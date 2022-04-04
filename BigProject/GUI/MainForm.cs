using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelcntt.Visible = false;
            panelqtkd.Visible = false;
            panelketoan.Visible = false;
        }
        private void hideMenu()
        {
            if (panelcntt.Visible == true)
                panelcntt.Visible = false;
            if (panelqtkd.Visible == true)
                panelqtkd.Visible = false;
            if (panelketoan.Visible == true)
                panelketoan.Visible = false;
        }
        private void showMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }
        private void btncntt_Click(object sender, EventArgs e)
        {
            showMenu(panelcntt);
        }
        private Form activeForm = null;
        private void openForm(Form frm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelfocus.Controls.Add(frm);
            panelfocus.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
        private void btnttsvcntt_Click(object sender, EventArgs e)
        {
            openForm(new GUI.Thongtinsinhvien());
        }

        private void btndiemcntt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnkhoaqtkd_Click(object sender, EventArgs e)
        {
            showMenu(panelqtkd);
        }

        private void btnthongtinqtkd_Click(object sender, EventArgs e)
        {
            
        }

        private void btndiemqtkd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnkhoaketoan_Click(object sender, EventArgs e)
        {
            showMenu(panelketoan);
        }

        private void btnthongtinketoan_Click(object sender, EventArgs e)
        {
            
        }

        private void btndiemketoan_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
