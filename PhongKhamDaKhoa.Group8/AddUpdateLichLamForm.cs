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
    public partial class AddUpdateLichLamForm : Form
    {
        public string maLL { get; set; }
        private KhoaService khoaService = new();
        private BacSiService _BsService = new();
        private PhuTaService _PhuTaService = new();
        private CaLamService _CaLamService = new();
        private int CA_LAM_TOI_DA = 10;
        public AddUpdateLichLamForm()
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
            if (string.IsNullOrEmpty(txtCaLam.Texts))
            {
                MessageBox.Show("Vui lòng nhập ca làm việc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte caLamViecNumber;

            if (!byte.TryParse(txtCaLam.Texts, out caLamViecNumber))
            {
                MessageBox.Show("Ca làm không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (caLamViecNumber <= 0 || caLamViecNumber > CA_LAM_TOI_DA)
            {
                MessageBox.Show("Vui lòng nhập ca làm việc hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (maLL == null)
            {
                Calamviec caLam = new Calamviec()
                {
                    MaCa = _CaLamService.GenerateMaLL(),
                    MaBs = cboTenBS.SelectedValue.ToString(),
                    MaPt = cboTenPT.SelectedValue.ToString(),
                    Ca = caLamViecNumber,
                    Ngay = DateOnly.FromDateTime(dtpNgayLamViec.Value),
                };
                _CaLamService.Add(caLam);
                MessageBox.Show("Thêm ca làm mới thành công!!!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Calamviec updatedCaLam = _CaLamService.Get(txtMaLL.Text);
                updatedCaLam.Ngay = DateOnly.FromDateTime(dtpNgayLamViec.Value);
                updatedCaLam.MaBs = cboTenBS.SelectedValue.ToString();
                updatedCaLam.MaPt = cboTenPT.SelectedValue.ToString();
                updatedCaLam.Ca = caLamViecNumber;
                _CaLamService.Update(updatedCaLam);
                MessageBox.Show("Cập nhật lịch làm thành công!!!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void AddUpdateLichLamForm_Load(object sender, EventArgs e)
        {
            var khoaList = new List<string>();
            foreach (var khoa in khoaService.GetAll())
            {
                khoaList.Add(khoa.MaKhoa);
            }
            cbKhoa.DataSource = khoaList;

            cboTenBS.DataSource = _BsService.GetAll().Where(x => x.MaKhoa == cbKhoa.Text).ToList();
            cboTenBS.DisplayMember = "Hoten";
            cboTenBS.ValueMember = "MaBs";

            cboTenPT.DataSource = _PhuTaService.GetAll();
            cboTenPT.DisplayMember = "Hoten";
            cboTenPT.ValueMember = "MaPt";

            if (maLL != null)
            {
                Calamviec updateLL = _CaLamService.Get(maLL);
                txtMaLL.Texts = updateLL.MaCa.ToString();
                dtpNgayLamViec.Value = DateTime.Parse(updateLL.Ngay.ToString());
                cboTenBS.Text = _BsService.GetBacsi(updateLL.MaBs).Hoten.Trim();
                cboTenPT.Text = _PhuTaService.GetPhuTa(updateLL.MaPt).Hoten.Trim();
                cbKhoa.Text = _BsService.GetBacsi(updateLL.MaBs).MaKhoa.Trim();
                txtCaLam.Texts = updateLL.Ca.ToString();
                lblTitle.Text = "Cập nhật lịch làm việc";
            }
        }

        private void txtCaLam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            var bsList = _BsService.GetAll().Where(x => x.MaKhoa == cbKhoa.Text).ToList();
            cboTenBS.DataSource = bsList;
            if (bsList.Count == 0)
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

        private const int MaxWidth = 500;
        private const int MaxHeight = 603;

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.Width > MaxWidth || this.Width < MaxWidth)
            {
                this.Width = MaxWidth;
            }
            if (this.Height > MaxHeight || this.Height < MaxHeight)
            {
                this.Height = MaxHeight;
            }
        }
    }
}
