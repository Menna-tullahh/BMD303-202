using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using physical_therapy_system.DAL;
using System.Diagnostics;

namespace physical_therapy_system
{
    public partial class logIn : Form
    {
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";
        //Connection con = new Connection();

       // SqlCommand com = new SqlCommand();

        public static string username;
        public static string password;
        public static string role;
            
        bool drag = false;
        Point start_point = new Point(0, 0);

        public logIn()
        {
            InitializeComponent();


        }

        private void logIn_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //this.usernameTxt.Text = Properties.Settings.Default.UserEmail;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(connecstionString))
            {
                username = usernameTxt.Text;
                password = passTxt.Text;
                con.Open();
                SqlCommand com = new SqlCommand("checkLogin", con);
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@username", username);
                com.Parameters.AddWithValue("@password", password);

                com.Parameters.Add("@role", SqlDbType.VarChar, 100);
                com.Parameters["@role"].Direction = ParameterDirection.Output;
                com.Parameters.Add("@status", SqlDbType.Int);
                com.Parameters["@status"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();

                int returnStatus = (int)com.Parameters["@status"].Value;


                if (returnStatus == 1)
                {
                    role = (string)com.Parameters["@role"].Value;
                    Form1 obj = new Form1();
                    obj.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Either username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                /* foreach (SqlParameter prm in com.Parameters)
                 {
                     Debug.WriteLine("");
                     Debug.WriteLine("Name " + prm.ParameterName);
                     Debug.WriteLine("Type " + prm.SqlDbType.ToString());
                     Debug.WriteLine("Size " + prm.Size.ToString());
                     Debug.WriteLine("Direction " + prm.Direction.ToString());
                     Debug.WriteLine("Value " + prm.Value);

                 }*/



            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;

            }
        }

        private void Movable_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Movable_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }

        }

        private void Movable_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);


        }

        private void Movable_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void usernameTxt_Leave(object sender, EventArgs e)
        {

        }

        private void Movable_panel_MouseMove_1(object sender, MouseEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void passTxt_Enter(object sender, EventArgs e)
        {
            
        }
    }

}
