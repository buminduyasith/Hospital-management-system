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
using System.Data.SqlClient;
using Hospital_management_system.database;
using System.Threading;

namespace Hospital_management_system.password_change
{
    public partial class pwdchangeview : Form
    {
        connectionstring constr = new connectionstring();
        public pwdchangeview()
        {
            InitializeComponent();
        }

        private void pwdchangeview_Load(object sender, EventArgs e)
        {
            txtname.Text = loggingform.name;
            txtid.Text = loggingform.uniquid;
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = constr.getconnection())
            {
                con.Open();

                string query = "UPDATE userlogins SET pwdchange = @pwdS , password = @pwd  WHERE email = @mail ";

                using(SqlCommand com = new SqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@pwd", txtcnp.Text);
                    com.Parameters.AddWithValue("@pwds", 1);
                    com.Parameters.AddWithValue("mail", loggingform.email);


                    SqlDataAdapter adapter = new SqlDataAdapter();

                    if (!checkpwd())
                    {
                        return;
                    }

                    adapter.UpdateCommand = com;
                    adapter.UpdateCommand.ExecuteNonQuery();

                    MessageBox.Show("password changed");

                    Thread.Sleep(500);

                    loggingform f = new loggingform();
                    f.Show();
                    this.Close();

                    
                }
            }
        }


        private bool checkpwd()
        {
            if(loggingform.pwd != txtcp.Text)
            {

                return false;
            }
            if (txtnp.Text != txtcnp.Text)
            {
                return false;
            }

            return true;
        }
    }
}
