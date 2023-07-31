using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
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
    public partial class FrmCustomersDebits : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        int Accounttype { get; set; }
        string transType { get; set; }
        string rptType = "";
        public string formType { get; set; }
        AccountControl accControl = new AccountControl();
        public int mAccountId { get; set; }

        public FrmCustomersDebits()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
           

        }
        async Task GetLoad()
        {
            //itemProductUnitMvBindingSource.DataSource = await itemProductsControl.GetAllItemProducts();//db.itemCategories.ToList();

            accountsTransDTOBindingSource.DataSource = await accControl.GetAllAccountBlancesHasDebit(mAccountId);//db.itemCategories.ToList();

            //itemProductUnitMvBindingSource.Add(new ItemProduct());
            //itemProductUnitMvBindingSource.MoveLast();

        }
        async Task GetFilterdLoad(string filterd)
        {
            if (filterd == null || string.IsNullOrEmpty(filterd))
            {
              //  accountsBindingSource.DataSource = await accControl.GetAllProductStockTry();//db.itemCategories.ToList();

            }
            else
            {
           //     accountsBindingSource.DataSource = await accControl.GetAllProductStockTry(filterd);//db.itemCategories.ToList();

            }


        }
        async Task getMyRoll()
        {
            RollsControl control = new RollsControl();


            var myRoll = await control.getMyRoll(Program.userGroupId);


            if (myRoll == null)
            {
                return;
            }

            if (formType == "Customer")
            {
                foreach (var item in myRoll)
                {

                  


                }


            }

            if (formType == "Suplier")
            {
                foreach (var item in myRoll)
                {

                   

                  

                }


            }


        }

        private async void FrmCustomersDebits_Load(object sender, EventArgs e)
        {
          
            if (formType == "Cash")
            {
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "الحسابات النقدية";

                }
                else
                {
                    LblHeader.Text = "Cash Accounts";

                }
                LblHeader.BackColor = Color.Gray;
                Accounttype = 0;
                colAccountAddress.Visible = false;
                colAccountPhone.Visible = false;
               
            }
            if (formType == "Customer")
            {
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "قائمة العملاء المدينين";

                }
                else
                {
                    LblHeader.Text = "Customers Debit List";

                }
                LblHeader.BackColor = Color.Teal;
                Accounttype = 0;
                if (Properties.Settings.Default.Language == "ar")
                {
                    rptType = "تقرير العملاء المدينون";

                }
                else
                {
                    rptType = "Customer Debit Report";

                }
            }

            if (formType == "Suplier")
            {
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "قائمة الموردين الدائنين";

                }
                else
                {
                    LblHeader.Text = "Supliers Credit List";

                }
                if (Properties.Settings.Default.Language == "ar")
                {
                    rptType = "تقرير الموردين الدائنين";

                }
                else
                {
                    rptType = "Supliers Credit Report";

                }
                LblHeader.BackColor = Color.DarkRed;
                Accounttype = 1;

            }
            if (formType == "Expens")
            {
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "حسابات المصاريف";
                }
                else
                {
                    LblHeader.Text = "Expenses";

                }
                LblHeader.BackColor = Color.Olive;
                Accounttype = 0;
                transType = "سند قيد";
            }


            if (formType == "Receipt") //سندقبض
            {

                LblHeader.Text = "Receipts";
                LblHeader.BackColor = Color.Green;
                Accounttype = 0;
                transType = "سند قبض";
            }

            if (formType == "Payment") //سندصرف
            {

                LblHeader.Text = "Payments";
                LblHeader.BackColor = Color.FromArgb(64, 64, 64);
                Accounttype = 1;
                transType = "سند صرف";


            }



            await GetLoad();

            await getMyRoll();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            var obj = accountsTransDTOBindingSource.Current as AccountsTransDTO;
            if (obj.Id == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            var acc =await accControl.Getaccount(obj.Id);
            //var checkBooked = await myControl.GetAllBookingsByGuestId(obj.Id);

            if (acc.acctransnSub.Any())
            {
                DesktopAlert.Show("يوجد سجلات مرتطبة" + "\n" + "there are related records ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (helper.ShowMessageConfirm(this, "Confirm   تأكيد ", " Delete this Record ? | تاكيد حذف السجل ؟"))
            {
                await accControl.DeleteAcc(acc);
                await GetLoad();

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
        public bool createdb_BARACODE(DataTable B_TABLE)
        {
            DataSet invo = new DataSet();

            DataTable dd_bar = new DataTable();
            dd_bar = B_TABLE;
            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(dd_bar);
            invo.Tables[0].TableName = "item";
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "AccountsDebitReport.xml";
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

        async Task PrintLabels(bool Print)
        {
            var accDt = await accControl.GetAllAccountBlancesHasDebitReport(mAccountId);
            //MessageBox.Show(accDt.Rows.Count.ToString());
            if (createdb_BARACODE(accDt))
            {





                AccountDebitReports rd = new AccountDebitReports();//.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "AccountDebitReports.repx", true);



                rd.Parameters["accounttype"].Value = Accounttype;
                 rd.Parameters["accountid"].Value = mAccountId;
             
                    rd.Parameters["RptType"].Value = rptType;

                rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
                rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
                rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
                rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;

                foreach (var item in rd.Parameters)
                {
                    item.Visible = false;
                }


                using (ReportPrintTool printTool = new ReportPrintTool(rd))
                {
                    if (Print)
                    {
                        printTool.PrintDialog();

                    }
                    else
                    {
                        rd.CreateDocument(true);//

                        printTool.ShowPreviewDialog();

                    }
                    DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                    ds.Dispose();
                }

            }

        }

        private async void simpleButton7_Click(object sender, EventArgs e)
        {

        }

        private void designReportToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ReportDesignTool printTool = new ReportDesignTool(RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "AccountDebitReports.repx", true));
            printTool.ShowRibbonDesignerDialog();
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
        }

        private void DgvItems_Click(object sender, EventArgs e)
        {

        }

        private void accountTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;

            }
            AccountsTransDTO obj = accountsTransDTOBindingSource.Current as AccountsTransDTO;


            if (obj != null && obj.Id != 0)
            {
                var frm = new FrmAccountTransactions();
                frm.accountId = obj.Id;
                frm.Accounttype = Accounttype;
                frm.Text += obj.AccountName ;
                frm.AccountName = obj.AccountName;

                //frm.itemProductUnitMvBindingSource.DataSource = obj;// itemProductUnitMvBindingSource.Current;

                frm.ShowDialog();
            }
        }

        private void TxtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void simpleButton3_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount <= 0)
            {
                return;
            }


            await PrintLabels(true);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (!DgvItems.IsPrintingAvailable)
            {
                DesktopAlert.Show("حدثت مشكلة في التقرير , يرجى المحاولة لاحقا !");
                return;
            }
            if (!System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + @"\ExcellFiles"))
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + @"\ExcellFiles");
            }

            // Open the Preview window.
            //string path = string.Format(@"\ExcellFiles\الأدوار" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".xlsx");
            string path = System.Windows.Forms.Application.StartupPath + @"\ExcellFiles\"+ rptType + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".xlsx";

            gridView1.OptionsPrint.PrintHeader = true;
            XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.True;
            advOptions.AllowSortingAndFiltering = DevExpress.Utils.DefaultBoolean.True;
            advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.True;
            advOptions.ShowPageTitle = DevExpress.Utils.DefaultBoolean.True;
            advOptions.SheetName = rptType;




            DgvItems.ExportToXlsx(path, advOptions);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (!DgvItems.IsPrintingAvailable)
            {
                DesktopAlert.Show("حدثت مشكلة في التقرير , يرجى المحاولة لاحقا !");
                return;
            }
            if (!System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + @"\PdfFiles"))
            {
                System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + @"\PdfFiles");
            }

            // Open the Preview window.
            //string path = string.Format(@"\ExcellFiles\الأدوار" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".xlsx");
            string path = System.Windows.Forms.Application.StartupPath + @"\PdfFiles\"+ rptType + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".pdf";




            DgvItems.ExportToPdf(path);
        }
    }
}