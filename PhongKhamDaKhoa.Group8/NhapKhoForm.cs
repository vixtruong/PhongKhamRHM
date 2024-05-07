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
    public partial class NhapKhoForm : Form
    {
        public NhapKhoForm()
        {
            InitializeComponent();
        }

        ThuocService tService = new ThuocService();
        VatLieuService vlService = new VatLieuService();

        private void cbLoai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedIndex == 0)
            {
                List<string> tList = new List<string>();
                foreach (var item in tService.GetAll()) { tList.Add(item.Tenthuoc); }
                cbDanhsach.DataSource = tList;
            }

            if (cbLoai.SelectedIndex == 1)
            {
                List<string> vlList = new List<string>();
                foreach (var item in vlService.GetAll()) { vlList.Add(item.TenVl); }
                cbDanhsach.DataSource = vlList;
            }
        }

        private void NhapKhoForm_Load(object sender, EventArgs e)
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
            string name = cbDanhsach.Text;

            if (cbLoai.Text == "Thuốc")
            {
                Thuoc thuoc = tService.GetByName(name);

                Thuoc newThuoc = new Thuoc()
                {
                    MaThuoc = thuoc.MaThuoc,
                    Tenthuoc = thuoc.Tenthuoc,
                    Soluong = thuoc.Soluong + int.Parse(txtSoluong.Texts),
                    Dvt = thuoc.Dvt,
                    Gia = thuoc.Gia
                };
                tService.UpdateThuoc(newThuoc);
                this.Close();
                return;
            }

            Vatlieu vl = vlService.GetByName(name);

            Vatlieu newVl = new Vatlieu()
            {
                MaVl = vl.MaVl,
                TenVl = vl.TenVl,
                Soluong = vl.Soluong + int.Parse(txtSoluong.Texts),
                Dvt = vl.Dvt,
                Gia = vl.Gia
            };
            vlService.Update(newVl);

            this.Close();
        }
    }
}
