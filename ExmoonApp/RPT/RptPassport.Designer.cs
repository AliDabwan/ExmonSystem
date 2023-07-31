
namespace ExmonSystem.RPT
{
    partial class RptPassport
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
            DevExpress.DataAccess.ObjectBinding.Parameter parameter1 = new DevExpress.DataAccess.ObjectBinding.Parameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.LineTotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.SubtotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.TaxLineTotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.TotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.takeRow = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.id = new DevExpress.XtraReports.Parameters.Parameter();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrPictureBox1});
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[AttachmeedFile]")});
            this.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.xrPictureBox1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBox1_BeforePrint);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // LineTotalCalcField
            // 
            this.LineTotalCalcField.DisplayName = "LineTotal";
            this.LineTotalCalcField.Expression = "[Parameters.UnitPriceParameter] * (1 + [Parameters.UnitTaxParameter] / 100) * [Pa" +
    "rameters.QuantityParameter]";
            this.LineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.LineTotalCalcField.Name = "LineTotalCalcField";
            // 
            // SubtotalCalcField
            // 
            this.SubtotalCalcField.DisplayName = "Subtotal";
            this.SubtotalCalcField.Expression = "Sum([LineTotalCalcField])";
            this.SubtotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.SubtotalCalcField.Name = "SubtotalCalcField";
            // 
            // TaxLineTotalCalcField
            // 
            this.TaxLineTotalCalcField.DisplayName = "TaxLineTotal";
            this.TaxLineTotalCalcField.Expression = "[Parameters.UnitPriceParameter] * [Parameters.QuantityParameter] * [Parameters.Un" +
    "itTaxParameter] / 100";
            this.TaxLineTotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.TaxLineTotalCalcField.Name = "TaxLineTotalCalcField";
            // 
            // TotalCalcField
            // 
            this.TotalCalcField.DisplayName = "Total";
            this.TotalCalcField.Expression = "[SubtotalCalcField]";
            this.TotalCalcField.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.TotalCalcField.Name = "TotalCalcField";
            // 
            // takeRow
            // 
            this.takeRow.Name = "takeRow";
            this.takeRow.Type = typeof(int);
            this.takeRow.ValueInfo = "1";
            this.takeRow.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.Type = typeof(int);
            this.id.ValueInfo = "0";
            this.id.Visible = false;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Constructor = objectConstructorInfo1;
            this.objectDataSource1.DataMember = "GetCustomersDto2";
            this.objectDataSource1.DataSource = typeof(ExmonSystem.Controls.AccountControl);
            this.objectDataSource1.Name = "objectDataSource1";
            parameter1.Name = "id";
            parameter1.Type = typeof(DevExpress.DataAccess.Expression);
            parameter1.Value = new DevExpress.DataAccess.Expression("?id", typeof(int));
            this.objectDataSource1.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter1});
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FullName]")});
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            // 
            // RptPassport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.LineTotalCalcField,
            this.SubtotalCalcField,
            this.TaxLineTotalCalcField,
            this.TotalCalcField});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20.12498F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 858.125F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 99.79159F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 79.58334F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new System.Drawing.Font("Arial", 9.75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new System.Drawing.Printing.Margins(30, 28, 30, 20)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "Margins", new System.Drawing.Printing.Margins(30, 28, 30, 32)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(424.0833F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "xrLabel1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPictureBox1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(84.99986F, 33.95834F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPictureBox1, "Default", "SizeF", new System.Drawing.SizeF(672.0001F, 432.4999F))});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.takeRow,
            this.id});
            this.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.CalculatedField LineTotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField SubtotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField TaxLineTotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField TotalCalcField;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.Parameters.Parameter takeRow;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.Parameters.Parameter id;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
