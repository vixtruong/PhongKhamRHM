namespace PhongKhamDaKhoa.Group8
{
    partial class AddHoSoBenhAnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHoSoBenhAnForm));
            txtMaBN = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dtpNgayKham = new RJControls.RJDatePicker();
            btnLuu = new PhongKham.RJControls.RJButton();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            txtTinhTrang = new RichTextBox();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaBN
            // 
            txtMaBN.BackColor = Color.White;
            txtMaBN.BorderColor = Color.FromArgb(27, 117, 188);
            txtMaBN.BorderFocusColor = Color.HotPink;
            txtMaBN.BorderRadius = 8;
            txtMaBN.BorderSize = 1;
            txtMaBN.Cursor = Cursors.IBeam;
            txtMaBN.Location = new Point(172, 44);
            txtMaBN.Multiline = false;
            txtMaBN.Name = "txtMaBN";
            txtMaBN.Padding = new Padding(10, 7, 10, 7);
            txtMaBN.PasswordChar = false;
            txtMaBN.PlaceholderColor = Color.DarkGray;
            txtMaBN.PlaceholderText = "";
            txtMaBN.Size = new Size(238, 36);
            txtMaBN.TabIndex = 0;
            txtMaBN.Texts = "";
            txtMaBN.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã bệnh nhân:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 171);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 3;
            label2.Text = "Tình trạng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(15, 117);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 6;
            label4.Text = "Ngày khám:";
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.BorderColor = Color.FromArgb(27, 117, 188);
            dtpNgayKham.BorderSize = 1;
            dtpNgayKham.Font = new Font("Segoe UI", 9.5F);
            dtpNgayKham.Location = new Point(172, 107);
            dtpNgayKham.MinimumSize = new Size(4, 35);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(237, 35);
            dtpNgayKham.SkinColor = SystemColors.ControlLightLight;
            dtpNgayKham.TabIndex = 7;
            dtpNgayKham.TextColor = Color.Black;
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
            btnLuu.Location = new Point(230, 361);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(107, 44);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.TextColor = Color.Black;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(406, 9);
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
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(450, 61);
            panelTitleBar.TabIndex = 44;
            panelTitleBar.MouseEnter += button_MouseEnter;
            panelTitleBar.MouseLeave += button_MouseLeave;
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Cursor = Cursors.IBeam;
            txtTinhTrang.Location = new Point(173, 171);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(237, 163);
            txtTinhTrang.TabIndex = 8;
            txtTinhTrang.Text = "";
            // 
            // AddHoSoBenhAnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(450, 420);
            Controls.Add(txtTinhTrang);
            Controls.Add(dtpNgayKham);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaBN);
            Controls.Add(panelTitleBar);
            Controls.Add(btnLuu);
            Name = "AddHoSoBenhAnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Bệnh Án";
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtMaBN;
        private Label label1;
        private Label label2;
        private Label label4;
        private RJControls.RJDatePicker dtpNgayKham;
        private PhongKham.RJControls.RJButton btnLuu;
        private Button btnThoat;
        private Panel panelTitleBar;
        private RichTextBox txtTinhTrang;
    }
}