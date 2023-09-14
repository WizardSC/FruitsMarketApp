using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL khDAL;
        private List<KhachHangDTO> listKhachHang = null;
        public KhachHangBLL()
        {
            khDAL = new KhachHangDAL();
        }

        public DataTable getListKhachHang()
        {
            return khDAL.getListKhachHang();
        }

       


        public bool insertKhachHang(KhachHangDTO kh)
        {
            return khDAL.insertKhachHang(kh);
        }

        public bool updateKhachHang(KhachHangDTO kh)
        {
            return khDAL.updateKhachHang(kh);
        }

        public bool deleteKhachHang(string MaKH)
        {
            return khDAL.deleteKhachHang(MaKH);
        }
    }
}
