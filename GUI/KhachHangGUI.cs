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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Texts;
            string Ho = txtHo.Texts;
            string Ten = txtTen.Texts;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string GioiTinh = "";
            string DiaChi = txtDiaChi.Texts;
            string SoDT = txtSoDT.Texts;
            byte[] img = null;
            int DiemTichLuy = 0;
            string TrangThai = "";
            KhachHangDTO kh = new KhachHangDTO(MaKH,Ho,Ten,NgaySinh,DiaChi,GioiTinh,SoDT,img,DiemTichLuy,TrangThai);
            int flag = khBLL.insertKhachHang(kh) ? 1 : 0;
            if (flag == 1)
            {
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
