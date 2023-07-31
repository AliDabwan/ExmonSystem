using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace ExmonSystem.FrmForm
{
    public partial class FrmPrescriptionAdd : DevExpress.XtraEditors.XtraForm
    {
        public FrmPrescriptionAdd()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtUsage.Text))
            {
                Program.prescriptionUsage = TxtUsage.Text;
                Close();
            }
        }

        private void FrmPrescriptionAdd_Load(object sender, EventArgs e)
        {
            setname_forbar();

            TxtUser.Text = Program.userFullName;
            TxtCustomer.Focus();
        }
        DataTable BR_TABLE = new DataTable();
        public void setname_forbar()
        {
            BR_TABLE.Columns.Add("Name");
            BR_TABLE.Columns.Add("ItemName");
            BR_TABLE.Columns.Add("BillDate");
            BR_TABLE.Columns.Add("ExpierDate");
            BR_TABLE.Columns.Add("Usage");
            BR_TABLE.Columns.Add("UserName");

        }
        void PRINTBarcodxtra()
        {


            if (Properties.Settings.Default.AllowPrescription)
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.PRINTER_PARACOD))
                {
                    DesktopAlert.Show("يجب إختيار طابعة الملصقات" + "  " + "Please select Labels Printer");
                    var frmst = new FrmStrat();
                    frmst.ShowDialog();
                    return;
                }

            }
            if (!string.IsNullOrEmpty(TxtUsage.Text))
                {
                    DataRow x = BR_TABLE.NewRow();

                    x[0] = TxtCustomer.Text;
                    x[1] = TxtItemName.Text;
                    x[2] = dateEdit1.DateTime.ToString("dd/MM/yyyy");
                    x[3] = TxtDateExpier.Text;
                    x[4] = TxtUsage.Text;
                x[5] = Program.userFullName;

                BR_TABLE.Rows.Add(x);



                }

            

            if (BR_TABLE.Rows.Count > 0)
            {
                createdb_BARACODE(BR_TABLE);
                PrintLabels();
            }

        }
        public void createdb_BARACODE(DataTable B_TABLE)
        {
            DataSet invo = new DataSet();

            DataTable dd_bar = new DataTable();
            dd_bar = B_TABLE;
            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(dd_bar);
            invo.Tables[0].TableName = "item";
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "PrescriptionRoll.xml";
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

            //     System.Windows.Forms.MessageBox.Show("dispos");
        }
        void PrintLabels()
        {


            XtraReport rd = RptPrescripUsageLabel50X25.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptPrescripUsageLabel50X25.repx", true);

            var company = "";

            company = Properties.Settings.Default.COMPANY + Properties.Settings.Default.CompanyDetailsAr;


            rd.Parameters["CompanyName"].Value = company;

            rd.Parameters["CompanyName"].Visible = false;
            foreach (var item in rd.Parameters)
            {
                item.Visible = false;
            }
            using (ReportPrintTool printTool = new ReportPrintTool(rd))
            {

                printTool.Print();
                DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                ds.Dispose();
            }
            if (!string.IsNullOrEmpty(TxtUsage.Text))
            {
                Program.prescriptionUsage = TxtUsage.Text;
                Close();
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

        private void BtnPrintSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsage.Text))
            {
                PRINTBarcodxtra();

            }

        }
    }
}