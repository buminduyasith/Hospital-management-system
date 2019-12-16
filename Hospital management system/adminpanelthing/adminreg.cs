using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Hospital_management_system.database;

namespace Hospital_management_system.adminpanelthing
{
    
    public partial class adminreg : UserControl
    {
        connectionstring constr = new connectionstring();
        public string gender { set; get; }
        public string adminid { set; get; }

        public string honorific { set; get; }


        public adminreg()
        {
            InitializeComponent();
        }

        private void adminreg_Load(object sender, EventArgs e)
        {
            autogenid();
            setpasscode();
        }

        public void dbinsert()
        {
           using(SqlConnection con = constr.getconnection())
            {
                con.Open();

                string sqlquery = "insert into admins values(@adminid,@honor,@fname,@lname,@dob,@age,@gender,@nid" +
                    ",@phonenum,@email);" +
                    " insert into userlogins(email,password,nid,userrole,pwdchange,adminid) values(@email,@pwd,@nid,@userrole,@pwdchange,@adminid)";

                using (SqlCommand com = new SqlCommand(sqlquery, con))
                {

                    try
                    {
                        com.Parameters.AddWithValue("@adminid", txtadminid.Text);
                        com.Parameters.AddWithValue("@honor", honorific);
                        com.Parameters.AddWithValue("@fname", txtfn.Text);
                        com.Parameters.AddWithValue("@lname", txtln.Text);
                    
                        com.Parameters.AddWithValue("@gender", gender);

                        // com.Parameters.AddWithValue("@gender", gender);
                        com.Parameters.AddWithValue("@dob", dobadmin.Value);
                        com.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                        com.Parameters.AddWithValue("@nid", txtnid.Text);
                        com.Parameters.AddWithValue("@phonenum", txtphonenum.Text);
                        com.Parameters.AddWithValue("@email", txtemail.Text);
                        com.Parameters.AddWithValue("@pwd", txtpwd.Text);
                        com.Parameters.AddWithValue("@userrole", "admin");
                        com.Parameters.AddWithValue("@pwdchange", 0);

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.InsertCommand = com;
                        adapter.InsertCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }



                }
            }
        }


        public void setpasscode()
        {
            Random rand = new Random();

            txtpwd.Text = rand.Next(1000, 9999).ToString();
        }

        public void autogenid()
        {
            int currentyear = DateTime.Now.Year;
            int currentdate = DateTime.Now.Day;
            int currentmonth = DateTime.Now.Month;
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            string time = h + "" + m + "" + s;
            txtadminid.Text = "Admin -" + currentyear + "- " + currentdate + " -" + currentmonth + "-" + time;


        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";




        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            honorific = comboBox1.Text;

            if (comboBox1.SelectedIndex == 0)
            {
                rbmale.Checked = true;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                rbfemale.Checked = true;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                rbfemale.Checked = true;
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            dbinsert();
            MessageBox.Show("444");
        }
    }


}
