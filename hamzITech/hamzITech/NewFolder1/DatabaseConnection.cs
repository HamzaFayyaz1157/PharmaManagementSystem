using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.NewFolder1
{
    public static class DatabaseConnection
    {
        static string ConnectionString = "Data Source=DESKTOP-M3H7L83;Initial Catalog=Pharma_2022;Integrated Security=True";



        public static DataSet SeclectQuery(string query)
        {
            DataSet ds = new DataSet();
            try
            {


                SqlConnection objConnection = new SqlConnection(ConnectionString);
                objConnection.Open();
                SqlCommand ObjCommand = new SqlCommand(query, objConnection);
                SqlDataAdapter da = new SqlDataAdapter(ObjCommand);
                da.Fill(ds);

                objConnection.Close();

                return ds;


                    }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static void InSert(string query)
        {
            try
            {

                SqlConnection objConnection = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(query,objConnection);
                objConnection.Open();
                cmd.ExecuteNonQuery();
                objConnection.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
