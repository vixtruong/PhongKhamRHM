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
    public partial class AddVatLieuForm : Form
    {
        public AddVatLieuForm()
        {
            InitializeComponent();
        }

        ThuocService tService = new ThuocService();
        VatLieuService vlService = new VatLieuService();

        private void AddUpdateVatLieu_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>()
            {
                "Thuốc",
                "Vật liệu"
            };

            cbLoai.DataSource = list;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id;
            string ten = txtName.Texts;
            int soluong = int.Parse(txtSoluong.Texts);
            string dvt = txtDvt.Texts;
            int gia = int.Parse(txtGia.Texts);
            if (cbLoai.Text == "Thuốc")
            {
                id = tService.GenerateID();
                Thuoc thuoc = new Thuoc()
                {
                    MaThuoc = id,
                    Tenthuoc = ten,
                    Soluong = soluong,
                    Dvt = dvt,
                    Gia = gia
                };

                tService.AddThuoc(thuoc);
            }

            if (cbLoai.Text == "Vật liệu")
            {
                id = vlService.GenerateID();
                Vatlieu vl = new Vatlieu()
                {
                    MaVl = id,
                    TenVl = ten,
                    Soluong = soluong,
                    Dvt = dvt,
                    Gia = gia
                };

                vlService.Add(vl);
            }

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
