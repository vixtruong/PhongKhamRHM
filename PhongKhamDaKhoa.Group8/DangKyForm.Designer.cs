namespace WinFormsApp4
{
    partial class DangKyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyForm));
            panel1 = new Panel();
            btnSignUp = new PhongKham.RJControls.RJButton();
            btnSendOTP = new PhongKham.RJControls.RJButton();
            txtOTP = new CustomControls.RJControls.RJTextBox();
            txtRepassword = new CustomControls.RJControls.RJTextBox();
            txtPassword = new CustomControls.RJControls.RJTextBox();
            txtEmail = new CustomControls.RJControls.RJTextBox();
            txtUsername = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            label3 = new Label();
            chkCPK = new CheckBox();
            chkLT = new CheckBox();
            chkBS = new CheckBox();
            label9 = new Label();
            label12 = new Label();
            label8 = new Label();
            label6 = new Label();
            panelTitleBar = new Panel();
            btnThoat = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            rjCircularPictureBox2 = new PhongKham.RJControls.RJCircularPictureBox();
            rjCircularPictureBox1 = new PhongKham.RJControls.RJCircularPictureBox();
            rjCircularPictureBox3 = new PhongKham.RJControls.RJCircularPictureBox();
            label11 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox3 = new PictureBox();
            label15 = new Label();
            panel1.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(btnSendOTP);
            panel1.Controls.Add(txtOTP);
            panel1.Controls.Add(txtRepassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chkCPK);
            panel1.Controls.Add(chkLT);
            panel1.Controls.Add(chkBS);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panelTitleBar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 728);
            panel1.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.BackgroundColor = Color.Transparent;
            btnSignUp.BorderColor = Color.FromArgb(27, 117, 188);
            btnSignUp.BorderRadius = 10;
            btnSignUp.BorderSize = 1;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(494, 649);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(125, 41);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "ĐĂNG KÍ";
            btnSignUp.TextColor = Color.Black;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSendOTP
            // 
            btnSendOTP.BackColor = Color.Transparent;
            btnSendOTP.BackgroundColor = Color.Transparent;
            btnSendOTP.BorderColor = Color.FromArgb(27, 117, 188);
            btnSendOTP.BorderRadius = 10;
            btnSendOTP.BorderSize = 1;
            btnSendOTP.Cursor = Cursors.Hand;
            btnSendOTP.FlatAppearance.BorderSize = 0;
            btnSendOTP.FlatStyle = FlatStyle.Flat;
            btnSendOTP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSendOTP.ForeColor = Color.Black;
            btnSendOTP.Location = new Point(625, 356);
            btnSendOTP.Margin = new Padding(3, 4, 3, 4);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new Size(88, 41);
            btnSendOTP.TabIndex = 4;
            btnSendOTP.Text = "Gửi OTP";
            btnSendOTP.TextColor = Color.Black;
            btnSendOTP.UseVisualStyleBackColor = false;
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // txtOTP
            // 
            txtOTP.BackColor = SystemColors.Window;
            txtOTP.BorderColor = Color.FromArgb(27, 117, 188);
            txtOTP.BorderFocusColor = Color.HotPink;
            txtOTP.BorderRadius = 10;
            txtOTP.BorderSize = 1;
            txtOTP.Cursor = Cursors.IBeam;
            txtOTP.Location = new Point(406, 356);
            txtOTP.Margin = new Padding(3, 4, 3, 4);
            txtOTP.Multiline = false;
            txtOTP.Name = "txtOTP";
            txtOTP.Padding = new Padding(11, 9, 11, 9);
            txtOTP.PasswordChar = false;
            txtOTP.PlaceholderColor = Color.DarkGray;
            txtOTP.PlaceholderText = "";
            txtOTP.Size = new Size(213, 40);
            txtOTP.TabIndex = 3;
            txtOTP.Texts = "";
            txtOTP.UnderlinedStyle = false;
            // 
            // txtRepassword
            // 
            txtRepassword.BackColor = SystemColors.Window;
            txtRepassword.BorderColor = Color.FromArgb(27, 117, 188);
            txtRepassword.BorderFocusColor = Color.HotPink;
            txtRepassword.BorderRadius = 10;
            txtRepassword.BorderSize = 1;
            txtRepassword.Cursor = Cursors.IBeam;
            txtRepassword.Location = new Point(406, 573);
            txtRepassword.Margin = new Padding(3, 4, 3, 4);
            txtRepassword.Multiline = false;
            txtRepassword.Name = "txtRepassword";
            txtRepassword.Padding = new Padding(11, 9, 11, 9);
            txtRepassword.PasswordChar = true;
            txtRepassword.PlaceholderColor = Color.DarkGray;
            txtRepassword.PlaceholderText = "";
            txtRepassword.Size = new Size(307, 40);
            txtRepassword.TabIndex = 6;
            txtRepassword.Texts = "";
            txtRepassword.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.FromArgb(27, 117, 188);
            txtPassword.BorderFocusColor = Color.HotPink;
            txtPassword.BorderRadius = 10;
            txtPassword.BorderSize = 1;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(406, 467);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(11, 9, 11, 9);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "";
            txtPassword.Size = new Size(307, 40);
            txtPassword.TabIndex = 5;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.FromArgb(27, 117, 188);
            txtEmail.BorderFocusColor = Color.HotPink;
            txtEmail.BorderRadius = 10;
            txtEmail.BorderSize = 1;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(406, 260);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(11, 9, 11, 9);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(307, 40);
            txtEmail.TabIndex = 2;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderColor = Color.FromArgb(27, 117, 188);
            txtUsername.BorderFocusColor = Color.HotPink;
            txtUsername.BorderRadius = 10;
            txtUsername.BorderSize = 1;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Location = new Point(406, 76);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(11, 9, 11, 9);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "";
            txtUsername.Size = new Size(307, 40);
            txtUsername.TabIndex = 1;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(402, 324);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 24;
            label4.Text = "Mã OTP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(402, 223);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 22;
            label3.Text = "Email:";
            // 
            // chkCPK
            // 
            chkCPK.AutoSize = true;
            chkCPK.Cursor = Cursors.Hand;
            chkCPK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkCPK.Location = new Point(625, 179);
            chkCPK.Margin = new Padding(3, 4, 3, 4);
            chkCPK.Name = "chkCPK";
            chkCPK.Size = new Size(68, 32);
            chkCPK.TabIndex = 21;
            chkCPK.Text = "Chủ";
            chkCPK.UseVisualStyleBackColor = true;
            chkCPK.CheckedChanged += chkCPK_CheckedChanged;
            // 
            // chkLT
            // 
            chkLT.AutoSize = true;
            chkLT.Cursor = Cursors.Hand;
            chkLT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkLT.Location = new Point(518, 179);
            chkLT.Margin = new Padding(3, 4, 3, 4);
            chkLT.Name = "chkLT";
            chkLT.Size = new Size(87, 32);
            chkLT.TabIndex = 19;
            chkLT.Text = "Lễ Tân";
            chkLT.UseVisualStyleBackColor = true;
            chkLT.CheckedChanged += chkLT_CheckedChanged;
            // 
            // chkBS
            // 
            chkBS.AutoSize = true;
            chkBS.Cursor = Cursors.Hand;
            chkBS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkBS.Location = new Point(415, 179);
            chkBS.Margin = new Padding(3, 4, 3, 4);
            chkBS.Name = "chkBS";
            chkBS.Size = new Size(85, 32);
            chkBS.TabIndex = 20;
            chkBS.Text = "Bác Sĩ";
            chkBS.UseVisualStyleBackColor = true;
            chkBS.CheckedChanged += chkBS_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(402, 133);
            label9.Name = "label9";
            label9.Size = new Size(88, 28);
            label9.TabIndex = 11;
            label9.Text = "Bộ phận:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(402, 37);
            label12.Name = "label12";
            label12.Size = new Size(132, 28);
            label12.TabIndex = 12;
            label12.Text = "Số điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(402, 535);
            label8.Name = "label8";
            label8.Size = new Size(175, 28);
            label8.TabIndex = 14;
            label8.Text = "Nhập lại mật khẩu:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(402, 428);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 15;
            label6.Text = "Mật khẩu:";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(782, 61);
            panelTitleBar.TabIndex = 29;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(738, 5);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(41, 43);
            btnThoat.TabIndex = 8;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            btnThoat.MouseEnter += button_MouseEnter;
            btnThoat.MouseLeave += button_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(rjCircularPictureBox2);
            panel2.Controls.Add(rjCircularPictureBox1);
            panel2.Controls.Add(rjCircularPictureBox3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label15);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 728);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(119, 649);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
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
            rjCircularPictureBox2.Location = new Point(111, 243);
            rjCircularPictureBox2.Margin = new Padding(3, 4, 3, 4);
            rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            rjCircularPictureBox2.Size = new Size(112, 112);
            rjCircularPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox2.TabIndex = 23;
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
            rjCircularPictureBox1.Location = new Point(39, 259);
            rjCircularPictureBox1.Margin = new Padding(3, 4, 3, 4);
            rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            rjCircularPictureBox1.Size = new Size(80, 80);
            rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox1.TabIndex = 24;
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
            rjCircularPictureBox3.Location = new Point(213, 259);
            rjCircularPictureBox3.Margin = new Padding(3, 4, 3, 4);
            rjCircularPictureBox3.Name = "rjCircularPictureBox3";
            rjCircularPictureBox3.Size = new Size(85, 85);
            rjCircularPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox3.TabIndex = 25;
            rjCircularPictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(27, 117, 188);
            label11.Location = new Point(66, 489);
            label11.Name = "label11";
            label11.Size = new Size(209, 3);
            label11.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(101, 497);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 20;
            label5.Text = "Contact For Work:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(144, 537);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 21;
            label1.Text = "Nhân Đỗ";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(74, 575);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(111, 535);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(106, 579);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 19;
            label2.Text = "drnhan1211@gmail.com";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 153);
            panel3.TabIndex = 16;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(27, 117, 188);
            label7.Location = new Point(63, 151);
            label7.Name = "label7";
            label7.Size = new Size(209, 3);
            label7.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label13.ForeColor = Color.FromArgb(27, 117, 188);
            label13.Location = new Point(141, 81);
            label13.Name = "label13";
            label13.Size = new Size(170, 28);
            label13.TabIndex = 5;
            label13.Text = "RĂNG HÀM MẶT";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label14.ForeColor = Color.FromArgb(27, 117, 188);
            label14.Location = new Point(122, 33);
            label14.Name = "label14";
            label14.Size = new Size(204, 37);
            label14.TabIndex = 4;
            label14.Text = "PHÒNG KHÁM";
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(49, 391);
            label15.Name = "label15";
            label15.Size = new Size(249, 25);
            label15.TabIndex = 15;
            label15.Text = "Vui lòng đăng kí để sử dụng";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DangKyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 728);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DangKyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng kí";
            Load += DangKyForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PhongKham.RJControls.RJCircularPictureBox rjCircularPictureBox2;
        private PhongKham.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private PhongKham.RJControls.RJCircularPictureBox rjCircularPictureBox3;
        private Label label11;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label2;
        private Panel panel3;
        private Label label7;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox3;
        private Label label15;
        private CustomControls.RJControls.RJTextBox txtUsername;

        private Label label4;
        private Label label3;
        private Label label9;
        private Label label12;
        private Label label8;
        private Label label6;
        private CustomControls.RJControls.RJTextBox txtOTP;
        private CustomControls.RJControls.RJTextBox txtEmail;
        private PhongKham.RJControls.RJButton btnSendOTP;
        private CustomControls.RJControls.RJTextBox txtRepassword;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private CheckBox chkCPK;
        private CheckBox chkLT;
        private CheckBox chkBS;
        private PhongKham.RJControls.RJButton btnSignUp;
        private Panel panelTitleBar;
        private Button btnThoat;
        private PictureBox pictureBox2;
    }
}