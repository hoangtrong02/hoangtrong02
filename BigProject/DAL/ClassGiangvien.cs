using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class ClassGiangvien : InterfaceGiangvien
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        SqlDataAdapter da;
        public int Magiangvien { get; set; }
        public string Tengiangvien { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Quequan { get; set; }
        public string Email { get; set; }
        public string Sodienthoai { get; set; }
        public byte[] Photo { get; set; }
        public string Photoname { get; set; }
        public ClassGiangvien() { }
        public ClassGiangvien(int _magiangvien, string _ten_giangvien, DateTime _ngaysinh, string _gioitinh, string _quequan, string _email, string _sodienthoai, byte[] _photo, string _photoname)
        {
            this.Magiangvien = _magiangvien;
            this.Tengiangvien = _ten_giangvien;
            this.Ngaysinh = _ngaysinh;
            this.Gioitinh = _gioitinh;
            this.Quequan = _quequan;
            this.Email = _email;
            this.Sodienthoai = _sodienthoai;
            this.Photo = _photo;
            this.Photoname = _photoname;
        }
/*        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Sinhvien");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllSinhvien", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable timkiemSinhvien(string sql)
        {
            SqlConnection conn = dbc.Connect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool Suasinhvien()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateSinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tensinhvien", this.Tensinhvien);
                cmd.Parameters.AddWithValue("@Ngaysinh", this.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", this.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", this.Quequan);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", this.Sodienthoai);
                cmd.Parameters.AddWithValue("@Photo", this.Photo);
                cmd.Parameters.AddWithValue("@Photoname", this.Photoname);
                cmd.Parameters.AddWithValue("@Masinhvien", this.Masinhvien);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Themsinhvien()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddSinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", this.Masinhvien);
                cmd.Parameters.AddWithValue("@Tensinhvien", this.Tensinhvien);
                cmd.Parameters.AddWithValue("@Ngaysinh", this.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", this.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", this.Quequan);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", this.Sodienthoai);
                cmd.Parameters.AddWithValue("@Photo", this.Photo);
                cmd.Parameters.AddWithValue("@Photoname", this.Photoname);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Xoasinhvien()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DeleteSinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", this.Masinhvien);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }*/
        public DataTable LoadData()
        {
            throw new NotImplementedException();
        }

        public bool Suagiangvien()
        {
            throw new NotImplementedException();
        }

        public bool Themgiangvien()
        {
            throw new NotImplementedException();
        }

        public bool Xoagiangvien()
        {
            throw new NotImplementedException();
        }
    }
}
