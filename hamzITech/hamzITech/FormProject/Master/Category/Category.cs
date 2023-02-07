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
    public partial class Category : DevExpress.XtraEditors.XtraForm
    {

        CategoryService Categoryservice = new CategoryService();
        public Category()
        {
            InitializeComponent();
            LoadId();
        }

       

        private void btnsaveandNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtCategoryId, "CategoryId is Required");
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
            if (string.IsNullOrEmpty(txtCategoryId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtCategoryId, "CategoryId is Required");
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
            var Response = Categoryservice.GetId();
            txtCategoryId.Text = Response.obj.ToString();
        }

        public void Save()
        {
            CategoryModel Category = new CategoryModel();
            Category.CategoryId = Convert.ToInt32(txtCategoryId.Text);
            Category.Description = txtDescription.Text;


            Categoryservice.Save(Category);
        }
        public void ResetControl()
        {

            txtCategoryId.Text = "";
            txtDescription.Text = "";


        }

        
    }
}