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
using System.Security.Cryptography;
using System.IO;
using System.Speech.Synthesis.TtsEngine;
using GUI.Properties;

namespace GUI
{
    public partial class NhanVienGUI : Form
    {
        private NhanVienBLL nvBLL;
        private DataTable nvDataTable = new DataTable();
        private string tempTimKiem;
        private string tempTimKiemGender;

        public NhanVienGUI()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvBLL.getListNhanVien();

            dgvNhanVien.EnableHeadersVisualStyles = false;
            loadDatatoComboBox();


            btnSua.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;

            rdbTimKiemFemaleGender.Enabled = false;
            rdbTimKiemMaleGender.Enabled = false;
            // Set giá trị Tag của PictureBox
            pbImage.Tag = "placeholder_image";

        }
        private void loadDatatoComboBox()
        {
            cbxTimKiem.Items.Add("Mã NV");
            cbxTimKiem.Items.Add("Họ");
            cbxTimKiem.Items.Add("Tên");
            cbxTimKiem.Items.Add("Giới tính");
            cbxTimKiem.SelectedIndex = 0;
        }
        private void refeshForm()
        {

            btnThem.BackColor = Color.Transparent;
            btnSua.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;

            txtMaNV.Texts = "";
            txtHo.Texts = "";
            txtTen.Texts = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdbGioiTinhNam.Checked = false;
            rdbGioiTinhNu.Checked = false;
            txtDiaChi.Texts = "";
            txtSoDT.Texts = "";
            txtMaCV.Texts = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            warningMaNV.Visible = false;
            warningHo.Visible = false;
            warningTen.Visible = false;
            warningNgaySinh.Visible = false;
            warningGioiTinh.Visible = false;
            warningDiaChi.Visible = false;
            warningSoDT.Visible = false;
            warningMaCV.Visible = false;
            warningUploadAnh.Visible = false;

            errThongTin.SetError(txtMaNV, string.Empty);
            errThongTin.SetError(txtHo, string.Empty);
            errThongTin.SetError(txtTen, string.Empty);
            errThongTin.SetError(dtpNgaySinh, string.Empty);
            errThongTin.SetError(rdbGioiTinhNu, string.Empty);
            errThongTin.SetError(txtDiaChi, string.Empty);
            errThongTin.SetError(txtSoDT, string.Empty);
            errThongTin.SetError(btnChonChucVu, string.Empty);
            
            dgvNhanVien.DataSource = nvBLL.getListNhanVien();
            pbImage.Image = Properties.Resources.placeholder_image;
            pbImage.Tag = "placeholder_image";

        }
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            refeshForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Texts;
            string Ho = txtHo.Texts;
            string Ten = txtTen.Texts;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string DiaChi = txtDiaChi.Texts;
            string SoDT = txtSoDT.Texts;
            string MaCV = txtMaCV.Texts;
            string GioiTinh = null;

            byte[] img = this.convertImageToBinaryString(pbImage.Image);
            if (rdbGioiTinhNam.Checked)
            {
                GioiTinh = "Nam";
            }
            else if (rdbGioiTinhNu.Checked)
            {
                GioiTinh = "Nữ";
            }
            Console.WriteLine(GioiTinh);
            Console.WriteLine(pbImage.Tag);
            bool flagTextBox = false;
            #region check textbox rỗng
            if (pbImage.Tag == "placeholder_image")
            {
                // PictureBox đang hiển thị ảnh từ tài nguyên placeholder_image
                warningUploadAnh.Visible = true;
                flagTextBox = true;
            } else
            {
                warningUploadAnh.Visible = false;

            }
            {

            }
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
            if (string.IsNullOrEmpty(Ten))
            {
                errThongTin.SetError(txtTen, " ");
                warningTen.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(txtTen, string.Empty);
                warningTen.Visible = false;
            }
            if (string.IsNullOrEmpty(NgaySinh.ToString()))
            {
                errThongTin.SetError(dtpNgaySinh, " ");
                warningNgaySinh.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(dtpNgaySinh, string.Empty);
                warningNgaySinh.Visible = false;
            }
            if (string.IsNullOrEmpty(GioiTinh))
            {
                errThongTin.SetError(rdbGioiTinhNu, " ");
                warningGioiTinh.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(rdbGioiTinhNu, string.Empty);
                warningGioiTinh.Visible = false;
            }
            if (string.IsNullOrEmpty(DiaChi))
            {
                errThongTin.SetError(txtDiaChi, " ");
                warningDiaChi.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(txtDiaChi, string.Empty);
                warningDiaChi.Visible = false;
            }
            if (string.IsNullOrEmpty(SoDT))
            {
                errThongTin.SetError(txtSoDT, " ");
                warningSoDT.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(txtSoDT, string.Empty);
                warningSoDT.Visible = false;
            }
            if (string.IsNullOrEmpty(MaCV.ToString()))
            {
                errThongTin.SetError(btnChonChucVu, " ");
                warningMaCV.Visible = true;
                flagTextBox = true;
            }
            else
            {
                errThongTin.SetError(btnChonChucVu, string.Empty);
                warningMaCV.Visible = false;
            }
            if (flagTextBox)
            {
                return;
            }
            #endregion
            NhanVienDTO nv = new NhanVienDTO(MaNV, Ho, Ten, NgaySinh, GioiTinh, DiaChi, SoDT, img, MaCV);
            int flag = nvBLL.insertNhanVien(nv) ? 1 : 0;
            if (flag == 1)
            {
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                refeshForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region chỉnh màu button
            btnThem.BackColor = Color.LightGray;
            btnSua.BackColor = Color.Transparent;
            btnXoa.BackColor = Color.Transparent;
            #endregion
            int i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Texts = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHo.Texts = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtTen.Texts = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            string GioiTinh = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            if (GioiTinh == "Nam")
            {
                rdbGioiTinhNam.Checked = true;
            }
            else
            {
                rdbGioiTinhNu.Checked = true;
            }
            txtDiaChi.Texts = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtSoDT.Texts = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txtMaCV.Texts = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            byte[] imageBytes = (byte[])dgvNhanVien.Rows[i].Cells[8].Value;            
            pbImage.Image = convertBinaryStringToImage(imageBytes);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Texts;
            int kq = nvBLL.deleteNhanvien(MaNV) ? 1 : 0;
            if (kq == 1)
            {
                MessageBox.Show("Xóa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                refeshForm();
            }
            else
            {
                MessageBox.Show("Xóa thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string MaNV = txtMaNV.Texts;
            string Ho = txtHo.Texts;
            string Ten = txtTen.Texts;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string DiaChi = txtDiaChi.Texts;
            string SoDT = txtSoDT.Texts;
            string MaCV = txtMaCV.Texts;
            string GioiTinh = null;
            byte[] IMG = this.convertImageToBinaryString(pbImage.Image);
            if (rdbGioiTinhNam.Checked)
            {
                GioiTinh = "Nam";
            }
            else if (rdbGioiTinhNu.Checked)
            {
                GioiTinh = "Nữ";
            }
            NhanVienDTO nv = new NhanVienDTO(MaNV, Ho, Ten, NgaySinh, GioiTinh, DiaChi, SoDT, IMG, MaCV);
            int kq = nvBLL.updateNhanVien(nv) ? 1 : 0;
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                refeshForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }
        //Tìm kiếm không cần phải duyệt database
        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tempTimKiemGender);
            DataView dvNhanVien = nvBLL.getListNhanVien().DefaultView;
            if (tempTimKiem == "Mã NV")
            {
                dvNhanVien.RowFilter = "MaNV like '%" + txtTimKiem.Texts + "%'";
            }
            if (tempTimKiem == "Họ")
            {
                dvNhanVien.RowFilter = "Ho Like '%" + txtTimKiem.Texts + "%'";
            }
            if (tempTimKiem == "Tên")
            {
                dvNhanVien.RowFilter = "Ten Like '%" + txtTimKiem.Texts + "%'";
            }
            if (tempTimKiem == "Giới tính")
            {
                if (tempTimKiemGender == "Nam")
                {
                    dvNhanVien.RowFilter = "GioiTinh = 'Nam'";
                }
                else if (tempTimKiemGender == "Nữ")
                {
                    dvNhanVien.RowFilter = "GioiTinh = 'Nữ'";
                }
            }

            // Cập nhật nguồn dữ liệu gốc của DataView dựa trên DataView đã lọc
            dgvNhanVien.DataSource = dvNhanVien.ToTable();
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            refeshForm();
            txtTimKiem.Texts = null;
            tempTimKiem = cbxTimKiem.SelectedItem.ToString();
            if (tempTimKiem.Equals("Giới tính"))
            {
                txtTimKiem.Enabled = false;
                rdbTimKiemMaleGender.Enabled = true;
                rdbTimKiemFemaleGender.Enabled = true;
            }
            else
            {
                txtTimKiem.Texts = "";
                txtTimKiem.Enabled = true;
                rdbTimKiemFemaleGender.Checked = false;
                rdbTimKiemMaleGender.Checked = false;
                rdbTimKiemMaleGender.Enabled = false;
                rdbTimKiemFemaleGender.Enabled = false;
            }

        }

        private void rdbTimKiemMaleGender_CheckedChanged(object sender, EventArgs e)
        {
            tempTimKiemGender = "Nam";
            txtTimKiem.Texts = "Nam";

        }

        private void rdbTimKiemGenderNu_CheckedChanged(object sender, EventArgs e)
        {

            tempTimKiemGender = "Nữ";
            txtTimKiem.Texts = "Nữ";
        }

        private void btnUploadAnh_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn thư mục gốc của ứng dụng
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Kết hợp đường dẫn tương đối để tạo đường dẫn đến thư mục NhanVien
            string folderPath = Path.Combine(appDirectory, "resources", "image", "NhanVien");

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

                pbImage.Tag = txtMaNV.Text;
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
