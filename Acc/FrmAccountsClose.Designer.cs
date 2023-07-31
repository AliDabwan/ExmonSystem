
namespace ExmonSystem.Form
{
    partial class FrmAccountsClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountsClose));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtMAccountID = new System.Windows.Forms.TextBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEntryID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtAmount = new DevExpress.XtraEditors.CalcEdit();
            this.TxtDate = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.TxtToBalance = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtRealBalance = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.TxtMAccountID);
            this.panel1.Controls.Add(this.LblHeader);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TxtId
            // 
            resources.ApplyResources(this.TxtId, "TxtId");
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            // 
            // TxtMAccountID
            // 
            resources.ApplyResources(this.TxtMAccountID, "TxtMAccountID");
            this.TxtMAccountID.Name = "TxtMAccountID";
            this.TxtMAccountID.ReadOnly = true;
            // 
            // LblHeader
            // 
            this.LblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.LblHeader, "LblHeader");
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Click += new System.EventHandler(this.LblHeader_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel8);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFrom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtEntryID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.cmbFrom, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.TabStop = true;
            // 
            // cmbFrom
            // 
            this.cmbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cmbFrom, "cmbFrom");
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.SelectedIndexChanged += new System.EventHandler(this.cmbFrom_SelectedIndexChanged);
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
            // lblFrom
            // 
            resources.ApplyResources(this.lblFrom, "lblFrom");
            this.lblFrom.Name = "lblFrom";
            // 
            // lblTo
            // 
            resources.ApplyResources(this.lblTo, "lblTo");
            this.lblTo.Name = "lblTo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // TxtEntryID
            // 
            resources.ApplyResources(this.TxtEntryID, "TxtEntryID");
            this.TxtEntryID.Name = "TxtEntryID";
            this.TxtEntryID.ReadOnly = true;
            this.TxtEntryID.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.TxtAmount, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.TabStop = true;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // TxtAmount
            // 
            resources.ApplyResources(this.TxtAmount, "TxtAmount");
            this.TxtAmount.EnterMoveNextControl = true;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtAmount.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtAmount.Properties.Appearance.Font")));
            this.TxtAmount.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtAmount.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAmount.Properties.Appearance.Options.UseFont = true;
            this.TxtAmount.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtAmount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtAmount.Properties.Buttons"))))});
            this.TxtAmount.Properties.DisplayFormat.FormatString = "N2";
            this.TxtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtAmount.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("TxtAmount.Properties.Mask.MaskType")));
            this.TxtAmount.Properties.NullText = resources.GetString("TxtAmount.Properties.NullText");
            this.TxtAmount.Properties.Precision = 2;
            // 
            // TxtDate
            // 
            resources.ApplyResources(this.TxtDate, "TxtDate");
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtDate.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtDate.Properties.Appearance.Font")));
            this.TxtDate.Properties.Appearance.Options.UseFont = true;
            this.TxtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtDate.Properties.Buttons"))))});
            this.TxtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtDate.Properties.CalendarTimeProperties.Buttons"))))});
            this.TxtDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.TxtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.TxtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDate.Properties.NullDate = new System.DateTime(2021, 6, 6, 11, 49, 56, 0);
            this.TxtDate.Properties.NullDateCalendarValue = new System.DateTime(2021, 6, 6, 11, 50, 7, 0);
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.cmbTo, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.TxtToBalance, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // cmbTo
            // 
            this.cmbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cmbTo, "cmbTo");
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.SelectedIndexChanged += new System.EventHandler(this.cmbTo_SelectedIndexChanged);
            // 
            // TxtToBalance
            // 
            resources.ApplyResources(this.TxtToBalance, "TxtToBalance");
            this.TxtToBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TxtToBalance.Name = "TxtToBalance";
            this.TxtToBalance.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.TxtNote, 0, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // TxtNote
            // 
            resources.ApplyResources(this.TxtNote, "TxtNote");
            this.TxtNote.Name = "TxtNote";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtRealBalance);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // TxtRealBalance
            // 
            this.TxtRealBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.TxtRealBalance, "TxtRealBalance");
            this.TxtRealBalance.Name = "TxtRealBalance";
            this.TxtRealBalance.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnPrint, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // BtnNew
            // 
            resources.ApplyResources(this.BtnNew, "BtnNew");
            this.BtnNew.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnNew.Appearance.Font")));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnNew.ImageOptions.SvgImage")));
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
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
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnClose.Appearance.Font")));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnClose.ImageOptions.SvgImage")));
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Click += new System.EventHandler(this.simpleButton4_Click);
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
            // simpleButton2
            // 
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Name = "simpleButton2";
            // 
            // BtnPrint
            // 
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnPrint.Appearance.Font")));
            this.BtnPrint.Appearance.Options.UseFont = true;
            this.BtnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPrint.ImageOptions.SvgImage")));
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(ExmonSystem.Models.Accounts);
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataSource = typeof(ExmonSystem.Models.Accounts);
            // 
            // FrmAccountsClose
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAccountsClose";
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox TxtToBalance;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtMAccountID;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
        public System.Windows.Forms.TextBox TxtEntryID;
        public System.Windows.Forms.TextBox TxtNote;
        public DevExpress.XtraEditors.DateEdit TxtDate;
        public System.Windows.Forms.ComboBox cmbFrom;
        public System.Windows.Forms.ComboBox cmbTo;
        public DevExpress.XtraEditors.CalcEdit TxtAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox TxtRealBalance;
    }
}