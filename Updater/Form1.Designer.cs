
namespace Updater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblConfirm1 = new DevExpress.XtraEditors.LabelControl();
            this.LblConfirm2 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timerStartUpdate = new System.Windows.Forms.Timer();
            this.LblConfirm = new DevExpress.XtraEditors.LabelControl();
            this.progress1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.progress2 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.progress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LblConfirm1
            // 
            this.LblConfirm1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LblConfirm1.Appearance.Options.UseFont = true;
            this.LblConfirm1.Appearance.Options.UseTextOptions = true;
            this.LblConfirm1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblConfirm1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LblConfirm1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblConfirm1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.LblConfirm1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.LblConfirm1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LblConfirm1.ImageOptions.SvgImage")));
            this.LblConfirm1.Location = new System.Drawing.Point(32, 40);
            this.LblConfirm1.Name = "LblConfirm1";
            this.LblConfirm1.Size = new System.Drawing.Size(313, 69);
            this.LblConfirm1.TabIndex = 0;
            this.LblConfirm1.Text = "تم تحديث البرنامج بنجاح\r\nNew Updated successfuly done";
            this.LblConfirm1.Visible = false;
            this.LblConfirm1.Click += new System.EventHandler(this.LblConfirm1_Click);
            // 
            // LblConfirm2
            // 
            this.LblConfirm2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblConfirm2.Appearance.Options.UseFont = true;
            this.LblConfirm2.Appearance.Options.UseTextOptions = true;
            this.LblConfirm2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblConfirm2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LblConfirm2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblConfirm2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.LblConfirm2.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.LblConfirm2.Location = new System.Drawing.Point(73, 131);
            this.LblConfirm2.Name = "LblConfirm2";
            this.LblConfirm2.Size = new System.Drawing.Size(200, 54);
            this.LblConfirm2.TabIndex = 1;
            this.LblConfirm2.Text = " سيتم اغلاق الشاشة بعد 5 ثوان\r\n        closed after 5 seconds";
            this.LblConfirm2.Visible = false;
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
            // LblConfirm
            // 
            this.LblConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LblConfirm.Appearance.Options.UseFont = true;
            this.LblConfirm.Appearance.Options.UseTextOptions = true;
            this.LblConfirm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblConfirm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LblConfirm.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblConfirm.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.LblConfirm.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.LblConfirm.Location = new System.Drawing.Point(51, 39);
            this.LblConfirm.Name = "LblConfirm";
            this.LblConfirm.Size = new System.Drawing.Size(259, 54);
            this.LblConfirm.TabIndex = 2;
            this.LblConfirm.Text = "استكمال التحديث ! انتظر من فضلك\r\nPlease wait a while ,Upgrade in progress";
            // 
            // progress1
            // 
            this.progress1.EditValue = 0;
            this.progress1.Location = new System.Drawing.Point(51, 89);
            this.progress1.Name = "progress1";
            this.progress1.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.PingPong;
            this.progress1.Size = new System.Drawing.Size(255, 18);
            this.progress1.TabIndex = 4;
            // 
            // progress2
            // 
            this.progress2.EditValue = 0;
            this.progress2.Location = new System.Drawing.Point(51, 177);
            this.progress2.Name = "progress2";
            this.progress2.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.PingPong;
            this.progress2.Size = new System.Drawing.Size(255, 8);
            this.progress2.TabIndex = 5;
            this.progress2.Visible = false;
            this.progress2.EditValueChanged += new System.EventHandler(this.progress2_EditValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 203);
            this.Controls.Add(this.progress2);
            this.Controls.Add(this.progress1);
            this.Controls.Add(this.LblConfirm);
            this.Controls.Add(this.LblConfirm2);
            this.Controls.Add(this.LblConfirm1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblConfirm1;
        private DevExpress.XtraEditors.LabelControl LblConfirm2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerStartUpdate;
        private DevExpress.XtraEditors.LabelControl LblConfirm;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progress1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progress2;
    }
}

