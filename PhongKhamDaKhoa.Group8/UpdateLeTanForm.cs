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
    public partial class UpdateLeTanForm : Form
    {
        public UpdateLeTanForm()
        {
            InitializeComponent();
        }

        LeTanService _service = new LeTanService();

        public string? id { get; set; }

        private void UpdateLeTanForm_Load(object sender, EventArgs e)
        {
            if (this.id != null)
            {
                Letan letan = _service.GetLetan(id);

                txtNameLT.Texts = letan.Hoten;
                dtpBirthdayLT.Text = letan.Ngaysinh.ToString();
                dtpDateWorkingLT.Text = letan.Ngaylamviec.ToString();
                string gioitinh = letan.Gioitinh.ToString();
                if (letan.Sdt == null)
                {
                    txtPhoneLT.Texts = "";
                }
                else
                {
                    txtPhoneLT.Texts = letan.Sdt;
                }

                if (gioitinh.ToLower().Equals("Nam".ToLower()))
                {
                    chkMaleLT.Checked = true;
                    //chkFemaleLT.Checked = false;
                }
                else
                {
                    //chkMaleLT.Checked = false;
                    chkFemaleLT.Checked = true;
                }
            }
        }

        private void btnSaveLT_Click(object sender, EventArgs e)
        {
            string LTId = id;
            string name = txtNameLT.Texts;
            DateOnly birthday = new DateOnly(dtpBirthdayLT.Value.Year, dtpBirthdayLT.Value.Month, dtpBirthdayLT.Value.Day);
            DateOnly dayWorking = new DateOnly(dtpDateWorkingLT.Value.Year, dtpDateWorkingLT.Value.Month, dtpDateWorkingLT.Value.Day);
            string phoneNumber = txtPhoneLT.Texts;
            string gender = chkMaleLT.Checked ? "Nam" : "Nữ";

            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cập nhật Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chkMaleLT.Checked && !chkFemaleLT.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Cập nhật Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Letan letan;
            if (phoneNumber == "")
            {
                letan = new()
                {
                    MaLt = LTId,
                    Hoten = name,
                    Ngaysinh = birthday,
                    Ngaylamviec = dayWorking,
                    Gioitinh = gender
                };
            }
            else
            {
                letan = new()
                {
                    MaLt = LTId,
                    Hoten = name,
                    Ngaysinh = birthday,
                    Ngaylamviec = dayWorking,
                    Sdt = phoneNumber,
                    Gioitinh = gender
                };
            }

            _service.UpdateLeTan(letan);

            this.Close();
        }

        private void chkMaleLT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaleLT.Checked)
            {
                chkFemaleLT.Checked = false;
            }
        }

        private void chkFemaleLT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemaleLT.Checked)
            {
                chkMaleLT.Checked = false;
            }
        }
    }
}
