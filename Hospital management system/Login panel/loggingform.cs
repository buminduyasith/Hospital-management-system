using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Hospital_management_system.database;
using Hospital_management_system.doctorpanel;
using Hospital_management_system.password_change;

namespace Hospital_management_system.Login_panel
{
    public partial class loggingform : Form
    {

        public static string name;
        public static string nid;
       // public static string recepid;
        public static string email;
        public static DateTime lastdateis;
        public static string uniquid;
        public static string pwd;

        connectionstring constr = new connectionstring();
        public loggingform()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = constr.getconnection();

            con.Open();

            string query = "select pwdchange,userrole from userlogins where email = @email AND password = @pwd";

            SqlCommand com = new SqlCommand(query, con);

            com.Parameters.AddWithValue("@email", txtemail.Text);
            com.Parameters.AddWithValue("@pwd", txtpassword.Text);

           
            DataTable dt = new DataTable();

            //SqlDataReader reader = com.ExecuteReader();
            string userrole=string.Empty;
           
                using (SqlDataReader Reader = com.ExecuteReader())
                {


                try
                {
                    while (Reader.Read())
                    {
                        userrole = Reader["userrole"].ToString();
                       



                    }

                    if(userrole == "")
                    {
                        MessageBox.Show("PASSWORD OR EMAIL INCORRECTED");     
                    }

                    if (userrole == "recep")
                    {
                        getinformrecep();
                        if (pwdchange.checkaccountdefaultpwdchange() == 0)
                        {
                            pwdchangeview pcv = new pwdchangeview();
                            pcv.Show();
                            
                            return;
                        }

                        lastlog lg = new lastlog();
                        lastdateis = lg.getlastlog(txtemail.Text);
                       

                        Form1 f = new Form1();
                        
                        f.Show();
                        
                    }

                    else if(userrole== "doctor")
                    {
                        getinfodoctors();
                        if (pwdchange.checkaccountdefaultpwdchange() == 0)
                        {
                            pwdchangeview pcv = new pwdchangeview();
                            pcv.Show();
                            this.Close();
                            return;
                        }
                       
                       lastlog lg = new lastlog();
                        lastdateis = lg.getlastlog(txtemail.Text);
                       
                        maindoc doc = new maindoc();
                        doc.Show();
                        
                    }

                    else if (userrole == "admin")
                    {
                        getinfoadmin();

                        if (pwdchange.checkaccountdefaultpwdchange() == 0)
                        {
                            pwdchangeview pcv = new pwdchangeview();
                            pcv.Show();
                            //this.Close();
                            return;
                        }
                        AdminPanel adminf = new AdminPanel();
                        lastlog lg = new lastlog();
                        lastdateis = lg.getlastlog(txtemail.Text);
                      

                        adminf.Show();
                       
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                


                com.Dispose();
                con.Close();
                }
            
          

            /*
            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("hi");
                while (reader.Read())
                {

                    string output = reader.GetValue(0).ToString();

                }
                

            }*/

            /*
            while (reader.Read())
            {
                string name = reader.GetValue(0).ToString();
                MessageBox.Show(name);
            }*/


            /*
            if (dt.Rows.Count > 0)
            {
                while (reader.Read())
                {
                    string role = reader["userrole"].ToString();
                    MessageBox.Show(role);
               }
               
             
            }

            else
            {

            }
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();

            admin.Show();
        }

        private void loggingform_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtemail;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = txtpassword;
            }

            if(e.KeyChar == (char)Keys.VolumeDown)
            {
                this.ActiveControl = txtpassword;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                this.ActiveControl = txtemail;
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                this.ActiveControl = txtpassword;
                return true;
            }
            //capture left arrow key
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = btnlog;
            }

            
        }

        public void getinformrecep()
        {
            using(SqlConnection con = constr.getconnection())
            {
                con.Open();

                string sqlquery = @"SELECT receptionist.recepid,fname,lname,receptionist.email,
               receptionist.nid FROM receptionist INNER JOIN userlogins ON receptionist.recepid = userlogins.recepid where userlogins.email = '"+txtemail.Text+"'";

                using(SqlCommand com = new SqlCommand(sqlquery, con))
                {
                    //com.Parameters.AddWithValue("mail", txtemail.Text);

                    SqlDataReader reader1 = com.ExecuteReader();
                    
                        while (reader1.Read())
                        {
                        uniquid = reader1.GetString(0);
                            name  = reader1.GetString(1) + " " + reader1.GetString(2);

                            email = reader1.GetString(3);
                            nid = reader1.GetString(4);
                           



                        }


                  
                }
            }
        }

        public void getinfoadmin()
        {
            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string sqlquery = @"SELECT admins.adminid,fname,lname,admins.email,
               admins.nid FROM admins INNER JOIN userlogins ON admins.adminid = userlogins.adminid where userlogins.email = '" + txtemail.Text + "'";

                using (SqlCommand com = new SqlCommand(sqlquery, con))
                {
                    //com.Parameters.AddWithValue("mail", txtemail.Text);

                    SqlDataReader reader1 = com.ExecuteReader();

                    while (reader1.Read())
                    {
                        uniquid = reader1.GetString(0);
                        name = reader1.GetString(1) + " " + reader1.GetString(2);

                        email = reader1.GetString(3);
                        nid = reader1.GetString(4);




                    }

                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maindoc m = new maindoc();
            
            m.Show();

            
        }

        public void getinfodoctors()
        {
            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string sqlquery = @"SELECT doctor.docid,fname,lname,doctor.email,
               doctor.dnid FROM doctor INNER JOIN userlogins ON doctor.docid = userlogins.docid where userlogins.email = '" + txtemail.Text + "'";

                using (SqlCommand com = new SqlCommand(sqlquery, con))
                {
                    //com.Parameters.AddWithValue("mail", txtemail.Text);

                    SqlDataReader reader1 = com.ExecuteReader();

                    while (reader1.Read())
                    {
                        uniquid = reader1.GetString(0);
                        name = reader1.GetString(1) + " " + reader1.GetString(2);

                        email = reader1.GetString(3);
                        nid = reader1.GetString(4);




                    }

                  

                }
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            pwd = txtpassword.Text;
        }
    }
}
