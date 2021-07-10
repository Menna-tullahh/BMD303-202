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
    public partial class ucPatients : UserControl
    {
        public static string patientinfo;
        public ucPatients()
        {
            InitializeComponent();
        }
 

        private void listPatient1_Load(object sender, EventArgs e)
        {

        }

        private void listPatient3_Load(object sender, EventArgs e)
        {

        }

        private void listPatient2_Load(object sender, EventArgs e)
        {

        }

        private void listPatient4_Load(object sender, EventArgs e)
        {

        }

        private void listPatient1_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateItems()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = GetItems();
            if (dt != null) { 
                if (dt.Rows.Count > 0)
                {
                    ListPatient[] listitems = new ListPatient[dt.Rows.Count];
                    for (int i = 0; i<1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listitems[i] = new ListPatient();
                            listitems[i].Title = row["patientName"].ToString();
                            
                            listitems[i].Message = row["NationalID"].ToString();
                            listitems[i].patientID = row["patientID"].ToString();
                            listitems[i].Click += (sender, EventArgs) => { click(sender, EventArgs, row["patientID"].ToString()); };

                            //listitems[i].Width= flowLayoutPanel1.Width;
                            //listitems[i].BgColor = Color.Silver;
                            flowLayoutPanel1.Controls.Add(listitems[i]);


                        }
                    }



                }
            }
            void click(object sender, EventArgs e,string x){
                patientinfo = x;

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


        private void ucPatients_Leave(object sender, EventArgs e)
        {

        }

        private void ucPatients_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        public DataTable GetItems()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string query = "select * from patient";
            SqlCommand cmd = new SqlCommand(query, con.connect);
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
