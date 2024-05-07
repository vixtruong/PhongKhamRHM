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

namespace PhongKhamDaKhoa.Group8
{
    public partial class AddBacSiForm : Form
    {
        KhoaService khoaService = new KhoaService();

        public AddBacSiForm()
        {
            InitializeComponent();
        }

        private BacSiService _service = new BacSiService();

        private void btnSaveBS_Click(object sender, EventArgs e)
        {
            string BSId = _service.GenerateBacSiID();
            string name = txtNameBS.Texts;
            string khoa = txtKhoa.Texts;
            DateOnly birthday = new DateOnly(dtpBirthdayBS.Value.Year, dtpBirthdayBS.Value.Month, dtpBirthdayBS.Value.Day);
            DateOnly dayWorking = new DateOnly(dtpDateWorkingBS.Value.Year, dtpDateWorkingBS.Value.Month, dtpDateWorkingBS.Value.Day);
            string phoneNumber = txtPhoneBS.Texts;
            string gender = chkMaleBS.Checked ? "Nam" : "Nữ";

            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thêm Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chkMaleBS.Checked && !chkFemaleBS.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thêm Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (khoaService.Get(khoa) == null)
            {
                MessageBox.Show("Không tồn tại khoa này!", "NullError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bacsi bacsi;
            if (phoneNumber == "")
            {
                bacsi = new()
                {
                    MaBs = BSId,
                    Hoten = name,
                    Ngaysinh = birthday,
                    Ngaylamviec = dayWorking,
                    Gioitinh = gender,
                    MaKhoa = khoa,
                };
            }
            else
            {
                bacsi = new()
                {
                    MaBs = BSId,
                    Hoten = name,
                    Ngaysinh = birthday,
                    Ngaylamviec = dayWorking,
                    Sdt = phoneNumber,
                    Gioitinh = gender,
                    MaKhoa = khoa,
                };
            }

            _service.AddBacSi(bacsi);

            this.Close();
        }

        private void chkMaleBS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaleBS.Checked)
            {
                chkFemaleBS.Checked = false;
            }
        }

        private void chkFemaleBS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemaleBS.Checked)
            {
                chkFemaleBS.Checked = false;
            }
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
