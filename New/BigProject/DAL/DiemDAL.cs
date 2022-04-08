using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class DiemDAL : Interface.InterfaceDiem
    {
        DAL.DBConnectionSQL dbc = new DBConnectionSQL();
        SqlCommand cmd;
        public int Masinhvien { get; set; }
        public string Tenhocphan { get; set; }
        public float Diemchuyencan { get; set; }
        public float Diemgiuaky { get; set; }
        public float Diemcuoiky { get; set; }
        public DiemDAL() { }
        public DiemDAL(int _masinhvien,string _tenhocphan,float _diemchuyencan, float _diemgiuaky, float _diemcuoiky)
        {
            this.Masinhvien = _masinhvien;
            this.Tenhocphan = _tenhocphan;
            this.Diemchuyencan = _diemchuyencan;
            this.Diemgiuaky = _diemgiuaky;
            this.Diemcuoiky = _diemcuoiky;
        }
        public DataTable LoadData()
        {
            DataTable dt = new DataTable("Diem");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("Exec sp_AllDiem ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable timkiemDiemSV(string timkiem)
        {
            DataTable dt = new DataTable("DiemSv");
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                cmd = new SqlCommand("sp_SearchDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", timkiem);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public bool Suadiem()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_UpdateDiem ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", this.Masinhvien);
                cmd.Parameters.AddWithValue("@Tenhocphan", this.Tenhocphan);
                cmd.Parameters.AddWithValue("@Diemchuyencan", this.Diemchuyencan);
                cmd.Parameters.AddWithValue("@Diemgiuaky", this.Diemgiuaky);
                cmd.Parameters.AddWithValue("@Diemcuoiky", this.Diemcuoiky);
                cmd.Parameters.AddWithValue("@Thangdiem10", this.Thangdiem10());
                cmd.Parameters.AddWithValue("@Thangdiem4", this.Thangdiem4());
                cmd.Parameters.AddWithValue("@Thangdiemchu", this.Thangdiemchu());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public float Thangdiem10()
        {
            return (float)(this.Diemchuyencan * 0.1 + this.Diemgiuaky * 0.2 + this.Diemcuoiky * 0.7);
        }

        public float Thangdiem4()
        {
            return (float)(Thangdiem10() * 0.4);
        }

        public string Thangdiemchu()
        {
            string diemchu;
            if (Thangdiem10() < 4)
                diemchu = "F";
            else if (Thangdiem10() >= 4 && Thangdiem10() < 5)
                diemchu = "D";
            else if (Thangdiem10() >= 5 && Thangdiem10() < 6f)
                diemchu = "D+";
            else if (Thangdiem10() >= 6 && Thangdiem10() < 6.5f)
                diemchu = "C";
            else if (Thangdiem10() >= 6.5f && Thangdiem10() < 7)
                diemchu = "C+";
            else if (Thangdiem10() >= 7 && Thangdiem10() < 8)
                diemchu = "B";
            else if (Thangdiem10() >= 8 && Thangdiem10() < 8.5f)
                diemchu = "B+";
            else if (Thangdiem10() >= 8.5f && Thangdiem10() < 9)
                diemchu = "A";
            else 
                diemchu = "A+";
            return diemchu;
        }

        public bool Themdiem()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_AddDiem ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Masinhvien", this.Masinhvien);
                cmd.Parameters.AddWithValue("@Tenhocphan", this.Tenhocphan);
                cmd.Parameters.AddWithValue("@Diemchuyencan", this.Diemchuyencan);
                cmd.Parameters.AddWithValue("@Diemgiuaky", this.Diemgiuaky);
                cmd.Parameters.AddWithValue("@Diemcuoiky", this.Diemcuoiky);
                cmd.Parameters.AddWithValue("@Thangdiem10", this.Thangdiem10());
                cmd.Parameters.AddWithValue("@Thangdiem4", this.Thangdiem4());
                cmd.Parameters.AddWithValue("@Thangdiemchu", this.Thangdiemchu());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Xoadiem()
        {
            SqlConnection conn = dbc.Connect();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DeleteDiem ", conn);
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
