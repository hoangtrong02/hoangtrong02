using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class LopDAL : Interface.InterfaceLop
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public string Course { get; set; }
        public LopDAL() { }
        public LopDAL(string _malop,string _tenlop, string _course)
        {
            this.Malop = _malop;
            this.Tenlop = _tenlop;
            this.Course = _course;
        }

        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Lop");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllLop ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }

        public bool SuaLop()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateLop ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", this.Malop);
                cmd.Parameters.AddWithValue("@Tenlop", this.Tenlop);
                cmd.Parameters.AddWithValue("@Course", this.Course);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemLop()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", this.Malop);
                cmd.Parameters.AddWithValue("@Tenlop", this.Tenlop);
                cmd.Parameters.AddWithValue("@Course", this.Course);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaLop()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DeleteLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Malop", this.Malop);
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
