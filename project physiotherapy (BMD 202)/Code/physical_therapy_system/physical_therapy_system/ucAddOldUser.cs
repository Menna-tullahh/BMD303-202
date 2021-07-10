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
    public partial class ucAddOldUser : UserControl
    {
        int action;
        public static string nationalIDField;
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";
        

        public ucAddOldUser()
        {
            InitializeComponent();
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 2;
            toolStripMenuItem1.Text = "Reserve An Appointment                  ";


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {

                con.Open();
                SqlCommand com = new SqlCommand("checkOldUser", con);
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@nationalID", nationalID.Text);
                com.Parameters.Add("@status", SqlDbType.Int);
                com.Parameters["@status"].Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();
                int returnStatus = (int)com.Parameters["@status"].Value;

                if (returnStatus == 1) {

                    if (action == 1)
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
                    else if (action == 2)
                    {
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
                    else
                    {
                        MessageBox.Show("You have to fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("This patient is not existing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 1;
            toolStripMenuItem1.Text = "Update Patient Profile                        ";


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucAddOldUser_Load(object sender, EventArgs e)
        {
            ucAddNewUser.newPatient = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nationalID_TextChanged(object sender, EventArgs e)
        {
            nationalIDField = nationalID.Text;

        }
    }
}
