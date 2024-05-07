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
    public partial class AddPhuTaForm : Form
    {
        public AddPhuTaForm()
        {
            InitializeComponent();
        }

        private PhuTaService _service = new PhuTaService();

        private void btnSavePT_Click(object sender, EventArgs e)
        {
            string PTId = _service.GeneratePhuTaID();
            string name = txtNamePT.Texts;
            DateOnly birthday = new DateOnly(dtpBirthdayPT.Value.Year, dtpBirthdayPT.Value.Month, dtpBirthdayPT.Value.Day);
            DateOnly dayWorking = new DateOnly(dtpDateWorkingPT.Value.Year, dtpDateWorkingPT.Value.Month, dtpDateWorkingPT.Value.Day);
            string phoneNumber = txtPhonePT.Texts;
            string gender = chkMalePT.Checked ? "Nam" : "Nữ";

            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thêm Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chkMalePT.Checked && !chkFemalePT.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thêm Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Phuta phuta;
            if (phoneNumber == "")
            {
                phuta = new()
                {
                    MaPt = PTId,
                    Hoten = name,
                    Ngaysinh = birthday,
                    Ngaylamviec = dayWorking,
                    Gioitinh = gender
                };
            }
            else
            {
                phuta = new()
                {
                    MaPt = PTId,
                    Hoten = name,
                    Ngaysinh = birthday,
                    Ngaylamviec = dayWorking,
                    Sdt = phoneNumber,
                    Gioitinh = gender
                };
            }

            _service.AddPhuTa(phuta);

            this.Close();
        }

        private void chkMalePT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMalePT.Checked)
            {
                chkFemalePT.Checked = false;
            }
        }

        private void chkFemalePT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemalePT.Checked)
            {
                chkMalePT.Checked = false;
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
