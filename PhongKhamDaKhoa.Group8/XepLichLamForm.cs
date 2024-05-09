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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PhongKhamNhaKhoa
{
    public partial class XepLichLamForm : Form
    {
        private CaLamService _CaLamService = new();
        private BacSiService _BSService = new();
        private BenhNhanService _BNService = new();
        private PhuTaService _PTService = new();
        private DateOnly today;
        public XepLichLamForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void loadDataToGridView()
        {
            dgvDSLichLam.DataSource = null;
            today = DateOnly.FromDateTime(dtpUserSelect.Value);

            List<Calamviec> ListLichLamAfterFilter = _CaLamService.GetAll().Where(x => x.Ngay == today).ToList();
            dgvDSLichLam.DataSource = ListLichLamAfterFilter;

            dgvDSLichLam.Columns["MaBsNavigation"].Visible = false;
            dgvDSLichLam.Columns["MaPtNavigation"].Visible = false;

            dgvDSLichLam.Columns["MaCa"].HeaderText = "Mã lịch làm";
            dgvDSLichLam.Columns["MaBs"].HeaderText = "Mã bác sĩ";
            dgvDSLichLam.Columns["MaPt"].HeaderText = "Mã phụ tá";
            dgvDSLichLam.Columns["Ngay"].HeaderText = "Ngày làm việc";
            dgvDSLichLam.Columns["Ca"].HeaderText = "Ca làm";

            dgvDSLichLam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void resetInputField()
        {
            txtMaLL.Texts = "";
            txtTenBS.Texts = "";
            txtTenPT.Texts = "";
            txtCaLam.Texts = "";
            dtpNgayLamViec.Value = DateTime.Now;
        }

        private void XepLichLamForm_Load(object sender, EventArgs e)
        {
            loadDataToGridView();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateLichLamForm form = new();
            form.maLL = null;
            form.ShowDialog();
            loadDataToGridView();
            resetInputField();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLL.Texts))
            {
                MessageBox.Show("Vui lòng chọn lịch làm cần xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("Bạn có muốn xóa lịch làm này không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.ToString() == "Yes")
            {
                try
                {
                    _CaLamService.Delete(txtMaLL.Texts);
                    MessageBox.Show("Xóa lịch làm thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToGridView();
                    resetInputField();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có liên quan tới dữ liệu của phòng khám! Không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDSLichLam_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSLichLam.SelectedRows.Count > 0)
            {
                var selectedLL = (Calamviec)dgvDSLichLam.SelectedRows[0].DataBoundItem;
                // có trong tay 1 object / 1 cuốn sách đang được lựa chọn rồi
                // -> chấm từng field của nó và đổ vào form
                txtMaLL.Texts = selectedLL.MaCa.ToString();
                dtpNgayLamViec.Value = DateTime.Parse(selectedLL.Ngay.ToString());
                txtTenBS.Texts = _BSService.GetBacsi(selectedLL.MaBs).Hoten.Trim();
                txtTenPT.Texts = _PTService.GetPhuTa(selectedLL.MaPt).Hoten.Trim();
                txtKhoa.Texts = _BSService.GetBacsi(selectedLL.MaBs).MaKhoa.Trim();
                txtCaLam.Texts = selectedLL.Ca.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLL.Texts))
            {
                MessageBox.Show("Vui lòng chọn lịch làm cần chỉnh sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddUpdateLichLamForm form = new();
            form.maLL = txtMaLL.Texts;
            form.ShowDialog();
            loadDataToGridView();
            resetInputField();
        }

        private void btnPrevDay_Click_1(object sender, EventArgs e)
        {
            dtpUserSelect.Value = dtpUserSelect.Value.AddDays(-1);
            loadDataToGridView();
        }

        private void btnNextDay_Click_1(object sender, EventArgs e)
        {
            dtpUserSelect.Value = dtpUserSelect.Value.AddDays(1);
            loadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const int MaxWidth = 1211;
        private const int MaxHeight = 730;

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
