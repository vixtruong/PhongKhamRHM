namespace PhongKhamDaKhoa.Group8
{
    partial class QuanLyKhoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhoForm));
            btnXoa = new PhongKham.RJControls.RJButton();
            btnSua = new PhongKham.RJControls.RJButton();
            dgvVP = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            btnSan = new PhongKham.RJControls.RJButton();
            btnChua = new PhongKham.RJControls.RJButton();
            label1 = new Label();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            cbLoaiVP = new ComboBox();
            btnSearchLT = new Button();
            txtTimkiem = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVP).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(234, 79, 82);
            btnXoa.BackgroundColor = Color.FromArgb(234, 79, 82);
            btnXoa.BorderColor = Color.LightGreen;
            btnXoa.BorderRadius = 10;
            btnXoa.BorderSize = 0;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(642, 588);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 39);
            btnXoa.TabIndex = 28;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(114, 162, 247);
            btnSua.BackgroundColor = Color.FromArgb(114, 162, 247);
            btnSua.BorderColor = Color.LemonChiffon;
            btnSua.BorderRadius = 10;
            btnSua.BorderSize = 0;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(537, 588);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(101, 39);
            btnSua.TabIndex = 29;
            btnSua.Text = "Sửa";
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgvVP
            // 
            dgvVP.Anchor = AnchorStyles.Top;
            dgvVP.BackgroundColor = Color.White;
            dgvVP.BorderStyle = BorderStyle.Fixed3D;
            dgvVP.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvVP.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVP.ColumnHeadersHeight = 29;
            dgvVP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVP.EnableHeadersVisualStyles = false;
            dgvVP.GridColor = Color.White;
            dgvVP.Location = new Point(21, 192);
            dgvVP.Margin = new Padding(3, 4, 3, 4);
            dgvVP.MultiSelect = false;
            dgvVP.Name = "dgvVP";
            dgvVP.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVP.RowHeadersVisible = false;
            dgvVP.RowHeadersWidth = 40;
            dgvVP.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvVP.RowTemplate.ReadOnly = true;
            dgvVP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVP.Size = new Size(722, 375);
            dgvVP.TabIndex = 27;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(290, 100);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 24;
            label3.Text = "Tìm kiếm theo tên:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 100);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 25;
            label2.Text = "Loại vật phẩm:";
            // 
            // btnSan
            // 
            btnSan.BackColor = Color.DarkSlateGray;
            btnSan.BackgroundColor = Color.DarkSlateGray;
            btnSan.BorderColor = Color.LightGreen;
            btnSan.BorderRadius = 10;
            btnSan.BorderSize = 0;
            btnSan.Cursor = Cursors.Hand;
            btnSan.FlatAppearance.BorderSize = 0;
            btnSan.FlatStyle = FlatStyle.Flat;
            btnSan.ForeColor = Color.White;
            btnSan.Location = new Point(128, 590);
            btnSan.Margin = new Padding(3, 4, 3, 4);
            btnSan.Name = "btnSan";
            btnSan.Size = new Size(103, 39);
            btnSan.TabIndex = 30;
            btnSan.Text = "Có sẵn";
            btnSan.TextColor = Color.White;
            btnSan.UseVisualStyleBackColor = false;
            btnSan.Click += btnNhapKho_Click;
            // 
            // btnChua
            // 
            btnChua.BackColor = Color.Gray;
            btnChua.BackgroundColor = Color.Gray;
            btnChua.BorderColor = Color.LightGreen;
            btnChua.BorderRadius = 10;
            btnChua.BorderSize = 0;
            btnChua.Cursor = Cursors.Hand;
            btnChua.FlatAppearance.BorderSize = 0;
            btnChua.FlatStyle = FlatStyle.Flat;
            btnChua.ForeColor = Color.White;
            btnChua.Location = new Point(237, 590);
            btnChua.Margin = new Padding(3, 4, 3, 4);
            btnChua.Name = "btnChua";
            btnChua.Size = new Size(101, 39);
            btnChua.TabIndex = 32;
            btnChua.Text = "Chưa có";
            btnChua.TextColor = Color.White;
            btnChua.UseVisualStyleBackColor = false;
            btnChua.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(19, 594);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 33;
            label1.Text = "Nhập kho:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(709, 20);
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
            panelTitleBar.Controls.Add(pictureBox6);
            panelTitleBar.Controls.Add(pictureBox3);
            panelTitleBar.Controls.Add(label7);
            panelTitleBar.Controls.Add(label6);
            panelTitleBar.Controls.Add(btnThoat);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(766, 84);
            panelTitleBar.TabIndex = 58;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(622, 4);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 76);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 74;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.FromArgb(27, 117, 188);
            label7.Location = new Point(101, 42);
            label7.Name = "label7";
            label7.Size = new Size(146, 23);
            label7.TabIndex = 8;
            label7.Text = "RĂNG HÀM MẶT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.FromArgb(27, 117, 188);
            label6.Location = new Point(90, 12);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 7;
            label6.Text = "PHÒNG KHÁM";
            // 
            // cbLoaiVP
            // 
            cbLoaiVP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbLoaiVP.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbLoaiVP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbLoaiVP.FormattingEnabled = true;
            cbLoaiVP.Location = new Point(21, 134);
            cbLoaiVP.Margin = new Padding(3, 4, 3, 4);
            cbLoaiVP.Name = "cbLoaiVP";
            cbLoaiVP.Size = new Size(262, 36);
            cbLoaiVP.TabIndex = 59;
            cbLoaiVP.SelectedIndexChanged += cbLoaiVP_OnSelectedIndexChanged;
            // 
            // btnSearchLT
            // 
            btnSearchLT.Cursor = Cursors.Hand;
            btnSearchLT.Image = (Image)resources.GetObject("btnSearchLT.Image");
            btnSearchLT.Location = new Point(698, 130);
            btnSearchLT.Margin = new Padding(3, 4, 3, 4);
            btnSearchLT.Name = "btnSearchLT";
            btnSearchLT.Size = new Size(45, 42);
            btnSearchLT.TabIndex = 60;
            btnSearchLT.UseVisualStyleBackColor = true;
            btnSearchLT.Click += btnSearchLT_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BackColor = SystemColors.Window;
            txtTimkiem.BorderColor = Color.FromArgb(27, 117, 188);
            txtTimkiem.BorderFocusColor = Color.HotPink;
            txtTimkiem.BorderRadius = 8;
            txtTimkiem.BorderSize = 1;
            txtTimkiem.Cursor = Cursors.IBeam;
            txtTimkiem.Font = new Font("Segoe UI", 11F);
            txtTimkiem.Location = new Point(307, 131);
            txtTimkiem.Multiline = false;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Padding = new Padding(10, 7, 10, 7);
            txtTimkiem.PasswordChar = false;
            txtTimkiem.PlaceholderColor = Color.DarkGray;
            txtTimkiem.PlaceholderText = "";
            txtTimkiem.Size = new Size(385, 40);
            txtTimkiem.TabIndex = 61;
            txtTimkiem.Texts = "";
            txtTimkiem.UnderlinedStyle = false;
            // 
            // QuanLyKhoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(766, 653);
            Controls.Add(txtTimkiem);
            Controls.Add(btnSearchLT);
            Controls.Add(cbLoaiVP);
            Controls.Add(label1);
            Controls.Add(btnChua);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnSan);
            Controls.Add(dgvVP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuanLyKhoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tồn Kho";
            Load += QuanLyKhoForm_Load;
            Resize += Form_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvVP).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PhongKham.RJControls.RJButton btnXoa;
        private PhongKham.RJControls.RJButton btnSua;
        private DataGridView dgvVP;
        private Label label3;
        private Label label2;
        private PhongKham.RJControls.RJButton btnSan;
        private PhongKham.RJControls.RJButton btnChua;
        private Label label1;
        private Button btnThoat;
        private Panel panelTitleBar;
        private ComboBox cbLoaiVP;
        private Button btnSearchLT;
        private CustomControls.RJControls.RJTextBox txtTimkiem;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox6;
    }
}