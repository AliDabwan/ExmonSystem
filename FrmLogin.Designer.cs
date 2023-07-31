
namespace ExmonSystem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.CmbUsers = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButDelete = new DevExpress.XtraEditors.SimpleButton();
            this.But0 = new DevExpress.XtraEditors.SimpleButton();
            this.ButBack = new DevExpress.XtraEditors.SimpleButton();
            this.But9 = new DevExpress.XtraEditors.SimpleButton();
            this.But8 = new DevExpress.XtraEditors.SimpleButton();
            this.But7 = new DevExpress.XtraEditors.SimpleButton();
            this.But6 = new DevExpress.XtraEditors.SimpleButton();
            this.But5 = new DevExpress.XtraEditors.SimpleButton();
            this.But4 = new DevExpress.XtraEditors.SimpleButton();
            this.But3 = new DevExpress.XtraEditors.SimpleButton();
            this.But2 = new DevExpress.XtraEditors.SimpleButton();
            this.But1 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ButCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButExit = new DevExpress.XtraEditors.SimpleButton();
            this.butLogin = new DevExpress.XtraEditors.SimpleButton();
            this.ButResPassword = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CmbUsers, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.BackColor = System.Drawing.Color.Khaki;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.DoubleClick += new System.EventHandler(this.txtPassword_DoubleClick);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // CmbUsers
            // 
            resources.ApplyResources(this.CmbUsers, "CmbUsers");
            this.CmbUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbUsers.BackColor = System.Drawing.Color.Khaki;
            this.CmbUsers.FormattingEnabled = true;
            this.CmbUsers.Name = "CmbUsers";
            this.CmbUsers.SelectedIndexChanged += new System.EventHandler(this.CmbUsers_SelectedIndexChanged);
            this.CmbUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbUsers_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.ButDelete, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.But0, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ButBack, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.But9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.But8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.But7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.But6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.But5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.But4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.But3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.But2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.But1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // ButDelete
            // 
            this.ButDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButDelete.Appearance.Font")));
            this.ButDelete.Appearance.Options.UseFont = true;
            this.ButDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.ButDelete, "ButDelete");
            this.ButDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.ButDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButDelete.ImageOptions.SvgImage")));
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // But0
            // 
            this.But0.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But0.Appearance.Font")));
            this.But0.Appearance.Options.UseFont = true;
            this.But0.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But0, "But0");
            this.But0.Name = "But0";
            this.But0.Click += new System.EventHandler(this.But1_Click);
            // 
            // ButBack
            // 
            this.ButBack.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButBack.Appearance.Font")));
            this.ButBack.Appearance.Options.UseFont = true;
            this.ButBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.ButBack, "ButBack");
            this.ButBack.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.ButBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButBack.ImageOptions.SvgImage")));
            this.ButBack.Name = "ButBack";
            this.ButBack.Click += new System.EventHandler(this.ButBack_Click);
            // 
            // But9
            // 
            this.But9.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But9.Appearance.Font")));
            this.But9.Appearance.Options.UseFont = true;
            this.But9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But9, "But9");
            this.But9.Name = "But9";
            this.But9.Click += new System.EventHandler(this.But1_Click);
            // 
            // But8
            // 
            this.But8.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But8.Appearance.Font")));
            this.But8.Appearance.Options.UseFont = true;
            this.But8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But8, "But8");
            this.But8.Name = "But8";
            this.But8.Click += new System.EventHandler(this.But1_Click);
            // 
            // But7
            // 
            this.But7.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But7.Appearance.Font")));
            this.But7.Appearance.Options.UseFont = true;
            this.But7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But7, "But7");
            this.But7.Name = "But7";
            this.But7.Click += new System.EventHandler(this.But1_Click);
            // 
            // But6
            // 
            this.But6.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But6.Appearance.Font")));
            this.But6.Appearance.Options.UseFont = true;
            this.But6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But6, "But6");
            this.But6.Name = "But6";
            this.But6.Click += new System.EventHandler(this.But1_Click);
            // 
            // But5
            // 
            this.But5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But5.Appearance.Font")));
            this.But5.Appearance.Options.UseFont = true;
            this.But5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But5, "But5");
            this.But5.Name = "But5";
            this.But5.Click += new System.EventHandler(this.But1_Click);
            // 
            // But4
            // 
            this.But4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But4.Appearance.Font")));
            this.But4.Appearance.Options.UseFont = true;
            this.But4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But4, "But4");
            this.But4.Name = "But4";
            this.But4.Click += new System.EventHandler(this.But1_Click);
            // 
            // But3
            // 
            this.But3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But3.Appearance.Font")));
            this.But3.Appearance.Options.UseFont = true;
            this.But3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But3, "But3");
            this.But3.Name = "But3";
            this.But3.Click += new System.EventHandler(this.But1_Click);
            // 
            // But2
            // 
            this.But2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But2.Appearance.Font")));
            this.But2.Appearance.Options.UseFont = true;
            this.But2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But2, "But2");
            this.But2.Name = "But2";
            this.But2.Click += new System.EventHandler(this.But1_Click);
            // 
            // But1
            // 
            this.But1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("But1.Appearance.Font")));
            this.But1.Appearance.Options.UseFont = true;
            this.But1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            resources.ApplyResources(this.But1, "But1");
            this.But1.Name = "But1";
            this.But1.Click += new System.EventHandler(this.But1_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.ButCancel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.ButExit, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.butLogin, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButResPassword, 0, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // ButCancel
            // 
            this.ButCancel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButCancel.Appearance.Font")));
            this.ButCancel.Appearance.Options.UseFont = true;
            this.ButCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButCancel.ImageOptions.SvgImage")));
            resources.ApplyResources(this.ButCancel, "ButCancel");
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // ButExit
            // 
            this.ButExit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButExit.Appearance.Font")));
            this.ButExit.Appearance.Options.UseFont = true;
            this.ButExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButExit.ImageOptions.SvgImage")));
            resources.ApplyResources(this.ButExit, "ButExit");
            this.ButExit.Name = "ButExit";
            this.ButExit.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // butLogin
            // 
            this.butLogin.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("butLogin.Appearance.Font")));
            this.butLogin.Appearance.Options.UseFont = true;
            this.butLogin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.butLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("butLogin.ImageOptions.SvgImage")));
            resources.ApplyResources(this.butLogin, "butLogin");
            this.butLogin.Name = "butLogin";
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // ButResPassword
            // 
            this.ButResPassword.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ButResPassword.Appearance.Font")));
            this.ButResPassword.Appearance.Options.UseFont = true;
            this.ButResPassword.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            resources.ApplyResources(this.ButResPassword, "ButResPassword");
            this.ButResPassword.Name = "ButResPassword";
            this.ButResPassword.Click += new System.EventHandler(this.ButResPassword_Click);
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButExit;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbUsers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton ButDelete;
        private DevExpress.XtraEditors.SimpleButton But0;
        private DevExpress.XtraEditors.SimpleButton ButBack;
        private DevExpress.XtraEditors.SimpleButton But9;
        private DevExpress.XtraEditors.SimpleButton But8;
        private DevExpress.XtraEditors.SimpleButton But7;
        private DevExpress.XtraEditors.SimpleButton But6;
        private DevExpress.XtraEditors.SimpleButton But5;
        private DevExpress.XtraEditors.SimpleButton But4;
        private DevExpress.XtraEditors.SimpleButton But3;
        private DevExpress.XtraEditors.SimpleButton But2;
        private DevExpress.XtraEditors.SimpleButton But1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton ButExit;
        private DevExpress.XtraEditors.SimpleButton butLogin;
        private DevExpress.XtraEditors.SimpleButton ButResPassword;
        private DevExpress.XtraEditors.SimpleButton ButCancel;
    }
}