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
    public partial class Vendor: DevExpress.XtraEditors.XtraForm
    {

        VendorService Vendorservice = new VendorService();
        public Vendor()
        {
            InitializeComponent();
            LoadId();
        }

       

        private void btnsaveandNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVendorId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtVendorId, "VendorId is Required");
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
            if (string.IsNullOrEmpty(txtVendorId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtVendorId, "VendorId is Required");
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
            var Response = Vendorservice.GetId();
            txtVendorId.Text = Response.obj.ToString();
        }

        public void Save()
        {
            VendorModel Vendor = new VendorModel();
            Vendor.VendorId = Convert.ToInt32(txtVendorId.Text);
            Vendor.Description = txtDescription.Text;


            Vendorservice.Save(Vendor);
        }
        public void ResetControl()
        {

            txtVendorId.Text = "";
            txtDescription.Text = "";


        }

        
    }
}