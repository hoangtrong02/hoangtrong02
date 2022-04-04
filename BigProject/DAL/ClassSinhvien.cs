using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class ClassSinhvien : InterfaceSinhvien
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        public string Malop { get; set; }
        public int Masinhvien { get; set; }
        public string Tensinhvien { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Quequan { get; set; }
        public string Email { get; set; }
        public string Sodienthoai { get; set; }
        public byte[] Picture { get; set; }
        public ClassSinhvien() { }
        public ClassSinhvien(string _malop,int _masinhvien, string _tensinhvien, DateTime _ngaysinh, string _gioitinh, string _quequan, string _email, string _sodienthoai, byte[] _picture)
        {
            this.Malop = _malop;
            this.Masinhvien = _masinhvien;
            this.Tensinhvien = _tensinhvien;
            this.Ngaysinh = _ngaysinh;
            this.Gioitinh = _gioitinh;
            this.Quequan = _quequan;
            this.Email = _email;
            this.Sodienthoai = _sodienthoai;
            this.Picture = _picture;
        }
        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Sinhvien");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllSinhvien ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable timkiemSinhvien(string ID)
        {
            DataTable dt = new DataTable("Sinhvien");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("SELECT* FROM Sinhvien WHERE Masinhvien = " + ID, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public bool Suasinhvien()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateSinhvien ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", this.Malop);
                cmd.Parameters.AddWithValue("@Tensinhvien", this.Tensinhvien);
                cmd.Parameters.AddWithValue("@Ngaysinh", this.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", this.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", this.Quequan);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", this.Sodienthoai);
                cmd.Parameters.AddWithValue("@Picture", this.Picture);
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
                cmd.Parameters.AddWithValue("@Malop", this.Malop);
                cmd.Parameters.AddWithValue("@Masinhvien", this.Masinhvien);
                cmd.Parameters.AddWithValue("@Tensinhvien", this.Tensinhvien);
                cmd.Parameters.AddWithValue("@Ngaysinh", this.Ngaysinh);
                cmd.Parameters.AddWithValue("@Gioitinh", this.Gioitinh);
                cmd.Parameters.AddWithValue("@Quequan", this.Quequan);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Sodienthoai", this.Sodienthoai);
                cmd.Parameters.AddWithValue("@Picture", this.Picture);
                
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
        }
    }
}
