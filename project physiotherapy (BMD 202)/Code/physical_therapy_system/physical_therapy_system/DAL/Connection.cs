using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physical_therapy_system.DAL
{
    class Connection
    {
        #region DB Connection
        public SqlConnection connect = new SqlConnection( "Data Source=DESKTOP-GRDRPCD;Initial Catalog=clinical_system;Integrated Security=True");
        #endregion
    }
}
