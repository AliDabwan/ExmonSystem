
namespace ExmonSystem.Acc
{
    partial class FrmCustomersDebits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomersDebits));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.designReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.DgvItems = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.accountTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.LblHeader.BackColor = System.Drawing.Color.Teal;
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Name = "LblHeader";
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtSearch, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.simpleButton6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton5, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // simpleButton6
            // 
            resources.ApplyResources(this.simpleButton6, "simpleButton6");
            this.simpleButton6.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton6.Appearance.Font")));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
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
            // simpleButton3
            // 
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BtnNew
            // 
            resources.ApplyResources(this.BtnNew, "BtnNew");
            this.BtnNew.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnNew.Appearance.Font")));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ContextMenuStrip = this.contextMenuStrip1;
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
            // simpleButton5
            // 
            resources.ApplyResources(this.simpleButton5, "simpleButton5");
            this.simpleButton5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton5.Appearance.Font")));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // TxtSearch
            // 
            resources.ApplyResources(this.TxtSearch, "TxtSearch");
            this.TxtSearch.Client = this.DgvItems;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtSearch.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtSearch.Properties.Appearance.Font")));
            this.TxtSearch.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSearch.Properties.Appearance.Options.UseFont = true;
            this.TxtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.TxtSearch.Properties.Client = this.DgvItems;
            this.TxtSearch.Properties.FindDelay = 200;
            this.TxtSearch.SelectedIndexChanged += new System.EventHandler(this.TxtSearch_SelectedIndexChanged);
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
            this.gridView1,
            this.gridView2});
            this.DgvItems.Click += new System.EventHandler(this.DgvItems_Click);
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
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
            this.colAccountPhone.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colAccountAddress
            // 
            resources.ApplyResources(this.colAccountAddress, "colAccountAddress");
            this.colAccountAddress.FieldName = "AccountAddress";
            this.colAccountAddress.Name = "colAccountAddress";
            this.colAccountAddress.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colAccountTaxNumber
            // 
            resources.ApplyResources(this.colAccountTaxNumber, "colAccountTaxNumber");
            this.colAccountTaxNumber.FieldName = "AccountTaxNumber";
            this.colAccountTaxNumber.Name = "colAccountTaxNumber";
            this.colAccountTaxNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridView2
            // 
            resources.ApplyResources(this.gridView2, "gridView2");
            this.gridView2.GridControl = this.DgvItems;
            this.gridView2.Name = "gridView2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // FrmCustomersDebits
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.DgvItems);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmCustomersDebits";
            this.Load += new System.EventHandler(this.FrmCustomersDebits_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem accountTransactionsToolStripMenuItem;
        private DevExpress.XtraEditors.SearchControl TxtSearch;
        private DevExpress.XtraGrid.GridControl DgvItems;
        private System.Windows.Forms.BindingSource accountsTransDTOBindingSource;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}