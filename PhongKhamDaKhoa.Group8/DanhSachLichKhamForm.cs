using Repositories.Entities;
using Services;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhongKhamDaKhoa.Group8
{
    public partial class DanhSachLichKhamForm : Form
    {
        private System.Threading.Timer timer;
        public string? sdt { get; set; }
        BacSiService bsService = new BacSiService();
        LichHenService lhService = new LichHenService();
        BenhNhanService bnService = new BenhNhanService();

        public DanhSachLichKhamForm()
        {
            InitializeComponent();
            InitializeTimer();
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

        private void InitializeTimer()
        {
            timer = new System.Threading.Timer(TimerCallback, null, 0, 2000); // 2 giây
        }

        private void TimerCallback(object state)
        {
            LoadDgvLichKham();
        }

        private void LoadDgvLichKham()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            if (this.sdt != null)
            {
                Bacsi? bacsi = bsService.GetByPhone(this.sdt);
                tenBS.Text = bacsi?.Hoten;

                foreach (var item in lhService.GetAll())
                {
                    if (item.MaBs == bacsi.MaBs && item.Ngayhen == new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day))
                    {
                        string tenBN = bnService.Get(item.MaBn).Hoten;
                        list.Add(new Tuple<string, string>(item.MaLh, tenBN));
                    }
                }

                this.Invoke(new Action(() =>
                {
                    dgvLichKham.DataSource = null;
                    dgvLichKham.DataSource = list;
                    dgvLichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvLichKham.Columns["Item1"].HeaderText = "Mã";
                    dgvLichKham.Columns["Item2"].HeaderText = "Bệnh nhân";
                }));
            }
        }

        private void DanhSachLichKhamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const int MaxWidth = 663;
        private const int MaxHeight = 538;

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
