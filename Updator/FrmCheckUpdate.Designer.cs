
namespace GigaPosUpdator
{
    partial class FrmCheckUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckUpdate));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timerStartUpdate = new System.Windows.Forms.Timer();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl1.Location = new System.Drawing.Point(32, 1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(255, 94);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "جاري التحقق من وجود تحديثات\r\nCheck For New Updates";
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerStartUpdate
            // 
            this.timerStartUpdate.Interval = 3000;
            this.timerStartUpdate.Tick += new System.EventHandler(this.timerStartUpdate_Tick);
            // 
            // lblResult
            // 
            this.lblResult.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblResult.Appearance.Options.UseFont = true;
            this.lblResult.Appearance.Options.UseTextOptions = true;
            this.lblResult.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblResult.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lblResult.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResult.Location = new System.Drawing.Point(32, 123);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(279, 73);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "يرجى الانتظار قليلا ... جاري تنزيل التحديثات\r\nPlease wait while updating app";
            this.lblResult.Visible = false;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(32, 88);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.PingPong;
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(255, 18);
            this.marqueeProgressBarControl1.TabIndex = 3;
            // 
            // FrmCheckUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 214);
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmCheckUpdate.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerStartUpdate;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
    }
}

