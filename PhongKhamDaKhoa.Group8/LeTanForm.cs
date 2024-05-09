using PhongKham.RJControls;
using Repositories.Entities;
using System.Runtime.InteropServices;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Repositories;
using PhongKhamNhaKhoa;
using PhongKhamDaKhoa.Group8;
using Services;

namespace WinFormsApp4
{
    public partial class LeTanForm : Form
    {
        public LeTanForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        PhongkhamrhmContext _context = new PhongkhamrhmContext();
        LichHenService lhService = new LichHenService();
        BacSiService bsService = new BacSiService();
        BenhNhanService bnService = new BenhNhanService();


        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }

        private void LeTanForm_Load(object sender, EventArgs e)
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            foreach (var item in lhService.GetAll())
            {
                if (item.Ngayhen.Day == DateTime.Today.Day && item.Ngayhen.Month == DateTime.Today.Month && item.Ngayhen.Year == DateTime.Today.Year)
                {
                    string tenBS = bsService.GetBacsi(item.MaBs).Hoten;
                    string tenBN = bnService.Get(item.MaBn).Hoten;
                    list.Add(new Tuple<string, string>(tenBS, tenBN));
                }
                dgvLichKham.DataSource = list;
                dgvLichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLichKham.Columns["Item1"].HeaderText = "Bác sĩ";
                dgvLichKham.Columns["Item2"].HeaderText = "Bệnh nhân";
            }
        }

        private void btnThongTinNV_Click(object sender, EventArgs e)
        {
            QuanLyNSForm form = new QuanLyNSForm();
            form.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ThanhToanForm form = new ThanhToanForm();
            form.Show();
        }

        private void btnXemLichKham_Click(object sender, EventArgs e)
        {
            XemLichKhamForm form = new XemLichKhamForm();
            form.Show();
        }

        private void LeTanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DangNhapForm form = new DangNhapForm();
            form.Show();
        }

        private void btnXepLichLam_Click(object sender, EventArgs e)
        {
            XepLichLamForm form = new XepLichLamForm();
            form.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemTonKho_Click(object sender, EventArgs e)
        {
            QuanLyKhoForm form = new QuanLyKhoForm();
            form.Show();
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThuForm form = new ThongKeDoanhThuForm();
            form.Show();
        }

        private const int MaxWidth = 889;
        private const int MaxHeight = 624;

        private void LeTanForm_Resize(object sender, EventArgs e)
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
