namespace WinFormsApp4
{
    partial class DangNhapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            panel1 = new Panel();
            panelTitleBar = new Panel();
            btnThoat = new Button();
            btnLogin = new PhongKham.RJControls.RJButton();
            txtPassword = new CustomControls.RJControls.RJTextBox();
            txtUsername = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            lblinkDangKi = new Label();
            lblinkQuenMK = new Label();
            label6 = new Label();
            label12 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            rjCircularPictureBox2 = new PhongKham.RJControls.RJCircularPictureBox();
            rjCircularPictureBox1 = new PhongKham.RJControls.RJCircularPictureBox();
            rjCircularPictureBox3 = new PhongKham.RJControls.RJCircularPictureBox();
            label11 = new Label();
            label5 = new Label();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            panel1.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelTitleBar);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblinkDangKi);
            panel1.Controls.Add(lblinkQuenMK);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(334, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 595);
            panel1.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(424, 61);
            panelTitleBar.TabIndex = 22;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(375, 9);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(41, 43);
            btnThoat.TabIndex = 6;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            btnThoat.MouseEnter += button_MouseEnter;
            btnThoat.MouseLeave += button_MouseLeave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(27, 117, 188);
            btnLogin.BorderRadius = 10;
            btnLogin.BorderSize = 1;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(141, 352);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 53);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.TextColor = Color.Black;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnDangNhap_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.FromArgb(27, 117, 188);
            txtPassword.BorderFocusColor = Color.HotPink;
            txtPassword.BorderRadius = 10;
            txtPassword.BorderSize = 1;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(37, 239);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(11, 9, 11, 9);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = SystemColors.ControlLight;
            txtPassword.PlaceholderText = "";
            txtPassword.Size = new Size(353, 40);
            txtPassword.TabIndex = 2;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            txtUsername.AutoValidate = AutoValidate.EnablePreventFocusChange;
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderColor = Color.FromArgb(27, 117, 188);
            txtUsername.BorderFocusColor = Color.HotPink;
            txtUsername.BorderRadius = 10;
            txtUsername.BorderSize = 1;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Location = new Point(37, 96);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(11, 9, 11, 9);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = SystemColors.ControlLight;
            txtUsername.PlaceholderText = "";
            txtUsername.Size = new Size(353, 40);
            txtUsername.TabIndex = 1;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(37, 148);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 3;
            label4.Text = "Mặc định là số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(37, 55);
            label3.Name = "label3";
            label3.Size = new Size(157, 28);
            label3.TabIndex = 7;
            label3.Text = "Tên đăng nhập:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 519);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblinkDangKi
            // 
            lblinkDangKi.AutoSize = true;
            lblinkDangKi.Cursor = Cursors.Hand;
            lblinkDangKi.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            lblinkDangKi.ForeColor = Color.FromArgb(27, 117, 188);
            lblinkDangKi.Location = new Point(237, 443);
            lblinkDangKi.Name = "lblinkDangKi";
            lblinkDangKi.Size = new Size(157, 28);
            lblinkDangKi.TabIndex = 4;
            lblinkDangKi.Text = "Đăng kí tại đây";
            lblinkDangKi.Click += lblinkDangKi_Click;
            // 
            // lblinkQuenMK
            // 
            lblinkQuenMK.AutoSize = true;
            lblinkQuenMK.Cursor = Cursors.Hand;
            lblinkQuenMK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            lblinkQuenMK.ForeColor = Color.FromArgb(27, 117, 188);
            lblinkQuenMK.Location = new Point(250, 299);
            lblinkQuenMK.Name = "lblinkQuenMK";
            lblinkQuenMK.Size = new Size(140, 23);
            lblinkQuenMK.TabIndex = 5;
            lblinkQuenMK.Text = "Quên mật khẩu?";
            lblinkQuenMK.Click += lblinkQuenMK_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(33, 443);
            label6.Name = "label6";
            label6.Size = new Size(212, 28);
            label6.TabIndex = 7;
            label6.Text = "Bạn chưa có tài khoản?";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label12.Location = new Point(37, 192);
            label12.Name = "label12";
            label12.Size = new Size(107, 28);
            label12.TabIndex = 7;
            label12.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 367);
            label2.Name = "label2";
            label2.Size = new Size(278, 25);
            label2.TabIndex = 3;
            label2.Text = "Vui lòng đăng nhập để sử dụng";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 1);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 152);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(27, 117, 188);
            label1.Location = new Point(123, 31);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 4;
            label1.Text = "PHÒNG KHÁM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.FromArgb(27, 117, 188);
            label7.Location = new Point(141, 81);
            label7.Name = "label7";
            label7.Size = new Size(170, 28);
            label7.TabIndex = 5;
            label7.Text = "RĂNG HÀM MẶT";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(7, 2);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 153);
            panel3.TabIndex = 7;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(27, 117, 188);
            label10.Location = new Point(58, 151);
            label10.Name = "label10";
            label10.Size = new Size(209, 3);
            label10.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(rjCircularPictureBox2);
            panel2.Controls.Add(rjCircularPictureBox1);
            panel2.Controls.Add(rjCircularPictureBox3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 595);
            panel2.TabIndex = 8;
            // 
            // rjCircularPictureBox2
            // 
            rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox2.BorderColor = Color.RoyalBlue;
            rjCircularPictureBox2.BorderColor2 = Color.HotPink;
            rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox2.BorderSize = 2;
            rjCircularPictureBox2.GradientAngle = 50F;
            rjCircularPictureBox2.Image = (Image)resources.GetObject("rjCircularPictureBox2.Image");
            rjCircularPictureBox2.Location = new Point(111, 220);
            rjCircularPictureBox2.Margin = new Padding(3, 4, 3, 4);
            rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            rjCircularPictureBox2.Size = new Size(112, 112);
            rjCircularPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox2.TabIndex = 14;
            rjCircularPictureBox2.TabStop = false;
            // 
            // rjCircularPictureBox1
            // 
            rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox1.BorderColor = Color.RoyalBlue;
            rjCircularPictureBox1.BorderColor2 = Color.HotPink;
            rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox1.BorderSize = 2;
            rjCircularPictureBox1.GradientAngle = 50F;
            rjCircularPictureBox1.Image = (Image)resources.GetObject("rjCircularPictureBox1.Image");
            rjCircularPictureBox1.Location = new Point(39, 236);
            rjCircularPictureBox1.Margin = new Padding(3, 4, 3, 4);
            rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            rjCircularPictureBox1.Size = new Size(80, 80);
            rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox1.TabIndex = 14;
            rjCircularPictureBox1.TabStop = false;
            // 
            // rjCircularPictureBox3
            // 
            rjCircularPictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox3.BorderColor = Color.RoyalBlue;
            rjCircularPictureBox3.BorderColor2 = Color.HotPink;
            rjCircularPictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox3.BorderSize = 2;
            rjCircularPictureBox3.GradientAngle = 50F;
            rjCircularPictureBox3.Image = (Image)resources.GetObject("rjCircularPictureBox3.Image");
            rjCircularPictureBox3.Location = new Point(213, 236);
            rjCircularPictureBox3.Margin = new Padding(3, 4, 3, 4);
            rjCircularPictureBox3.Name = "rjCircularPictureBox3";
            rjCircularPictureBox3.Size = new Size(85, 85);
            rjCircularPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox3.TabIndex = 14;
            rjCircularPictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(27, 117, 188);
            label11.Location = new Point(63, 468);
            label11.Name = "label11";
            label11.Size = new Size(209, 3);
            label11.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(97, 481);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 11;
            label5.Text = "Contact For Work:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(141, 519);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 12;
            label8.Text = "Nhân Đỗ";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(71, 553);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(107, 516);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(103, 557);
            label9.Name = "label9";
            label9.Size = new Size(171, 20);
            label9.TabIndex = 10;
            label9.Text = "drnhan1211@gmail.com";
            // 
            // DangNhapForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(758, 595);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DangNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += DangNhapForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label12;
        private Label label3;
        private Label label4;
        private Label lblinkDangKi;
        private Label lblinkQuenMK;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label7;
        private Panel panel3;
        private Panel panel2;
        private CustomControls.RJControls.RJTextBox txtUsername;
        private Label label5;
        private Label label8;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label9;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private PhongKham.RJControls.RJButton btnLogin;
        private Label label10;
        private PhongKham.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private Label label11;
        private PhongKham.RJControls.RJCircularPictureBox rjCircularPictureBox3;
        private PhongKham.RJControls.RJCircularPictureBox rjCircularPictureBox2;
        private Panel panelTitleBar;
        private Button btnThoat;

    }
}