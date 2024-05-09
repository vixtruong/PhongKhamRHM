using Repositories.Entities;
using Services;
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
using System.Runtime.InteropServices;

namespace WinFormsApp4
{
    public partial class DangKyForm : Form
    {

        String randomCode;
        public static String to;
        Regex regex = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

        public DangKyForm()
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

        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }

        private void DangKyForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void chkBS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBS.Checked)
            {
                chkLT.Checked = false;
                chkCPK.Checked = false;
            }
        }

        private void chkLT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLT.Checked)
            {
                chkBS.Checked = false;
                chkCPK.Checked = false;
            }
        }

        private void chkCPK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPK.Checked)
            {
                chkBS.Checked = false;
                chkLT.Checked = false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            TaiKhoanService service = new TaiKhoanService();
            BacSiService bsService = new BacSiService();
            LeTanService ltService = new LeTanService();

            string username = txtUsername.Texts;
            string password = txtPassword.Texts;
            string email = txtEmail.Texts;
            string chucvu = "";


            Taikhoan account = service.CheckSignUp(username);

            if (account != null)
            {
                MessageBox.Show("Số điện thoại này đã được đăng kí tài khoản!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username.Length != 10)
            {
                MessageBox.Show("Độ dài số điện thoại là 10 ký tự. Vui lòng nhập lại!", "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!regex.IsMatch(txtEmail.Texts))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!!!"
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
                MessageBox.Show("Mật khẩu có độ dài từ 8 đến 24 kí tự. Vui lòng nhập lại!", "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkBS.Checked == false && chkLT.Checked == false && chkCPK.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ!", "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtRepassword.Texts.Equals(password))
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (randomCode != txtOTP.Texts.ToString())
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã OTP"
                   , "Mã OTP không trùng khớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkBS.Checked)
                chucvu = "BS";
            else if (chkLT.Checked)
                chucvu = "LT";
            else chucvu = "CPK";

            if (chucvu == "BS" && bsService.GetByPhone(username) == null)
            {
                MessageBox.Show("Không tồn tại bác sĩ có số điện thoại này!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chucvu == "LT" && ltService.GetByPhone(username) == null)
            {
                MessageBox.Show("Không tồn tại lễ tân có số điện thoại này!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Taikhoan newAccount = new()
            {
                Sdt = username,
                Matkhau = password,
                Chucvu = chucvu,
                Email = email
            };

            service.AddTaiKhoan(newAccount);
            MessageBox.Show("Đăng kí tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(txtEmail.Texts))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!!!"
              , "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Texts).ToString();
            from = "n8cnpm2024@gmail.com";
            pass = "xxun uvux ypam jncu";
            messageBody = "Your OTP is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Account Sign Up OTP";
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
            this.Close();
        }

        private const int MaxWidth = 800;
        private const int MaxHeight = 775;

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
