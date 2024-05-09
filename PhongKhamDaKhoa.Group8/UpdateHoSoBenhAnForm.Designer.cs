namespace PhongKhamDaKhoa.Group8
{
    partial class UpdateHoSoBenhAnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateHoSoBenhAnForm));
            txtTinhTrang = new RichTextBox();
            btnLuu = new PhongKham.RJControls.RJButton();
            SuspendLayout();
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Cursor = Cursors.IBeam;
            txtTinhTrang.Location = new Point(11, 12);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(377, 215);
            txtTinhTrang.TabIndex = 0;
            txtTinhTrang.Text = "";
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
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(139, 239);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 44);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.TextColor = Color.Black;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // UpdateHoSoBenhAnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(400, 295);
            Controls.Add(btnLuu);
            Controls.Add(txtTinhTrang);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateHoSoBenhAnForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sửa Bệnh Án";
            Load += UpdateHoSoBenhAnForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtTinhTrang;
        private PhongKham.RJControls.RJButton btnLuu;
    }
}