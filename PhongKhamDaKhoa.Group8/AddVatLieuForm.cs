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
    public partial class AddVatLieuForm : Form
    {
        public AddVatLieuForm()
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

        private const int MaxWidth = 416;
        private const int MaxHeight = 511;

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.Width > MaxWidth || this.Width < MaxWidth)
            {
                this.Width = MaxWidth;
            }
            if (this.Height > MaxHeight || this.Height < MaxHeight)
            {
                this.Height = MaxHeight;
            }
        }
    }
}
