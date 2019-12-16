using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using System.Threading;
using Hospital_management_system.Login_panel;

namespace Hospital_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpatientreg_Click(object sender, EventArgs e)
        {
            patientregistration2.BringToFront();
            patientregistration2.Show();

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            homereceptionist1.BringToFront();
            homereceptionist1.Show();
            
        }

        private void btnslidein_Click(object sender, EventArgs e)
        {
            int iFormWidth = 240;

           Transition.run(slideinpanel, "Width", iFormWidth, new TransitionType_EaseInEaseOut(800));
            btnslidein.Hide();
        }

        private void btnslideout_Click(object sender, EventArgs e)
        {

            int iFormWidth = 51;

            Transition.run(slideinpanel, "Width", iFormWidth, new TransitionType_EaseInEaseOut(800));

            Thread.Sleep(150);
            btnslidein.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnslidein.Hide();
        }

        private void homereceptionist1_Load(object sender, EventArgs e)
        {

        }

        private void slideinpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnchanneldoc_Click(object sender, EventArgs e)
        {
            channeldoctorRes1.BringToFront();
            channeldoctorRes1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientdetails_reg1.BringToFront();
            patientdetails_reg1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }

            else
            {
                timer1.Stop();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Panel> ne = new List<Panel>();
            ne.Add(panel1);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            lastlog last = new lastlog();

            last.insertlastlog(DateTime.Now,loggingform.email);
            
            loggingform log = new loggingform();
            log.Show();
            this.Close();

        }

        private void homereceptionist1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
