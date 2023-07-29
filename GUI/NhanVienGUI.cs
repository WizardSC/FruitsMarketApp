using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using CustomControls.RJControls;
using System.Windows.Media.Media3D;

namespace GUI
{
    public partial class NhanVienGUI : Form
    {
        private NhanVienBLL nvBLL;
        List<RJTextBox> dsTextBox = new List<RJTextBox>();

        public NhanVienGUI()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvBLL.getListHocSinh();
            dgvNhanVien.EnableHeadersVisualStyles = false;



            btnSua.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;
            Console.WriteLine("Hello");

        }

        private void rjTextBox7__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjRadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Texts) || string.IsNullOrEmpty(txtHo.Texts))
            {
                if (string.IsNullOrEmpty(txtMaNV.Texts))
                {
                    errThongTin.SetError(txtMaNV, " ");
                    warningMaNV.Visible = true;
                }
                else
                {
                    errThongTin.SetError(txtMaNV, string.Empty);
                    warningMaNV.Visible = false;
                }

                if (string.IsNullOrEmpty(txtHo.Texts))
                {
                    errThongTin.SetError(txtHo, " ");
                    warningHo.Visible = true;
                }
                else
                {
                    errThongTin.SetError(txtHo, string.Empty);
                    warningHo.Visible = false;
                }

                return;
            }

            MessageBox.Show("Thanh cong");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Texts;
            string Ho = txtHo.Texts;
            bool flagTextBox = false;
            #region check textbox rỗng
            if (string.IsNullOrEmpty(MaNV))
            {
                errThongTin.SetError(txtMaNV, " ");
                warningMaNV.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(txtMaNV, string.Empty);
                warningMaNV.Visible = false;
            }

            if (string.IsNullOrEmpty(Ho))
            {
                errThongTin.SetError(txtHo, " ");
                warningHo.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(txtHo, string.Empty);
                warningHo.Visible = false;
            }
            
            if (flagTextBox)
            {
                return;
            }
            #endregion
            MessageBox.Show("Thanh cong");
        }
}
}
;