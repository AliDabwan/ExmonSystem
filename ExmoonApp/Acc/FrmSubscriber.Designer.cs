
using DevExpress.XtraEditors;

namespace ExmonSystem.Acc
{
    partial class FrmSubscriber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubscriber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.subscriberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DgvRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkVoucher = new DevExpress.XtraEditors.CheckEdit();
            this.CheckExcell = new DevExpress.XtraEditors.CheckEdit();
            this.CheckVisa = new DevExpress.XtraEditors.CheckEdit();
            this.CheckTicket = new DevExpress.XtraEditors.CheckEdit();
            this.CheckPassport = new DevExpress.XtraEditors.CheckEdit();
            this.TxtValue = new DevExpress.XtraEditors.CalcEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckExcell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckVisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPassport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValue.Properties)).BeginInit();
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
            this.TxtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subscriberBindingSource, "Id", true));
            this.TxtID.Name = "TxtID";
            // 
            // subscriberBindingSource
            // 
            this.subscriberBindingSource.DataSource = typeof(ExmonSystem.Models.Subscriber);
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
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.DgvRecords);
            this.panel4.Name = "panel4";
            // 
            // DgvRecords
            // 
            resources.ApplyResources(this.DgvRecords, "DgvRecords");
            this.DgvRecords.DataSource = this.subscriberBindingSource;
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
            this.colTaxName,
            this.colTaxValue});
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
            // 
            // colTaxName
            // 
            resources.ApplyResources(this.colTaxName, "colTaxName");
            this.colTaxName.FieldName = "Name";
            this.colTaxName.Name = "colTaxName";
            // 
            // colTaxValue
            // 
            resources.ApplyResources(this.colTaxValue, "colTaxValue");
            this.colTaxValue.FieldName = "Price";
            this.colTaxValue.Name = "colTaxValue";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Name = "panel5";
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
            this.tableLayoutPanel1.Controls.Add(this.TxtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subscriberBindingSource, "Name", true));
            this.TxtName.EnterMoveNextControl = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtName.Properties.Appearance.Font")));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Properties.NullText = resources.GetString("TxtName.Properties.NullText");
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // groupControl1
            // 
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Controls.Add(this.checkVoucher);
            this.groupControl1.Controls.Add(this.CheckExcell);
            this.groupControl1.Controls.Add(this.CheckVisa);
            this.groupControl1.Controls.Add(this.CheckTicket);
            this.groupControl1.Controls.Add(this.CheckPassport);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.TabStop = true;
            // 
            // checkVoucher
            // 
            resources.ApplyResources(this.checkVoucher, "checkVoucher");
            this.checkVoucher.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subscriberBindingSource, "IsVoucher", true));
            this.checkVoucher.EnterMoveNextControl = true;
            this.checkVoucher.Name = "checkVoucher";
            this.checkVoucher.Properties.Caption = resources.GetString("checkVoucher.Properties.Caption");
            this.checkVoucher.Properties.DisplayValueChecked = resources.GetString("checkVoucher.Properties.DisplayValueChecked");
            this.checkVoucher.Properties.DisplayValueGrayed = resources.GetString("checkVoucher.Properties.DisplayValueGrayed");
            this.checkVoucher.Properties.DisplayValueUnchecked = resources.GetString("checkVoucher.Properties.DisplayValueUnchecked");
            this.checkVoucher.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("checkVoucher.Properties.GlyphVerticalAlignment")));
            // 
            // CheckExcell
            // 
            resources.ApplyResources(this.CheckExcell, "CheckExcell");
            this.CheckExcell.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subscriberBindingSource, "IsExcell", true));
            this.CheckExcell.EnterMoveNextControl = true;
            this.CheckExcell.Name = "CheckExcell";
            this.CheckExcell.Properties.Caption = resources.GetString("CheckExcell.Properties.Caption");
            this.CheckExcell.Properties.DisplayValueChecked = resources.GetString("CheckExcell.Properties.DisplayValueChecked");
            this.CheckExcell.Properties.DisplayValueGrayed = resources.GetString("CheckExcell.Properties.DisplayValueGrayed");
            this.CheckExcell.Properties.DisplayValueUnchecked = resources.GetString("CheckExcell.Properties.DisplayValueUnchecked");
            this.CheckExcell.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("CheckExcell.Properties.GlyphVerticalAlignment")));
            // 
            // CheckVisa
            // 
            resources.ApplyResources(this.CheckVisa, "CheckVisa");
            this.CheckVisa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subscriberBindingSource, "IsVisa", true));
            this.CheckVisa.EnterMoveNextControl = true;
            this.CheckVisa.Name = "CheckVisa";
            this.CheckVisa.Properties.Caption = resources.GetString("CheckVisa.Properties.Caption");
            this.CheckVisa.Properties.DisplayValueChecked = resources.GetString("CheckVisa.Properties.DisplayValueChecked");
            this.CheckVisa.Properties.DisplayValueGrayed = resources.GetString("CheckVisa.Properties.DisplayValueGrayed");
            this.CheckVisa.Properties.DisplayValueUnchecked = resources.GetString("CheckVisa.Properties.DisplayValueUnchecked");
            this.CheckVisa.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("CheckVisa.Properties.GlyphVerticalAlignment")));
            // 
            // CheckTicket
            // 
            resources.ApplyResources(this.CheckTicket, "CheckTicket");
            this.CheckTicket.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subscriberBindingSource, "IsTicket", true));
            this.CheckTicket.EnterMoveNextControl = true;
            this.CheckTicket.Name = "CheckTicket";
            this.CheckTicket.Properties.Caption = resources.GetString("CheckTicket.Properties.Caption");
            this.CheckTicket.Properties.DisplayValueChecked = resources.GetString("CheckTicket.Properties.DisplayValueChecked");
            this.CheckTicket.Properties.DisplayValueGrayed = resources.GetString("CheckTicket.Properties.DisplayValueGrayed");
            this.CheckTicket.Properties.DisplayValueUnchecked = resources.GetString("CheckTicket.Properties.DisplayValueUnchecked");
            this.CheckTicket.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("CheckTicket.Properties.GlyphVerticalAlignment")));
            // 
            // CheckPassport
            // 
            resources.ApplyResources(this.CheckPassport, "CheckPassport");
            this.CheckPassport.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.subscriberBindingSource, "IsPassport", true));
            this.CheckPassport.EnterMoveNextControl = true;
            this.CheckPassport.Name = "CheckPassport";
            this.CheckPassport.Properties.Caption = resources.GetString("CheckPassport.Properties.Caption");
            this.CheckPassport.Properties.DisplayValueChecked = resources.GetString("CheckPassport.Properties.DisplayValueChecked");
            this.CheckPassport.Properties.DisplayValueGrayed = resources.GetString("CheckPassport.Properties.DisplayValueGrayed");
            this.CheckPassport.Properties.DisplayValueUnchecked = resources.GetString("CheckPassport.Properties.DisplayValueUnchecked");
            this.CheckPassport.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("CheckPassport.Properties.GlyphVerticalAlignment")));
            // 
            // TxtValue
            // 
            resources.ApplyResources(this.TxtValue, "TxtValue");
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtValue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtValue.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtValue.Properties.Appearance.Font")));
            this.TxtValue.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtValue.Properties.Appearance.Options.UseBackColor = true;
            this.TxtValue.Properties.Appearance.Options.UseFont = true;
            this.TxtValue.Properties.Appearance.Options.UseForeColor = true;
            this.TxtValue.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtValue.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtValue.Properties.Buttons"))))});
            this.TxtValue.Properties.DisplayFormat.FormatString = "N0";
            this.TxtValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValue.Properties.EditFormat.FormatString = "N0";
            this.TxtValue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValue.Properties.Mask.EditMask = resources.GetString("TxtValue.Properties.Mask.EditMask");
            this.TxtValue.Properties.NullText = resources.GetString("TxtValue.Properties.NullText");
            this.TxtValue.Properties.Precision = 2;
            this.TxtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValue_KeyDown);
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // FrmSubscriber
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmSubscriber";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmTaxValue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckExcell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckVisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPassport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl DgvRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Timer timerLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxValue;
        public DevExpress.XtraEditors.CalcEdit TxtValue;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.Label label4;
        private CheckEdit CheckPassport;
        private GroupControl groupControl1;
        private CheckEdit checkVoucher;
        private CheckEdit CheckExcell;
        private CheckEdit CheckVisa;
        private CheckEdit CheckTicket;
        private System.Windows.Forms.BindingSource subscriberBindingSource;
    }
}