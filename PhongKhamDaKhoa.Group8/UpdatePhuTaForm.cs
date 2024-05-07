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
    public partial class UpdatePhuTaForm : Form
    {
        public UpdatePhuTaForm()
        {
            InitializeComponent();
        }

        PhuTaService _service = new PhuTaService();
        public string? id { get; set; }

        private void UpdatePhuTaForm_Load(object sender, EventArgs e)
        {
            if (this.id != null)
            {
                Phuta phuta = _service.GetPhuTa(id);

                txtNamePT.Texts = phuta.Hoten;
                dtpBirthdayPT.Text = phuta.Ngaysinh.ToString();
                dtpDateWorkingPT.Text = phuta.Ngaylamviec.ToString();
                string gioitinh = phuta.Gioitinh.ToString();
                if (phuta.Sdt == null)
                {
                    txtPhonePT.Texts = "";
                }
                else
                {
                    txtPhonePT.Texts = phuta.Sdt;
                }

                if (gioitinh.ToLower().Equals("Nam".ToLower()))
                {
                    chkMalePT.Checked = true;
                    chkFemalePT.Checked = false;
                }
                else
                {
                    chkMalePT.Checked = false;
                    chkFemalePT.Checked = true;
                }
            }
        }

        private void btnSavePT_Click(object sender, EventArgs e)
        {
            string PTId = id;
            string name = txtNamePT.Texts;
            DateOnly birthday = new DateOnly(dtpBirthdayPT.Value.Year, dtpBirthdayPT.Value.Month, dtpBirthdayPT.Value.Day);
            DateOnly dayWorking = new DateOnly(dtpDateWorkingPT.Value.Year, dtpDateWorkingPT.Value.Month, dtpDateWorkingPT.Value.Day);
            string phoneNumber = txtPhonePT.Texts;
            string gender = chkMalePT.Checked ? "Nam" : "Nữ";

            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cập nhật Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chkMalePT.Checked && !chkFemalePT.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Cập nhật Lễ tân", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            _service.UpdatePhuTa(phuta);

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
    }
}
