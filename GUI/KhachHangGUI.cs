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
    public partial class KhachHangGUI : Form
    {
        private KhachHangBLL khBLL;
        public KhachHangGUI()
        {
            InitializeComponent();
            khBLL = new KhachHangBLL();
        }

        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khBLL.getListKhachHang();
            dgvKhachHang.EnableHeadersVisualStyles = false;
        }
    }
}
