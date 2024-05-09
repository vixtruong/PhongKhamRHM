namespace PhongKhamDaKhoa.Group8
{
    partial class DanhSachLichKhamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachLichKhamForm));
            panelTitleBar = new Panel();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            btnThoat = new Button();
            label3 = new Label();
            tenBS = new Label();
            label5 = new Label();
            dgvLichKham = new DataGridView();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.WhiteSmoke;
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Controls.Add(label2);
            panelTitleBar.Controls.Add(pictureBox1);
            panelTitleBar.Controls.Add(pictureBox7);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(645, 77);
            panelTitleBar.TabIndex = 49;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(588, 11);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 55);
            btnClose.TabIndex = 69;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(27, 117, 188);
            label1.Location = new Point(88, 44);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 8;
            label1.Text = "RĂNG HÀM MẶT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(27, 117, 188);
            label2.Location = new Point(79, 8);
            label2.Name = "label2";
            label2.Size = new Size(166, 30);
            label2.TabIndex = 7;
            label2.Text = "PHÒNG KHÁM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(511, 0);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(70, 76);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 69;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.FromArgb(27, 117, 188);
            label7.Location = new Point(-1164, 257);
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
            label6.Location = new Point(-1173, 221);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 4;
            label6.Text = "PHÒNG KHÁM";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1252, 213);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(692, 223);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(10, 55);
            button2.TabIndex = 68;
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(1831, 221);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1776, 231);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(41, 43);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(-1255, 212);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.FromArgb(27, 117, 188);
            label3.Location = new Point(180, 93);
            label3.Name = "label3";
            label3.Size = new Size(282, 30);
            label3.TabIndex = 71;
            label3.Text = "DANH SÁCH KHÁM BỆNH";
            // 
            // tenBS
            // 
            tenBS.AutoSize = true;
            tenBS.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            tenBS.ForeColor = Color.FromArgb(27, 117, 188);
            tenBS.Location = new Point(256, 130);
            tenBS.Name = "tenBS";
            tenBS.Size = new Size(206, 30);
            tenBS.TabIndex = 72;
            tenBS.Text = "HỌ VÀ TÊN BÁC SĨ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.FromArgb(27, 117, 188);
            label5.Location = new Point(163, 130);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 73;
            label5.Text = "BÁC SĨ:";
            // 
            // dgvLichKham
            // 
            dgvLichKham.BackgroundColor = Color.White;
            dgvLichKham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichKham.Location = new Point(12, 174);
            dgvLichKham.Name = "dgvLichKham";
            dgvLichKham.RowHeadersVisible = false;
            dgvLichKham.RowHeadersWidth = 51;
            dgvLichKham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichKham.Size = new Size(623, 307);
            dgvLichKham.TabIndex = 74;
            // 
            // DanhSachLichKhamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(645, 491);
            Controls.Add(dgvLichKham);
            Controls.Add(label5);
            Controls.Add(tenBS);
            Controls.Add(label3);
            Controls.Add(panelTitleBar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DanhSachLichKhamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Lịch Khám";
            FormClosing += DanhSachLichKhamForm_FormClosing;
            Resize += Form_Resize;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitleBar;
        private Button btnClose;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button1;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label tenBS;
        private Label label5;
        private DataGridView dgvLichKham;
    }
}