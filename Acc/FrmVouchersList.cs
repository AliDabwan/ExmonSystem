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
    public partial class FrmVouchersList : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        int Accounttype { get; set; }
        string transType { get; set; }
        string EntryType { get; set; }

        bool ShowVoucherRoll = true;
        public string formType { get; set; }
        public string formTypeAr { get; set; }
        AccountControl accControl = new AccountControl();
        public int mAccountId { get; set; }
        public FrmVouchersList()
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
                frm.transType = "دفعة مقدم";
                frm.mAccountId = mAccountId;
                frm.ShowDialog();



            }
            await GetLoad();

        }
        async Task GetLoad()
        {

            //if (formType == "Receipt") //سندقبض
            //{
            //    accountsTransactionSubBindingSource.DataSource = await accControl.GetAccountsSubtMovementBytransType(formType,EntryType);//db.itemCategories.ToList();


            //}
            //else if (formType == "Payment") //سندصرف
            //{

            //    accountsTransactionSubBindingSource.DataSource = await accControl.GetAccountsSubtMovementBytransType(formType, EntryType);//db.itemCategories.ToList();


            if (formTypeAr== "دفعة مقدم")
            {
                accountsTransactionSubBindingSource.DataSource = await accControl.GetAccountsSubtMovementBytransType(formType, formTypeAr, EntryType, TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date);//db.itemCategories.ToList();

            }
            else
            {
                accountsTransactionSubBindingSource.DataSource = await accControl.GetAccountsSubtMovementBytransType(formType, EntryType, TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date);//db.itemCategories.ToList();

            }

            //}else
            //{

            //}
            gridView1.UpdateSummary();

        }
        async Task getMyRoll()
        {
            RollsControl control = new RollsControl();


            var myRoll = await control.getMyRoll(Program.userGroupId);


            if (myRoll == null)
            {
                return;
            }
            editToolStripMenuItem.Enabled = false;
            simpleButton2.Visible = false;
            simpleButton1.Visible = false;
            if (formType == "Receipt")
            {
                foreach (var item in myRoll)
                {

                    if (item.RollTitle == "حذف سند قبض")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                        else
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);

                        }
                    }

                    if (item.RollTitle == "سند قبض")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton1.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                        else
                        {
                            simpleButton1.Visible = Convert.ToBoolean(item.IsChecked);

                        }
                    }

                    if (item.RollTitle == "عرض سند قبض")
                    {
                        if (item.IsChecked == "False")
                        {
                            editToolStripMenuItem.Enabled = Convert.ToBoolean(item.IsChecked);
                        }
                        else
                        {
                            editToolStripMenuItem.Enabled = Convert.ToBoolean(item.IsChecked);

                        }
                    }

                }


            }

            if (formType == "Payment"|| formType == "Expens")
            {
                foreach (var item in myRoll)
                {

                    if (item.RollTitle == "حذف سند دفع")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                        else
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);

                        }
                    }

                    if (item.RollTitle == "سند دفع")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton1.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                        else
                        {
                            simpleButton1.Visible = Convert.ToBoolean(item.IsChecked);

                        }
                    }

                    if (item.RollTitle == "عرض سند دفع")
                    {
                        if (item.IsChecked == "False")
                        {
                            editToolStripMenuItem.Enabled = Convert.ToBoolean(item.IsChecked);
                        }
                        else
                        {
                            editToolStripMenuItem.Enabled = Convert.ToBoolean(item.IsChecked);

                        }
                    }


                }


            }


        }

        private async void FrmCustomersList_Load(object sender, EventArgs e)
        {
            radioGroup1.SelectedIndex = 1;
            if (formType == "Expens")
            {
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "سندات مصاريف";

                }
                else
                {
                    LblHeader.Text = "Expenses";

                }
                LblHeader.BackColor = Color.Olive;
                Accounttype = 0;
                transType = "سند قيد مصروف";
                EntryType = "مدين";
            }


            if (formType == "Receipt") //سندقبض
            {


                gridView1.Columns["FromAmount"].Visible = false;
                gridView1.Columns["ToAmount"].Visible = true;

                if (Properties.Settings.Default.Language == "ar")
                {
                    //LblHeader.Text = "المدفوعات المقدمة للمرسلين";
                    LblHeader.Text = "سندات القبض";

                }
                else
                {
                    LblHeader.Text = "Receipts";

                }
                LblHeader.BackColor = Color.Green;
                Accounttype = 0;
                transType = "سند قبض";
                EntryType = "دائن";

            }

            if (formType == "Payment") //سندصرف
            {
                gridView1.Columns["FromAmount"].Visible = true;
                gridView1.Columns["ToAmount"].Visible = false;

                if (Properties.Settings.Default.Language == "ar")
                {
                    //LblHeader.Text = "سندات الصرف";
                    LblHeader.Text = "المدفوعات المقدمة للمرسلين";

                }
                else
                {
                    LblHeader.Text = "Payment";

                }
                LblHeader.BackColor = Color.FromArgb(64, 64, 64);
                Accounttype = 1;
                transType = "سند صرف";
                EntryType = "مدين";


            }


            GridColumnSummaryItem siTotal = new GridColumnSummaryItem();
            siTotal.SummaryType = SummaryItemType.Count;
            siTotal.DisplayFormat = "{0}";
            gridView1.Columns["TransId"].Summary.Add(siTotal);
            GridColumnSummaryItem FromAmount = new GridColumnSummaryItem();
            FromAmount.SummaryType = SummaryItemType.Sum;
            FromAmount.DisplayFormat = "Total Debit : {0:N2}";
            gridView1.Columns["FromAmount"].Summary.Add(FromAmount);
            gridView1.OptionsView.ShowFooter = true;



            GridColumnSummaryItem ToAmount = new GridColumnSummaryItem();
            ToAmount.SummaryType = SummaryItemType.Sum;
            ToAmount.DisplayFormat = "Total Credit : {0:N2}";
            gridView1.Columns["ToAmount"].Summary.Add(ToAmount);
            gridView1.OptionsView.ShowFooter = true;

            this.Text = LblHeader.Text;

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
            AccountsTransactionSub obj = accountsTransactionSubBindingSource.Current as AccountsTransactionSub;
            if (obj.TransId == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (helper.ShowMessageConfirm(this, "Confirm   تأكيد ", " Delete this Record ? | تاكيد حذف السجل ؟"))
            {
              var conf=  await accControl.DeleteTransAcc(obj.EntryId,obj.TransRefType);
                if (conf)
                {                  DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                    await GetLoad();

                }

            }
        }
        public bool createdb_BARACODE(DataTable B_TABLE)
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            flyoutPanel1.ShowBeakForm();

        }
        async Task PrintLabels(bool prnt)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
          
                var accDt = formTypeAr == "دفعة مقدم"?
                    await accControl.GetAccountsSubtMovementBytransTypeReport(formType, formTypeAr,EntryType, TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date)
                    :await accControl.GetAccountsSubtMovementBytransTypeReport(formType,EntryType, TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date)
                    
                    ;
            //MessageBox.Show(accDt.Rows.Count.ToString());
            if (createdb_BARACODE(accDt))
            {





                AccountExpensesReports rd = new AccountExpensesReports();//.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "AccountExpensesReports.repx", true);

                rd.Parameters["accounttype"].Value = Accounttype;
                if (formType == "Expens")
                {
                    rd.Parameters["DDetails"].Value = "حركة المصروفات";

                }
                else if (formType == "Payment") //سند صرف
                {
                    rd.Parameters["DDetails"].Value = "الدفعات المقدمة للمرسلين";

                }

                else if (formType == "Receipt") //سندقبض
                {
                    rd.Parameters["DDetails"].Value = "سندات الصرف";




                }
                rd.Parameters["datefrom"].Value =TxtDateFrom.DateTime.Date;
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

                rd = AccountsDataReports.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "AccountExpensesReports.repx", true);


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
            Accounts obj = accountsBindingSource.Current as Accounts;

            if (obj != null && obj.Id != 0)
            {
                var frm = new FrmCustomerAcc();
                frm.formType = formType;
                //frm.itemProductUnitMvBindingSource.DataSource = obj;// itemProductUnitMvBindingSource.Current;
                frm.Id = obj.Id;
                frm.ShowDialog();
                await GetLoad();

            }
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
            Accounts obj = accountsBindingSource.Current as Accounts;

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

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formType == "Expens")
            {
                return;
            }
            if (gridView1.RowCount<=0)
            {
                return;
            }
            AccountsTransactionSub obj = accountsTransactionSubBindingSource.Current as AccountsTransactionSub;

            if (obj != null && obj.TransId != 0)
            {
                var frm = new Form.FrmPayments();
                frm.mAccountId = mAccountId;
                frm.TxtEntryID.Text = obj.EntryId.ToString();
                frm.TxtRef.Text = obj.TransRefNo;
                frm.TxtNote.Text = obj.DetailsNote;
                frm.TxtAmount.Text = (obj.EntryType== "مدين"?obj.FromAmount:obj.ToAmount).ToString(SD.NumDec);
                frm.TxtDate.DateTime = obj.TransDate;
                frm.cmbFrom.Text = (obj.EntryType == "مدين" ? obj.AccountName : "");
                frm.cmbTo.Text = (obj.EntryType == "مدين" ? "": obj.AccountName);

                if (formType == "Expens")
                {
                    frm.formType = "Expens";
                }
                else if (formType == "Receipt") //سندقبض
                {
                    frm.formType = "Receipt";
                }
                else if (formType == "Payment") //سندصرف
                {
                    frm.formType = "Payment";              
                }
                frm.ShowDialog();

            }
            await GetLoad();
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
    }
}