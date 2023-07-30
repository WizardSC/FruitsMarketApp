using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV;
        private string ho;
        private string ten;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDT;
        
        private byte[] img;
        private string maCV;

        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string maNV, string ho, string ten, DateTime ngaySinh, string gioiTinh, string diaChi, string soDT, byte[] img, string maCV)
        {
            this.maNV = maNV;
            this.ho = ho;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.img = img;
            this.maCV = maCV;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public byte[] Img { get => img; set => img = value; }
    }
}
