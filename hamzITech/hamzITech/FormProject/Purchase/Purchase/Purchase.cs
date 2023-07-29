using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace hamzITech.FormProject.Purchase.Purchase
{
    public partial class Purchase : DevExpress.XtraEditors.XtraForm
    {

        DataSet ds = new DataSet();
        PurchaseService purchaseService = new PurchaseService();
        public Purchase()
        {
            InitializeComponent();
            Loadddl();
            LoadId();
            txtdate.Text = DateTime.Now.Date.ToString();
            CreateDataTable();
            gvdPurchaseInvoice.DataSource = ds.Tables[0];


            //grdPurchase.DataSource = ds.Tables[];

        }


        private void CreateDataTable()
        {
            DataTable tbl = new DataTable("ParentTable");

            DataColumn Col = new DataColumn();

            Col.ColumnName = "ItemId";
            Col.Caption = "ItemId";
            Col.AutoIncrement = false;
            Col.ReadOnly = false;
            Col.Unique = false;
            tbl.Columns.Add(Col);

            DataColumn Col1 = new DataColumn();
            Col1.ColumnName = "Description";
            Col1.Caption = "Description";
            Col1.AutoIncrement = false;
            Col1.ReadOnly = false;
            Col1.Unique = false;
            tbl.Columns.Add(Col1);

            DataColumn col2 = new DataColumn();
            col2.ColumnName = "ExpiryDate";
            col2.Caption = "ExpiryDate";
            col2.AutoIncrement = false;
            col2.ReadOnly = false;
            col2.Unique = false;
            tbl.Columns.Add(col2);

            DataColumn col3 = new DataColumn();
            col3.ColumnName = "PurchaseQty";
            col3.Caption = "PurchaseQty";
            col3.AutoIncrement = false;
            col3.ReadOnly = false;
            col3.Unique = false;
            tbl.Columns.Add(col3);

            DataColumn col4 = new DataColumn();
            col4.ColumnName = "PurchaseRate";
            col4.Caption = "PurchaseRate";
            col4.AutoIncrement = false;
            col4.ReadOnly = false;
            col4.Unique = false;
            tbl.Columns.Add(col4);

            DataColumn col5 = new DataColumn();
            col5.ColumnName = "SaleRate";
            col5.Caption = "SaleRate";
            col5.AutoIncrement = false;
            col5.ReadOnly = false;
            col5.Unique = false;
            tbl.Columns.Add(col5);

            DataColumn col6 = new DataColumn();
            col6.ColumnName = "PurchaseTax";
            col6.Caption = "PurchaseTax";
            col6.AutoIncrement = false;
            col6.ReadOnly = false;
            col6.Unique = false;
            tbl.Columns.Add(col6);

            DataColumn col7 = new DataColumn();
            col7.ColumnName = "AdditionTax";
            col7.Caption = "AdditionTax";
            col7.AutoIncrement = false;
            col7.ReadOnly = false;
            col7.Unique = false;
            tbl.Columns.Add(col7);

            DataColumn col8 = new DataColumn();
            col8.ColumnName = "TotalAmount";
            col8.Caption = "TotalAmount";
            col8.AutoIncrement = false;
            col8.ReadOnly = false;
            col8.Unique = false;
            tbl.Columns.Add(col8);

            ds.Tables.Add(tbl);


        }



        public void LoadId()
        {

            var response = purchaseService.GetId();
            //txtItemId.Text = response.obj.ToString();
            if (response.LogLevel.ToString() == "Error")
            {
                MessageBox.Show(response.obj.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txtIPurchaseId.Text = response.obj.ToString();
            }



        }

        public void Loadddl()
        {

            DataSet Vendor = DatabaseConnection.SeclectQuery("select[VendorId],[Description] from Setup.Vendor");
            ddlVendor.Properties.DataSource = Vendor.Tables[0];
            ddlVendor.Properties.DisplayMember = "Description";
            ddlVendor.Properties.ValueMember = "VendorId";



            DataSet Product = DatabaseConnection.SeclectQuery("select ItemId,Description,RetailPrice,PurchaseDiscount from Setup.Item");
            repositoryItemSearchLookUpEdit1.DataSource = Product.Tables[0];
            repositoryItemSearchLookUpEdit1.DisplayMember = "Description";
            repositoryItemSearchLookUpEdit1.ValueMember = "ItemId";

            //ddlCatagory.Properties.DataSource = Catagory.Tables[0];
            //ddlCatagory.Properties.DisplayMember = "Description";
            //ddlCatagory.Properties.ValueMember = "CategoryId";

            //DataSet Store = DatabaseConnection.SeclectQuery("select [StoreId],[Description] from Setup.Store");
            //ddlStore.Properties.DataSource = Store.Tables[0];
            //ddlStore.Properties.DisplayMember = "Description";
            //ddlStore.Properties.ValueMember = "StoreId";

            //DataSet PackingType = DatabaseConnection.SeclectQuery("select [packingtypeId],[Description] from Setup.PackingType");
            //ddlPackingType.Properties.DataSource = PackingType.Tables[0];
            //ddlPackingType.Properties.DisplayMember = "Description";
            //ddlPackingType.Properties.ValueMember = "packingtypeId";

        }

        private void gvdPurchaseInvoice_Click(object sender, EventArgs e)
        {

        }

        private void grdPurchase_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            PurchaseModel purchase = new PurchaseModel();
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Description")
            {
                for (int i = 0; i < grdPurchase.RowCount; i++)
                {
                    DataRow row = grdPurchase.GetDataRow(i);
                    if (row != null)
                    {
                        purchase.ItemId = Convert.ToInt32(row.ItemArray[2]);

                    }
                }
            }
        }
    }
}