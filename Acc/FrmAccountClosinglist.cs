﻿using DevComponents.DotNetBar.Controls;
using DevExpress.Data;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using ExmonSystem.RPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem
{
    public partial class FrmAccountClosinglist : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        AccountControl accountControl = new AccountControl();
       public int Accounttype { get; set; }

        public int accountId { get; set; } = 0;
        public FrmAccountClosinglist()
        {
            InitializeComponent();
        }
        async Task calcSums(IEnumerable<AccountsTransDTO> subSummary)
        {
            if (gridView1.RowCount <= 0)
            {
                TxtTotalBalance.Text = "0";
                return;
            }
            if (subSummary==null)
            {
                return;
            }
            var fromValu = subSummary.Sum(x => x.totalDebit);
            var toValu = subSummary.Sum(x => x.totalCredit);
            //var total = Convert.ToDouble(0);
            double FromAmountValue =Convert.ToDouble(gridView1.Columns["totalDebit"].SummaryItem.SummaryValue);
            double ToAmountValue = Convert.ToDouble(gridView1.Columns["totalCredit"].SummaryItem.SummaryValue);

            if (Accounttype == 0)
            {
                TxtTotalBalance.Text = (fromValu - toValu).ToString(SD.NumDec);
            }else
            {
                TxtTotalBalance.Text = (toValu - fromValu).ToString(SD.NumDec);
            }



        }

        async Task GetLoad()
        {
           
           var summary = await accountControl.GetAccountsListGroups(accountId, TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date);
            //DesktopAlert.Show(TxtDateTo.DateTime.Date.ToString());
            accountsTransDTOBindingSource.DataSource = summary;//db.itemCategories.ToList();
            gridView1.UpdateSummary();

            



            await calcSums(summary);

        }
        async Task getAccountsName()
        {
            if (Program.userCashAccountId==0)
            {
                cmbFrom.DataSource = await accountControl.GetAllAccount(Properties.Settings.Default.PropMainAccountCashes == 0 ? 101 : Properties.Settings.Default.PropMainAccountCashes);//db.itemCategories.ToList();

            }else
            {
                cmbFrom.DataSource = await accountControl.GetAccounts(Program.userCashAccountId);//db.itemCategories.ToList();
                cmbFrom.Visible = false;

            }

            cmbFrom.DisplayMember = "AccountName";
                cmbFrom.ValueMember = "Id";
            
        
         


        }

        private async void FrmItemCat_Load(object sender, EventArgs e)
        {
            await getAccountsName();

            GridColumnSummaryItem siTotal = new GridColumnSummaryItem();
            siTotal.SummaryType = SummaryItemType.Count;
            siTotal.DisplayFormat = "{0} عدد";
            gridView1.Columns["TransDay"].Summary.Add(siTotal);
            GridColumnSummaryItem FromAmount = new GridColumnSummaryItem();
            FromAmount.SummaryType = SummaryItemType.Sum;
            FromAmount.DisplayFormat = "{0:N2}";
            gridView1.Columns["totalDebit"].Summary.Add(FromAmount);
            gridView1.OptionsView.ShowFooter = true;



            GridColumnSummaryItem ToAmount = new GridColumnSummaryItem();
            ToAmount.SummaryType = SummaryItemType.Sum;
            ToAmount.DisplayFormat = "{0:N2}";
            gridView1.Columns["totalCredit"].Summary.Add(ToAmount);
            gridView1.OptionsView.ShowFooter = true;

            timerLoad.Start();
           

        }
        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           

        }

        private void DgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {

            }

        }

        private async void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
           await GetLoad();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itemProductTransactionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
        
        }

        private void DgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BtnShow_Click(object sender, EventArgs e)
        {
            await GetLoad();

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

       async Task  PrintLabels()
        {
            var accDt = await accountControl.GetAccountsListGroupsRpt(accountId, TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date);
            //MessageBox.Show(accDt.Rows.Count.ToString());
            if (createdb_BARACODE(accDt))
            {





                AccountSummaryReports rd = new AccountSummaryReports();//.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "AccountSummaryReports.repx", true);



                rd.Parameters["accounttype"].Value = Accounttype;
                rd.Parameters["accountname"].Value = cmbFrom.Text;
                rd.Parameters["accountid"].Value = accountId;
                rd.Parameters["datefrom"].Value = TxtDateFrom.DateTime;

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

                    printTool.ShowPreviewDialog();
                    DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                    ds.Dispose();
                }

            }

        }


        private void RdToday_CheckedChanged(object sender, EventArgs e)
        {
            TxtDateFrom.DateTime = DateTime.Now;
            TxtDateTo.DateTime = DateTime.Now;
           
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;

            }
         await   PrintLabels();

        }

        private void designReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XtraReport rd = AccountMovmentReports.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "AccountSummaryReports.repx", true);
            AccountMovmentReports rd = new AccountMovmentReports();

            ReportDesignTool printTool = new ReportDesignTool(rd);
            printTool.ShowRibbonDesignerDialog();
            DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
            ds.Dispose();
        }

        private void DgvItems_Click(object sender, EventArgs e)
        {

        }

        private void TxtDateFrom_EditValueChanged(object sender, EventArgs e)
        {
            TxtDateTo.DateTime = TxtDateFrom.DateTime.AddMonths(1);
        }

        private void rdDates_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                accountId = Convert.ToInt32(cmbFrom.SelectedValue);
                await GetLoad();

            }
            catch
            {
                if (Program.userCashAccountId>0)
                {
                    accountId = Program.userCashAccountId;
                }
            }
        }
    }
}