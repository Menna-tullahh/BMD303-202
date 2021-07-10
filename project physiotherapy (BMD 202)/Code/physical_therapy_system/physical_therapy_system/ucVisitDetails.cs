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
    public partial class ucVisitDetails : UserControl
    {
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";
        private int returnsessionsNo;
        private string returnstartDate;
        private string returnendDate;
        private int returntotalMoney;
        private string returntotalDuration;
        private string returndiagnosis;
        private string returnnotes;
        private string returntitle;
        private int returncompletedSessions;
        private int returnfinished;
        private string returnfrequency;
        private string returndoctorName;

        public ucVisitDetails()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void otherToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucVisitDetails_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ucPatientProfile.courseinfo);

            //MessageBox.Show(ucPatientProfile.returnNationalID);
            if (logIn.role == "Secretary")
            {
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;

            }
                    

            using (SqlConnection con = new SqlConnection(connecstionString))
            {

                con.Open();
                SqlCommand com = new SqlCommand("courseInfo", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);

                com.Parameters.Add("@sessionsNo", SqlDbType.Int);
                com.Parameters["@sessionsNo"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@doctorName", SqlDbType.VarChar, 100);
                com.Parameters["@doctorName"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@startDate", SqlDbType.Date);
                com.Parameters["@startDate"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@endDate", SqlDbType.Date);
                com.Parameters["@endDate"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@totalMoney", SqlDbType.Int);
                com.Parameters["@totalMoney"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@totalDuration", SqlDbType.VarChar, 100);
                com.Parameters["@totalDuration"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@diagnosis", SqlDbType.VarChar, 100);
                com.Parameters["@diagnosis"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@frequency", SqlDbType.VarChar, 100);
                com.Parameters["@frequency"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@notes", SqlDbType.VarChar, 100);
                com.Parameters["@notes"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@title", SqlDbType.VarChar, 100);
                com.Parameters["@title"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@completedSessions", SqlDbType.Int);
                com.Parameters["@completedSessions"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@finished", SqlDbType.Int);
                com.Parameters["@finished"].Direction = ParameterDirection.Output;

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


                if (DBNull.Value.Equals(com.Parameters["@sessionsNo"].Value))
                {
                    returnsessionsNo = 0;
                }
                else
                {
                    returnsessionsNo = (int)com.Parameters["@sessionsNo"].Value;
                }

                if (DBNull.Value.Equals(com.Parameters["@doctorName"].Value))
                {
                    returndoctorName = string.Empty;
                }
                else
                {
                    returndoctorName = com.Parameters["@doctorName"].Value.ToString();
                }


                if (DBNull.Value.Equals(com.Parameters["@startDate"].Value))
                {
                    returnstartDate = string.Empty;
                }
                else
                {
                    returnstartDate = com.Parameters["@startDate"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@endDate"].Value))
                {
                    returnendDate = string.Empty;
                }
                else
                {
                    returnendDate = com.Parameters["@endDate"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@totalMoney"].Value))
                {
                    returntotalMoney = 0;
                }
                else
                {
                    returntotalMoney = (int)com.Parameters["@totalMoney"].Value;
                }

                if (DBNull.Value.Equals(com.Parameters["@totalDuration"].Value))
                {
                    returntotalDuration = string.Empty;
                }
                else
                {
                    returntotalDuration = com.Parameters["@totalDuration"].Value.ToString();
                }



                if (DBNull.Value.Equals(com.Parameters["@diagnosis"].Value))
                {
                    returndiagnosis = string.Empty;
                }
                else
                {
                    returndiagnosis = com.Parameters["@diagnosis"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@frequency"].Value))
                {
                    returnfrequency = string.Empty;
                }
                else
                {
                    returnfrequency = com.Parameters["@frequency"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@notes"].Value))
                {
                    returnnotes = string.Empty;
                }
                else
                {
                    returnnotes = com.Parameters["@notes"].Value.ToString();
                }

                if (DBNull.Value.Equals(com.Parameters["@title"].Value))
                {
                    returntitle = string.Empty;
                }
                else
                {
                    returntitle = com.Parameters["@title"].Value.ToString();
                }



                if (DBNull.Value.Equals(com.Parameters["@completedSessions"].Value))
                {
                    returncompletedSessions = 0;
                }
                else
                {
                    returncompletedSessions = (int)com.Parameters["@completedSessions"].Value;
                }


                if (DBNull.Value.Equals(com.Parameters["@finished"].Value))
                {
                    returnfinished = 0;
                }
                else
                {
                    returnfinished = (int)com.Parameters["@finished"].Value;





                }


                //patientName.Text = returnName;
                label2.Text = returntitle;
                if (returnfinished == 0)
                {
                    label11.Text = "Not Finished";
                }
                else if (returnfinished == 1)
                {
                    label11.Text = "Completed";

                }

                if (returnstartDate.Count() == 0)
                {
                    label12.Text = returnstartDate.ToString();
                }
                else
                {
                    label12.Text = returnstartDate.ToString().Substring(0,9);
                }  
                if (returnendDate.Count() == 0)
                {
                    label18.Text = returnendDate.ToString();
                }
                else
                {
                    label18.Text = returnendDate.ToString().Substring(0,9);
                }
                phone.Text = returnsessionsNo.ToString();
                email.Text = returnfrequency;
                label20.Text = returntotalMoney.ToString();
                nationalID.Text = returntotalDuration;
                textBox5.Text = returnnotes;
                label21.Text = "Dr/ "+returndoctorName;
                label19.Text = returncompletedSessions.ToString();

            }
            using (SqlConnection con = new SqlConnection(connecstionString))
            {


                con.Open();
                SqlCommand com = new SqlCommand("select * from equipments; ", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                DataTable table1 = new DataTable();
                da.Fill(table1);



                checkedListBox1.DataSource = table1;
                checkedListBox1.DisplayMember = "equipmentName";
                checkedListBox1.ValueMember = "equipmentID";


                com.ExecuteNonQuery();



                SqlCommand com2 = new SqlCommand("select * from diagnosis; ", con);
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.SelectCommand = com2;
                DataTable table2 = new DataTable();
                da2.Fill(table2);

                checkedListBox2.DataSource = table2;
                checkedListBox2.DisplayMember = "diagnosisName";
                checkedListBox2.ValueMember = "diagnosisName";
                com2.ExecuteNonQuery();



            }
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("select equipmentName from equipments e, course_equipments c where e.equipmentID = c.equipmentID and courseID =@courseID;", con);
                com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                DataTable table1 = new DataTable();
                da.Fill(table1);

                int x=0;

                List<int> list1 = new List<int>();

                foreach (DataRowView item in checkedListBox1.Items)
                {
                   
                    foreach (DataRow i in table1.Rows)
                    {
                        string y = i["equipmentName"].ToString();
                        if (item["equipmentName"].ToString() == y)
                        {
                            list1.Add(x);
                        }
                    }
                    x += 1;
                }

                foreach ( int j in list1)
                {
                    checkedListBox1.SetItemChecked(j, true);
                }

                com.ExecuteNonQuery();
            }

            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("select diagnosisName from diagnosis d, course_diagnosis c where d.diagnosisID = c.diagnosisID and courseID =@courseID;", con);
                com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                DataTable table1 = new DataTable();
                da.Fill(table1);

                int x = 0;

                List<int> list1 = new List<int>();

                foreach (DataRowView item in checkedListBox2.Items)
                {

                    foreach (DataRow i in table1.Rows)
                    {
                        string y = i["diagnosisName"].ToString();
                        if (item["diagnosisName"].ToString() == y)
                        {
                            list1.Add(x);
                        }
                    }
                    x += 1;
                }

                foreach (int j in list1)
                {
                    checkedListBox2.SetItemChecked(j, true);
                }

                com.ExecuteNonQuery();
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

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnNextTable_Click(object sender, EventArgs e)
        {
            string newEquipment = textBox1.Text;
            string newDiagnosis = textBox2.Text;

            if (textBox1.Text.Count() > 0)
            {

                using (SqlConnection con = new SqlConnection(connecstionString))
                {


                    con.Open();
                    SqlCommand com = new SqlCommand("insert into equipments (equipmentName) values (@newEquipment);", con);
                    com.Parameters.AddWithValue("@newEquipment", newEquipment);


                    com.ExecuteNonQuery();

                    try
                    {
                        MessageBox.Show("A new equipment is added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            if (textBox2.Text.Count() > 0)
            {
                using (SqlConnection con = new SqlConnection(connecstionString))
                {


                    con.Open();
                    SqlCommand com = new SqlCommand("insert into diagnosis (diagnosisName) values (@newDiagnosis);", con);
                    com.Parameters.AddWithValue("@newDiagnosis", newDiagnosis);


                    com.ExecuteNonQuery();

                    try
                    {
                        MessageBox.Show("A new Diagnosis is added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // this.Refresh();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {

                con.Open();
                SqlCommand com = new SqlCommand("updateCourse", con);
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);
                com.Parameters.AddWithValue("@sessionsNo", phone.Text);
                com.Parameters.AddWithValue("@frequency", email.Text);
                com.Parameters.AddWithValue("@totalDuration", nationalID.Text);
                com.Parameters.AddWithValue("@notes", textBox5.Text);


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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {

                con.Open();
                SqlCommand com = new SqlCommand("deleteAllEquipmentsOfPatient", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);

                com.ExecuteNonQuery();
            }

            using (SqlConnection con = new SqlConnection(connecstionString))
            {

                con.Open();
                SqlCommand com = new SqlCommand("deleteAllDiagnosisOfPatient", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);

                com.ExecuteNonQuery();
            }



            foreach (DataRowView item in checkedListBox1.CheckedItems)
            {
                using (SqlConnection con = new SqlConnection(connecstionString))
                {

                    con.Open();
                    SqlCommand com = new SqlCommand("updateEquipmentsOfPatient", con);
                    com.CommandType = CommandType.StoredProcedure;


                    com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);
                    com.Parameters.AddWithValue("@equipmentID", item["equipmentID"].ToString());


                    com.ExecuteNonQuery();



                }
            }

            try
            {
                MessageBox.Show("Equipments Updated sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            
            foreach (DataRowView item in checkedListBox2.CheckedItems)
            {
                using (SqlConnection con = new SqlConnection(connecstionString))
                {

                    con.Open();
                    SqlCommand com = new SqlCommand("updateDiagnosisOfPatient", con);
                    com.CommandType = CommandType.StoredProcedure;


                    com.Parameters.AddWithValue("@courseID", ucPatientProfile.courseinfo);
                    com.Parameters.AddWithValue("@diagnosisID", item["diagnosisID"].ToString());


                    com.ExecuteNonQuery();


                }
            }

            try
            {
                MessageBox.Show("Diagnosis Updated sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

    }
