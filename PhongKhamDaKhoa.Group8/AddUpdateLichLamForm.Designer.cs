namespace PhongKhamNhaKhoa
{
    partial class AddUpdateLichLamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateLichLamForm));
            lblTitle = new Label();
            cbKhoa = new ComboBox();
            label3 = new Label();
            cboTenPT = new ComboBox();
            cboTenBS = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpNgayLamViec = new DateTimePicker();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            txtMaLL = new CustomControls.RJControls.RJTextBox();
            txtCaLam = new CustomControls.RJControls.RJTextBox();
            btnSave = new PhongKham.RJControls.RJButton();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(137, 12);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 32);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Thêm Mới Lịch Làm";
            // 
            // cbKhoa
            // 
            cbKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKhoa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbKhoa.Font = new Font("Segoe UI", 10.8F);
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(202, 225);
            cbKhoa.Margin = new Padding(2, 3, 2, 3);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(249, 33);
            cbKhoa.TabIndex = 27;
            cbKhoa.SelectedIndexChanged += cbKhoa_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(34, 225);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 28;
            label3.Text = "Khoa:";
            // 
            // cboTenPT
            // 
            cboTenPT.Font = new Font("Segoe UI", 10.8F);
            cboTenPT.FormattingEnabled = true;
            cboTenPT.Location = new Point(202, 362);
            cboTenPT.Margin = new Padding(2, 3, 2, 3);
            cboTenPT.Name = "cboTenPT";
            cboTenPT.Size = new Size(249, 33);
            cboTenPT.TabIndex = 22;
            // 
            // cboTenBS
            // 
            cboTenBS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenBS.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTenBS.Font = new Font("Segoe UI", 10.8F);
            cboTenBS.FormattingEnabled = true;
            cboTenBS.Location = new Point(202, 297);
            cboTenBS.Margin = new Padding(2, 3, 2, 3);
            cboTenBS.Name = "cboTenBS";
            cboTenBS.Size = new Size(249, 33);
            cboTenBS.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(34, 89);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 26;
            label8.Text = "Mã lich làm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(34, 427);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 25;
            label5.Text = "Ca làm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(34, 363);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 24;
            label4.Text = "Tên phụ tá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(34, 296);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 21;
            label2.Text = "Tên bác sĩ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(34, 156);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 18;
            label1.Text = "Ngày làm việc:";
            // 
            // dtpNgayLamViec
            // 
            dtpNgayLamViec.CustomFormat = "dd/MM/yyyy ";
            dtpNgayLamViec.Font = new Font("Segoe UI", 10.8F);
            dtpNgayLamViec.Location = new Point(202, 157);
            dtpNgayLamViec.Margin = new Padding(2, 3, 2, 3);
            dtpNgayLamViec.Name = "dtpNgayLamViec";
            dtpNgayLamViec.Size = new Size(246, 31);
            dtpNgayLamViec.TabIndex = 19;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(431, 8);
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
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(482, 61);
            panelTitleBar.TabIndex = 46;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // txtMaLL
            // 
            txtMaLL.BackColor = SystemColors.ControlLightLight;
            txtMaLL.BorderColor = Color.FromArgb(27, 117, 188);
            txtMaLL.BorderFocusColor = Color.HotPink;
            txtMaLL.BorderRadius = 8;
            txtMaLL.BorderSize = 1;
            txtMaLL.Cursor = Cursors.IBeam;
            txtMaLL.Location = new Point(201, 85);
            txtMaLL.Margin = new Padding(3, 4, 3, 4);
            txtMaLL.Multiline = false;
            txtMaLL.Name = "txtMaLL";
            txtMaLL.Padding = new Padding(11, 9, 11, 9);
            txtMaLL.PasswordChar = false;
            txtMaLL.PlaceholderColor = Color.DarkGray;
            txtMaLL.PlaceholderText = "";
            txtMaLL.Size = new Size(250, 40);
            txtMaLL.TabIndex = 47;
            txtMaLL.Texts = "";
            txtMaLL.UnderlinedStyle = false;
            // 
            // txtCaLam
            // 
            txtCaLam.BackColor = Color.White;
            txtCaLam.BorderColor = Color.FromArgb(27, 117, 188);
            txtCaLam.BorderFocusColor = Color.HotPink;
            txtCaLam.BorderRadius = 8;
            txtCaLam.BorderSize = 1;
            txtCaLam.Cursor = Cursors.IBeam;
            txtCaLam.Location = new Point(201, 424);
            txtCaLam.Margin = new Padding(3, 4, 3, 4);
            txtCaLam.Multiline = false;
            txtCaLam.Name = "txtCaLam";
            txtCaLam.Padding = new Padding(11, 9, 11, 9);
            txtCaLam.PasswordChar = false;
            txtCaLam.PlaceholderColor = Color.DarkGray;
            txtCaLam.PlaceholderText = "";
            txtCaLam.Size = new Size(250, 40);
            txtCaLam.TabIndex = 48;
            txtCaLam.Texts = "";
            txtCaLam.UnderlinedStyle = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundColor = Color.Transparent;
            btnSave.BorderColor = Color.FromArgb(27, 117, 188);
            btnSave.BorderRadius = 10;
            btnSave.BorderSize = 1;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(201, 487);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.TextAlign = ContentAlignment.TopCenter;
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddUpdateLichLamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(482, 556);
            Controls.Add(btnSave);
            Controls.Add(txtCaLam);
            Controls.Add(txtMaLL);
            Controls.Add(panelTitleBar);
            Controls.Add(cbKhoa);
            Controls.Add(label3);
            Controls.Add(cboTenPT);
            Controls.Add(cboTenBS);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNgayLamViec);
            Margin = new Padding(2, 3, 2, 3);
            Name = "AddUpdateLichLamForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông Tin Lịch Làm Việc";
            Load += AddUpdateLichLamForm_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private ComboBox cbKhoa;
        private Label label3;
        private ComboBox cboTenPT;
        private ComboBox cboTenBS;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgayLamViec;
        private Button btnThoat;
        private Panel panelTitleBar;
        private CustomControls.RJControls.RJTextBox txtMaLL;
        private CustomControls.RJControls.RJTextBox txtCaLam;
        private PhongKham.RJControls.RJButton btnSave;
    }
}