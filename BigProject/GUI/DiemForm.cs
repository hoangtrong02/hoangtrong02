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
    public partial class DiemForm : Form
    {
        public DiemForm()
        {
            InitializeComponent();
        }

        private void DiemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSinhVienDataSet_Diem.Diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter.Fill(this.qLSinhVienDataSet_Diem.Diem);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }
    }
}
