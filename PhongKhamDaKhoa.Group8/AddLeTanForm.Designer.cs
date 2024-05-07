namespace PhongKhamDaKhoa.Group8
{
    partial class AddLeTanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLeTanForm));
            btnSaveLT = new PhongKham.RJControls.RJButton();
            txtPhoneLT = new CustomControls.RJControls.RJTextBox();
            txtNameLT = new CustomControls.RJControls.RJTextBox();
            chkFemaleLT = new CheckBox();
            chkMaleLT = new CheckBox();
            dtpDateWorkingLT = new DateTimePicker();
            dtpBirthdayLT = new DateTimePicker();
            label12 = new Label();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaveLT
            // 
            btnSaveLT.Anchor = AnchorStyles.None;
            btnSaveLT.BackColor = Color.Transparent;
            btnSaveLT.BackgroundColor = Color.Transparent;
            btnSaveLT.BorderColor = Color.FromArgb(27, 117, 188);
            btnSaveLT.BorderRadius = 10;
            btnSaveLT.BorderSize = 1;
            btnSaveLT.Cursor = Cursors.Hand;
            btnSaveLT.FlatAppearance.BorderSize = 0;
            btnSaveLT.FlatStyle = FlatStyle.Flat;
            btnSaveLT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSaveLT.ForeColor = Color.Black;
            btnSaveLT.Location = new Point(119, 415);
            btnSaveLT.Name = "btnSaveLT";
            btnSaveLT.Size = new Size(109, 31);
            btnSaveLT.TabIndex = 55;
            btnSaveLT.Text = "Lưu";
            btnSaveLT.TextColor = Color.Black;
            btnSaveLT.UseVisualStyleBackColor = false;
            btnSaveLT.Click += btnSaveLT_Click;
            // 
            // txtPhoneLT
            // 
            txtPhoneLT.Anchor = AnchorStyles.None;
            txtPhoneLT.BackColor = SystemColors.Window;
            txtPhoneLT.BorderColor = Color.FromArgb(27, 117, 188);
            txtPhoneLT.BorderFocusColor = Color.HotPink;
            txtPhoneLT.BorderRadius = 10;
            txtPhoneLT.BorderSize = 1;
            txtPhoneLT.Cursor = Cursors.IBeam;
            txtPhoneLT.Location = new Point(43, 281);
            txtPhoneLT.Multiline = false;
            txtPhoneLT.Name = "txtPhoneLT";
            txtPhoneLT.Padding = new Padding(10, 7, 10, 7);
            txtPhoneLT.PasswordChar = false;
            txtPhoneLT.PlaceholderColor = Color.DarkGray;
            txtPhoneLT.PlaceholderText = "";
            txtPhoneLT.Size = new Size(267, 31);
            txtPhoneLT.TabIndex = 53;
            txtPhoneLT.Texts = "";
            txtPhoneLT.UnderlinedStyle = false;
            // 
            // txtNameLT
            // 
            txtNameLT.Anchor = AnchorStyles.None;
            txtNameLT.BackColor = SystemColors.Window;
            txtNameLT.BorderColor = Color.FromArgb(27, 117, 188);
            txtNameLT.BorderFocusColor = Color.HotPink;
            txtNameLT.BorderRadius = 10;
            txtNameLT.BorderSize = 1;
            txtNameLT.Cursor = Cursors.IBeam;
            txtNameLT.Location = new Point(44, 62);
            txtNameLT.Multiline = false;
            txtNameLT.Name = "txtNameLT";
            txtNameLT.Padding = new Padding(10, 7, 10, 7);
            txtNameLT.PasswordChar = false;
            txtNameLT.PlaceholderColor = Color.DarkGray;
            txtNameLT.PlaceholderText = "";
            txtNameLT.Size = new Size(266, 31);
            txtNameLT.TabIndex = 54;
            txtNameLT.Texts = "";
            txtNameLT.UnderlinedStyle = false;
            // 
            // chkFemaleLT
            // 
            chkFemaleLT.Anchor = AnchorStyles.None;
            chkFemaleLT.AutoSize = true;
            chkFemaleLT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkFemaleLT.Location = new Point(167, 220);
            chkFemaleLT.Name = "chkFemaleLT";
            chkFemaleLT.Size = new Size(50, 25);
            chkFemaleLT.TabIndex = 51;
            chkFemaleLT.Text = "Nữ";
            chkFemaleLT.UseVisualStyleBackColor = true;
            chkFemaleLT.CheckedChanged += chkFemaleLT_CheckedChanged;
            // 
            // chkMaleLT
            // 
            chkMaleLT.Anchor = AnchorStyles.None;
            chkMaleLT.AutoSize = true;
            chkMaleLT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkMaleLT.Location = new Point(44, 220);
            chkMaleLT.Name = "chkMaleLT";
            chkMaleLT.Size = new Size(63, 25);
            chkMaleLT.TabIndex = 52;
            chkMaleLT.Text = "Nam";
            chkMaleLT.UseVisualStyleBackColor = true;
            chkMaleLT.CheckedChanged += chkMaleLT_CheckedChanged;
            // 
            // dtpDateWorkingLT
            // 
            dtpDateWorkingLT.Anchor = AnchorStyles.None;
            dtpDateWorkingLT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDateWorkingLT.Location = new Point(44, 357);
            dtpDateWorkingLT.Name = "dtpDateWorkingLT";
            dtpDateWorkingLT.Size = new Size(266, 27);
            dtpDateWorkingLT.TabIndex = 49;
            // 
            // dtpBirthdayLT
            // 
            dtpBirthdayLT.Anchor = AnchorStyles.None;
            dtpBirthdayLT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpBirthdayLT.Location = new Point(43, 141);
            dtpBirthdayLT.Name = "dtpBirthdayLT";
            dtpBirthdayLT.Size = new Size(267, 27);
            dtpBirthdayLT.TabIndex = 50;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(35, 257);
            label12.Name = "label12";
            label12.Size = new Size(110, 21);
            label12.TabIndex = 44;
            label12.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(35, 329);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 45;
            label1.Text = "Ngày vào làm việc:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(35, 190);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 46;
            label4.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(35, 109);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 47;
            label7.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 34);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 48;
            label3.Text = "Họ và tên:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(317, 7);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(36, 32);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(359, 46);
            panelTitleBar.TabIndex = 56;
            // 
            // AddLeTanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(359, 474);
            Controls.Add(btnSaveLT);
            Controls.Add(txtPhoneLT);
            Controls.Add(txtNameLT);
            Controls.Add(chkFemaleLT);
            Controls.Add(chkMaleLT);
            Controls.Add(dtpDateWorkingLT);
            Controls.Add(dtpBirthdayLT);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(panelTitleBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddLeTanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Lễ Tân";
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PhongKham.RJControls.RJButton btnSaveLT;
        private CustomControls.RJControls.RJTextBox txtPhoneLT;
        private CustomControls.RJControls.RJTextBox txtNameLT;
        private CheckBox chkFemaleLT;
        private CheckBox chkMaleLT;
        private DateTimePicker dtpDateWorkingLT;
        private DateTimePicker dtpBirthdayLT;
        private Label label12;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label3;
        private Button btnThoat;
        private Panel panelTitleBar;
    }
}