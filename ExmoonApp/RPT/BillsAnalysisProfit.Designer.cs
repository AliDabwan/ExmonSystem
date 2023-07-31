
namespace ExmonSystem.RPT
{
    partial class BillsAnalysisProfit
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsAnalysisProfit));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lblCompanyDetailsEn = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCompanyPhone2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCompanyDetailsAr = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCompanyAr = new DevExpress.XtraReports.UI.XRLabel();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.custsuplier = new DevExpress.XtraReports.Parameters.Parameter();
            this.datefrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.dateto = new DevExpress.XtraReports.Parameters.Parameter();
            this.billtype = new DevExpress.XtraReports.Parameters.Parameter();
            this.CompanyName = new DevExpress.XtraReports.Parameters.Parameter();
            this.CompanyDetails = new DevExpress.XtraReports.Parameters.Parameter();
            this.CompanyTax = new DevExpress.XtraReports.Parameters.Parameter();
            this.CompanyPhone = new DevExpress.XtraReports.Parameters.Parameter();
            this.logoPath = new DevExpress.XtraReports.Parameters.Parameter();
            this.totalSum = new DevExpress.XtraReports.Parameters.Parameter();
            this.lang = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.calculatedDate = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedNo = new DevExpress.XtraReports.UI.CalculatedField();
            this.valuNumber = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.lblCompanyDetailsEn,
            this.lblCompanyPhone2,
            this.lblCompanyDetailsAr,
            this.lblCompanyAr,
            this.pictureBox1});
            this.TopMargin.Name = "TopMargin";
            // 
            // xrLine1
            // 
            this.xrLine1.Name = "xrLine1";
            // 
            // lblCompanyDetailsEn
            // 
            this.lblCompanyDetailsEn.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?CompanyTax")});
            this.lblCompanyDetailsEn.Multiline = true;
            this.lblCompanyDetailsEn.Name = "lblCompanyDetailsEn";
            this.lblCompanyDetailsEn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCompanyDetailsEn.StylePriority.UseFont = false;
            this.lblCompanyDetailsEn.StylePriority.UseTextAlignment = false;
            this.lblCompanyDetailsEn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblCompanyPhone2
            // 
            this.lblCompanyPhone2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?CompanyPhone")});
            this.lblCompanyPhone2.Multiline = true;
            this.lblCompanyPhone2.Name = "lblCompanyPhone2";
            this.lblCompanyPhone2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCompanyPhone2.StylePriority.UseFont = false;
            this.lblCompanyPhone2.StylePriority.UseTextAlignment = false;
            this.lblCompanyPhone2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblCompanyDetailsAr
            // 
            this.lblCompanyDetailsAr.AutoWidth = true;
            this.lblCompanyDetailsAr.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?CompanyDetails")});
            this.lblCompanyDetailsAr.Multiline = true;
            this.lblCompanyDetailsAr.Name = "lblCompanyDetailsAr";
            this.lblCompanyDetailsAr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCompanyDetailsAr.StylePriority.UseFont = false;
            this.lblCompanyDetailsAr.StylePriority.UseTextAlignment = false;
            this.lblCompanyDetailsAr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblCompanyAr
            // 
            this.lblCompanyAr.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?CompanyName")});
            this.lblCompanyAr.Multiline = true;
            this.lblCompanyAr.Name = "lblCompanyAr";
            this.lblCompanyAr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCompanyAr.StylePriority.UseFont = false;
            this.lblCompanyAr.StylePriority.UseTextAlignment = false;
            this.lblCompanyAr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "?logoPath")});
            this.pictureBox1.ImageUrl = "?logoPath";
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrPageInfo3,
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrLine3
            // 
            this.xrLine3.Name = "xrLine3";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.UserName;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(241)))));
            this.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("calculatedNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseBackColor = false;
            this.Detail.StylePriority.UseBorders = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.BackColor = System.Drawing.Color.White;
            this.ReportHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1});
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBackColor = false;
            this.ReportHeader.StylePriority.UseBorders = false;
            this.ReportHeader.StylePriority.UseTextAlignment = false;
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.Name = "xrLine2";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?dateto")});
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?datefrom")});
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?billtype")});
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PrintAtBottom = true;
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart1.DataMember = "item";
            this.xrChart1.DataSource = this.sqlDataSource1;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.MinorCount = 4;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Diagram = xyDiagram1;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.SeriesDataMember = "BillDayDate";
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.xrChart1.SeriesTemplate.ArgumentDataMember = "BillDayDate";
            this.xrChart1.SeriesTemplate.SeriesDataMember = "BillDayDate";
            this.xrChart1.SeriesTemplate.ValueDataMembersSerializable = "valuNumber";
            this.xrChart1.SeriesTemplate.View = stackedBarSeriesView1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BillsReports";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "BillDate";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"643\" />";
            table1.Name = "item";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "BillNet";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "BillProfit";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "BillDayDate";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "item";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
            this.PageHeader.Name = "PageHeader";
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // custsuplier
            // 
            this.custsuplier.AllowNull = true;
            this.custsuplier.Name = "custsuplier";
            // 
            // datefrom
            // 
            this.datefrom.AllowNull = true;
            this.datefrom.Name = "datefrom";
            this.datefrom.ValueInfo = "0";
            // 
            // dateto
            // 
            this.dateto.AllowNull = true;
            this.dateto.Name = "dateto";
            this.dateto.ValueInfo = "0";
            // 
            // billtype
            // 
            this.billtype.AllowNull = true;
            this.billtype.Name = "billtype";
            // 
            // CompanyName
            // 
            this.CompanyName.AllowNull = true;
            this.CompanyName.Name = "CompanyName";
            // 
            // CompanyDetails
            // 
            this.CompanyDetails.AllowNull = true;
            this.CompanyDetails.Name = "CompanyDetails";
            // 
            // CompanyTax
            // 
            this.CompanyTax.AllowNull = true;
            this.CompanyTax.Name = "CompanyTax";
            // 
            // CompanyPhone
            // 
            this.CompanyPhone.AllowNull = true;
            this.CompanyPhone.Name = "CompanyPhone";
            // 
            // logoPath
            // 
            this.logoPath.AllowNull = true;
            this.logoPath.Name = "logoPath";
            // 
            // totalSum
            // 
            this.totalSum.AllowNull = true;
            this.totalSum.MultiValue = true;
            this.totalSum.Name = "totalSum";
            // 
            // lang
            // 
            this.lang.AllowNull = true;
            this.lang.Name = "lang";
            this.lang.ValueInfo = "ar";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3,
            this.xrTable4});
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.StylePriority.UseBorders = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15});
            this.xrTableRow3.Name = "xrTableRow3";
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBorders = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.StylePriority.UseBorders = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21});
            this.xrTableRow4.Name = "xrTableRow4";
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([BillDayDate])")});
            this.xrTableCell21.Multiline = true;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Page;
            this.xrTableCell21.Summary = xrSummary1;
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // calculatedDate
            // 
            this.calculatedDate.DataMember = "item";
            this.calculatedDate.DisplayName = "calculatedDate";
            this.calculatedDate.Expression = "GetDate([BillDate])";
            this.calculatedDate.FieldType = DevExpress.XtraReports.UI.FieldType.DateTime;
            this.calculatedDate.Name = "calculatedDate";
            // 
            // calculatedNo
            // 
            this.calculatedNo.DataMember = "item";
            this.calculatedNo.Expression = "ToDouble([BillNo])";
            this.calculatedNo.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.calculatedNo.Name = "calculatedNo";
            // 
            // valuNumber
            // 
            this.valuNumber.DataMember = "item";
            this.valuNumber.Expression = "ToDecimal([BillProfit]\n)";
            this.valuNumber.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.valuNumber.Name = "valuNumber";
            // 
            // BillsAnalysisProfit
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter,
            this.PageHeader,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedDate,
            this.calculatedNo,
            this.valuNumber});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "item";
            this.DataSource = this.sqlDataSource1;
            this.Landscape = true;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new System.Drawing.Font("Arial", 9.75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new System.Drawing.Printing.Margins(27, 25, 129, 53)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", System.Drawing.Printing.PaperKind.Custom),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 53F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.CompanyTax, "Default", "Description", "Parameter1"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyAr, "Default", "Font", new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyAr, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(860.3772F, 4.000028F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyAr, "Default", "SizeF", new System.Drawing.SizeF(248.0406F, 53.12502F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyDetailsAr, "Default", "Font", new System.Drawing.Font("Times New Roman", 12F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyDetailsAr, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(858.8157F, 57.12505F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyDetailsAr, "Default", "SizeF", new System.Drawing.SizeF(253.1842F, 56.61061F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyDetailsEn, "Default", "Font", new System.Drawing.Font("Times New Roman", 12F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyDetailsEn, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(7F, 20.41667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyDetailsEn, "Default", "SizeF", new System.Drawing.SizeF(207.2917F, 42.70835F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyPhone2, "Default", "Font", new System.Drawing.Font("Times New Roman", 12F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyPhone2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(7F, 66.12502F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCompanyPhone2, "Default", "SizeF", new System.Drawing.SizeF(207.2917F, 42.70835F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.logoPath, "Default", "Description", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 59.99991F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "ar", "HeightF", 59.99991F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "Visible", false),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 403.2914F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "ar", "HeightF", 411.2913F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(507.2982F, 4.00006F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pictureBox1, "Default", "SizeF", new System.Drawing.SizeF(164.5833F, 109.7356F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportHeader, "Default", "HeightF", 107.7918F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportHeader, "ar", "HeightF", 107.7918F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 129F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "ar", "HeightF", 129F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrChart1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(16.99985F, 7.666397F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrChart1, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(7.000001F, 7.666397F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrChart1, "Default", "SizeF", new System.Drawing.SizeF(1090F, 395.625F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrChart1, "ar", "SizeF", new System.Drawing.SizeF(1100F, 395.625F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Font", new System.Drawing.Font("Arial", 14F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(359.7462F, 4.291677F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(460.8434F, 34.45832F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "Bills Report"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "Text", "تقرير الفواتير"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Font", new System.Drawing.Font("Arial", 12F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(560.7878F, 47.74997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(490.901F, 47.74997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "SizeF", new System.Drawing.SizeF(138.1863F, 23.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Text", "xrLabel2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "TextFormatString", "{0:dd/MM/yyyy}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Font", new System.Drawing.Font("Arial", 12F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(560.7878F, 72.7917F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(490.901F, 72.7917F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "SizeF", new System.Drawing.SizeF(138.1863F, 23.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Text", "xrLabel2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "TextFormatString", "{0:dd/MM/yyyy}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "Font", new System.Drawing.Font("Arial", 12F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(507.2982F, 47.74997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(633.4652F, 47.74997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "SizeF", new System.Drawing.SizeF(53.4897F, 23.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "Text", "From :"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "ar", "Text", ": من "),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "Font", new System.Drawing.Font("Arial", 12F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(507.2982F, 72.7917F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(633.4652F, 72.7917F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "SizeF", new System.Drawing.SizeF(53.48969F, 23.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "Text", "To :"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "ar", "Text", ": الى"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLine1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 119F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLine1, "Default", "SizeF", new System.Drawing.SizeF(1117F, 10.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLine2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 95.79172F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLine2, "Default", "SizeF", new System.Drawing.SizeF(1117F, 12.00003F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLine3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLine3, "Default", "SizeF", new System.Drawing.SizeF(1117F, 10.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(560.7877F, 9.999974F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo1, "Default", "SizeF", new System.Drawing.SizeF(100F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo1, "Default", "TextFormatString", "Page{0}/{1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(11.56136F, 11.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo2, "Default", "SizeF", new System.Drawing.SizeF(205.6012F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo2, "Default", "TextFormatString", "{0:d MMMM, yyyy hh:mm tt}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1027.667F, 11F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo3, "Default", "SizeF", new System.Drawing.SizeF(84.33337F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(11.56136F, 8.999974F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(977.9009F, 4.999974F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "SizeF", new System.Drawing.SizeF(94.37738F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "ar", "SizeF", new System.Drawing.SizeF(134.0989F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(11.56136F, 33.99991F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(977.9009F, 29.99991F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "Default", "SizeF", new System.Drawing.SizeF(94.37738F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "ar", "SizeF", new System.Drawing.SizeF(134.0989F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Font", new System.Drawing.Font("Arial", 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Text", "Count"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "ar", "Text", "عدد"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Weight", 3.3639426705412556D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "ar", "Weight", 0.76310161572302293D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Font", new System.Drawing.Font("Arial", 9.75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Text", "xrTableCell6"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Weight", 3.3639426705412561D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "ar", "Weight", 0.76310161572302293D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow3, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow4, "Default", "Weight", 1D)});
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.custsuplier,
            this.datefrom,
            this.dateto,
            this.billtype,
            this.CompanyName,
            this.CompanyDetails,
            this.CompanyTax,
            this.CompanyPhone,
            this.logoPath,
            this.totalSum,
            this.lang});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lblCompanyDetailsEn;
        private DevExpress.XtraReports.UI.XRLabel lblCompanyPhone2;
        private DevExpress.XtraReports.UI.XRLabel lblCompanyDetailsAr;
        private DevExpress.XtraReports.UI.XRLabel lblCompanyAr;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.Parameters.Parameter custsuplier;
        private DevExpress.XtraReports.Parameters.Parameter datefrom;
        private DevExpress.XtraReports.Parameters.Parameter dateto;
        private DevExpress.XtraReports.Parameters.Parameter billtype;
        private DevExpress.XtraReports.Parameters.Parameter CompanyName;
        private DevExpress.XtraReports.Parameters.Parameter CompanyDetails;
        private DevExpress.XtraReports.Parameters.Parameter CompanyTax;
        private DevExpress.XtraReports.Parameters.Parameter CompanyPhone;
        private DevExpress.XtraReports.Parameters.Parameter logoPath;
        private DevExpress.XtraReports.Parameters.Parameter totalSum;
        private DevExpress.XtraReports.Parameters.Parameter lang;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.CalculatedField calculatedDate;
        private DevExpress.XtraReports.UI.CalculatedField calculatedNo;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.UI.CalculatedField valuNumber;
    }
}
