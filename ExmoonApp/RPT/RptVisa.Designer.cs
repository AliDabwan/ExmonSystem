
namespace ExmonSystem.RPT
{
    partial class RptVisa
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.LineTotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.SubtotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.TaxLineTotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.TotalCalcField = new DevExpress.XtraReports.UI.CalculatedField();
            this.FullName = new DevExpress.XtraReports.Parameters.Parameter();
            this.ApplyDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.ApprovalDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.VisaRandomId = new DevExpress.XtraReports.Parameters.Parameter();
            this.BirthDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.PassportNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.PhoneNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.DateBeforePrint14 = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateBeforePrint28 = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel1,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel7});
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?FullName")});
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ApplyDate")});
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PhoneNumber")});
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PassportNo")});
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?FullName")});
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?BirthDate")});
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ApprovalDate")});
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?VisaRandomId")});
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
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
            // GroupHeader2
            // 
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
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
            // FullName
            // 
            this.FullName.AllowNull = true;
            this.FullName.Name = "FullName";
            this.FullName.Visible = false;
            // 
            // ApplyDate
            // 
            this.ApplyDate.AllowNull = true;
            this.ApplyDate.Name = "ApplyDate";
            this.ApplyDate.Visible = false;
            // 
            // ApprovalDate
            // 
            this.ApprovalDate.AllowNull = true;
            this.ApprovalDate.Name = "ApprovalDate";
            this.ApprovalDate.Visible = false;
            // 
            // VisaRandomId
            // 
            this.VisaRandomId.AllowNull = true;
            this.VisaRandomId.Name = "VisaRandomId";
            this.VisaRandomId.Visible = false;
            // 
            // BirthDate
            // 
            this.BirthDate.AllowNull = true;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Visible = false;
            // 
            // PassportNo
            // 
            this.PassportNo.AllowNull = true;
            this.PassportNo.Name = "PassportNo";
            this.PassportNo.Visible = false;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AllowNull = true;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            // 
            // DateBeforePrint14
            // 
            this.DateBeforePrint14.AllowNull = true;
            this.DateBeforePrint14.Name = "DateBeforePrint14";
            this.DateBeforePrint14.Visible = false;
            // 
            // DateBeforePrint28
            // 
            this.DateBeforePrint28.AllowNull = true;
            this.DateBeforePrint28.Name = "DateBeforePrint28";
            this.DateBeforePrint28.Visible = false;
            // 
            // RptVisa
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.PageHeader,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.LineTotalCalcField,
            this.SubtotalCalcField,
            this.TaxLineTotalCalcField,
            this.TotalCalcField});
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 3.000005F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "ar", "HeightF", 32.16667F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateBeforePrint28, "Default", "Description", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 858.125F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FullName, "Default", "Description", "الاسم الانكليزي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.GroupHeader2, "Default", "HeightF", 94.87507F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PassportNo, "Default", "Description", "رقم الجواز"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new System.Drawing.Font("Arial", 9.75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new System.Drawing.Printing.Margins(30, 28, 30, 3)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "Margins", new System.Drawing.Printing.Margins(30, 28, 30, 32)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.VisaRandomId, "Default", "Description", "رقم فيزا عشوائي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 51.66664F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "xrLabel1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 100.625F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "xrLabel2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 179.7916F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Text", "xrLabel3"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 146.4584F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Text", "xrLabel4"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 222.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "Text", "xrLabel5"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 302.7084F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "Text", "xrLabel6"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 9.999974F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "Text", "xrLabel7"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(654.4999F, 260.6251F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "Text", "xrLabel4")});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FullName,
            this.ApplyDate,
            this.ApprovalDate,
            this.VisaRandomId,
            this.BirthDate,
            this.PassportNo,
            this.PhoneNumber,
            this.DateBeforePrint14,
            this.DateBeforePrint28});
            this.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.CalculatedField LineTotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField SubtotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField TaxLineTotalCalcField;
        private DevExpress.XtraReports.UI.CalculatedField TotalCalcField;
        private DevExpress.XtraReports.Parameters.Parameter FullName;
        private DevExpress.XtraReports.Parameters.Parameter ApplyDate;
        private DevExpress.XtraReports.Parameters.Parameter ApprovalDate;
        private DevExpress.XtraReports.Parameters.Parameter VisaRandomId;
        private DevExpress.XtraReports.Parameters.Parameter BirthDate;
        private DevExpress.XtraReports.Parameters.Parameter PassportNo;
        private DevExpress.XtraReports.Parameters.Parameter PhoneNumber;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.Parameters.Parameter DateBeforePrint14;
        private DevExpress.XtraReports.Parameters.Parameter DateBeforePrint28;
    }
}
