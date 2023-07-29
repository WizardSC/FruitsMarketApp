using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nvDAL;
        public NhanVienBLL()
        {
            nvDAL = new NhanVienDAL();
        }

        public DataTable getListHocSinh()
        {
            return nvDAL.getListNhanVien();
        }

        public bool insertNhanVien(NhanVienDTO nv)
        {
            return nvDAL.insertNhanVien(nv);
        }
    }
}
