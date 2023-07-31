
namespace ExmonSystem.Setting
{
    partial class FrmUserAuthorityGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserAuthorityGroups));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvGroups = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupRollNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtGroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGroupId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.dgvRollsNames = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DgvRolls = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollGroupsBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRollsNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Name = "panel2";
            this.panel2.TabStop = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.DgvGroups, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // DgvGroups
            // 
            resources.ApplyResources(this.DgvGroups, "DgvGroups");
            this.DgvGroups.AllowUserToAddRows = false;
            this.DgvGroups.AllowUserToDeleteRows = false;
            this.DgvGroups.AllowUserToResizeColumns = false;
            this.DgvGroups.AllowUserToResizeRows = false;
            this.DgvGroups.AutoGenerateColumns = false;
            this.DgvGroups.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.groupRollNameDataGridViewTextBoxColumn});
            this.DgvGroups.DataSource = this.rollGroupsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGroups.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGroups.Name = "DgvGroups";
            this.DgvGroups.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvGroups.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvGroups.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvGroups.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DgvGroups.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvGroups.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvGroups.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvGroups.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGroups.ShowCellErrors = false;
            this.DgvGroups.ShowCellToolTips = false;
            this.DgvGroups.ShowEditingIcon = false;
            this.DgvGroups.ShowRowErrors = false;
            this.DgvGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroups_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupRollNameDataGridViewTextBoxColumn
            // 
            this.groupRollNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupRollNameDataGridViewTextBoxColumn.DataPropertyName = "GroupRollName";
            resources.ApplyResources(this.groupRollNameDataGridViewTextBoxColumn, "groupRollNameDataGridViewTextBoxColumn");
            this.groupRollNameDataGridViewTextBoxColumn.Name = "groupRollNameDataGridViewTextBoxColumn";
            this.groupRollNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rollGroupsBindingSource
            // 
            this.rollGroupsBindingSource.DataSource = typeof(ExmonSystem.Models.RollGroups);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BtnNew
            // 
            resources.ApplyResources(this.BtnNew, "BtnNew");
            this.BtnNew.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnNew.Appearance.Font")));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnNew.ImageOptions.SvgImage")));
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnSave.Appearance.Font")));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSave.ImageOptions.SvgImage")));
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            resources.ApplyResources(this.BtnDelete, "BtnDelete");
            this.BtnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnDelete.Appearance.Font")));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDelete.ImageOptions.SvgImage")));
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.TxtGroupName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtGroupId, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // TxtGroupName
            // 
            resources.ApplyResources(this.TxtGroupName, "TxtGroupName");
            this.TxtGroupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rollGroupsBindingSource, "GroupRollName", true));
            this.TxtGroupName.Name = "TxtGroupName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TxtGroupId
            // 
            resources.ApplyResources(this.TxtGroupId, "TxtGroupId");
            this.TxtGroupId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rollGroupsBindingSource, "Id", true));
            this.TxtGroupId.Name = "TxtGroupId";
            this.TxtGroupId.ReadOnly = true;
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
            this.tableLayoutPanel4.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.flyoutPanel1);
            this.panelControl2.Controls.Add(this.DgvRolls);
            this.panelControl2.Name = "panelControl2";
            // 
            // flyoutPanel1
            // 
            resources.ApplyResources(this.flyoutPanel1, "flyoutPanel1");
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OptionsBeakPanel.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Slide;
            this.flyoutPanel1.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Right;
            this.flyoutPanel1.OptionsBeakPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton()});
            this.flyoutPanel1.OwnerControl = this.panel2;
            this.flyoutPanel1.ParentForm = this;
            // 
            // flyoutPanelControl1
            // 
            resources.ApplyResources(this.flyoutPanelControl1, "flyoutPanelControl1");
            this.flyoutPanelControl1.Controls.Add(this.dgvRollsNames);
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            // 
            // dgvRollsNames
            // 
            resources.ApplyResources(this.dgvRollsNames, "dgvRollsNames");
            this.dgvRollsNames.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rollGroupsBindingSource, "rolls", true));
            this.dgvRollsNames.EmbeddedNavigator.AccessibleDescription = resources.GetString("dgvRollsNames.EmbeddedNavigator.AccessibleDescription");
            this.dgvRollsNames.EmbeddedNavigator.AccessibleName = resources.GetString("dgvRollsNames.EmbeddedNavigator.AccessibleName");
            this.dgvRollsNames.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.dgvRollsNames.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.Anchor")));
            this.dgvRollsNames.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.BackgroundImage")));
            this.dgvRollsNames.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.BackgroundImageLayout")));
            this.dgvRollsNames.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.ImeMode")));
            this.dgvRollsNames.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.MaximumSize")));
            this.dgvRollsNames.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.TextLocation")));
            this.dgvRollsNames.EmbeddedNavigator.ToolTip = resources.GetString("dgvRollsNames.EmbeddedNavigator.ToolTip");
            this.dgvRollsNames.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("dgvRollsNames.EmbeddedNavigator.ToolTipIconType")));
            this.dgvRollsNames.EmbeddedNavigator.ToolTipTitle = resources.GetString("dgvRollsNames.EmbeddedNavigator.ToolTipTitle");
            this.dgvRollsNames.MainView = this.gridView2;
            this.dgvRollsNames.Name = "dgvRollsNames";
            this.dgvRollsNames.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgvRollsNames.Click += new System.EventHandler(this.dgvRollsNames_Click);
            // 
            // gridView2
            // 
            resources.ApplyResources(this.gridView2, "gridView2");
            this.gridView2.GridControl = this.dgvRollsNames;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // DgvRolls
            // 
            resources.ApplyResources(this.DgvRolls, "DgvRolls");
            this.DgvRolls.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rollGroupsBindingSource, "rolls", true));
            this.DgvRolls.EmbeddedNavigator.AccessibleDescription = resources.GetString("DgvRolls.EmbeddedNavigator.AccessibleDescription");
            this.DgvRolls.EmbeddedNavigator.AccessibleName = resources.GetString("DgvRolls.EmbeddedNavigator.AccessibleName");
            this.DgvRolls.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("DgvRolls.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.DgvRolls.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("DgvRolls.EmbeddedNavigator.Anchor")));
            this.DgvRolls.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DgvRolls.EmbeddedNavigator.BackgroundImage")));
            this.DgvRolls.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("DgvRolls.EmbeddedNavigator.BackgroundImageLayout")));
            this.DgvRolls.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("DgvRolls.EmbeddedNavigator.ImeMode")));
            this.DgvRolls.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("DgvRolls.EmbeddedNavigator.MaximumSize")));
            this.DgvRolls.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("DgvRolls.EmbeddedNavigator.TextLocation")));
            this.DgvRolls.EmbeddedNavigator.ToolTip = resources.GetString("DgvRolls.EmbeddedNavigator.ToolTip");
            this.DgvRolls.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("DgvRolls.EmbeddedNavigator.ToolTipIconType")));
            this.DgvRolls.EmbeddedNavigator.ToolTipTitle = resources.GetString("DgvRolls.EmbeddedNavigator.ToolTipTitle");
            this.DgvRolls.MainView = this.gridView1;
            this.DgvRolls.Name = "DgvRolls";
            this.DgvRolls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.GridControl = this.DgvRolls;
            this.gridView1.Name = "gridView1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Name = "label6";
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // FrmUserAuthorityGroups
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmUserAuthorityGroups";
            this.Load += new System.EventHandler(this.FrmUserAuthorityGroups_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollGroupsBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRollsNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGroupId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl DgvRolls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource rollGroupsBindingSource;
        private System.Windows.Forms.DataGridView DgvGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupRollNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timerLoad;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraGrid.GridControl dgvRollsNames;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}