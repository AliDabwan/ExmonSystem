
namespace ExmonSystem.Acc
{
    partial class FrmOrdersRpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdersRpt));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.TxtGover = new DevExpress.XtraEditors.LookUpEdit();
            this.radioFilter = new DevExpress.XtraEditors.RadioGroup();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.designReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.DgvItems = new DevExpress.XtraGrid.GridControl();
            this.orderDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidStatue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDateTo = new DevExpress.XtraEditors.DateEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LblALL = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtProfitNet = new DevExpress.XtraEditors.TextEdit();
            this.TxtTotalAll = new DevExpress.XtraEditors.TextEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioFilter.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProfitNet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalAll.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.LblHeader);
            this.panel1.Name = "panel1";
            // 
            // LblHeader
            // 
            resources.ApplyResources(this.LblHeader, "LblHeader");
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Name = "LblHeader";
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.TxtGover);
            this.panelControl2.Controls.Add(this.radioFilter);
            this.panelControl2.Name = "panelControl2";
            // 
            // TxtGover
            // 
            resources.ApplyResources(this.TxtGover, "TxtGover");
            this.TxtGover.EnterMoveNextControl = true;
            this.TxtGover.Name = "TxtGover";
            this.TxtGover.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.TxtGover.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TxtGover.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtGover.Properties.Appearance.Font")));
            this.TxtGover.Properties.Appearance.Options.UseFont = true;
            this.TxtGover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtGover.Properties.Buttons"))))});
            this.TxtGover.Properties.NullText = resources.GetString("TxtGover.Properties.NullText");
            this.TxtGover.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.TxtGover.TabStop = false;
            this.TxtGover.EditValueChanged += new System.EventHandler(this.TxtGover_EditValueChanged);
            // 
            // radioFilter
            // 
            resources.ApplyResources(this.radioFilter, "radioFilter");
            this.radioFilter.Name = "radioFilter";
            this.radioFilter.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioFilter.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("radioFilter.Properties.Appearance.Font")));
            this.radioFilter.Properties.Appearance.Options.UseBackColor = true;
            this.radioFilter.Properties.Appearance.Options.UseFont = true;
            this.radioFilter.Properties.Columns = 4;
            this.radioFilter.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioFilter.Properties.Items"))), resources.GetString("radioFilter.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioFilter.Properties.Items2"))), resources.GetString("radioFilter.Properties.Items3"))});
            this.radioFilter.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioFilter.SelectedIndexChanged += new System.EventHandler(this.RadioFilter_SelectedIndexChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Name = "panel2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnClose.Appearance.Font")));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnClose.ImageOptions.SvgImage")));
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnNew
            // 
            resources.ApplyResources(this.BtnNew, "BtnNew");
            this.BtnNew.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnNew.Appearance.Font")));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ContextMenuStrip = this.contextMenuStrip1;
            this.BtnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnNew.ImageOptions.SvgImage")));
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designReportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // designReportToolStripMenuItem
            // 
            resources.ApplyResources(this.designReportToolStripMenuItem, "designReportToolStripMenuItem");
            this.designReportToolStripMenuItem.Name = "designReportToolStripMenuItem";
            this.designReportToolStripMenuItem.Click += new System.EventHandler(this.designReportToolStripMenuItem_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.TxtSearch);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.radioGroup1);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.TxtDateFrom);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.TxtDateTo);
            this.panelControl1.Name = "panelControl1";
            // 
            // TxtSearch
            // 
            resources.ApplyResources(this.TxtSearch, "TxtSearch");
            this.TxtSearch.Client = this.DgvItems;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtSearch.Properties.Appearance.Font")));
            this.TxtSearch.Properties.Appearance.Options.UseFont = true;
            this.TxtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.TxtSearch.Properties.Client = this.DgvItems;
            // 
            // DgvItems
            // 
            resources.ApplyResources(this.DgvItems, "DgvItems");
            this.DgvItems.DataSource = this.orderDtoBindingSource;
            this.DgvItems.EmbeddedNavigator.AccessibleDescription = resources.GetString("DgvItems.EmbeddedNavigator.AccessibleDescription");
            this.DgvItems.EmbeddedNavigator.AccessibleName = resources.GetString("DgvItems.EmbeddedNavigator.AccessibleName");
            this.DgvItems.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("DgvItems.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.DgvItems.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("DgvItems.EmbeddedNavigator.Anchor")));
            this.DgvItems.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DgvItems.EmbeddedNavigator.BackgroundImage")));
            this.DgvItems.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("DgvItems.EmbeddedNavigator.BackgroundImageLayout")));
            this.DgvItems.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("DgvItems.EmbeddedNavigator.ImeMode")));
            this.DgvItems.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("DgvItems.EmbeddedNavigator.MaximumSize")));
            this.DgvItems.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("DgvItems.EmbeddedNavigator.TextLocation")));
            this.DgvItems.EmbeddedNavigator.ToolTip = resources.GetString("DgvItems.EmbeddedNavigator.ToolTip");
            this.DgvItems.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("DgvItems.EmbeddedNavigator.ToolTipIconType")));
            this.DgvItems.EmbeddedNavigator.ToolTipTitle = resources.GetString("DgvItems.EmbeddedNavigator.ToolTipTitle");
            this.DgvItems.MainView = this.gridView1;
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DgvItems.Click += new System.EventHandler(this.DgvItems_Click_1);
            // 
            // orderDtoBindingSource
            // 
            this.orderDtoBindingSource.DataSource = typeof(ExmonSystem.Models.OrderDto);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.HeaderPanel.Font")));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.SelectedRow.Font")));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCreatedDate,
            this.colExCompanyId,
            this.colDriverId,
            this.colOrderCount,
            this.colPaidStatue,
            this.colPaidDate,
            this.colPrice,
            this.colTotalAmount,
            this.colTotalPaid});
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "FormatIsEnd";
            formatConditionRuleValue3.AllowAnimation = DevExpress.Utils.DefaultBoolean.True;
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Expression = "[IsGoToEndStatue] = True";
            formatConditionRuleValue3.PredefinedName = "Green Bold Text";
            formatConditionRuleValue3.Value1 = "True";
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Name = "Format0";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Expression = "[IsReturnToStoreStatue] = True";
            formatConditionRuleValue4.PredefinedName = "Red Bold Text";
            formatConditionRuleValue4.Value1 = true;
            gridFormatRule4.Rule = formatConditionRuleValue4;
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.FormatRules.Add(gridFormatRule4);
            this.gridView1.GridControl = this.DgvItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowHeight = 30;
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
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
            // colExCompanyId
            // 
            resources.ApplyResources(this.colExCompanyId, "colExCompanyId");
            this.colExCompanyId.FieldName = "CompanyName";
            this.colExCompanyId.Name = "colExCompanyId";
            this.colExCompanyId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colDriverId
            // 
            resources.ApplyResources(this.colDriverId, "colDriverId");
            this.colDriverId.FieldName = "DriverName";
            this.colDriverId.Name = "colDriverId";
            this.colDriverId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
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
            // colPaidStatue
            // 
            resources.ApplyResources(this.colPaidStatue, "colPaidStatue");
            this.colPaidStatue.FieldName = "PaidStatue";
            this.colPaidStatue.Name = "colPaidStatue";
            this.colPaidStatue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colPaidDate
            // 
            resources.ApplyResources(this.colPaidDate, "colPaidDate");
            this.colPaidDate.FieldName = "PaidDate";
            this.colPaidDate.Name = "colPaidDate";
            this.colPaidDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colPrice
            // 
            resources.ApplyResources(this.colPrice, "colPrice");
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colTotalAmount
            // 
            resources.ApplyResources(this.colTotalAmount, "colTotalAmount");
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colTotalPaid
            // 
            resources.ApplyResources(this.colTotalPaid, "colTotalPaid");
            this.colTotalPaid.FieldName = "TotalPaid";
            this.colTotalPaid.Name = "colTotalPaid";
            this.colTotalPaid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // simpleButton3
            // 
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // radioGroup1
            // 
            resources.ApplyResources(this.radioGroup1, "radioGroup1");
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("radioGroup1.Properties.Appearance.Font")));
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Columns = 4;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items"))), resources.GetString("radioGroup1.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items2"))), resources.GetString("radioGroup1.Properties.Items3")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items4"))), resources.GetString("radioGroup1.Properties.Items5"))});
            this.radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TxtDateFrom
            // 
            resources.ApplyResources(this.TxtDateFrom, "TxtDateFrom");
            this.TxtDateFrom.Name = "TxtDateFrom";
            this.TxtDateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtDateFrom.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtDateFrom.Properties.Appearance.Font")));
            this.TxtDateFrom.Properties.Appearance.Options.UseFont = true;
            this.TxtDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtDateFrom.Properties.Buttons"))))});
            this.TxtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtDateFrom.Properties.CalendarTimeProperties.Buttons"))))});
            this.TxtDateFrom.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("TxtDateFrom.Properties.CalendarTimeProperties.Mask.EditMask");
            this.TxtDateFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.TxtDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDateFrom.Properties.Mask.EditMask = resources.GetString("TxtDateFrom.Properties.Mask.EditMask");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TxtDateTo
            // 
            resources.ApplyResources(this.TxtDateTo, "TxtDateTo");
            this.TxtDateTo.Name = "TxtDateTo";
            this.TxtDateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtDateTo.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtDateTo.Properties.Appearance.Font")));
            this.TxtDateTo.Properties.Appearance.Options.UseFont = true;
            this.TxtDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtDateTo.Properties.Buttons"))))});
            this.TxtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtDateTo.Properties.CalendarTimeProperties.Buttons"))))});
            this.TxtDateTo.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("TxtDateTo.Properties.CalendarTimeProperties.Mask.EditMask");
            this.TxtDateTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.TxtDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDateTo.Properties.Mask.EditMask = resources.GetString("TxtDateTo.Properties.Mask.EditMask");
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Name = "panel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.LblALL, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtProfitNet, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.TxtTotalAll, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // LblALL
            // 
            resources.ApplyResources(this.LblALL, "LblALL");
            this.LblALL.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("LblALL.Appearance.Font")));
            this.LblALL.Appearance.Options.UseFont = true;
            this.LblALL.Appearance.Options.UseTextOptions = true;
            this.LblALL.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblALL.Name = "LblALL";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Name = "labelControl3";
            // 
            // TxtProfitNet
            // 
            resources.ApplyResources(this.TxtProfitNet, "TxtProfitNet");
            this.TxtProfitNet.EnterMoveNextControl = true;
            this.TxtProfitNet.Name = "TxtProfitNet";
            this.TxtProfitNet.Properties.AllowFocused = false;
            this.TxtProfitNet.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtProfitNet.Properties.Appearance.Font")));
            this.TxtProfitNet.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.TxtProfitNet.Properties.Appearance.Options.UseFont = true;
            this.TxtProfitNet.Properties.Appearance.Options.UseForeColor = true;
            this.TxtProfitNet.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtProfitNet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtProfitNet.Properties.ReadOnly = true;
            this.TxtProfitNet.TabStop = false;
            // 
            // TxtTotalAll
            // 
            resources.ApplyResources(this.TxtTotalAll, "TxtTotalAll");
            this.TxtTotalAll.EnterMoveNextControl = true;
            this.TxtTotalAll.Name = "TxtTotalAll";
            this.TxtTotalAll.Properties.AllowFocused = false;
            this.TxtTotalAll.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtTotalAll.Properties.Appearance.Font")));
            this.TxtTotalAll.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.TxtTotalAll.Properties.Appearance.Options.UseFont = true;
            this.TxtTotalAll.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTotalAll.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTotalAll.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtTotalAll.Properties.ReadOnly = true;
            this.TxtTotalAll.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.DgvItems, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // contextMenuStrip2
            // 
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // FrmOrdersRpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmOrdersRpt";
            this.Load += new System.EventHandler(this.FrmCustomersList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtGover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioFilter.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProfitNet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalAll.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem designReportToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl DgvItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchControl TxtSearch;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit TxtDateFrom;
        private DevExpress.XtraEditors.DateEdit TxtDateTo;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LookUpEdit TxtGover;
        private DevExpress.XtraEditors.RadioGroup radioFilter;
        private DevExpress.XtraEditors.LabelControl LblALL;
        private DevExpress.XtraEditors.TextEdit TxtTotalAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtProfitNet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidStatue;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPaid;
        private System.Windows.Forms.BindingSource orderDtoBindingSource;
    }
}