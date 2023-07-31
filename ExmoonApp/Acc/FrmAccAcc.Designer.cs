
namespace ExmonSystem.Form
{
    partial class FrmAccAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccAcc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtMAccountID = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toggleIsIsTax = new DevExpress.XtraEditors.ToggleSwitch();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAccountId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleIsIsTax.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.TxtMAccountID);
            this.panel1.Controls.Add(this.LblTitle);
            resources.ApplyResources(this.panel1, "panel1");
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
            this.LblTitle.BackColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.LblTitle, "LblTitle");
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Name = "LblTitle";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.toggleIsIsTax, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBalance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtAccountId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // toggleIsIsTax
            // 
            this.toggleIsIsTax.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountsBindingSource, "IsHasTax", true));
            resources.ApplyResources(this.toggleIsIsTax, "toggleIsIsTax");
            this.toggleIsIsTax.Name = "toggleIsIsTax";
            this.toggleIsIsTax.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("toggleIsIsTax.Properties.Appearance.Font")));
            this.toggleIsIsTax.Properties.Appearance.Options.UseFont = true;
            this.toggleIsIsTax.Properties.OffText = resources.GetString("toggleIsIsTax.Properties.OffText");
            this.toggleIsIsTax.Properties.OnText = resources.GetString("toggleIsIsTax.Properties.OnText");
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
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsBindingSource, "taxnumber", true));
            this.textBox5.Name = "textBox5";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
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
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton4, 3, 0);
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
            // simpleButton4
            // 
            resources.ApplyResources(this.simpleButton4, "simpleButton4");
            this.simpleButton4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton4.Appearance.Font")));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.tableLayoutPanel2.SetColumnSpan(this.simpleButton4, 2);
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
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
            // FrmAccAcc
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
            this.Name = "FrmAccAcc";
            this.Load += new System.EventHandler(this.FrmAccAcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleIsIsTax.Properties)).EndInit();
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
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAccountId;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TxtMAccountID;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.TextBox TxtId;
        private DevExpress.XtraEditors.ToggleSwitch toggleIsIsTax;
    }
}