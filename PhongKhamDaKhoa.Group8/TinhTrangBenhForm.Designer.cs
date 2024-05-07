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
            contextMenuStrip1 = new ContextMenuStrip(components);
            richTextBox1 = new RichTextBox();
            btnUpdateLT = new PhongKham.RJControls.RJButton();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(10, 9);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(445, 187);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btnUpdateLT
            // 
            btnUpdateLT.BackColor = Color.Transparent;
            btnUpdateLT.BackgroundColor = Color.Transparent;
            btnUpdateLT.BorderColor = Color.FromArgb(27, 117, 188);
            btnUpdateLT.BorderRadius = 10;
            btnUpdateLT.BorderSize = 1;
            btnUpdateLT.FlatAppearance.BorderSize = 0;
            btnUpdateLT.FlatStyle = FlatStyle.Flat;
            btnUpdateLT.Font = new Font("Segoe UI", 9.75F);
            btnUpdateLT.ForeColor = Color.Black;
            btnUpdateLT.Location = new Point(181, 202);
            btnUpdateLT.Name = "btnUpdateLT";
            btnUpdateLT.Size = new Size(97, 29);
            btnUpdateLT.TabIndex = 59;
            btnUpdateLT.Text = "Lưu";
            btnUpdateLT.TextColor = Color.Black;
            btnUpdateLT.UseVisualStyleBackColor = false;
            btnUpdateLT.Click += btnUpdateLT_Click;
            // 
            // TinhTrangBenhForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(467, 242);
            Controls.Add(btnUpdateLT);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TinhTrangBenhForm";
            Text = "Tình Trạng Bệnh";
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox richTextBox1;
        private PhongKham.RJControls.RJButton btnUpdateLT;
    }
}