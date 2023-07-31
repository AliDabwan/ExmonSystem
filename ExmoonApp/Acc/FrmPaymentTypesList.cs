using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
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
    public partial class FrmPaymentTypesList : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        int Accounttype { get; set; }
        string transType { get; set; }

        public string formType { get; set; }
        AccountControl accControl = new AccountControl();
        public int mAccountId { get; set; }

        public FrmPaymentTypesList()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (formType == "Cash"  )
            {
                var frm = new Form.FrmAccCash();
                frm.formType = formType;
                frm.Id = 0;
                frm.mAccountId = mAccountId;
                frm.ShowDialog();

            }
        
            await GetLoad();

        }
        async Task GetLoad()
        {
            //itemProductUnitMvBindingSource.DataSource = await itemProductsControl.GetAllItemProducts();//db.itemCategories.ToList();

            accountsTransDTOBindingSource.DataSource = await accControl.GetAllAccountBlances(mAccountId);//db.itemCategories.ToList();

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
                            simpleButton1.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }


                }


            }



        }

        private async void FrmPaymentTypesList_Load(object sender, EventArgs e)
        {
          
            if (formType == "Cash")
            {
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "انواع الدفع";

                }
                else
                {
                    LblHeader.Text = "Payment Types";

                }
                LblHeader.BackColor = Color.Gray;
                Accounttype = 0;
                colAccountAddress.Visible = false;
                colAccountPhone.Visible = false;
               
            }
          
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
                DesktopAlert.Show("يوجد معاملات في هذا الحساب  ! لايمكن الحذف." + "\n" + "there are related records ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (helper.ShowMessageConfirm(this, "Confirm   تأكيد ", " Delete this Record ? | تاكيد حذف السجل ؟"))
            {
                await accControl.DeleteAcc(acc);
                await GetLoad();

            }
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
            var accDt = await  accControl.GetAllAccountBlancesRpt(mAccountId);
            //MessageBox.Show(accDt.Rows.Count.ToString());
            if (createdb_BARACODE(accDt))
            {





                AccountsDataReports rd = new AccountsDataReports();//.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "AccountsDataReports.repx", true);




                rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
                rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
                rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
                rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
                rd.Parameters["MaccId"].Value = mAccountId;
                rd.Parameters["MaccId"].Visible = false;
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

        }
        public bool createdb_BARACODE(DataTable B_TABLE)
        {
            DataSet invo = new DataSet();

            DataTable dd_bar = new DataTable();
            dd_bar = B_TABLE;
            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(dd_bar);
            invo.Tables[0].TableName = "item";
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "AccountsData.xml";
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

        private void designReportToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ReportDesignTool printTool = new ReportDesignTool(RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true));
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
            if (gridView1.RowCount <= 0)
            {
                return;

            }
            //DesktopAlert.Show("1");
            AccountsTransDTO obj = accountsTransDTOBindingSource.Current as AccountsTransDTO;
            //DesktopAlert.Show("2");

            if (obj != null && obj.Id != 0)
            {
                //DesktopAlert.Show("3");


                if (formType == "Cash" )
                {
                    var frmCash = new Form.FrmAccCash();
                    frmCash.formType = formType;
                    frmCash.mAccountId = mAccountId;
                    frmCash.Id = obj.Id;
                    //DesktopAlert.Show("4");

                    frmCash.ShowDialog();

                }
               



                //frm.itemProductUnitMvBindingSource.DataSource = obj;// itemProductUnitMvBindingSource.Current;
             




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
            AccountsTransDTO obj = accountsTransDTOBindingSource.Current as AccountsTransDTO;


            if (obj != null && obj.Id != 0)
            {
                var frm = new FrmAccountTransactions();
                frm.accountId = obj.Id;
                frm.Accounttype = Accounttype;
                frm.AccountName = obj.AccountName;

                frm.Text += obj.AccountName ;
                //frm.itemProductUnitMvBindingSource.DataSource = obj;// itemProductUnitMvBindingSource.Current;

                frm.ShowDialog();
            }
        }

        private void TxtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}