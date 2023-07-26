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

            Con = new SqlConnection("Data Source=.;Initial Catalog=PMS;Integrated Security=True");
        }
    }
}
