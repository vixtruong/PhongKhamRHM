namespace PhongKhamDaKhoa.Group8
{
    partial class AddVatLieuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVatLieuForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnLuu = new PhongKham.RJControls.RJButton();
            txtSoluong = new CustomControls.RJControls.RJTextBox();
            txtDvt = new CustomControls.RJControls.RJTextBox();
            txtGia = new CustomControls.RJControls.RJTextBox();
            txtName = new CustomControls.RJControls.RJTextBox();
            cbLoai = new ComboBox();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(118, 19);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 0;
            label1.Text = "Thêm thông tin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(26, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(26, 208);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 2;
            label3.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(26, 273);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 3;
            label4.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(26, 339);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 4;
            label5.Text = "Giá:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(26, 77);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 5;
            label6.Text = "Loại:";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.BackgroundColor = Color.Transparent;
            btnLuu.BorderColor = Color.FromArgb(27, 117, 188);
            btnLuu.BorderRadius = 10;
            btnLuu.BorderSize = 1;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(144, 399);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 43);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.TextColor = Color.Black;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtSoluong
            // 
            txtSoluong.BackColor = SystemColors.Window;
            txtSoluong.BorderColor = Color.FromArgb(27, 117, 188);
            txtSoluong.BorderFocusColor = Color.HotPink;
            txtSoluong.BorderRadius = 8;
            txtSoluong.BorderSize = 1;
            txtSoluong.Location = new Point(144, 207);
            txtSoluong.Multiline = false;
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Padding = new Padding(10, 7, 10, 7);
            txtSoluong.PasswordChar = false;
            txtSoluong.PlaceholderColor = Color.DarkGray;
            txtSoluong.PlaceholderText = "";
            txtSoluong.Size = new Size(216, 36);
            txtSoluong.TabIndex = 14;
            txtSoluong.Texts = "";
            txtSoluong.UnderlinedStyle = false;
            // 
            // txtDvt
            // 
            txtDvt.BackColor = SystemColors.Window;
            txtDvt.BorderColor = Color.FromArgb(27, 117, 188);
            txtDvt.BorderFocusColor = Color.HotPink;
            txtDvt.BorderRadius = 8;
            txtDvt.BorderSize = 1;
            txtDvt.Location = new Point(144, 271);
            txtDvt.Multiline = false;
            txtDvt.Name = "txtDvt";
            txtDvt.Padding = new Padding(10, 7, 10, 7);
            txtDvt.PasswordChar = false;
            txtDvt.PlaceholderColor = Color.DarkGray;
            txtDvt.PlaceholderText = "";
            txtDvt.Size = new Size(216, 36);
            txtDvt.TabIndex = 15;
            txtDvt.Texts = "";
            txtDvt.UnderlinedStyle = false;
            // 
            // txtGia
            // 
            txtGia.BackColor = SystemColors.Window;
            txtGia.BorderColor = Color.FromArgb(27, 117, 188);
            txtGia.BorderFocusColor = Color.HotPink;
            txtGia.BorderRadius = 8;
            txtGia.BorderSize = 1;
            txtGia.Location = new Point(144, 335);
            txtGia.Multiline = false;
            txtGia.Name = "txtGia";
            txtGia.Padding = new Padding(10, 7, 10, 7);
            txtGia.PasswordChar = false;
            txtGia.PlaceholderColor = Color.DarkGray;
            txtGia.PlaceholderText = "";
            txtGia.Size = new Size(216, 36);
            txtGia.TabIndex = 16;
            txtGia.Texts = "";
            txtGia.UnderlinedStyle = false;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderColor = Color.FromArgb(27, 117, 188);
            txtName.BorderFocusColor = Color.HotPink;
            txtName.BorderRadius = 8;
            txtName.BorderSize = 1;
            txtName.Location = new Point(144, 143);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(10, 7, 10, 7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.DarkGray;
            txtName.PlaceholderText = "";
            txtName.Size = new Size(216, 36);
            txtName.TabIndex = 17;
            txtName.Texts = "";
            txtName.UnderlinedStyle = false;
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(144, 77);
            cbLoai.Margin = new Padding(3, 4, 3, 4);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(215, 28);
            cbLoai.TabIndex = 18;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(350, 9);
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
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(398, 61);
            panelTitleBar.TabIndex = 44;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // AddVatLieuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(398, 464);
            Controls.Add(panelTitleBar);
            Controls.Add(cbLoai);
            Controls.Add(txtName);
            Controls.Add(txtGia);
            Controls.Add(txtDvt);
            Controls.Add(txtSoluong);
            Controls.Add(btnLuu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Cursor = Cursors.IBeam;
            Name = "AddVatLieuForm";
            Text = "AddUpdateVatLieu";
            Load += AddUpdateVatLieu_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PhongKham.RJControls.RJButton btnLuu;
        private CustomControls.RJControls.RJTextBox txtSoluong;
        private CustomControls.RJControls.RJTextBox txtDvt;
        private CustomControls.RJControls.RJTextBox txtGia;
        private CustomControls.RJControls.RJTextBox txtName;
        private ComboBox cbLoai;
        private Button btnThoat;
        private Panel panelTitleBar;
    }
}