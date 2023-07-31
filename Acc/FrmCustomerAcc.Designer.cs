
namespace ExmonSystem.Form
{
    partial class FrmCustomerAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerAcc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtMAccountID = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.lblmobile = new System.Windows.Forms.Label();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTawseelOther = new System.Windows.Forms.Label();
            this.lblResName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAccountId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.TxtTawseelBaghdad = new DevExpress.XtraEditors.CalcEdit();
            this.TxtTawseelBaghdadSub = new DevExpress.XtraEditors.CalcEdit();
            this.TxtTawseelOthers = new DevExpress.XtraEditors.CalcEdit();
            this.lblTawseelBaghdad = new System.Windows.Forms.Label();
            this.lblTawseelBaghdadSub = new System.Windows.Forms.Label();
            this.txtphone = new DevExpress.XtraEditors.TextEdit();
            this.txtresName = new DevExpress.XtraEditors.TextEdit();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.pnlVendorType = new DevExpress.XtraEditors.RadioGroup();
            this.lblVendorType = new System.Windows.Forms.Label();
            this.TxtTasleemBaghdad = new DevExpress.XtraEditors.CalcEdit();
            this.TxtTasleemBaghdadSub = new DevExpress.XtraEditors.CalcEdit();
            this.TxtTasleemOthers = new DevExpress.XtraEditors.CalcEdit();
            this.lblTasleemBaghdad = new System.Windows.Forms.Label();
            this.lblTasleemBaghdadSub = new System.Windows.Forms.Label();
            this.lblTasleemOthers = new System.Windows.Forms.Label();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTawseelBaghdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTawseelBaghdadSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTawseelOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtresName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlVendorType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasleemBaghdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasleemBaghdadSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasleemOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.TxtMAccountID);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtmobile);
            this.panel1.Controls.Add(this.lblmobile);
            this.panel1.Controls.Add(this.TxtBalance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Name = "panel1";
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
            // LblTitle
            // 
            resources.ApplyResources(this.LblTitle, "LblTitle");
            this.LblTitle.BackColor = System.Drawing.Color.Teal;
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Name = "LblTitle";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "taxnumber", true));
            this.textBox5.Name = "textBox5";
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "creditlimit", true));
            this.textBox10.Name = "textBox10";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtmobile
            // 
            resources.ApplyResources(this.txtmobile, "txtmobile");
            this.txtmobile.BackColor = System.Drawing.Color.White;
            this.txtmobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "mobile", true));
            this.txtmobile.Name = "txtmobile";
            // 
            // lblmobile
            // 
            resources.ApplyResources(this.lblmobile, "lblmobile");
            this.lblmobile.Name = "lblmobile";
            // 
            // TxtBalance
            // 
            resources.ApplyResources(this.TxtBalance, "TxtBalance");
            this.TxtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "balance", true));
            this.TxtBalance.Name = "TxtBalance";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
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
            this.tableLayoutPanel1.Controls.Add(this.lblTawseelOther, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblResName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtAccountId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblphone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtTawseelBaghdad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtTawseelBaghdadSub, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtTawseelOthers, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTawseelBaghdad, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTawseelBaghdadSub, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtphone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtresName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlVendorType, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVendorType, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtTasleemBaghdad, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtTasleemBaghdadSub, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtTasleemOthers, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTasleemBaghdad, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTasleemBaghdadSub, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTasleemOthers, 2, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblTawseelOther
            // 
            resources.ApplyResources(this.lblTawseelOther, "lblTawseelOther");
            this.lblTawseelOther.Name = "lblTawseelOther";
            // 
            // lblResName
            // 
            resources.ApplyResources(this.lblResName, "lblResName");
            this.lblResName.Name = "lblResName";
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
            this.TxtAccountId.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblphone
            // 
            resources.ApplyResources(this.lblphone, "lblphone");
            this.lblphone.Name = "lblphone";
            // 
            // TxtTawseelBaghdad
            // 
            resources.ApplyResources(this.TxtTawseelBaghdad, "TxtTawseelBaghdad");
            this.TxtTawseelBaghdad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "PriceBaghdadCenterTawseel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtTawseelBaghdad.EnterMoveNextControl = true;
            this.TxtTawseelBaghdad.Name = "TxtTawseelBaghdad";
            this.TxtTawseelBaghdad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTawseelBaghdad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTawseelBaghdad.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtTawseelBaghdad.Properties.Appearance.Font")));
            this.TxtTawseelBaghdad.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtTawseelBaghdad.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTawseelBaghdad.Properties.Appearance.Options.UseFont = true;
            this.TxtTawseelBaghdad.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTawseelBaghdad.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTawseelBaghdad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtTawseelBaghdad.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtTawseelBaghdad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtTawseelBaghdad.Properties.Buttons"))))});
            this.TxtTawseelBaghdad.Properties.NullText = resources.GetString("TxtTawseelBaghdad.Properties.NullText");
            this.TxtTawseelBaghdad.Properties.Precision = 2;
            this.TxtTawseelBaghdad.EditValueChanged += new System.EventHandler(this.TxtTawseelBaghdad_EditValueChanged);
            // 
            // TxtTawseelBaghdadSub
            // 
            resources.ApplyResources(this.TxtTawseelBaghdadSub, "TxtTawseelBaghdadSub");
            this.TxtTawseelBaghdadSub.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "PriceBaghdadSuburbTawseel", true));
            this.TxtTawseelBaghdadSub.EnterMoveNextControl = true;
            this.TxtTawseelBaghdadSub.Name = "TxtTawseelBaghdadSub";
            this.TxtTawseelBaghdadSub.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTawseelBaghdadSub.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTawseelBaghdadSub.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtTawseelBaghdadSub.Properties.Appearance.Font")));
            this.TxtTawseelBaghdadSub.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtTawseelBaghdadSub.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTawseelBaghdadSub.Properties.Appearance.Options.UseFont = true;
            this.TxtTawseelBaghdadSub.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTawseelBaghdadSub.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTawseelBaghdadSub.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtTawseelBaghdadSub.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtTawseelBaghdadSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtTawseelBaghdadSub.Properties.Buttons"))))});
            this.TxtTawseelBaghdadSub.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTawseelBaghdadSub.Properties.EditFormat.FormatString = "N2";
            this.TxtTawseelBaghdadSub.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTawseelBaghdadSub.Properties.NullText = resources.GetString("TxtTawseelBaghdadSub.Properties.NullText");
            this.TxtTawseelBaghdadSub.Properties.Precision = 2;
            // 
            // TxtTawseelOthers
            // 
            resources.ApplyResources(this.TxtTawseelOthers, "TxtTawseelOthers");
            this.TxtTawseelOthers.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "PriceOthersTawseel", true));
            this.TxtTawseelOthers.EnterMoveNextControl = true;
            this.TxtTawseelOthers.Name = "TxtTawseelOthers";
            this.TxtTawseelOthers.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTawseelOthers.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTawseelOthers.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtTawseelOthers.Properties.Appearance.Font")));
            this.TxtTawseelOthers.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtTawseelOthers.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTawseelOthers.Properties.Appearance.Options.UseFont = true;
            this.TxtTawseelOthers.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTawseelOthers.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTawseelOthers.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtTawseelOthers.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtTawseelOthers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtTawseelOthers.Properties.Buttons"))))});
            this.TxtTawseelOthers.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTawseelOthers.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTawseelOthers.Properties.NullText = resources.GetString("TxtTawseelOthers.Properties.NullText");
            this.TxtTawseelOthers.Properties.Precision = 2;
            // 
            // lblTawseelBaghdad
            // 
            resources.ApplyResources(this.lblTawseelBaghdad, "lblTawseelBaghdad");
            this.lblTawseelBaghdad.Name = "lblTawseelBaghdad";
            // 
            // lblTawseelBaghdadSub
            // 
            resources.ApplyResources(this.lblTawseelBaghdadSub, "lblTawseelBaghdadSub");
            this.lblTawseelBaghdadSub.Name = "lblTawseelBaghdadSub";
            // 
            // txtphone
            // 
            resources.ApplyResources(this.txtphone, "txtphone");
            this.txtphone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "phone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtphone.EnterMoveNextControl = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtphone.Properties.Appearance.Font")));
            this.txtphone.Properties.Appearance.Options.UseFont = true;
            // 
            // txtresName
            // 
            resources.ApplyResources(this.txtresName, "txtresName");
            this.txtresName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "AccountResName", true));
            this.txtresName.EnterMoveNextControl = true;
            this.txtresName.Name = "txtresName";
            this.txtresName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtresName.Properties.Appearance.Font")));
            this.txtresName.Properties.Appearance.Options.UseFont = true;
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "AccountName", true));
            this.TxtName.EnterMoveNextControl = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtName.Properties.Appearance.Font")));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            // 
            // pnlVendorType
            // 
            resources.ApplyResources(this.pnlVendorType, "pnlVendorType");
            this.pnlVendorType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "VendorType", true));
            this.pnlVendorType.EnterMoveNextControl = true;
            this.pnlVendorType.Name = "pnlVendorType";
            this.pnlVendorType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlVendorType.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("pnlVendorType.Properties.Appearance.Font")));
            this.pnlVendorType.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.pnlVendorType.Properties.Appearance.Options.UseBackColor = true;
            this.pnlVendorType.Properties.Appearance.Options.UseFont = true;
            this.pnlVendorType.Properties.Appearance.Options.UseForeColor = true;
            this.pnlVendorType.Properties.ColumnIndent = 1;
            this.pnlVendorType.Properties.Columns = 1;
            this.pnlVendorType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(resources.GetString("pnlVendorType.Properties.Items"), resources.GetString("pnlVendorType.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(resources.GetString("pnlVendorType.Properties.Items2"), resources.GetString("pnlVendorType.Properties.Items3")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(resources.GetString("pnlVendorType.Properties.Items4"), resources.GetString("pnlVendorType.Properties.Items5"))});
            this.tableLayoutPanel1.SetRowSpan(this.pnlVendorType, 3);
            this.pnlVendorType.SelectedIndexChanged += new System.EventHandler(this.pnlVendorType_SelectedIndexChanged);
            // 
            // lblVendorType
            // 
            resources.ApplyResources(this.lblVendorType, "lblVendorType");
            this.lblVendorType.Name = "lblVendorType";
            // 
            // TxtTasleemBaghdad
            // 
            resources.ApplyResources(this.TxtTasleemBaghdad, "TxtTasleemBaghdad");
            this.TxtTasleemBaghdad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "PriceBaghdadCenterTasleem", true));
            this.TxtTasleemBaghdad.EnterMoveNextControl = true;
            this.TxtTasleemBaghdad.Name = "TxtTasleemBaghdad";
            this.TxtTasleemBaghdad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTasleemBaghdad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTasleemBaghdad.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtTasleemBaghdad.Properties.Appearance.Font")));
            this.TxtTasleemBaghdad.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtTasleemBaghdad.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTasleemBaghdad.Properties.Appearance.Options.UseFont = true;
            this.TxtTasleemBaghdad.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTasleemBaghdad.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTasleemBaghdad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtTasleemBaghdad.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtTasleemBaghdad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtTasleemBaghdad.Properties.Buttons"))))});
            this.TxtTasleemBaghdad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasleemBaghdad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasleemBaghdad.Properties.NullText = resources.GetString("TxtTasleemBaghdad.Properties.NullText");
            this.TxtTasleemBaghdad.Properties.Precision = 2;
            // 
            // TxtTasleemBaghdadSub
            // 
            resources.ApplyResources(this.TxtTasleemBaghdadSub, "TxtTasleemBaghdadSub");
            this.TxtTasleemBaghdadSub.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "PriceBaghdadSuburbTasleem", true));
            this.TxtTasleemBaghdadSub.EnterMoveNextControl = true;
            this.TxtTasleemBaghdadSub.Name = "TxtTasleemBaghdadSub";
            this.TxtTasleemBaghdadSub.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTasleemBaghdadSub.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTasleemBaghdadSub.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtTasleemBaghdadSub.Properties.Appearance.Font")));
            this.TxtTasleemBaghdadSub.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtTasleemBaghdadSub.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTasleemBaghdadSub.Properties.Appearance.Options.UseFont = true;
            this.TxtTasleemBaghdadSub.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTasleemBaghdadSub.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTasleemBaghdadSub.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtTasleemBaghdadSub.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtTasleemBaghdadSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtTasleemBaghdadSub.Properties.Buttons"))))});
            this.TxtTasleemBaghdadSub.Properties.DisplayFormat.FormatString = "N";
            this.TxtTasleemBaghdadSub.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasleemBaghdadSub.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasleemBaghdadSub.Properties.Mask.EditMask = resources.GetString("TxtTasleemBaghdadSub.Properties.Mask.EditMask");
            this.TxtTasleemBaghdadSub.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("TxtTasleemBaghdadSub.Properties.Mask.UseMaskAsDisplayFormat")));
            this.TxtTasleemBaghdadSub.Properties.NullText = resources.GetString("TxtTasleemBaghdadSub.Properties.NullText");
            this.TxtTasleemBaghdadSub.Properties.Precision = 2;
            // 
            // TxtTasleemOthers
            // 
            resources.ApplyResources(this.TxtTasleemOthers, "TxtTasleemOthers");
            this.TxtTasleemOthers.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "PriceOthersTasleem", true));
            this.TxtTasleemOthers.EnterMoveNextControl = true;
            this.TxtTasleemOthers.Name = "TxtTasleemOthers";
            this.TxtTasleemOthers.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTasleemOthers.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTasleemOthers.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtTasleemOthers.Properties.Appearance.Font")));
            this.TxtTasleemOthers.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TxtTasleemOthers.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTasleemOthers.Properties.Appearance.Options.UseFont = true;
            this.TxtTasleemOthers.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTasleemOthers.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTasleemOthers.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtTasleemOthers.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtTasleemOthers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("TxtTasleemOthers.Properties.Buttons"))))});
            this.TxtTasleemOthers.Properties.DisplayFormat.FormatString = "N";
            this.TxtTasleemOthers.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasleemOthers.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasleemOthers.Properties.Mask.EditMask = resources.GetString("TxtTasleemOthers.Properties.Mask.EditMask");
            this.TxtTasleemOthers.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("TxtTasleemOthers.Properties.Mask.UseMaskAsDisplayFormat")));
            this.TxtTasleemOthers.Properties.NullText = resources.GetString("TxtTasleemOthers.Properties.NullText");
            this.TxtTasleemOthers.Properties.Precision = 2;
            // 
            // lblTasleemBaghdad
            // 
            resources.ApplyResources(this.lblTasleemBaghdad, "lblTasleemBaghdad");
            this.lblTasleemBaghdad.Name = "lblTasleemBaghdad";
            // 
            // lblTasleemBaghdadSub
            // 
            resources.ApplyResources(this.lblTasleemBaghdadSub, "lblTasleemBaghdadSub");
            this.lblTasleemBaghdadSub.Name = "lblTasleemBaghdadSub";
            // 
            // lblTasleemOthers
            // 
            resources.ApplyResources(this.lblTasleemOthers, "lblTasleemOthers");
            this.lblTasleemOthers.Name = "lblTasleemOthers";
            // 
            // toggleSwitch1
            // 
            resources.ApplyResources(this.toggleSwitch1, "toggleSwitch1");
            this.tableLayoutPanel2.SetColumnSpan(this.toggleSwitch1, 2);
            this.toggleSwitch1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "IsEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("toggleSwitch1.Properties.Appearance.Font")));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("toggleSwitch1.Properties.GlyphVerticalAlignment")));
            this.toggleSwitch1.Properties.OffText = resources.GetString("toggleSwitch1.Properties.OffText");
            this.toggleSwitch1.Properties.OnText = resources.GetString("toggleSwitch1.Properties.OnText");
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Name = "panel6";
            this.panel6.TabStop = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.toggleSwitch1, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.TabStop = true;
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnSave.Appearance.Font")));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSave.ImageOptions.SvgImage")));
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BtnAdd
            // 
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnAdd.Appearance.Font")));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdd.ImageOptions.SvgImage")));
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnDelete
            // 
            resources.ApplyResources(this.BtnDelete, "BtnDelete");
            this.BtnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnDelete.Appearance.Font")));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDelete.ImageOptions.SvgImage")));
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Click += new System.EventHandler(this.simpleButton2_Click);
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
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // FrmCustomerAcc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmCustomerAcc";
            this.Load += new System.EventHandler(this.FrmCustomerAcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTawseelBaghdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTawseelBaghdadSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTawseelOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtresName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlVendorType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasleemBaghdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasleemBaghdadSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasleemOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private System.Windows.Forms.TextBox TxtAccountId;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TxtMAccountID;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblResName;
        private System.Windows.Forms.Label lblTawseelOther;
        public DevExpress.XtraEditors.CalcEdit TxtTawseelBaghdad;
        public DevExpress.XtraEditors.CalcEdit TxtTawseelBaghdadSub;
        public DevExpress.XtraEditors.CalcEdit TxtTawseelOthers;
        private System.Windows.Forms.Label lblTawseelBaghdad;
        private System.Windows.Forms.Label lblTawseelBaghdadSub;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.TextEdit txtphone;
        private DevExpress.XtraEditors.TextEdit txtresName;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.RadioGroup pnlVendorType;
        private System.Windows.Forms.Label lblVendorType;
        public DevExpress.XtraEditors.CalcEdit TxtTasleemBaghdad;
        public DevExpress.XtraEditors.CalcEdit TxtTasleemBaghdadSub;
        public DevExpress.XtraEditors.CalcEdit TxtTasleemOthers;
        private System.Windows.Forms.Label lblTasleemBaghdad;
        private System.Windows.Forms.Label lblTasleemBaghdadSub;
        private System.Windows.Forms.Label lblTasleemOthers;
    }
}