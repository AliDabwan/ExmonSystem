
namespace ExmonSystem
{
    partial class FrmAccountTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountTransactions));
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvItems = new DevExpress.XtraGrid.GridControl();
            this.accountsTransactionSubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransRefType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransRefTypeAr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransRefId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransRefNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailsNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntryType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTotalBalance = new System.Windows.Forms.TextBox();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.designReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RdToday = new System.Windows.Forms.RadioButton();
            this.rdDates = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDateTo = new DevExpress.XtraEditors.DateEdit();
            this.BtnShow = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransactionSubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.DgvItems);
            this.panel2.Name = "panel2";
            // 
            // DgvItems
            // 
            resources.ApplyResources(this.DgvItems, "DgvItems");
            this.DgvItems.DataSource = this.accountsTransactionSubBindingSource;
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
            // accountsTransactionSubBindingSource
            // 
            this.accountsTransactionSubBindingSource.DataSource = typeof(ExmonSystem.Models.AccountsTransactionSub);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.SelectedRow.Font")));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransId,
            this.colTransRefType,
            this.colTransRefTypeAr,
            this.colTransRefId,
            this.colTransRefNo,
            this.colTransDate,
            this.colUserId,
            this.colEntryId,
            this.colDetailsNote,
            this.colAccountID,
            this.colAccountName,
            this.colEntryType,
            this.colFromAmount,
            this.colToAmount,
            this.colAmountText,
            this.colAccount,
            this.colUser,
            this.gridColumn1});
            this.gridView1.GridControl = this.DgvItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colTransId
            // 
            resources.ApplyResources(this.colTransId, "colTransId");
            this.colTransId.FieldName = "TransId";
            this.colTransId.Name = "colTransId";
            this.colTransId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colTransRefType
            // 
            resources.ApplyResources(this.colTransRefType, "colTransRefType");
            this.colTransRefType.FieldName = "TransRefType";
            this.colTransRefType.Name = "colTransRefType";
            // 
            // colTransRefTypeAr
            // 
            resources.ApplyResources(this.colTransRefTypeAr, "colTransRefTypeAr");
            this.colTransRefTypeAr.FieldName = "TransRefTypeAr";
            this.colTransRefTypeAr.Name = "colTransRefTypeAr";
            // 
            // colTransRefId
            // 
            resources.ApplyResources(this.colTransRefId, "colTransRefId");
            this.colTransRefId.FieldName = "TransRefId";
            this.colTransRefId.Name = "colTransRefId";
            // 
            // colTransRefNo
            // 
            resources.ApplyResources(this.colTransRefNo, "colTransRefNo");
            this.colTransRefNo.FieldName = "TransRefNo";
            this.colTransRefNo.Name = "colTransRefNo";
            // 
            // colTransDate
            // 
            resources.ApplyResources(this.colTransDate, "colTransDate");
            this.colTransDate.FieldName = "TransDate";
            this.colTransDate.Name = "colTransDate";
            // 
            // colUserId
            // 
            resources.ApplyResources(this.colUserId, "colUserId");
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            // 
            // colEntryId
            // 
            resources.ApplyResources(this.colEntryId, "colEntryId");
            this.colEntryId.FieldName = "EntryId";
            this.colEntryId.Name = "colEntryId";
            // 
            // colDetailsNote
            // 
            resources.ApplyResources(this.colDetailsNote, "colDetailsNote");
            this.colDetailsNote.FieldName = "DetailsNote";
            this.colDetailsNote.Name = "colDetailsNote";
            // 
            // colAccountID
            // 
            resources.ApplyResources(this.colAccountID, "colAccountID");
            this.colAccountID.FieldName = "AccountID";
            this.colAccountID.Name = "colAccountID";
            // 
            // colAccountName
            // 
            resources.ApplyResources(this.colAccountName, "colAccountName");
            this.colAccountName.FieldName = "Account.AccountName";
            this.colAccountName.MinWidth = 80;
            this.colAccountName.Name = "colAccountName";
            // 
            // colEntryType
            // 
            resources.ApplyResources(this.colEntryType, "colEntryType");
            this.colEntryType.FieldName = "EntryType";
            this.colEntryType.Name = "colEntryType";
            // 
            // colFromAmount
            // 
            resources.ApplyResources(this.colFromAmount, "colFromAmount");
            this.colFromAmount.DisplayFormat.FormatString = "N2";
            this.colFromAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFromAmount.FieldName = "FromAmount";
            this.colFromAmount.Name = "colFromAmount";
            this.colFromAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colToAmount
            // 
            resources.ApplyResources(this.colToAmount, "colToAmount");
            this.colToAmount.DisplayFormat.FormatString = "N2";
            this.colToAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToAmount.FieldName = "ToAmount";
            this.colToAmount.Name = "colToAmount";
            this.colToAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colAmountText
            // 
            resources.ApplyResources(this.colAmountText, "colAmountText");
            this.colAmountText.FieldName = "AmountText";
            this.colAmountText.Name = "colAmountText";
            // 
            // colAccount
            // 
            resources.ApplyResources(this.colAccount, "colAccount");
            this.colAccount.FieldName = "Account.taxnumber";
            this.colAccount.Name = "colAccount";
            // 
            // colUser
            // 
            resources.ApplyResources(this.colUser, "colUser");
            this.colUser.FieldName = "User";
            this.colUser.Name = "colUser";
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "Account.Accounttype";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtTotalBalance);
            this.panel3.Controls.Add(this.BtnClose);
            this.panel3.Name = "panel3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TxtTotalBalance
            // 
            resources.ApplyResources(this.TxtTotalBalance, "TxtTotalBalance");
            this.TxtTotalBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtTotalBalance.Name = "TxtTotalBalance";
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
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.tableLayoutPanel2);
            this.panelControl1.Name = "panelControl1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.TxtDateFrom, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RdToday, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdDates, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtDateTo, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnShow, 6, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            this.TxtDateFrom.EditValueChanged += new System.EventHandler(this.TxtDateFrom_EditValueChanged);
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
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Name = "labelControl1";
            // 
            // RdToday
            // 
            resources.ApplyResources(this.RdToday, "RdToday");
            this.RdToday.Name = "RdToday";
            this.RdToday.UseVisualStyleBackColor = true;
            this.RdToday.CheckedChanged += new System.EventHandler(this.RdToday_CheckedChanged);
            // 
            // rdDates
            // 
            resources.ApplyResources(this.rdDates, "rdDates");
            this.rdDates.Checked = true;
            this.rdDates.Name = "rdDates";
            this.rdDates.TabStop = true;
            this.rdDates.UseVisualStyleBackColor = true;
            this.rdDates.CheckedChanged += new System.EventHandler(this.rdDates_CheckedChanged);
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Name = "labelControl2";
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
            this.TxtDateTo.EditValueChanged += new System.EventHandler(this.TxtDateTo_EditValueChanged);
            // 
            // BtnShow
            // 
            resources.ApplyResources(this.BtnShow, "BtnShow");
            this.BtnShow.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnShow.Appearance.Font")));
            this.BtnShow.Appearance.Options.UseFont = true;
            this.BtnShow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnShow.ImageOptions.SvgImage")));
            this.BtnShow.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // FrmAccountTransactions
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAccountTransactions";
            this.ShowInTaskbar = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Load += new System.EventHandler(this.FrmItemCat_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransactionSubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateFrom.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDateTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit TxtDateTo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnShow;
        private System.Windows.Forms.RadioButton RdToday;
        private System.Windows.Forms.RadioButton rdDates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotalBalance;
        private DevExpress.XtraGrid.GridControl DgvItems;
        private System.Windows.Forms.BindingSource accountsTransactionSubBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransRefType;
        private DevExpress.XtraGrid.Columns.GridColumn colTransRefId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransRefNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colEntryId;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailsNote;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colEntryType;
        private DevExpress.XtraGrid.Columns.GridColumn colFromAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colToAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountText;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem designReportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTransRefTypeAr;
        private DevExpress.XtraEditors.DateEdit TxtDateFrom;
    }
}