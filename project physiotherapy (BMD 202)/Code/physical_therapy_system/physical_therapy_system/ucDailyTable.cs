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
    public partial class ucDailyTable : UserControl
    {
        string connecstionString = @"Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True";

        public ucDailyTable()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucDailyTable_Load(object sender, EventArgs e)
        {
            label61.Text = ucCalendar.date.ToString();
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.ToString());


            using (SqlConnection con = new SqlConnection(connecstionString))
            {

                con.Open();
                SqlCommand com = new SqlCommand("select DISTINCT  sessionTime, patientName, nationalID, title,confirmed from reservation r, patient p, course c where r.reservation_patient_ID = p.patientID and r.reservation_course_ID = c.courseID and sessionDate = @date;", con);
                com.Parameters.AddWithValue("@date", ucCalendar.date);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                DataTable table = new DataTable();
                da.Fill(table);


                if (table != null)
                {
                    foreach (DataRow dataRow in table.Rows)
                    {
                   
                            if (dataRow.ItemArray[0].ToString() == "09:00:00")
                            {
                                ID9.Visible = true;
                                name9.Visible = true;
                                type9.Visible = true;
                                ID9.Text = dataRow.ItemArray[2].ToString();
                                name9.Text = dataRow.ItemArray[1].ToString();
                                type9.Text = dataRow.ItemArray[3].ToString();
                                button2.Visible = true;
                                button1.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label2.Visible = true;
                                    button2.Visible = false;
                                    button1.Visible = false;
                                }

                            }
                            if (dataRow.ItemArray[0].ToString() == "10:00:00")
                            {
                                ID10.Visible = true;
                                label3.Visible = true;
                                type10.Visible = true;
                                ID10.Text = dataRow.ItemArray[2].ToString();
                                label3.Text = dataRow.ItemArray[1].ToString();
                                type10.Text = dataRow.ItemArray[3].ToString();
                                button3.Visible = true;
                                button4.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label14.Visible = true;
                                    button3.Visible = false;
                                    button4.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "11:00:00")
                            {
                                id11.Visible = true;
                                label5.Visible = true;
                                type11.Visible = true;
                                id11.Text = dataRow.ItemArray[2].ToString();
                                label5.Text = dataRow.ItemArray[1].ToString();
                                type11.Text = dataRow.ItemArray[3].ToString();
                                button5.Visible = true;
                                button6.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label49.Visible = true;
                                    button5.Visible = false;
                                    button6.Visible = false;
                                }
                             }
                            if (dataRow.ItemArray[0].ToString() == "12:00:00")
                            {
                                id12.Visible = true;
                                label6.Visible = true;
                                type12.Visible = true;
                                id12.Text = dataRow.ItemArray[2].ToString();
                                label6.Text = dataRow.ItemArray[1].ToString();
                                type12.Text = dataRow.ItemArray[3].ToString();
                                button7.Visible = true;
                                button8.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label50.Visible = true;
                                    button7.Visible = false;
                                    button8.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "13:00:00")
                            {
                                id13.Visible = true;
                                label8.Visible = true;
                                label15.Visible = true;
                                id13.Text = dataRow.ItemArray[2].ToString();
                                label8.Text = dataRow.ItemArray[1].ToString();
                                label15.Text = dataRow.ItemArray[3].ToString();
                                button9.Visible = true;
                                button10.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label51.Visible = true;
                                    button9.Visible = false;
                                    button10.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "14:00:00")
                            {
                                label17.Visible = true;
                                label9.Visible = true;
                                label18.Visible = true;
                                label17.Text = dataRow.ItemArray[2].ToString();
                                label9.Text = dataRow.ItemArray[1].ToString();
                                label18.Text = dataRow.ItemArray[3].ToString();
                                button11.Visible = true;
                                button12.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label52.Visible = true;
                                    button11.Visible = false;
                                    button12.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "15:00:00")
                            {
                                label20.Visible = true;
                                label11.Visible = true;
                                label21.Visible = true;
                                label20.Text = dataRow.ItemArray[2].ToString();
                                label11.Text = dataRow.ItemArray[1].ToString();
                                label21.Text = dataRow.ItemArray[3].ToString();
                                button13.Visible = true;
                                button14.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label57.Visible = true;
                                    button13.Visible = false;
                                    button14.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "16:00:00")
                            {
                                label23.Visible = true;
                                label12.Visible = true;
                                label24.Visible = true;
                                label23.Text = dataRow.ItemArray[2].ToString();
                                label12.Text = dataRow.ItemArray[1].ToString();
                                label24.Text = dataRow.ItemArray[3].ToString();
                                button15.Visible = true;
                                button16.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label56.Visible = true;
                                    button15.Visible = false;
                                    button16.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "17:00:00")
                            {
                                label26.Visible = true;
                                label43.Visible = true;
                                label27.Visible = true;
                                label26.Text = dataRow.ItemArray[2].ToString();
                                label43.Text = dataRow.ItemArray[1].ToString();
                                label27.Text = dataRow.ItemArray[3].ToString();
                                button17.Visible = true;
                                button18.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label55.Visible = true;
                                    button17.Visible = false;
                                    button18.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "18:00:00")
                            {
                                label29.Visible = true;
                                label44.Visible = true;
                                label30.Visible = true;
                                label29.Text = dataRow.ItemArray[2].ToString();
                                label24.Text = dataRow.ItemArray[1].ToString();
                                label30.Text = dataRow.ItemArray[3].ToString();
                                button19.Visible = true;
                                button20.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label54.Visible = true;
                                    button19.Visible = false;
                                    button20.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "19:00:00")
                            {
                                label32.Visible = true;
                                label45.Visible = true;
                                label33.Visible = true;
                                label32.Text = dataRow.ItemArray[2].ToString();
                                label45.Text = dataRow.ItemArray[1].ToString();
                                label33.Text = dataRow.ItemArray[3].ToString();
                                button21.Visible = true;
                                button22.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label53.Visible = true;
                                    button21.Visible = false;
                                    button22.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "20:00:00")
                            {
                                label35.Visible = true;
                                label46.Visible = true;
                                label36.Visible = true;
                                label35.Text = dataRow.ItemArray[2].ToString();
                                label46.Text = dataRow.ItemArray[1].ToString();
                                label36.Text = dataRow.ItemArray[3].ToString();
                                button23.Visible = true;
                                button24.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label60.Visible = true;
                                    button23.Visible = false;
                                    button24.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "21:00:00")
                            {
                                label38.Visible = true;
                                label47.Visible = true;
                                label39.Visible = true;
                                label38.Text = dataRow.ItemArray[2].ToString();
                                label47.Text = dataRow.ItemArray[1].ToString();
                                label39.Text = dataRow.ItemArray[3].ToString();
                                button25.Visible = true;
                                button26.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label59.Visible = true;
                                    button25.Visible = false;
                                    button26.Visible = false;
                                }
                            }
                            if (dataRow.ItemArray[0].ToString() == "22:00:00")
                            {
                                label41.Visible = true;
                                label48.Visible = true;
                                label42.Visible = true;
                                label41.Text = dataRow.ItemArray[2].ToString();
                                label48.Text = dataRow.ItemArray[1].ToString();
                                label42.Text = dataRow.ItemArray[3].ToString();
                                button27.Visible = true;
                                button28.Visible = true;
                                if (dataRow.ItemArray[4].ToString() == "1")
                                {
                                    label58.Visible = true;
                                    button27.Visible = false;
                                    button28.Visible = false;
                                }
                            }
                       
                    }

                }

                com.ExecuteNonQuery();

            }

        }

        private void ucDailyTable_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "09:00:00");
                com.Parameters.AddWithValue("@nationalID", ID9.Text);
                com.Parameters.AddWithValue("@title", type9.Text);
                com.ExecuteNonQuery();

                button1.Visible = false;
                button2.Visible = false;
            }
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "10:00:00");
                com.Parameters.AddWithValue("@nationalID", ID10.Text);
                com.Parameters.AddWithValue("@title", type10.Text);
                com.ExecuteNonQuery();

                button3.Visible = false;
                button4.Visible = false;
            }
            label14.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "11:00:00");
                com.Parameters.AddWithValue("@nationalID", id11.Text);
                com.Parameters.AddWithValue("@title", type11.Text);
                com.ExecuteNonQuery();

                button5.Visible = false;
                button6.Visible = false;
            }
            label49.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "12:00:00");
                com.Parameters.AddWithValue("@nationalID", id12.Text);
                com.Parameters.AddWithValue("@title", type12.Text);
                com.ExecuteNonQuery();

                button7.Visible = false;
                button8.Visible = false;
            }
            label50.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "13:00:00");
                com.Parameters.AddWithValue("@nationalID", id13.Text);
                com.Parameters.AddWithValue("@title", label15.Text);
                com.ExecuteNonQuery();

                button9.Visible = false;
                button10.Visible = false;
            }
            label51.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "14:00:00");
                com.Parameters.AddWithValue("@nationalID", label17.Text);
                com.Parameters.AddWithValue("@title", label18.Text);
                com.ExecuteNonQuery();

                button11.Visible = false;
                button12.Visible = false;
            }
            label52.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "15:00:00");
                com.Parameters.AddWithValue("@nationalID", label20.Text);
                com.Parameters.AddWithValue("@title", label21.Text);
                com.ExecuteNonQuery();

                button13.Visible = false;
                button14.Visible = false;
            }
            label57.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "16:00:00");
                com.Parameters.AddWithValue("@nationalID", label23.Text);
                com.Parameters.AddWithValue("@title", label24.Text);
                com.ExecuteNonQuery();

                button15.Visible = false;
                button16.Visible = false;
            }
            label56.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "17:00:00");
                com.Parameters.AddWithValue("@nationalID", label26.Text);
                com.Parameters.AddWithValue("@title", label27.Text);
                com.ExecuteNonQuery();

                button17.Visible = false;
                button18.Visible = false;
            }
            label55.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "18:00:00");
                com.Parameters.AddWithValue("@nationalID", label29.Text);
                com.Parameters.AddWithValue("@title", label30.Text);
                com.ExecuteNonQuery();

                button19.Visible = false;
                button20.Visible = false;
            }
            label54.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "19:00:00");
                com.Parameters.AddWithValue("@nationalID", label32.Text);
                com.Parameters.AddWithValue("@title", label33.Text);
                com.ExecuteNonQuery();

                button21.Visible = false;
                button22.Visible = false;
            }
            label53.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "20:00:00");
                com.Parameters.AddWithValue("@nationalID", label35.Text);
                com.Parameters.AddWithValue("@title", label36.Text);
                com.ExecuteNonQuery();

                button23.Visible = false;
                button24.Visible = false;
            }
            label60.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "21:00:00");
                com.Parameters.AddWithValue("@nationalID", label38.Text);
                com.Parameters.AddWithValue("@title", label39.Text);
                com.ExecuteNonQuery();

                button25.Visible = false;
                button26.Visible = false;
            }
            label59.Visible = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connecstionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("addSession", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@date", ucCalendar.date);
                com.Parameters.AddWithValue("@time", "22:00:00");
                com.Parameters.AddWithValue("@nationalID", label41.Text);
                com.Parameters.AddWithValue("@title", label42.Text);
                com.ExecuteNonQuery();

                button27.Visible = false;
                button28.Visible = false;
            }
            label58.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

