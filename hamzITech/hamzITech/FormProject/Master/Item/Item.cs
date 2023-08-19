using DevExpress.XtraEditors;
using hamzITech.NewFolder1;
using hamzITech.Project.models;
using hamzITech.Project.serverLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using hamzITech.Project.DataAccessLayer;
using Microsoft.Extensions.Logging;

namespace hamzITech.FormProject
{
    public partial class Item : DevExpress.XtraEditors.XtraForm
    {
        // gvdItemDiscount gvdItem 
        DataSet ds = new DataSet();
        

       // private readonly ILogger _logger;
        ItemService Itemservice = new ItemService();
        string ExcepMesg = "";
        public Item()
        {

            DataSet Company = DatabaseConnection.SeclectQuery("select[CompanyId],[Description] from Setup.Company");

            InitializeComponent();
            LoadId();
            Loadddl();
            CreateDataTable();
            gvdItemDiscount.DataSource = ds.Tables[0];



            gvdItemDiscount.Enabled = false;
            txtDiscount.SelectedIndex = 0;


        }



        private void btnsaveandNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtItemId, "ItemId is Required");
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtDescription, "Description is Required");
                return;
            }
            if (ddlStore.EditValue == null)
            {
                dxErrorProvider1.SetError(ddlStore, "Store is Required");
                return;
            }
            if (string.IsNullOrEmpty(txtretailPrice.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtretailPrice, "Retail Price is Required");
                return;
            }
            if (string.IsNullOrEmpty(txttradePrice.Text.Trim()))
            {
                dxErrorProvider1.SetError(txttradePrice, "Trade Price is Required");
                return;
            }
            try
            {

                Save();
                ResetControl();
                LoadId();
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtItemId, "ItemId is Required");
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtDescription, "Description is Required");
                return;
            }
            if (ddlStore.EditValue == null)
            {
                dxErrorProvider1.SetError(ddlStore, "Store is Required");
                return;
            }

            if (string.IsNullOrEmpty(txtretailPrice.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtretailPrice, "Retail Price is Required");
                return;
            }
            if (string.IsNullOrEmpty(txttradePrice.Text.Trim()))
            {
                dxErrorProvider1.SetError(txttradePrice, "Trade Price is Required");
                return;
            }

            Save();
            this.Close();
        }
        public void LoadId()
        {
            
            var    response = Itemservice.GetId();
                //txtItemId.Text = response.obj.ToString();
            if (response.LogLevel.ToString() == "Error")
            {
                MessageBox.Show(response.obj.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                txtItemId.Text = response.obj.ToString();
            }
            


        }

        public ResponseViewModel Save()
        {
            //var response = new ResponseViewModel();
            
                ItemModel Item = new ItemModel();
                Item.ItemId = Convert.ToInt32(txtItemId.Text);
                Item.CompanyId = (int?)ddlCompany.EditValue;
                Item.CategoryId = (int?)ddlCatagory.EditValue;
                Item.IsDiscount = txtDiscount.SelectedIndex;
                Item.StoreId = (int)ddlStore.EditValue;
                Item.PakingTypeId = (int?)ddlPackingType.EditValue;
                Item.Description = txtDescription.Text;
                Item.RetailPrice = Convert.ToDecimal(txtretailPrice.Text);
                Item.SaleTax = Convert.ToDecimal(txtSaleTax.Text == "" ? null : txtSaleTax.Text);
                Item.AdditionTax = Convert.ToDecimal(txtAdditionTax.Text == "" ? null : txtAdditionTax.Text);
                Item.PurchaseTax = Convert.ToDecimal(txtPurchaseTax.Text == "" ? null : txtPurchaseTax.Text);
                Item.AltCode = Convert.ToInt32(txtAltCode.Text == "" ? null : txtAltCode.Text);
                Item.TradePrice = Convert.ToDecimal(txttradePrice.Text);
                Item.CortonUnit = Convert.ToInt32(txtCortonQty.EditValue ?? null);
                Item.Strip = Convert.ToInt32(txtStripQty.EditValue);
                Item.ReOrderQty = Convert.ToInt32(txtreorderQty.EditValue);
                Item.Shelf = txtShelf.Text;
                Item.PurchaseDiscount = Convert.ToInt32(txtPurchaseDiscount.EditValue);
                Item.IsDiscount = txtDiscount.SelectedIndex;


                var response = Itemservice.Save(Item);
            if(response.LogLevel.ToString() =="Error")
            {
                MessageBox.Show("Error");
                return response;
            }
           // _logger.Log(response.LogLevel, response.Message);
            return response;
            //_logger.Log(response.LogLevel, response.Message);
            //return StatusCode((int)response.Status, response.obj);
            //return StatusCode((int)response.Status, response.obj);

            //ExcepMesg =  response.obj.ToString();
            //    if (ExcepMesg == "Saved")
            //{
            //    MessageBox.Show(ExcepMesg);

            //}
            //    else
            //{
            //    MessageBox.Show("SomeThing is wrong");
            //    return response;
            //}



            //if (Item.IsDiscount == 1)
            //{
            //    ItemDiscountModel Discount = new ItemDiscountModel();
            //    for (int i = 0; i < gridView1.RowCount; i++)
            //    {
            //        DataRow row = gridView1.GetDataRow(i);
            //        if (row != null)
            //        {

            //            string DiscountType = row.ItemArray[0].ToString();
            //            if (DiscountType == "Value")
            //                Discount.DiscountType = 0;
            //            else if (DiscountType == "Percentage")
            //                Discount.DiscountType = 1;
            //            Discount.ItemId = Item.ItemId;
            //            Discount.TargetQty = Convert.ToInt32(row.ItemArray[3]);
            //            Discount.Percentage = Convert.ToDecimal(row.ItemArray[1].ToString());
            //            Discount.Value = Convert.ToDecimal(row.ItemArray[2].ToString());
            //            Discount.StartDate = Convert.ToDateTime(row.ItemArray[4]);
            //            Discount.EndDate = Convert.ToDateTime(row.ItemArray[5]);
            //            Discount.Remarks = row.ItemArray[6].ToString();
            //        }

            //    }
            //    Itemservice.SaveDiscount(Discount);


            //}



        }




        public void ResetControl()
        {

            //txtItemId.Text = "";
            txtDescription.Text = "";
            ddlCompany.Text = "";
            ddlStore.Text = "";
            ddlPackingType.Text = "";
            txtShelf.Text = "";
            ddlCatagory.Text = "";
            txtretailPrice.Text = "";
            txttradePrice.Text = "";
            txtCortonQty.Text = "";
            txtSaleTax.Text = "";
            txtAdditionTax.Text = "";
            txtPurchaseTax.Text = "";
            txtAltCode.Text = "";
            txtStripQty.Text = "";
            txtreorderQty.Text = "";
            txtPurchaseDiscount.Text = "";
            txtDiscount.SelectedIndex = 0;

            gvdItemDiscount.DataSource = null;

        }

        public void Loadddl()
        {
            DataSet Company = DatabaseConnection.SeclectQuery("select[CompanyId],[Description] from Setup.Company");
            ddlCompany.Properties.DataSource = Company.Tables[0];
            ddlCompany.Properties.DisplayMember = "Description";
            ddlCompany.Properties.ValueMember = "CompanyId";

            DataSet Catagory = DatabaseConnection.SeclectQuery("select [CategoryId],[Description] from Setup.Category");
            ddlCatagory.Properties.DataSource = Catagory.Tables[0];
            ddlCatagory.Properties.DisplayMember = "Description";
            ddlCatagory.Properties.ValueMember = "CategoryId";

            DataSet Store = DatabaseConnection.SeclectQuery("select [StoreId],[Description] from Setup.Store");
            ddlStore.Properties.DataSource = Store.Tables[0];
            ddlStore.Properties.DisplayMember = "Description";
            ddlStore.Properties.ValueMember = "StoreId";

            DataSet PackingType = DatabaseConnection.SeclectQuery("select [packingtypeId],[Description] from Setup.PackingType");
            ddlPackingType.Properties.DataSource = PackingType.Tables[0];
            ddlPackingType.Properties.DisplayMember = "Description";
            ddlPackingType.Properties.ValueMember = "packingtypeId";

        }

        private void CreateDataTable()
        {
            DataTable tbl = new DataTable("ParentTable");

            DataColumn Col = new DataColumn();

            Col.ColumnName = "DiscountType";
            Col.Caption = "DiscountType";
            Col.AutoIncrement = false;
            Col.ReadOnly = false;
            Col.Unique = false;
            tbl.Columns.Add(Col);

            DataColumn Col1 = new DataColumn();
            Col1.ColumnName = "Percentage";
            Col1.Caption = "Percentage";
            Col1.AutoIncrement = false;
            Col1.ReadOnly = false;
            Col1.Unique = false;
            tbl.Columns.Add(Col1);

            DataColumn col2 = new DataColumn();
            col2.ColumnName = "Value";
            col2.Caption = "Value";
            col2.AutoIncrement = false;
            col2.ReadOnly = false;
            col2.Unique = false;
            tbl.Columns.Add(col2);

            DataColumn col3 = new DataColumn();
            col3.ColumnName = "TargetQty";
            col3.Caption = "TargetQty";
            col3.AutoIncrement = false;
            col3.ReadOnly = false;
            col3.Unique = false;
            tbl.Columns.Add(col3);

            DataColumn col4 = new DataColumn();
            col4.ColumnName = "StartDate";
            col4.Caption = "StartDate";
            col4.AutoIncrement = false;
            col4.ReadOnly = false;
            col4.Unique = false;
            tbl.Columns.Add(col4);

            DataColumn col5 = new DataColumn();
            col5.ColumnName = "EndDate";
            col5.Caption = "EndDate";
            col5.AutoIncrement = false;
            col5.ReadOnly = false;
            col5.Unique = false;
            tbl.Columns.Add(col5);

            DataColumn col6 = new DataColumn();
            col6.ColumnName = "Remarks";
            col6.Caption = "Remarks";
            col6.AutoIncrement = false;
            col6.ReadOnly = false;
            col6.Unique = false;
            tbl.Columns.Add(col6);

            ds.Tables.Add(tbl);


        }

        private void txtDiscount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtDiscount.SelectedIndex == 0)
            {
                gvdItemDiscount.Enabled = false;

            }
            if (txtDiscount.SelectedIndex == 1)
            {
                gvdItemDiscount.Enabled = true;

            }

        }

        private void Item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        //private void gridView1_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //   // GridView view = sender as GridView;
        //            if (e.Column.FieldName == "DiscountType")
        //    {
        //       // gvdItemDiscount.DataSource = null;
        //        string Text = e.Value.ToString();
        //        if (Text == "Value")
        //        {
        //            gridView1.Columns[1].OptionsColumn.ReadOnly = true;
        //            gridView1.Columns[1].OptionsColumn.AllowFocus = false;
        //            gridView1.Columns[1].OptionsColumn.TabStop = false;

        //            gridView1.Columns[2].OptionsColumn.ReadOnly = false;
        //            gridView1.Columns[2].OptionsColumn.AllowFocus = true;
        //            gridView1.Columns[2].OptionsColumn.TabStop = true;

        //        }
        //        else if (Text == "Percentage")
        //        {
        //            gridView1.Columns[1].OptionsColumn.ReadOnly = false;
        //            gridView1.Columns[1].OptionsColumn.AllowFocus = true;
        //            gridView1.Columns[1].OptionsColumn.TabStop = true;

        //            gridView1.Columns[2].OptionsColumn.ReadOnly = true;
        //            gridView1.Columns[2].OptionsColumn.AllowFocus = false;
        //            gridView1.Columns[2].OptionsColumn.TabStop = false;

        //        }



        //        gridView1.Columns[3].OptionsColumn.ReadOnly = false;
        //        gridView1.Columns[3].OptionsColumn.AllowFocus = true;
        //        gridView1.Columns[3].OptionsColumn.TabStop = true;

        //        gridView1.Columns[4].OptionsColumn.ReadOnly = false;
        //        gridView1.Columns[4].OptionsColumn.AllowFocus = true;
        //        gridView1.Columns[4].OptionsColumn.TabStop = true;

        //        gridView1.Columns[5].OptionsColumn.ReadOnly = false;
        //        gridView1.Columns[5].OptionsColumn.AllowFocus = true;
        //        gridView1.Columns[5].OptionsColumn.TabStop = true;

        //        gridView1.Columns[6].OptionsColumn.ReadOnly = false;
        //        gridView1.Columns[6].OptionsColumn.AllowFocus = true;
        //        gridView1.Columns[6].OptionsColumn.TabStop = true;

        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            string DiscountType = view.GetRowCellValue(e.RowHandle, gvdDiscountType).ToString();
            if (DiscountType == "")
            {
                e.Valid = false;
                view.SetColumnError(gvdDiscountType, "DiscountType is required");
            }
            if (e.Valid)
            {
                view.ClearColumnErrors();
            }

        }

        //private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    GridView view = sender as GridView;


        //    if(gridView1.RowCount >= 2)
        //    {
        //        for (int i = 0; i < gridView1.RowCount; i++)
        //        {
        //            DataRow row = gridView1.GetDataRow(i);
        //            if (row != null)
        //            {
        //                string DiscountType = view.GetRowCellValue(e.RowHandle, gvdDiscountType).ToString();
        //                if (DiscountType == "Value")
        //                {

        //                    //rgridView1.FocusedColumn.OptionsColumn.ReadOnly
        //                   // row.
        //                    gridView1.Columns[1].OptionsColumn.ReadOnly = true;
        //                    gridView1.Columns[1].OptionsColumn.AllowFocus = false;
        //                    gridView1.Columns[1].OptionsColumn.TabStop = false;

        //                    gridView1.Columns[2].OptionsColumn.ReadOnly = false;
        //                    gridView1.Columns[2].OptionsColumn.AllowFocus = true;
        //                    gridView1.Columns[2].OptionsColumn.TabStop = true;

        //                }
        //                else if (DiscountType == "Percentage")
        //                {
        //                    gridView1.Columns[1].OptionsColumn.ReadOnly = false;
        //                    gridView1.Columns[1].OptionsColumn.AllowFocus = true;
        //                    gridView1.Columns[1].OptionsColumn.TabStop = true;


        //                    gridView1.Columns[2].OptionsColumn.ReadOnly = true;
        //                    gridView1.Columns[2].OptionsColumn.AllowFocus = false;
        //                    gridView1.Columns[2].OptionsColumn.TabStop = false;
        //                }
        //            }
        //        }

        //    }
        //    else
        //        {
        //        string DiscountType = view.GetRowCellValue(e.RowHandle, gvdDiscountType).ToString();
        //        if (DiscountType == "Value")
        //            {
        //                gridView1.Columns[1].OptionsColumn.ReadOnly = true;
        //                gridView1.Columns[1].OptionsColumn.AllowFocus = false;
        //                gridView1.Columns[1].OptionsColumn.TabStop = false;

        //                gridView1.Columns[2].OptionsColumn.ReadOnly = false;
        //                gridView1.Columns[2].OptionsColumn.AllowFocus = true;
        //                gridView1.Columns[2].OptionsColumn.TabStop = true;

        //            }
        //            else if (DiscountType == "Percentage")
        //            {
        //                gridView1.Columns[1].OptionsColumn.ReadOnly = false;
        //                gridView1.Columns[1].OptionsColumn.AllowFocus = true;
        //                gridView1.Columns[1].OptionsColumn.TabStop = true;


        //                gridView1.Columns[2].OptionsColumn.ReadOnly = true;
        //                gridView1.Columns[2].OptionsColumn.AllowFocus = false;
        //                gridView1.Columns[2].OptionsColumn.TabStop = false;
        //            }
        //        }

        //}

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            //if ()
            //{
            //    view.Columns[1].OptionsColumn.ReadOnly = rea
            //}
        }

        private void txtPurchaseDiscount_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        
        //private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    for (int i = 0; i < gridView1.RowCount; i++)
        //    {
        //        DataRow row = gridView1.GetDataRow(i);
        //        if (row != null)
        //            row.
        //        {

        //        }
        //    }
        //}
    }
}