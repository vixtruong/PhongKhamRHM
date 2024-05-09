namespace PhongKhamDaKhoa.Group8
{
    partial class UpdateVatLieuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVatLieuForm));
            txtGia = new CustomControls.RJControls.RJTextBox();
            txtDvt = new CustomControls.RJControls.RJTextBox();
            txtSoluong = new CustomControls.RJControls.RJTextBox();
            txtName = new CustomControls.RJControls.RJTextBox();
            btnLuu = new PhongKham.RJControls.RJButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            cbLoai = new ComboBox();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // txtGia
            // 
            txtGia.BackColor = SystemColors.ControlLightLight;
            txtGia.BorderColor = Color.FromArgb(27, 117, 188);
            txtGia.BorderFocusColor = Color.HotPink;
            txtGia.BorderRadius = 8;
            txtGia.BorderSize = 1;
            txtGia.Location = new Point(173, 325);
            txtGia.Multiline = false;
            txtGia.Name = "txtGia";
            txtGia.Padding = new Padding(10, 7, 10, 7);
            txtGia.PasswordChar = false;
            txtGia.PlaceholderColor = Color.DarkGray;
            txtGia.PlaceholderText = "";
            txtGia.Size = new Size(250, 36);
            txtGia.TabIndex = 28;
            txtGia.Texts = "";
            txtGia.UnderlinedStyle = false;
            // 
            // txtDvt
            // 
            txtDvt.BackColor = SystemColors.ControlLightLight;
            txtDvt.BorderColor = Color.FromArgb(27, 117, 188);
            txtDvt.BorderFocusColor = Color.HotPink;
            txtDvt.BorderRadius = 8;
            txtDvt.BorderSize = 1;
            txtDvt.Location = new Point(173, 268);
            txtDvt.Multiline = false;
            txtDvt.Name = "txtDvt";
            txtDvt.Padding = new Padding(10, 7, 10, 7);
            txtDvt.PasswordChar = false;
            txtDvt.PlaceholderColor = Color.DarkGray;
            txtDvt.PlaceholderText = "";
            txtDvt.Size = new Size(250, 36);
            txtDvt.TabIndex = 27;
            txtDvt.Texts = "";
            txtDvt.UnderlinedStyle = false;
            // 
            // txtSoluong
            // 
            txtSoluong.BackColor = SystemColors.ControlLightLight;
            txtSoluong.BorderColor = Color.FromArgb(27, 117, 188);
            txtSoluong.BorderFocusColor = Color.HotPink;
            txtSoluong.BorderRadius = 8;
            txtSoluong.BorderSize = 1;
            txtSoluong.Location = new Point(173, 209);
            txtSoluong.Multiline = false;
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Padding = new Padding(10, 7, 10, 7);
            txtSoluong.PasswordChar = false;
            txtSoluong.PlaceholderColor = Color.DarkGray;
            txtSoluong.PlaceholderText = "";
            txtSoluong.Size = new Size(250, 36);
            txtSoluong.TabIndex = 26;
            txtSoluong.Texts = "";
            txtSoluong.UnderlinedStyle = false;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ControlLightLight;
            txtName.BorderColor = Color.FromArgb(27, 117, 188);
            txtName.BorderFocusColor = Color.HotPink;
            txtName.BorderRadius = 8;
            txtName.BorderSize = 1;
            txtName.Location = new Point(173, 153);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(10, 7, 10, 7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.DarkGray;
            txtName.PlaceholderText = "";
            txtName.Size = new Size(250, 36);
            txtName.TabIndex = 25;
            txtName.Texts = "";
            txtName.UnderlinedStyle = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.BackgroundColor = Color.Transparent;
            btnLuu.BorderColor = Color.FromArgb(27, 117, 188);
            btnLuu.BorderRadius = 8;
            btnLuu.BorderSize = 1;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(173, 386);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 39);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.TextColor = Color.Black;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(48, 89);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 22;
            label6.Text = "Loại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(48, 328);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 21;
            label5.Text = "Giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(48, 269);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 20;
            label4.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(48, 209);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 19;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 153);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 18;
            label2.Text = "Tên:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(438, 9);
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
            panelTitleBar.Size = new Size(491, 61);
            panelTitleBar.TabIndex = 57;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(136, 14);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 32);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Thông Tin Vật Liệu";
            // 
            // cbLoai
            // 
            cbLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbLoai.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbLoai.Font = new Font("Segoe UI", 11F);
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(173, 92);
            cbLoai.Margin = new Padding(3, 4, 3, 4);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(250, 33);
            cbLoai.TabIndex = 58;
            // 
            // UpdateVatLieuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(491, 469);
            Controls.Add(cbLoai);
            Controls.Add(txtGia);
            Controls.Add(txtDvt);
            Controls.Add(txtSoluong);
            Controls.Add(txtName);
            Controls.Add(btnLuu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UpdateVatLieuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập Nhật Vật Liệu";
            Load += UpdateVatLieuForm_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtGia;
        private CustomControls.RJControls.RJTextBox txtDvt;
        private CustomControls.RJControls.RJTextBox txtSoluong;
        private CustomControls.RJControls.RJTextBox txtName;
        private PhongKham.RJControls.RJButton btnLuu;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Panel panelTitleBar;
        private ComboBox cbLoai;
        private Label lblTitle;
    }
}