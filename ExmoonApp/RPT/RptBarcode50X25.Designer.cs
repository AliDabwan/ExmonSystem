
namespace ExmonSystem.RPT
{
    partial class RptBarcode50X25
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabelCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.CompanyName = new DevExpress.XtraReports.Parameters.Parameter();
            this.Barcode = new DevExpress.XtraReports.Parameters.Parameter();
            this.myDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.Voucher = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 1F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 1F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrLabelCompany});
            this.Detail.HeightF = 101.25F;
            this.Detail.Name = "Detail";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Barcode")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(2.999997F, 16.00006F);
            this.xrBarCode1.Module = 1F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(190F, 78F);
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            this.xrBarCode1.Symbology = code128Generator1;
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabelCompany
            // 
            this.xrLabelCompany.BackColor = System.Drawing.Color.Black;
            this.xrLabelCompany.CanGrow = false;
            this.xrLabelCompany.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?myDate")});
            this.xrLabelCompany.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabelCompany.ForeColor = System.Drawing.Color.White;
            this.xrLabelCompany.LocationFloat = new DevExpress.Utils.PointFloat(8F, 0F);
            this.xrLabelCompany.Multiline = true;
            this.xrLabelCompany.Name = "xrLabelCompany";
            this.xrLabelCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelCompany.SizeF = new System.Drawing.SizeF(180F, 15F);
            this.xrLabelCompany.StylePriority.UseBackColor = false;
            this.xrLabelCompany.StylePriority.UseFont = false;
            this.xrLabelCompany.StylePriority.UseForeColor = false;
            this.xrLabelCompany.StylePriority.UseTextAlignment = false;
            this.xrLabelCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // CompanyName
            // 
            this.CompanyName.AllowNull = true;
            this.CompanyName.Name = "CompanyName";
            // 
            // Barcode
            // 
            this.Barcode.AllowNull = true;
            this.Barcode.Name = "Barcode";
            // 
            // myDate
            // 
            this.myDate.AllowNull = true;
            this.myDate.Name = "myDate";
            // 
            // Voucher
            // 
            this.Voucher.AllowNull = true;
            this.Voucher.Name = "Voucher";
            this.Voucher.ValueInfo = "0";
            // 
            // RptBarcode50X25
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 3, 1, 1);
            this.PageHeight = 98;
            this.PageWidth = 198;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.CompanyName,
            this.Barcode,
            this.myDate,
            this.Voucher});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.Parameters.Parameter CompanyName;
        private DevExpress.XtraReports.UI.XRLabel xrLabelCompany;
        private DevExpress.XtraReports.Parameters.Parameter Barcode;
        private DevExpress.XtraReports.Parameters.Parameter myDate;
        private DevExpress.XtraReports.Parameters.Parameter Voucher;
    }
}
