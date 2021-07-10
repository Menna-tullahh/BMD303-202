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
    public partial class ucAddNewUser : UserControl
    {
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";
        public static string nationalID;
        int genderCode = -1;
        public static bool newPatient = false;

        public ucAddNewUser()
        {
            InitializeComponent();
        }

        private void panelAddNew_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            


            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                string name = pName.Text;
                DateTime dob = Convert.ToDateTime(pDOB.Text);
                string phoneNumber1 = pPhone1.Text;
                nationalID = pNationalID.Text;
                string job = pJob.Text;
                string address = pAddress.Text;
                string gender = null;
                if (genderCode == 1)
                {
                    gender = "male";
                }
                else if (genderCode == 2)
                {
                    gender = "female";
                }

                string email = pEmail.Text;
                string note = pNote.Text;

                con.Open();
                SqlCommand com = new SqlCommand("addNewPatient", con);
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@dob", dob);
                com.Parameters.AddWithValue("@phone1", phoneNumber1);
                com.Parameters.AddWithValue("@nationalID", nationalID);
                com.Parameters.AddWithValue("@job", job);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@email", email);
                com.Parameters.AddWithValue("@note", note);
                
                try
                {
                    com.ExecuteNonQuery();
                    if (String.IsNullOrEmpty(nationalID) || nationalID.Length < 14)
                    {
                        MessageBox.Show("National ID either empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("The patient sucessfully added", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newPatient = true;
                        if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucReserve"))
                        {
                            Form1.Instance.lblTitle.Text = "Reserve";
                            ucReserve nu = new ucReserve();
                            nu.Dock = DockStyle.Fill;
                            Form1.Instance.pnlFormLoader.Controls.Add(nu);
                        }
                        Form1.Instance.pnlFormLoader.Controls["ucReserve"].BringToFront();
                        Form1.Instance.pnlFormLoader.Visible = true;
                    }
                }
                catch
                {
                    if (String.IsNullOrEmpty(nationalID) || nationalID.Length < 14 )
                    {
                        MessageBox.Show("National ID either empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("This patient already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                




            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pPhone1_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                pPhone1.Select(0, 0);
            });
        }

        private void pPhone2_Enter(object sender, EventArgs e)
        {

        }

        private void pEmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pEmail_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                pEmail.Select(0, 0);
            });
        }

        private void pNationalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genderCode = 1;
            toolStripMenuItem1.Text = "Male";

        }

        private void FemaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genderCode = 2;
            toolStripMenuItem1.Text = "Female";
        }
    }
}
