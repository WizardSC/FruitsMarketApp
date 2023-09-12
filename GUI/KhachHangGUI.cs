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
            } else if (rdbGioiTinhNu.Checked)
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
            } else if (rdbKHoatDong.Checked)
            {
                TrangThai = rdbKHoatDong.Text;
            }
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
            if(TrangThai == "Không hoạt động")
            {
                rdbKHoatDong.Checked = true;
            } else
            {
                rdbHoatDong.Checked = true;
            }
            byte[] imageBytes = (byte[])dgvKhachHang.Rows[i].Cells[7].Value;
            pbImage.Image = convertBinaryStringToImage(imageBytes);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }
    }
}
