using DevComponents.DotNetBar.Controls;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using ExmonSystem.RPT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExmonSystem.Form
{
    public partial class FrmCashAccounts : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        int Accounttype { get; set; }
        bool rollUpdate = true;
        public string formType { get; set; }
        AccountControl accControl = new AccountControl();
        public int mAccountId { get; set; }
        public FrmCashAccounts()
        {
            InitializeComponent();
        }
        async Task GetLoad()
        {
            //itemProductUnitMvBindingSource.DataSource = await itemProductsControl.GetAllItemProducts();//db.itemCategories.ToList();


            accountsTransDTOBindingSource.DataSource = await accControl.GetAllAccountBlances(mAccountId);//db.itemCategories.ToList();
            gridView1.UpdateSummary();

            TxtName.Enabled = true;

            //accountsTransDTOBindingSource.Add(new Accounts());
            //accountsTransDTOBindingSource.MoveLast();
            TxtName.Focus();
            //itemProductUnitMvBindingSource.Add(new ItemProduct());
            //itemProductUnitMvBindingSource.MoveLast();

        }
        async Task getMyRoll()
        {
            RollsControl control = new RollsControl();


            var myRoll = await control.getMyRoll(Program.userGroupId);


            if (myRoll == null)
            {
                return;
            }

            if (formType == "Cash")
            {
                foreach (var item in myRoll)
                {

                    if (item.RollTitle == "حذف حساب")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "إضافة حساب")
                    {
                        if (item.IsChecked == "False")
                        {
                            BtnNew.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "تعديل حساب")
                    {
                        if (item.IsChecked == "False")
                        {
                             rollUpdate = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                }


            }



        }

        private async void FrmCashAccounts_Load(object sender, EventArgs e)
        {
            if (formType == "Cash")
            {
                //TxtMAccountID.Text = "101";
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.Text = "Cash Accounts";
                LblHeader.BackColor = Color.Gray;
                Accounttype = 0;

            }

            if (formType == "Expens")
            {
                //  TxtMAccountID.Text = "104";
                TxtMAccountID.Text = mAccountId.ToString();


                LblHeader.Text = "Expenses Accounts";
                LblHeader.BackColor = Color.Olive;
                Accounttype = 0;

            }

            if (formType == "Revenus")
            {
                //  TxtMAccountID.Text = "105";
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.Text = "Revenus Accounts";
                LblHeader.BackColor = Color.DarkRed;
                Accounttype = 1;

            }
            //GridColumnSummaryItem siTotal = new GridColumnSummaryItem();
            //siTotal.SummaryType = SummaryItemType.Count;
            //siTotal.DisplayFormat = "{0} عدد";
            //gridView1.Columns["Id"].Summary.Add(siTotal);
            //GridColumnSummaryItem FromAmount = new GridColumnSummaryItem();
            //FromAmount.SummaryType = SummaryItemType.Sum;
            //FromAmount.DisplayFormat = "{0:N2} Total ";
            //gridView1.Columns["balance"].Summary.Add(FromAmount);
            //gridView1.OptionsView.ShowFooter = true;


            await GetLoad();


            await getMyRoll();

        }

        private void gridCashAcc_Click(object sender, EventArgs e)
        {

        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            Accounts obj = accountsBindingSource.Current as Accounts;
            if (obj.Id == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (helper.ShowMessageConfirm(this, "Confirm   تأكيد ", " Delete this Record ? | تاكيد حذف السجل ؟"))
            {
                await accControl.DeleteAcc(obj);
                await GetLoad();

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            TxtName.Enabled = true;
            TxtBalance.Enabled = true;

            accountsTransDTOBindingSource.MoveLast();
            accountsBindingSource.MoveLast();

            AccountsTransDTO obj = accountsTransDTOBindingSource.Current as AccountsTransDTO;



            if (obj != null)
            {
                //var myacc = await accControl.Getaccount(obj.Id);
                var myacc = await accControl.Getaccount(obj.Id);

                if (obj.Id == 0)
                {
                    TxtName.Focus();
                }
                else
                {

                    accountsTransDTOBindingSource.Add(new AccountsTransDTO());
                    accountsTransDTOBindingSource.MoveLast();

                    //accountsBindingSource.DataSource = myacc;    //accountsBindingSource.Add(new Accounts());
                    //accountsBindingSource.MoveLast();
                    TxtName.Focus();
                }
            }
        }

        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }

            //DesktopAlert.Show(TxtMAccountID.Text);
            var Maccount = Convert.ToInt32(TxtMAccountID.Text);

            Accounts obj = accountsBindingSource.Current as Accounts;
            if (obj.Id>0)
            {
                if (!rollUpdate)
                {

                    DesktopAlert.Show("لاتوجد صلاحية للتعديل " + "\n" + " Edition is not allowed ", eDesktopAlertColor.DarkBlue, eAlertPosition.TopRight);
                    return;
                }
            }
            if (obj != null)
            {
                obj.MAccountLabelId = Maccount;
                obj.Accounttype = Accounttype;
                await accControl.AddToAcc(obj);


                TxtName.Enabled = false;
                accountsBindingSource.ResetBindings(false);

                TxtName.Enabled = false;
                TxtBalance.Enabled = false;
                BtnNew.Focus();
                //simpleButton1_Click(sender ,e);
                await GetLoad();

            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            flyoutPanel1.ShowBeakForm();

        }
        //async Task GetReport(bool Prnt)
        //{
        //    DataTable dtt = new DataTable();
          
        //        dtt = await accControl.GetAllAccountRpt(mAccountId);//db.itemCategories.ToList();


        //    helper.Reportt(dtt, "‏‏rpt_Accounts", "Accounts List قائمة الحسابات", formType, "", "A4", Prnt, 1, 1, false, "");

        //    //itemProductUnitMvBindingSource.Add(new ItemProduct());
        //    //itemProductUnitMvBindingSource.MoveLast();

        //}

        private  void BtnNew_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
           

            XtraReport rd = RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true);
            rd.Parameters["MaccId"].Value = mAccountId;
            rd.Parameters["MaccId"].Visible = false;
            rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;

            foreach (var item in rd.Parameters)
            {
                item.Visible = false;
            }

            ReportPrintTool printTool = new ReportPrintTool(rd);
            //ReportPrintTool printTool = new ReportPrintTool(RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true));
          
            printTool.ShowPreviewDialog();



            // await GetReport(false);
        }

        private async void simpleButton7_Click(object sender, EventArgs e)
        {
            //  await GetReport(true);

            //RptCashAccountsName rptCash = new RptCashAccountsName();
            //XtraReport report = XtraReport.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true);


            //ReportDesignTool designTool = new ReportDesignTool(report);
            //designTool.ShowRibbonDesignerDialog();


        }

        private void designReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReportDesignTool printTool = new ReportDesignTool(RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true));
            printTool.ShowRibbonDesignerDialog();

            //helper.ReportDesign("‏‏rpt_Accounts");

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
                frm.AccountName = obj.AccountName;

                frm.Text += obj.AccountName;
                //frm.itemProductUnitMvBindingSource.DataSource = obj;// itemProductUnitMvBindingSource.Current;

                frm.ShowDialog();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                TxtName.Enabled = true;
                TxtBalance.Enabled = false;

            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
          

            //var dt =await accControl.GetAllAccountRpt(mAccountId);
            //helper.createdb_BARACODE(dt,"myXmlFileTry");
            //string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "myXmlFileTry" + ".xml";
          
            ////string jsonText = JsonConvert.SerializeXmlNode();

            //DesktopAlert.Show(jsonText);


        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {   
            
            var frmrpt = new RptForm();
            frmrpt.ShowDialog();


        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            //RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true);
            //RptCashAccountsName rptCashes = new RptCashAccountsName();

         
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //RptCashAccountsName rptCashes = new RptCashAccountsName();
          
            //FormBarcodRpt formBarcodRpt = new FormBarcodRpt();
            //formBarcodRpt.documentViewer1.DocumentSource = rptCashes;
            //formBarcodRpt.ShowDialog();
        }

        private async void gridView1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            AccountsTransDTO obj = accountsTransDTOBindingSource.Current as AccountsTransDTO;

            if (obj != null && obj.Id != 0)
            {
                var myacc =await accControl.Getaccount(obj.Id);
                //DesktopAlert.Show(myacc.AccountName);
                TxtMAccountID.Text = myacc.MAccountLabelId.ToString();
                //mAccountId = myacc.MAccountLabelId ;
                Accounttype = myacc.Accounttype ;
                accountsBindingSource.DataSource = myacc;
                TxtName.Enabled = true;
                TxtBalance.Enabled = true;
                await GetLoad();

            }
        }
    }
}