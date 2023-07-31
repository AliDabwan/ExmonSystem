using DevComponents.DotNetBar.Controls;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace ExmonSystem.Acc
{
    public partial class FrmOrderPrint : DevExpress.XtraEditors.XtraForm
    {
        AccountControl accControl = new AccountControl();

        public FrmOrderPrint()
        {
            InitializeComponent();
        }
        public List<ExCompanyDTO> listExCompany = new List<ExCompanyDTO>();
        public List<Driver> listDriver = new List<Driver>();


        public List<Destination> listDestination1 = new List<Destination>();
        public List<Destination> listDestination2 = new List<Destination>();
        public List<Destination> listDestination3 = new List<Destination>();
        public List<Destination> listDestination4 = new List<Destination>();
        public List<AirLine> listAirLine1 = new List<AirLine>();
        public List<AirLine> listAirLine2 = new List<AirLine>();
        public List<AirLine> listAirLine3 = new List<AirLine>();
        public List<AirLine> listAirLine4 = new List<AirLine>();


        

        async Task  GetLoadFields()
        {



            var xx = await accControl.GetAllExCompanies();

           

            foreach (var item in xx)
            {
                listExCompany.Add(new ExCompanyDTO() { Id = item.Id, Name = item.Name, SubscrberId = item.SubscrberId, });

               
            }


            ExCompanyIdLookUpEdit.Properties.DataSource = listExCompany;
            ExCompanyIdLookUpEdit.Properties.DisplayMember = "Name";
            ExCompanyIdLookUpEdit.Properties.ValueMember = "Id";
            ExCompanyIdLookUpEdit.Properties.PopulateColumns();
            ExCompanyIdLookUpEdit.Properties.Columns[2].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[3].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[4].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[5].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[6].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[7].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[8].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[9].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[10].Visible = false;




            var xxDest = await accControl.GetAllDestinations();

            listDestination1.Add(new Destination() { Id = 0, Name = " " });
            listDestination2.Add(new Destination() { Id = 0, Name = " " });
            listDestination3.Add(new Destination() { Id = 0, Name = " " });
            listDestination4.Add(new Destination() { Id = 0, Name = " " });

            foreach (var item in xxDest)
            {

                listDestination1.Add(new Destination() { Id = item.Id, Name = item.Name, IsVisa = item.IsVisa, ReportName = item.ReportName });
                listDestination2.Add(new Destination() { Id = item.Id, Name = item.Name, IsVisa = item.IsVisa, ReportName = item.ReportName });
                listDestination3.Add(new Destination() { Id = item.Id, Name = item.Name, IsVisa = item.IsVisa, ReportName = item.ReportName });
                listDestination4.Add(new Destination() { Id = item.Id, Name = item.Name, IsVisa = item.IsVisa, ReportName = item.ReportName });

            }

            TxtGover1.Properties.DataSource = listDestination1;
            TxtGover1.Properties.DisplayMember = "Name";
            TxtGover1.Properties.ValueMember = "Id";
            TxtGover1.Properties.PopulateColumns();
            TxtGover1.Properties.Columns[2].Visible = false;
            TxtGover1.Properties.Columns[3].Visible = false;
            TxtGover1.Properties.Columns[4].Visible = false;

            TxtGover2.Properties.DataSource = listDestination2;
            TxtGover2.Properties.DisplayMember = "Name";
            TxtGover2.Properties.ValueMember = "Id";
            TxtGover2.Properties.PopulateColumns();
            TxtGover2.Properties.Columns[2].Visible = false;
            TxtGover2.Properties.Columns[3].Visible = false;
            TxtGover2.Properties.Columns[4].Visible = false;

            TxtGover3.Properties.DataSource = listDestination3;
            TxtGover3.Properties.DisplayMember = "Name";
            TxtGover3.Properties.ValueMember = "Id";
            TxtGover3.Properties.PopulateColumns();
            TxtGover3.Properties.Columns[2].Visible = false;
            TxtGover3.Properties.Columns[3].Visible = false;
            TxtGover3.Properties.Columns[4].Visible = false;

            TxtGover4.Properties.DataSource = listDestination4;
            TxtGover4.Properties.DisplayMember = "Name";
            TxtGover4.Properties.ValueMember = "Id";
            TxtGover4.Properties.PopulateColumns();
            TxtGover4.Properties.Columns[2].Visible = false;
            TxtGover4.Properties.Columns[3].Visible = false;
            TxtGover4.Properties.Columns[4].Visible = false;



            TxtGover1.ItemIndex = 0;
            TxtGover2.ItemIndex = 0;
            TxtGover3.ItemIndex = 0;
            TxtGover4.ItemIndex = 0;




            try
            {
                var xxDri = await accControl.GetAllDrivers();
                listDriver.Add(new Driver() { Id = 0, Name = " " });

                foreach (var item in xxDri)
                {
                    listDriver.Add(new Driver() { Id = item.Id, Name = item.Name });

                }
                //DesktopAlert.Show("driver:" + listDriver.Count);

                DriverIdLookUpEdit.Properties.DataSource = listDriver;
                DriverIdLookUpEdit.Properties.DisplayMember = "Name";
                DriverIdLookUpEdit.Properties.ValueMember = "Id";
                DriverIdLookUpEdit.Properties.PopulateColumns();
                DriverIdLookUpEdit.Properties.Columns[2].Visible = false;


            }
            catch 
            {

                ;
            }

           



            var xxAir= await accControl.GetAllAirLines();
            listAirLine1.Add(new AirLine() { Id = 0, Name = " " });
            listAirLine2.Add(new AirLine() { Id = 0, Name = " " });
            listAirLine3.Add(new AirLine() { Id = 0, Name = " " });
            listAirLine4.Add(new AirLine() { Id = 0, Name = " " });

            foreach (var item in xxAir)
            {
                listAirLine1.Add(new AirLine() { Id = item.Id, Name = item.Name });
                listAirLine2.Add(new AirLine() { Id = item.Id, Name = item.Name });
                listAirLine3.Add(new AirLine() { Id = item.Id, Name = item.Name });
                listAirLine4.Add(new AirLine() { Id = item.Id, Name = item.Name });

            }
            //DesktopAlert.Show("driver:" + listDriver.Count);

            TxtAirLines1.Properties.DataSource = listAirLine1;
            TxtAirLines1.Properties.DisplayMember = "Name";
            TxtAirLines1.Properties.ValueMember = "Id";
            TxtAirLines1.Properties.PopulateColumns();
            TxtAirLines1.Properties.Columns[2].Visible = false;
            TxtAirLines1.Properties.Columns[3].Visible = false;
            TxtAirLines1.Properties.Columns[4].Visible = false;
            TxtAirLines1.ItemIndex = 0;
            TxtAirLines2.ItemIndex = 0;
            TxtAirLines3.ItemIndex = 0;
            TxtAirLines4.ItemIndex = 0;

            TxtAirLines2.Properties.DataSource = listAirLine2;
            TxtAirLines2.Properties.DisplayMember = "Name";
            TxtAirLines2.Properties.ValueMember = "Id";
            TxtAirLines2.Properties.PopulateColumns();
            TxtAirLines2.Properties.Columns[2].Visible = false;
            TxtAirLines2.Properties.Columns[3].Visible = false;
            TxtAirLines2.Properties.Columns[4].Visible = false;



            TxtAirLines3.Properties.DataSource = listAirLine3;
            TxtAirLines3.Properties.DisplayMember = "Name";
            TxtAirLines3.Properties.ValueMember = "Id";
            TxtAirLines3.Properties.PopulateColumns();
            TxtAirLines3.Properties.Columns[2].Visible = false;
            TxtAirLines3.Properties.Columns[3].Visible = false;
            TxtAirLines3.Properties.Columns[4].Visible = false;



            TxtAirLines4.Properties.DataSource = listAirLine4;
            TxtAirLines4.Properties.DisplayMember = "Name";
            TxtAirLines4.Properties.ValueMember = "Id";
            TxtAirLines4.Properties.PopulateColumns();
            TxtAirLines4.Properties.Columns[2].Visible = false;
            TxtAirLines4.Properties.Columns[3].Visible = false;
            TxtAirLines4.Properties.Columns[4].Visible = false;


        }
        private async void FrmTaxValue_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            await GetLoadFields();

            timerLoad.Start();
        }
        public Int64 Id { get; set; } = 0;
        public int ExCompanyId { get; set; } = 0;
        async Task GetLoad()
        {


            orderBindingSource.DataSource = await accControl.GetOrder(Id);//db.itemCategories.ToList();

            layoutControlGroup1.Enabled = true;

            int rowI = 0;
            var mysub = await accControl.GetAllOrderSub(Id);
            if (mysub!=null)
            {
                rowI = 0;
                foreach (var item in mysub)
                {
                    if (rowI==0)
                    {
                        TxtGover1.EditValue = item.DestinationId;
                        TxtAirLines1.EditValue = item.AirlineId;
                        TxtValu1.EditValue = item.SubCount;
                        rowI++;
                        continue;
                    }
                    if (rowI == 1)
                    {
                        TxtGover2.EditValue = item.DestinationId;
                        TxtAirLines2.EditValue = item.AirlineId;
                        TxtValu2.EditValue = item.SubCount;
                        rowI++;
                        continue;

                    }
                    if (rowI == 2)
                    {
                        TxtGover3.EditValue = item.DestinationId;
                        TxtAirLines3.EditValue = item.AirlineId;
                        TxtValu3.EditValue = item.SubCount;
                        rowI++;
                        continue;

                    }
                    if (rowI == 3)
                    {
                        TxtGover4.EditValue = item.DestinationId;
                        TxtAirLines4.EditValue = item.AirlineId;
                        TxtValu4.EditValue = item.SubCount;
                        rowI++;
                        continue;

                    }


                }

            }


        }
        private async void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
          await GetLoad();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            layoutControlGroup1.Enabled = true;
            BtnSave.Enabled = true;

            orderBindingSource.Clear();
            orderSubs.Clear();

        }

        List<OrderSub> orderSubs = new List<OrderSub>();

        async Task<bool> doSub(string rowNumber,Int64 id,LookUpEdit txtgover, LookUpEdit txtair,CalcEdit valu)
        {
            if (string.IsNullOrEmpty(txtgover.Text)|| txtgover.Text == " ")
            {
                DesktopAlert.Show("يجب اختيار اسم الدولة "+ rowNumber, eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                return false;
            }
            if (string.IsNullOrEmpty(txtair.Text)|| txtair.Text == " ")
            {
                DesktopAlert.Show("يجب اختيار اسم الطيران" + rowNumber, eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                return false;
            }
            if (string.IsNullOrEmpty(valu.Text)|| valu.Text=="0")
            {
                DesktopAlert.Show("يجب اختيار تحديد عدد النسخ " + rowNumber, eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                return false;
            }
            if (txtgover.Text == " "|| txtair.Text == " ")
            {
                return false;
            }
                var mysub1 = new OrderSub
                {
                    OrderId = id,
                    DestinationId = Convert.ToInt32(txtgover.EditValue),
                    AirlineId = Convert.ToInt32(txtair.EditValue),
                    SubCount = Convert.ToInt32(valu.Text)
                };


            orderSubs.Add(mysub1);

            return true;
        }


        async Task RptCustomers(bool isPrint,int id)
        {
         




            //var mydt = await accControl.Getdatatable(customers);

            //if (createdb_BARACODE(mydt))
            //{

                //RptPassport rd = new RptPassport();

                //rd = new RptPassport(); 


                XtraReport rd = RptPassport.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptPassport.repx", true);


                //rd.Parameters["billtype"].Value = "احصائيات المبيعات";
                //rd.Parameters["datefrom"].Value = TxtDateFrom.DateTime;
                rd.Parameters["takeRow"].Value = 10;
                rd.Parameters["id"].Value = id;
                
                //rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
                //rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
                //rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
                //rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
                //rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;

                //foreach (var item in rd.Parameters)
                //{
                //    if (item.Name == "totalSum")
                //    {
                //        //item.Value = TxtTotal.Text;
                //    }
                //    if (item.Name == "lang")
                //    {
                //        item.Value = Properties.Settings.Default.Language;
                //    }
                //    item.Visible = false;
                //}


                using (ReportPrintTool printTool = new ReportPrintTool(rd))
                {

                    if (isPrint)
                    {
                        printTool.PrintDialog();

                    }
                    else
                    {
                        rd.CreateDocument(true);//

                        printTool.ShowPreviewDialog();

                    }

                    //DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                    //ds.Dispose();
                }

            //}

        }




        async Task ExportToExcell(IEnumerable<CustomerDto> mycustom,Int64 id)
        {





            var mydt = await accControl.Getdatatable(mycustom);

            if (createdb_BARACODE(mydt))
            {

                //RptPassport rd = new RptPassport();

                //rd = new RptPassport(); 


                XtraReport rd = RptCustomersExport.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptCustomersExport.repx", true);


            //rd.Parameters["billtype"].Value = "احصائيات المبيعات";
            //rd.Parameters["datefrom"].Value = TxtDateFrom.DateTime;
            rd.Parameters["DateofPrint"].Value = DateTime.Now.ToString("dd/MM/yyyy");

            // Specify export options.
            DevExpress.XtraPrinting.XlsxExportOptions xlsxExportOptions = new DevExpress.XtraPrinting.XlsxExportOptions()
            {
                ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFile,
                ShowGridLines = true,
                FitToPrintedPageHeight = true
            };

            // Specify the path for the exported XLSX file.  
            string xlsxExportFile =
               System.Windows.Forms.Application.StartupPath + @"\orderCustomers_" +id+
                ".xlsx";

            // Export the report.
            rd.ExportToXlsx(xlsxExportFile, xlsxExportOptions);

                FileInfo fi = new FileInfo(xlsxExportFile);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(xlsxExportFile);
                }
                else
                {
                    //file doesn't exist
                }

                DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                ds.Dispose();
            }

        }

        async Task ShowRptVisas(bool isPrint, CustomerDto customer,string path)
        {
            Random random = new Random();
            int result = random.Next(1000, 10000);


            //RptPassport rd = new RptPassport();

            //rd = new RptPassport(); 


            //XtraReport rd = RptVisa.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptVisa.repx", true);
            XtraReport rd = RptVisa.FromFile(path, true);


            rd.Parameters["FullName"].Value = customer.FullName;
            rd.Parameters["PassportNo"].Value = customer.PassportNo;
            rd.Parameters["PhoneNumber"].Value = customer.PhoneNumber;
            rd.Parameters["BirthDate"].Value = customer.BirthDate;
            rd.Parameters["ApprovalDate"].Value = customer.FullName;
            rd.Parameters["ApplyDate"].Value = customer.ExpierDate;
            rd.Parameters["VisaRandomId"].Value = "V" + DateTime.Now.Year + result.ToString();
            rd.Parameters["DateBeforePrint14"].Value = DateTime.Now.AddDays(-14).ToString("dd/MM/yyyy");
            rd.Parameters["DateBeforePrint28"].Value = DateTime.Now.AddDays(-28).ToString("dd/MM/yyyy");


            //rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
            //rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
            //rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
            //rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
            //rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;

            //foreach (var item in rd.Parameters)
            //{
            //    if (item.Name == "totalSum")
            //    {
            //        //item.Value = TxtTotal.Text;
            //    }
            //    if (item.Name == "lang")
            //    {
            //        item.Value = Properties.Settings.Default.Language;
            //    }
            //    item.Visible = false;
            //}


            using (ReportPrintTool printTool = new ReportPrintTool(rd))
                {

                    if (isPrint)
                    {
                        printTool.PrintDialog();

                    }
                    else
                    {
                        rd.CreateDocument(true);//

                        printTool.ShowPreviewDialog();

                    }

                    //DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                    //ds.Dispose();
                }

            

        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        async Task ShowRptTickets(bool isPrint, CustomerDto customer, string path)
        {


            Random random = new Random();
            int result = random.Next(1000, 10000);
            //RptPassport rd = new RptPassport();

            //rd = new RptPassport(); 


            //XtraReport rd = RptVisa.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptVisa.repx", true);
            XtraReport rd = RptTicket.FromFile(path, true);


            rd.Parameters["FullName"].Value = customer.EnName;
            rd.Parameters["PassportNo"].Value = customer.PassportNo;
            rd.Parameters["PhoneNumber"].Value = customer.PhoneNumber;
            rd.Parameters["BirthDate"].Value = customer.BirthDate;
            rd.Parameters["ApprovalDate"].Value = customer.FullName;
            rd.Parameters["ApplyDate"].Value = customer.ExpierDate;
            rd.Parameters["VisaRandomId"].Value = RandomString(6);
            rd.Parameters["EticketId"].Value = DateTime.Now.Year + result.ToString();
            rd.Parameters["DateAfterPrint2"].Value = DateTime.Now.AddDays(2).ToString("dddd, d MMMM, yyyy");
            rd.Parameters["DateAfterPrint7"].Value = DateTime.Now.AddDays(7).ToString("dddd, d MMMM, yyyy");
            rd.Parameters["DateBeforPrint2"].Value = DateTime.Now.AddDays(-2).ToString("dddd, d MMMM, yyyy");

            //rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
            //rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
            //rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
            //rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
            //rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;

            //foreach (var item in rd.Parameters)
            //{
            //    if (item.Name == "totalSum")
            //    {
            //        //item.Value = TxtTotal.Text;
            //    }
            //    if (item.Name == "lang")
            //    {
            //        item.Value = Properties.Settings.Default.Language;
            //    }
            //    item.Visible = false;
            //}


            using (ReportPrintTool printTool = new ReportPrintTool(rd))
            {

                if (isPrint)
                {
                    printTool.PrintDialog();

                }
                else
                {
                    rd.CreateDocument(true);//

                    printTool.ShowPreviewDialog();

                }

                //DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                //ds.Dispose();
            }



        }
        async Task ShowRptWasl(bool isPrint, CustomerDto customer)
        {


            Random random = new Random();
            int result = random.Next(1000, 10000);
            int result2 = random.Next(1000, 5000);
            //RptPassport rd = new RptPassport();

            //rd = new RptPassport(); 


            XtraReport rd = RptWasl.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptWasl.repx", true);


            rd.Parameters["CompanyName"].Value = TxtCompanyEn.Text;
            rd.Parameters["FullName"].Value = customer.EnName;
            rd.Parameters["PassportNo"].Value = customer.PassportNo;
            rd.Parameters["PhoneNumber"].Value = customer.PhoneNumber;
            rd.Parameters["BirthDate"].Value = customer.BirthDate;
            rd.Parameters["ApprovalDate"].Value = customer.FullName;
            rd.Parameters["ApplyDate"].Value = customer.ExpierDate;
            rd.Parameters["Id"].Value = DateTime.Now.Year + result2.ToString();
            rd.Parameters["SerialId"].Value = DateTime.Now.Year + result.ToString();
            rd.Parameters["DatePrint"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
         
            //rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
            //rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
            //rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
            //rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
            //rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;

            //foreach (var item in rd.Parameters)
            //{
            //    if (item.Name == "totalSum")
            //    {
            //        //item.Value = TxtTotal.Text;
            //    }
            //    if (item.Name == "lang")
            //    {
            //        item.Value = Properties.Settings.Default.Language;
            //    }
            //    item.Visible = false;
            //}


            using (ReportPrintTool printTool = new ReportPrintTool(rd))
            {

                if (isPrint)
                {
                    printTool.PrintDialog();

                }
                else
                {
                    rd.CreateDocument(true);//

                    printTool.ShowPreviewDialog();

                }

                //DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                //ds.Dispose();
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
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "CustomersExport.xml";
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



        private async void  BtnSave_Click(object sender, EventArgs e)
        {
        
            

           


            using (MyDbContext db = new MyDbContext())
            {
                Order obj = orderBindingSource.Current as Order;
                if (obj != null)
                {
                    if (obj.Id != 0)
                    {
                        int CopiesCount1 = 0;
                        int CopiesCount2 = 0;
                        int CopiesCount3 = 0;
                        int CopiesCount4 = 0;

                        //var mysubscriber=await accControl.getsubs


                        try
                        {
                            var ExCompany = TxtGover1.GetSelectedDataRow() as Destination;
                            if (ExCompany != null)
                            {
                                if (ExCompany.Id>0)
                                {
                                    var airlin = TxtAirLines1.GetSelectedDataRow() as AirLine;
                                    if (airlin != null)
                                    {
                                        if (airlin.Id > 0)
                                        {
                                            CopiesCount1 = Convert.ToInt32(TxtValu1.Text);
                                            //DesktopAlert.Show("val 1 :  =" + CopiesCount1);

                                        }
                                    }
                                }
                            }
                        }
                        catch{ CopiesCount1 = 0; }


                        try
                        {
                            var ExCompany = TxtGover2.GetSelectedDataRow() as Destination;
                            if (ExCompany != null)
                            {
                                if (ExCompany.Id > 0)
                                {
                                    var airlin = TxtAirLines2.GetSelectedDataRow() as AirLine;
                                    if (airlin != null)
                                    {
                                        if (airlin.Id > 0)
                                        {
                                            CopiesCount2= Convert.ToInt32(TxtValu2.Text);
                                            //DesktopAlert.Show("val 2 :  =" + CopiesCount2);

                                        }
                                    }
                                }
                            }
                        }
                        catch { CopiesCount2 = 0; }


                        try
                        {
                            var ExCompany = TxtGover3.GetSelectedDataRow() as Destination;
                            if (ExCompany != null)
                            {
                                if (ExCompany.Id > 0)
                                {
                                    var airlin = TxtAirLines3.GetSelectedDataRow() as AirLine;
                                    if (airlin != null)
                                    {
                                        if (airlin.Id > 0)
                                        {
                                            CopiesCount3 = Convert.ToInt32(TxtValu3.Text);
                                            //DesktopAlert.Show("val 3 :  =" + CopiesCount3);

                                        }
                                    }
                                }
                            }
                        }
                        catch { CopiesCount3 = 0; }

                        try
                        {
                            var ExCompany = TxtGover4.GetSelectedDataRow() as Destination;
                            if (ExCompany != null)
                            {
                                if (ExCompany.Id > 0)
                                {
                                    var airlin = TxtAirLines4.GetSelectedDataRow() as AirLine;
                                    if (airlin != null)
                                    {
                                        if (airlin.Id > 0)
                                        {
                                            CopiesCount4 = Convert.ToInt32(TxtValu4.Text);
                                            //DesktopAlert.Show("val 3 :  =" + CopiesCount3);

                                        }
                                    }
                                }
                            }
                        }
                        catch { CopiesCount4 = 0; }

                        int totalCount = 0;

                        totalCount = (CopiesCount1 + CopiesCount2 + CopiesCount3 + CopiesCount4);
                        if (totalCount!= Convert.ToInt32( OrderCountCalcEdit.Text))
                        {
                            DesktopAlert.Show(" يجب ان يكون مجموع النسخ مساويا للعدد " + OrderCountCalcEdit.Text + " المحدد في طلب الطباعة " , eDesktopAlertColor.Black, eAlertPosition.TopRight);



                            BtnSave.Enabled = true;
                            return; 
                        }
                        //DesktopAlert.Show("valcount :  =" + ());



                        BtnSave.Enabled = false;

                        orderSubs.Clear();
                        if ((!string.IsNullOrEmpty(TxtGover1.Text) && TxtGover1.Text != " "))
                        {
                            if ((!string.IsNullOrEmpty(TxtAirLines1.Text) && TxtAirLines1.Text != " "))
                            {


                                if (Convert.ToInt32(TxtValu1.Text) > 0)
                                {
                                    var do1 = await doSub("1", obj.Id, TxtGover1, TxtAirLines1, TxtValu1);
                                    if (!do1)
                                    {
                                        BtnSave.Enabled = true;
                                        return;
                                    }
                                }
                                else
                                {
                                    BtnSave.Enabled = true;
                                    DesktopAlert.Show("يجب تحديد عدد النسخ " + "1", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                    TxtValu1.Focus();

                                    return;
                                }
                            }
                            else
                            {
                                BtnSave.Enabled = true;
                                DesktopAlert.Show("يجب تحديد شركة الطيران " + "1", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                TxtAirLines1.Focus();
                                return;
                            }
                        }
                        if ((!string.IsNullOrEmpty(TxtGover2.Text) && TxtGover2.Text != " ") )
                        {
                            if ((!string.IsNullOrEmpty(TxtAirLines2.Text) && TxtAirLines2.Text != " "))
                            {


                                if (Convert.ToInt32(TxtValu2.Text) > 0)
                                {
                                    var do2 = await doSub("2", obj.Id, TxtGover2, TxtAirLines2, TxtValu2);
                                    if (!do2)
                                    {
                                        BtnSave.Enabled = true;
                                        return;
                                    }
                                }
                                else
                                {
                                    DesktopAlert.Show("يجب تحديد عدد النسخ " + "2", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                                    BtnSave.Enabled = true;
                                    TxtValu2.Focus();

                                    return;
                                }
                            }
                            else
                            {
                                BtnSave.Enabled = true;
                                DesktopAlert.Show("يجب تحديد شركة الطيران " + "2", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                TxtAirLines2.Focus();
                                return;
                            }
                        }
                        if ((!string.IsNullOrEmpty(TxtGover3.Text) && TxtGover3.Text != " ") )
                        {
                            if ((!string.IsNullOrEmpty(TxtAirLines3.Text) && TxtAirLines3.Text != " "))
                            {
                                if (Convert.ToInt32(TxtValu3.Text) > 0)
                                {
                                    var do3 = await doSub("3", obj.Id, TxtGover3, TxtAirLines3, TxtValu3);
                                    if (!do3)
                                    {
                                        BtnSave.Enabled = true;
                                        return;
                                    }
                                }
                                else
                                {
                                    DesktopAlert.Show("يجب تحديد عدد النسخ " + "3", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                    TxtValu3.Focus();
                                    BtnSave.Enabled = true;

                                    return;
                                }
                            }
                            else
                            {
                                BtnSave.Enabled = true;
                                DesktopAlert.Show("يجب تحديد شركة الطيران " + "3", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                TxtAirLines3.Focus();
                                return;
                            }
                        }
                        if ((!string.IsNullOrEmpty(TxtGover4.Text) && TxtGover4.Text != " ") )
                        {
                            if ((!string.IsNullOrEmpty(TxtAirLines4.Text) && TxtAirLines4.Text != " "))
                            {
                                if (Convert.ToInt32(TxtValu4.Text) > 0)
                                {
                                    var do4 = await doSub("4", obj.Id, TxtGover4, TxtAirLines4, TxtValu4);
                                    if (!do4)
                                    {
                                        BtnSave.Enabled = true;
                                        return;
                                    }
                                }
                                else
                                {
                                    BtnSave.Enabled = true;
                                    DesktopAlert.Show("يجب تحديد عدد النسخ " + "4", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                    TxtValu4.Focus();

                                    return;
                                }
                            }

                            else
                            {
                                BtnSave.Enabled = true;
                                DesktopAlert.Show("يجب تحديد شركة الطيران " + "4", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                TxtAirLines4.Focus();
                                return;
                            }

                        }
                      


                        if (orderSubs.Count <= 0)
                        {
                            DesktopAlert.Show("يجب اختيار سطر واحد على الاقل ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                            BtnSave.Enabled = true;

                            return;
                        }


                        //DesktopAlert.Show("items in sub is :" + orderSubs.Count);



                        if (db.Entry<Order>(obj).State == EntityState.Detached)
                            db.Set<Order>().Attach(obj);
                        if (obj.IsPaid)
                        {
                            DesktopAlert.Show("هذا الطلب مدفوع ! لايمكن تعديله ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                            return;

                        }

                        var rsltSub=   await accControl.AddListOfOrdersSub(obj.Id, orderSubs);
                        if (rsltSub<=0)
                        {
                            DesktopAlert.Show("لم يتم إضافة السطور بنجاح ! اختر الدولة والطيران ثم حاول مرة اخرى ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                            BtnSave.Enabled = true;

                            return;
                        }

                        double TotalAmount = 0;
                        double Price = 0;
                        int Count = 0;

                        Price = Convert.ToDouble(TxtPrice.Text);
                        Count = Convert.ToInt32(OrderCountCalcEdit.Text);
                        TotalAmount= (Price* Count);

                        obj.TotalAmount = TotalAmount;
                        obj.LastUpdateDate = DateTime.Now;
                        obj.LastUpdateUserId = Program.userId;
                        obj.IsPrinted = true;
                        obj.PrintedStatue = "مطبوع";

                        db.Entry<Order>(obj).State = EntityState.Modified;
                        var rslt = await db.SaveChangesAsync();






                        //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
                        if (rslt > 0)
                        {



                            //var myCustomers= await accControl.GetCustomersDto(Convert.ToInt32(OrderCountCalcEdit.Text));//db.itemCategories.ToList();


                            //customerDtoBindingSource.DataSource = myCustomers;

                            //PASPOORT


                            DesktopAlert.Show("تم تعديل الطلب بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                            DesktopAlert.Show("يرجى الانتظار جاري طباعة التقارير ", eDesktopAlertColor.DarkBlue, eAlertPosition.TopRight);
                            await PrintReports();



                            Close();







                            layoutControlGroup1.Enabled = false;
                            BtnAdd_Click(sender, e);
                        }
                        else
                        {
                            BtnSave.Enabled = true;
                            BtnAdd.Enabled = false;
                        }
                    }
                   
                  

                }else
                {
                    BtnSave.Enabled = true;

                }
            }
        }
        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

      

        private void TxtValue_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ExCompanyIdLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                    BtnSave.Focus();
                
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

     

        private void AttachmeedFilePictureEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ExCompanyIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void DistrictNameComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NoteMemoEdit_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void BtnRemove1_Click(object sender, EventArgs e)
        {
            TxtGover1.ItemIndex = 0;
            TxtAirLines1.ItemIndex = 0;
            TxtValu1.Text = "0";
        }

        private void BtnRemove2_Click(object sender, EventArgs e)
        {
            TxtGover2.ItemIndex = 0;
            TxtAirLines2.ItemIndex = 0;
            TxtValu2.Text = "0";
        }

        private void BtnRemove3_Click(object sender, EventArgs e)
        {
            TxtGover3.ItemIndex = 0;
            TxtAirLines3.ItemIndex = 0;
            TxtValu3.Text = "0";
        }

        private void BtnRemove4_Click(object sender, EventArgs e)
        {
            TxtGover4.ItemIndex = 0;
            TxtAirLines4.ItemIndex = 0;
            TxtValu4.Text = "0";
        }

        private void TxtValu1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TxtValu1.Text) > Convert.ToInt32(OrderCountCalcEdit.Text))
                {
                    TxtValu1.Text = OrderCountCalcEdit.Text;
                               DesktopAlert.Show("لايمكن اضافة عدد اكبر من العدد المحدد في الطلب ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                    return;
                }
            }
            catch 
            {

                
            }
           
        }

        //void GetDataFromRows()
        //{
        //    if ((!string.IsNullOrEmpty(TxtGover1.Text) && TxtGover1.Text != " "))
        //    {
        //        if ((!string.IsNullOrEmpty(TxtAirLines1.Text) && TxtAirLines1.Text != " "))
        //        {


        //            if (Convert.ToInt32(TxtValu1.Text) > 0)
        //            {
        //                var do1 = await doSub("1", obj.Id, TxtGover1, TxtAirLines1, TxtValu1);
        //                if (!do1)
        //                {
        //                    BtnSave.Enabled = true;
        //                    return;
        //                }
        //            }
                   
        //        }
               
        //    }
        //    if ((!string.IsNullOrEmpty(TxtGover2.Text) && TxtGover2.Text != " "))
        //    {
        //        if ((!string.IsNullOrEmpty(TxtAirLines2.Text) && TxtAirLines2.Text != " "))
        //        {


        //            if (Convert.ToInt32(TxtValu2.Text) > 0)
        //            {
        //                var do2 = await doSub("2", obj.Id, TxtGover2, TxtAirLines2, TxtValu2);
        //                if (!do2)
        //                {
        //                    BtnSave.Enabled = true;
        //                    return;
        //                }
        //            }
                   
        //        }
                
        //    }
        //    if ((!string.IsNullOrEmpty(TxtGover3.Text) && TxtGover3.Text != " "))
        //    {
        //        if ((!string.IsNullOrEmpty(TxtAirLines3.Text) && TxtAirLines3.Text != " "))
        //        {
        //            if (Convert.ToInt32(TxtValu3.Text) > 0)
        //            {
        //                var do3 = await doSub("3", obj.Id, TxtGover3, TxtAirLines3, TxtValu3);
        //                if (!do3)
        //                {
        //                    BtnSave.Enabled = true;
        //                    return;
        //                }
        //            }
                   
        //        }
               
        //    }
        //    if ((!string.IsNullOrEmpty(TxtGover4.Text) && TxtGover4.Text != " "))
        //    {
        //        if ((!string.IsNullOrEmpty(TxtAirLines4.Text) && TxtAirLines4.Text != " "))
        //        {
        //            if (Convert.ToInt32(TxtValu4.Text) > 0)
        //            {
        //                var do4 = await doSub("4", obj.Id, TxtGover4, TxtAirLines4, TxtValu4);
        //                if (!do4)
        //                {
        //                    BtnSave.Enabled = true;
        //                    return;
        //                }
        //            }
                  
        //        }


        //    }

        //}
        async Task<bool> doReports(string rowId,IEnumerable<CustomerDto> cstLists, LookUpEdit txtgover, LookUpEdit txtair, int valuSkip, 
            CalcEdit valuTake,bool isCustomer, bool isVisa, bool isTicket, bool isWasl)
        {

            int CopiesCount = 0;
            string VisaPath = "";
            string AirLinePath = "";
            //try
            //{
            var Destination = txtgover.GetSelectedDataRow() as Destination;

            if (Destination != null)
                {
                    if (Destination.Id > 0)
                    {
                        var airlin = txtair.GetSelectedDataRow() as AirLine;

                    if (airlin != null)
                        {
                            if (airlin.Id > 0)
                            {

                        
                            CopiesCount = Convert.ToInt32(valuTake.Text);
                                var myCustomers = cstLists.Skip(valuSkip).Take(CopiesCount).ToList();
                            //MessageBox.Show("myCustomers : " + myCustomers.Count);

                            VisaPath = Application.StartupPath + @"\visa_" + Destination.Id + ".repx";

                                AirLinePath = Application.StartupPath + @"\tickt_" + airlin.Id + ".repx";
                                if (File.Exists(VisaPath) && File.Exists(AirLinePath))
                                {
                                    //MessageBox.Show("Row : "+rowId +" customers after take :"+ myCustomers.Count);
                                    foreach (var item in myCustomers)
                                    {
                                    if (isCustomer)
                                    {
                                        await RptCustomers(false, item.Id);


                                    }
                                    if (isVisa)
                                    {
                                        if (Destination.IsVisa)
                                        {
                                            await ShowRptVisas(false, item, VisaPath);

                                        }
                                    }
                                    if (isTicket)
                                    {
                                        await ShowRptTickets(false, item, AirLinePath);

                                    }
                                    if (isWasl)
                                    {
                                        await ShowRptWasl(false, item);

                                    }

                                }
                                }
                            }
                        }
                    }
                }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            

            return true;
        }
        bool IsPassport = false;
        bool IsTicket  = false;
        bool IsVisa  = false;
        bool IsExcell  = false;
        bool IsVoucher  = false;
        async Task PrintReports()
        {
            var subsc = await accControl.GetExCompany(ExCompanyId);
            if (subsc!=null)
            {
                var myCustomers = await accControl.GetCustomersOfList(Convert.ToInt32(OrderCountCalcEdit.Text), TxtGover1.Text, ExCompanyIdLookUpEdit.Text);

                IsPassport = subsc.Subscriber.IsPassport;
                IsVisa = subsc.Subscriber.IsVisa;
                IsTicket = subsc.Subscriber.IsTicket;
                IsVoucher = subsc.Subscriber.IsVoucher;




                await doReports("1", myCustomers, TxtGover1, TxtAirLines1, 0, TxtValu1,IsPassport,IsVisa,IsTicket,IsVoucher);
                await doReports("2", myCustomers, TxtGover2, TxtAirLines2, Convert.ToInt32(TxtValu1.Text), TxtValu2, IsPassport, IsVisa, IsTicket, IsVoucher);
                await doReports("3", myCustomers, TxtGover3, TxtAirLines3, Convert.ToInt32(TxtValu2.Text), TxtValu3, IsPassport, IsVisa, IsTicket, IsVoucher);
                await doReports("4", myCustomers, TxtGover4, TxtAirLines4, Convert.ToInt32(TxtValu3.Text), TxtValu4, IsPassport, IsVisa, IsTicket, IsVoucher);

                if (subsc.Subscriber.IsExcell)
                {
                    await ExportToExcell(myCustomers, Id);

                }
            }
            //var myCustomers = await accControl.GetCustomersDto(Convert.ToInt32(OrderCountCalcEdit.Text));//db.itemCategories.ToList();
         

        }
        private  void simpleButton1_Click_1(object sender, EventArgs e)
        {

            //var myCustomers = await accControl.GetCustomersOfList(Convert.ToInt32(OrderCountCalcEdit.Text),TxtGover1.Text, ExCompanyIdLookUpEdit.Text);

            //customerDtoBindingSource1.DataSource = myCustomers;

            //    //= await accControl.GetCustomersDto(100);//db.itemCategories.ToList();


            //await ExportToExcell(myCustomers,Id);


            //await doReports("1", myCustomers,TxtGover1,TxtAirLines1,0,TxtValu1);
            //await doReports("2", myCustomers,TxtGover2,TxtAirLines2, Convert.ToInt32(TxtValu1.Text), TxtValu2);
            //await doReports("3", myCustomers,TxtGover3,TxtAirLines3, Convert.ToInt32(TxtValu2.Text), TxtValu3);
            //await doReports("4", myCustomers,TxtGover4,TxtAirLines4,Convert.ToInt32(TxtValu3.Text),TxtValu4);

        }
    }
}