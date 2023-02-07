
namespace hamzITech.FormProject.Purchase.Purchase
{
    partial class Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnsaveandNew = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ddlCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtretailPrice = new DevExpress.XtraEditors.TextEdit();
            this.gvdPurchaseInvoice = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvdDiscountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdPercetage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdTargetQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdstartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvdRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtretailPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdPurchaseInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnClear);
            this.panelControl2.Controls.Add(this.btnClose);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnsaveandNew);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(668, 23);
            this.panelControl2.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(240, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(179, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save && Close";
            // 
            // btnsaveandNew
            // 
            this.btnsaveandNew.Location = new System.Drawing.Point(-1, 0);
            this.btnsaveandNew.Name = "btnsaveandNew";
            this.btnsaveandNew.Size = new System.Drawing.Size(93, 23);
            this.btnsaveandNew.TabIndex = 1;
            this.btnsaveandNew.TabStop = false;
            this.btnsaveandNew.Text = " Save && New";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Vendor";
            // 
            // ddlCompany
            // 
            this.ddlCompany.Location = new System.Drawing.Point(58, 34);
            this.ddlCompany.Name = "ddlCompany";
            this.ddlCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlCompany.Properties.NullText = "";
            this.ddlCompany.Properties.PopupView = this.searchLookUpEdit1View;
            this.ddlCompany.Size = new System.Drawing.Size(255, 20);
            this.ddlCompany.TabIndex = 4;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(420, 35);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(112, 20);
            this.dateEdit1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(342, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Purchase Date";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(58, 62);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Properties.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(115, 20);
            this.txtItemId.TabIndex = 9;
            this.txtItemId.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "PO #";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(191, 65);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Remarks";
            // 
            // txtretailPrice
            // 
            this.txtretailPrice.Location = new System.Drawing.Point(252, 62);
            this.txtretailPrice.Name = "txtretailPrice";
            this.txtretailPrice.Properties.BeepOnError = false;
            this.txtretailPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtretailPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtretailPrice.Properties.MaskSettings.Set("mask", "f");
            this.txtretailPrice.Size = new System.Drawing.Size(280, 20);
            this.txtretailPrice.TabIndex = 10;
            // 
            // gvdPurchaseInvoice
            // 
            this.gvdPurchaseInvoice.Location = new System.Drawing.Point(-1, 110);
            this.gvdPurchaseInvoice.MainView = this.gridView1;
            this.gvdPurchaseInvoice.Name = "gvdPurchaseInvoice";
            this.gvdPurchaseInvoice.Size = new System.Drawing.Size(669, 408);
            this.gvdPurchaseInvoice.TabIndex = 12;
            this.gvdPurchaseInvoice.UseEmbeddedNavigator = true;
            this.gvdPurchaseInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvdDiscountType,
            this.gvdPercetage,
            this.gvdValue,
            this.gvdTargetQty,
            this.gvdstartDate,
            this.gvdEndDate,
            this.gvdRemark});
            this.gridView1.GridControl = this.gvdPurchaseInvoice;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gvdDiscountType
            // 
            this.gvdDiscountType.Caption = "ItemId";
            repositoryItemComboBox1.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            repositoryItemComboBox1.AutoHeight = false;
            repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemComboBox1.Items.AddRange(new object[] {
            "Value",
            "Percentage"});
            repositoryItemComboBox1.Name = "repositoryItemComboBox2";
            this.gvdDiscountType.ColumnEdit = repositoryItemComboBox1;
            this.gvdDiscountType.FieldName = "ItemId";
            this.gvdDiscountType.Name = "gvdDiscountType";
            this.gvdDiscountType.Visible = true;
            this.gvdDiscountType.VisibleIndex = 0;
            this.gvdDiscountType.Width = 93;
            // 
            // gvdPercetage
            // 
            this.gvdPercetage.Caption = "description";
            this.gvdPercetage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gvdPercetage.FieldName = "Percentage";
            this.gvdPercetage.Name = "gvdPercetage";
            this.gvdPercetage.Visible = true;
            this.gvdPercetage.VisibleIndex = 1;
            this.gvdPercetage.Width = 202;
            // 
            // gvdValue
            // 
            this.gvdValue.Caption = "Value";
            this.gvdValue.FieldName = "Value";
            this.gvdValue.Name = "gvdValue";
            this.gvdValue.Visible = true;
            this.gvdValue.VisibleIndex = 2;
            this.gvdValue.Width = 60;
            // 
            // gvdTargetQty
            // 
            this.gvdTargetQty.Caption = "Target Qty";
            this.gvdTargetQty.FieldName = "TargetQty";
            this.gvdTargetQty.Name = "gvdTargetQty";
            this.gvdTargetQty.Visible = true;
            this.gvdTargetQty.VisibleIndex = 3;
            this.gvdTargetQty.Width = 65;
            // 
            // gvdstartDate
            // 
            this.gvdstartDate.Caption = "Start Date";
            repositoryItemDateEdit1.AutoHeight = false;
            repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.gvdstartDate.ColumnEdit = repositoryItemDateEdit1;
            this.gvdstartDate.DisplayFormat.FormatString = "d";
            this.gvdstartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gvdstartDate.FieldName = "StartDate";
            this.gvdstartDate.Name = "gvdstartDate";
            this.gvdstartDate.Visible = true;
            this.gvdstartDate.VisibleIndex = 4;
            this.gvdstartDate.Width = 65;
            // 
            // gvdEndDate
            // 
            this.gvdEndDate.Caption = "End Date";
            repositoryItemDateEdit2.AutoHeight = false;
            repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.gvdEndDate.ColumnEdit = repositoryItemDateEdit2;
            this.gvdEndDate.FieldName = "EndDate";
            this.gvdEndDate.Name = "gvdEndDate";
            this.gvdEndDate.Visible = true;
            this.gvdEndDate.VisibleIndex = 5;
            this.gvdEndDate.Width = 67;
            // 
            // gvdRemark
            // 
            this.gvdRemark.Caption = "Remarks";
            this.gvdRemark.FieldName = "Remarks";
            this.gvdRemark.Name = "gvdRemark";
            this.gvdRemark.Visible = true;
            this.gvdRemark.VisibleIndex = 6;
            this.gvdRemark.Width = 145;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 516);
            this.Controls.Add(this.gvdPurchaseInvoice);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtretailPrice);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ddlCompany);
            this.Controls.Add(this.panelControl2);
            this.Name = "Purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtretailPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdPurchaseInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemDateEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnsaveandNew;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit ddlCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtItemId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtretailPrice;
        private DevExpress.XtraGrid.GridControl gvdPurchaseInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gvdDiscountType;
        private DevExpress.XtraGrid.Columns.GridColumn gvdPercetage;
        private DevExpress.XtraGrid.Columns.GridColumn gvdValue;
        private DevExpress.XtraGrid.Columns.GridColumn gvdTargetQty;
        private DevExpress.XtraGrid.Columns.GridColumn gvdstartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gvdEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn gvdRemark;
    }
}