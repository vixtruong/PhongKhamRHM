using Microsoft.IdentityModel.Tokens;
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
    public partial class KyThuatForm : Form
    {
        public string id { get; set; }
        PhieuKhamBenhService pkbService = new PhieuKhamBenhService();
        KyThuatService ktService = new KyThuatService();
        ViTriBenhService vtService = new ViTriBenhService();
        BacSiService bsService = new BacSiService();
        CTPkbService ctpkbService = new CTPkbService();
        List<Tuple<string, string, int, int, int>> ktList = new List<Tuple<string, string, int, int, int>>();

        public KyThuatForm()
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDgvKT(List<Tuple<string, string, int, int, int>> list)
        {
            dgvListKT.DataSource = null;
            dgvListKT.DataSource = list;
            dgvListKT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListKT.Columns["Item1"].HeaderText = "Kỹ thuật";
            dgvListKT.Columns["Item2"].HeaderText = "Vị trí";
            dgvListKT.Columns["Item3"].HeaderText = "Số lượng";
            dgvListKT.Columns["Item4"].HeaderText = "Đơn giá";
            dgvListKT.Columns["Item5"].HeaderText = "Thành tiền";
        }

        private void KyThuatForm_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                Bacsi bs = bsService.GetBacsi(id);
                lbTenBS.Text = bs.Hoten;
            }

            List<string> pkbList = new List<string>();
            foreach (var pkb in pkbService.GetAll())
            {
                pkbList.Add(pkb.MaPkb);
            }
            cbPKB.DataSource = pkbList;

            List<string> ktList = new List<string>();
            foreach (var kt in ktService.GetAll())
            {
                ktList.Add(kt.TenKt);
            }
            cbKyThuat.DataSource = ktList;
        }

        private void cbKyThuat_SelectedValueChanged(object sender, EventArgs e)
        {
            string tenKT = cbKyThuat.Text;
            Kythuat? kt = ktService.GetByName(tenKT);
            List<string> vtList = new List<string>();
            foreach (var vt in vtService.GetAll())
            {
                if (vt.MaKt == kt.MaKt)
                {
                    vtList.Add(vt.TenVt);
                }
            }
            cbVitribenh.DataSource = vtList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nudSoluong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập lại số lượng!", "Số lượng bằng không", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenKT;
            string tenVTbenh;
            int soluong;
            int dongia;
            int thanhtien;

            if (ktList.IsNullOrEmpty())
            {
                tenKT = cbKyThuat.Text;
                tenVTbenh = cbVitribenh.Text;
                Kythuat? kt = ktService.GetByName(tenKT);
                Vitribenh? vt = vtService.GetByKTIdAndName(kt.MaKt, tenVTbenh);
                soluong = int.Parse(nudSoluong.Value.ToString());
                dongia = vt.Gia;
                thanhtien = dongia * soluong;
                ktList.Add(new Tuple<string, string, int, int, int>(tenKT, tenVTbenh, soluong, dongia, thanhtien));
                LoadDgvKT(ktList);
            }
            else
            {
                tenKT = cbKyThuat.Text;
                tenVTbenh = cbVitribenh.Text;
                Kythuat? kt = ktService.GetByName(tenKT);
                Vitribenh? vt = vtService.GetByKTIdAndName(kt.MaKt, tenVTbenh);
                soluong = int.Parse(nudSoluong.Value.ToString());
                dongia = vt.Gia;
                thanhtien = dongia * soluong;

                bool found = false;
                for (int i = 0; i < ktList.Count; i++)
                {
                    if (ktList[i].Item1 == tenKT && ktList[i].Item2 == tenVTbenh)
                    {
                        var updatedTuple = new Tuple<string, string, int, int, int>(
                            ktList[i].Item1,
                            ktList[i].Item2,
                            ktList[i].Item3 + soluong,
                            ktList[i].Item4,
                            ktList[i].Item5 + thanhtien);

                        ktList[i] = updatedTuple;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    ktList.Add(new Tuple<string, string, int, int, int>(tenKT, tenVTbenh, soluong, dongia, thanhtien));
                }

                LoadDgvKT(ktList);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListKT.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn kỹ thuật để xóa", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvListKT.SelectedRows[0];
            string tenKT = row.Cells["Item1"].Value.ToString();
            string tenVT = row.Cells["Item2"].Value.ToString();
            List<Tuple<string, string, int, int, int>> itemsToRemove = new List<Tuple<string, string, int, int, int>>();

            // Lặp qua danh sách và thêm các phần tử cần xóa vào danh sách tạm thời
            foreach (var item in ktList)
            {
                if (item.Item1 == tenKT && item.Item2 == tenVT)
                {
                    itemsToRemove.Add(item);
                }
            }

            // Xóa các phần tử khỏi danh sách
            foreach (var itemToRemove in itemsToRemove)
            {
                ktList.Remove(itemToRemove);
            }

            LoadDgvKT(ktList);
        }

        private void btnUpdateLT_Click(object sender, EventArgs e)
        {
            string maPKB = cbPKB.Text;
            string maVt;
            int soluong;
            int thanhtien;

            foreach (var kt in ktList)
            {
                string maKT = ktService.GetByName(kt.Item1.ToString()).MaKt;
                string tenVT = kt.Item2.ToString();
                maVt = vtService.GetByKTIdAndName(maKT, tenVT).MaVt;
                soluong = kt.Item3;
                thanhtien = kt.Item5;

                Chitietpkb ctpkb = new()
                {
                    MaPkb = maPKB,
                    MaVt = maVt,
                    Soluong = soluong,
                    Thanhtien = thanhtien,
                };

                ctpkbService.Add(ctpkb);
            }
            MessageBox.Show("Thêm dịch vụ thành công!", "Successfully", MessageBoxButtons.OK);
        }

        private const int MaxWidth = 905;
        private const int MaxHeight = 869;

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.Width > MaxWidth)
            {
                this.Width = MaxWidth;
            }
            if (this.Height > MaxHeight)
            {
                this.Height = MaxHeight;
            }
        }
    }
}
