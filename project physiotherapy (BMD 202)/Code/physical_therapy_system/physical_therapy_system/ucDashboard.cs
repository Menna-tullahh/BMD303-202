using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace physical_therapy_system
{
    public partial class ucDashboard : UserControl
    {
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                
                con.Open();
                SqlCommand com = new SqlCommand("totalEarnings", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@moneyOutput", SqlDbType.Int);
                com.Parameters["@moneyOutput"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();
                int returnStatus = (int)com.Parameters["@moneyOutput"].Value;

                earnings.Text = Convert.ToString(returnStatus) + " EGP";

                



                SqlCommand com2 = new SqlCommand("countCustomers", con);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add("@countCustomers", SqlDbType.Int);
                com2.Parameters["@countCustomers"].Direction = ParameterDirection.Output;
                com2.ExecuteNonQuery();
                int returnStatus2 = (int)com2.Parameters["@countCustomers"].Value;
                customerNo.Text = Convert.ToString(returnStatus2) + " Patient(s)";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucAddNewUser"))
            {
                Form1.Instance.lblTitle.Text = "Add New Patient";
                ucAddNewUser nu = new ucAddNewUser();
                nu.Dock = DockStyle.Fill;
                Form1.Instance.pnlFormLoader.Controls.Add(nu);
            }
            Form1.Instance.pnlFormLoader.Controls["ucAddNewUser"].BringToFront();
            Form1.Instance.pnlFormLoader.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucAddOldUser"))
            {
                Form1.Instance.lblTitle.Text = "Update Old Patient";
                ucAddOldUser nu = new ucAddOldUser();
                nu.Dock = DockStyle.Fill;
                Form1.Instance.pnlFormLoader.Controls.Add(nu);
            }
            Form1.Instance.pnlFormLoader.Controls["ucAddOldUser"].BringToFront();
            Form1.Instance.pnlFormLoader.Visible = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customerNo_Click(object sender, EventArgs e)
        {

        }
    }
}
