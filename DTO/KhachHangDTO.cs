using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string maKH;
        private string ho;
        private string ten;
        private DateTime ngaySinh;
        private string diaChi;
        private string gioiTinh;
        private string soDT;
        private byte[] img;
        private int diemTichLuy;
        private string trangThai;

        public KhachHangDTO()
        {
        }

        public KhachHangDTO(string maKH, string ho, string ten, DateTime ngaySinh, string diaChi, string gioiTinh, string soDT, byte[] img, int diemTichLuy, string trangThai)
        {
            this.maKH = maKH;
            this.ho = ho;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.soDT = soDT;
            this.img = img;
            this.diemTichLuy = diemTichLuy;
            this.trangThai = trangThai;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public byte[] Img { get => img; set => img = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
