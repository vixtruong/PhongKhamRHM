namespace PhongKhamDaKhoa.Group8
{
    partial class TinhTrangBenhForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhTrangBenhForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            rtxtTinhtrang = new RichTextBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // rtxtTinhtrang
            // 
            rtxtTinhtrang.BorderStyle = BorderStyle.FixedSingle;
            rtxtTinhtrang.Location = new Point(11, 12);
            rtxtTinhtrang.Name = "rtxtTinhtrang";
            rtxtTinhtrang.Size = new Size(508, 248);
            rtxtTinhtrang.TabIndex = 1;
            rtxtTinhtrang.Text = "";
            // 
            // TinhTrangBenhForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(534, 273);
            Controls.Add(rtxtTinhtrang);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TinhTrangBenhForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tình Trạng Bệnh";
            Load += TinhTrangBenhForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox rtxtTinhtrang;
    }
}