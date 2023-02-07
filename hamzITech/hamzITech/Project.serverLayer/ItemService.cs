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
    public class ItemService : Iitem
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M3H7L83;Initial Catalog=Pharma_2022;Integrated Security=True");



        public ResponseViewModel Save(ItemModel item)
        {
            var response = new ResponseViewModel();
            try
            {






                string InsertQury = "Insert into Setup.Item (ItemId,CompanyId,Description,RetailPrice," +
               "TradePrice,PurchaseDiscount,CortonUnit,PakingTypeId,StoreId,CategoryId,ReOrderQty" +
               ",Strip,IsDiscount,Shelf,CreatedBy,CreatedOn,ValidFlag) " +
               "Values (" + item.ItemId + ",'" + item.CompanyId + "','" + item.Description + "','" + item.RetailPrice + "'," +
               "'" + item.TradePrice + "','" + item.PurchaseDiscount + "','" + item.CortonUnit + "'," +
               "'" + item.PakingTypeId + "','" + item.StoreId + "','" + item.CategoryId + "','" + item.ReOrderQty + "'," +
               "'" + item.Strip + "','" + item.IsDiscount + "','" + item.Shelf + "','" + "admin" + "','" + DateTime.Now + "'," + 1 + ")";



                //SqlCommand cmd = new SqlCommand("Insert into Setup.Item (ItemId,CompanyId,Description,RetailPrice," +
                // "TradePrice,IsDiscount,PurchaseDiscount,CortonUnit,PakingTypeId,StoreId,CategoryId,ReOrderQty" +
                // ",Strip,Shelf,CreatedBy,CreatedOn,ValidFlag) " +
                // "Values (@ItemId,@CompanyId,@Description,@RetailPrice,@TradePrice,@IsDiscount,@PurchaseDiscount," +
                // "@CortonUnit,@PakingTypeId,@StoreId,@CategoryId,@ReOrderQty,@Strip,@Shelf," +
                // "@CreatedBy,@CreatedOn,@ValidFlag)", con);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@ItemId", item.ItemId);
                //cmd.Parameters.AddWithValue("@CompanyId", item.CompanyId);
                //cmd.Parameters.AddWithValue("@Description", item.Description);
                //cmd.Parameters.AddWithValue("@Shelf", item.Shelf);
                //cmd.Parameters.AddWithValue("@RetailPrice", item.RetailPrice);
                //cmd.Parameters.AddWithValue("@TradePrice", item.TradePrice);
                //cmd.Parameters.AddWithValue("@IsDiscount", item.IsDiscount);
                //cmd.Parameters.AddWithValue("@PurchaseDiscount", item.PurchaseDiscount);
                //cmd.Parameters.AddWithValue("@CortonUnit", item.CortonUnit);
                //cmd.Parameters.AddWithValue("@PakingTypeId", item.PakingTypeId);
                //cmd.Parameters.AddWithValue("@StoreId", item.StoreId);
                //cmd.Parameters.AddWithValue("@CategoryId", item.CategoryId);
                //cmd.Parameters.AddWithValue("@ReOrderQty", item.ReOrderQty);
                //cmd.Parameters.AddWithValue("@Strip", item.Strip);
                //cmd.Parameters.AddWithValue("@CreatedBy", "Admin");
                //cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                //cmd.Parameters.AddWithValue("@ValidFlag", true);



                DatabaseConnection.InSert(InsertQury);
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
            SqlCommand cmd = new SqlCommand("select top 1 ItemId from Setup.Item order by ItemId Desc ", con);
            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                getID = da["ItemId"].ToString();

                ID = Convert.ToInt32(getID);
                ID++;
            }
            else
                ID = 1;
            con.Close();
            response.obj = ID;
            return response;
        }

        public ResponseViewModel LoadLookup()
        {

            DataSet ds = DatabaseConnection.SeclectQuery("select[CompanyId],[Description] from Setup.Company");
            var response = new ResponseViewModel();

            return response;

        }

        public ResponseViewModel SaveDiscount(ItemDiscountModel Discount)
        {
            var response = new ResponseViewModel();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Setup.ItemDiscount (ItemId,DiscountType,Value,Percentage," +
                    "TargetQty,StartDate,EndDate,Remarks,CreatedBy,CreatedOn,ValidFlag)" +
                    " Values (@ItemId,@DiscountType,@Value,@Percentage,@TargetQty,@StartDate,@EndDate,@Remarks," +
                    "@CreatedBy,@CreatedOn,@ValidFlag)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ItemId", Discount.ItemId);
                cmd.Parameters.AddWithValue("@DiscountType", Discount.DiscountType);
                cmd.Parameters.AddWithValue("@Value", Discount.Value);
                cmd.Parameters.AddWithValue("@Percentage", Discount.Percentage);
                cmd.Parameters.AddWithValue("@TargetQty", Discount.TargetQty);
                cmd.Parameters.AddWithValue("@StartDate", Discount.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", Discount.EndDate);
                cmd.Parameters.AddWithValue("@Remarks", Discount.Remarks);
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
            };
        }
    }
}
