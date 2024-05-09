using PhongKhamNhaKhoa;
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
using WinFormsApp4;

namespace PhongKhamDaKhoa.Group8
{
    public partial class BacSiForm : Form
    {
        public string? sdt { get; set; }
        BacSiService bsService = new BacSiService();
        LichHenService lhService = new LichHenService();
        BenhNhanService bnService = new BenhNhanService();
        private System.Threading.Timer timer;

        public BacSiForm()
        {
            InitializeComponent();
            InitializeTimer();
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

        private void BacSiForm_Load(object sender, EventArgs e)
        {
            LoadDgvLichKham();
        }

        public void LoadDgvLichKham()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            if (this.sdt != null)
            {
                Bacsi? bacsi = bsService.GetByPhone(this.sdt);
                tenBS.Text = bacsi?.Hoten;

                foreach (var item in lhService.GetAll())
                {
                    if (item.MaBs == bacsi.MaBs && item.Ngayhen == new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day))
                    {
                        string tenBN = bnService.Get(item.MaBn).Hoten;
                        list.Add(new Tuple<string, string>(item.MaLh, tenBN));
                    }
                }
                // Sử dụng Invoke để cập nhật UI từ một thread khác
                this.Invoke(new Action(() =>
                {
                    dgvLichKham.DataSource = null;
                    dgvLichKham.DataSource = list;
                    dgvLichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvLichKham.Columns["Item1"].HeaderText = "Mã";
                    dgvLichKham.Columns["Item2"].HeaderText = "Bệnh nhân";
                }));
            }
        }

        private void btnToaThuoc_Click(object sender, EventArgs e)
        {
            if (sdt != null)
            {
                ToaThuocForm form = new ToaThuocForm();
                Bacsi? bacsi = bsService.GetByPhone(sdt);
                form.id = bacsi.MaBs;
                form.Show();
            }
        }

        private void BacSiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DangNhapForm form = new DangNhapForm();
            form.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemLichKham_Click(object sender, EventArgs e)
        {
            XemLichKhamForm form = new XemLichKhamForm();
            form.Show();
        }

        private void btnHoSoBenhAn_Click(object sender, EventArgs e)
        {
            HoSoBenhAnForm form = new HoSoBenhAnForm();
            Bacsi? bacsi = bsService.GetByPhone(sdt);
            form.id = bacsi.MaBs;
            form.Show();
        }

        private void btnKyThuat_Click(object sender, EventArgs e)
        {
            KyThuatForm form = new KyThuatForm();
            Bacsi? bacsi = bsService.GetByPhone(sdt);
            form.id = bacsi.MaBs;
            form.Show();
        }

        private void btnVLTH_Click(object sender, EventArgs e)
        {
            VatLieuTieuHaoForm form = new();
            Bacsi? bacsi = bsService.GetByPhone(sdt);
            form.id = bacsi.MaBs;
            form.Show();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (dgvLichKham.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLichKham.SelectedRows[0];
                string? maLH = row.Cells["Item1"].Value.ToString();

                if (maLH != null)
                {
                    lhService.Delete(maLH);
                }
                LoadDgvLichKham();
            }
        }

        private void btnMhLK_Click(object sender, EventArgs e)
        {
            DanhSachLichKhamForm form = new();
            form.sdt = sdt;
            form.Show();
        }

        //Cập nhật lại dgv
        private void InitializeTimer()
        {
            // Khởi tạo Timer và cấu hình
            timer = new System.Threading.Timer(TimerCallback, null, 0, 2000); // 2 giây
        }

        private void TimerCallback(object state)
        {
            // Thực hiện hành động cần thiết khi Timer chạy
            LoadDgvLichKham();
        }

        private void DanhSachLichKhamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dừng Timer khi form đóng lại để tránh lỗi
            timer.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private const int MaxWidth = 894;
        private const int MaxHeight = 646;

        private void BacSiForm_Resize(object sender, EventArgs e)
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
