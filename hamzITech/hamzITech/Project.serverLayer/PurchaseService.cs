using hamzITech.NewFolder1;
using hamzITech.Project.DataAccessLayer;
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
    public class PurchaseService : IPurchase
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PMS;Integrated Security=True");



        public ResponseViewModel Save(PurchaseModel Purchase)
        {
            var response = new ResponseViewModel();
            try
            {






               // string InsertQury = "Insert into Setup.Purchase (PurchaseId,CompanyId,Description,RetailPrice," +
               //"TradePrice,PurchaseDiscount,CortonUnit,PakingTypeId,StoreId,CategoryId,ReOrderQty" +
               //",Strip,IsDiscount,Shelf,CreatedBy,CreatedOn,ValidFlag) " +
               //"Values (" + Purchase.PurchaseId + ",'" + Purchase.CompanyId + "','" + Purchase.Description + "','" + Purchase.RetailPrice + "'," +
               //"'" + Purchase.TradePrice + "','" + Purchase.PurchaseDiscount + "','" + Purchase.CortonUnit + "'," +
               //"'" + Purchase.PakingTypeId + "','" + Purchase.StoreId + "','" + Purchase.CategoryId + "','" + Purchase.ReOrderQty + "'," +
               //"'" + Purchase.Strip + "','" + Purchase.IsDiscount + "','" + Purchase.Shelf + "','" + "admin" + "','" + DateTime.Now + "'," + 1 + ")";



                


               // DatabaseConnection.InSert(InsertQury);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
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
            SqlCommand cmd = new SqlCommand("select top 1 PurchaseId from Purchase.master order by PurchaseId Desc ", con);
            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                getID = da["PurchaseId"].ToString();

                ID = Convert.ToInt32(getID);
                ID++;
            }
            else
                ID = 1;
            con.Close();
            response.obj = ID;
            return response;
        }

        
        //public ResponseViewModel SaveDiscount(PurchaseDiscountModel Discount)
        //{
        //    var response = new ResponseViewModel();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into Setup.PurchaseDiscount (PurchaseId,DiscountType,Value,Percentage," +
        //            "TargetQty,StartDate,EndDate,Remarks,CreatedBy,CreatedOn,ValidFlag)" +
        //            " Values (@PurchaseId,@DiscountType,@Value,@Percentage,@TargetQty,@StartDate,@EndDate,@Remarks," +
        //            "@CreatedBy,@CreatedOn,@ValidFlag)", con);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("@PurchaseId", Discount.PurchaseId);
        //        cmd.Parameters.AddWithValue("@DiscountType", Discount.DiscountType);
        //        cmd.Parameters.AddWithValue("@Value", Discount.Value);
        //        cmd.Parameters.AddWithValue("@Percentage", Discount.Percentage);
        //        cmd.Parameters.AddWithValue("@TargetQty", Discount.TargetQty);
        //        cmd.Parameters.AddWithValue("@StartDate", Discount.StartDate);
        //        cmd.Parameters.AddWithValue("@EndDate", Discount.EndDate);
        //        cmd.Parameters.AddWithValue("@Remarks", Discount.Remarks);
        //        cmd.Parameters.AddWithValue("@CreatedBy", "Admin");
        //        cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
        //        cmd.Parameters.AddWithValue("@ValidFlag", true);

                
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        response.obj = "Saved";
        //        return response;
        //    }



        //    catch (Exception ex)
        //    {

        //        //response.Status = HttpStatusCode.InternalServerError;
        //        response.obj = ex.GetBaseException().Message;
        //        response.Message = ex.GetBaseException().Message;
        //        //response.LogLevel = LogLevel.Error;
        //        return response;
        //    };
        //}
    
    }
}
