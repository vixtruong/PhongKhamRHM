using Repositories;
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
using System.Windows.Documents;
using System.Windows.Forms;

namespace PhongKhamDaKhoa.Group8
{
    public partial class QuanLyKhoForm : Form
    {
        ThuocService thuocService = new ThuocService();
        VatLieuService vlService = new VatLieuService();
        ViTriBenhService vtbService = new ViTriBenhService();
        PhongkhamrhmContext _context = new PhongkhamrhmContext();

        public QuanLyKhoForm()
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

        private void QuanLyKhoForm_Load(object sender, EventArgs e)
        {
            List<string> listVP = new List<string>()
            {
                "Thuốc",
                "Vật liệu"
            };
            cbLoaiVP.DataSource = listVP;
            dgvVP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadListThuoc(List<Thuoc> list)
        {
            dgvVP.DataSource = null;
            dgvVP.DataSource = list;
            dgvVP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVP.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dgvVP.Columns["Tenthuoc"].HeaderText = "Tên thuốc";
            dgvVP.Columns["Soluong"].HeaderText = "Số lượng";
            dgvVP.Columns["Dvt"].HeaderText = "Đơn vị tính";
            dgvVP.Columns["Gia"].HeaderText = "Giá";
            dgvVP.Columns["Chitiettoathuocs"].Visible = false;
        }

        private void LoadListVatLieu(List<Vatlieu> list)
        {
            dgvVP.DataSource = null;
            dgvVP.DataSource = list;
            dgvVP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVP.Columns["MaVl"].HeaderText = "Mã Vật liệu";
            dgvVP.Columns["TenVl"].HeaderText = "Tên Vật liệu";
            dgvVP.Columns["Soluong"].HeaderText = "Số lượng";
            dgvVP.Columns["Dvt"].HeaderText = "Đơn vị tính";
            dgvVP.Columns["Gia"].HeaderText = "Giá";
            dgvVP.Columns["Chitietvatlieutieuhaos"].Visible = false;
        }

        private void cbLoaiVP_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiVP.SelectedIndex == 0)
            {
                List<Thuoc> list = thuocService.GetAll();
                LoadListThuoc(list);
            }
            else if (cbLoaiVP.SelectedIndex == 1)
            {
                List<Vatlieu> list = vlService.GetAll();
                LoadListVatLieu(list);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có gì để xóa!", "Null Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vp = cbLoaiVP.Text;
            if (vp == "Thuốc")
            {
                DataGridViewRow seclectedRow = dgvVP.SelectedRows[0];
                string id = seclectedRow.Cells["MaThuoc"].Value.ToString();

                DialogResult deleteResult = MessageBox.Show($"Bạn chắc chắn muốn xóa?", "Xóa thông tin",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteResult == DialogResult.No)
                    return;

                try
                {
                    thuocService.DeleteThuoc(id);
                    var newList = thuocService.GetAll();
                    LoadListThuoc(newList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thuốc có liên quan tới dữ liệu của phòng khám! Không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (vp == "Vật liệu")
            {
                DataGridViewRow seclectedRow = dgvVP.SelectedRows[0];
                string id = seclectedRow.Cells["MaVl"].Value.ToString();

                DialogResult deleteResult = MessageBox.Show($"Bạn chắc chắn muốn xóa?", "Xóa thông tin",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteResult == DialogResult.No)
                    return;

                try
                {
                    vlService.Delete(id);
                    var newList = vlService.GetAll();
                    LoadListVatLieu(newList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vật liệu có liên quan tới dữ liệu của phòng khám! Không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddVatLieuForm form = new AddVatLieuForm();
            form.ShowDialog();
            if (cbLoaiVP.Text == "Thuốc")
            {
                var result1 = thuocService.GetAll();
                LoadListThuoc(result1);
                return;
            }
            var result = vlService.GetAll();
            LoadListVatLieu(result);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvVP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có gì để cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string selectedId;

            if (dgvVP.SelectedRows.Count > 0)
            {
                if (cbLoaiVP.Text == "Thuốc")
                {
                    DataGridViewRow seclectedRow = dgvVP.SelectedRows[0];
                    selectedId = seclectedRow.Cells["MaThuoc"].Value.ToString();
                    UpdateVatLieuForm form = new UpdateVatLieuForm();
                    form.id = selectedId;
                    form.ShowDialog();
                    var result = thuocService.GetAll();
                    LoadListThuoc(result);
                }

                if (cbLoaiVP.Text == "Vật liệu")
                {
                    DataGridViewRow seclectedRow = dgvVP.SelectedRows[0];
                    selectedId = seclectedRow.Cells["MaVl"].Value.ToString();
                    UpdateVatLieuForm form = new UpdateVatLieuForm();
                    form.id = selectedId;
                    form.ShowDialog();
                    var result = vlService.GetAll();
                    LoadListVatLieu(result);
                }
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            NhapKhoForm form = new NhapKhoForm();
            form.ShowDialog();
            if (cbLoaiVP.Text == "Thuốc")
            {
                var result1 = thuocService.GetAll();
                LoadListThuoc(result1);
                return;
            }
            var result = vlService.GetAll();
            LoadListVatLieu(result);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchLT_Click(object sender, EventArgs e)
        {
            string tenVP = txtTimkiem.Texts;

            if (cbLoaiVP.Text == "Thuốc" && !string.IsNullOrEmpty(tenVP))
            {
                List<Thuoc> list = new List<Thuoc>();
                foreach (var item in thuocService.GetAll())
                {
                    if (item.Tenthuoc.ToLower().Contains(tenVP.ToLower()))
                    {
                        list.Add(item);
                    }
                }
                LoadListThuoc(list);
            }

            if (cbLoaiVP.Text == "Vật liệu" && !string.IsNullOrEmpty(tenVP))
            {
                List<Vatlieu> list = new List<Vatlieu>();
                foreach (var item in vlService.GetAll())
                {
                    if (item.TenVl.ToLower().Contains(tenVP.ToLower()))
                    {
                        list.Add(item);
                    }
                }
                LoadListVatLieu(list);
            }
        }

        private const int MaxWidth = 784;
        private const int MaxHeight = 700;

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
