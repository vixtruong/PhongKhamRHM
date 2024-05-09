namespace WinFormsApp4
{
    partial class LeTanForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeTanForm));
            btnXepLichKham = new PhongKham.RJControls.RJButton();
            panel1 = new Panel();
            dtpNgayKham = new PhongKhamDaKhoa.Group8.RJControls.RJDatePicker();
            label3 = new Label();
            line = new Label();
            dgvLichKham = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            btnThoat = new Button();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            btnXepLichLam = new PhongKham.RJControls.RJButton();
            btnXemThongKe = new PhongKham.RJControls.RJButton();
            btnXemTonKho = new PhongKham.RJControls.RJButton();
            btnThanhToan = new PhongKham.RJControls.RJButton();
            btnThongTinNV = new PhongKham.RJControls.RJButton();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnXepLichKham
            // 
            btnXepLichKham.BackColor = Color.Transparent;
            btnXepLichKham.BackgroundColor = Color.Transparent;
            btnXepLichKham.BorderColor = Color.FromArgb(27, 117, 188);
            btnXepLichKham.BorderRadius = 15;
            btnXepLichKham.BorderSize = 1;
            btnXepLichKham.Cursor = Cursors.Hand;
            btnXepLichKham.FlatAppearance.BorderSize = 0;
            btnXepLichKham.FlatStyle = FlatStyle.Flat;
            btnXepLichKham.Font = new Font("Segoe UI", 9.75F);
            btnXepLichKham.ForeColor = Color.Black;
            btnXepLichKham.Image = (Image)resources.GetObject("btnXepLichKham.Image");
            btnXepLichKham.ImageAlign = ContentAlignment.TopCenter;
            btnXepLichKham.Location = new Point(322, 83);
            btnXepLichKham.Margin = new Padding(3, 4, 3, 4);
            btnXepLichKham.Name = "btnXepLichKham";
            btnXepLichKham.RightToLeft = RightToLeft.No;
            btnXepLichKham.Size = new Size(158, 179);
            btnXepLichKham.TabIndex = 1;
            btnXepLichKham.Text = "Xem Lịch Khám";
            btnXepLichKham.TextAlign = ContentAlignment.BottomCenter;
            btnXepLichKham.TextColor = Color.Black;
            btnXepLichKham.UseVisualStyleBackColor = false;
            btnXepLichKham.Click += btnXemLichKham_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dtpNgayKham);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(line);
            panel1.Controls.Add(dgvLichKham);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 577);
            panel1.TabIndex = 19;
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.BorderColor = Color.PaleVioletRed;
            dtpNgayKham.BorderSize = 0;
            dtpNgayKham.Enabled = false;
            dtpNgayKham.Font = new Font("Segoe UI", 9.5F);
            dtpNgayKham.Location = new Point(16, 121);
            dtpNgayKham.MinimumSize = new Size(4, 35);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(228, 35);
            dtpNgayKham.SkinColor = Color.White;
            dtpNgayKham.TabIndex = 1;
            dtpNgayKham.TextColor = Color.Black;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(27, 117, 188);
            label3.Location = new Point(27, 101);
            label3.Name = "label3";
            label3.Size = new Size(209, 3);
            label3.TabIndex = 7;
            // 
            // line
            // 
            line.BackColor = Color.FromArgb(27, 117, 188);
            line.Location = new Point(27, 459);
            line.Name = "line";
            line.Size = new Size(209, 3);
            line.TabIndex = 7;
            // 
            // dgvLichKham
            // 
            dgvLichKham.BackgroundColor = SystemColors.ControlLightLight;
            dgvLichKham.BorderStyle = BorderStyle.Fixed3D;
            dgvLichKham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichKham.Location = new Point(16, 169);
            dgvLichKham.Margin = new Padding(3, 4, 3, 4);
            dgvLichKham.Name = "dgvLichKham";
            dgvLichKham.RowHeadersVisible = false;
            dgvLichKham.RowHeadersWidth = 62;
            dgvLichKham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichKham.Size = new Size(229, 276);
            dgvLichKham.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(67, 472);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 6;
            label1.Text = "Contact For Work:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(111, 505);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 6;
            label2.Text = "Nhân Đỗ";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(41, 537);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(77, 503);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(73, 541);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 5;
            label4.Text = "drnhan1211@gmail.com";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.BackColor = Color.Transparent;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(560, 15);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(1, 0, 0, 0);
            btnThoat.Size = new Size(38, 39);
            btnThoat.TabIndex = 0;
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            btnThoat.MouseEnter += button_MouseEnter;
            btnThoat.MouseLeave += button_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 97);
            panel3.TabIndex = 6;
            panel3.MouseDown += panelTitleBar_MouseDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.FromArgb(27, 117, 188);
            label7.Location = new Point(101, 53);
            label7.Name = "label7";
            label7.Size = new Size(146, 23);
            label7.TabIndex = 5;
            label7.Text = "RĂNG HÀM MẶT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.FromArgb(27, 117, 188);
            label6.Location = new Point(91, 13);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 4;
            label6.Text = "PHÒNG KHÁM";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 1);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnXepLichLam
            // 
            btnXepLichLam.BackColor = Color.Transparent;
            btnXepLichLam.BackgroundColor = Color.Transparent;
            btnXepLichLam.BorderColor = Color.FromArgb(27, 117, 188);
            btnXepLichLam.BorderRadius = 15;
            btnXepLichLam.BorderSize = 1;
            btnXepLichLam.Cursor = Cursors.Hand;
            btnXepLichLam.FlatAppearance.BorderSize = 0;
            btnXepLichLam.FlatStyle = FlatStyle.Flat;
            btnXepLichLam.Font = new Font("Segoe UI", 9.75F);
            btnXepLichLam.ForeColor = Color.Black;
            btnXepLichLam.Image = (Image)resources.GetObject("btnXepLichLam.Image");
            btnXepLichLam.ImageAlign = ContentAlignment.TopCenter;
            btnXepLichLam.Location = new Point(503, 83);
            btnXepLichLam.Margin = new Padding(3, 4, 3, 4);
            btnXepLichLam.Name = "btnXepLichLam";
            btnXepLichLam.Size = new Size(158, 179);
            btnXepLichLam.TabIndex = 2;
            btnXepLichLam.Text = "Xếp Lịch Làm Việc";
            btnXepLichLam.TextAlign = ContentAlignment.BottomCenter;
            btnXepLichLam.TextColor = Color.Black;
            btnXepLichLam.UseVisualStyleBackColor = false;
            btnXepLichLam.Click += btnXepLichLam_Click;
            // 
            // btnXemThongKe
            // 
            btnXemThongKe.BackColor = Color.Transparent;
            btnXemThongKe.BackgroundColor = Color.Transparent;
            btnXemThongKe.BorderColor = Color.FromArgb(27, 117, 188);
            btnXemThongKe.BorderRadius = 15;
            btnXemThongKe.BorderSize = 1;
            btnXemThongKe.Cursor = Cursors.Hand;
            btnXemThongKe.FlatAppearance.BorderSize = 0;
            btnXemThongKe.FlatStyle = FlatStyle.Flat;
            btnXemThongKe.Font = new Font("Segoe UI", 9.75F);
            btnXemThongKe.ForeColor = Color.Black;
            btnXemThongKe.Image = (Image)resources.GetObject("btnXemThongKe.Image");
            btnXemThongKe.ImageAlign = ContentAlignment.TopCenter;
            btnXemThongKe.Location = new Point(678, 83);
            btnXemThongKe.Margin = new Padding(3, 4, 3, 4);
            btnXemThongKe.Name = "btnXemThongKe";
            btnXemThongKe.Size = new Size(158, 179);
            btnXemThongKe.TabIndex = 3;
            btnXemThongKe.Text = "Xem Thống Kê";
            btnXemThongKe.TextAlign = ContentAlignment.BottomCenter;
            btnXemThongKe.TextColor = Color.Black;
            btnXemThongKe.UseVisualStyleBackColor = false;
            btnXemThongKe.Click += btnXemThongKe_Click;
            // 
            // btnXemTonKho
            // 
            btnXemTonKho.BackColor = Color.Transparent;
            btnXemTonKho.BackgroundColor = Color.Transparent;
            btnXemTonKho.BorderColor = Color.FromArgb(27, 117, 188);
            btnXemTonKho.BorderRadius = 15;
            btnXemTonKho.BorderSize = 1;
            btnXemTonKho.Cursor = Cursors.Hand;
            btnXemTonKho.FlatAppearance.BorderSize = 0;
            btnXemTonKho.FlatStyle = FlatStyle.Flat;
            btnXemTonKho.Font = new Font("Segoe UI", 9.75F);
            btnXemTonKho.ForeColor = Color.Black;
            btnXemTonKho.Image = (Image)resources.GetObject("btnXemTonKho.Image");
            btnXemTonKho.ImageAlign = ContentAlignment.TopCenter;
            btnXemTonKho.Location = new Point(503, 283);
            btnXemTonKho.Margin = new Padding(3, 4, 3, 4);
            btnXemTonKho.Name = "btnXemTonKho";
            btnXemTonKho.Size = new Size(158, 179);
            btnXemTonKho.TabIndex = 4;
            btnXemTonKho.Text = "Quản Lý Kho";
            btnXemTonKho.TextAlign = ContentAlignment.BottomCenter;
            btnXemTonKho.TextColor = Color.Black;
            btnXemTonKho.UseVisualStyleBackColor = false;
            btnXemTonKho.Click += btnXemTonKho_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Transparent;
            btnThanhToan.BackgroundColor = Color.Transparent;
            btnThanhToan.BorderColor = Color.FromArgb(27, 117, 188);
            btnThanhToan.BorderRadius = 15;
            btnThanhToan.BorderSize = 1;
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 9.75F);
            btnThanhToan.ForeColor = Color.Black;
            btnThanhToan.Image = (Image)resources.GetObject("btnThanhToan.Image");
            btnThanhToan.ImageAlign = ContentAlignment.TopCenter;
            btnThanhToan.Location = new Point(322, 283);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(158, 179);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.TextAlign = ContentAlignment.BottomCenter;
            btnThanhToan.TextColor = Color.Black;
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnHoaDon_Click;
            // 
            // btnThongTinNV
            // 
            btnThongTinNV.BackColor = Color.Transparent;
            btnThongTinNV.BackgroundColor = Color.Transparent;
            btnThongTinNV.BorderColor = Color.FromArgb(27, 117, 188);
            btnThongTinNV.BorderRadius = 15;
            btnThongTinNV.BorderSize = 1;
            btnThongTinNV.Cursor = Cursors.Hand;
            btnThongTinNV.FlatAppearance.BorderSize = 0;
            btnThongTinNV.FlatStyle = FlatStyle.Flat;
            btnThongTinNV.Font = new Font("Segoe UI", 9.75F);
            btnThongTinNV.ForeColor = Color.Black;
            btnThongTinNV.Image = (Image)resources.GetObject("btnThongTinNV.Image");
            btnThongTinNV.ImageAlign = ContentAlignment.TopCenter;
            btnThongTinNV.Location = new Point(678, 283);
            btnThongTinNV.Margin = new Padding(3, 4, 3, 4);
            btnThongTinNV.Name = "btnThongTinNV";
            btnThongTinNV.Size = new Size(158, 179);
            btnThongTinNV.TabIndex = 6;
            btnThongTinNV.Text = "Quản Lý Nhân Sự";
            btnThongTinNV.TextAlign = ContentAlignment.BottomCenter;
            btnThongTinNV.TextColor = Color.Black;
            btnThongTinNV.UseVisualStyleBackColor = false;
            btnThongTinNV.Click += btnThongTinNV_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(259, 505);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 72);
            panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(325, 3);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(262, 3);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Location = new Point(259, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(613, 69);
            panelTitleBar.TabIndex = 21;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // LeTanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 577);
            Controls.Add(panelTitleBar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnThongTinNV);
            Controls.Add(btnXemThongKe);
            Controls.Add(btnThanhToan);
            Controls.Add(btnXepLichLam);
            Controls.Add(btnXemTonKho);
            Controls.Add(btnXepLichKham);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LeTanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Lễ Tân";
            FormClosed += LeTanForm_FormClosed;
            Load += LeTanForm_Load;
            Resize += LeTanForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PhongKham.RJControls.RJButton btnXepLichKham;
        private Panel panel1;
        private PhongKham.RJControls.RJButton btnXepLichLam;
        private PhongKham.RJControls.RJButton btnXemThongKe;
        private PhongKham.RJControls.RJButton btnXemTonKho;
        private PhongKham.RJControls.RJButton btnThanhToan;
        private PhongKham.RJControls.RJButton btnThongTinNV;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox3;
        private Button btnThoat;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label line;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label3;
        private Panel panelTitleBar;
        private PhongKhamDaKhoa.Group8.RJControls.RJDatePicker dtpNgayKham;
        private DataGridView dgvLichKham;
    }
}
