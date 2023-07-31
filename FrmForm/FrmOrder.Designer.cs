
namespace ExmonSystem.Acc
{
    partial class FrmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPrice = new DevExpress.XtraEditors.CalcEdit();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.DgvRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BarcodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DriverIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.NoteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ExCompanyIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.OrderCountCalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.CreatedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForBarcode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDriverId = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.ItemForNote = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExCompanyId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOrderCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreatedDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoteMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExCompanyIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderCountCalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDriverId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExCompanyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrderCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreatedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.TxtPrice);
            this.panel1.Controls.Add(this.TxtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // TxtPrice
            // 
            resources.ApplyResources(this.TxtPrice, "TxtPrice");
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPrice.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtPrice.Properties.Appearance.Font")));
            this.TxtPrice.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtPrice.Properties.Appearance.Options.UseBackColor = true;
            this.TxtPrice.Properties.Appearance.Options.UseFont = true;
            this.TxtPrice.Properties.Appearance.Options.UseForeColor = true;
            this.TxtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtPrice.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtPrice.Properties.Buttons"))))});
            this.TxtPrice.Properties.DisplayFormat.FormatString = "N0";
            this.TxtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPrice.Properties.EditFormat.FormatString = "N0";
            this.TxtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPrice.Properties.Mask.EditMask = resources.GetString("TxtPrice.Properties.Mask.EditMask");
            this.TxtPrice.Properties.NullText = resources.GetString("TxtPrice.Properties.NullText");
            this.TxtPrice.Properties.Precision = 2;
            this.TxtPrice.Properties.ReadOnly = true;
            // 
            // TxtID
            // 
            resources.ApplyResources(this.TxtID, "TxtID");
            this.TxtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
            this.TxtID.Name = "TxtID";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ExmonSystem.Models.Order);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Name = "panel4";
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
            this.DgvRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colExCompanyId,
            this.colOrderCount,
            this.colDriverId,
            this.colCreatedDate});
            this.gridView1.GridControl = this.DgvRecords;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
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
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.layoutControl1);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Name = "panel5";
            // 
            // layoutControl1
            // 
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Controls.Add(this.dataLayoutControl1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            // 
            // dataLayoutControl1
            // 
            resources.ApplyResources(this.dataLayoutControl1, "dataLayoutControl1");
            this.dataLayoutControl1.Controls.Add(this.BarcodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DriverIdLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.NoteMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.ExCompanyIdLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.OrderCountCalcEdit);
            this.dataLayoutControl1.Controls.Add(this.CreatedDateDateEdit);
            this.dataLayoutControl1.DataSource = this.orderBindingSource;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBarcode});
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            // 
            // BarcodeTextEdit
            // 
            resources.ApplyResources(this.BarcodeTextEdit, "BarcodeTextEdit");
            this.BarcodeTextEdit.Name = "BarcodeTextEdit";
            this.BarcodeTextEdit.StyleController = this.dataLayoutControl1;
            // 
            // DriverIdLookUpEdit
            // 
            resources.ApplyResources(this.DriverIdLookUpEdit, "DriverIdLookUpEdit");
            this.DriverIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "DriverId", true));
            this.DriverIdLookUpEdit.EnterMoveNextControl = true;
            this.DriverIdLookUpEdit.Name = "DriverIdLookUpEdit";
            this.DriverIdLookUpEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("DriverIdLookUpEdit.Properties.Appearance.Font")));
            this.DriverIdLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.DriverIdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DriverIdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DriverIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DriverIdLookUpEdit.Properties.Buttons"))))});
            this.DriverIdLookUpEdit.Properties.NullText = resources.GetString("DriverIdLookUpEdit.Properties.NullText");
            this.DriverIdLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.DriverIdLookUpEdit.StyleController = this.dataLayoutControl1;
            // 
            // NoteMemoEdit
            // 
            resources.ApplyResources(this.NoteMemoEdit, "NoteMemoEdit");
            this.NoteMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "Note", true));
            this.NoteMemoEdit.Name = "NoteMemoEdit";
            this.NoteMemoEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("NoteMemoEdit.Properties.Appearance.Font")));
            this.NoteMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.NoteMemoEdit.StyleController = this.dataLayoutControl1;
            this.NoteMemoEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteMemoEdit_KeyDown);
            // 
            // ExCompanyIdLookUpEdit
            // 
            resources.ApplyResources(this.ExCompanyIdLookUpEdit, "ExCompanyIdLookUpEdit");
            this.ExCompanyIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "ExCompanyId", true));
            this.ExCompanyIdLookUpEdit.EnterMoveNextControl = true;
            this.ExCompanyIdLookUpEdit.Name = "ExCompanyIdLookUpEdit";
            this.ExCompanyIdLookUpEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ExCompanyIdLookUpEdit.Properties.Appearance.Font")));
            this.ExCompanyIdLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.ExCompanyIdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ExCompanyIdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ExCompanyIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ExCompanyIdLookUpEdit.Properties.Buttons"))))});
            this.ExCompanyIdLookUpEdit.Properties.NullText = resources.GetString("ExCompanyIdLookUpEdit.Properties.NullText");
            this.ExCompanyIdLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ExCompanyIdLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ExCompanyIdLookUpEdit.EditValueChanged += new System.EventHandler(this.ExCompanyIdLookUpEdit_EditValueChanged_1);
            // 
            // OrderCountCalcEdit
            // 
            resources.ApplyResources(this.OrderCountCalcEdit, "OrderCountCalcEdit");
            this.OrderCountCalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "OrderCount", true));
            this.OrderCountCalcEdit.EnterMoveNextControl = true;
            this.OrderCountCalcEdit.Name = "OrderCountCalcEdit";
            this.OrderCountCalcEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("OrderCountCalcEdit.Properties.Appearance.Font")));
            this.OrderCountCalcEdit.Properties.Appearance.Options.UseFont = true;
            this.OrderCountCalcEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.OrderCountCalcEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OrderCountCalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("OrderCountCalcEdit.Properties.Buttons"))))});
            this.OrderCountCalcEdit.Properties.DisplayFormat.FormatString = "F0";
            this.OrderCountCalcEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.OrderCountCalcEdit.Properties.EditFormat.FormatString = "F0";
            this.OrderCountCalcEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.OrderCountCalcEdit.Properties.Mask.EditMask = resources.GetString("OrderCountCalcEdit.Properties.Mask.EditMask");
            this.OrderCountCalcEdit.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("OrderCountCalcEdit.Properties.Mask.UseMaskAsDisplayFormat")));
            this.OrderCountCalcEdit.Properties.NullText = resources.GetString("OrderCountCalcEdit.Properties.NullText");
            this.OrderCountCalcEdit.StyleController = this.dataLayoutControl1;
            // 
            // CreatedDateDateEdit
            // 
            resources.ApplyResources(this.CreatedDateDateEdit, "CreatedDateDateEdit");
            this.CreatedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "CreatedDate", true));
            this.CreatedDateDateEdit.EnterMoveNextControl = true;
            this.CreatedDateDateEdit.Name = "CreatedDateDateEdit";
            this.CreatedDateDateEdit.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("CreatedDateDateEdit.Properties.Appearance.Font")));
            this.CreatedDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.CreatedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CreatedDateDateEdit.Properties.Buttons"))))});
            this.CreatedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CreatedDateDateEdit.Properties.CalendarTimeProperties.Buttons"))))});
            this.CreatedDateDateEdit.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("CreatedDateDateEdit.Properties.CalendarTimeProperties.Mask.EditMask");
            this.CreatedDateDateEdit.Properties.DisplayFormat.FormatString = "{0:yyyy-MM-dd HH:mm}";
            this.CreatedDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreatedDateDateEdit.Properties.EditFormat.FormatString = "{0:yyyy-MM-dd HH:mm}";
            this.CreatedDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreatedDateDateEdit.Properties.Mask.EditMask = resources.GetString("CreatedDateDateEdit.Properties.Mask.EditMask");
            this.CreatedDateDateEdit.StyleController = this.dataLayoutControl1;
            // 
            // ItemForBarcode
            // 
            resources.ApplyResources(this.ItemForBarcode, "ItemForBarcode");
            this.ItemForBarcode.Control = this.BarcodeTextEdit;
            this.ItemForBarcode.Location = new System.Drawing.Point(0, 24);
            this.ItemForBarcode.Name = "ItemForBarcode";
            this.ItemForBarcode.Size = new System.Drawing.Size(347, 24);
            this.ItemForBarcode.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(491, 509);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDriverId,
            this.simpleSeparator1,
            this.ItemForNote,
            this.ItemForExCompanyId,
            this.ItemForOrderCount,
            this.ItemForCreatedDate});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(471, 489);
            // 
            // ItemForDriverId
            // 
            this.ItemForDriverId.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("ItemForDriverId.AppearanceItemCaption.Font")));
            this.ItemForDriverId.AppearanceItemCaption.Options.UseFont = true;
            resources.ApplyResources(this.ItemForDriverId, "ItemForDriverId");
            this.ItemForDriverId.Control = this.DriverIdLookUpEdit;
            this.ItemForDriverId.Location = new System.Drawing.Point(0, 60);
            this.ItemForDriverId.Name = "ItemForDriverId";
            this.ItemForDriverId.Size = new System.Drawing.Size(471, 30);
            this.ItemForDriverId.TextSize = new System.Drawing.Size(67, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 90);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(471, 1);
            // 
            // ItemForNote
            // 
            this.ItemForNote.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("ItemForNote.AppearanceItemCaption.Font")));
            this.ItemForNote.AppearanceItemCaption.Options.UseFont = true;
            resources.ApplyResources(this.ItemForNote, "ItemForNote");
            this.ItemForNote.Control = this.NoteMemoEdit;
            this.ItemForNote.Location = new System.Drawing.Point(0, 91);
            this.ItemForNote.Name = "ItemForNote";
            this.ItemForNote.Size = new System.Drawing.Size(471, 398);
            this.ItemForNote.StartNewLine = true;
            this.ItemForNote.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForExCompanyId
            // 
            this.ItemForExCompanyId.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("ItemForExCompanyId.AppearanceItemCaption.Font")));
            this.ItemForExCompanyId.AppearanceItemCaption.Options.UseFont = true;
            resources.ApplyResources(this.ItemForExCompanyId, "ItemForExCompanyId");
            this.ItemForExCompanyId.Control = this.ExCompanyIdLookUpEdit;
            this.ItemForExCompanyId.Location = new System.Drawing.Point(0, 0);
            this.ItemForExCompanyId.Name = "ItemForExCompanyId";
            this.ItemForExCompanyId.Size = new System.Drawing.Size(471, 30);
            this.ItemForExCompanyId.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForOrderCount
            // 
            this.ItemForOrderCount.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("ItemForOrderCount.AppearanceItemCaption.Font")));
            this.ItemForOrderCount.AppearanceItemCaption.Options.UseFont = true;
            resources.ApplyResources(this.ItemForOrderCount, "ItemForOrderCount");
            this.ItemForOrderCount.Control = this.OrderCountCalcEdit;
            this.ItemForOrderCount.Location = new System.Drawing.Point(235, 30);
            this.ItemForOrderCount.Name = "ItemForOrderCount";
            this.ItemForOrderCount.Size = new System.Drawing.Size(236, 30);
            this.ItemForOrderCount.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForCreatedDate
            // 
            this.ItemForCreatedDate.AppearanceItemCaption.Font = ((System.Drawing.Font)(resources.GetObject("ItemForCreatedDate.AppearanceItemCaption.Font")));
            this.ItemForCreatedDate.AppearanceItemCaption.Options.UseFont = true;
            resources.ApplyResources(this.ItemForCreatedDate, "ItemForCreatedDate");
            this.ItemForCreatedDate.Control = this.CreatedDateDateEdit;
            this.ItemForCreatedDate.Location = new System.Drawing.Point(0, 30);
            this.ItemForCreatedDate.Name = "ItemForCreatedDate";
            this.ItemForCreatedDate.Size = new System.Drawing.Size(235, 30);
            this.ItemForCreatedDate.TextSize = new System.Drawing.Size(67, 13);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(515, 533);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(495, 513);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnClose.Appearance.Font")));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.tableLayoutPanel2.SetColumnSpan(this.BtnClose, 3);
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnClose.ImageOptions.SvgImage")));
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            resources.ApplyResources(this.BtnDelete, "BtnDelete");
            this.BtnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnDelete.Appearance.Font")));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDelete.ImageOptions.SvgImage")));
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnSave.Appearance.Font")));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSave.ImageOptions.SvgImage")));
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAdd
            // 
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnAdd.Appearance.Font")));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdd.ImageOptions.SvgImage")));
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // FrmOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmTaxValue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoteMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExCompanyIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderCountCalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDriverId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExCompanyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrderCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreatedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl DgvRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Timer timerLoad;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit BarcodeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBarcode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SearchControl TxtSearch;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDriverId;
        private DevExpress.XtraEditors.LookUpEdit DriverIdLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraEditors.MemoEdit NoteMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit ExCompanyIdLookUpEdit;
        private DevExpress.XtraEditors.CalcEdit OrderCountCalcEdit;
        private DevExpress.XtraEditors.DateEdit CreatedDateDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNote;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExCompanyId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOrderCount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCount;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        public DevExpress.XtraEditors.CalcEdit TxtPrice;
    }
}