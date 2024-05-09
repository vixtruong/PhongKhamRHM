namespace PhongKhamDaKhoa.Group8
{
    partial class UpdateBacSiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBacSiForm));
            chkFemaleBS = new CheckBox();
            chkMaleBS = new CheckBox();
            dtpDateWorkingBS = new DateTimePicker();
            dtpBirthdayBS = new DateTimePicker();
            label12 = new Label();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            txtNameBS = new CustomControls.RJControls.RJTextBox();
            txtPhoneBS = new CustomControls.RJControls.RJTextBox();
            btnSaveBS = new PhongKham.RJControls.RJButton();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            txtKhoa = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // chkFemaleBS
            // 
            chkFemaleBS.AutoSize = true;
            chkFemaleBS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkFemaleBS.Location = new Point(234, 423);
            chkFemaleBS.Margin = new Padding(3, 4, 3, 4);
            chkFemaleBS.Name = "chkFemaleBS";
            chkFemaleBS.Size = new Size(61, 32);
            chkFemaleBS.TabIndex = 15;
            chkFemaleBS.Text = "Nữ";
            chkFemaleBS.UseVisualStyleBackColor = true;
            chkFemaleBS.CheckedChanged += chkFemaleBS_CheckedChanged;
            // 
            // chkMaleBS
            // 
            chkMaleBS.AutoSize = true;
            chkMaleBS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkMaleBS.Location = new Point(94, 423);
            chkMaleBS.Margin = new Padding(3, 4, 3, 4);
            chkMaleBS.Name = "chkMaleBS";
            chkMaleBS.Size = new Size(76, 32);
            chkMaleBS.TabIndex = 16;
            chkMaleBS.Text = "Nam";
            chkMaleBS.UseVisualStyleBackColor = true;
            chkMaleBS.CheckedChanged += chkMaleBS_CheckedChanged;
            // 
            // dtpDateWorkingBS
            // 
            dtpDateWorkingBS.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDateWorkingBS.Location = new Point(94, 605);
            dtpDateWorkingBS.Margin = new Padding(3, 4, 3, 4);
            dtpDateWorkingBS.Name = "dtpDateWorkingBS";
            dtpDateWorkingBS.Size = new Size(303, 32);
            dtpDateWorkingBS.TabIndex = 13;
            // 
            // dtpBirthdayBS
            // 
            dtpBirthdayBS.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpBirthdayBS.Location = new Point(94, 317);
            dtpBirthdayBS.Margin = new Padding(3, 4, 3, 4);
            dtpBirthdayBS.Name = "dtpBirthdayBS";
            dtpBirthdayBS.Size = new Size(303, 32);
            dtpBirthdayBS.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(83, 473);
            label12.Name = "label12";
            label12.Size = new Size(132, 28);
            label12.TabIndex = 5;
            label12.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(83, 569);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 7;
            label1.Text = "Ngày vào làm việc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(83, 383);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 8;
            label4.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(83, 275);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 9;
            label7.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(83, 68);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 10;
            label3.Text = "Họ và tên:";
            // 
            // txtNameBS
            // 
            txtNameBS.BackColor = SystemColors.Window;
            txtNameBS.BorderColor = Color.FromArgb(27, 117, 188);
            txtNameBS.BorderFocusColor = Color.HotPink;
            txtNameBS.BorderRadius = 8;
            txtNameBS.BorderSize = 1;
            txtNameBS.Cursor = Cursors.IBeam;
            txtNameBS.Location = new Point(94, 105);
            txtNameBS.Margin = new Padding(3, 4, 3, 4);
            txtNameBS.Multiline = false;
            txtNameBS.Name = "txtNameBS";
            txtNameBS.Padding = new Padding(11, 9, 11, 9);
            txtNameBS.PasswordChar = false;
            txtNameBS.PlaceholderColor = Color.DarkGray;
            txtNameBS.PlaceholderText = "";
            txtNameBS.Size = new Size(304, 40);
            txtNameBS.TabIndex = 28;
            txtNameBS.Texts = "";
            txtNameBS.UnderlinedStyle = false;
            // 
            // txtPhoneBS
            // 
            txtPhoneBS.BackColor = SystemColors.Window;
            txtPhoneBS.BorderColor = Color.FromArgb(27, 117, 188);
            txtPhoneBS.BorderFocusColor = Color.HotPink;
            txtPhoneBS.BorderRadius = 8;
            txtPhoneBS.BorderSize = 1;
            txtPhoneBS.Cursor = Cursors.IBeam;
            txtPhoneBS.Location = new Point(94, 505);
            txtPhoneBS.Margin = new Padding(3, 4, 3, 4);
            txtPhoneBS.Multiline = false;
            txtPhoneBS.Name = "txtPhoneBS";
            txtPhoneBS.Padding = new Padding(11, 9, 11, 9);
            txtPhoneBS.PasswordChar = false;
            txtPhoneBS.PlaceholderColor = Color.DarkGray;
            txtPhoneBS.PlaceholderText = "";
            txtPhoneBS.Size = new Size(305, 40);
            txtPhoneBS.TabIndex = 28;
            txtPhoneBS.Texts = "";
            txtPhoneBS.UnderlinedStyle = false;
            // 
            // btnSaveBS
            // 
            btnSaveBS.BackColor = Color.Transparent;
            btnSaveBS.BackgroundColor = Color.Transparent;
            btnSaveBS.BorderColor = Color.FromArgb(27, 117, 188);
            btnSaveBS.BorderRadius = 10;
            btnSaveBS.BorderSize = 1;
            btnSaveBS.Cursor = Cursors.Hand;
            btnSaveBS.FlatAppearance.BorderSize = 0;
            btnSaveBS.FlatStyle = FlatStyle.Flat;
            btnSaveBS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSaveBS.ForeColor = Color.Black;
            btnSaveBS.Location = new Point(179, 683);
            btnSaveBS.Margin = new Padding(3, 4, 3, 4);
            btnSaveBS.Name = "btnSaveBS";
            btnSaveBS.Size = new Size(125, 41);
            btnSaveBS.TabIndex = 29;
            btnSaveBS.Text = "Lưu";
            btnSaveBS.TextColor = Color.Black;
            btnSaveBS.UseVisualStyleBackColor = false;
            btnSaveBS.Click += btnSaveBS_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(431, 9);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(41, 43);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(484, 61);
            panelTitleBar.TabIndex = 30;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(138, 14);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 32);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Thông Tin Bác Sĩ";
            // 
            // txtKhoa
            // 
            txtKhoa.BackColor = SystemColors.Window;
            txtKhoa.BorderColor = Color.FromArgb(27, 117, 188);
            txtKhoa.BorderFocusColor = Color.HotPink;
            txtKhoa.BorderRadius = 8;
            txtKhoa.BorderSize = 1;
            txtKhoa.Cursor = Cursors.IBeam;
            txtKhoa.Location = new Point(94, 208);
            txtKhoa.Margin = new Padding(3, 4, 3, 4);
            txtKhoa.Multiline = false;
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Padding = new Padding(11, 9, 11, 9);
            txtKhoa.PasswordChar = false;
            txtKhoa.PlaceholderColor = Color.DarkGray;
            txtKhoa.PlaceholderText = "";
            txtKhoa.Size = new Size(304, 40);
            txtKhoa.TabIndex = 32;
            txtKhoa.Texts = "";
            txtKhoa.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(83, 169);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 31;
            label2.Text = "Khoa:";
            // 
            // UpdateBacSiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(484, 740);
            Controls.Add(txtKhoa);
            Controls.Add(label2);
            Controls.Add(btnSaveBS);
            Controls.Add(txtPhoneBS);
            Controls.Add(txtNameBS);
            Controls.Add(chkFemaleBS);
            Controls.Add(chkMaleBS);
            Controls.Add(dtpDateWorkingBS);
            Controls.Add(dtpBirthdayBS);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(panelTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateBacSiForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập Nhật Bác Sĩ";
            Load += UpdateBacSiForm_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chkFemaleBS;
        private CheckBox chkMaleBS;
        private DateTimePicker dtpDateWorkingBS;
        private DateTimePicker dtpBirthdayBS;
        private Label label12;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label3;
        private CustomControls.RJControls.RJTextBox txtNameBS;
        private CustomControls.RJControls.RJTextBox txtPhoneBS;
        private PhongKham.RJControls.RJButton btnSaveBS;
        private Button btnThoat;
        private Panel panelTitleBar;
        private CustomControls.RJControls.RJTextBox txtKhoa;
        private Label label2;
        private Label lblTitle;
    }
}