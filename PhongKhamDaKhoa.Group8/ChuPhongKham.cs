using PhongKhamNhaKhoa;
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
    public partial class ChuPhongKham : Form
    {
        public ChuPhongKham()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThuForm form = new ThongKeDoanhThuForm();
            form.Show();
        }

        private void btnXepLichLam_Click(object sender, EventArgs e)
        {
            XepLichLamForm form = new XepLichLamForm();
            form.Show();
        }

        private void btnXemTonKho_Click(object sender, EventArgs e)
        {
            QuanLyKhoForm form = new QuanLyKhoForm();
            form.Show();
        }

        private void ChuPhongKhamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DangNhapForm form = new DangNhapForm();
            form.Show();
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private const int MaxWidth = 889;
        private const int MaxHeight = 624;

        private void ChuPhongKham_Resize(object sender, EventArgs e)
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
