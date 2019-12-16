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

namespace Hospital_management_system.adminpanelthing
{
    public partial class adminhome : UserControl
    {
        public adminhome()
        {
            InitializeComponent();
        }

        private void adminhome_Load(object sender, EventArgs e)
        {
            txtname.Text = loggingform.name;
            txtrecepid.Text = loggingform.uniquid;
            txtnid.Text = loggingform.nid;
            txtmail.Text = loggingform.email;
            txtlogindate.Text = loggingform.lastdateis.ToString();
        }
    }
}
