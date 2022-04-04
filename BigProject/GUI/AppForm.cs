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
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            /*guna2WinProgressIndicator1.Start();*/
            if(start > 30)
            {
                LoginForm lg = new LoginForm();
                /*guna2WinProgressIndicator1.Stop();*/
                timer1.Stop();
                this.Hide();
                lg.ShowDialog();
            }
        }
    }
}
