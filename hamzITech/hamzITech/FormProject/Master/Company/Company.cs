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
    public partial class Company : DevExpress.XtraEditors.XtraForm
    {

        CompanyService Companyservice = new CompanyService();
        public Company()
        {
            InitializeComponent();
            LoadId();
        }

       

        private void btnsaveandNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtCompanyId, "CompanyId is Required");
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
            if (string.IsNullOrEmpty(txtCompanyId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtCompanyId, "CompanyId is Required");
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
            var Response = Companyservice.GetId();
            txtCompanyId.Text = Response.obj.ToString();
        }

        public void Save()
        {
            CompanyModel Company = new CompanyModel();
            Company.CompanyId = Convert.ToInt32(txtCompanyId.Text);
            Company.Description = txtDescription.Text;


            Companyservice.Save(Company);
        }
        public void ResetControl()
        {

            txtCompanyId.Text = "";
            txtDescription.Text = "";


        }

        
    }
}