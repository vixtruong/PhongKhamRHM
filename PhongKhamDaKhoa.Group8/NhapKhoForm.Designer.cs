namespace PhongKhamDaKhoa.Group8
{
    partial class NhapKhoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapKhoForm));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoluong = new CustomControls.RJControls.RJTextBox();
            btnLuu = new PhongKham.RJControls.RJButton();
            cbLoai = new ComboBox();
            cbDanhsach = new ComboBox();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 1;
            label2.Text = "Loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(26, 132);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 2;
            label3.Text = "Danh sách:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(26, 192);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 5;
            label4.Text = "Số lượng:";
            // 
            // txtSoluong
            // 
            txtSoluong.BackColor = SystemColors.Window;
            txtSoluong.BorderColor = Color.FromArgb(27, 117, 188);
            txtSoluong.BorderFocusColor = Color.HotPink;
            txtSoluong.BorderRadius = 8;
            txtSoluong.BorderSize = 1;
            txtSoluong.Cursor = Cursors.IBeam;
            txtSoluong.Location = new Point(126, 184);
            txtSoluong.Multiline = false;
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Padding = new Padding(10, 7, 10, 7);
            txtSoluong.PasswordChar = false;
            txtSoluong.PlaceholderColor = Color.DarkGray;
            txtSoluong.PlaceholderText = "";
            txtSoluong.Size = new Size(250, 36);
            txtSoluong.TabIndex = 6;
            txtSoluong.Texts = "";
            txtSoluong.UnderlinedStyle = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.BackgroundColor = Color.Transparent;
            btnLuu.BorderColor = Color.FromArgb(27, 117, 188);
            btnLuu.BorderRadius = 10;
            btnLuu.BorderSize = 1;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(145, 243);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 40);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.TextColor = Color.Black;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cbLoai
            // 
            cbLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbLoai.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbLoai.Font = new Font("Segoe UI", 11F);
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(126, 67);
            cbLoai.Margin = new Padding(3, 4, 3, 4);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(250, 33);
            cbLoai.TabIndex = 9;
            // 
            // cbDanhsach
            // 
            cbDanhsach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDanhsach.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbDanhsach.Font = new Font("Segoe UI", 11F);
            cbDanhsach.FormattingEnabled = true;
            cbDanhsach.Location = new Point(126, 129);
            cbDanhsach.Margin = new Padding(3, 4, 3, 4);
            cbDanhsach.Name = "cbDanhsach";
            cbDanhsach.Size = new Size(250, 33);
            cbDanhsach.TabIndex = 10;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(370, 7);
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
            panelTitleBar.Size = new Size(417, 61);
            panelTitleBar.TabIndex = 57;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(82, 14);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 32);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Thông Tin Nhập Kho";
            // 
            // NhapKhoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(417, 297);
            Controls.Add(cbDanhsach);
            Controls.Add(cbLoai);
            Controls.Add(btnLuu);
            Controls.Add(txtSoluong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NhapKhoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông Tin Nhập Kho";
            Load += NhapKhoForm_Load;
            Resize += Form_Resize;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private CustomControls.RJControls.RJTextBox txtSoluong;
        private PhongKham.RJControls.RJButton btnLuu;
        private ComboBox cbLoai;
        private ComboBox cbDanhsach;
        private Button btnThoat;
        private Panel panelTitleBar;
        private Label lblTitle;
    }
}