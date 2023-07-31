
namespace ExmonSystem
{
    partial class FrmRestorePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestorePassword));
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.TxtQuest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.btnCheck = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPassord = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAnswer
            // 
            resources.ApplyResources(this.TxtAnswer, "TxtAnswer");
            this.TxtAnswer.Name = "TxtAnswer";
            // 
            // TxtQuest
            // 
            this.TxtQuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtQuest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Phone", true));
            resources.ApplyResources(this.TxtQuest, "TxtQuest");
            this.TxtQuest.Name = "TxtQuest";
            this.TxtQuest.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnSave.Appearance.Font")));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.Name = "TxtName";
            // 
            // btnCheck
            // 
            this.btnCheck.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnCheck.Appearance.Font")));
            this.btnCheck.Appearance.Options.UseFont = true;
            this.btnCheck.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.ImageOptions.Image")));
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // TxtPassord
            // 
            this.TxtPassord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtPassord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            resources.ApplyResources(this.TxtPassord, "TxtPassord");
            this.TxtPassord.Name = "TxtPassord";
            this.TxtPassord.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ExmonSystem.Models.User);
            // 
            // FrmRestorePassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtPassord);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQuest);
            this.Controls.Add(this.TxtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRestorePassword";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmRestorePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.TextBox TxtQuest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnCheck;
        private System.Windows.Forms.TextBox TxtPassord;
        public System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Timer timer1;
    }
}