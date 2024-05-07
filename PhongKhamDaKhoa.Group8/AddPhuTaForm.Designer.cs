namespace PhongKhamDaKhoa.Group8
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
            btnSavePT.Location = new Point(119, 401);
            btnSavePT.Name = "btnSavePT";
            btnSavePT.Size = new Size(109, 31);
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
            txtPhonePT.Location = new Point(44, 272);
            txtPhonePT.Multiline = false;
            txtPhonePT.Name = "txtPhonePT";
            txtPhonePT.Padding = new Padding(10, 7, 10, 7);
            txtPhonePT.PasswordChar = false;
            txtPhonePT.PlaceholderColor = Color.DarkGray;
            txtPhonePT.PlaceholderText = "";
            txtPhonePT.Size = new Size(269, 31);
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
            txtNamePT.Location = new Point(45, 53);
            txtNamePT.Multiline = false;
            txtNamePT.Name = "txtNamePT";
            txtNamePT.Padding = new Padding(10, 7, 10, 7);
            txtNamePT.PasswordChar = false;
            txtNamePT.PlaceholderColor = Color.DarkGray;
            txtNamePT.PlaceholderText = "";
            txtNamePT.Size = new Size(268, 31);
            txtNamePT.TabIndex = 41;
            txtNamePT.Texts = "";
            txtNamePT.UnderlinedStyle = false;
            // 
            // chkFemalePT
            // 
            chkFemalePT.AutoSize = true;
            chkFemalePT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkFemalePT.Location = new Point(167, 211);
            chkFemalePT.Name = "chkFemalePT";
            chkFemalePT.Size = new Size(50, 25);
            chkFemalePT.TabIndex = 38;
            chkFemalePT.Text = "Nữ";
            chkFemalePT.UseVisualStyleBackColor = true;
            chkFemalePT.CheckedChanged += chkFemalePT_CheckedChanged;
            // 
            // chkMalePT
            // 
            chkMalePT.AutoSize = true;
            chkMalePT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkMalePT.Location = new Point(45, 211);
            chkMalePT.Name = "chkMalePT";
            chkMalePT.Size = new Size(63, 25);
            chkMalePT.TabIndex = 39;
            chkMalePT.Text = "Nam";
            chkMalePT.UseVisualStyleBackColor = true;
            chkMalePT.CheckedChanged += chkMalePT_CheckedChanged;
            // 
            // dtpDateWorkingPT
            // 
            dtpDateWorkingPT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDateWorkingPT.Location = new Point(45, 348);
            dtpDateWorkingPT.Name = "dtpDateWorkingPT";
            dtpDateWorkingPT.Size = new Size(268, 27);
            dtpDateWorkingPT.TabIndex = 36;
            // 
            // dtpBirthdayPT
            // 
            dtpBirthdayPT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpBirthdayPT.Location = new Point(45, 132);
            dtpBirthdayPT.Name = "dtpBirthdayPT";
            dtpBirthdayPT.Size = new Size(268, 27);
            dtpBirthdayPT.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(35, 248);
            label12.Name = "label12";
            label12.Size = new Size(110, 21);
            label12.TabIndex = 31;
            label12.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(35, 320);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 32;
            label1.Text = "Ngày vào làm việc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(35, 181);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 33;
            label4.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(35, 100);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 34;
            label7.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 25);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 35;
            label3.Text = "Họ và tên:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(311, 7);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(36, 32);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(352, 46);
            panelTitleBar.TabIndex = 43;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // AddPhuTaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(352, 464);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPhuTaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Phụ Tá";
            panelTitleBar.ResumeLayout(false);
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
    }
}