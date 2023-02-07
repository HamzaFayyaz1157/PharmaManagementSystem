using DevExpress.XtraEditors;
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

namespace hamzITech.FormProject
{
    public partial class Store : DevExpress.XtraEditors.XtraForm
    {

        StoreService Storeservice = new StoreService();
        public Store()
        {
            InitializeComponent();
            LoadId();
        }

        

        private void btnsaveandNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStoreId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtStoreId, "StoreId is Required");
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtDescription, "Description is Required");
                return;
            }
            Save();
            ResetControl();
            LoadId();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStoreId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtStoreId, "StoreId is Required");
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtDescription, "Description is Required");
                return;
            }
            Save();
            this.Close();
        }
        public void LoadId()
        {
            var Response = Storeservice.GetId();
            txtStoreId.Text = Response.obj.ToString();
        }

        public void Save()
        {
            StoreModel Store = new StoreModel();
            Store.StoreId = Convert.ToInt32(txtStoreId.Text);
            Store.Description = txtDescription.Text;
            Store.Location = txtLocation.Text;

            Storeservice.Save(Store);
        }
        public void ResetControl()
        {

            txtStoreId.Text = "";
            txtDescription.Text = "";
            txtLocation.Text = "";


        }

        
    }
}