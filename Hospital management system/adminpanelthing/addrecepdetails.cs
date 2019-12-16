using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system.adminpanelthing
{
    public partial class addrecepdetails : Form
    {
        public addrecepdetails()
        {
            InitializeComponent();
            txtname.Enabled = false;
            txtemail.Enabled = false;
            txtrecepid.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void addrecepdetails_Load(object sender, EventArgs e)
        {

            txtemail.Text = receptionreg.emailadress;
            txtname.Text = receptionreg.fullname; 


        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
