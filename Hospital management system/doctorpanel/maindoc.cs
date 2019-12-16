using Hospital_management_system.adminpanelthing;
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
    public partial class maindoc : Form
    {
        public maindoc()
        {
            InitializeComponent();
        }

        public void create(Form myForm)
        {
            if (this.panelcontainer.Controls.Count > 0)
            {
                this.panelcontainer.Controls.RemoveAt(0);
            }

            //Form2 myForm = new Form2();
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            //  myForm.AutoScroll = true;
            this.panelcontainer.Controls.Add(myForm);
            this.panelcontainer.Tag = myForm;

            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        

        private void channeldetails_Click(object sender, EventArgs e)
        {
            ChannelDeatails CD = new ChannelDeatails();
            create(CD);
        }

        private void panelcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnworking_Click(object sender, EventArgs e)
        {
            workingdays wd = new workingdays();
            create(wd);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            DoctorDashbord dd = new DoctorDashbord();
            create(dd);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            lastlog last = new lastlog();

            last.insertlastlog(DateTime.Now, loggingform.email);

            loggingform log = new loggingform();
            log.Show();
            this.Close();
        }

        private void btnpatientrec_Click(object sender, EventArgs e)
        {
            patientrecfordoctor pdoc = new patientrecfordoctor();

            create(pdoc);

        }
    }
}
