namespace PhongKhamNhaKhoa
{
    partial class ThongKeDoanhThuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDoanhThuForm));
            label1 = new Label();
            dtpNgayKetThuc = new DateTimePicker();
            label3 = new Label();
            dtpNgayBatDau = new DateTimePicker();
            label2 = new Label();
            btnExportExcel = new PhongKham.RJControls.RJButton();
            btnThoat = new Button();
            panelTitleBar = new Panel();
            btnXuatBieuDo = new PhongKham.RJControls.RJButton();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(161, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Thống Kê";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Location = new Point(178, 140);
            dtpNgayKetThuc.Margin = new Padding(2, 3, 2, 3);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(239, 27);
            dtpNgayKetThuc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 140);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 2;
            label3.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Location = new Point(178, 77);
            dtpNgayBatDau.Margin = new Padding(2, 3, 2, 3);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(239, 27);
            dtpNgayBatDau.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 0;
            label2.Text = "Ngày bắt đầu:";
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Transparent;
            btnExportExcel.BackgroundColor = Color.Transparent;
            btnExportExcel.BorderColor = Color.FromArgb(27, 117, 188);
            btnExportExcel.BorderRadius = 8;
            btnExportExcel.BorderSize = 1;
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.ForeColor = Color.Black;
            btnExportExcel.Image = (Image)resources.GetObject("btnExportExcel.Image");
            btnExportExcel.ImageAlign = ContentAlignment.TopCenter;
            btnExportExcel.Location = new Point(38, 209);
            btnExportExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(175, 183);
            btnExportExcel.TabIndex = 5;
            btnExportExcel.Text = "Xuất file Excel";
            btnExportExcel.TextAlign = ContentAlignment.BottomCenter;
            btnExportExcel.TextColor = Color.Black;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(397, 11);
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
            panelTitleBar.Size = new Size(447, 61);
            panelTitleBar.TabIndex = 58;
            // 
            // btnXuatBieuDo
            // 
            btnXuatBieuDo.BackColor = Color.Transparent;
            btnXuatBieuDo.BackgroundColor = Color.Transparent;
            btnXuatBieuDo.BorderColor = Color.FromArgb(27, 117, 188);
            btnXuatBieuDo.BorderRadius = 8;
            btnXuatBieuDo.BorderSize = 1;
            btnXuatBieuDo.Cursor = Cursors.Hand;
            btnXuatBieuDo.FlatAppearance.BorderSize = 0;
            btnXuatBieuDo.FlatStyle = FlatStyle.Flat;
            btnXuatBieuDo.ForeColor = Color.Black;
            btnXuatBieuDo.Image = (Image)resources.GetObject("btnXuatBieuDo.Image");
            btnXuatBieuDo.Location = new Point(222, 209);
            btnXuatBieuDo.Margin = new Padding(3, 4, 3, 4);
            btnXuatBieuDo.Name = "btnXuatBieuDo";
            btnXuatBieuDo.Size = new Size(176, 183);
            btnXuatBieuDo.TabIndex = 59;
            btnXuatBieuDo.Text = "Xuất biểu đồ doanh thu";
            btnXuatBieuDo.TextAlign = ContentAlignment.BottomCenter;
            btnXuatBieuDo.TextColor = Color.Black;
            btnXuatBieuDo.UseVisualStyleBackColor = false;
            btnXuatBieuDo.Click += btnXuatBieuDo_Click;
            // 
            // ThongKeDoanhThuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(447, 447);
            Controls.Add(btnXuatBieuDo);
            Controls.Add(panelTitleBar);
            Controls.Add(btnExportExcel);
            Controls.Add(dtpNgayKetThuc);
            Controls.Add(label3);
            Controls.Add(dtpNgayBatDau);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "ThongKeDoanhThuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê";
            Resize += Form_Resize;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpNgayKetThuc;
        private Label label3;
        private DateTimePicker dtpNgayBatDau;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Panel panelTitleBar;
        private PhongKham.RJControls.RJButton btnXuatBieuDo;
        private PhongKham.RJControls.RJButton btnExportExcel;
    }
}