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

namespace PhongKhamNhaKhoa
{
    public partial class ThongKeDoanhThuForm : Form
    {
        private PhieuKhamBenhService _PKBService = new();
        private HoaDonService _HDService = new();
        private Export export = new Export();
        public ThongKeDoanhThuForm()
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

        private DataTable ConvertListHoaDonToDataTable(List<Hoadon> listHoaDon)
        {
            DataTable dataTable = new();

            // Tạo các cột trong DataTable tương ứng với các thuộc tính của lớp DSCaDay
            dataTable.Columns.Add("STT", typeof(string));
            dataTable.Columns.Add("Mã hóa đơn", typeof(string));
            dataTable.Columns.Add("Ngày lập", typeof(string));
            dataTable.Columns.Add("Mã bác sĩ", typeof(string));
            dataTable.Columns.Add("Thành tiền", typeof(int));

            int stt = 1;

            foreach (var hoaDon in listHoaDon)
            {
                string maPKB = hoaDon.Mapkb;
                Phieukhambenh pkb = _PKBService.GetPhieukhambenh(maPKB);

                DataRow row = dataTable.NewRow();

                row["STT"] = stt++;
                row["Mã hóa đơn"] = hoaDon.MaHd;
                row["Ngày lập"] = hoaDon.Ngaylap.ToString("dd/MM/yyyy");
                row["Mã bác sĩ"] = pkb.MaBs;
                row["Thành tiền"] = hoaDon.Thanhtien;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DateTime dateStart = dtpNgayBatDau.Value;
            DateTime dateEnd = dtpNgayKetThuc.Value;
            List<Hoadon> listHD = _HDService.GetHDInRange(DateOnly.FromDateTime(dateStart), DateOnly.FromDateTime(dateEnd));

            DataTable dataTableHoaDon = ConvertListHoaDonToDataTable(listHD);
            string title = $"THỐNG KÊ - BÁO CÁO DOANH THU PHÒNG KHÁM {dateStart.ToString("dd/MM/yyyy")} -> {dateEnd.ToString("dd/MM/yyyy")}";
            export.ExportFile(dataTableHoaDon, "Thong Ke Doanh Thu", title);
        }

        private DataTable GetDataTableUniqueMaBS(List<Hoadon> listHD)
        {
            DataTable dataTable = new();

            // Tạo các cột trong DataTable tương ứng với các thuộc tính của lớp DSCaDay
            dataTable.Columns.Add("Mã bác sĩ", typeof(string));

            HashSet<string> uniqueMaBS = new HashSet<string>();
            foreach (var HD in listHD)
            {
                string MaBS = _PKBService.GetPhieukhambenh(HD.Mapkb).MaBs;
                uniqueMaBS.Add(MaBS);
            }

            foreach (string name in uniqueMaBS)
            {
                dataTable.Columns.Add(name, typeof(string));
            }
            return dataTable;
        }


        private void btnXuatBieuDo_Click(object sender, EventArgs e)
        {
            DateTime dateStart = dtpNgayBatDau.Value;
            DateTime dateEnd = dtpNgayKetThuc.Value;

            List<Hoadon> listHD = _HDService.GetHDInRange(DateOnly.FromDateTime(dateStart), DateOnly.FromDateTime(dateEnd));
            DataTable dataTableMaBS = GetDataTableUniqueMaBS(listHD);

            // Danh sách lưu doanh thu theo từng bác sĩ theo thứ tự trong danh sách dataTableMaBS
            List<int> listTongDoanhThu = new List<int>();
            foreach (DataColumn column in dataTableMaBS.Columns)
            {
                if (column.ColumnName != "Mã bác sĩ")
                {
                    int tongDoanhThu = 0;
                    foreach (var HD in listHD)
                    {
                        Phieukhambenh pkb = _PKBService.GetPhieukhambenh(HD.Mapkb);
                        if (pkb.MaBs == column.ColumnName)
                        {
                            tongDoanhThu += listHD.Find(hd => hd.Mapkb == pkb.MaPkb).Thanhtien;
                        }
                    }
                    listTongDoanhThu.Add(tongDoanhThu);
                }
            }

            export.ExportChartHSDoanhThu(dataTableMaBS, "So sanh doanh thu", $"BIỂU ĐỒ SO SÁNH DOANH THU GIỮA CÁC BÁC SĨ {dateStart.ToString("dd/MM/yyyy")} -> {dateEnd.ToString("dd/MM/yyyy")}", listTongDoanhThu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const int MaxWidth = 465;
        private const int MaxHeight = 494;

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
