using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physical_therapy_system.DAL
{
    class ClassDAL
    {
        #region register
        /*using (SqlConnection con = new SqlConnection(connecstionString))
            {
                username = usernameTxt.Text;
                password = passTxt.Text;
                con.Open();
                SqlCommand com = new SqlCommand("register", con);
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@username", username);
                com.Parameters.AddWithValue("@password", password);
                com.Parameters.AddWithValue("@role", "Doctor");


                com.Parameters.Add("@regstatus", SqlDbType.Int);
                com.Parameters["@regstatus"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();

                int returnStatus = (int)com.Parameters["@regstatus"].Value;
                Console.WriteLine(returnStatus);

                if (returnStatus == 0)
                {
                    MessageBox.Show("Successfully added", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Already found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }*/
        #endregion

        #region deleteUser
        /*using (SqlConnection con = new SqlConnection(connecstionString))
           {
               username = usernameTxt.Text;
               con.Open();
               SqlCommand com = new SqlCommand("deleteUser", con);
               com.CommandType = CommandType.StoredProcedure;

               com.Parameters.AddWithValue("@username", username);

               com.ExecuteNonQuery();

               MessageBox.Show("Successfully deleted", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);


           }*/
        #endregion

        #region

        #endregion




    }
}
