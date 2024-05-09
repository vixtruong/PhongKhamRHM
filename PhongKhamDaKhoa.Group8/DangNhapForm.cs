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
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanService service = new TaiKhoanService();

            string username = txtUsername.Texts;
            string password = txtPassword.Texts;

            Taikhoan account = service.CheckLogin(username, password);
            if (account == null)
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin đăng nhập!",
                    "Thông tin đăng nhập chưa chính xác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (account.Chucvu == "LT")
            {
                LeTanForm leTanForm = new LeTanForm();
                leTanForm.Show();
            }
            else if (account.Chucvu == "BS")
            {
                BacSiForm bacSiForm = new BacSiForm();
                bacSiForm.sdt = username;
                bacSiForm.Show();
            }
            else
            {
                return;
            }

            this.Hide();
        }

        private void lblinkDangKi_Click(object sender, EventArgs e)
        {
            DangKyForm form = new DangKyForm();
            form.Show();
        }

        private void lblinkQuenMK_Click(object sender, EventArgs e)
        {
            QuenMatKhauForm form = new QuenMatKhauForm();
            form.sdt = txtUsername.Text;
            form.Show();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b') // '\b' là kí tự của phím backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Ngăn không cho nhập các kí tự khác
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private const int MaxWidth = 776;
        private const int MaxHeight = 642;

        private void DangNhapForm_Resize(object sender, EventArgs e)
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
