using DevExpress.XtraEditors;
using hamzITech.NewFolder1;
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


        PurchaseService purchaseService = new PurchaseService();
        public Purchase()
        {
            InitializeComponent();
            Loadddl();
            LoadId();
            txtdate.Text = DateTime.Now.Date.ToString();

        }

        

        public void LoadId()
        {
            
            var    response = purchaseService.GetId();
                //txtItemId.Text = response.obj.ToString();
            if (response.LogLevel.ToString() == "Error")
            {
                MessageBox.Show(response.obj.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}