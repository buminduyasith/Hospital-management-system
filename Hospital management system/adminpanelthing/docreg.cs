using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_management_system.database;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hospital_management_system.adminpanelthing
{
    public partial class docreg : UserControl
    {

        connectionstring constr = new connectionstring();

        string gender;
        string spec;
        public docreg()
        {
            InitializeComponent();
          //  this.AutoValidate = AutoValidate.Disable;

        }

        private void docreg_Load(object sender, EventArgs e)
        {
            setpasscode();
            autogenid();
        }

        private void txtfn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtfn.Text))
            {
                errorProvider1.SetError(txtfn, "empty");
              
                e.Cancel = true;

            }

            else if (txtfn.Text.Length > 10)
            {
                errorProvider1.SetError(txtfn, "minum 10 characters");
                //return;
            }


            else
            {
                foreach (char item in txtfn.Text)
                {
                    if (!char.IsLetter(item))
                    {
                        errorProvider1.SetError(txtfn, "cant have numbers");
                        txtfn.Select(0, txtfn.Text.Length);
                        // return;
                    }



                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savetodb();
            MessageBox.Show("444");
            
        }


        public void savetodb()
        {

            using(SqlConnection con = constr.getconnection())
            {
                con.Open();

                string sqlquery = "insert into doctor values(@docid,@fname,@lname,@spec,@gender,@dob,@age,@nid" +
                   ",@phonenum,@email);"+
                  " insert into userlogins(email,password,nid,userrole,pwdchange,docid) values(@email,@pwd,@nid,@userrole,@pwdchange,@docid)";

                

                using(SqlCommand com =new SqlCommand(sqlquery, con))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@docid", txtdocid.Text);
                        com.Parameters.AddWithValue("@fname", txtfn.Text);
                        com.Parameters.AddWithValue("@lname", txtln.Text);
                        com.Parameters.AddWithValue("@spec", spec);
                        com.Parameters.AddWithValue("@gender", gender);

                        // com.Parameters.AddWithValue("@gender", gender);
                        com.Parameters.AddWithValue("@dob", dob2.Value);
                        com.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                        com.Parameters.AddWithValue("@nid", txtnid.Text);
                        com.Parameters.AddWithValue("@phonenum", txtphonenum.Text);
                        com.Parameters.AddWithValue("@email", txtemail.Text);
                        com.Parameters.AddWithValue("@pwd", txtpwd.Text);
                        com.Parameters.AddWithValue("@userrole", "doctor");
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

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void combospec_SelectedIndexChanged(object sender, EventArgs e)
        {
            spec = combospec.Text;
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
            txtdocid.Text = "DOC -" + currentyear + "- " + currentdate + " -" + currentmonth + "-" + time;

           
        }
    }
}
