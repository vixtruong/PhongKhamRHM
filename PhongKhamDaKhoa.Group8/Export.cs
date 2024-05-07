using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKhamNhaKhoa
{
    public class Export
    {
        public void ExportFile(System.Data.DataTable dataTable, string sheetName, string title)
        {
            // Tạo các đối tượng excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Tao moi mot Excel WorkBook

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tao phan tieu de
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            // Tao tieu de cot

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "STT";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã hóa đơn";

            cl2.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày lập";

            cl3.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Mã bác sĩ";

            cl4.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Thành tiền";

            cl5.ColumnWidth = 27;

            // Tương tự với những cột còn lại

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 4;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo database

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            // Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            // Thiet lap vung dien du lieu
            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // O bat dau dien du lieu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // O ket thuc dien du lieu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lay ve vung dien du lieu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // Dien du lieu vao vung da thiet lap
            range.Value2 = arr;

            // Tính tổng tiền lương
            double tongDoanhThu = dataTable.AsEnumerable().Sum(row => Convert.ToDouble(row["Thành tiền"]));

            // Thêm hàng tính tổng
            int totalRow = rowStart + dataTable.Rows.Count;
            oSheet.Cells[totalRow, columnStart] = "Tổng cộng";
            oSheet.Cells[totalRow, columnStart + 4] = tongDoanhThu + " (VNĐ)";

            // Định dạng dòng tổng cộng
            Microsoft.Office.Interop.Excel.Range totalRowRange = oSheet.Range[oSheet.Cells[totalRow, columnStart], oSheet.Cells[totalRow, rowStart + dataTable.Columns.Count - 4]];
            totalRowRange.Font.Bold = true;
            totalRowRange.Font.Italic = true;
            totalRowRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            totalRowRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            totalRowRange.Interior.ColorIndex = 6;

            // Ke vien
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Can giua ca bang
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        public void ExportChartHSDoanhThu(System.Data.DataTable dataTable, string sheetName, string title, List<int> listDoanhThu)
        {
            // Tạo các đối tượng excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Tao moi mot Excel WorkBook

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;


            // Tao phan tieu de
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            int ascciNameColumn = 65;

            foreach (DataColumn column in dataTable.Columns)
            {
                string columnName = Convert.ToChar(ascciNameColumn++).ToString() + "3";
                Microsoft.Office.Interop.Excel.Range newCol = oSheet.get_Range(columnName, columnName);
                newCol.Value2 = column.ColumnName;
                newCol.ColumnWidth = 25;
            }


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", Convert.ToChar(--ascciNameColumn) + "3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 4;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Thiet lap vung dien du lieu
            int rowStart = 4;

            int columnStart = 1;

            // Tính tổng số giờ dạy ứng với từng trường

            // List chứa tổng số giờ của các trường đc xắp xếp theo thứ tự từ trái sang phải
            int indexTruongDH = 0;
            ascciNameColumn = 65; // Bắt đầu từ cột B

            foreach (DataColumn column in dataTable.Columns)
            {
                string cellName = Convert.ToChar(ascciNameColumn++).ToString() + "4";
                Microsoft.Office.Interop.Excel.Range newCol = oSheet.get_Range(cellName, cellName);
                newCol.ColumnWidth = 25;

                if (column.ColumnName == "Mã bác sĩ")
                {
                    newCol.Value2 = "Doanh thu (VNĐ)";
                }
                else
                {
                    newCol.Value2 = listDoanhThu[indexTruongDH++];
                }
            }

            // Định dạng dòng tổng cộng
            Microsoft.Office.Interop.Excel.Range totalRange = oSheet.get_Range("A4", Convert.ToChar(--ascciNameColumn).ToString() + "4");
            totalRange.Font.Bold = true;
            totalRange.Font.Italic = true;
            totalRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            totalRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            totalRange.Interior.ColorIndex = 6;

            // Vẽ  biểu đồ cột
            Microsoft.Office.Interop.Excel.Range crange;
            Microsoft.Office.Interop.Excel.ChartObjects cb = (Microsoft.Office.Interop.Excel.ChartObjects)oSheet.ChartObjects(Type.Missing);
            Microsoft.Office.Interop.Excel.ChartObject cbc = (Microsoft.Office.Interop.Excel.ChartObject)cb.Add(130, 90, 300, 300);
            Microsoft.Office.Interop.Excel.Chart cp = cbc.Chart;

            // Ẩn chú thích
            cp.HasLegend = false;

            // Chú thích cho cột Y
            Microsoft.Office.Interop.Excel.Axis yAxis
                = (Microsoft.Office.Interop.Excel.Axis)cp.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary);
            yAxis.HasTitle = true;
            yAxis.AxisTitle.Text = "(VNĐ)";

            // Chú thích cho cột X
            Microsoft.Office.Interop.Excel.Axis xAxis
               = (Microsoft.Office.Interop.Excel.Axis)cp.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlCategory, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary);
            xAxis.HasTitle = true;
            xAxis.AxisTitle.Text = "(Mã bác sĩ)";


            crange = oSheet.get_Range("B3", Convert.ToChar(ascciNameColumn).ToString() + "5");
            cp.SetSourceData(crange, System.Reflection.Missing.Value);
            cp.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
        }
    }
}
