using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using Services;
using Repositories.Entities;
using System.Drawing.Printing;
using System.Web;

namespace WinFormsApp4
{
    public partial class ThanhToanForm : Form
    {

        private PhieuKhamBenhService pkbService = new PhieuKhamBenhService();
        private ToaThuocService toaService = new ToaThuocService();
        private CTToaThuocService ctttService = new CTToaThuocService();
        private ThuocService thuocService = new ThuocService();
        private KyThuatService kythuatService = new KyThuatService();
        private ViTriBenhService vtService = new ViTriBenhService();
        private VatLieuService vlService = new VatLieuService();
        private CTPkbService ctpkbService = new CTPkbService();
        private BenhNhanService bnService = new BenhNhanService();
        private HoaDonService hdService = new HoaDonService();
        string hdID = "";

        public ThanhToanForm()
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

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxPKB();
            List<string> list = new List<string>()
            {
                "0", "5", "10", "15", "20", "25", "30", "50", "75"
            };

            cbGiamgia.DataSource = list;
        }

        private void LoadComboBoxPKB()
        {
            List<string> list = new List<string>();
            List<Phieukhambenh> pkbList = pkbService.GetAll();

            if (pkbList != null)
            {
                foreach (var pkb in pkbList)
                {
                    list.Add(pkb.MaPkb);
                }

                cbPKB.DataSource = list;
            }
        }

        private void cbPKB_SelectedValueChanged(object sender, EventArgs e)
        {
            string maPKB = cbPKB.SelectedValue.ToString();
            
            LoadDataBySelect(maPKB);
        }

        private void LoadDataBySelect(string pkbID)
        {
            List<Tuple<string, int, int, decimal>> thuocList = new List<Tuple<string, int, int, decimal>>();
            string targetToaId = toaService.GetIDToaByPkbID(pkbID);

            //DgvThuoc
            if (targetToaId == null)
            {
                LoadDgvToaThuoc(null);
            }

            foreach (var item in ctttService.GetAll())
            {
                if (item.MaToa == targetToaId)
                {
                    Thuoc thuoc = thuocService.GetThuoc(item.MaThuoc);
                    thuocList.Add(new Tuple<string, int, int, decimal>(thuoc.Tenthuoc, item.Soluong, thuoc.Gia, item.Thanhtien));

                }
            }
            LoadDgvToaThuoc(thuocList);

            //DgvKythuat
            List<Tuple<string, string, int, int, decimal>> list = new List<Tuple<string, string, int, int, decimal>>();
            foreach (var item in ctpkbService.GetAll())
            {
                if (item.MaPkb.Equals(pkbID))
                {
                    Vitribenh vitribenh = vtService.Get(item.MaVt);
                    Kythuat kythuat = kythuatService.GetKythuat(vitribenh.MaKt);

                    list.Add(new Tuple<string, string, int, int, decimal>(kythuat.TenKt, vitribenh.TenVt, item.Soluong, vitribenh.Gia,
                                                                                           item.Thanhtien));
                }
            }
            LoadDgvKyThuat(list);

            //InfoBN
            Benhnhan benhnhan = bnService.Get(pkbService.GetPhieukhambenh(pkbID).MaBn);
            txtHoten.Texts = benhnhan.Hoten;
            dtpNgaysinh.Text = benhnhan.Ngaysinh.ToString();
            txtSDT.Texts = benhnhan.Sdt;

            decimal total = totalBill();
            txtTongtien.Texts = total.ToString();
            txtThanhtien.Texts = total.ToString();
        }


        private void LoadDgvToaThuoc(List<Tuple<string, int, int, decimal>> list)
        {
            if (list == null)
            {
                dgvThuoc.DataSource = null;
                return;
            }
            dgvThuoc.DataSource = list;
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThuoc.Columns["Item1"].HeaderText = "Tên thuốc";
            dgvThuoc.Columns["Item2"].HeaderText = "Số lượng";
            dgvThuoc.Columns["Item3"].HeaderText = "Đơn giá";
            dgvThuoc.Columns["Item4"].HeaderText = "Thành tiền";
        }

        private void LoadDgvKyThuat(List<Tuple<string, string, int, int, decimal>> list)
        {
            if (list == null)
            {
                dgvKT.DataSource = null;
                return;
            }
            dgvKT.DataSource = list;
            dgvKT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKT.Columns["Item1"].HeaderText = "Kỹ thuật";
            dgvKT.Columns["Item2"].HeaderText = "Vị trí";
            dgvKT.Columns["Item3"].HeaderText = "Số lượng";
            dgvKT.Columns["Item4"].HeaderText = "Đơn giá";
            dgvKT.Columns["Item5"].HeaderText = "Thành tiền";
        }

        private decimal totalBill()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvThuoc.Rows)
            {
                // Lấy giá trị của cột "Thành tiền" từ mỗi hàng
                if (row.Cells["Item3"].Value != null)
                {
                    decimal amount = (decimal)row.Cells["Item4"].Value;
                    total += amount;
                }
            }

            foreach (DataGridViewRow row in dgvKT.Rows)
            {
                // Lấy giá trị của cột "Thành tiền" từ mỗi hàng
                if (row.Cells["Item4"].Value != null)
                {
                    decimal amount = (decimal)row.Cells["Item5"].Value;
                    total += amount;
                }
            }

            return total;
        }

        private void chkTienmat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTienmat.Checked == true) { chkCK.Checked = false; }
        }

        private void cbGiamgia_SelectedValueChanged(object sender, EventArgs e)
        {
            int giamgiaValue = int.Parse(cbGiamgia.SelectedValue.ToString());
            int thanhtien = (int)totalBill() * (100 - giamgiaValue) / 100;
            txtThanhtien.Texts = thanhtien.ToString();
        }

        private void chkCK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCK.Checked == true) { chkTienmat.Checked = false; }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            hdID = hdService.GenerateID();
            string pkbID = cbPKB.Text;
            string letanID = txtMaLT.Texts;
            DateOnly ngaylap = new DateOnly(dtpNgayLap.Value.Year, dtpNgayLap.Value.Month, dtpNgayLap.Value.Day);

            if (string.IsNullOrEmpty(pkbID))
            {
                MessageBox.Show("Vui lòng nhập thông tin phiếu khám!", "Null Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pkbService.GetPhieukhambenh(pkbID) == null)
            {
                MessageBox.Show("Phiếu khám bệnh không tồn tại!", "Null Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(letanID))
            {
                MessageBox.Show("Vui lòng nhập thông tin người lập!", "Null Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cbGiamgia.Texts))
            {
                MessageBox.Show("Vui lòng nhập thông tin giảm giá!", "Null Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkCK.Checked == false && chkTienmat.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!", "Null Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            short giamgia = short.Parse(cbGiamgia.Texts);
            int tongtien = int.Parse(txtTongtien.Texts);
            int thanhtien = int.Parse(txtThanhtien.Texts);
            string phuongthuc = "";
            string bnID = pkbService.GetPhieukhambenh(pkbID).MaBn;

            if (chkTienmat.Checked == true) phuongthuc = "TM";
            if (chkCK.Checked == true) phuongthuc = "CK";
            Hoadon newHoadon = new()
            {
                MaHd = hdID,
                Mapkb = pkbID,
                MaLt = letanID,
                Tongtien = tongtien,
                Giamgia = giamgia,
                Thanhtien = thanhtien,
                Phuongthuc = phuongthuc,
                MaBn = bnID,
                Ngaylap = ngaylap
            };

            hdService.Add(newHoadon);
            printHoadon(newHoadon.MaHd);
            MessageBox.Show("Tạo hóa đơn thành công!", "Thành công", MessageBoxButtons.OK);
        }

        private void printHoadon(string filename)
        {
            //pdHoadon.PrintPage += new PrintPageEventHandler(pdHoadon_PrintPage);

            //// Đường dẫn và tên file
            //string filePath = Path.Combine(@"D:\User\Desktop\HOADON", filename + ".pdf");

            //// Khởi tạo đối tượng PrinterSettings để thiết lập cấu hình in
            //PrinterSettings ps = new PrinterSettings();

            //// Thiết lập đường dẫn và tên file cho tệp cần lưu
            //ps.PrintToFile = true;
            //ps.PrintFileName = filePath;

            //// Thiết lập đối tượng PrinterSettings cho PrintDocument
            //pdHoadon.PrinterSettings = ps;

            //// Gọi phương thức Print() để in hóa đơn
            //pdHoadon.Print();
            ppdHoadon.Document = pdHoadon;
            ppdHoadon.ShowDialog();
        }

        private void pdHoadon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tenPK = "Phòng khám răng hàm mặt ABC";
            var diachi = "123, ABC, District 10, HCM City";
            var sdt = "1234567890";

            var w = pdHoadon.DefaultPageSettings.PaperSize.Width;

            //Ten phong kham
            e.Graphics.DrawString(
                    tenPK.ToUpper(),
                    new Font("Courtier New", 12, FontStyle.Bold),
                    Brushes.Black,
                    new Point(100, 20)
                );

            //Thoi gian in hoa don
            e.Graphics.DrawString(
                    String.Format(hdID),
                    new Font("Courtier New", 12, FontStyle.Bold),
                    Brushes.Black,
                    new Point(w / 2 + 200, 20)
                );

            e.Graphics.DrawString(
                    String.Format("Địa chỉ: " + diachi),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(101, 45)
                );

            e.Graphics.DrawString(
                    String.Format("Số điện thoại: " + sdt),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(101, 65)
                );

            //ngay gio
            e.Graphics.DrawString(
                    String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(w / 2 + 200, 45)
                );

            //dinh dang but ve
            Pen blackPen = new Pen(Color.Black, 1);

            //toa do y
            var y = 85;

            Point p1 = new Point(100, y);
            Point p2 = new Point(w - 100, y);

            e.Graphics.DrawLine(blackPen, p1, p2);
            y += 20;

            e.Graphics.DrawString(
                    String.Format("Danh sách Kỹ thuật"),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(w / 2 - 50, y)
                );

            y += 20;
            e.Graphics.DrawString("Kỹ thuật", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Vị trí", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(231, y));
            e.Graphics.DrawString("Số lượng", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(362, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(493, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(w / 2 + 200, y));

            // Lặp qua từng dòng trong DataGridView để vẽ dữ liệu
            
            foreach (DataGridViewRow row in dgvKT.Rows)
            {
                y += 20;
                int xr = 100;
                // Lặp qua từng ô trong dòng
                for (int i = 0; i < dgvKT.Columns.Count; i++)
                {
                    e.Graphics.DrawString(row.Cells[i].Value.ToString(), new Font("Courtier New", 8), Brushes.Black, new Point(xr, y));
                    xr += 131;
                }
            }

            y += 40;
            Pen dashedPen = new Pen(Color.Black, 1);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Point p3 = new Point(100, y);
            Point p4 = new Point(w - 100, y);
            e.Graphics.DrawLine(dashedPen, p3, p4);

            y += 20;
            //Danh sach thuoc
            e.Graphics.DrawString(
                    String.Format("Danh sách thuốc"),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(w / 2 - 50, y)
                );

            y += 20;
            e.Graphics.DrawString("Tên thuốc", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Số lượng", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(100 + 175, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(100 + 175*2, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courtier New", 8, FontStyle.Italic), Brushes.Black, new Point(100 + 175 * 3, y));

            foreach (DataGridViewRow row in dgvThuoc.Rows)
            {
                y += 20;

                // Đặt vị trí ban đầu của cột
                int x = 100;

                // Lặp qua từng cột trong dòng
                for (int i = 0; i < dgvThuoc.Columns.Count; i++)
                {
                    // Vẽ dữ liệu từng ô lên trang in
                    e.Graphics.DrawString(row.Cells[i].Value.ToString(), new Font("Courtier New", 8), Brushes.Black, new Point(x, y));

                    // Tăng vị trí của cột cho lần lặp tiếp theo
                    x += 175; // Điều chỉnh khoảng cách giữa các cột
                }

            }

            Hoadon h = hdService.Get(hdID);

            y += 40;
            Point p5 = new Point(100, y);
            Point p6 = new Point(w - 100, y);
            e.Graphics.DrawLine(dashedPen, p5, p6);

            y += 40;
            e.Graphics.DrawString(
                    String.Format("Tổng tiền: " + h.Tongtien),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(100, y)
                );
            e.Graphics.DrawString(
                    String.Format("Khách hàng: " + txtHoten.Texts),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(550, y)
                );
            y += 20;
            e.Graphics.DrawString(
                    String.Format("Giảm giá: " + h.Giamgia + "%"),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(100, y)
                );
            e.Graphics.DrawString(
                    String.Format("SDT: " + txtSDT.Texts),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(550, y)
                );
            y += 20;
            e.Graphics.DrawString(
                    String.Format("Thành tiền: " + h.Thanhtien),
                    new Font("Courtier New", 8, FontStyle.Bold),
                    Brushes.Black,
                    new Point(100, y)
                );
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
