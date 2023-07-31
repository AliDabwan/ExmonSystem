using DevComponents.DotNetBar.Controls;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraReports.UI;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using ExmonSystem.RPT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem
{
    public  class Helper
    {


        public async void Xmlcreatedb_Voucher(int billId, int billNo, string billtype)
        {
            AccountControl billControl = new AccountControl();

            DataSet invo = new DataSet();

            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            var billMain = await billControl.GetVouchersForXml(billtype, billId);

            if (billMain == null)
            {
                return;

            }
         



            invo.Tables.Add(billMain);
            invo.Tables[0].TableName = "Vouchers";
          

            string name = Application.StartupPath + @"\XmlVouchers\" + billtype + @"\" + billNo + ".xml";

            if (!Directory.Exists(Application.StartupPath + @"\XmlVouchers\" + billtype))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\XmlVouchers\" + billtype);
            }

            string outpath = name;
            if (File.Exists(outpath))
            {
                System.IO.File.Delete(outpath);
            }
            using (TextWriter tw = File.CreateText(outpath))
            {

                invo.WriteXml(tw, XmlWriteMode.WriteSchema);
                tw.Close();
            }

            invo.Tables.Clear();
            invo.Dispose();
            return;
            //     System.Windows.Forms.MessageBox.Show("dispos");
        }




        public int  GetVersionInfo()
        {
            



            using (MyDbContext db = new MyDbContext())
            {

                var gigaVno = db.MyVersionInfo.FirstOrDefault();
                if (gigaVno != null)
                {
                    return gigaVno.UpdateNo;

                }else
                {
                    return 0;
                }


            }

            //}
            //catch (Exception ex)
            //{


            //    return -1;

            //}


        }


        public async Task AddVersionInfo(int Vno)
        {
            if (Vno == 0)
            {
                return;
            }
            int rslt = 0;
            //try
            //{



            using (MyDbContext db = new MyDbContext())
            {


                var myvno = db.MyVersionInfo.FirstOrDefault();
                if (myvno != null)
                {
                    db.MyVersionInfo.Remove(myvno);

                }

                var gigaVno = new myVersionInfo()
                {
                    UpdateNo = Vno,

                };

                if (gigaVno != null)
                {



                    db.MyVersionInfo.Add(gigaVno);
                    rslt = await db.SaveChangesAsync();

                }





                if (rslt <= 0)
                {

                    SetLog("Op: " + "UpdateFiluer" + " - " + " No : " + Vno + " userId: " + Program.userId);
                    return;


                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }

            //}
            //catch (Exception ex)
            //{


            //    return -1;

            //}


        }

        public  bool GetSettingsSaveMode()
        {
            if (!File.Exists(@".\mySetingsSaveMode.json"))
            {

                return false;
            }
            using (StreamReader r = new StreamReader(@".\mySetingsSaveMode.json"))
            {
                var json = r.ReadToEnd();
                mySetingsSaveMode items = JsonConvert.DeserializeObject<mySetingsSaveMode>(json);

                //DesktopAlert.Show("New Update Detected");

                if (items != null)
                {
                    Properties.Settings.Default.IsInitialize = items.IsInitialize;
                    Properties.Settings.Default.PropActv = items.PropActv;
                    Properties.Settings.Default.Propfree = items.Propfree;
                    Properties.Settings.Default.ConType = items.ConType;
                    Properties.Settings.Default.ConName = items.ConName;
                    Properties.Settings.Default.Save();
                    return true;
                }
                else
                {
                    return false;
                }

            }


        }


        public void SetVerifyJSON(mySetingsSaveMode items)
        {
            try
            {
                if (File.Exists(@".\mySetingsSaveMode.json"))
                {
                    File.Delete(@".\mySetingsSaveMode.json");
                }
                if (items != null)
                {
                    File.WriteAllText(@".\mySetingsSaveMode.json", JsonConvert.SerializeObject(items));

                }
            }
            catch
            {


            }



        }
        public  void SetSettingsSaveMode(mySetingsSaveMode items)
        {
            try
            {
                if (File.Exists(@".\mySetingsSaveMode.json"))
                {
                    File.Delete(@".\mySetingsSaveMode.json");
                }
                if (items != null)
                {
                    File.WriteAllText(@".\mySetingsSaveMode.json", JsonConvert.SerializeObject(items));

                }
            }
            catch
            {

               
            }
           


        }
        public async Task AddGigalog(string Command, string logTable,string type,string LogId,string LogNo)
        {
            if (type == null)
            {
                return;
            }
            int rslt = 0;
            //try
            //{



            using (MyDbContext db = new MyDbContext())
            {

                //var gigaLog = new Gigalog()
                //{
                //    LogTypeCommand= Command,
                //    LogOnTable= logTable,
                //    LogId= LogId,
                //    LogNo= LogNo,
                //    LogType= type


                //};

                //if (gigaLog!=null)
                //{

                //    db.Gigalogs.Add(gigaLog);
                //    rslt = await db.SaveChangesAsync();

                //}





                if (rslt <= 0)
                {
                 
                    SetLog("Op: "+Command +" :"+ type+" : refId: "+LogId+" : refNo: " + LogNo + " - " +" table : "+ logTable+" userId: "+Program.userId);
                    return;


                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }

            //}
            //catch (Exception ex)
            //{


            //    return -1;

            //}


        }

        public bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }
        public bool ShowMessageConfirmForBarcodPrint(System.Windows.Forms.Form owner, string Caption, string MessageBody,string Cmnd1,string Cmnd2)
        {
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = Caption, Description = MessageBody };
            Predicate<DialogResult> predicate = canCloseFunc;
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = Cmnd1, Result = System.Windows.Forms.DialogResult.Yes };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = Cmnd2, Result = System.Windows.Forms.DialogResult.No };
            action.Commands.Add(command1);
            action.Commands.Add(command2);
            FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;
            if (FlyoutDialog.Show(owner, action, properties, predicate) == System.Windows.Forms.DialogResult.Yes)
                return true;
            return false;
        }

        public  bool ShowMessageConfirm(System.Windows.Forms.Form owner,string Caption ,string MessageBody)
        {
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = Caption, Description = MessageBody };
            Predicate<DialogResult> predicate = canCloseFunc;
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Yes | نعم", Result = System.Windows.Forms.DialogResult.Yes };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "No | لا", Result = System.Windows.Forms.DialogResult.No };
            action.Commands.Add(command1);
            action.Commands.Add(command2);
            FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(100, 40);
         
            properties.Style = FlyoutStyle.MessageBox;
            if (FlyoutDialog.Show(owner, action, properties, predicate) == System.Windows.Forms.DialogResult.Yes)
                return true;
            return false;
        }
        public bool ShowMessage(System.Windows.Forms.Form owner, string Caption, string MessageBody)
        {
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = Caption, Description = MessageBody };
            Predicate<DialogResult> predicate = canCloseFunc;
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Yes | نعم", Result = System.Windows.Forms.DialogResult.Yes };
            action.Commands.Add(command1);
            FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;
            if (FlyoutDialog.Show(owner, action, properties, predicate) == System.Windows.Forms.DialogResult.Yes)
                return true;
            return false;
        }


        //public void Reportt( DataTable Dt_Source, string RptName, string param1, string param2, string param3, string typePaper, bool printt, int Copies, int Repeats, bool WithStar, string SortBy)
        //{
        //    DataTable BR_TABLE = new DataTable();

        //    string XmlFile = "";

        //    //;



        //    if (Copies == 0)
        //    {
        //        Copies = 1;
        //    }
        //    if (Repeats == 0)
        //    {
        //        Repeats = 1;
        //    }

        //    XmlFile = "ReportOneTable";


        //    if (Dt_Source.Rows.Count <= 0)
        //    { return; }

        //    if (Repeats > 1)
        //    {


        //        BR_TABLE.Clear();
        //        BR_TABLE = Dt_Source.Clone();

        //        foreach (DataRow dr in Dt_Source.Rows)
        //        {

        //            for (int i = 0; i < Repeats; i++)
        //            {
        //                BR_TABLE.ImportRow(dr);
        //            }
        //        }

        //        //for (int i = 0; i < Copies; i++)
        //        //{
        //        //    for (int k = 0; k < Dt_Source.Rows.Count; k++)
        //        //    {
        //        //        DataRow x = BR_TABLE.NewRow();

        //        //        x[0] = Dt_Source.Rows[k][0];
        //        //        x[1] = Dt_Source.Rows[k][1];
        //        //        x[2] = Dt_Source.Rows[k][2];
        //        //        x[3] = Dt_Source.Rows[k][3];
        //        //        x[4] = Dt_Source.Rows[k][4];

        //        //        BR_TABLE.Rows.Add(x);
        //        //    }
        //        //}


        //        createdb_BARACODE(Dt_Source, XmlFile);
        //    }
        //    else
        //    {
        //        createdb_BARACODE(Dt_Source, XmlFile);

        //    }
        //    DataSet dsd = new DataSet(); ////////////////////////////////////////dataset 

        //    Report rr = new Report();
        //    dsd.ReadXml(System.Windows.Forms.Application.StartupPath + "\\" + XmlFile + ".xml");


        //    if (typePaper == "A4")
        //    {
        //        rr.Load(System.Windows.Forms.Application.StartupPath + @"\rpt\" + RptName + ".frx");
        //    }
        //    else
        //    {
        //        rr.Load(System.Windows.Forms.Application.StartupPath + @"\rpt\" + RptName + ".frx");

        //    }


        //    rr.RegisterData(dsd);/// the name
        //    rr.GetDataSource("item").Enabled = true;

        //    DataBand data1 = new DataBand();
        //    data1.Name = "Data1";
        //    data1.DataSource = rr.GetDataSource("item");
        //    if (!string.IsNullOrEmpty(SortBy))
        //    {
        //        data1.Sort.Add(new Sort("item." + SortBy));

        //    }
        //    data1.GetData();




        //    if (Properties.Settings.Default.PropHReportsHeader == true)
        //    {
        //        (rr.FindObject("ReportTitle1") as ReportTitleBand).Visible = true;

        //    }
        //    else
        //    {
        //        (rr.FindObject("ReportTitle1") as ReportTitleBand).Visible = false;

        //    }

        //    if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\MyLogo.png"))
        //    {

        //        //}
        //        Image myimg = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\" +  Properties.Settings.Default.PropLogoName);
        //        (rr.FindObject("Picture1") as PictureObject).Image = myimg;

        //    }
        //    else
        //    {
        //        (rr.FindObject("Picture1") as PictureObject).Image = Properties.Resources.images;

        //    }

        //    rr.Parameters[0].Value = Properties.Settings.Default.COMPANY;
        //    rr.Parameters[1].Value = Properties.Settings.Default.CompanyDetailsAr;
        //    rr.Parameters[2].Value ="";
        //    rr.Parameters[3].Value = Properties.Settings.Default.CompanyPhons;
        //    rr.Parameters[4].Value = Properties.Settings.Default.COMPANYEn;
        //    rr.Parameters[5].Value = Properties.Settings.Default.CompanyDetailsEn;
        //    rr.Parameters[6].Value = "";
        //    rr.Parameters[7].Value = "";

        //    rr.Parameters[8].Value = DateTime.Now.ToString("yyyy-MM-dd");
        //    rr.Parameters[9].Value = DateTime.Now.ToString("yyyy-MM-dd");

        //    rr.Parameters[10].Value = param1;
        //    rr.Parameters[11].Value = param2;
        //    rr.Parameters[12].Value = param3;


        //    if (printt == true)
        //    {

        //        rr.PrintSettings.ShowDialog = false;
        //        if (typePaper == "A4")
        //        {
        //            if (Properties.Settings.Default.PRINTER_CUSTOM == string.Empty)
        //            {
        //                DesktopAlert.Show("يجب تحديد طابعة التقارير في خصائص التقارير" + "\n" + "No Printer was selected before ");
        //                return;
        //            }
        //            rr.PrintSettings.Printer = Properties.Settings.Default.PRINTER_CUSTOM;
        //        }
        //        else if (typePaper == "Roll")
        //        {
        //            if (Properties.Settings.Default.PRINTER_Roll == string.Empty)
        //            {
        //                DesktopAlert.Show("يجب تحديد طابعة تقارير الرول في خصائص تقارير الرول" + "\n" + "No Printer was selected before ");

        //                return;
        //            }
        //            rr.PrintSettings.Printer = Properties.Settings.Default.PRINTER_Roll;
        //        }
        //        else
        //        {
        //            if (Properties.Settings.Default.PRINTER_PARACOD == string.Empty)
        //            {
        //                DesktopAlert.Show("يجب تحديد طابعة ملصقات الباركود في خصائص الباركود" + "\n" + "No Printer was selected before ");

        //                return;
        //            }
        //            rr.PrintSettings.Printer = Properties.Settings.Default.PRINTER_PARACOD;


        //        }
        //        rr.PrintSettings.Copies = Copies;
        //        rr.Print();
        //    }
        //    else
        //    {
        //        //PL.Shared.FrmReport FrmReport = new PL.Shared.FrmReport();
        //        rr.Show();
        //        //FrmReport.ShowDialog();
        //    }
        //    data1.Dispose();

        //    dsd.Dispose();
        //}



        public void createdb_BARACODE(DataTable B_TABLE ,string XmlFile)
        {
            DataSet invo = new DataSet();


            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(B_TABLE);
            invo.Tables[0].TableName = "item";
         
            //string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "baracode_product.xml";
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + XmlFile + ".xml";

            if (File.Exists(outpath))
            {
                System.IO.File.Delete(outpath);
            }
            using (TextWriter tw = File.CreateText(outpath))
            {

                invo.WriteXml(tw);
                tw.Close();
            }
            B_TABLE.DataSet.Clear();
            B_TABLE.Dispose();

            invo.Tables.Clear();
            invo.Dispose();

            //     System.Windows.Forms.MessageBox.Show("dispos");
        }
        //public void ReportDesign(string RptName)
        //{
        //    Report rr = new Report();

        //    rr.Load(System.Windows.Forms.Application.StartupPath + @"\rpt\" + RptName + ".frx");
        //    //PL.Shared.FrmReport FrmReport = new PL.Shared.FrmReport();
        //    rr.Design();

        //    //FrmReport.ShowDialog();
        //}



        public void ShowReport( string rptName)
        {


            XtraReport rd = XtraReport.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + rptName + ".repx", true);
     
            ReportPrintTool printTool = new ReportPrintTool(rd);
            //ReportPrintTool printTool = new ReportPrintTool(RptCashAccountsName.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "CashesAccountsNamesRPT.repx", true));

            printTool.ShowPreviewDialog();
        }


 


        public  string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public  string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }


        public  void DesignRptMerged(XtraReport xs)
        {
            if (xs!=null)
            {
                xs.ShowRibbonDesignerDialog();


            }


        }
        public async Task myReportBillDesigner( bool isPos)
        {
           
           

                XtraReport rd = new XtraReport();

            if (isPos)
            {

                if (Program.myCompany.UseResurantMode)
                {
                    rd = XtraReport.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptPOSResturant.repx", true);

                }
                else
                {
                    rd = XtraReport.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptPOSinvoice.repx", true);

                }
            }
            else
            {
                rd = RptSaleInvoice.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptSaleInvoice.repx", true);

            }

            rd.ShowRibbonDesignerDialog();
                //using (ReportDesignTool printTool = new ReportDesignTool(rd))
                //{
                //    printTool.ShowDesigner();


                //    //DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                //    //ds.Dispose();
                //}

            
        }

        public async Task myReportNoteDesigner(bool isPos)
        {



            XtraReport rd = new XtraReport();

            if (isPos)
            {

                rd = XtraReport.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptDiscountNote.repx", true);

            }
            else
            {
                rd = RptSaleInvoice.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptDiscountNote.repx", true);

            }

            rd.ShowRibbonDesignerDialog();
            //using (ReportDesignTool printTool = new ReportDesignTool(rd))
            //{
            //    printTool.ShowDesigner();


            //    //DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
            //    //ds.Dispose();
            //}


        }


        public bool createdb_Bill(DataTable B_TABLE, DataTable B_sub, DataTable B_Customer)
        {
            try
            {
                DataSet invo = new DataSet();

                //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
                invo.Tables.Add(B_TABLE);
                invo.Tables[0].TableName = "BillMain";
                invo.Tables.Add(B_sub);
                invo.Tables[1].TableName = "BillSub";
                invo.Tables.Add(B_Customer);
                invo.Tables[2].TableName = "BillCustSup";
                string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "myBillReports.xml";
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
                B_sub.DataSet.Clear();
                B_sub.Dispose();
                invo.Tables.Clear();
                invo.Dispose();
                return true;
            }
            catch
            {

                return false;
            }
            
            //     System.Windows.Forms.MessageBox.Show("dispos");
        }



        public bool createXML_Bill(DataTable B_TABLE, DataTable B_sub, DataTable B_Customer)
        {
            DataSet invo = new DataSet();

            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(B_TABLE);
            invo.Tables[0].TableName = "BillMain";
            invo.Tables.Add(B_sub);
            invo.Tables[1].TableName = "BillSub";
          
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "myBillReports.xml";
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
            B_sub.DataSet.Clear();
            B_sub.Dispose();
            invo.Tables.Clear();
            invo.Dispose();
            return true;
            //     System.Windows.Forms.MessageBox.Show("dispos");
        }
        public bool createdb_Bill(DataTable B_TABLE,  DataTable B_Customer)
        {
            DataSet invo = new DataSet();

            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(B_TABLE);
            invo.Tables[0].TableName = "BillMain";
          
            invo.Tables.Add(B_Customer);
            invo.Tables[1].TableName = "BillCustSup";
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "myBillReports.xml";
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
           
            invo.Tables.Clear();
            invo.Dispose();
            return true;
            //     System.Windows.Forms.MessageBox.Show("dispos");
        }




        public async Task myReportVoucher(bool isPrint, bool isPos
        , int VoucherId, string transTypee, string transTypeeAr,string EntryType,string realBalance)
        {
            AccountControl accControl = new AccountControl();

            var VMain = await accControl.GetVoucher(transTypee, VoucherId, EntryType);

            //MessageBox.Show(accDt.Rows.Count.ToString());
            if (createdb_Voucher(VMain))
            {


                XtraReport rd = new XtraReport();

                //if (isPos)
                //{
                //    rd = RptPOSinvoice.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptRollVoucher.repx", true);

                //}
                //else
                //{
                    rd = RptVoucher.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptVoucher.repx", true);

                //}

                rd.Parameters["VoucherId"].Value = VoucherId;

                rd.Parameters["transTypee"].Value = transTypee;
                rd.Parameters["transTypeeAr"].Value = transTypeeAr;
                rd.Parameters["CurrentBalance"].Value = realBalance;
           


                rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
                rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
                rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
                rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
                rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;

                foreach (var item in rd.Parameters)
                {
                    item.Visible = false;
                }


                using (ReportPrintTool printTool = new ReportPrintTool(rd))
                {

                    if (isPrint)
                    {
                        
                            if (string.IsNullOrEmpty(Properties.Settings.Default.PRINTER_CUSTOM))
                            {
                                DesktopAlert.Show("يجب إختيار الطابعة " + "  " + "Please select Printer");
                                var frmst = new FrmStrat();
                                frmst.ShowDialog();
                                return;
                            }
                            printTool.PrinterSettings.PrinterName = Properties.Settings.Default.PRINTER_CUSTOM;

                        
                        printTool.Print();

                    }
                    else
                    {
                        printTool.ShowPreviewDialog();

                    }

                    DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                    ds.Dispose();
                }

            }

        }
      
        public bool createdb_Voucher(DataTable B_TABLE)
        {
            DataSet invo = new DataSet();

            //  System.Windows.Forms.MessageBox.Show(B_TABLE.DataSet.ToString());
            invo.Tables.Add(B_TABLE);
            invo.Tables[0].TableName = "VoucherMain";
         
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "myVoucher.xml";
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
      
            invo.Tables.Clear();
            invo.Dispose();
            return true;
            //     System.Windows.Forms.MessageBox.Show("dispos");
        }





        private string GetDecimalValue(string decimalPart)
        {
            string result = String.Empty;
            //  Currency.PartPrecision =2     - 1 rial equal 100 halala
            var CurrencyPartPrecision = 2;
            if (CurrencyPartPrecision != decimalPart.Length)
            {
                result = String.Format("{0}.{1}", decimalPart.Substring(0, CurrencyPartPrecision), decimalPart.Substring(CurrencyPartPrecision, decimalPart.Length - CurrencyPartPrecision));

                result = (Math.Round(Convert.ToDecimal(result))).ToString();
            }
            else
                result = decimalPart;

            for (int i = 0; i < CurrencyPartPrecision - result.Length; i++)
            {
                result += "0";
            }

            return result;
        }

        public string getDecInt(decimal ValueNumber)
        {
            this.Number = ValueNumber;
         return   ExtractIntegerAndDecimalParts();

        }
        private long _intergerValue;

        /// <summary>
        /// Decimal Part
        /// </summary>
        private int _decimalValue;

        /// <summary>
        /// Number to be converted
        /// </summary>
        public decimal Number { get; set; }
        /// <summary>
        /// Eextract Interger and Decimal parts
        /// </summary>
        private string ExtractIntegerAndDecimalParts()
        {
            String[] splits = Number.ToString().Split('.');

            _intergerValue = (long)Convert.ToDouble(splits[0]);

            if (splits.Length > 1)
                _decimalValue = Convert.ToInt32(GetDecimalValue(splits[1]));

            return "integer= " + _intergerValue + "  Decimal= " + _decimalValue ;

        }



        public void DoBackup()
        {
            AppSettings setting = new AppSettings();
            var conname = Properties.Settings.Default.ConName;
            //DesktopAlert.Show(conname);

            string database = setting.conDetails(conname).InitialCatalog;

            if (Properties.Settings.Default.PropBackUpPath == string.Empty)
            {
                if (!System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + @"\Backups"))
                {
                    System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + @"\Backups");
                    Properties.Settings.Default.PropBackUpPath = System.Windows.Forms.Application.StartupPath + @"\Backups";
                    Properties.Settings.Default.Save();
                }
            }

            string txt_path = Properties.Settings.Default.PropBackUpPath;




            //try
            //{
            string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txt_path + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

            using (MyDbContext context = new MyDbContext())
            {



                var rslt = context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);


                foreach (var fi in new DirectoryInfo(txt_path).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(25))
                    fi.Delete();
                DesktopAlert.Show(" تم إجراء النسخ الإحتياطي بنجاح");


            }


            //}
            //catch
            //{

            //}
            //  backup();
            //BAL.CHK CLSS3 = new BAL.CHK();

            //if (CLSS3.SET_BACKUP() == true)
            //{
            //    MessageBox.Show("تمت عملية النسخ الإحتياطي بنجاح", "عملية النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("فشلت عملية النسخ الإحتياطي يجب تحديد المسار الإقتراضي للنسخ الإحتياطية  ", "عملية النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }
        public void DoBackupSilent()
        {
            try
            {


                AppSettings setting = new AppSettings();
                var conname = Properties.Settings.Default.ConName;
                //DesktopAlert.Show(conname);

                string database = setting.conDetails(conname).InitialCatalog;

                if (Properties.Settings.Default.PropBackUpPath == string.Empty)
                {
                    if (!System.IO.Directory.Exists(System.Windows.Forms.Application.StartupPath + @"\Backups"))
                    {
                        System.IO.Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + @"\Backups");
                        Properties.Settings.Default.PropBackUpPath = System.Windows.Forms.Application.StartupPath + @"\Backups";
                        Properties.Settings.Default.Save();
                    }
                }

                string txt_path = Properties.Settings.Default.PropBackUpPath;




                //try
                //{
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txt_path + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                using (MyDbContext context = new MyDbContext())
                {



                    var rslt = context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);


                    foreach (var fi in new DirectoryInfo(txt_path).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(25))
                        fi.Delete();
                }
            

            }
            catch
            {
                return;
            }
            //  backup();
            //BAL.CHK CLSS3 = new BAL.CHK();

            //if (CLSS3.SET_BACKUP() == true)
            //{
            //    MessageBox.Show("تمت عملية النسخ الإحتياطي بنجاح", "عملية النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("فشلت عملية النسخ الإحتياطي يجب تحديد المسار الإقتراضي للنسخ الإحتياطية  ", "عملية النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }

        public void DoRestor(string FilePath)
        {
            AppSettings setting = new AppSettings();

            var conname = Properties.Settings.Default.ConName;
            string database = setting.conDetails(conname).InitialCatalog;


            string txt_path = FilePath;




            //try
            //{
            string cmd = "ALTER DATABASE [" + database + "] SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE  [" + database + "] FROM Disk='" + txt_path + "'";

            using (MyDbContext context = new MyDbContext())
            {



                var rslt = context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);


                DesktopAlert.Show(" تم إستعادة النسخ الإحتياطي بنجاح");
            }


            //}
            //catch
            //{

            //}
            //  backup();
            //BAL.CHK CLSS3 = new BAL.CHK();

            //if (CLSS3.SET_BACKUP() == true)
            //{
            //    MessageBox.Show("تمت عملية النسخ الإحتياطي بنجاح", "عملية النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("فشلت عملية النسخ الإحتياطي يجب تحديد المسار الإقتراضي للنسخ الإحتياطية  ", "عملية النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }

        public  void SetLog(string errDetails, string fname)
        {
            //if (!File.Exists(@".\mylog.json"))
            //{
            //    File.Delete(@".\serverCon.json");
            //}
         
            var log = new myLog() { ErrorDetails = errDetails };
            if (log != null)
            {
                File.WriteAllText(@".\" + fname + "_Log.json", JsonConvert.SerializeObject(log));

            }


        }
        public void SetLog(string errDetails)
        {
            //if (!File.Exists(@".\mylog.json"))
            //{
            //    File.Delete(@".\serverCon.json");
            //}

            if (!Directory.Exists(@"logs"))
            {
                Directory.CreateDirectory(@"logs");
            }

            var log = new myLog() { ErrorDetails = errDetails };
            if (log != null)
            {
                File.WriteAllText(@"logs\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".json", JsonConvert.SerializeObject(log));

            }


        }


    }
}
