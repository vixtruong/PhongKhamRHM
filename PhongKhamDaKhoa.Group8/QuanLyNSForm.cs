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

namespace WinFormsApp4
{
    public partial class QuanLyNSForm : Form
    {
        public QuanLyNSForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private LeTanService _ltService = new LeTanService();
        private BacSiService _bsService = new BacSiService();
        private PhuTaService _ptService = new PhuTaService();

        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }

        private void QuanLyNSForm_Load(object sender, EventArgs e)
        {
            //Letan
            List<Letan> ltList = _ltService.GetAll();
            RefreshDgvListLT(ltList);

            //Bacsi
            List<Bacsi> bsList = _bsService.GetAll();
            RefreshDgvListBS(bsList);

            List<Phuta> ptList = _ptService.GetAll();
            RefreshDgvListPT(ptList);
        }

        //Start Letan
        private void RefreshDgvListLT(List<Letan> result)
        {
            dgvListLT.DataSource = null;
            dgvListLT.DataSource = result;
            dgvListLT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListLT.Columns["Malt"].HeaderText = "ID";
            dgvListLT.Columns["Hoten"].HeaderText = "Họ tên";
            dgvListLT.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dgvListLT.Columns["Ngaylamviec"].HeaderText = "Ngày vào làm";
            dgvListLT.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgvListLT.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgvListLT.Columns["Hoadons"].Visible = false;
        }

        private void btnAddLT_Click(object sender, EventArgs e)
        {
            AddLeTanForm form = new AddLeTanForm();
            form.ShowDialog();

            var result = _ltService.GetAll();
            RefreshDgvListLT(result);
        }

        private void dgvListLT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListLT.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListLT.SelectedRows[0];
                
                txtNameLT.Texts = seclectedRow.Cells["Hoten"].Value.ToString();
                dtpBirthdayLT.Text = seclectedRow.Cells["Ngaysinh"].Value.ToString();
                dtpBirthdayLT.Visible = false;
                dtpBirthdayLT.Visible = true;
                dtpDateWorkingLT.Text = seclectedRow.Cells["Ngaylamviec"].Value.ToString();
                dtpDateWorkingLT.Visible = false;
                dtpDateWorkingLT.Visible = true;
                string gioitinh = seclectedRow.Cells["gioitinh"].Value.ToString();
                if (seclectedRow.Cells["Sdt"].Value == null)
                {
                    txtPhoneLT.Texts = "";
                }
                else
                {
                    txtPhoneLT.Texts = seclectedRow.Cells["Sdt"].Value.ToString();
                }

                if (gioitinh.ToLower().Equals("Nam".ToLower()))
                {
                    chkMaleLT.Checked = true;
                    chkFemaleLT.Checked = false;
                }
                else
                {
                    chkMaleLT.Checked = false;
                    chkFemaleLT.Checked = true;
                }
            }
        }

        private void btnSearchLT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindIDLT.Texts))
            {
                MessageBox.Show("Ô tìm kiếm trống! Vui lòng nhập thông tin cần tìm!", "Yêu cầu tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = _ltService.SearchLeTan(txtFindIDLT.Texts.Trim());

            RefreshDgvListLT(result);
        }

        private void btnDeleteLT_Click(object sender, EventArgs e)
        {
            string id;
            if (string.IsNullOrWhiteSpace(txtNameLT.Texts))
            {
                MessageBox.Show("Không có gì để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvListLT.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListLT.SelectedRows[0];
                id = seclectedRow.Cells["Malt"].Value.ToString();

                DialogResult deleteResult = MessageBox.Show($"Bạn chắn chắn muốn xóa Lễ tân {id}?", "Xóa thông tin",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteResult == DialogResult.No)
                    return;

                try
                {
                    _ltService.DeleteLeTan(id);
                    var result = _ltService.GetAll();
                    RefreshDgvListLT(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lễ tân có liên quan tới dữ liệu của phòng khám! Không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateLT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameLT.Texts))
            {
                MessageBox.Show("Không có gì để cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string selectedId;

            if (dgvListLT.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListLT.SelectedRows[0];
                selectedId = seclectedRow.Cells["Malt"].Value.ToString();
                UpdateLeTanForm form = new UpdateLeTanForm();
                form.id = selectedId;
                form.ShowDialog();
                var result = _ltService.GetAll();
                RefreshDgvListLT(result);
            }
        }
        // End Letan

        // Start Bacsi
        private void RefreshDgvListBS(List<Bacsi> result)
        {
            dgvListBS.DataSource = null;
            dgvListBS.DataSource = result;
            dgvListBS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListBS.Columns["Mabs"].HeaderText = "ID";
            dgvListBS.Columns["Hoten"].HeaderText = "Họ tên";
            dgvListBS.Columns["MaKhoa"].HeaderText = "Khoa";
            dgvListBS.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dgvListBS.Columns["Ngaylamviec"].HeaderText = "Ngày vào làm";
            dgvListBS.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgvListBS.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgvListBS.Columns["Calamviecs"].Visible = false;
            dgvListBS.Columns["Phieukhambenhs"].Visible = false;
            dgvListBS.Columns["Lichhens"].Visible = false;
        }

        private void btnAddBS_Click(object sender, EventArgs e)
        {
            AddBacSiForm form = new AddBacSiForm();
            form.ShowDialog();

            var result = _bsService.GetAll();
            RefreshDgvListBS(result);
        }

        private void dgvListBS_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListBS.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListBS.SelectedRows[0];

                txtNameBS.Texts = seclectedRow.Cells["Hoten"].Value.ToString();
                txtKhoa.Texts = seclectedRow.Cells["MaKhoa"].Value.ToString();
                string[] time = seclectedRow.Cells["Ngaysinh"].Value.ToString().Split("/");
                dtpBirthdayBS.Value = new DateTime(int.Parse(time[2]), int.Parse(time[1]), int.Parse(time[0]));
                dtpBirthdayBS.Visible = false;
                dtpBirthdayBS.Visible = true;
                dtpDateWorkingBS.Text = seclectedRow.Cells["Ngaylamviec"].Value.ToString();
                dtpDateWorkingBS.Visible = false;
                dtpDateWorkingBS.Visible = true;
                string gioitinh = seclectedRow.Cells["gioitinh"].Value.ToString();
                if (seclectedRow.Cells["Sdt"].Value == null)
                {
                    txtPhoneBS.Texts = "";
                }
                else
                {
                    txtPhoneBS.Texts = seclectedRow.Cells["Sdt"].Value.ToString();
                }

                if (gioitinh.ToLower().Equals("Nam".ToLower()))
                {
                    chkMaleBS.Checked = true;
                }
                else
                {
                    chkFemaleBS.Checked = true;
                }
            }
        }

        private void btnSeacrhBS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindIDBS.Texts))
            {
                MessageBox.Show("Ô tìm kiếm trống! Vui lòng nhập thông tin cần tìm!", "Yêu cầu tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = _bsService.SearchBacSi(txtFindIDBS.Texts.Trim());

            RefreshDgvListBS(result);
        }

        private void btnDeleteBS_Click(object sender, EventArgs e)
        {
            string id;
            if (string.IsNullOrWhiteSpace(txtNameBS.Texts))
            {
                MessageBox.Show("Không có gì để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvListBS.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListBS.SelectedRows[0];
                id = seclectedRow.Cells["Mabs"].Value.ToString();

                DialogResult deleteResult = MessageBox.Show($"Bạn chắn chắn muốn xóa Lễ tân {id}?", "Xóa thông tin",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteResult == DialogResult.No)
                    return;

                try
                {
                    _bsService.DeleteBacSi(id);

                    var result = _bsService.GetAll();
                    RefreshDgvListBS(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bác sĩ có liên quan tới dữ liệu của phòng khám! Không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateBS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameBS.Texts))
            {
                MessageBox.Show("Không có gì để cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string selectedId;

            if (dgvListBS.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListBS.SelectedRows[0];
                selectedId = seclectedRow.Cells["Mabs"].Value.ToString();
                UpdateBacSiForm form = new UpdateBacSiForm();
                form.id = selectedId;
                form.ShowDialog();
                var result = _bsService.GetAll();
                RefreshDgvListBS(result);
            }
        }
        //End Bacsi

        //Start Phuta
        private void RefreshDgvListPT(List<Phuta> result)
        {
            dgvListPT.DataSource = null;
            dgvListPT.DataSource = result;
            dgvListPT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListPT.Columns["Mapt"].HeaderText = "ID";
            dgvListPT.Columns["Hoten"].HeaderText = "Họ tên";
            dgvListPT.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dgvListPT.Columns["Ngaylamviec"].HeaderText = "Ngày vào làm";
            dgvListPT.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgvListPT.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgvListPT.Columns["Calamviecs"].Visible = false;
        }

        private void btnAddPT_Click(object sender, EventArgs e)
        {
            AddPhuTaForm form = new AddPhuTaForm();
            form.ShowDialog();

            var result = _ptService.GetAll();
            RefreshDgvListPT(result);
        }

        private void dgvListPT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListPT.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListPT.SelectedRows[0];

                txtNamePT.Texts = seclectedRow.Cells["Hoten"].Value.ToString();
                dtpBirthdayPT.Text = seclectedRow.Cells["Ngaysinh"].Value.ToString();
                dtpBirthdayPT.Visible = false;
                dtpBirthdayPT.Visible = true;
                dtpDateWorkingPT.Text = seclectedRow.Cells["Ngaylamviec"].Value.ToString();
                dtpDateWorkingPT.Visible = false;
                dtpDateWorkingPT.Visible = true;
                string gioitinh = seclectedRow.Cells["gioitinh"].Value.ToString();
                if (seclectedRow.Cells["Sdt"].Value == null)
                {
                    txtPhonePT.Texts = "";
                }
                else
                {
                    txtPhonePT.Texts = seclectedRow.Cells["Sdt"].Value.ToString();
                }

                if (gioitinh.ToLower().Equals("Nam".ToLower()))
                {
                    chkMalePT.Checked = true;
                }
                else
                {
                    chkFemalePT.Checked = true;
                }
            }
        }

        private void btnSearchPT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindIDPT.Texts))
            {
                MessageBox.Show("Ô tìm kiếm trống! Vui lòng nhập thông tin cần tìm!", "Yêu cầu tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = _ptService.SearchPhuTa(txtFindIDBS.Texts.Trim());

            RefreshDgvListPT(result);
        }

        private void btnDeletePT_Click(object sender, EventArgs e)
        {
            string id;
            if (string.IsNullOrWhiteSpace(txtNamePT.Texts))
            {
                MessageBox.Show("Không có gì để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvListPT.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListPT.SelectedRows[0];
                id = seclectedRow.Cells["Mapt"].Value.ToString();

                DialogResult deleteResult = MessageBox.Show($"Bạn chắn chắn muốn xóa Phụ tá {id}?", "Xóa thông tin",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteResult == DialogResult.No)
                    return;

                try
                {
                    _ptService.DeletePhuTa(id);

                    var result = _ptService.GetAll();
                    RefreshDgvListPT(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phụ tá có liên quan tới dữ liệu của phòng khám! Không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdatePT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamePT.Texts))
            {
                MessageBox.Show("Không có gì để cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string selectedId;

            if (dgvListPT.SelectedRows.Count > 0)
            {
                DataGridViewRow seclectedRow = dgvListPT.SelectedRows[0];
                selectedId = seclectedRow.Cells["Mapt"].Value.ToString();
                UpdatePhuTaForm form = new UpdatePhuTaForm();
                form.id = selectedId;
                form.ShowDialog();
                var result = _ptService.GetAll();
                RefreshDgvListPT(result);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMaleLT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaleLT.Checked)
            {
                chkFemaleLT.Checked = false;
            }
        }

        private void chkMaleBS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaleBS.Checked)
            {
                chkFemaleBS.Checked = false;
            }
        }

        private void chkMalePT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaleBS.Checked)
            {
                chkFemaleLT.Checked = false;
            }
        }

        private void chkFemaleLT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemaleLT.Checked)
            {
                chkMaleLT.Checked = false;
            }
        }

        private void chkFemaleBS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemaleBS.Checked)
            {
                chkMaleBS.Checked = false;
            }
        }

        private void chkFemalePT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemalePT.Checked)
            {
                chkMalePT.Checked = false;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private const int MaxWidth = 1244;
        private const int MaxHeight = 796;

        private void Form_Resize(object sender, EventArgs e)
        {
            if(this.Width > MaxWidth || this.Width < MaxWidth)
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
