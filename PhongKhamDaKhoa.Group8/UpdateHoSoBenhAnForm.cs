using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PhongKhamDaKhoa.Group8
{
    public partial class UpdateHoSoBenhAnForm : Form
    {
        public int maBA { get; set; }
        HoSoBenhAnService hsService = new HoSoBenhAnService();

        public UpdateHoSoBenhAnForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UpdateHoSoBenhAnForm_Load(object sender, EventArgs e)
        {
            if (maBA != null)
            {
                Hosobenhan ba = hsService.Get(maBA);
                txtTinhTrang.Text = ba.Tinhtrang.Trim();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (maBA != null)
            {
                if (string.IsNullOrEmpty(txtTinhTrang.Text))
                {
                    MessageBox.Show("Vui lòng điền tình trạng cần chỉnh sửa!", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Hosobenhan ba = hsService.Get(maBA);
                Hosobenhan newBA = new()
                {
                    MaHs = ba.MaHs,
                    Tinhtrang = txtTinhTrang.Text.Trim(),
                    Ngaykham = ba.Ngaykham,
                    MaBn = ba.MaBn,
                    Solankham = ba.Solankham,
                };

                hsService.Update(newBA);
                MessageBox.Show("Cập nhật bệnh án thành công!", "Thành công", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
