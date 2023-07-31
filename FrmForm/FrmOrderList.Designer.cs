
namespace ExmonSystem.Acc
{
    partial class FrmOrderList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderList));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.DgvRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ExmonSystem.Models.Order);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.TxtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvRecords, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // TxtSearch
            // 
            resources.ApplyResources(this.TxtSearch, "TxtSearch");
            this.TxtSearch.Client = this.DgvRecords;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtSearch.Properties.Appearance.Font")));
            this.TxtSearch.Properties.Appearance.Options.UseFont = true;
            this.TxtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.TxtSearch.Properties.Client = this.DgvRecords;
            this.TxtSearch.Properties.FindDelay = 500;
            // 
            // DgvRecords
            // 
            resources.ApplyResources(this.DgvRecords, "DgvRecords");
            this.DgvRecords.DataSource = this.orderBindingSource;
            this.DgvRecords.EmbeddedNavigator.AccessibleDescription = resources.GetString("DgvRecords.EmbeddedNavigator.AccessibleDescription");
            this.DgvRecords.EmbeddedNavigator.AccessibleName = resources.GetString("DgvRecords.EmbeddedNavigator.AccessibleName");
            this.DgvRecords.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("DgvRecords.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.DgvRecords.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("DgvRecords.EmbeddedNavigator.Anchor")));
            this.DgvRecords.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DgvRecords.EmbeddedNavigator.BackgroundImage")));
            this.DgvRecords.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("DgvRecords.EmbeddedNavigator.BackgroundImageLayout")));
            this.DgvRecords.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("DgvRecords.EmbeddedNavigator.ImeMode")));
            this.DgvRecords.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("DgvRecords.EmbeddedNavigator.MaximumSize")));
            this.DgvRecords.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("DgvRecords.EmbeddedNavigator.TextLocation")));
            this.DgvRecords.EmbeddedNavigator.ToolTip = resources.GetString("DgvRecords.EmbeddedNavigator.ToolTip");
            this.DgvRecords.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("DgvRecords.EmbeddedNavigator.ToolTipIconType")));
            this.DgvRecords.EmbeddedNavigator.ToolTipTitle = resources.GetString("DgvRecords.EmbeddedNavigator.ToolTipTitle");
            this.DgvRecords.MainView = this.gridView1;
            this.DgvRecords.Name = "DgvRecords";
            this.DgvRecords.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.DgvRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colExCompanyId,
            this.colOrderCount,
            this.colDriverId,
            this.colCreatedDate,
            this.gridColumnPrint});
            this.gridView1.GridControl = this.DgvRecords;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colId.Summary"))), resources.GetString("colId.Summary1"), resources.GetString("colId.Summary2"))});
            // 
            // colExCompanyId
            // 
            resources.ApplyResources(this.colExCompanyId, "colExCompanyId");
            this.colExCompanyId.FieldName = "ExCompany.Name";
            this.colExCompanyId.Name = "colExCompanyId";
            this.colExCompanyId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colOrderCount
            // 
            resources.ApplyResources(this.colOrderCount, "colOrderCount");
            this.colOrderCount.FieldName = "OrderCount";
            this.colOrderCount.Name = "colOrderCount";
            this.colOrderCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colDriverId
            // 
            resources.ApplyResources(this.colDriverId, "colDriverId");
            this.colDriverId.FieldName = "Driver.Name";
            this.colDriverId.Name = "colDriverId";
            this.colDriverId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colCreatedDate
            // 
            resources.ApplyResources(this.colCreatedDate, "colCreatedDate");
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridColumnPrint
            // 
            resources.ApplyResources(this.gridColumnPrint, "gridColumnPrint");
            this.gridColumnPrint.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumnPrint.Name = "gridColumnPrint";
            this.gridColumnPrint.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            this.gridColumnPrint.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // repositoryItemButtonEdit1
            // 
            resources.ApplyResources(this.repositoryItemButtonEdit1, "repositoryItemButtonEdit1");
            editorButtonImageOptions1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            resources.ApplyResources(editorButtonImageOptions1, "editorButtonImageOptions1");
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(30, 25);
            resources.ApplyResources(serializableAppearanceObject1, "serializableAppearanceObject1");
            serializableAppearanceObject1.Options.UseFont = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), resources.GetString("repositoryItemButtonEdit1.Buttons1"), ((int)(resources.GetObject("repositoryItemButtonEdit1.Buttons2"))), ((bool)(resources.GetObject("repositoryItemButtonEdit1.Buttons3"))), ((bool)(resources.GetObject("repositoryItemButtonEdit1.Buttons4"))), ((bool)(resources.GetObject("repositoryItemButtonEdit1.Buttons5"))), editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, resources.GetString("repositoryItemButtonEdit1.Buttons6"), ((object)(resources.GetObject("repositoryItemButtonEdit1.Buttons7"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("repositoryItemButtonEdit1.Buttons8"))), ((DevExpress.Utils.ToolTipAnchor)(resources.GetObject("repositoryItemButtonEdit1.Buttons9"))))});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnClose.Appearance.Font")));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnClose.ImageOptions.SvgImage")));
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.BtnClose, 2, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // FrmOrderList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmOrderList";
            this.Load += new System.EventHandler(this.FrmTaxValue_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl DgvRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SearchControl TxtSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colExCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCount;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}