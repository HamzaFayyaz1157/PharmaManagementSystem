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
    public partial class PackingType : DevExpress.XtraEditors.XtraForm
    {

        PackingTypeService PackingTypeservice = new PackingTypeService();
        public PackingType()
        {
            InitializeComponent();
            LoadId();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsaveandNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPackingTypeId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtPackingTypeId, "PackingTypeId is Required");
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
            if (string.IsNullOrEmpty(txtPackingTypeId.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtPackingTypeId, "PackingTypeId is Required");
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
            var Response = PackingTypeservice.GetId();
            txtPackingTypeId.Text = Response.obj.ToString();
        }

        public void Save()
        {
            PackingTypeModel PackingType = new PackingTypeModel();
            PackingType.PackingTypeId = Convert.ToInt32(txtPackingTypeId.Text);
            PackingType.Description = txtDescription.Text;


            PackingTypeservice.Save(PackingType);
        }
        public void ResetControl()
        {

            txtPackingTypeId.Text = "";
            txtDescription.Text = "";


        }

        
    }
}