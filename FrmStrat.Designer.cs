
namespace ExmonSystem
{
    partial class FrmStrat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStrat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PropMizanType = new DevExpress.XtraEditors.CalcEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ComBoxBarcodPrinter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComBoxInvoicePrinter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyAdd = new System.Windows.Forms.TextBox();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyTAX = new System.Windows.Forms.TextBox();
            this.txtCompanyIDReg = new System.Windows.Forms.TextBox();
            this.txtCompanyEmail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.ButbrowseImage = new DevExpress.XtraEditors.SimpleButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCompanyImage = new DevExpress.XtraEditors.PictureEdit();
            this.ButSaveCompany = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.PropAutoBackupinClose = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.ButRestore = new DevExpress.XtraEditors.SimpleButton();
            this.butBackup = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBackupFolder = new System.Windows.Forms.TextBox();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropMizanType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyImage.Properties)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropAutoBackupinClose.Properties)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.toolTipController1.SetAllowHtmlText(this.panel1, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("panel1.AllowHtmlText"))));
            this.panel1.Controls.Add(this.PropMizanType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Name = "panel1";
            this.toolTipController1.SetTitle(this.panel1, resources.GetString("panel1.Title"));
            this.toolTipController1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.panel1, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("panel1.ToolTipIconType"))));
            // 
            // PropMizanType
            // 
            resources.ApplyResources(this.PropMizanType, "PropMizanType");
            this.PropMizanType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "PropMizanType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PropMizanType.EnterMoveNextControl = true;
            this.PropMizanType.Name = "PropMizanType";
            this.PropMizanType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.PropMizanType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PropMizanType.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("PropMizanType.Properties.Appearance.Font")));
            this.PropMizanType.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PropMizanType.Properties.Appearance.Options.UseBackColor = true;
            this.PropMizanType.Properties.Appearance.Options.UseFont = true;
            this.PropMizanType.Properties.Appearance.Options.UseForeColor = true;
            this.PropMizanType.Properties.Appearance.Options.UseTextOptions = true;
            this.PropMizanType.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PropMizanType.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PropMizanType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("PropMizanType.Properties.Buttons"))))});
            this.PropMizanType.Properties.DisplayFormat.FormatString = "N0";
            this.PropMizanType.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PropMizanType.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PropMizanType.Properties.EditValueChangedDelay = 1;
            this.PropMizanType.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.PropMizanType.Properties.Mask.EditMask = resources.GetString("PropMizanType.Properties.Mask.EditMask");
            this.PropMizanType.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("PropMizanType.Properties.Mask.UseMaskAsDisplayFormat")));
            this.PropMizanType.Properties.NullText = resources.GetString("PropMizanType.Properties.NullText");
            this.PropMizanType.Properties.Precision = 2;
            this.PropMizanType.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(ExmonSystem.Models.Company);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.toolTipController1.SetAllowHtmlText(this.label10, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label10.AllowHtmlText"))));
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            this.toolTipController1.SetTitle(this.label10, resources.GetString("label10.Title"));
            this.toolTipController1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label10, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label10.ToolTipIconType"))));
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.toolTipController1.SetAllowHtmlText(this.panel2, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("panel2.AllowHtmlText"))));
            this.panel2.Controls.Add(this.xtraTabControl1);
            this.panel2.Name = "panel2";
            this.toolTipController1.SetTitle(this.panel2, resources.GetString("panel2.Title"));
            this.toolTipController1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.panel2, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("panel2.ToolTipIconType"))));
            // 
            // xtraTabControl1
            // 
            resources.ApplyResources(this.xtraTabControl1, "xtraTabControl1");
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            resources.ApplyResources(this.xtraTabPage1, "xtraTabPage1");
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.ComBoxBarcodPrinter);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.ComBoxInvoicePrinter);
            this.xtraTabPage1.Controls.Add(this.tableLayoutPanel11);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.Name = "xtraTabPage1";
            // 
            // simpleButton3
            // 
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // simpleButton2
            // 
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // ComBoxBarcodPrinter
            // 
            resources.ApplyResources(this.ComBoxBarcodPrinter, "ComBoxBarcodPrinter");
            this.toolTipController1.SetAllowHtmlText(this.ComBoxBarcodPrinter, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("ComBoxBarcodPrinter.AllowHtmlText"))));
            this.ComBoxBarcodPrinter.FormattingEnabled = true;
            this.ComBoxBarcodPrinter.Name = "ComBoxBarcodPrinter";
            this.toolTipController1.SetTitle(this.ComBoxBarcodPrinter, resources.GetString("ComBoxBarcodPrinter.Title"));
            this.toolTipController1.SetToolTip(this.ComBoxBarcodPrinter, resources.GetString("ComBoxBarcodPrinter.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.ComBoxBarcodPrinter, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("ComBoxBarcodPrinter.ToolTipIconType"))));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.toolTipController1.SetAllowHtmlText(this.label6, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label6.AllowHtmlText"))));
            this.label6.Name = "label6";
            this.toolTipController1.SetTitle(this.label6, resources.GetString("label6.Title"));
            this.toolTipController1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label6, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label6.ToolTipIconType"))));
            // 
            // ComBoxInvoicePrinter
            // 
            resources.ApplyResources(this.ComBoxInvoicePrinter, "ComBoxInvoicePrinter");
            this.toolTipController1.SetAllowHtmlText(this.ComBoxInvoicePrinter, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("ComBoxInvoicePrinter.AllowHtmlText"))));
            this.ComBoxInvoicePrinter.FormattingEnabled = true;
            this.ComBoxInvoicePrinter.Name = "ComBoxInvoicePrinter";
            this.toolTipController1.SetTitle(this.ComBoxInvoicePrinter, resources.GetString("ComBoxInvoicePrinter.Title"));
            this.toolTipController1.SetToolTip(this.ComBoxInvoicePrinter, resources.GetString("ComBoxInvoicePrinter.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.ComBoxInvoicePrinter, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("ComBoxInvoicePrinter.ToolTipIconType"))));
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(this.tableLayoutPanel11, "tableLayoutPanel11");
            this.toolTipController1.SetAllowHtmlText(this.tableLayoutPanel11, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("tableLayoutPanel11.AllowHtmlText"))));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.toolTipController1.SetTitle(this.tableLayoutPanel11, resources.GetString("tableLayoutPanel11.Title"));
            this.toolTipController1.SetToolTip(this.tableLayoutPanel11, resources.GetString("tableLayoutPanel11.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.tableLayoutPanel11, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("tableLayoutPanel11.ToolTipIconType"))));
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.toolTipController1.SetAllowHtmlText(this.tableLayoutPanel1, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("tableLayoutPanel1.AllowHtmlText"))));
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyAdd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyPhone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyTAX, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyIDReg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyEmail, 1, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTipController1.SetTitle(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.Title"));
            this.toolTipController1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.tableLayoutPanel1, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("tableLayoutPanel1.ToolTipIconType"))));
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.toolTipController1.SetAllowHtmlText(this.label26, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label26.AllowHtmlText"))));
            this.label26.Name = "label26";
            this.toolTipController1.SetTitle(this.label26, resources.GetString("label26.Title"));
            this.toolTipController1.SetToolTip(this.label26, resources.GetString("label26.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label26, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label26.ToolTipIconType"))));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.toolTipController1.SetAllowHtmlText(this.label1, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label1.AllowHtmlText"))));
            this.label1.Name = "label1";
            this.toolTipController1.SetTitle(this.label1, resources.GetString("label1.Title"));
            this.toolTipController1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label1, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label1.ToolTipIconType"))));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.toolTipController1.SetAllowHtmlText(this.label2, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label2.AllowHtmlText"))));
            this.label2.Name = "label2";
            this.toolTipController1.SetTitle(this.label2, resources.GetString("label2.Title"));
            this.toolTipController1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label2, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label2.ToolTipIconType"))));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.toolTipController1.SetAllowHtmlText(this.label3, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label3.AllowHtmlText"))));
            this.label3.Name = "label3";
            this.toolTipController1.SetTitle(this.label3, resources.GetString("label3.Title"));
            this.toolTipController1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label3, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label3.ToolTipIconType"))));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.toolTipController1.SetAllowHtmlText(this.label4, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label4.AllowHtmlText"))));
            this.label4.Name = "label4";
            this.toolTipController1.SetTitle(this.label4, resources.GetString("label4.Title"));
            this.toolTipController1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label4, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label4.ToolTipIconType"))));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.toolTipController1.SetAllowHtmlText(this.label5, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label5.AllowHtmlText"))));
            this.label5.Name = "label5";
            this.toolTipController1.SetTitle(this.label5, resources.GetString("label5.Title"));
            this.toolTipController1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label5, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label5.ToolTipIconType"))));
            // 
            // txtCompanyName
            // 
            resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
            this.toolTipController1.SetAllowHtmlText(this.txtCompanyName, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("txtCompanyName.AllowHtmlText"))));
            this.txtCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "NameAr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompanyName.Name = "txtCompanyName";
            this.toolTipController1.SetTitle(this.txtCompanyName, resources.GetString("txtCompanyName.Title"));
            this.toolTipController1.SetToolTip(this.txtCompanyName, resources.GetString("txtCompanyName.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.txtCompanyName, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("txtCompanyName.ToolTipIconType"))));
            // 
            // txtCompanyAdd
            // 
            resources.ApplyResources(this.txtCompanyAdd, "txtCompanyAdd");
            this.toolTipController1.SetAllowHtmlText(this.txtCompanyAdd, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("txtCompanyAdd.AllowHtmlText"))));
            this.txtCompanyAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "AdressAr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompanyAdd.Name = "txtCompanyAdd";
            this.toolTipController1.SetTitle(this.txtCompanyAdd, resources.GetString("txtCompanyAdd.Title"));
            this.toolTipController1.SetToolTip(this.txtCompanyAdd, resources.GetString("txtCompanyAdd.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.txtCompanyAdd, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("txtCompanyAdd.ToolTipIconType"))));
            // 
            // txtCompanyPhone
            // 
            resources.ApplyResources(this.txtCompanyPhone, "txtCompanyPhone");
            this.toolTipController1.SetAllowHtmlText(this.txtCompanyPhone, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("txtCompanyPhone.AllowHtmlText"))));
            this.txtCompanyPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Phone1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.toolTipController1.SetTitle(this.txtCompanyPhone, resources.GetString("txtCompanyPhone.Title"));
            this.toolTipController1.SetToolTip(this.txtCompanyPhone, resources.GetString("txtCompanyPhone.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.txtCompanyPhone, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("txtCompanyPhone.ToolTipIconType"))));
            this.txtCompanyPhone.TextChanged += new System.EventHandler(this.txtCompanyPhone_TextChanged);
            // 
            // txtCompanyTAX
            // 
            resources.ApplyResources(this.txtCompanyTAX, "txtCompanyTAX");
            this.toolTipController1.SetAllowHtmlText(this.txtCompanyTAX, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("txtCompanyTAX.AllowHtmlText"))));
            this.txtCompanyTAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCompanyTAX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "TaxNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompanyTAX.Name = "txtCompanyTAX";
            this.toolTipController1.SetTitle(this.txtCompanyTAX, resources.GetString("txtCompanyTAX.Title"));
            this.toolTipController1.SetToolTip(this.txtCompanyTAX, resources.GetString("txtCompanyTAX.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.txtCompanyTAX, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("txtCompanyTAX.ToolTipIconType"))));
            // 
            // txtCompanyIDReg
            // 
            resources.ApplyResources(this.txtCompanyIDReg, "txtCompanyIDReg");
            this.toolTipController1.SetAllowHtmlText(this.txtCompanyIDReg, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("txtCompanyIDReg.AllowHtmlText"))));
            this.txtCompanyIDReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Phone3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompanyIDReg.Name = "txtCompanyIDReg";
            this.toolTipController1.SetTitle(this.txtCompanyIDReg, resources.GetString("txtCompanyIDReg.Title"));
            this.toolTipController1.SetToolTip(this.txtCompanyIDReg, resources.GetString("txtCompanyIDReg.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.txtCompanyIDReg, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("txtCompanyIDReg.ToolTipIconType"))));
            // 
            // txtCompanyEmail
            // 
            resources.ApplyResources(this.txtCompanyEmail, "txtCompanyEmail");
            this.toolTipController1.SetAllowHtmlText(this.txtCompanyEmail, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("txtCompanyEmail.AllowHtmlText"))));
            this.txtCompanyEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.toolTipController1.SetTitle(this.txtCompanyEmail, resources.GetString("txtCompanyEmail.Title"));
            this.toolTipController1.SetToolTip(this.txtCompanyEmail, resources.GetString("txtCompanyEmail.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.txtCompanyEmail, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("txtCompanyEmail.ToolTipIconType"))));
            // 
            // tableLayoutPanel12
            // 
            resources.ApplyResources(this.tableLayoutPanel12, "tableLayoutPanel12");
            this.toolTipController1.SetAllowHtmlText(this.tableLayoutPanel12, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("tableLayoutPanel12.AllowHtmlText"))));
            this.tableLayoutPanel12.Controls.Add(this.panel11, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.ButSaveCompany, 0, 1);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.toolTipController1.SetTitle(this.tableLayoutPanel12, resources.GetString("tableLayoutPanel12.Title"));
            this.toolTipController1.SetToolTip(this.tableLayoutPanel12, resources.GetString("tableLayoutPanel12.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.tableLayoutPanel12, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("tableLayoutPanel12.ToolTipIconType"))));
            // 
            // panel11
            // 
            resources.ApplyResources(this.panel11, "panel11");
            this.toolTipController1.SetAllowHtmlText(this.panel11, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("panel11.AllowHtmlText"))));
            this.panel11.Controls.Add(this.simpleButton9);
            this.panel11.Controls.Add(this.ButbrowseImage);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Controls.Add(this.txtCompanyImage);
            this.panel11.Name = "panel11";
            this.toolTipController1.SetTitle(this.panel11, resources.GetString("panel11.Title"));
            this.toolTipController1.SetToolTip(this.panel11, resources.GetString("panel11.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.panel11, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("panel11.ToolTipIconType"))));
            // 
            // simpleButton9
            // 
            resources.ApplyResources(this.simpleButton9, "simpleButton9");
            this.simpleButton9.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton9.Appearance.Font")));
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton9.ImageOptions.SvgImage")));
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // ButbrowseImage
            // 
            resources.ApplyResources(this.ButbrowseImage, "ButbrowseImage");
            this.ButbrowseImage.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButbrowseImage.Appearance.Font")));
            this.ButbrowseImage.Appearance.Options.UseFont = true;
            this.ButbrowseImage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButbrowseImage.ImageOptions.SvgImage")));
            this.ButbrowseImage.Name = "ButbrowseImage";
            this.ButbrowseImage.Click += new System.EventHandler(this.ButbrowseImage_Click);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.toolTipController1.SetAllowHtmlText(this.label18, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label18.AllowHtmlText"))));
            this.label18.Name = "label18";
            this.toolTipController1.SetTitle(this.label18, resources.GetString("label18.Title"));
            this.toolTipController1.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label18, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label18.ToolTipIconType"))));
            // 
            // txtCompanyImage
            // 
            resources.ApplyResources(this.txtCompanyImage, "txtCompanyImage");
            this.txtCompanyImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.companyBindingSource, "Image", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompanyImage.Name = "txtCompanyImage";
            this.txtCompanyImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.txtCompanyImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // ButSaveCompany
            // 
            resources.ApplyResources(this.ButSaveCompany, "ButSaveCompany");
            this.ButSaveCompany.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButSaveCompany.Appearance.Font")));
            this.ButSaveCompany.Appearance.Options.UseFont = true;
            this.ButSaveCompany.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButSaveCompany.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButSaveCompany.ImageOptions.SvgImage")));
            this.ButSaveCompany.Name = "ButSaveCompany";
            this.ButSaveCompany.Click += new System.EventHandler(this.ButSaveCompany_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.toolTipController1.SetAllowHtmlText(this.label7, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label7.AllowHtmlText"))));
            this.label7.Name = "label7";
            this.toolTipController1.SetTitle(this.label7, resources.GetString("label7.Title"));
            this.toolTipController1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label7, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label7.ToolTipIconType"))));
            // 
            // xtraTabPage5
            // 
            resources.ApplyResources(this.xtraTabPage5, "xtraTabPage5");
            this.xtraTabPage5.Controls.Add(this.panel9);
            this.xtraTabPage5.Name = "xtraTabPage5";
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.toolTipController1.SetAllowHtmlText(this.panel9, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("panel9.AllowHtmlText"))));
            this.panel9.Controls.Add(this.tableLayoutPanel8);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Name = "panel9";
            this.toolTipController1.SetTitle(this.panel9, resources.GetString("panel9.Title"));
            this.toolTipController1.SetToolTip(this.panel9, resources.GetString("panel9.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.panel9, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("panel9.ToolTipIconType"))));
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.toolTipController1.SetAllowHtmlText(this.tableLayoutPanel8, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("tableLayoutPanel8.AllowHtmlText"))));
            this.tableLayoutPanel8.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.PropAutoBackupinClose, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.toolTipController1.SetTitle(this.tableLayoutPanel8, resources.GetString("tableLayoutPanel8.Title"));
            this.toolTipController1.SetToolTip(this.tableLayoutPanel8, resources.GetString("tableLayoutPanel8.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.tableLayoutPanel8, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("tableLayoutPanel8.ToolTipIconType"))));
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.toolTipController1.SetAllowHtmlText(this.label22, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label22.AllowHtmlText"))));
            this.label22.Name = "label22";
            this.toolTipController1.SetTitle(this.label22, resources.GetString("label22.Title"));
            this.toolTipController1.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label22, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label22.ToolTipIconType"))));
            // 
            // PropAutoBackupinClose
            // 
            resources.ApplyResources(this.PropAutoBackupinClose, "PropAutoBackupinClose");
            this.PropAutoBackupinClose.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::ExmonSystem.Properties.Settings.Default, "PropAutoBackupinClose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PropAutoBackupinClose.EditValue = global::ExmonSystem.Properties.Settings.Default.PropAutoBackupinClose;
            this.PropAutoBackupinClose.Name = "PropAutoBackupinClose";
            this.PropAutoBackupinClose.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("PropAutoBackupinClose.Properties.Appearance.Font")));
            this.PropAutoBackupinClose.Properties.Appearance.Options.UseFont = true;
            this.PropAutoBackupinClose.Properties.Caption = resources.GetString("PropAutoBackupinClose.Properties.Caption");
            this.PropAutoBackupinClose.Properties.DisplayValueChecked = resources.GetString("PropAutoBackupinClose.Properties.DisplayValueChecked");
            this.PropAutoBackupinClose.Properties.DisplayValueGrayed = resources.GetString("PropAutoBackupinClose.Properties.DisplayValueGrayed");
            this.PropAutoBackupinClose.Properties.DisplayValueUnchecked = resources.GetString("PropAutoBackupinClose.Properties.DisplayValueUnchecked");
            this.PropAutoBackupinClose.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("PropAutoBackupinClose.Properties.GlyphVerticalAlignment")));
            this.PropAutoBackupinClose.CheckedChanged += new System.EventHandler(this.PropAutoBackupinClose_CheckedChanged);
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.toolTipController1.SetAllowHtmlText(this.tableLayoutPanel9, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("tableLayoutPanel9.AllowHtmlText"))));
            this.tableLayoutPanel9.Controls.Add(this.ButRestore, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.butBackup, 0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.toolTipController1.SetTitle(this.tableLayoutPanel9, resources.GetString("tableLayoutPanel9.Title"));
            this.toolTipController1.SetToolTip(this.tableLayoutPanel9, resources.GetString("tableLayoutPanel9.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.tableLayoutPanel9, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("tableLayoutPanel9.ToolTipIconType"))));
            // 
            // ButRestore
            // 
            resources.ApplyResources(this.ButRestore, "ButRestore");
            this.ButRestore.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButRestore.Appearance.Font")));
            this.ButRestore.Appearance.Options.UseFont = true;
            this.ButRestore.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.ButRestore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButRestore.ImageOptions.SvgImage")));
            this.ButRestore.Name = "ButRestore";
            this.ButRestore.Click += new System.EventHandler(this.ButRestore_Click);
            // 
            // butBackup
            // 
            resources.ApplyResources(this.butBackup, "butBackup");
            this.butBackup.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("butBackup.Appearance.Font")));
            this.butBackup.Appearance.Options.UseFont = true;
            this.butBackup.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.butBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("butBackup.ImageOptions.SvgImage")));
            this.butBackup.Name = "butBackup";
            this.butBackup.Click += new System.EventHandler(this.butBackup_Click);
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.toolTipController1.SetAllowHtmlText(this.tableLayoutPanel10, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("tableLayoutPanel10.AllowHtmlText"))));
            this.tableLayoutPanel10.Controls.Add(this.txtBackupFolder, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.simpleButton10, 1, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.toolTipController1.SetTitle(this.tableLayoutPanel10, resources.GetString("tableLayoutPanel10.Title"));
            this.toolTipController1.SetToolTip(this.tableLayoutPanel10, resources.GetString("tableLayoutPanel10.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.tableLayoutPanel10, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("tableLayoutPanel10.ToolTipIconType"))));
            // 
            // txtBackupFolder
            // 
            resources.ApplyResources(this.txtBackupFolder, "txtBackupFolder");
            this.toolTipController1.SetAllowHtmlText(this.txtBackupFolder, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("txtBackupFolder.AllowHtmlText"))));
            this.txtBackupFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.toolTipController1.SetTitle(this.txtBackupFolder, resources.GetString("txtBackupFolder.Title"));
            this.toolTipController1.SetToolTip(this.txtBackupFolder, resources.GetString("txtBackupFolder.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.txtBackupFolder, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("txtBackupFolder.ToolTipIconType"))));
            // 
            // simpleButton10
            // 
            resources.ApplyResources(this.simpleButton10, "simpleButton10");
            this.simpleButton10.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton10.Appearance.Font")));
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton10.ImageOptions.SvgImage")));
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.toolTipController1.SetAllowHtmlText(this.panel10, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("panel10.AllowHtmlText"))));
            this.panel10.Controls.Add(this.label21);
            this.panel10.Name = "panel10";
            this.toolTipController1.SetTitle(this.panel10, resources.GetString("panel10.Title"));
            this.toolTipController1.SetToolTip(this.panel10, resources.GetString("panel10.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.panel10, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("panel10.ToolTipIconType"))));
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.toolTipController1.SetAllowHtmlText(this.label21, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label21.AllowHtmlText"))));
            this.label21.Name = "label21";
            this.toolTipController1.SetTitle(this.label21, resources.GetString("label21.Title"));
            this.toolTipController1.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label21, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label21.ToolTipIconType"))));
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.toolTipController1.SetAllowHtmlText(this.label25, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("label25.AllowHtmlText"))));
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Name = "label25";
            this.toolTipController1.SetTitle(this.label25, resources.GetString("label25.Title"));
            this.toolTipController1.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this.label25, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("label25.ToolTipIconType"))));
            // 
            // xtraFolderBrowserDialog1
            // 
            resources.ApplyResources(this.xtraFolderBrowserDialog1, "xtraFolderBrowserDialog1");
            // 
            // xtraOpenFileDialog1
            // 
            resources.ApplyResources(this.xtraOpenFileDialog1, "xtraOpenFileDialog1");
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // FrmStrat
            // 
            resources.ApplyResources(this, "$this");
            this.toolTipController1.SetAllowHtmlText(this, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("$this.AllowHtmlText"))));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmStrat";
            this.toolTipController1.SetTitle(this, resources.GetString("$this.Title"));
            this.toolTipController1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.toolTipController1.SetToolTipIconType(this, ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("$this.ToolTipIconType"))));
            this.Load += new System.EventHandler(this.FrmStrat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropMizanType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyImage.Properties)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropAutoBackupinClose.Properties)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyAdd;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.TextBox txtCompanyTAX;
        private System.Windows.Forms.TextBox txtCompanyIDReg;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton ButSaveCompany;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton ButbrowseImage;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.PictureEdit txtCompanyImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComBoxInvoicePrinter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.CheckEdit PropAutoBackupinClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private DevExpress.XtraEditors.SimpleButton ButRestore;
        private DevExpress.XtraEditors.SimpleButton butBackup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox txtBackupFolder;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCompanyEmail;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        public DevExpress.XtraEditors.CalcEdit PropMizanType;
        private System.Windows.Forms.ComboBox ComBoxBarcodPrinter;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}