﻿using hamzITech.Project.DataAccessLayer;
using hamzITech.Project.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamzITech.Project.serverLayer
{
   public class CategoryService : ICategory
    {
        //Connection con = new Connection();

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PMS;Integrated Security=True");



        public ResponseViewModel Save(CategoryModel category)
        {
            var response = new ResponseViewModel();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Setup.Category (CategoryId,Description,CreatedBy,CreatedOn,ValidFlag) Values (@CategoryId,@Description,@CreatedBy,@CreatedOn,@ValidFlag)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CategoryId", category.CategoryId);
                cmd.Parameters.AddWithValue("@Description", category.Description);
                cmd.Parameters.AddWithValue("@CreatedBy", "Admin");
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@ValidFlag", true);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                response.obj = "Saved";
                return response;
            }
            catch (Exception ex)
            {

                //response.Status = HttpStatusCode.InternalServerError;
                response.obj = ex.GetBaseException().Message;
                response.Message = ex.GetBaseException().Message;
                //response.LogLevel = LogLevel.Error;
                return response;
            }
        }
        public ResponseViewModel GetId()
        {
            string getID = "";
            int ID = 0;
            var response = new ResponseViewModel();
            con.Open();
            SqlCommand cmd = new SqlCommand("select top 1 CategoryId from Setup.Category order by CategoryId Desc ", con);
            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                getID = da["CategoryId"].ToString();

                ID = Convert.ToInt32(getID);
                ID++;
            }
            else
                ID = 1;
            con.Close();
            response.obj = ID;
            return response;
        }



    }
}
