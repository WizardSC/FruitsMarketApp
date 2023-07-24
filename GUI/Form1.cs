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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        
       

        private void customButton2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Xin chao");
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
        }

        
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubHangHoa);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubQuanLy);
        }
    }
}

