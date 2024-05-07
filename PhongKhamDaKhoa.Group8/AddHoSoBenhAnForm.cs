using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
