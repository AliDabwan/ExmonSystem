using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using ExmonSystem.RPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem
{
    public partial class FrmStrat : DevExpress.XtraEditors.XtraForm
    {
        CompanyControl company = new CompanyControl();
       
        Helper helper = new Helper();

        public FrmStrat()
        {
            InitializeComponent();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string FNAME = "";
                FNAME = xtraFolderBrowserDialog1.SelectedPath;
                txtBackupFolder.Text = FNAME;
                Properties.Settings.Default.PropBackUpPath = FNAME;
                Properties.Settings.Default.Save();
            }
            else
            {

                return;
            }
        }

        private async void FrmStrat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gIGADBDataSet.Company' table. You can move, or remove it, as needed.
            txtBackupFolder.Text = Properties.Settings.Default.PropBackUpPath;
            string PRINTERS;



            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PRINTERS = PrinterSettings.InstalledPrinters[i];
                ComBoxInvoicePrinter.Items.Add(PRINTERS);
                ComBoxBarcodPrinter.Items.Add(PRINTERS);
              

            }
          
            txtCompanyName.Text  = Properties.Settings.Default.COMPANY;
            txtCompanyAdd.Text   = Properties.Settings.Default.CompanyDetailsAr;
            txtCompanyPhone.Text = Properties.Settings.Default.CompanyPhons;
            txtCompanyTAX.Text   = Properties.Settings.Default.CompanyTaxNumber;
            txtCompanyEmail.Text = Properties.Settings.Default.CompanyDetailsEn;
             ComBoxInvoicePrinter.Text  = Properties.Settings.Default.PRINTER_CUSTOM;
            ComBoxBarcodPrinter.Text  = Properties.Settings.Default.PRINTER_PARACOD;



            var companies =await company.GetAllCompany();

         
            //CheckItemCostUpdateWithPurchase.Checked = (bool)companies.CheckItemCostUpdateWithPurchase;
            //CheckMizanAllowUse.Checked = (bool)companies.CheckMizanAllowUse;
            //TxtMizanStarts.Value = companies.MizanStarts;
            //TxtMizanItemlength.Value = companies.MizanItemlength;
            //TxtMizanItemQty.Value = companies.MizanItemQty;


            if (companies==null)
            {

                companyBindingSource.Add(new Company());
                companyBindingSource.MoveLast();
                txtCompanyName.Focus();
            }else
            {
                companyBindingSource.DataSource = companies;/// db.itemCategories.ToList();

               PropMizanType.Value=companies.PropMizanType        ; 
            
                companyBindingSource.MoveLast();
            }

            try
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + @"\myLogo.jpg");

                txtCompanyImage.Image = bitmap;
            }
            catch { return; }
           
        }

        private async void ButSaveCompany_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsInitialize = true;
           Properties.Settings.Default.COMPANY= txtCompanyName.Text ; 
           Properties.Settings.Default.CompanyDetailsAr= txtCompanyAdd.Text ;  
           Properties.Settings.Default.CompanyPhons= txtCompanyPhone.Text ;
           Properties.Settings.Default.CompanyTaxNumber= txtCompanyTAX.Text ;
           Properties.Settings.Default.CompanyDetailsEn= txtCompanyEmail.Text ;
            Properties.Settings.Default.PRINTER_CUSTOM = ComBoxInvoicePrinter.Text;
            Properties.Settings.Default.PRINTER_PARACOD = ComBoxBarcodPrinter.Text;


            Properties.Settings.Default.Save();


            Company obj = companyBindingSource.Current as Company;

            if (obj!=null)
            {



                //obj.CheckItemCostUpdateWithPurchase = CheckItemCostUpdateWithPurchase.Checked;
                //obj.CheckMizanAllowUse = CheckMizanAllowUse.Checked;
                //obj.MizanStarts = (int)TxtMizanStarts.Value;
                //obj.MizanItemlength = (int)TxtMizanItemlength.Value;
                //obj.MizanItemQty = (int)TxtMizanItemQty.Value;

             var rslt =await company.AddCompany(obj);
                if (rslt>0)
                {
                    helper.ShowMessage(this, "Settings إعدادات", " Settings Saved Successfully تم حفظ الإعدادات بنجاح ");


                }
            }



        }

        private async void ButSaveInvoice_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PRINTER_CUSTOM = ComBoxInvoicePrinter.Text;

            Properties.Settings.Default.PRINTER_PARACOD = ComBoxBarcodPrinter.Text;


            Properties.Settings.Default.Save();

            Company obj = companyBindingSource.Current as Company;

            if (obj != null)
            {

              
            

                var rslt = await company.AddCompany(obj);
                if (rslt > 0)
                {
                    Program.myCompany = obj;
                    helper.ShowMessage(this, "Settings إعدادات", " Settings Saved Successfully تم حفظ الإعدادات بنجاح ");
                    Close();

                }
            }





        }

        private async void ButSaveVAT_Click(object sender, EventArgs e)
        {
           
            Company obj = companyBindingSource.Current as Company;
         

            if (obj != null)
            {


                var rslt = await company.AddCompany(obj);
                if (rslt > 0)
                {
                   
                    Program.myCompany = obj;
                    helper.ShowMessage(this, "Settings إعدادات", " Settings Saved Successfully تم حفظ الإعدادات بنجاح ");
                    Close();

                }
            }

        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void CheckPurchaseAppTax_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            Company obj = companyBindingSource.Current as Company;

            if (obj != null)
            {

             

                //obj.CheckItemCostUpdateWithPurchase = CheckItemCostUpdateWithPurchase.Checked;
                //obj.CheckMizanAllowUse = CheckMizanAllowUse.Checked;
                //obj.MizanStarts = (int)TxtMizanStarts.Value;
                //obj.MizanItemlength = (int)TxtMizanItemlength.Value;
                //obj.MizanItemQty = (int)TxtMizanItemQty.Value;

                var rslt = await company.AddCompany(obj);
                if (rslt > 0)
                {
                    Program.myCompany = obj;
                    helper.ShowMessage(this, "Settings إعدادات", " Settings Saved Successfully تم حفظ الإعدادات بنجاح ");
                    Close();

                }
            }
        }

        private void ButbrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = Guid.NewGuid()+".jpg";//opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---

                    //if (File.Exists(filepath))
                    //{
                    //    File.Delete(filepath);
                    //}
                    
                    File.Copy(filepath, appPath + iName); // <---
                    Properties.Settings.Default.PropLogoName = iName;
                    Properties.Settings.Default.Save();
                   txtCompanyImage.Image = new Bitmap(opFile.OpenFile());
                }
                catch (Exception exp)
                {
                    DesktopAlert.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            try
            {
                txtCompanyImage.Image = null;
                if (File.Exists(Application.StartupPath + @"\myLogo.jpg"))
                {
                    File.Delete(Application.StartupPath + @"\myLogo.jpg");
                }


            }
            catch (Exception exp)
            {
                DesktopAlert.Show("Unable to open file " + exp.Message);
            }

}

        private  void ButRestore_Click(object sender, EventArgs e)
        {

            xtraOpenFileDialog1.DefaultExt = ".db";
            xtraOpenFileDialog1.Filter = "ملفات | *.bak; *.BAK; *.Bak;";
            xtraOpenFileDialog1.InitialDirectory = Properties.Settings.Default.PropBackUpPath;
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string AttachFile = xtraOpenFileDialog1.FileName;

                string AttachmentType = Path.GetExtension(AttachFile);
                if (AttachmentType != ".BAK" && AttachmentType != ".bak" && AttachmentType != ".Bak")
                {
                    MessageBox.Show("ملف قاعدة البيانات غير صحيح");
                    return;
                }


                helper.DoRestor(AttachFile);

            }
        }

        private void butBackup_Click(object sender, EventArgs e)
        {
            //  helper.DoBackup();
            helper.DoBackup();
        }

        private void txtCompanyPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //XtraReport rd = RptPOSinvoice.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptPOSinvoice.repx", true);

            //ReportDesignTool printTool = new ReportDesignTool(rd);
            //printTool.ShowRibbonDesignerDialog();
            //DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
            //ds.Dispose();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraReport rd = RptSaleInvoice.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptSaleInvoice.repx", true);

            ReportDesignTool printTool = new ReportDesignTool(rd);
            printTool.ShowRibbonDesignerDialog();
            DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
            ds.Dispose();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            XtraReport rd = RptBarcode50X25.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptBarcode50X25.repx", true);

            ReportDesignTool printTool = new ReportDesignTool(rd);
            printTool.ShowRibbonDesignerDialog();
            DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
            ds.Dispose();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            XtraReport rd = RptPrescripUsageLabel50X25.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptPrescripUsageLabel50X25.repx", true);

            ReportDesignTool printTool = new ReportDesignTool(rd);
            printTool.ShowRibbonDesignerDialog();
            DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
            ds.Dispose();

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void PropMizanStarts_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void integerInput1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PropMizanLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
          
        }

        private void PropAutoBackupinClose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void simpleButton7_Click(object sender, EventArgs e)
        {
            Company obj = companyBindingSource.Current as Company;

            if (obj != null)
            {

                if (obj.ResetTalapInEndDay==1)
                {
                }

                var rslt = await company.AddCompany(obj);
                if (rslt > 0)
                {
                    Program.myCompany = obj;
                    helper.ShowMessage(this, "Settings إعدادات", " Settings Saved Successfully تم حفظ الإعدادات بنجاح ");
                    Close();

                }
            }
        }

        private void checkEdit6_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void UseResturantMode_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            try
            {
                XtraReport rd = new XtraReport();

                rd = RptPassport.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptPassport.repx", true);


                rd.ShowRibbonDesignerDialog();
            }
            catch
            {

                return;
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                XtraReport rd = new XtraReport();

                rd = RptWasl.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptWasl.repx", true);


                rd.ShowRibbonDesignerDialog();
            }
            catch
            {

                return;
            }
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                XtraReport rd = new XtraReport();

                rd = RptCustomersExport.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "RptCustomersExport.repx", true);


                rd.ShowRibbonDesignerDialog();
            }
            catch
            {

                return;
            }
        }
    }
}