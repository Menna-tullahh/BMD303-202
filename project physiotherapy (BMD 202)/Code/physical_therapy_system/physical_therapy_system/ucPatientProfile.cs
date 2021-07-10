using physical_therapy_system.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace physical_therapy_system
{
    public partial class ucPatientProfile : UserControl
    {
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";
        string returnName;
        int returnAge;
        string returnGender;
        string returnNationality;
        string returnFirstLanguage;
        string returnPatientAddress;
        string returnPhoneNumber;
        string returnPhoneNumber2;
        string returnJob;
        string returnEmail;
        string returnNote;
        public static string returnNationalID;
        public static string courseinfo;
        string x;
        string y;

        //public static string listPatientID = ListPatient._message;
        //public string patientName = userControlID.ToString();
        string info ;
        public ucPatientProfile()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucVisits"))
            {
                Form1.Instance.lblTitle.Text = "Patient's Visits";
                ucVisits nu = new ucVisits();
                nu.Dock = DockStyle.Fill;
                Form1.Instance.pnlFormLoader.Controls.Add(nu);
            }
            Form1.Instance.pnlFormLoader.Controls["ucVisits"].BringToFront();
            Form1.Instance.pnlFormLoader.Visible = true;
        }

        private void ucPatientProfile_Load(object sender, EventArgs e)
            {

                if (!String.IsNullOrEmpty(ucAddOldUser.nationalIDField))   
                {

                    using (SqlConnection con = new SqlConnection(connecstionString))
                    {


                        con.Open();


                        SqlCommand com = new SqlCommand("select @patientID = patientID from patient where nationalID = @nationalID;", con);
                        com.Parameters.AddWithValue("@nationalID", ucAddOldUser.nationalIDField);
                        com.Parameters.Add("@patientID", SqlDbType.Int);
                        com.Parameters["@patientID"].Direction = ParameterDirection.Output;

                        com.ExecuteNonQuery();
                        x = com.Parameters["@patientID"].Value.ToString();

                    }

                info = x;
                }
                if (!String.IsNullOrEmpty(ucAddNewUser.nationalID))
                {
                    using (SqlConnection con = new SqlConnection(connecstionString))
                    {


                        con.Open();


                        SqlCommand com = new SqlCommand("select @patientID = patientID from patient where nationalID = @nationalID;", con);
                        com.Parameters.AddWithValue("@nationalID", ucAddNewUser.nationalID);
                        com.Parameters.Add("@patientID", SqlDbType.Int);
                        com.Parameters["@patientID"].Direction = ParameterDirection.Output;

                        com.ExecuteNonQuery();
                         y = com.Parameters["@patientID"].Value.ToString();

                    }
                info = y;

                   }
                if(!String.IsNullOrEmpty(ucPatients.patientinfo))
                {
                    info = ucPatients.patientinfo;

                }

            using (SqlConnection con = new SqlConnection(connecstionString))
                {

                con.Open();
                SqlCommand com = new SqlCommand("patientInfo", con);
                com.CommandType = CommandType.StoredProcedure;

                 com.Parameters.AddWithValue("@patientID", info);
                

                com.Parameters.Add("@patientName", SqlDbType.VarChar, 100);
                com.Parameters["@patientName"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@age", SqlDbType.Int);
                com.Parameters["@age"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@gender", SqlDbType.VarChar, 100);
                com.Parameters["@gender"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@nationality", SqlDbType.VarChar, 100);
                com.Parameters["@nationality"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@firstLanguage", SqlDbType.VarChar, 100);
                com.Parameters["@firstLanguage"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@patientAddress", SqlDbType.VarChar, 100);
                com.Parameters["@patientAddress"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 100);
                com.Parameters["@phoneNumber"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@job", SqlDbType.VarChar, 100);
                com.Parameters["@job"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@email", SqlDbType.VarChar, 100);
                com.Parameters["@email"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@note", SqlDbType.VarChar, 100);
                com.Parameters["@note"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@nationalID", SqlDbType.VarChar, 100);
                com.Parameters["@nationalID"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();


                /* returnName = (string)com.Parameters["@patientName"].Value;
                 returnAge = (int)com.Parameters["@age"].Value ;
                 returnGender = (string)com.Parameters["@gender"].Value;
                 returnNationality = (string)com.Parameters["@nationality"].Value;
                 returnFirstLanguage = (string)com.Parameters["@firstLanguage"].Value;
                 returnPatientAddress = (string)com.Parameters["@patientAddress"].Value;
                 returnPhoneNumber = (string)com.Parameters["@phoneNumber"].Value;
                 returnPhoneNumber2 = (string)com.Parameters["@phoneNumber2"].Value;
                 returnJob = (string)com.Parameters["@job"].Value;
                 returnEmail = (string)com.Parameters["@email"].Value;
                 returnNote = (string)com.Parameters["@note"].Value;
                 returnNationalID = (string)com.Parameters["@nationalID"].Value;*/

                if (com.Parameters["@patientName"].Value == null)
                {
                    returnName = string.Empty;
                }
                else { returnName = (string)com.Parameters["@patientName"].Value; }

                if (DBNull.Value.Equals(com.Parameters["@gender"].Value))
                {
                    returnGender = string.Empty;
                }
                else
                {
                    returnGender = com.Parameters["@gender"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@age"].Value))
                {
                    returnAge = 0;
                }
                else
                {
                    returnAge = (int)com.Parameters["@age"].Value;
                }


                if (DBNull.Value.Equals(com.Parameters["@nationality"].Value))
                {
                    returnNationality = string.Empty;
                }
                else
                {
                    returnNationality = com.Parameters["@nationality"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@firstLanguage"].Value))
                {
                    returnFirstLanguage = string.Empty;
                }
                else
                {
                    returnFirstLanguage = com.Parameters["@firstLanguage"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@patientAddress"].Value))
                {
                    returnPatientAddress = string.Empty;
                }
                else
                {
                    returnPatientAddress = com.Parameters["@patientAddress"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@phoneNumber"].Value))
                {
                    returnPhoneNumber = string.Empty;
                }
                else
                {
                    returnPhoneNumber = com.Parameters["@phoneNumber"].Value.ToString();
                }

   
                if (DBNull.Value.Equals(com.Parameters["@job"].Value))
                {
                    returnJob = string.Empty;
                }
                else
                {
                    returnJob = com.Parameters["@job"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@email"].Value))
                {
                    returnEmail = string.Empty;
                }
                else
                {
                    returnEmail = com.Parameters["@email"].Value.ToString();
                }



                if (DBNull.Value.Equals(com.Parameters["@note"].Value))
                {
                    returnNote = string.Empty;
                }
                else
                {
                    returnNote = com.Parameters["@note"].Value.ToString();
                }



                if (DBNull.Value.Equals(com.Parameters["@nationalID"].Value))
                {
                    returnNationalID = string.Empty;
                }
                else
                {
                    returnNationalID = com.Parameters["@nationalID"].Value.ToString();
                }

            }


            //patientName.Text = returnName;
            name.Text = returnName;
            age.Text = returnAge.ToString();
            job.Text = returnJob;
            phone.Text = returnPhoneNumber;
            email.Text = returnEmail;
            address.Text = returnPatientAddress;
            nationalID.Text = returnNationalID;
            nationality.Text = returnNationality;
            language.Text = returnFirstLanguage;

            populateItems();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {

                con.Open();
                SqlCommand com = new SqlCommand("updateProfile", con);
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@patientID", info);
                com.Parameters.AddWithValue("@patientName", name.Text);
                com.Parameters.AddWithValue("@age", age.Text);
                com.Parameters.AddWithValue("@gender", " ");
                com.Parameters.AddWithValue("@nationality", nationality.Text);
                com.Parameters.AddWithValue("@firstLanguage", language.Text);
                com.Parameters.AddWithValue("@patientAddress", address.Text);
                com.Parameters.AddWithValue("@phoneNumber", phone.Text);
                com.Parameters.AddWithValue("@job", job.Text);
                com.Parameters.AddWithValue("@email", email.Text);
                com.Parameters.AddWithValue("@note", " ");
                com.Parameters.AddWithValue("@NationalID", nationalID.Text);

                com.ExecuteNonQuery();

                try
                {

                    MessageBox.Show("Updated sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // label1.Text = patientName;
        private void populateItems()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = GetItems();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ucVisits[] listitems = new ucVisits[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listitems[i] = new ucVisits();
                            listitems[i].Title = row["title"].ToString();

                            listitems[i].start = row["startDate"].ToString();
                            listitems[i].end = row["endDate"].ToString();
                            listitems[i].Click += (sender, EventArgs) => { Click(sender, EventArgs, row["courseID"].ToString()); };
                           // 
                            //listitems[i].Width= flowLayoutPanel1.Width;
                            //listitems[i].BgColor = Color.Silver;
                            flowLayoutPanel1.Controls.Add(listitems[i]);


                        }
                    }



                }
            }
            void Click(object sender, EventArgs e, string x)
            {
                courseinfo = x;

                if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucVisitDetails"))
                {
                    Form1.Instance.lblTitle.Text = "Course Details";
                    ucVisitDetails nu = new ucVisitDetails();
                    nu.Dock = DockStyle.Fill;
                    Form1.Instance.pnlFormLoader.Controls.Add(nu);
                }
                Form1.Instance.pnlFormLoader.Controls["ucVisitDetails"].BringToFront();
                Form1.Instance.pnlFormLoader.Visible = true;
            }
        }
        public DataTable GetItems()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string query = "select * from course where course_patient_ID =  (select patientID from patient where nationalID = @returnNationalID);";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@returnNationalID", nationalID.Text);

            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }

        }



    }

    
}
