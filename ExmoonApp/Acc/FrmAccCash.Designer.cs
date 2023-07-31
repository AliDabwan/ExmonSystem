
namespace ExmonSystem.Form
{
    partial class FrmAccCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccCash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtMAccountID = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAccountId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch2 = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch3 = new DevExpress.XtraEditors.ToggleSwitch();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.TxtMAccountID);
            this.panel1.Controls.Add(this.LblTitle);
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
            // TxtBalance
            // 
            resources.ApplyResources(this.TxtBalance, "TxtBalance");
            this.TxtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "balance", true));
            this.TxtBalance.Name = "TxtBalance";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "AccountName", true));
            this.TxtName.Name = "TxtName";
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
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
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "note", true));
            this.textBox9.Name = "textBox9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "creditlimit", true));
            this.textBox10.Name = "textBox10";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            // toggleSwitch1
            // 
            resources.ApplyResources(this.toggleSwitch1, "toggleSwitch1");
            this.toggleSwitch1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "IsEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("toggleSwitch1.Properties.Appearance.Font")));
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("toggleSwitch1.Properties.GlyphVerticalAlignment")));
            this.toggleSwitch1.Properties.OffText = resources.GetString("toggleSwitch1.Properties.OffText");
            this.toggleSwitch1.Properties.OnText = resources.GetString("toggleSwitch1.Properties.OnText");
            // 
            // toggleSwitch2
            // 
            resources.ApplyResources(this.toggleSwitch2, "toggleSwitch2");
            this.toggleSwitch2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "IsCustomerRequired", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toggleSwitch2.Name = "toggleSwitch2";
            this.toggleSwitch2.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("toggleSwitch2.Properties.Appearance.Font")));
            this.toggleSwitch2.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch2.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("toggleSwitch2.Properties.GlyphVerticalAlignment")));
            this.toggleSwitch2.Properties.OffText = resources.GetString("toggleSwitch2.Properties.OffText");
            this.toggleSwitch2.Properties.OnText = resources.GetString("toggleSwitch2.Properties.OnText");
            // 
            // toggleSwitch3
            // 
            resources.ApplyResources(this.toggleSwitch3, "toggleSwitch3");
            this.toggleSwitch3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "IsPaymentType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toggleSwitch3.Name = "toggleSwitch3";
            this.toggleSwitch3.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("toggleSwitch3.Properties.Appearance.Font")));
            this.toggleSwitch3.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch3.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("toggleSwitch3.Properties.GlyphVerticalAlignment")));
            this.toggleSwitch3.Properties.OffText = resources.GetString("toggleSwitch3.Properties.OffText");
            this.toggleSwitch3.Properties.OnText = resources.GetString("toggleSwitch3.Properties.OnText");
            // 
            // FrmAccCash
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.toggleSwitch3);
            this.Controls.Add(this.toggleSwitch2);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtAccountId);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmAccCash";
            this.Load += new System.EventHandler(this.FrmAccCash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAccountId;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtMAccountID;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.TextBox TxtId;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch3;
    }
}