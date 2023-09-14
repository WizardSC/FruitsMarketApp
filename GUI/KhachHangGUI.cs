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
using System.IO;

namespace GUI
{
    public partial class KhachHangGUI : Form
    {
        private KhachHangBLL khBLL;
        private string tempTimKiem;
        private string tempFrom = "";
        private string tempTo = "";
        public KhachHangGUI()
        {
            InitializeComponent();
            khBLL = new KhachHangBLL();
        }


        #region Các hàm bổ trợ
        //chuyển đổi một hình ảnh thành một dạng biểu diễn nhị phân 
        private byte[] convertImageToBinaryString(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();

        }

        //chuyển đổi một dạng biểu diễn nhị phân thành một hình ảnh 
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
        }

        private void refreshValue()
        {
            txtFrom.Texts = "";
            txtTo.Texts = "";
            txtTimKiem.Texts = "";
            tempFrom = "";
            tempTo = "";
            tempTimKiem = "";
        }
        private void refreshForm()
        {
            txtMaKH.Texts = "";
            txtHo.Texts = "";
            txtTen.Texts = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdbGioiTinhNam.Checked = false;
            rdbGioiTinhNu.Checked = false;
            txtDiaChi.Texts = "";
            txtSoDT.Texts = "";
            rdbHoatDong.Checked = false;
            rdbKHoatDong.Checked = false;

            dgvKhachHang.DataSource = khBLL.getListKhachHang();
            pbImage.Image = Properties.Resources.placeholder_image;
            pbImage.Tag = "placeholder_image";

            btnSua.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThem.BackColor = Color.Transparent;

            pnFilter.Visible = false;
            pnSearch.Visible = true;
            btnFilter.BackColor = Color.FromArgb(215, 215, 215);
            btnFilter.BackgroundColor = Color.FromArgb(215, 215, 215);

            btnSearch.BackColor = Color.FromArgb(255, 112, 0);
            btnSearch.BackgroundColor = Color.FromArgb(255, 112, 0);


            loadMaKH();
        }
        
        //Hàm load mã KH
        private void loadMaKH()
        {
            DataTable dataKH = khBLL.getListKhachHang();
            string lastMaKH = null;
            foreach (DataRow row in dataKH.Rows)
            {
                lastMaKH = row["MaKH"].ToString();
               

            }
            if (lastMaKH == "")
            {
                txtMaKH.Texts = "KH001";
            }
            int tempNum = int.Parse(lastMaKH.Substring(2));
            if((tempNum + 1) >= 10)
            {
                txtMaKH.Texts = "KH0" + (tempNum+1).ToString();
            } else if (tempNum >= 1 && tempNum < 10) {
                txtMaKH.Texts = "KH00" + (tempNum+1).ToString();
            }
            
        }
        //Hàm load data lên combobox
        private void loadToComboBox()
        {
            cbxTimKiem.Items.Add("Mã KH");
            cbxTimKiem.Items.Add("Họ");
            cbxTimKiem.Items.Add("Tên");
            cbxTimKiem.SelectedIndex = 0;
        }

        #endregion
        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khBLL.getListKhachHang();
            dgvKhachHang.EnableHeadersVisualStyles = false;
            
            btnSua.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaKH.Enabled = false;

            //Lúc khởi động form thì panelFilter mặc định ẩn
            pnFilter.Visible = false;
            loadMaKH();
            loadToComboBox();

            pbImage.Image = Properties.Resources.placeholder_image;
            pbImage.Tag = "placeholder_image";

            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Texts;
            string Ho = txtHo.Texts;
            string Ten = txtTen.Texts;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string GioiTinh = "";
            if (rdbGioiTinhNam.Checked)
            {
                GioiTinh = rdbGioiTinhNam.Text;
            }
            else if (rdbGioiTinhNu.Checked)
            {
                GioiTinh = rdbGioiTinhNu.Text;
            }
            string DiaChi = txtDiaChi.Texts;
            string SoDT = txtSoDT.Texts;
            byte[] img = this.convertImageToBinaryString(pbImage.Image);
            int DiemTichLuy = 0;
            string TrangThai = "";

            if (rdbHoatDong.Checked)
            {
                TrangThai = rdbHoatDong.Text;
            }
            else if (rdbKHoatDong.Checked)
            {
                TrangThai = rdbKHoatDong.Text;
            }
            KhachHangDTO kh = new KhachHangDTO(MaKH, Ho, Ten, NgaySinh, DiaChi, GioiTinh, SoDT, img, DiemTichLuy, TrangThai);
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
            refreshForm();
        }

        private void btnUploadAnh_Click(object sender, EventArgs e)
        {

            // Lấy đường dẫn thư mục gốc của ứng dụng
            string appDirectory = Directory.GetCurrentDirectory();
            string appDirectory1 = Directory.GetParent(appDirectory).Parent.FullName;
            // Kết hợp đường dẫn tương đối để tạo đường dẫn đến thư mục KhachHang
            string folderPath = Path.Combine(appDirectory1, "resources", "image", "KhachHang");

            // Thiết lập đường dẫn ban đầu cho OpenFileDialog
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = folderPath,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;

                pbImage.Tag = txtMaKH.Texts;
                Console.WriteLine(pbImage.Tag);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refreshForm();
            refreshValue();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region đổi màu btn
            btnThem.BackColor = Color.LightGray;
            btnSua.BackColor = Color.Transparent;
            btnXoa.BackColor = Color.Transparent;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            #endregion
            int i = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Texts = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtHo.Texts = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtTen.Texts = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            string GioiTinh = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
            if (GioiTinh == "Nam")
            {
                rdbGioiTinhNam.Checked = true;
            }
            else
            {
                rdbGioiTinhNu.Checked = true;
            }
            txtDiaChi.Texts = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
            txtSoDT.Texts = dgvKhachHang.Rows[i].Cells[6].Value.ToString();
            string TrangThai = dgvKhachHang.Rows[i].Cells[9].Value.ToString();
            if (TrangThai == "Không hoạt động")
            {
                rdbKHoatDong.Checked = true;
            }
            else
            {
                rdbHoatDong.Checked = true;
            }
            byte[] imageBytes = (byte[])dgvKhachHang.Rows[i].Cells[7].Value;
            pbImage.Image = convertBinaryStringToImage(imageBytes);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Texts;
            string Ho = txtHo.Texts;
            string Ten = txtTen.Texts;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string GioiTinh = "";
            if (rdbGioiTinhNam.Checked)
            {
                GioiTinh = rdbGioiTinhNam.Text;
            }
            else if (rdbGioiTinhNu.Checked)
            {
                GioiTinh = rdbGioiTinhNu.Text;
            }
            string DiaChi = txtDiaChi.Texts;
            string SoDT = txtSoDT.Texts;
            byte[] img = this.convertImageToBinaryString(pbImage.Image);
            int DiemTichLuy = 0;
            string TrangThai = "";

            KhachHangDTO kh = new KhachHangDTO(MaKH, Ho, Ten, NgaySinh, DiaChi, GioiTinh, SoDT, img, DiemTichLuy, TrangThai);
            int kq = khBLL.updateKhachHang(kh) ? 1 : 0;
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                refreshForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Texts;
            var choice = MessageBox.Show("Xác nhận xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                int kq = khBLL.deleteKhachHang(MaKH) ? 1 : 0;
                if (kq == 1)
                {

                    {
                        MessageBox.Show("Xóa thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        refreshForm();
                    }

                }
                else
                {
                    MessageBox.Show("Thêm thất bại",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            } else if(choice == DialogResult.No)
            {
                return;
            }
                

        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            refreshForm();

            DataView dvKhachHang = khBLL.getListKhachHang().DefaultView;
            
           
            switch (tempTimKiem)
            {
                case "Mã KH":
                    dvKhachHang.RowFilter = "MaKH like '%" + txtTimKiem.Texts + "%'";
                    break;
            }
            dgvKhachHang.DataSource = dvKhachHang.ToTable();
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            tempTimKiem = cbxTimKiem.SelectedItem.ToString();
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnFilter.BackColor = Color.FromArgb(255, 112, 0);
            btnFilter.BackgroundColor = Color.FromArgb(255, 112, 0);

            btnSearch.BackColor = Color.FromArgb(215, 215, 215);
            btnSearch.BackgroundColor = Color.FromArgb(215, 215, 215);

            pnFilter.Visible = true;
            pnSearch.Visible = false;

            //refreshForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnFilter.BackColor = Color.FromArgb(215, 215, 215);
            btnFilter.BackgroundColor = Color.FromArgb(215, 215, 215);

            btnSearch.BackColor = Color.FromArgb(255, 112, 0);
            btnSearch.BackgroundColor = Color.FromArgb(255, 112, 0);

            pnSearch.Visible = true;
            pnFilter.Visible = false;

            //refreshForm();

        }
        //Xóa bỏ tự chọn dòng đầu tiên của DataGridView khi load form
        private void dgvKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKhachHang.ClearSelection();
            dgvKhachHang.CurrentCell = null;
        }

        

        private void searchDiemTichLuy(int minValue, int maxValue)
        {
            DataView dvKhachHang = khBLL.getListKhachHang().DefaultView;
            dvKhachHang.RowFilter = $"DiemTichLuy >= {minValue} AND DiemTichLuy <= {maxValue}";
            dgvKhachHang.DataSource = dvKhachHang.ToTable();

        }
        private void txtFrom__TextChanged(object sender, EventArgs e)
        {
            int minValue;
            int maxValue;
            tempFrom = txtFrom.Texts;
            if (tempTo.Equals("") || tempFrom.Equals(""))
            {
                
            } else if (!tempTo.Equals("") && !tempFrom.Equals(""))
            {
                
                int.TryParse(txtFrom.Texts, out minValue);
                int.TryParse(txtTo.Texts, out maxValue);
                searchDiemTichLuy(minValue, maxValue);
            }
        }

        private void txtTo__TextChanged(object sender, EventArgs e)
        {
            int minValue;
            int maxValue;
            tempTo = txtTo.Texts;
            if (tempTo.Equals("") || tempFrom.Equals(""))
            {
                

            }
            else if (!tempTo.Equals("") && !tempFrom.Equals(""))
            {
              

                int.TryParse(txtFrom.Texts, out minValue);
                int.TryParse(txtTo.Texts, out maxValue);
                searchDiemTichLuy(minValue, maxValue);
            }
        }
    }
}
