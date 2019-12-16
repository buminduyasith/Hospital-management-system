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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Net.Http;

namespace Hospital_management_system.adminpanelthing
{
    public partial class receptionreg : UserControl
    {

        connectionstring constr = new connectionstring();

        public static string emailadress { set; get; }
        public static string fullname { set; get; }
        public static string recepid { set; get; }

        public receptionreg()
        {
            InitializeComponent();
        }

        private void txtdocid_TextChanged(object sender, EventArgs e)
        {

        }

        private void receptionreg_Load(object sender, EventArgs e)
        {
            setpasscode();
            autogenid();
            recepid = txtrecepid.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            lblstatus.Show();
            Application.DoEvents();

            dbinsert();

            lblstatus.Visible = false;


            addrecepdetails recep = new addrecepdetails();

            recep.ShowDialog();
        }


        public void dbinsert()
        {
            try
            {
               
                
                SqlConnection con = constr.getconnection();
                con.Open();

                string sqlquery = "insert into receptionist values(@recepid,@honor,@fname,@lname,@dob,@age,@gender,@nid" +
                    ",@phonenum,@email);" +
                    " insert into userlogins(email,password,nid,userrole,pwdchange,recepid) values(@email,@pwd,@nid,@userrole,@pwdchange,@recepid)";

                string gender = string.Empty;

                if (rbmale.Checked == true)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }


               
                int pwdchange = 0;

                string ur = "recep";

                SqlCommand com = new SqlCommand(sqlquery, con);

                com.Parameters.AddWithValue("@honor", comboBox1.Text);
                com.Parameters.AddWithValue("@fname", txtfn.Text);
                com.Parameters.AddWithValue("@lname", txtln.Text);
                com.Parameters.AddWithValue("@dob", dob.Value);
                com.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                com.Parameters.AddWithValue("@gender",gender);

                com.Parameters.AddWithValue("@nid", txtnid.Text);
                com.Parameters.AddWithValue("@phonenum", txtphonenum.Text);
                com.Parameters.AddWithValue("@email", txtemail.Text);
                com.Parameters.AddWithValue("@recepid", txtrecepid.Text);
                com.Parameters.AddWithValue("@pwd", txtpwd.Text);
                com.Parameters.AddWithValue("@userrole", ur);
                com.Parameters.AddWithValue("@pwdchange", pwdchange);















                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = com;

                adapter.InsertCommand.ExecuteNonQuery();

                com.Dispose();
                con.Close();

                emailadress = txtemail.Text;
                fullname = txtfn.Text + " " + txtln.Text;
                sendmail();
                
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("there is already someone regitered with this nid");
                    return;
                    
                }
                throw;
                
               // MessageBox.Show("db error);
            }

            catch(FormatException)
            {
                MessageBox.Show("INVALID INPUTS");
                return;
            }
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
            txtrecepid.Text = "RECEP -" + currentyear + "- " + currentdate + " -" + currentmonth + "-" + time;


        }


        public void setpasscode()
        {
            Random rand = new Random();

            txtpwd.Text = rand.Next(1000, 9999).ToString();
        }

        public void sendmail()
        {
            try
            {
                var fromAddress = new MailAddress("noreplyclinicrecords@gmail.com", "Noreply");
                var toAddress = new MailAddress(txtemail.Text, "bumidu");
                const string fromPassword = "98clinicrec*/";
                const string subject = "Account Created ";
                //  const string body = "Hey now!!";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
                var message = new MailMessage(fromAddress, toAddress);
                /*'string htmlString = @"
                      <p>Dear Ms. Susan,</p>
                      <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
                              I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
                      <p>Sincerely,<br>-Jack</br></p>
                      </body>
                      </html>
                     ";*/

                string head = @"<h1>welcome to our system</h1>

                            <hr><br><p>Please use this passcode when you logging to you account</P>
                             <br><h4>you logging deatils</h4>";





                string htmls1 = "you name " + txtfn.Text
                    + " you passcode is " + txtpwd.Text;

                string output = head + htmls1;


                //  string body1 = System.IO.File.ReadAllText(@"C:\Users\Bumindu\source\repos\mailling\mailling\yo.htm");
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = output;//body1;
                smtp.Send(message);
            }
            catch (Exception)
            {

                return;
            }
            

        }

        
    }
}
