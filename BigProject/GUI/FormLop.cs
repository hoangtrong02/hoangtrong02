using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject.GUI
{
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }
        bool checkData()
        {
            if (string.IsNullOrEmpty(txtmalop.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmalop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txttenlop.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenlop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtnienkhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập niên khóa", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnienkhoa.Focus();
                return false;
            }
            return true;
        }
        public void showcomboBox()
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Malop from Lop", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_timkiemMalop.DataSource = dt;
            }
            catch { }
        }
        private void FormLop_Load(object sender, EventArgs e)
        {
            DAL.ClassLop dl = new DAL.ClassLop();
            dataGridView_lop.DataSource = dl.LoadData();
            this.showcomboBox();
        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (checkData())
            {
                DAL.ClassLop dsv = new DAL.ClassLop(txtmalop.Text, txttenlop.Text, txtnienkhoa.Text);
                if (dsv.ThemLop())
                {
                    FormLop_Load(sender, e);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            DAL.ClassLop dsv = new DAL.ClassLop(txtmalop.Text, txttenlop.Text, txtnienkhoa.Text);
            if (dsv.SuaLop())
            {
                FormLop_Load(sender, e);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thông tin?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DAL.ClassLop dsv = new DAL.ClassLop(txtmalop.Text, txttenlop.Text, txtnienkhoa.Text);
                if (dsv.XoaLop())
                {
                    FormLop_Load(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void comboBox_timkiemMalop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DAL.DBConnectionSQL dbc = new DAL.DBConnectionSQL();
            try
            {
                SqlConnection conn = dbc.Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Malop from Lop", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_timkiemMalop.DataSource = dt;
                conn.Close();
            }
            catch { }
        }

        private void dataGridView_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmalop.Text = dataGridView_lop.Rows[index].Cells[0].Value.ToString();
                txttenlop.Text = dataGridView_lop.Rows[index].Cells[1].Value.ToString();
                txtnienkhoa.Text = dataGridView_lop.Rows[index].Cells[2].Value.ToString();
            }
        }
    }
}
