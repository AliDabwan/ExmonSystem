
namespace ExmonSystem
{
    partial class FrmAccountClosinglist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountClosinglist));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.accountsTransDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.DgvItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountsTransactionSubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTotalBalance = new System.Windows.Forms.TextBox();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.TxtDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.designReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDateTo = new DevExpress.XtraEditors.DateEdit();
            this.BtnShow = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransDTOBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransactionSubBindingSource)).BeginInit();
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
            // accountsTransDTOBindingSource
            // 
            this.accountsTransDTOBindingSource.DataSource = typeof(ExmonSystem.Models.AccountsTransDTO);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Controls.Add(this.DgvItems);
            this.panel2.Name = "panel2";
            // 
            // chartControl1
            // 
            resources.ApplyResources(this.chartControl1, "chartControl1");
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "TransDay";
            series1.DataSource = this.accountsTransDTOBindingSource;
            resources.ApplyResources(series1, "series1");
            series1.ValueDataMembersSerializable = "totalbalance";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            resources.ApplyResources(chartTitle1, "chartTitle1");
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // DgvItems
            // 
            resources.ApplyResources(this.DgvItems, "DgvItems");
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
            this.DgvItems.Click += new System.EventHandler(this.DgvItems_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.SelectedRow.Font")));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransMonth,
            this.colTransDay,
            this.coltotalDebit,
            this.coltotalCredit,
            this.coltotalbalance});
            this.gridView1.GridControl = this.DgvItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colTransMonth
            // 
            this.colTransMonth.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colTransMonth.AppearanceHeader.Font")));
            this.colTransMonth.AppearanceHeader.Options.UseFont = true;
            this.colTransMonth.AppearanceHeader.Options.UseTextOptions = true;
            this.colTransMonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTransMonth.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.colTransMonth, "colTransMonth");
            this.colTransMonth.FieldName = "TransMonth";
            this.colTransMonth.Name = "colTransMonth";
            // 
            // colTransDay
            // 
            this.colTransDay.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colTransDay.AppearanceHeader.Font")));
            this.colTransDay.AppearanceHeader.Options.UseFont = true;
            this.colTransDay.AppearanceHeader.Options.UseTextOptions = true;
            this.colTransDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTransDay.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.colTransDay, "colTransDay");
            this.colTransDay.FieldName = "TransDay";
            this.colTransDay.Name = "colTransDay";
            // 
            // coltotalDebit
            // 
            this.coltotalDebit.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("coltotalDebit.AppearanceHeader.Font")));
            this.coltotalDebit.AppearanceHeader.Options.UseFont = true;
            this.coltotalDebit.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalDebit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalDebit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.coltotalDebit, "coltotalDebit");
            this.coltotalDebit.FieldName = "totalDebit";
            this.coltotalDebit.Name = "coltotalDebit";
            // 
            // coltotalCredit
            // 
            this.coltotalCredit.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("coltotalCredit.AppearanceHeader.Font")));
            this.coltotalCredit.AppearanceHeader.Options.UseFont = true;
            this.coltotalCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalCredit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.coltotalCredit, "coltotalCredit");
            this.coltotalCredit.FieldName = "totalCredit";
            this.coltotalCredit.Name = "coltotalCredit";
            // 
            // coltotalbalance
            // 
            this.coltotalbalance.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("coltotalbalance.AppearanceHeader.Font")));
            this.coltotalbalance.AppearanceHeader.Options.UseFont = true;
            this.coltotalbalance.AppearanceHeader.Options.UseTextOptions = true;
            this.coltotalbalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltotalbalance.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(this.coltotalbalance, "coltotalbalance");
            this.coltotalbalance.FieldName = "totalbalance";
            this.coltotalbalance.Name = "coltotalbalance";
            // 
            // accountsTransactionSubBindingSource
            // 
            this.accountsTransactionSubBindingSource.DataSource = typeof(ExmonSystem.Models.AccountsTransactionSub);
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
            this.TxtTotalBalance.ReadOnly = true;
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
            this.tableLayoutPanel2.Controls.Add(this.cmbFrom, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtDateFrom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtDateTo, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnShow, 5, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // cmbFrom
            // 
            resources.ApplyResources(this.cmbFrom, "cmbFrom");
            this.cmbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.SelectedIndexChanged += new System.EventHandler(this.cmbFrom_SelectedIndexChanged);
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
            this.TxtDateFrom.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("TxtDateFrom.Properties.Mask.UseMaskAsDisplayFormat")));
            this.TxtDateFrom.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
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
            this.TxtDateTo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("TxtDateTo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.TxtDateTo.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
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
            // FrmAccountClosinglist
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
            this.Name = "FrmAccountClosinglist";
            this.ShowInTaskbar = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Load += new System.EventHandler(this.FrmItemCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransDTOBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTransactionSubBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotalBalance;
        private DevExpress.XtraGrid.GridControl DgvItems;
        private System.Windows.Forms.BindingSource accountsTransactionSubBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem designReportToolStripMenuItem;
        private DevExpress.XtraEditors.DateEdit TxtDateFrom;
        private System.Windows.Forms.BindingSource accountsTransDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDay;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalDebit;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalCredit;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalbalance;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransMonth;
        public System.Windows.Forms.ComboBox cmbFrom;
    }
}