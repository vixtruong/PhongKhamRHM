using PhongKhamDaKhoa.Group8;
using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKhamNhaKhoa
{
    public partial class AddUpdateLichKham : Form
    {
        // Biến lưu ID của Lịch hẹn cần update
        public string MaLH { get; set; }
        public string MaBN { get; set; }
        private BenhNhanService _BNService = new();
        private BacSiService _BSService = new();
        private LichHenService _LHService = new();
        private CaLamService _CaLamService = new();
        private PhieuKhamBenhService pkbService = new();
        private KhoaService khoaService = new();
        public delegate void TruyenDuLieu(List<Lichhen> list);
        public TruyenDuLieu truyenData;

        public AddUpdateLichKham()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBN.Texts))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSDT.Texts.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNhuCauKham.Texts))
            {
                MessageBox.Show("Vui lòng nhập nhu cầu khám", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MaBN == null)
            {
                string newMaBN = _BNService.GenerateMaBN();
                Benhnhan benhnhanmoi = new Benhnhan()
                {
                    MaBn = newMaBN,
                    Hoten = txtTenBN.Texts.Trim(),
                    Ngaysinh = DateOnly.FromDateTime(dtpNgaySinhBN.Value),
                    Sdt = txtSDT.Texts.Trim(),
                };
                if (_BNService.getMaBNBySDT(benhnhanmoi.Sdt) != null)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _BNService.Add(benhnhanmoi);

                Lichhen lichhen = new Lichhen()
                {
                    MaLh = _LHService.GenerateMaLH(),
                    MaBn = benhnhanmoi.MaBn,
                    MaBs = cboTenBS.SelectedValue.ToString(),
                    LoaiBenhNhan = cboLoaiBN.Text == "Bệnh nhân đặt lịch" ? "1" : "0",
                    Ngayhen = DateOnly.FromDateTime(dtpLichHen.Value),
                    Nhucaukham = txtNhuCauKham.Texts.Trim(),
                };
                _LHService.Add(lichhen);
                
                MessageBox.Show("Thêm lịch hẹn mới thành công!!!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (truyenData != null)
                {
                    truyenData(_LHService.GetAll());
                }

                this.Close();
                return;
            }

            Lichhen updateLH = _LHService.Get(MaLH);
            updateLH.Ngayhen = DateOnly.FromDateTime(dtpLichHen.Value);
            updateLH.MaBn = MaBN;
            updateLH.MaBs = cboTenBS.SelectedValue.ToString();
            updateLH.LoaiBenhNhan = cboLoaiBN.Text.Trim() == "Bệnh nhân đặt lịch" ? "1" : "0";
            updateLH.Nhucaukham = txtNhuCauKham.Texts.Trim();
            _LHService.Update(updateLH);

            Benhnhan benhnhan = new Benhnhan()
            {
                MaBn = MaBN,
                Hoten = txtTenBN.Texts.Trim(),
                Ngaysinh = DateOnly.FromDateTime(dtpNgaySinhBN.Value),
                Sdt = txtSDT.Texts.Trim(),
            };
            _BNService.Update(benhnhan);
            MessageBox.Show("Cập nhật lịch hẹn thành công!!!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // HÀM LẤY RA NHỮNG BÁC SĨ CÓ LỊCH LÀM VIỆC TRÙNG KHỚP VỚI NGÀY LỊCH HẸN  
        private List<Bacsi> GetBacSiWorkInDay()
        {
            DateTime ngayKham = dtpLichHen.Value;

            // Danh sách lưu mã bác sĩ có lịch làm việc trong ngày đó
            List<string> ListMaBS = _CaLamService.GetAllMaBS(ngayKham);

            List<Bacsi> result = new List<Bacsi>();
            foreach (string maBS in ListMaBS)
            {
                result.Add(_BSService.GetBacsi(maBS));
            }

            return result;
        }

        private void AddUpdateLichKham_Load(object sender, EventArgs e)
        {
            cboLoaiBN.DataSource = new List<string>
            {
                "Bệnh nhân thường",
                "Bệnh nhân đặt lịch"
            };

            var khoaList = new List<string>();
            foreach (var khoa in khoaService.GetAll())
            {
                khoaList.Add(khoa.MaKhoa);
            }
            cbKhoa.DataSource = khoaList;
            var bacSiWorkInDay = GetBacSiWorkInDay().Where(x => x.MaKhoa == cbKhoa.Text).ToList(); // Lấy danh sách bác sĩ làm việc trong ngày và trong khoa đã chọn
            cboTenBS.DataSource = bacSiWorkInDay.Any() ? bacSiWorkInDay : null; // Nếu có bác sĩ, gán danh sách vào DataSource, ngược lại gán null
            cboTenBS.DisplayMember = "Hoten";
            cboTenBS.ValueMember = "MaBs";

            // UPDATE MODE
            if (MaLH != null)
            {
                Lichhen updateLH = _LHService.Get(MaLH);
                dtpLichHen.Text = updateLH.Ngayhen.ToString();
                txtTenBN.Texts = _BNService.Get(updateLH.MaBn).Hoten.Trim();
                dtpNgaySinhBN.Value = DateTime.Parse(_BNService.Get(updateLH.MaBn).Ngaysinh.ToString());
                cboLoaiBN.Text = updateLH.LoaiBenhNhan == "1" ? "Bệnh nhân đặt lịch" : "Bệnh nhân thường";
                cbKhoa.Text = _BSService.GetBacsi(updateLH.MaBs).MaKhoa;
                cboTenBS.Text = _BSService.GetBacsi(updateLH.MaBs).Hoten;
                txtNhuCauKham.Texts = updateLH.Nhucaukham;
                txtSDT.Texts = _BNService.Get(updateLH.MaBn).Sdt;
                lblTitle.Text = "Cập nhật lịch khám";
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Kiểm tra xem ký tự được nhập vào có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hủy ký tự được nhập vào
                e.Handled = true;
            }
        }

        private void AddUpdateLichKham_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Khi form được đóng lại, kiểm tra xem form cha (XemLichKhamForm) có tồn tại không
            if (Owner != null && Owner is XemLichKhamForm)
            {
                // Ép kiểu form cha về XemLichKhamForm để truy cập các phương thức và thuộc tính của nó
                XemLichKhamForm parentForm = (XemLichKhamForm)Owner;

                // Gọi phương thức loadDataToGridView() của form cha để load lại dữ liệu vào DataGridView
                parentForm.loadDataToGridView();
            }
        }

        private void dtpLichHen_ValueChanged(object sender, EventArgs e)
        {
            cboTenBS.Text = "";
            cboTenBS.DataSource = GetBacSiWorkInDay().Where(x => x.MaKhoa == cbKhoa.Text).ToList();
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            cboTenBS.DataSource = GetBacSiWorkInDay().Where(x => x.MaKhoa == cbKhoa.Text).ToList();
            if (GetBacSiWorkInDay().Where(x => x.MaKhoa == cbKhoa.Text).ToList().Count == 0)
            {
                cboTenBS.Text = "";
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }

        private const int MaxWidth = 511;
        private const int MaxHeight = 679;

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.Width > MaxWidth)
            {
                this.Width = MaxWidth;
            }
            if (this.Height > MaxHeight)
            {
                this.Height = MaxHeight;
            }
        }
    }
}
