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
    }
}
