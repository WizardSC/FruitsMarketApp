using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.CodeDom;

namespace DAL
{
    public class NhanVienDAL : MSSQLConnect
    {
        public DataTable getListNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from nhanvien";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public bool insertNhanVien(NhanVienDTO nv)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into nhanvien values(@MaNV, @Ho, @Ten, @NgaySinh, @GioiTinh, @DiaChi, @SoDT, @MaCV, @IMG)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 20).Value = nv.MaNV;
                cmd.Parameters.Add("@ho", SqlDbType.NVarChar, 50).Value = nv.Ho;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = nv.Ten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = nv.GioiTinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = nv.DiaChi;
                cmd.Parameters.Add("@sodt", SqlDbType.NVarChar, 50).Value = nv.SoDT;
                cmd.Parameters.Add("@macv", SqlDbType.NVarChar, 50).Value = nv.MaCV;
                cmd.Parameters.Add("@img", SqlDbType.NVarChar, 50).Value = nv.Img;
                cmd.ExecuteNonQuery();
                return true;
            } catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            } finally
            {
                Disconnect();
            }
        }

        public bool updateNhanVien(NhanVienDTO nv)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nhanvien set Ho = @Ho, Ten = @Ten, @NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDT = @SoDT, MaCV = @MaCV, IMG = @IMG where MaNV = @MaNV";
                cmd.Connection = conn;
                cmd.Parameters.Add("@ho", SqlDbType.NVarChar, 50).Value = nv.Ho;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = nv.Ten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = nv.GioiTinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = nv.DiaChi;
                cmd.Parameters.Add("@sodt", SqlDbType.NVarChar, 50).Value = nv.SoDT;
                cmd.Parameters.Add("@macv", SqlDbType.NVarChar, 50).Value = nv.MaCV;
                cmd.Parameters.Add("@img", SqlDbType.NVarChar, 50).Value = nv.Img;
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 20).Value = nv.MaNV;
                cmd.ExecuteNonQuery();
                return true;
            } catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            } finally
            {
                Disconnect();
            }
        }
    }
}
