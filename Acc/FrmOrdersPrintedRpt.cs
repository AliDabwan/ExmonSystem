using DevComponents.DotNetBar.Controls;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using ExmonSystem.Controls;
using ExmonSystem.Form;
using ExmonSystem.Models;
using ExmonSystem.RPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem.Acc
{
    public partial class FrmOrdersPrintedRpt : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
      

        bool ShowVoucherRoll = true;
        public string formType { get; set; }
        AccountControl accControl = new AccountControl();
        public int mAccountId { get; set; }
        public FrmOrdersPrintedRpt()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (formType == "Expens")
            {
                var frm = new Form.FrmPayments();
                frm.formType = "Expens";
                frm.mAccountId = mAccountId;
                frm.ShowDialog();
            }
            else if (formType == "Receipt") //سندقبض
            {
                var frm = new Form.FrmPayments();
                frm.formType = "Receipt";
                frm.mAccountId = mAccountId;
                frm.ShowDialog();

            }

            else if (formType == "Payment") //سندصرف
            {
                var frm = new Form.FrmPayments();
                frm.formType = "Payment";
                frm.mAccountId = mAccountId;
                frm.ShowDialog();



            }
            await GetLoad();

        }
        int IsFilter = 0;

        IEnumerable<OrderDto> myList = new List<OrderDto>();

        int ispaid = 0;
        bool ispaidbool = false;
        async Task GetLoad()
        {

            //if (formType == "Receipt") //سندقبض
            //{
            //    parcelBindingSource.DataSource = await accControl.GetAccountsSubtMovementBytransType(formType,EntryType);//db.itemCategories.ToList();


            //}
            //else if (formType == "Payment") //سندصرف
            //{

            //    parcelBindingSource.DataSource = await accControl.GetAccountsSubtMovementBytransType(formType, EntryType);//db.itemCategories.ToList();




            //}else
            //{

            IsFilter = radioFilter.SelectedIndex;
            if (IsFilter == 1)
            {

                
               




                try
                {
                    var CarType = TxtGover.GetSelectedDataRow() as ExCompanyDTO;
                    if (CarType != null)
                    {
                        isGover = CarType.Id;

                    }
                }
                catch 
                {

                    isGover = 0 ;
                }
               


            }else
            {
              
                isGover = 0;
            }

            if (isGover==0)
            {
                isGover = 0;

            }

          
            
            myList= await accControl.GetAllOrdersPrined(TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date, isGover);//db.itemCategories.ToList();

            orderDtoBindingSource.DataSource = myList;
            //}
            gridView1.UpdateSummary();




            TxtTotalAll.Text = myList.Select(x => x.Id).Count().ToString(SD.NumDec) ;// mydto.Total.ToString("N0");
            



                TxtProfitNet.Text = myList.Select(x => x.TotalAmount).Sum().ToString(SD.NumDec);// mydto.Total.ToString("N0");

            //DesktopAlert.Show(mydto.Total+"");

            //getMyAccBalance(Properties.Settings.Default.PropBAccountSales);
            //getMyAccBalance(Properties.Settings.Default.PropBAccountCash);


        }


        int isGover=0;
       

        public List<ExCompanyDTO> elistGover = new List<ExCompanyDTO>();

        async Task GetGover()
        {
            ItemGoverControl itemunitcontrol = new ItemGoverControl();

            var xx = await itemunitcontrol.GetAllExCompanies();
            elistGover.Add(new ExCompanyDTO() { Id = 0, Name = "الكل" });

            foreach (var item in xx)
            {
                elistGover.Add(new ExCompanyDTO() { Id = item.Id, Name = item.Name });

            }

            TxtGover.Properties.DataSource = elistGover;
            TxtGover.Properties.DisplayMember = "Name";
            TxtGover.Properties.ValueMember = "Id";
            TxtGover.Properties.PopulateColumns();
            TxtGover.Properties.Columns[0].Caption = "#";
            TxtGover.Properties.Columns[1].Caption = "اسم الشركة";
            TxtGover.Properties.Columns[2].Visible = false;
            TxtGover.Properties.Columns[3].Visible = false;
            TxtGover.Properties.Columns[4].Visible = false;
            TxtGover.Properties.Columns[5].Visible = false;
            TxtGover.Properties.Columns[6].Visible = false;
            TxtGover.Properties.Columns[7].Visible = false;
            TxtGover.Properties.Columns[8].Visible = false;
            TxtGover.Properties.Columns[9].Visible = false;
            TxtGover.Properties.Columns[10].Visible = false;

            if (elistGover.Count <= 0)
            {
                return;
            }


        }
        private async void FrmCustomersList_Load(object sender, EventArgs e)
        {
            radioGroup1.SelectedIndex = 1;
            this.Text = LblHeader.Text;
            await GetGover();

            //GridColumnSummaryItem siTotal = new GridColumnSummaryItem();
            //siTotal.SummaryType = SummaryItemType.Count;
            //siTotal.DisplayFormat = "{0}";
            //gridView1.Columns["VoucherNo"].Summary.Add(siTotal);
            //GridColumnSummaryItem FromAmount = new GridColumnSummaryItem();
            //FromAmount.SummaryType = SummaryItemType.Sum;
            //FromAmount.DisplayFormat = "Total Debit : {0:N2}";
            //gridView1.Columns["FromAmount"].Summary.Add(FromAmount);
            //gridView1.OptionsView.ShowFooter = true;



            //GridColumnSummaryItem ToAmount = new GridColumnSummaryItem();
            //ToAmount.SummaryType = SummaryItemType.Sum;
            //ToAmount.DisplayFormat = "Total Credit : {0:N2}";
            //gridView1.Columns["ToAmount"].Summary.Add(ToAmount);
            gridView1.OptionsView.ShowFooter = true;


            await GetLoad();
            //await getMyRoll();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            //if (gridView1.RowCount <= 0)
            //{
            //    DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

            //    return;
            //}
            //AccountsTransactionSub obj = orderDtoBindingSource.Current as AccountsTransactionSub;
            //if (obj.TransId == 0)
            //{
            //    DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

            //    return;
            //}
            //if (helper.ShowMessageConfirm(this, "Confirm   تأكيد ", " Delete this Record ? | تاكيد حذف السجل ؟"))
            //{
            //  var conf=  await accControl.DeleteTransAcc(obj.EntryId,obj.TransRefType);
            //    if (conf)
            //    {                  DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
            //        await GetLoad();

            //    }

            //}
        }
        public bool createdb_eXP(DataTable B_TABLE)
        {
            DataSet invo = new DataSet();

            DataTable dd_bar = new DataTable();
            dd_bar = B_TABLE;
            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(dd_bar);
            invo.Tables[0].TableName = "item";
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "AccountsSummayReport.xml";

            //string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "AccountExpensesReports.xml";
            if (File.Exists(outpath))
            {
                System.IO.File.Delete(outpath);
            }
            using (TextWriter tw = File.CreateText(outpath))
            {

                invo.WriteXml(tw, XmlWriteMode.WriteSchema);
                tw.Close();
            }
            B_TABLE.DataSet.Clear();
            B_TABLE.Dispose();
            dd_bar.DataSet.Clear();
            dd_bar.Dispose();
            invo.Tables.Clear();
            invo.Dispose();
            return true;
            //     System.Windows.Forms.MessageBox.Show("dispos");
        }

        public bool createdb_BARACODE(DataTable B_TABLE)
        {
            DataSet invo = new DataSet();

            DataTable dd_bar = new DataTable();
            dd_bar = B_TABLE;
            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(dd_bar);
            invo.Tables[0].TableName = "item"; 
                            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "OrdersRpt.xml";

            //string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "AccountExpensesReports.xml";
            if (File.Exists(outpath))
            {
                System.IO.File.Delete(outpath);
            }
            using (TextWriter tw = File.CreateText(outpath))
            {

                invo.WriteXml(tw, XmlWriteMode.WriteSchema);
                tw.Close();
            }
            B_TABLE.DataSet.Clear();
            B_TABLE.Dispose();
            dd_bar.DataSet.Clear();
            dd_bar.Dispose();
            invo.Tables.Clear();
            invo.Dispose();
            return true;
            //     System.Windows.Forms.MessageBox.Show("dispos");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
        async Task PrintLabels(bool prnt)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            await GetLoad();
            var accDt = await accControl.Getdatatable(myList) ;
            //MessageBox.Show(accDt.Rows.Count.ToString());
            if (createdb_BARACODE(accDt))
            {





                XtraReport rd = RptOrders.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptOrders.repx", true);





                    rd.Parameters["title"].Value = LblHeader.Text;
                    rd.Parameters["gover"].Value = TxtGover.Text == "اختر النوع" ? "الكل" : TxtGover.Text;
                    //rd.Parameters["TotalNet"].Value = TxtTotalAll.Text;
                    //rd.Parameters["TotalAmount"].Value = TxtTotalAll.Text;






                    rd.Parameters["datefrom"].Value = TxtDateFrom.DateTime.Date;
                    rd.Parameters["dateto"].Value = TxtDateTo.DateTime.Date;


                    rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
                    rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
                    rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
                    rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
                    rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;
                    foreach (var item in rd.Parameters)
                    {
                        if (item.Name == "lang")
                        {
                            item.Value = Properties.Settings.Default.Language;
                        }
                        item.Visible = false;
                    }


                    using (ReportPrintTool printTool = new ReportPrintTool(rd))
                    {
                        if (!prnt)
                        {
                            rd.CreateDocument(true);//

                            printTool.ShowPreviewDialog();

                        }
                        else
                        {

                            printTool.PrintDialog();

                        }
                        DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                        ds.Dispose();
                    }

                
            }

        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            await PrintLabels(false);
        }

        private async void simpleButton7_Click(object sender, EventArgs e)
        {
            //await GetReport(true);

        }
        //async Task GetReport(bool Prnt)
        //{
        //    DataTable dtt = new DataTable();
          
        //        dtt = await accControl.GetAllAccountRpt(mAccountId);//db.itemCategories.ToList();


        //    helper.Reportt(dtt, "‏‏rpt_Accounts", "Accounts List قائمة الحسابات", formType, "", "A4", Prnt, 1, 1, false, "");

        //    //itemProductUnitMvBindingSource.Add(new ItemProduct());
        //    //itemProductUnitMvBindingSource.MoveLast();

        //}

        private void designReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XtraReport rd = new XtraReport();

                rd = RptOrders.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptOrders.repx", true);


                rd.ShowRibbonDesignerDialog();
            }
            catch 
            {

                return ;
            }
          
        }

        private void DgvItems_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private async void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;

            }
           
        }

        private void accountTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;

            }
            //Accounts obj = accountsBindingSource.Current as Accounts;

            //if (obj != null && obj.Id != 0)
            //{
            //    var frm = new FrmAccountTransactions();
            //    frm.accountId = obj.Id;
            //    frm.Accounttype = Accounttype;
            //    frm.Text += obj.AccountName ;
            //    frm.AccountName = obj.AccountName;

            //    //frm.itemProductUnitMvBindingSource.DataSource = obj;// itemProductUnitMvBindingSource.Current;

            //    frm.ShowDialog();
            //}
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (formType == "Expens")
            //{
            //    return;
         
        }
        void PrintLabels(string Barcode, bool isPrint, string mydate)
        {

            //PRINTBarcodxtra("Roll");

            RptBarcode50X25 rd = new RptBarcode50X25();//.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptBarcode50X25.repx", true);

            var company = "";

            //company = Properties.Settings.Default.COMPANY;


            rd.Parameters["Barcode"].Value = Barcode;
            rd.Parameters["myDate"].Value = mydate;
            //rd.Parameters["Voucher"].Value = "";
            //rd.Parameters["SenderName"].Value = "";
            //rd.Parameters["SenderPhone"].Value = "";
            //rd.Parameters["VendorName"].Value = "";
            rd.Parameters["CompanyName"].Visible = false;
            foreach (var item in rd.Parameters)
            {
                item.Visible = false;
            }
            using (ReportPrintTool printTool = new ReportPrintTool(rd))
            {

                if (isPrint)
                {
                    if (string.IsNullOrEmpty(Properties.Settings.Default.PRINTER_PARACOD))
                    {
                        DesktopAlert.Show("يجب إختيار طابعة الباركود");
                        var frmst = new FrmStrat();
                        frmst.ShowDialog();
                        return;
                    }
                    printTool.PrinterSettings.PrinterName = Properties.Settings.Default.PRINTER_PARACOD;
                    //printTool.PrinterSettings.Copies = (short)Properties.Settings.Default.PropNumricPrintInvoice;
                    printTool.Print();

                }
                else
                {
                    rd.CreateDocument(true);//

                    printTool.ShowPreviewDialog();

                }


            }

            //ReportPrintTool printTool = new ReportPrintTool(RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true));



            //if (helper.ShowMessageConfirmForBarcodPrint(this, "Barcod Paper Type", "Please Select the Barcod Paper ! يرجى تحديد نوع الملصقات المطلوبة", "A4 Labels", "Roll Labels "))
            //{
            //    //a4
            //    PRINTPARCOD("A4");
            //}
            //else
            //{//rool
            //    PRINTPARCOD("Roll");

            //}

        }

        private void DgvItems_Click_1(object sender, EventArgs e)
        {

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)//today
            {
                TxtDateFrom.DateTime = DateTime.Now;
                TxtDateTo.DateTime = DateTime.Now;
                TxtDateFrom.Enabled = false;
                TxtDateTo.Enabled = false;
            }
            else if (radioGroup1.SelectedIndex == 1)//فترتين 
            {
                TxtDateFrom.Enabled = true;
                TxtDateTo.Enabled = true;
                TxtDateFrom.DateTime = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + "01" + "-" + "01");
                TxtDateTo.DateTime = DateTime.Now;
            }
            else if (radioGroup1.SelectedIndex == 2)//الكل 
            {
                TxtDateFrom.DateTime = Convert.ToDateTime("2021" + "-" + "01" + "-" + "01");
                TxtDateTo.DateTime = DateTime.Now;
                TxtDateFrom.Enabled = false;
                TxtDateTo.Enabled = false;

            }

        }

        private async void simpleButton3_Click_1(object sender, EventArgs e)
        {
            await GetLoad();

        }

        private async void TxtVendor_EditValueChanged(object sender, EventArgs e)
        {
            radioFilter.SelectedIndex=1;
            await GetLoad();

        }

        private async void TxtSender_EditValueChanged(object sender, EventArgs e)
        {
            radioFilter.SelectedIndex = 1;

            await GetLoad();

        }

        private async void TxtGover_EditValueChanged(object sender, EventArgs e)
        {
            radioFilter.SelectedIndex = 1;

            await GetLoad();


        }

        private  void RadioVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void طباعةالباركودToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private  void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

      

        private  void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
        }

        private void radioGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            OrderDto obj = orderDtoBindingSource.Current as OrderDto;

            if (obj != null && obj.Id != 0)
            {
                FrmOrderPrint ffd = new FrmOrderPrint();
                ffd.Id = obj.Id;
                ffd.ExCompanyId = obj.ExCompanyId;

                ffd.TxtCompanyEn.Text = obj.CompanyNameEn;
                ffd.ShowDialog();

            }
        }

        private void RadioFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }

            if (e.Column.Name == "gridColumnPay")
            {

                OrderDto obj = orderDtoBindingSource.Current as OrderDto;
                if (obj != null)
                {
                    if (obj.Id == 0)
                    {
                        return;
                    }
                    if (obj.IsPaid)
                    {
                        DesktopAlert.Show("هذا الطلب مسدد مسبقا !", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                        return;
                    }
                    if (helper.ShowMessageConfirm(this, " تأكيد ", " تأكيد سداد هذا الطلب"))
                    {
                        var rslt = await accControl.EditOrderPay(obj);
                        if (rslt>0)
                        {
                            DesktopAlert.Show("تم سداد الطلب بنجاح", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                            await GetLoad();


                        }
                        else
                        {
                            DesktopAlert.Show("لم يتم السداد", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        }
                    }



                    //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
                }
            }
        }
    }
}