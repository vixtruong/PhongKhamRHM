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
    public partial class VatLieuTieuHaoForm : Form
    {
        public string id { get; set; }
        private PhieuKhamBenhService pkbService = new PhieuKhamBenhService();
        private BacSiService bsService = new BacSiService();
        private KhoaService khoaService = new KhoaService();
        VatLieuService vlService = new VatLieuService();
        CTVLTHService ctvlthService = new CTVLTHService();
        List<Tuple<string, string, string, int>> vlList = new List<Tuple<string, string, string, int>>();

        public VatLieuTieuHaoForm()
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

        private void LoadDgvVL(List<Tuple<string, string, string, int>> list)
        {
            dgvListVL.DataSource = null;
            dgvListVL.DataSource = list;
            dgvListVL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListVL.Columns["Item1"].HeaderText = "Khoa";
            dgvListVL.Columns["Item2"].HeaderText = "Mã VL";
            dgvListVL.Columns["Item3"].HeaderText = "Tên";
            dgvListVL.Columns["Item4"].HeaderText = "Số lượng";
        }

        private void VatLieuTieuHaoForm_Load(object sender, EventArgs e)
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

            List<string> khoaList = new List<string>();
            foreach (var khoa in khoaService.GetAll())
            {
                khoaList.Add(khoa.TenKhoa);
            }
            cbKhoa.DataSource = khoaList;
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            string tenKhoa = cbKhoa.Text;
            Khoa? khoa = khoaService.GetByName(tenKhoa);
            var vlList = new List<string>();

            foreach (var vl in vlService.GetAll())
            {
                if (vl.MaKhoa == khoa?.MaKhoa)
                {
                    vlList.Add(vl.TenVl);
                }
            }

            if (vlList.Count == 0)
            {
                cbVatlieu.Text = "";
            }
            cbVatlieu.DataSource = vlList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nudSoluong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập lại số lượng!", "Số lượng bằng không", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? tenKhoa;
            string? maVL;
            string? tenVL;
            int soluong;


            if (vlList.IsNullOrEmpty())
            {
                tenKhoa = cbKhoa.Text;
                tenVL = cbVatlieu.Text;
                Khoa? khoa = khoaService.GetByName(tenKhoa);
                Vatlieu? vl = vlService.GetByKhoaAndName(khoa.MaKhoa, tenVL);
                if (vl != null)
                {
                    maVL = vl.MaVl;
                    soluong = int.Parse(nudSoluong.Value.ToString());
                    vlList.Add(new Tuple<string, string, string, int>(tenKhoa, maVL, tenVL, soluong));
                    LoadDgvVL(vlList);
                }
            }
            else
            {
                tenKhoa = cbKhoa.Text;
                tenVL = cbVatlieu.Text;
                Khoa? khoa = khoaService.GetByName(tenKhoa);
                Vatlieu? vl = vlService.GetByKhoaAndName(khoa.MaKhoa, tenVL);
                if (vl != null)
                {
                    maVL = vl.MaVl;
                    soluong = int.Parse(nudSoluong.Value.ToString());

                    bool found = false;
                    for (int i = 0; i < vlList.Count; i++)
                    {
                        if (vlList[i].Item1 == tenKhoa && vlList[i].Item2 == maVL)
                        {
                            var updatedTuple = new Tuple<string, string, string, int>(
                                vlList[i].Item1,
                                vlList[i].Item2,
                                vlList[i].Item3,
                                vlList[i].Item4 + soluong);

                            vlList[i] = updatedTuple;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        vlList.Add(new Tuple<string, string, string, int>(tenKhoa, maVL, tenVL, soluong));
                    }

                    LoadDgvVL(vlList);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListVL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vật liệu để xóa", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvListVL.SelectedRows[0];
            string tenKhoa = row.Cells["Item1"].Value.ToString();
            string tenVL = row.Cells["Item2"].Value.ToString();

            List<Tuple<string, string, string, int>> itemsToRemove = new List<Tuple<string, string, string, int>>();

            // Lặp qua danh sách và thêm các phần tử cần xóa vào danh sách tạm thời
            foreach (var item in vlList)
            {
                if (item.Item1 == tenKhoa && item.Item2 == tenVL)
                {
                    itemsToRemove.Add(item);
                }
            }

            // Xóa các phần tử khỏi danh sách
            foreach (var itemToRemove in itemsToRemove)
            {
                vlList.Remove(itemToRemove);
            }

            LoadDgvVL(vlList);
        }

        private void btnUpdateLT_Click(object sender, EventArgs e)
        {
            string maPKB = cbPKB.Text;
            string maVL;
            int soluong;

            foreach (var vl in vlList)
            {
                maVL = vl.Item2;
                soluong = vl.Item4;

                Chitietvatlieutieuhao ctvlth = new()
                {
                    MaPkb = maPKB,
                    MaVl = maVL,
                    Soluong = soluong,
                };

                ctvlthService.Add(ctvlth);
            }

            MessageBox.Show("Thêm thông tin thành công!", "Successfully", MessageBoxButtons.OK);
        }

        private const int MaxWidth = 905;
        private const int MaxHeight = 890;

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
