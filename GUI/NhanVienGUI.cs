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
namespace GUI
{
    public partial class NhanVienGUI : Form
    {
        private NhanVienBLL nvBLL;


        public NhanVienGUI()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvBLL.getListHocSinh();
            dgvNhanVien.EnableHeadersVisualStyles = false;
            
            if (dgvNhanVien != null)
            {
                dgvNhanVien.ClearSelection();
            }
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
    }
}
