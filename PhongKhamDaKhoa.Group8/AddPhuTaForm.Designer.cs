﻿namespace PhongKhamDaKhoa.Group8
{
    partial class AddPhuTaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPhuTaForm));
            btnSavePT = new PhongKham.RJControls.RJButton();
            txtPhonePT = new CustomControls.RJControls.RJTextBox();
            txtNamePT = new CustomControls.RJControls.RJTextBox();
            chkFemalePT = new CheckBox();
            chkMalePT = new CheckBox();
            dtpDateWorkingPT = new DateTimePicker();
            dtpBirthdayPT = new DateTimePicker();
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
            // btnSavePT
            // 
            btnSavePT.BackColor = Color.Transparent;
            btnSavePT.BackgroundColor = Color.Transparent;
            btnSavePT.BorderColor = Color.FromArgb(27, 117, 188);
            btnSavePT.BorderRadius = 10;
            btnSavePT.BorderSize = 1;
            btnSavePT.Cursor = Cursors.Hand;
            btnSavePT.FlatAppearance.BorderSize = 0;
            btnSavePT.FlatStyle = FlatStyle.Flat;
            btnSavePT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSavePT.ForeColor = Color.Black;
            btnSavePT.Location = new Point(136, 569);
            btnSavePT.Margin = new Padding(3, 4, 3, 4);
            btnSavePT.Name = "btnSavePT";
            btnSavePT.Size = new Size(125, 41);
            btnSavePT.TabIndex = 42;
            btnSavePT.Text = "Lưu";
            btnSavePT.TextColor = Color.Black;
            btnSavePT.UseVisualStyleBackColor = false;
            btnSavePT.Click += btnSavePT_Click;
            // 
            // txtPhonePT
            // 
            txtPhonePT.BackColor = SystemColors.Window;
            txtPhonePT.BorderColor = Color.FromArgb(27, 117, 188);
            txtPhonePT.BorderFocusColor = Color.HotPink;
            txtPhonePT.BorderRadius = 10;
            txtPhonePT.BorderSize = 1;
            txtPhonePT.Location = new Point(50, 397);
            txtPhonePT.Margin = new Padding(3, 4, 3, 4);
            txtPhonePT.Multiline = false;
            txtPhonePT.Name = "txtPhonePT";
            txtPhonePT.Padding = new Padding(11, 9, 11, 9);
            txtPhonePT.PasswordChar = false;
            txtPhonePT.PlaceholderColor = Color.DarkGray;
            txtPhonePT.PlaceholderText = "";
            txtPhonePT.Size = new Size(307, 40);
            txtPhonePT.TabIndex = 40;
            txtPhonePT.Texts = "";
            txtPhonePT.UnderlinedStyle = false;
            // 
            // txtNamePT
            // 
            txtNamePT.BackColor = SystemColors.Window;
            txtNamePT.BorderColor = Color.FromArgb(27, 117, 188);
            txtNamePT.BorderFocusColor = Color.HotPink;
            txtNamePT.BorderRadius = 10;
            txtNamePT.BorderSize = 1;
            txtNamePT.Location = new Point(51, 105);
            txtNamePT.Margin = new Padding(3, 4, 3, 4);
            txtNamePT.Multiline = false;
            txtNamePT.Name = "txtNamePT";
            txtNamePT.Padding = new Padding(11, 9, 11, 9);
            txtNamePT.PasswordChar = false;
            txtNamePT.PlaceholderColor = Color.DarkGray;
            txtNamePT.PlaceholderText = "";
            txtNamePT.Size = new Size(306, 40);
            txtNamePT.TabIndex = 41;
            txtNamePT.Texts = "";
            txtNamePT.UnderlinedStyle = false;
            // 
            // chkFemalePT
            // 
            chkFemalePT.AutoSize = true;
            chkFemalePT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkFemalePT.Location = new Point(191, 315);
            chkFemalePT.Margin = new Padding(3, 4, 3, 4);
            chkFemalePT.Name = "chkFemalePT";
            chkFemalePT.Size = new Size(61, 32);
            chkFemalePT.TabIndex = 38;
            chkFemalePT.Text = "Nữ";
            chkFemalePT.UseVisualStyleBackColor = true;
            chkFemalePT.CheckedChanged += chkFemalePT_CheckedChanged;
            // 
            // chkMalePT
            // 
            chkMalePT.AutoSize = true;
            chkMalePT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkMalePT.Location = new Point(51, 315);
            chkMalePT.Margin = new Padding(3, 4, 3, 4);
            chkMalePT.Name = "chkMalePT";
            chkMalePT.Size = new Size(76, 32);
            chkMalePT.TabIndex = 39;
            chkMalePT.Text = "Nam";
            chkMalePT.UseVisualStyleBackColor = true;
            chkMalePT.CheckedChanged += chkMalePT_CheckedChanged;
            // 
            // dtpDateWorkingPT
            // 
            dtpDateWorkingPT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDateWorkingPT.Location = new Point(51, 498);
            dtpDateWorkingPT.Margin = new Padding(3, 4, 3, 4);
            dtpDateWorkingPT.Name = "dtpDateWorkingPT";
            dtpDateWorkingPT.Size = new Size(306, 32);
            dtpDateWorkingPT.TabIndex = 36;
            // 
            // dtpBirthdayPT
            // 
            dtpBirthdayPT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpBirthdayPT.Location = new Point(51, 210);
            dtpBirthdayPT.Margin = new Padding(3, 4, 3, 4);
            dtpBirthdayPT.Name = "dtpBirthdayPT";
            dtpBirthdayPT.Size = new Size(306, 32);
            dtpBirthdayPT.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(40, 365);
            label12.Name = "label12";
            label12.Size = new Size(138, 28);
            label12.TabIndex = 31;
            label12.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 461);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 32;
            label1.Text = "Ngày vào làm việc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 275);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 33;
            label4.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(40, 167);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 34;
            label7.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(40, 67);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 35;
            label3.Text = "Họ và tên:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(355, 9);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(41, 43);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.WhiteSmoke;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(402, 61);
            panelTitleBar.TabIndex = 43;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(95, 17);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 32);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Thông Tin Phụ Tá";
            // 
            // AddPhuTaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(402, 626);
            Controls.Add(btnSavePT);
            Controls.Add(txtPhonePT);
            Controls.Add(txtNamePT);
            Controls.Add(chkFemalePT);
            Controls.Add(chkMalePT);
            Controls.Add(dtpDateWorkingPT);
            Controls.Add(dtpBirthdayPT);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(panelTitleBar);
            Cursor = Cursors.IBeam;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddPhuTaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm Phụ Tá";
            Resize += AddPhuTaForm_Resize;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PhongKham.RJControls.RJButton btnSavePT;
        private CustomControls.RJControls.RJTextBox txtPhonePT;
        private CustomControls.RJControls.RJTextBox txtNamePT;
        private CheckBox chkFemalePT;
        private CheckBox chkMalePT;
        private DateTimePicker dtpDateWorkingPT;
        private DateTimePicker dtpBirthdayPT;
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