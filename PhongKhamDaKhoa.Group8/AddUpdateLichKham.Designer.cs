namespace PhongKhamNhaKhoa
{
    partial class AddUpdateLichKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateLichKham));
            cbKhoa = new ComboBox();
            label8 = new Label();
            cboTenBS = new ComboBox();
            cboLoaiBN = new ComboBox();
            dtpNgaySinhBN = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpLichHen = new DateTimePicker();
            panelTitleBar = new Panel();
            btnThoat = new Button();
            lblTitle = new Label();
            txtTenBN = new CustomControls.RJControls.RJTextBox();
            txtSDT = new CustomControls.RJControls.RJTextBox();
            txtNhuCauKham = new CustomControls.RJControls.RJTextBox();
            btnSave = new PhongKham.RJControls.RJButton();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // cbKhoa
            // 
            cbKhoa.Anchor = AnchorStyles.Top;
            cbKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKhoa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbKhoa.Font = new Font("Segoe UI", 11F);
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(205, 376);
            cbKhoa.Margin = new Padding(2, 3, 2, 3);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(229, 33);
            cbKhoa.TabIndex = 24;
            cbKhoa.SelectedValueChanged += cbKhoa_SelectedValueChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(31, 379);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 28);
            label8.TabIndex = 25;
            label8.Text = "Khoa:";
            // 
            // cboTenBS
            // 
            cboTenBS.Anchor = AnchorStyles.Top;
            cboTenBS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenBS.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTenBS.Font = new Font("Segoe UI", 11F);
            cboTenBS.FormattingEnabled = true;
            cboTenBS.Location = new Point(205, 444);
            cboTenBS.Margin = new Padding(2, 3, 2, 3);
            cboTenBS.Name = "cboTenBS";
            cboTenBS.Size = new Size(229, 33);
            cboTenBS.TabIndex = 19;
            // 
            // cboLoaiBN
            // 
            cboLoaiBN.Anchor = AnchorStyles.Top;
            cboLoaiBN.Font = new Font("Segoe UI", 11F);
            cboLoaiBN.FormattingEnabled = true;
            cboLoaiBN.Location = new Point(205, 313);
            cboLoaiBN.Margin = new Padding(2, 3, 2, 3);
            cboLoaiBN.Name = "cboLoaiBN";
            cboLoaiBN.Size = new Size(229, 33);
            cboLoaiBN.TabIndex = 17;
            // 
            // dtpNgaySinhBN
            // 
            dtpNgaySinhBN.Anchor = AnchorStyles.Top;
            dtpNgaySinhBN.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinhBN.Font = new Font("Segoe UI", 11F);
            dtpNgaySinhBN.Format = DateTimePickerFormat.Custom;
            dtpNgaySinhBN.Location = new Point(205, 189);
            dtpNgaySinhBN.Margin = new Padding(2, 3, 2, 3);
            dtpNgaySinhBN.Name = "dtpNgaySinhBN";
            dtpNgaySinhBN.Size = new Size(229, 32);
            dtpNgaySinhBN.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(31, 505);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 28);
            label7.TabIndex = 23;
            label7.Text = "Nhu cầu khám:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(31, 441);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 22;
            label6.Text = "Tên bác sĩ:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(31, 313);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 20;
            label5.Text = "Loại bệnh nhân:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(31, 251);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 18;
            label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(31, 189);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 16;
            label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(31, 129);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 14;
            label2.Text = "Tên bệnh nhân:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(32, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 12;
            label1.Text = "Ngày hẹn:";
            // 
            // dtpLichHen
            // 
            dtpLichHen.Anchor = AnchorStyles.Top;
            dtpLichHen.CustomFormat = "dd/MM/yyyy ";
            dtpLichHen.Font = new Font("Segoe UI", 11F);
            dtpLichHen.Location = new Point(205, 71);
            dtpLichHen.Margin = new Padding(2, 3, 2, 3);
            dtpLichHen.Name = "dtpLichHen";
            dtpLichHen.Size = new Size(229, 32);
            dtpLichHen.TabIndex = 10;
            dtpLichHen.ValueChanged += dtpLichHen_ValueChanged;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(493, 61);
            panelTitleBar.TabIndex = 45;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(450, 9);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(41, 43);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(128, 15);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 32);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Thêm Mới Lịch Khám";
            // 
            // txtTenBN
            // 
            txtTenBN.BackColor = Color.White;
            txtTenBN.BorderColor = Color.FromArgb(27, 117, 188);
            txtTenBN.BorderFocusColor = Color.HotPink;
            txtTenBN.BorderRadius = 8;
            txtTenBN.BorderSize = 1;
            txtTenBN.Cursor = Cursors.Hand;
            txtTenBN.Location = new Point(205, 125);
            txtTenBN.Margin = new Padding(3, 4, 3, 4);
            txtTenBN.Multiline = false;
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Padding = new Padding(11, 9, 11, 9);
            txtTenBN.PasswordChar = false;
            txtTenBN.PlaceholderColor = Color.DarkGray;
            txtTenBN.PlaceholderText = "";
            txtTenBN.Size = new Size(229, 40);
            txtTenBN.TabIndex = 46;
            txtTenBN.Texts = "";
            txtTenBN.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.White;
            txtSDT.BorderColor = Color.FromArgb(27, 117, 188);
            txtSDT.BorderFocusColor = Color.HotPink;
            txtSDT.BorderRadius = 8;
            txtSDT.BorderSize = 1;
            txtSDT.Cursor = Cursors.Hand;
            txtSDT.Location = new Point(205, 247);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Multiline = false;
            txtSDT.Name = "txtSDT";
            txtSDT.Padding = new Padding(11, 9, 11, 9);
            txtSDT.PasswordChar = false;
            txtSDT.PlaceholderColor = Color.DarkGray;
            txtSDT.PlaceholderText = "";
            txtSDT.Size = new Size(229, 40);
            txtSDT.TabIndex = 46;
            txtSDT.Texts = "";
            txtSDT.UnderlinedStyle = false;
            // 
            // txtNhuCauKham
            // 
            txtNhuCauKham.BackColor = Color.White;
            txtNhuCauKham.BorderColor = Color.FromArgb(27, 117, 188);
            txtNhuCauKham.BorderFocusColor = Color.HotPink;
            txtNhuCauKham.BorderRadius = 8;
            txtNhuCauKham.BorderSize = 1;
            txtNhuCauKham.Cursor = Cursors.Hand;
            txtNhuCauKham.Location = new Point(205, 501);
            txtNhuCauKham.Margin = new Padding(3, 4, 3, 4);
            txtNhuCauKham.Multiline = false;
            txtNhuCauKham.Name = "txtNhuCauKham";
            txtNhuCauKham.Padding = new Padding(11, 9, 11, 9);
            txtNhuCauKham.PasswordChar = false;
            txtNhuCauKham.PlaceholderColor = Color.DarkGray;
            txtNhuCauKham.PlaceholderText = "";
            txtNhuCauKham.Size = new Size(229, 40);
            txtNhuCauKham.TabIndex = 46;
            txtNhuCauKham.Texts = "";
            txtNhuCauKham.UnderlinedStyle = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundColor = Color.Transparent;
            btnSave.BorderColor = Color.FromArgb(27, 117, 188);
            btnSave.BorderRadius = 10;
            btnSave.BorderSize = 1;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(205, 569);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 38);
            btnSave.TabIndex = 47;
            btnSave.Text = "Lưu";
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddUpdateLichKham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(493, 632);
            Controls.Add(btnSave);
            Controls.Add(txtNhuCauKham);
            Controls.Add(txtSDT);
            Controls.Add(txtTenBN);
            Controls.Add(cbKhoa);
            Controls.Add(label8);
            Controls.Add(cboTenBS);
            Controls.Add(cboLoaiBN);
            Controls.Add(dtpNgaySinhBN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpLichHen);
            Controls.Add(panelTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "AddUpdateLichKham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông Tin Lịch Khám";
            FormClosed += AddUpdateLichKham_FormClosed;
            Load += AddUpdateLichKham_Load;
            Resize += Form_Resize;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbKhoa;
        private Label label8;
        private ComboBox cboTenBS;
        private ComboBox cboLoaiBN;
        private DateTimePicker dtpNgaySinhBN;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpLichHen;
        private Panel panelTitleBar;
        private Button btnThoat;
        private CustomControls.RJControls.RJTextBox txtTenBN;
        private CustomControls.RJControls.RJTextBox txtSDT;
        private CustomControls.RJControls.RJTextBox txtNhuCauKham;
        private PhongKham.RJControls.RJButton btnSave;
        private Label lblTitle;
    }
}