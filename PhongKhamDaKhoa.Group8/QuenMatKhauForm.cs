using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Repositories.Entities;
using Microsoft.Identity.Client.NativeInterop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;

namespace PhongKhamDaKhoa.Group8
{
    public partial class QuenMatKhauForm : Form
    {
        public string sdt { get; set; }

        String randomCode;
        public static String to;
        Regex regex = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

        public QuenMatKhauForm()
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

        private void QuenMatKhauForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = sdt;
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

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!!!"
              , "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "n8cnpm2024@gmail.com";
            pass = "xxun uvux ypam jncu";
            messageBody = "Your OTP is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting OTP";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP gửi thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            TaiKhoanService service = new TaiKhoanService();

            string sdt = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            Taikhoan account = service.Get(sdt);

            if (account == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sdt.Length != 10)
            {
                MessageBox.Show("Độ dài số điện thoại là 10 ký tự. Vui lòng nhập lại!", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!regex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!!!"
              , "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (account.Email != email)
            {
                MessageBox.Show("Email không trùng khớp!!!"
              , "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ!!!"
               , "Mật khẩu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8 || password.Length > 24)
            {
                MessageBox.Show("Mật khẩu có độ dài từ 8 đến 24 kí tự. Vui lòng nhập lại!", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtRepassword.Text.Equals(password))
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (randomCode != txtOTP.Text.ToString())
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã OTP"
                   , "Mã OTP không trùng khớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text.Equals(account.Matkhau))
            {
                MessageBox.Show("Mật khẩu mới đã trùng với mật khẩu cũ!", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            account.Matkhau = password;

            service.UpdateTaiKhoan(account);
            MessageBox.Show("Cập nhật Mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const int MaxWidth = 769;
        private const int MaxHeight = 704;

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
