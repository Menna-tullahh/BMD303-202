using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace physical_therapy_system
{
    public partial class ucReserve : UserControl
    {
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";
        public static string time = "";
        string nationalid = "";
        string assignCourse;
        string assignDoctor;
        string titletxt;
        public static string date;
        bool visible = false;

        public ucReserve()
        {
            InitializeComponent();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            date = monthCalendar1.SelectionRange.Start.ToShortDateString();

            

            string value = "";
            bool isChecked = radioButton1.Checked;
            value = radioButton1.Text;
            if (time == "")
            {
                MessageBox.Show("Please Choose a time for reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isChecked)
                {


                    using (SqlConnection con = new SqlConnection(connecstionString))
                    {


                        con.Open();
                        SqlCommand com = new SqlCommand("addNewCourse", con);
                        com.CommandType = CommandType.StoredProcedure;


                        com.Parameters.AddWithValue("@nationalID", nationalid);
                        com.Parameters.AddWithValue("@username", logIn.username);
                        com.Parameters.AddWithValue("@sessionDate", monthCalendar1.SelectionRange.Start.ToShortDateString());
                        com.Parameters.AddWithValue("@sessionTime", time);
                        com.Parameters.AddWithValue("@doctorID", assignDoctor);
                        com.Parameters.AddWithValue("@title", titletxt);
                        com.Parameters.Add("@bool", SqlDbType.Int);
                        com.Parameters["@bool"].Direction = ParameterDirection.Output;

                        com.ExecuteNonQuery();
                        int returnBool = (int)com.Parameters["@bool"].Value;

                       

                        try
                        {
                            //Console.WriteLine(dateTimePicker1.Value.ToString("hh:mm"));
                            if (returnBool == 1)
                            {
                                MessageBox.Show("This time is Reserved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                MessageBox.Show("A new Course is added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucDashboard"))
                                {
                                    Form1.Instance.lblTitle.Text = "Dashboard";
                                    ucDashboard nu = new ucDashboard();
                                    nu.Dock = DockStyle.Fill;
                                    Form1.Instance.pnlFormLoader.Controls.Add(nu);
                                }
                                Form1.Instance.pnlFormLoader.Controls["ucDashboard"].BringToFront();
                                Form1.Instance.pnlFormLoader.Visible = true;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }






                    }
                }
                else
                {
                    value = radioButton2.Text;
                    using (SqlConnection con = new SqlConnection(connecstionString))
                    {

                        con.Open();
                        SqlCommand com2 = new SqlCommand("updateCourseReservation", con);
                        com2.CommandType = CommandType.StoredProcedure;

                        com2.Parameters.AddWithValue("@nationalID", nationalid);
                        com2.Parameters.AddWithValue("@username", logIn.username);
                        com2.Parameters.AddWithValue("@sessionDate", monthCalendar1.SelectionRange.Start.ToShortDateString());
                        com2.Parameters.AddWithValue("@sessionTime", time);
                        com2.Parameters.AddWithValue("@idcourse", Int16.Parse(assignCourse));
                        com2.Parameters.Add("@bool", SqlDbType.Int);
                        com2.Parameters["@bool"].Direction = ParameterDirection.Output;

                        com2.ExecuteNonQuery();
                        int returnBool2 = (int)com2.Parameters["@bool"].Value;
                        try
                        {
                            if (returnBool2 == 1)
                            {
                                MessageBox.Show("This time is Reserved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                MessageBox.Show("Reserved sucessfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucDashboard"))
                                {
                                    Form1.Instance.lblTitle.Text = "Dashboard";
                                    ucDashboard nu = new ucDashboard();
                                    nu.Dock = DockStyle.Fill;
                                    Form1.Instance.pnlFormLoader.Controls.Add(nu);
                                }
                                Form1.Instance.pnlFormLoader.Controls["ucDashboard"].BringToFront();
                                Form1.Instance.pnlFormLoader.Visible = true;
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            doctor.Visible = true;
            comboBox1.Visible = true;

            course.Visible = false;
            comboBoxCourse.Visible = false;

            title.Visible = true;
            titleText.Visible = true;
            using (SqlConnection con = new SqlConnection(connecstionString))
            {


                con.Open();
                SqlCommand com = new SqlCommand("select name, userID from userAccount where role = 'doctor';", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                DataTable table1 = new DataTable();
                da.Fill(table1);

                comboBox1.DataSource = table1;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "userID";

                com.ExecuteNonQuery();

            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            course.Visible = true;
            comboBoxCourse.Visible = true;

            doctor.Visible = false;
            comboBox1.Visible = false;

            title.Visible = false;
            titleText.Visible = false;

            using (SqlConnection con = new SqlConnection(connecstionString))
            {


                con.Open();
            

                SqlCommand com = new SqlCommand("select courseID, title from course where course_patient_ID = (select patientID from patient where NationalID = @nationalid);", con);
                com.Parameters.AddWithValue("@nationalid", nationalid);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                DataTable table = new DataTable();
                da.Fill(table);


                comboBoxCourse.DataSource = table;
                comboBoxCourse.DisplayMember = "title";
                comboBoxCourse.ValueMember = "courseID";
                com.ExecuteNonQuery();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void ucReserve_Load(object sender, EventArgs e)
        {
            if (ucAddNewUser.newPatient == true)
            {
                radioButton2.Visible = false;
            }
            //dateTimePicker1.MinDate = DateTime.Today;
            if (!String.IsNullOrEmpty(ucAddNewUser.nationalID))
            {
                nationalid = ucAddNewUser.nationalID;
            }
            else if (!String.IsNullOrEmpty(ucAddOldUser.nationalIDField))
            {
                nationalid = ucAddOldUser.nationalIDField;
            }

            monthCalendar1.MinDate = DateTime.Today;

            if (visible == true)
            {
                radioButton2.Visible = false;

            }






        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            time = "9:00";
            toolStripMenuItem1.Text = "9:00";
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            time = "10:00";
            toolStripMenuItem1.Text = "10:00";
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            time = "11:00";
            toolStripMenuItem1.Text = "11:00";
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            time = "12:00";
            toolStripMenuItem1.Text = "12:00";
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            time = "13:00";
            toolStripMenuItem1.Text = "13:00";
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            time = "14:00";
            toolStripMenuItem1.Text = "14:00";
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            time = "15:00";
            toolStripMenuItem1.Text = "15:00";
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            time = "16:00";
            toolStripMenuItem1.Text = "16:00";
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            time = "17:00";
            toolStripMenuItem1.Text = "17:00";
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            time = "18:00";
            toolStripMenuItem1.Text = "18:00";
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            time = "19:00";
            toolStripMenuItem1.Text = "19:00";
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            time = "20:00";
            toolStripMenuItem1.Text = "20:00";
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            time = "21:00";
            toolStripMenuItem1.Text = "21:00";
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            time = "22:00";
            toolStripMenuItem1.Text = "22:00";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
             assignDoctor = comboBox1.SelectedValue.ToString();
        }

        private void comboBoxCourse_ValueMemberChanged(object sender, EventArgs e)
        {
            assignCourse = comboBoxCourse.SelectedValue.ToString();

            if (!String.IsNullOrEmpty(assignCourse))
            {
                assignCourse = comboBoxCourse.SelectedValue.ToString();

            }
            else
            {
                visible = true;

            }


        }

        private void comboBoxCourse_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {
             titletxt = titleText.Text;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucCalendar"))
            {
                Form1.Instance.lblTitle.Text = "Calendar";
                ucCalendar nu = new ucCalendar();
                nu.Dock = DockStyle.Fill;
                Form1.Instance.pnlFormLoader.Controls.Add(nu);
            }
            Form1.Instance.pnlFormLoader.Controls["ucCalendar"].BringToFront();
            Form1.Instance.pnlFormLoader.Visible = true;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucPatientProfile"))
            {
                Form1.Instance.lblTitle.Text = "Patient Profile";
                ucPatientProfile nu = new ucPatientProfile();
                nu.Dock = DockStyle.Fill;
                Form1.Instance.pnlFormLoader.Controls.Add(nu);
            }
            Form1.Instance.pnlFormLoader.Controls["ucPatientProfile"].BringToFront();
            Form1.Instance.pnlFormLoader.Visible = true;
        }
    }
}
