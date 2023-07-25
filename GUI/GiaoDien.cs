using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
            customizeDesign();
        }

        

       

        private void customizeDesign()
        {
            pnSubHangHoa.Visible = false;
            pnSubQuanLy.Visible = false;
        }

        private void hideSubMenu()
        {
            
            if(pnSubHangHoa.Visible == true)
            
                pnSubHangHoa.Visible = false;
            
            if(pnSubQuanLy.Visible== true)
            
                pnSubQuanLy.Visible = false;
            
        }
        

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }

        private void hidePnLB(Panel pn)
        {
            pnLBTrangChu.Visible = false;
            pnLBHangHoa.Visible = false;
            pnLBBanHang.Visible = false;
            pnLBHoaDon.Visible = false;
            pnLBKhachHang.Visible = false;
            pnLBNhanVien.Visible = false;
            pnLBNhapHang.Visible = false;
            pnLBQuanLy.Visible = false;
            pnLBPhieuNhap.Visible = false;
            pn.Visible = true;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChucNang.Controls.Add(childForm);
            pnChucNang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        

        #region click button menu
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBHangHoa);
            showSubMenu(pnSubHangHoa);
            
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBTrangChu);
            
            hideSubMenu();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBQuanLy);
            showSubMenu(pnSubQuanLy);
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBBanHang);
            
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBNhanVien);
            openChildForm(new NhanVien());
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBHoaDon);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBNhapHang);
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBPhieuNhap);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            hidePnLB(pnLBKhachHang);
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

