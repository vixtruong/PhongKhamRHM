using iTextSharp.text.xml.simpleparser.handler;
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
    public partial class UpdateVatLieuForm : Form
    {
        public UpdateVatLieuForm()
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

        public string? id { get; set; }
        private VatLieuService vlService = new VatLieuService();
        private ThuocService tService = new ThuocService();

        private void UpdateVatLieuForm_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>()
            {
                "Thuốc",
                "Vật liệu"
            };
            cbLoai.DataSource = list;

            if (id != null)
            {
                if (id.Contains("T"))
                {
                    Thuoc thuoc = tService.GetThuoc(id);
                    cbLoai.Text = "Thuốc";
                    txtName.Texts = thuoc.Tenthuoc;
                    txtSoluong.Texts = thuoc.Soluong.ToString();
                    txtDvt.Texts = thuoc.Dvt;
                    txtGia.Texts = thuoc.Gia.ToString();
                }

                if (id.Contains("VL"))
                {
                    Vatlieu vl = vlService.GetKythuat(id);
                    cbLoai.Text = "Vật liệu";
                    txtName.Texts = vl.TenVl;
                    txtSoluong.Texts = vl.Soluong.ToString();
                    txtDvt.Texts = vl.Dvt;
                    txtGia.Texts = vl.Gia.ToString();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtName.Texts;
            int soluong = int.Parse(txtSoluong.Texts);
            string dvt = txtDvt.Texts;
            int gia = int.Parse(txtGia.Texts);
            if (cbLoai.Text == "Thuốc")
            {
                Thuoc thuoc = new Thuoc()
                {
                    MaThuoc = id,
                    Tenthuoc = ten,
                    Soluong = soluong,
                    Dvt = dvt,
                    Gia = gia
                };

                tService.UpdateThuoc(thuoc);
            }

            if (cbLoai.Text == "Vật liệu")
            {
                Vatlieu vl = new Vatlieu()
                {
                    MaVl = id,
                    TenVl = ten,
                    Soluong = soluong,
                    Dvt = dvt,
                    Gia = gia
                };

                vlService.Update(vl);
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
