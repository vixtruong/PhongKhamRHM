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
using System.Windows.Forms;

namespace PhongKhamDaKhoa.Group8
{
    public partial class AddHoSoBenhAnForm : Form
    {
        HoSoBenhAnService hsService = new HoSoBenhAnService();

        public AddHoSoBenhAnForm()
        {
            InitializeComponent();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBN.Texts))
            {
                MessageBox.Show("Vui lòng điền mã bệnh nhân!", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtTinhTrang.Text))
            {
                MessageBox.Show("Vui lòng điền tình trạng bệnh!", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maBN = txtMaBN.Texts;
            short maxLanKham = 0;
            foreach (var item in hsService.GetAll())
            {
                if (maxLanKham < item.Solankham) maxLanKham = item.Solankham;
            }
            int lankham = maxLanKham + 1;
            string tinhtrang = txtTinhTrang.Text;
            DateOnly ngaykham = new DateOnly(dtpNgayKham.Value.Year, dtpNgayKham.Value.Month, dtpNgayKham.Value.Day);

            Hosobenhan ba = new()
            {
                MaBn = maBN,
                Tinhtrang = tinhtrang,
                Ngaykham = ngaykham,
                Solankham = (short)lankham
            };
            hsService.Add(ba);
            MessageBox.Show("Thêm bệnh án thành công!", "Thành công", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }
    }
}
