using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKhamDaKhoa.Group8
{
    public partial class HoSoBenhAnForm : Form
    {
        public string id {  get; set; }
        HoSoBenhAnService hsService = new();
        BenhNhanService bnService = new();
        BacSiService bsService = new();

        public HoSoBenhAnForm()
        {
            InitializeComponent();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }

        private void HoSoBenhAn_Load(object sender, EventArgs e)
        {
            if (id != null)
            { 
                lbHoten.Text = bsService.GetBacsi(id).Hoten;
            }
            List<Hosobenhan> list = hsService.GetAll();
            LoadDgvListHS(list);
        }

        private void txtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Texts;
            if (hsService.GetByMaBN(maBN) == null)
            {
                MessageBox.Show("Bệnh nhân không tồn tại hoặc chưa có hồ sơ bệnh án nào!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Hosobenhan> list = hsService.SearchByMaBN(maBN);
            LoadDgvListHS(list);
        }

        private void LoadDgvListHS(List<Hosobenhan> list)
        {
            dgvListBA.DataSource = null;
            dgvListBA.DataSource = list;
            dgvListBA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tính toán độ rộng cho từng cột
            int totalWidth = dgvListBA.Width;
            int tinhTrangWidth = totalWidth * 4 / 6; // 4 phần
            int otherColumnWidth = totalWidth / 6; // 1 phần

            // Thiết lập độ rộng cho từng cột
            dgvListBA.Columns["Tinhtrang"].Width = tinhTrangWidth;
            dgvListBA.Columns["MaBn"].Width = otherColumnWidth;
            dgvListBA.Columns["Solankham"].Width = otherColumnWidth;

            // Ẩn cột MaHs và MaHsNavigation nếu cần
            dgvListBA.Columns["MaHs"].Visible = false;
            dgvListBA.Columns["MaBnNavigation"].Visible = false;

            // Đặt lại tiêu đề cho cột MaBn và Solankham
            dgvListBA.Columns["MaBn"].HeaderText = "Mã BN";
            dgvListBA.Columns["Solankham"].HeaderText = "Lần khám";
            dgvListBA.Columns["Tinhtrang"].HeaderText = "Tình trạng";
        }

        private void dgvListBA_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListBA.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvListBA.SelectedRows[0];
                string maBN = row.Cells["Mabn"].Value.ToString();

                Benhnhan bn = bnService.Get(maBN);

                txtHoten.Texts = bn.Hoten;
                dtpNgaysinh.Text = bn.Ngaysinh.ToString();
                dtpNgaysinh.Visible = false;
                dtpNgaysinh.Visible = true;
                txtTinhtrang.Text = row.Cells["Tinhtrang"].Value.ToString().Trim();
            }
        }

        private void btnAddLT_Click(object sender, EventArgs e)
        {
            AddHoSoBenhAnForm form = new AddHoSoBenhAnForm();
            form.ShowDialog();

            var list = hsService.GetAll();
            LoadDgvListHS(list);
        }

        private void btnUpdateLT_Click(object sender, EventArgs e)
        {
            if (dgvListBA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh án để sửa!", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = dgvListBA.SelectedRows[0];
            string maBN = row.Cells["MaBn"].Value.ToString();
            short lankham = (short)row.Cells["Solankham"].Value;

            UpdateHoSoBenhAnForm form = new UpdateHoSoBenhAnForm();
            foreach (var ba in hsService.GetAll())
            {
                if (ba.MaBn == maBN && ba.Solankham == lankham)
                {
                    form.maBA = ba.MaHs;
                    form.ShowDialog();

                    var list = hsService.GetAll();
                    LoadDgvListHS(list);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListBA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh án cần xóa!", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvListBA.SelectedRows[0];
            string maBN = row.Cells["MaBn"].Value.ToString();
            short lankham = (short)row.Cells["Solankham"].Value;

            UpdateHoSoBenhAnForm form = new UpdateHoSoBenhAnForm();
            foreach (var ba in hsService.GetAll())
            {
                if (ba.MaBn == maBN && ba.Solankham == lankham)
                {
                    hsService.Delete(ba.MaHs);
                    DialogResult deleteResult = MessageBox.Show("Bạn chắc chắn muốn xóa bệnh án này?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteResult == DialogResult.No)
                        return;

                    hsService.Delete(ba.MaHs);
                    LoadDgvListHS(hsService.GetAll());
                }
            }
        }
    }
}
