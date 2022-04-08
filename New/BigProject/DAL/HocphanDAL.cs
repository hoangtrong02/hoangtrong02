using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class HocphanDAL : Interface.InterfaceHocphan
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        public string Mahocphan { get; set; }
        public string Tenhocphan { get; set; }
        public int Sotinchi { get; set; }
        public HocphanDAL() { }
        public HocphanDAL(string _mahocphan, string _tenhocphan, int _sotinchi)
        {
            this.Mahocphan = _mahocphan;
            this.Tenhocphan = _tenhocphan;
            this.Sotinchi = _sotinchi;
        }
        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Hocphan");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllHocphan ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }

        public bool SuaHocphan()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateHocphan ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mahocphan", this.Mahocphan);
                cmd.Parameters.AddWithValue("@Tenhocphan", this.Tenhocphan);
                cmd.Parameters.AddWithValue("@Sotinchi", this.Sotinchi);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemHocphan()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddHocphan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mahocphan", this.Mahocphan);
                cmd.Parameters.AddWithValue("@Tenhocphan", this.Tenhocphan);
                cmd.Parameters.AddWithValue("@Sotinchi", this.Sotinchi);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaHocphan()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DeleteHocphan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mahocphan", this.Mahocphan);
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
