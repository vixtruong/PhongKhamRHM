using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Runtime.InteropServices;

namespace PhongKhamNhaKhoa
{
    public partial class XemLichKhamForm : Form
    {
        private LichHenService _LHService = new();
        private BacSiService _BSService = new();
        private BenhNhanService _BNService = new();
        private PhieuKhamBenhService pkbService = new();
        private DateOnly today;
        public XemLichKhamForm()
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

        public void loadDataToGridView()
        {
            today = DateOnly.FromDateTime(dtpUserSelect.Value);

            List<Lichhen> ListLHAfterFilter = _LHService.GetAll().Where(x => x.Ngayhen == today).ToList();
            ListLHAfterFilter.Sort(new LichhenComparer());
            dgvDSLichHen.DataSource = null;
            dgvDSLichHen.DataSource = ListLHAfterFilter;

            dgvDSLichHen.Columns["MaBnNavigation"].Visible = false;
            dgvDSLichHen.Columns["MaBsNavigation"].Visible = false;

            dgvDSLichHen.Columns["MaLh"].HeaderText = "Mã lịch hẹn";
            dgvDSLichHen.Columns["Ngayhen"].HeaderText = "Ngày hẹn";
            dgvDSLichHen.Columns["MaBs"].HeaderText = "Mã bác sĩ";
            dgvDSLichHen.Columns["MaBn"].HeaderText = "Mã bệnh nhân";
            dgvDSLichHen.Columns["Nhucaukham"].HeaderText = "Nhu cầu khám";
            dgvDSLichHen.Columns["LoaiBenhNhan"].HeaderText = "Loại bệnh nhân";

            dgvDSLichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void resetInputField()
        {
            txtMaLH.Texts = "";
            dtpLichHen.Value = DateTime.Now;
            txtTenBN.Texts = "";
            dtpNgaySinhBN.Value = DateTime.Now;
            txtSDT.Texts = "";
            txtLoaiBN.Texts = "";
            txtTenBS.Texts = "";
            txtNhuCauKham.Texts = "";
        }

        private void XemLichKhamForm_Load(object sender, EventArgs e)
        {
            loadDataToGridView();
        }

        private void btnPrevDay_Click(object sender, EventArgs e)
        {
            dtpUserSelect.Value = dtpUserSelect.Value.AddDays(-1);
            loadDataToGridView();
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpUserSelect.Value = dtpUserSelect.Value.AddDays(1);
            loadDataToGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateLichKham form = new();
            form.MaLH = null;
            form.ShowDialog();
            loadDataToGridView();
            resetInputField();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hủy ký tự được nhập vào
                e.Handled = true;
            }
        }

        private void dgvDSLichHen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cột hiện tại có phải là cột 'Giới tính' không
            if (dgvDSLichHen.Columns[e.ColumnIndex].Name == "LoaiBenhNhan")
            {
                // Kiểm tra giá trị thực của ô hiện tại
                if (e.Value != null && e.Value.ToString() == "1")
                {
                    // Nếu giá trị là 1, thay đổi nó thành 'Nam'
                    e.Value = "BN đặt lịch";
                }
                else if (e.Value != null && e.Value.ToString() == "0")
                {
                    // Nếu giá trị là 0, thay đổi nó thành 'Nữ'
                    e.Value = "BN thường";
                }
            }
        }

        class LichhenComparer : IComparer<Lichhen>
        {
            public int Compare(Lichhen x, Lichhen y)
            {
                // Xác định sự ưu tiên dựa trên thuộc tính LoaiBenhNhan và MaLh
                if (x.LoaiBenhNhan == "1" && y.LoaiBenhNhan == "1")
                {
                    // Nếu cả hai đều có LoaiBenhNhan là "1", so sánh theo MaLh
                    return x.MaLh.CompareTo(y.MaLh);
                }
                else if (x.LoaiBenhNhan == "1")
                {
                    // Nếu x có LoaiBenhNhan là "1" và y có LoaiBenhNhan là "0", x ưu tiên hơn
                    return -1;
                }
                else if (y.LoaiBenhNhan == "1")
                {
                    // Nếu y có LoaiBenhNhan là "1" và x có LoaiBenhNhan là "0", y ưu tiên hơn
                    return 1;
                }
                else
                {
                    // Cả hai đều có LoaiBenhNhan là "0", so sánh theo MaLh
                    return x.MaLh.CompareTo(y.MaLh);
                }
            }
        }

        private void dgvDSLichHen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSLichHen.SelectedRows.Count > 0)
            {
                var selectedLH = (Lichhen)dgvDSLichHen.SelectedRows[0].DataBoundItem;
                // có trong tay 1 object / 1 cuốn sách đang được lựa chọn rồi
                // -> chấm từng field của nó và đổ vào form
                txtMaLH.Texts = selectedLH.MaLh.ToString();
                dtpLichHen.Value = DateTime.Parse(selectedLH.Ngayhen.ToString());
                txtTenBN.Texts = _BNService.Get(selectedLH.MaBn).Hoten.Trim();
                dtpNgaySinhBN.Value = DateTime.Parse(_BNService.Get(selectedLH.MaBn).Ngaysinh.ToString());
                txtLoaiBN.Texts = selectedLH.LoaiBenhNhan == "1" ? "Bệnh nhân đặt lịch" : "Bệnh nhân thường";
                txtTenBS.Texts = _BSService.GetBacsi(selectedLH.MaBs).Hoten;
                txtKhoa.Texts = _BSService.GetBacsi(selectedLH.MaBs).MaKhoa;
                txtNhuCauKham.Texts = selectedLH.Nhucaukham;
                txtSDT.Texts = _BNService.Get(selectedLH.MaBn).Sdt;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLH.Texts))
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("Bạn có muốn xóa lịch hẹn này không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.ToString() == "Yes")
            {
                try
                {
                    _LHService.Delete(txtMaLH.Texts);
                    MessageBox.Show("Xóa lịch hẹn thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToGridView();
                    resetInputField();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có liên quan tới dữ liệu của phòng khám! Không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLH.Texts))
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần chỉnh sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddUpdateLichKham form = new();
            form.MaLH = txtMaLH.Texts;
            form.MaBN = _BNService.getMaBNBySDT(txtSDT.Texts);
            form.ShowDialog();
            loadDataToGridView();
            resetInputField();

            // Nếu bị lỗi ko update đc thì
            // this.Hide();
            // new XemLichKhamForm().Show();
        }

        public class Header : PdfPageEventHelper
        {
            // Tên header
            private string headerText;

            // Font cho văn bản
            private BaseFont textBaseFont;
            private iTextSharp.text.Font textFont;

            // Constructor
            public Header(string headerText)
            {
                this.headerText = headerText;

                // Khởi tạo font cho văn bản
                textBaseFont = BaseFont.CreateFont("c:/windows/fonts/times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // Đường dẫn đến font "Times New Roman"
                textFont = new iTextSharp.text.Font(textBaseFont, 12, iTextSharp.text.Font.NORMAL);
            }

            // Override phương thức OnEndPage để tạo header
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);

                // Tính toán vị trí y mới cho header (giả sử là cách dưới 20px)
                float headerYPosition = document.PageSize.Top - 20;

                // Thêm header vào trang
                ColumnText.ShowTextAligned(writer.DirectContent,
                                            Element.ALIGN_CENTER,
                                            new Phrase(headerText, textFont),
                                            document.PageSize.Width / 2,
                                            headerYPosition,
                                            0);

                // Tạo dòng gạch ngang
                float lineYPosition = headerYPosition - 10;
                PdfContentByte cb = writer.DirectContent;
                cb.MoveTo(document.Left, lineYPosition);
                cb.LineTo(document.Right, lineYPosition);
                cb.Stroke();
            }
            public BaseFont GetTextBaseFont()
            {
                return textBaseFont;
            }
        }

        private void btnInLichHen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLH.Texts))
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn trước khi in phiếu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF Files|*.pdf"; // Chỉ cho phép lưu dưới dạng file PDF

            // Tên file mặc định
            saveFileDialog1.FileName = txtMaLH.Texts + ".pdf";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                using (Document document = new Document(new iTextSharp.text.Rectangle(288f, 150f), 10f, 10f, 10f, 10f))
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    // Sử dụng header được tạo

                    // Tạo và thêm thông tin lịch hẹn vào tài liệu

                    //Thêm phiếu khám bệnh
                    string mapkb = pkbService.GeneratePhieuKhamBenhID();
                    Phieukhambenh pkb = new Phieukhambenh()
                    {
                        MaPkb = mapkb,
                        Ngaykham = DateOnly.FromDateTime(dtpLichHen.Value),
                        MaBs = _LHService.Get(txtMaLH.Texts).MaBs,
                        MaBn = _LHService.Get(txtMaLH.Texts).MaBn,
                        Tinhtrang = txtNhuCauKham.Texts.Trim(),
                    };
                    pkbService.AddPhieuKhamBenh(pkb);

                    Header headerPKB = new Header("PHIẾU KHÁM BỆNH PHÒNG KHÁM NHA KHOA");
                    writer.PageEvent = headerPKB;

                    document.Open();

                    Paragraph pkbInfo = new Paragraph();
                    pkbInfo.SpacingAfter = 20f; // Dịch xuống phía dưới 20px
                    pkbInfo.Font = new iTextSharp.text.Font(headerPKB.GetTextBaseFont(), 12, iTextSharp.text.Font.NORMAL); // Sử dụng font từ header

                    // Tạo và thêm dòng gạch ngang
                    Paragraph linePKB = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1)));
                    document.Add(linePKB);

                    // Tạo và thêm thông tin lịch hẹn vào tài liệu
                    pkbInfo.Font = new iTextSharp.text.Font(headerPKB.GetTextBaseFont(), 12, iTextSharp.text.Font.NORMAL); // Sử dụng font từ header
                    pkbInfo.Add(new Chunk($"Mã PKB: {mapkb}.\n"));
                    pkbInfo.Add(new Chunk($"Ngày khám: {dtpLichHen.Text}.\n"));
                    pkbInfo.Add(new Chunk($"Bác sĩ: {txtTenBS.Texts} - {_LHService.Get(txtMaLH.Texts).MaBs}.\n"));
                    pkbInfo.Add(new Chunk($"Bệnh nhân: {txtTenBN.Texts} - {_LHService.Get(txtMaLH.Texts).MaBn}.\n"));
                    pkbInfo.Add(new Chunk($"SĐT: {txtSDT.Texts}.\n"));
                    pkbInfo.Add(new Chunk($"Nhu cầu khám: {txtNhuCauKham.Texts}\n\n"));
                    document.Add(pkbInfo);

                    document.Close();
                    return;
                }

                MessageBox.Show("Tài liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const int MaxWidth = 1301;
        private const int MaxHeight = 768;

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
