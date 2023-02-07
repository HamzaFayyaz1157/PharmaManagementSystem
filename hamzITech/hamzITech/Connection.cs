using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech
{
    class Connection
    {
        public SqlConnection Con;

        public void Connect()
        {

            Con = new SqlConnection("Data Source=DESKTOP-M3H7L83;Initial Catalog=Pharma_2022;Integrated Security=True");
        }
    }
}
