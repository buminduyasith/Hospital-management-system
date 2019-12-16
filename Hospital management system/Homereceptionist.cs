using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_management_system.Login_panel;

namespace Hospital_management_system
{
    public partial class Homereceptionist : UserControl
    {
      
        public Homereceptionist()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
         
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label3.Text = DateTime.Now.ToString("dddd");
        }

        private void Homereceptionist_Load(object sender, EventArgs e)
        {
            timer1.Start();

            txtname.Text = loggingform.name;
            txtrecepid.Text = loggingform.uniquid;
            txtnid.Text = loggingform.nid;
            txtmail.Text = loggingform.email;
            txtlogindate.Text = loggingform.lastdateis.ToString();

        }

        private void lbllogdate_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
