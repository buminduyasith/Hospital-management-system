
using Hospital_management_system.Login_panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system.doctorpanel
{
    public partial class DoctorDashbord : Form
    {
        public DoctorDashbord()
        {
            InitializeComponent();
        }

     

        private void DoctorDashbord_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbldate.Text = DateTime.Now.ToLongDateString();

            txtname.Text = loggingform.name;
            txtrecepid.Text = loggingform.uniquid;
            txtnid.Text = loggingform.nid;
            txtmail.Text = loggingform.email;
            txtlogindate.Text = loggingform.lastdateis.ToString();

            registered_patient_count rpc = new registered_patient_count();

            lblpcount.Text = rpc.getcount().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
