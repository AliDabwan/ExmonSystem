
namespace ExmonSystem.Form
{
    partial class FrmCashAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCashAccounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtMAccountID = new System.Windows.Forms.TextBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.accountTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRpt = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.designReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAccountId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvItems = new DevExpress.XtraGrid.GridControl();
            this.accountsTransDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccounttype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.TxtMAccountID);
            this.panel1.Controls.Add(this.LblHeader);
            this.panel1.Name = "panel1";
            // 
            // searchControl1
            // 
            resources.ApplyResources(this.searchControl1, "searchControl1");
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.searchControl1.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("searchControl1.Properties.Appearance.Font")));
            this.searchControl1.Properties.Appearance.Options.UseBackColor = true;
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            // 
            // TxtId
            // 
            resources.ApplyResources(this.TxtId, "TxtId");
            this.TxtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "Id", true));
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(ExmonSystem.Models.Accounts);
            // 
            // TxtMAccountID
            // 
            resources.ApplyResources(this.TxtMAccountID, "TxtMAccountID");
            this.TxtMAccountID.Name = "TxtMAccountID";
            this.TxtMAccountID.ReadOnly = true;
            // 
            // LblHeader
            // 
            resources.ApplyResources(this.LblHeader, "LblHeader");
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Name = "LblHeader";
            // 
            // contextMenuStrip2
            // 
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountTransactionsToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            // 
            // accountTransactionsToolStripMenuItem
            // 
            resources.ApplyResources(this.accountTransactionsToolStripMenuItem, "accountTransactionsToolStripMenuItem");
            this.accountTransactionsToolStripMenuItem.Name = "accountTransactionsToolStripMenuItem";
            this.accountTransactionsToolStripMenuItem.Click += new System.EventHandler(this.accountTransactionsToolStripMenuItem_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Name = "panel2";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Name = "panel6";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.simpleButton3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnRpt, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // simpleButton3
            // 
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BtnNew
            // 
            resources.ApplyResources(this.BtnNew, "BtnNew");
            this.BtnNew.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnNew.Appearance.Font")));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnNew.ImageOptions.SvgImage")));
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnRpt
            // 
            resources.ApplyResources(this.BtnRpt, "BtnRpt");
            this.BtnRpt.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnRpt.Appearance.Font")));
            this.BtnRpt.Appearance.Options.UseFont = true;
            this.BtnRpt.ContextMenuStrip = this.contextMenuStrip1;
            this.BtnRpt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRpt.ImageOptions.SvgImage")));
            this.BtnRpt.Name = "BtnRpt";
            this.BtnRpt.Click += new System.EventHandler(this.BtnNew_Click);
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
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Name = "panel5";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBalance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtAccountId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TxtBalance
            // 
            resources.ApplyResources(this.TxtBalance, "TxtBalance");
            this.TxtBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "balance", true));
            this.TxtBalance.Name = "TxtBalance";
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "AccountName", true));
            this.TxtName.Name = "TxtName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TxtAccountId
            // 
            resources.ApplyResources(this.TxtAccountId, "TxtAccountId");
            this.TxtAccountId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "AccountID", true));
            this.TxtAccountId.Name = "TxtAccountId";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.DgvItems);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Controls.Add(this.simpleButton5);
            this.panel3.Controls.Add(this.flyoutPanel1);
            this.panel3.Name = "panel3";
            // 
            // DgvItems
            // 
            resources.ApplyResources(this.DgvItems, "DgvItems");
            this.DgvItems.ContextMenuStrip = this.contextMenuStrip2;
            this.DgvItems.DataSource = this.accountsTransDTOBindingSource;
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
            // 
            // accountsTransDTOBindingSource
            // 
            this.accountsTransDTOBindingSource.DataSource = typeof(ExmonSystem.Models.AccountsTransDTO);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.SelectedRow.Font")));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountID,
            this.colAccountName,
            this.colAccounttype,
            this.coltotalDebit,
            this.coltotalCredit,
            this.coltotalbalance,
            this.colAccountPhone,
            this.colAccountAddress,
            this.colAccountTaxNumber});
            this.gridView1.GridControl = this.DgvItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colAccountID
            // 
            resources.ApplyResources(this.colAccountID, "colAccountID");
            this.colAccountID.FieldName = "AccountID";
            this.colAccountID.Name = "colAccountID";
            this.colAccountID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colAccountName
            // 
            resources.ApplyResources(this.colAccountName, "colAccountName");
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colAccounttype
            // 
            resources.ApplyResources(this.colAccounttype, "colAccounttype");
            this.colAccounttype.FieldName = "Accounttype";
            this.colAccounttype.Name = "colAccounttype";
            // 
            // coltotalDebit
            // 
            this.coltotalDebit.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("coltotalDebit.AppearanceCell.Font")));
            this.coltotalDebit.AppearanceCell.Options.UseFont = true;
            this.coltotalDebit.AppearanceCell.Options.UseTextOptions = true;
            this.coltotalDebit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalDebit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coltotalDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalDebit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.coltotalDebit, "coltotalDebit");
            this.coltotalDebit.DisplayFormat.FormatString = "N2";
            this.coltotalDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotalDebit.FieldName = "totalDebit";
            this.coltotalDebit.Name = "coltotalDebit";
            this.coltotalDebit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("coltotalDebit.Summary"))), resources.GetString("coltotalDebit.Summary1"), resources.GetString("coltotalDebit.Summary2"))});
            // 
            // coltotalCredit
            // 
            this.coltotalCredit.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("coltotalCredit.AppearanceCell.Font")));
            this.coltotalCredit.AppearanceCell.Options.UseFont = true;
            this.coltotalCredit.AppearanceCell.Options.UseTextOptions = true;
            this.coltotalCredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalCredit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coltotalCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalCredit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.coltotalCredit, "coltotalCredit");
            this.coltotalCredit.DisplayFormat.FormatString = "N2";
            this.coltotalCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotalCredit.FieldName = "totalCredit";
            this.coltotalCredit.Name = "coltotalCredit";
            this.coltotalCredit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("coltotalCredit.Summary"))), resources.GetString("coltotalCredit.Summary1"), resources.GetString("coltotalCredit.Summary2"))});
            // 
            // coltotalbalance
            // 
            this.coltotalbalance.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("coltotalbalance.AppearanceCell.Font")));
            this.coltotalbalance.AppearanceCell.Options.UseFont = true;
            this.coltotalbalance.AppearanceCell.Options.UseTextOptions = true;
            this.coltotalbalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalbalance.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coltotalbalance.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalbalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalbalance.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.coltotalbalance, "coltotalbalance");
            this.coltotalbalance.DisplayFormat.FormatString = "N2";
            this.coltotalbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotalbalance.FieldName = "totalbalance";
            this.coltotalbalance.Name = "coltotalbalance";
            this.coltotalbalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("coltotalbalance.Summary"))), resources.GetString("coltotalbalance.Summary1"), resources.GetString("coltotalbalance.Summary2"))});
            // 
            // colAccountPhone
            // 
            resources.ApplyResources(this.colAccountPhone, "colAccountPhone");
            this.colAccountPhone.FieldName = "AccountPhone";
            this.colAccountPhone.Name = "colAccountPhone";
            // 
            // colAccountAddress
            // 
            resources.ApplyResources(this.colAccountAddress, "colAccountAddress");
            this.colAccountAddress.FieldName = "AccountAddress";
            this.colAccountAddress.Name = "colAccountAddress";
            // 
            // colAccountTaxNumber
            // 
            resources.ApplyResources(this.colAccountTaxNumber, "colAccountTaxNumber");
            this.colAccountTaxNumber.FieldName = "AccountTaxNumber";
            this.colAccountTaxNumber.Name = "colAccountTaxNumber";
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Name = "simpleButton1";
            // 
            // simpleButton5
            // 
            resources.ApplyResources(this.simpleButton5, "simpleButton5");
            this.simpleButton5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton5.Appearance.Font")));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click_1);
            // 
            // flyoutPanel1
            // 
            resources.ApplyResources(this.flyoutPanel1, "flyoutPanel1");
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OptionsBeakPanel.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Slide;
            this.flyoutPanel1.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom;
            this.flyoutPanel1.OptionsBeakPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton()});
            // 
            // flyoutPanelControl1
            // 
            resources.ApplyResources(this.flyoutPanelControl1, "flyoutPanelControl1");
            this.flyoutPanelControl1.Controls.Add(this.tableLayoutPanel4);
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Name = "panel4";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.BtnClose, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnClose.Appearance.Font")));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnClose.ImageOptions.SvgImage")));
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox4.Name = "textBox4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // FrmCashAccounts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCashAccounts";
            this.Load += new System.EventHandler(this.FrmCashAccounts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAccountId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtMAccountID;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton BtnRpt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem designReportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem accountTransactionsToolStripMenuItem;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl DgvItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccounttype;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalDebit;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalCredit;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalbalance;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTaxNumber;
        private System.Windows.Forms.BindingSource accountsTransDTOBindingSource;
        private System.Windows.Forms.BindingSource accountsBindingSource;
    }
}