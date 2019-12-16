using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class AdminPanel : Form
    {
        bool isopened = false;
        public AdminPanel()
        {
            InitializeComponent();
        }

      

        private void btnrecepreg_Click(object sender, EventArgs e)
        {
            receptionreg1.Show();
            receptionreg1.BringToFront();
        }

        private void btnpatientdetails_Click(object sender, EventArgs e)
        {
            patientdetails1.Show();
            patientdetails1.BringToFront();
        }

        private void docreg1_Load(object sender, EventArgs e)
        {

        }

        private void btndocreg_Click(object sender, EventArgs e)
        {
            docreg1.Show();
            docreg1.BringToFront();
        }

        private void adminreg_Click(object sender, EventArgs e)
        {
            adminreg1.Show();
            adminreg1.BringToFront();
        }

        private void receptionreg1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnslideout_Click(object sender, EventArgs e)
        {
            if (!isopened)
            {
                panel1.Width = 250;

                isopened = true;

                btnslideout.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isopened)
            {
                panel1.Width = 50;

                isopened = false;

                btnslideout.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminhome1.BringToFront();
            adminhome1.Show();
        }
    }
}
