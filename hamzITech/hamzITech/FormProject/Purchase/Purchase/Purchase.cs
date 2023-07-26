using DevExpress.XtraEditors;
using hamzITech.NewFolder1;
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
        public Purchase()
        {
            InitializeComponent();
            Loadddl();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        public void Loadddl()
        {

            DataSet Vendor = DatabaseConnection.SeclectQuery("select[VendorId],[Description] from Setup.Vendor");
            ddlVendor.Properties.DataSource = Vendor.Tables[0];
            ddlVendor.Properties.DisplayMember = "Description";
            ddlVendor.Properties.ValueMember = "VendorId";

            //DataSet Catagory = DatabaseConnection.SeclectQuery("select [CategoryId],[Description] from Setup.Category");
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