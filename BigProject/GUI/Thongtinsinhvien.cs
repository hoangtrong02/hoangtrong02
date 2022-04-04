using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject.GUI
{
    public partial class Thongtinsinhvien : Form
    {
        DAL.ConvertImageToByteArray itb = new DAL.ConvertImageToByteArray();
        DAL.ConvertByteArrayToImage bti = new DAL.ConvertByteArrayToImage();
        public Thongtinsinhvien()
        {
            InitializeComponent();
        }

        bool checkdata()
        {
            if (pictureBox_sinhvien.Image == null)
            {
                MessageBox.Show("Bạn chưa chọn ảnh", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtmasinhvien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasinhvien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txthoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtquequan.Text))
            {
                MessageBox.Show("Bạn chưa nhập quê quán", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquequan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Bạn chưa nhập email", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsodienthoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", " Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsodienthoai.Focus();
                return false;
            }
            return true;
        }

        private void Thongtinsinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSinhVienDataSet1.Sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter1.Fill(this.qLSinhVienDataSet1.Sinhvien);
            DAL.ClassSinhvien dsv = new DAL.ClassSinhvien();
            dataGridView_sinhvien.DataSource =  dsv.LoadData();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView_sinhvien.Columns[8];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                DAL.ClassSinhvien dsv = new DAL.ClassSinhvien(comboBox_malop.Text, int.Parse(txtmasinhvien.Text), txthoten.Text, DateTime.Parse(dateTimePicker_ngaysinh.Text), comboBox_gioitinh.Text, txtquequan.Text, txtemail.Text, txtsodienthoai.Text, itb.ImageToByteArray(pictureBox_sinhvien.Image));
                if (dsv.Themsinhvien())
                {
                    Thongtinsinhvien_Load(sender, e);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DAL.ClassSinhvien dsv = new DAL.ClassSinhvien(comboBox_malop.Text, int.Parse(txtmasinhvien.Text), txthoten.Text, DateTime.Parse(dateTimePicker_ngaysinh.Text), comboBox_gioitinh.Text, txtquequan.Text, txtemail.Text, txtsodienthoai.Text, itb.ImageToByteArray(pictureBox_sinhvien.Image));
            if (dsv.Suasinhvien())
            {
                Thongtinsinhvien_Load(sender, e);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo");
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thông tin?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                DAL.ClassSinhvien dsv = new DAL.ClassSinhvien(comboBox_malop.Text, int.Parse(txtmasinhvien.Text), txthoten.Text, DateTime.Parse(dateTimePicker_ngaysinh.Text), comboBox_gioitinh.Text, txtquequan.Text, txtemail.Text, txtsodienthoai.Text, itb.ImageToByteArray(pictureBox_sinhvien.Image));
                if (dsv.Xoasinhvien())
                {
                    Thongtinsinhvien_Load(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void btnchonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_sinhvien.Image = Image.FromFile(opf.FileName);
            }
        }

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {
            DAL.ClassSinhvien dsv = new DAL.ClassSinhvien();
            if (txttimkiem.Text == "")
                Thongtinsinhvien_Load(sender, e);
            else
                dataGridView_sinhvien.DataSource = dsv.timkiemSinhvien(txttimkiem.Text);
        }

        private void dataGridView_sinhvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                comboBox_malop.Text = dataGridView_sinhvien.Rows[index].Cells[0].Value.ToString();
                txtmasinhvien.Text = dataGridView_sinhvien.Rows[index].Cells[1].Value.ToString();
                txthoten.Text = dataGridView_sinhvien.Rows[index].Cells[2].Value.ToString();
                dateTimePicker_ngaysinh.Text = dataGridView_sinhvien.Rows[index].Cells[3].Value.ToString();
                comboBox_gioitinh.Text = dataGridView_sinhvien.Rows[index].Cells[4].Value.ToString();
                txtquequan.Text = dataGridView_sinhvien.Rows[index].Cells[5].Value.ToString();
                txtemail.Text = dataGridView_sinhvien.Rows[index].Cells[6].Value.ToString();
                txtsodienthoai.Text = dataGridView_sinhvien.Rows[index].Cells[7].Value.ToString();
                pictureBox_sinhvien.Image = bti.ByteArrayToImage((byte[])dataGridView_sinhvien.Rows[index].Cells[8].Value);
            }
        }

        private void comboBox_timkiemMalop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
