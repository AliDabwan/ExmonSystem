
namespace ExmonSystem.Acc
{
    partial class FrmAirLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAirLine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.airLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCountries = new DevExpress.XtraEditors.TextEdit();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtSearch = new DevExpress.XtraEditors.SearchControl();
            this.DgvRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airLineBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCountries.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.TxtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // TxtID
            // 
            resources.ApplyResources(this.TxtID, "TxtID");
            this.TxtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airLineBindingSource, "Id", true));
            this.TxtID.Name = "TxtID";
            // 
            // airLineBindingSource
            // 
            this.airLineBindingSource.DataSource = typeof(ExmonSystem.Models.AirLine);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.simpleButton4);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Name = "panel5";
            // 
            // simpleButton4
            // 
            resources.ApplyResources(this.simpleButton4, "simpleButton4");
            this.simpleButton4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton4.Appearance.Font")));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
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
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtCountries, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airLineBindingSource, "Name", true));
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtName.Properties.Appearance.Font")));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TxtCountries
            // 
            resources.ApplyResources(this.TxtCountries, "TxtCountries");
            this.TxtCountries.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airLineBindingSource, "Countries", true));
            this.TxtCountries.EnterMoveNextControl = true;
            this.TxtCountries.Name = "TxtCountries";
            this.TxtCountries.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtCountries.Properties.Appearance.Font")));
            this.TxtCountries.Properties.Appearance.Options.UseFont = true;
            this.TxtCountries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCountries_KeyDown);
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
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
            this.tableLayoutPanel3.Controls.Add(this.TxtSearch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DgvRecords, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
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
            this.DgvRecords.DataSource = this.airLineBindingSource;
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
            this.repositoryItemImageEdit1,
            this.repositoryItemButtonEdit1});
            this.DgvRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.gridColumn2,
            this.gridColumn1});
            this.gridView1.GridControl = this.DgvRecords;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridView1_RowClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colName
            // 
            resources.ApplyResources(this.colName, "colName");
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.ColumnEdit = this.repositoryItemImageEdit1;
            this.gridColumn1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gridColumn1.ImageOptions.SvgImage")));
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // repositoryItemImageEdit1
            // 
            resources.ApplyResources(this.repositoryItemImageEdit1, "repositoryItemImageEdit1");
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageEdit1.Buttons"))))});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.SvgImageSize = new System.Drawing.Size(60, 60);
            // 
            // repositoryItemButtonEdit1
            // 
            resources.ApplyResources(this.repositoryItemButtonEdit1, "repositoryItemButtonEdit1");
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // FrmAirLine
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmAirLine";
            this.Load += new System.EventHandler(this.FrmTaxValue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airLineBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCountries.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Timer timerLoad;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SearchControl TxtSearch;
        private DevExpress.XtraGrid.GridControl DgvRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TxtCountries;
        private System.Windows.Forms.BindingSource airLineBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}