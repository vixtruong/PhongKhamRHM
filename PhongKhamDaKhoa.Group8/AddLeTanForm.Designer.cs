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
            lblTitle = new Label();
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
            btnSaveLT.Location = new Point(136, 575);
            btnSaveLT.Margin = new Padding(3, 4, 3, 4);
            btnSaveLT.Name = "btnSaveLT";
            btnSaveLT.Size = new Size(125, 41);
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
            txtPhoneLT.Location = new Point(49, 397);
            txtPhoneLT.Margin = new Padding(3, 4, 3, 4);
            txtPhoneLT.Multiline = false;
            txtPhoneLT.Name = "txtPhoneLT";
            txtPhoneLT.Padding = new Padding(11, 9, 11, 9);
            txtPhoneLT.PasswordChar = false;
            txtPhoneLT.PlaceholderColor = Color.DarkGray;
            txtPhoneLT.PlaceholderText = "";
            txtPhoneLT.Size = new Size(305, 40);
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
            txtNameLT.Location = new Point(50, 105);
            txtNameLT.Margin = new Padding(3, 4, 3, 4);
            txtNameLT.Multiline = false;
            txtNameLT.Name = "txtNameLT";
            txtNameLT.Padding = new Padding(11, 9, 11, 9);
            txtNameLT.PasswordChar = false;
            txtNameLT.PlaceholderColor = Color.DarkGray;
            txtNameLT.PlaceholderText = "";
            txtNameLT.Size = new Size(304, 40);
            txtNameLT.TabIndex = 54;
            txtNameLT.Texts = "";
            txtNameLT.UnderlinedStyle = false;
            // 
            // chkFemaleLT
            // 
            chkFemaleLT.Anchor = AnchorStyles.None;
            chkFemaleLT.AutoSize = true;
            chkFemaleLT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkFemaleLT.Location = new Point(191, 315);
            chkFemaleLT.Margin = new Padding(3, 4, 3, 4);
            chkFemaleLT.Name = "chkFemaleLT";
            chkFemaleLT.Size = new Size(61, 32);
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
            chkMaleLT.Location = new Point(50, 315);
            chkMaleLT.Margin = new Padding(3, 4, 3, 4);
            chkMaleLT.Name = "chkMaleLT";
            chkMaleLT.Size = new Size(76, 32);
            chkMaleLT.TabIndex = 52;
            chkMaleLT.Text = "Nam";
            chkMaleLT.UseVisualStyleBackColor = true;
            chkMaleLT.CheckedChanged += chkMaleLT_CheckedChanged;
            // 
            // dtpDateWorkingLT
            // 
            dtpDateWorkingLT.Anchor = AnchorStyles.None;
            dtpDateWorkingLT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDateWorkingLT.Location = new Point(50, 498);
            dtpDateWorkingLT.Margin = new Padding(3, 4, 3, 4);
            dtpDateWorkingLT.Name = "dtpDateWorkingLT";
            dtpDateWorkingLT.Size = new Size(303, 32);
            dtpDateWorkingLT.TabIndex = 49;
            // 
            // dtpBirthdayLT
            // 
            dtpBirthdayLT.Anchor = AnchorStyles.None;
            dtpBirthdayLT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpBirthdayLT.Location = new Point(49, 210);
            dtpBirthdayLT.Margin = new Padding(3, 4, 3, 4);
            dtpBirthdayLT.Name = "dtpBirthdayLT";
            dtpBirthdayLT.Size = new Size(305, 32);
            dtpBirthdayLT.TabIndex = 50;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(40, 365);
            label12.Name = "label12";
            label12.Size = new Size(138, 28);
            label12.TabIndex = 44;
            label12.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 461);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 45;
            label1.Text = "Ngày vào làm việc:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 275);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 46;
            label4.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(40, 167);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 47;
            label7.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(40, 67);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 48;
            label3.Text = "Họ và tên:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(362, 9);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(41, 43);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = true;
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
            panelTitleBar.Size = new Size(410, 61);
            panelTitleBar.TabIndex = 56;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(96, 20);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(209, 32);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Thông Tin Lễ Tân";
            // 
            // AddLeTanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(410, 632);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddLeTanForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm Lễ Tân";
            Resize += AddLeTanForm_Resize;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
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
        private Label lblTitle;
    }
}