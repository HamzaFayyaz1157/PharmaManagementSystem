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
        static string ConnectionString = "Data Source=.;Initial Catalog=PMS;Integrated Security=True";
        


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


        public static void InSert(String InsertQury)
        {
            try
            {
                int insertCount = 0;
                string msg = "";
                SqlConnection objConnection = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(InsertQury,objConnection);
                objConnection.Open();
                insertCount = cmd.ExecuteNonQuery();
                if (insertCount > 0)
                {
                    msg = "Inserted Successfully";
                }
                else
                    msg = "Something is wrong";



                objConnection.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
