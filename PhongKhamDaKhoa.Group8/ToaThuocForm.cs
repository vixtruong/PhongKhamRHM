using Microsoft.IdentityModel.Tokens;
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
using static System.Net.Mime.MediaTypeNames;

namespace PhongKhamDaKhoa.Group8
{
    public partial class ToaThuocForm : Form
    {
        public string id { get; set; }
        private BacSiService bsService = new();
        private PhieuKhamBenhService pkbService = new();
        private ThuocService thuocService = new();
        private ToaThuocService toaThuocService = new();
        private CTToaThuocService ctttService = new();
        List<Tuple<string, int, int, int>> thuocList = new List<Tuple<string, int, int, int>>();

        public ToaThuocForm()
        {
            InitializeComponent();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(171, 39, 28);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToaThuocForm_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                Bacsi bs = bsService.GetBacsi(id);
                lbTenBS.Text = bs.Hoten;
            }

            List<string> listPKB = new List<string>();
            foreach (var item in pkbService.GetAll())
            {
                listPKB.Add(item.MaPkb);
            }
            cbPKB.DataSource = listPKB;

            List<string> listThuoc = new List<string>();
            foreach (var item in thuocService.GetAll())
            {
                listThuoc.Add(item.Tenthuoc);
            }
            cbThuoc.DataSource = listThuoc;
        }

        private void LoadDgvThuoc(List<Tuple<string, int, int, int>> list)
        {
            dgvListThuoc.DataSource = null;
            dgvListThuoc.DataSource = list;
            dgvListThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListThuoc.Columns["Item1"].HeaderText = "Tên thuốc";
            dgvListThuoc.Columns["Item2"].HeaderText = "Số lượng";
            dgvListThuoc.Columns["Item3"].HeaderText = "Đơn giá";
            dgvListThuoc.Columns["Item4"].HeaderText = "Thành tiền";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nudSoluong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập lại số lượng!", "Số lượng bằng không", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenThuoc;
            int soluong;
            int dongia;
            int thanhtien;

            if (thuocList.IsNullOrEmpty())
            {
                tenThuoc = cbThuoc.Text;
                soluong = int.Parse(nudSoluong.Value.ToString());
                dongia = thuocService.GetByName(tenThuoc).Gia;
                thanhtien = dongia * soluong;
                thuocList.Add(new Tuple<string, int, int, int>(tenThuoc, soluong, dongia, thanhtien));
                LoadDgvThuoc(thuocList);
            }
            else
            {
                tenThuoc = cbThuoc.Text;
                soluong = int.Parse(nudSoluong.Value.ToString());
                dongia = thuocService.GetByName(tenThuoc).Gia;
                thanhtien = dongia * soluong;

                bool found = false;
                for (int i = 0; i < thuocList.Count; i++)
                {
                    if (thuocList[i].Item1 == tenThuoc)
                    {
                        var updatedTuple = new Tuple<string, int, int, int>(
                            thuocList[i].Item1,
                            thuocList[i].Item2 + soluong,
                            thuocList[i].Item3,
                            thuocList[i].Item4 + thanhtien);

                        thuocList[i] = updatedTuple;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    thuocList.Add(new Tuple<string, int, int, int>(tenThuoc, soluong, dongia, thanhtien));
                }

                LoadDgvThuoc(thuocList);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListThuoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn thuốc để xóa", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvListThuoc.SelectedRows[0];
            string tenThuoc = row.Cells["Item1"].Value.ToString();

            List<Tuple<string, int, int, int>> itemsToRemove = new List<Tuple<string, int, int, int>>();

            // Lặp qua danh sách và thêm các phần tử cần xóa vào danh sách tạm thời
            foreach (var item in thuocList)
            {
                if (item.Item1 == tenThuoc)
                {
                    itemsToRemove.Add(item);
                }
            }

            // Xóa các phần tử khỏi danh sách
            foreach (var itemToRemove in itemsToRemove)
            {
                thuocList.Remove(itemToRemove);
            }

            LoadDgvThuoc(thuocList);
        }

        private void btnUpdateLT_Click(object sender, EventArgs e)
        {
            string maToa = toaThuocService.GenerateID();
            string maBS = id;
            string maPkb = cbPKB.Text;
            DateTime todayDateTime = DateTime.Today;
            DateOnly ngaylap = new DateOnly(todayDateTime.Year, todayDateTime.Month, todayDateTime.Day);

            Toathuoc toa = new()
            {
                MaToa = maToa,
                MaBs = maBS,
                MaPkb = maPkb,
                Ngaylap = ngaylap
            };
            toaThuocService.AddToa(toa);

            foreach (var item in thuocList) {
                int soluong = item.Item2;
                int thanhtien = item.Item4;
                string maThuoc = thuocService.GetByName(item.Item1).MaThuoc;

                Chitiettoathuoc cttt = new()
                {
                    MaToa = maToa,
                    MaThuoc = maThuoc,
                    Soluong = soluong,
                    Thanhtien = thanhtien
                };

                ctttService.AddToa(cttt);
            }

            MessageBox.Show("Tạo toa thuốc thành công!", "Successfully", MessageBoxButtons.OK);
        }
    }
}