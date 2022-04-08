using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject.GUI
{
    public partial class FormHocphan : Form
    {
        public FormHocphan()
        {
            InitializeComponent();
        }
        bool checkData()
        {
            if (string.IsNullOrEmpty(txtmahocphan.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học phần", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahocphan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txttenhocphan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên học phần", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenhocphan.Focus();
                return false;
            }
            return true;
        }
        private void FormHocphan_Load(object sender, EventArgs e)
        {
            DAL.HocphanDAL dhp = new DAL.HocphanDAL();
            dataGridView_hocphan.DataSource = dhp.LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                DAL.HocphanDAL dhp = new DAL.HocphanDAL(txtmahocphan.Text, txttenhocphan.Text,int.Parse(comboBox_sotinchi.Text));
                if (dhp.ThemHocphan())
                {
                    FormHocphan_Load(sender, e);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DAL.HocphanDAL dhp = new DAL.HocphanDAL(txtmahocphan.Text, txttenhocphan.Text, int.Parse(comboBox_sotinchi.Text));
            if (dhp.SuaHocphan())
            {
                FormHocphan_Load(sender, e);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thông tin?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DAL.HocphanDAL dhp = new DAL.HocphanDAL(txtmahocphan.Text, txttenhocphan.Text, int.Parse(comboBox_sotinchi.Text));
                if (dhp.XoaHocphan())
                {
                    FormHocphan_Load(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void dataGridView_hocphan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmahocphan.Text = dataGridView_hocphan.Rows[index].Cells[0].Value.ToString();
                txttenhocphan.Text = dataGridView_hocphan.Rows[index].Cells[1].Value.ToString();
                comboBox_sotinchi.Text = dataGridView_hocphan.Rows[index].Cells[2].Value.ToString();
            }
        }
    }
}
