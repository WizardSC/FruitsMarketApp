using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class KhachHangDAL : MSSQLConnect
    {
        public DataTable getListKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from khachhang";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public bool insertKhachHang(KhachHangDTO kh)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into khachhang values (@MaKH, @Ho, @Ten, @NgaySinh, @GioiTinh, @DiaChi, @SoDT, @IMG, @DiemTichLuy, @TrangThai)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar, 20).Value = kh.MaKH;
                cmd.Parameters.Add("@Ho", SqlDbType.NVarChar, 50).Value = kh.Ho;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 50).Value = kh.Ten;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 20).Value = kh.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 20).Value = kh.DiaChi;
                cmd.Parameters.Add("@SoDT", SqlDbType.NVarChar, 20).Value = kh.SoDT;
                cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = kh.Img;
                cmd.Parameters.Add("@DiemTichLuy", SqlDbType.Int).Value = kh.DiemTichLuy;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 20).Value = kh.TrangThai;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool updateKhachHang(KhachHangDTO kh)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update khachhang set Ho = @Ho, Ten = @Ten, @NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDT = @SoDT, IMG = @IMG, TrangThai = @TrangThai where MaKH = @MaKH";
                cmd.Connection = conn;
                cmd.Parameters.Add("@ho", SqlDbType.NVarChar, 50).Value = kh.Ho;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = kh.Ten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = kh.NgaySinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = kh.GioiTinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = kh.DiaChi;
                cmd.Parameters.Add("@sodt", SqlDbType.NVarChar, 50).Value = kh.SoDT;
                cmd.Parameters.Add("@img", SqlDbType.Image).Value = kh.Img;
                cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar, 50).Value = kh.TrangThai;
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar, 20).Value = kh.MaKH;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}

