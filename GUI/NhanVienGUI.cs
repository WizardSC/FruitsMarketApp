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
            dgvNhanVien.DataSource = nvBLL.getListNhanVien();
            dgvNhanVien.EnableHeadersVisualStyles = false;



            btnSua.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;
            Console.WriteLine("Hello");

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

            errThongTin.SetError(txtMaNV, string.Empty);
            errThongTin.SetError(txtHo, string.Empty);
            errThongTin.SetError(txtTen, string.Empty);
            errThongTin.SetError(dtpNgaySinh, string.Empty);
            errThongTin.SetError(rdbGioiTinhNu, string.Empty);
            errThongTin.SetError(txtDiaChi, string.Empty);
            errThongTin.SetError(txtSoDT, string.Empty);
            errThongTin.SetError(btnChonChucVu, string.Empty);

            dgvNhanVien.DataSource = nvBLL.getListNhanVien();

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
            string IMG = "";
            if (rdbGioiTinhNam.Checked)
            {
                GioiTinh = "Nam";
            } else if (rdbGioiTinhNu.Checked)
            {
                GioiTinh = "Nữ";
            }
            Console.WriteLine(GioiTinh);
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
            NhanVienDTO nv = new NhanVienDTO(MaNV,Ho,Ten,NgaySinh,GioiTinh,DiaChi,SoDT,IMG,MaCV);
            int flag = nvBLL.insertNhanVien(nv) ? 1 : 0;
            if (flag == 1)
            {
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                refeshForm();
            } else
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
            if(GioiTinh == "Nam")
            {
                rdbGioiTinhNam.Checked = true;
            } else
            {
                rdbGioiTinhNu.Checked = true;
            }
            txtDiaChi.Texts = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtSoDT.Texts = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txtMaCV.Texts = dgvNhanVien.Rows[i].Cells[7].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

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
            string IMG = "";
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
    }
}
