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
    public partial class FrmDestination : DevExpress.XtraEditors.XtraForm
    {
        ItemGoverControl accControl = new ItemGoverControl();

        public FrmDestination()
        {
            InitializeComponent();
        }

        private void FrmTaxValue_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            TxtName.Enabled = false;
            BtnSave.Enabled = false;
            timerLoad.Start();

        }

        async Task GetLoad()
        {
            GridView gridView1 = DgvRecords.MainView as GridView;

            destinationBindingSource.DataSource = await accControl.GetAllDestinations();//db.itemCategories.ToList();

            //TxtName.Enabled = true;


            destinationBindingSource.Add(new Destination());
            destinationBindingSource.MoveLast();
            BtnAdd.Focus();

        }
        private async void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
            await GetLoad();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                TxtName.Enabled = true;
                BtnAdd.Enabled = true;

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtName.Enabled = true;
            BtnSave.Enabled = true;
            BtnAdd.Enabled = false;
            destinationBindingSource.MoveLast();
            Destination obj = destinationBindingSource.Current as Destination;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    TxtName.Focus();
                }
                else
                {
                    destinationBindingSource.Add(new Destination());
                    destinationBindingSource.MoveLast();
                    TxtName.Focus();
                }
            }

        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }

            BtnSave.Enabled = false;

            using (MyDbContext db = new MyDbContext())
            {
                Destination obj = destinationBindingSource.Current as Destination;
                if (obj != null)
                {
                    if (db.Entry<Destination>(obj).State == EntityState.Detached)
                        db.Set<Destination>().Attach(obj);
                    if (obj.Id == 0)
                    {
                        db.Entry<Destination>(obj).State = EntityState.Added;
                        var rslt1 = await db.SaveChangesAsync();



                        if (rslt1 > 0)
                        {
                            if (SaveFormReport("visa_" + obj.Id))
                            {

                            }
                            else
                            {
                                DesktopAlert.Show("لم يتم حفظ نموذج الفيزا ! حاول مرة اخرى او قم بتعديل السجل ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                BtnSave.Enabled = true;
                                BtnAdd.Enabled = false;
                                return;
                            }
                            DgvRecords.Refresh();
                            TxtName.Enabled = false;
                            destinationBindingSource.ResetBindings(false);
                            DesktopAlert.Show(" تمت الاضافة بنجاح !  " + "visa_" + obj.Id + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                            TxtName.Enabled = false;
                            BtnAdd_Click(sender, e);
                        }
                        else
                        {
                            BtnSave.Enabled = true;
                            BtnAdd.Enabled = false;
                        }

                    }

                    else
                    {
                        db.Entry<Destination>(obj).State = EntityState.Modified;
                        var rslt2 =await db.SaveChangesAsync();



                        if (rslt2 > 0)
                        {
                            if (!File.Exists(Application.StartupPath + @"\" + "visa_" + obj.Id + ".repx"))
                            {
                                if (SaveFormReport("visa_" + obj.Id))
                                {

                                }
                                else
                                {
                                    DesktopAlert.Show("لم يتم حفظ نموذج الفيزا ! حاول مرة اخرى او قم بتعديل السجل ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                    BtnSave.Enabled = true;
                                    BtnAdd.Enabled = false;
                                    return;
                                }
                            }

                            DgvRecords.Refresh();
                            TxtName.Enabled = false;
                            destinationBindingSource.ResetBindings(false);
                            DesktopAlert.Show("تم التعديل بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                            BtnAdd.Enabled = true;
                            TxtName.Enabled = false;
                            //BtnAdd_Click(sender, e);
                        }
                        else
                        {
                            BtnSave.Enabled = true;
                            BtnAdd.Enabled = false;
                        }

                    }
                    //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");


                }
            }
        }
        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(TxtName.Text))
            //{

            //    return;
            //}
            if (gridView1.RowCount <= 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            Destination obj = destinationBindingSource.Current as Destination;
            if (obj.Id==0)
            {
                return;
            }

                DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = "Confirm   تأكيد ", Description = "  Delete this Record ? | تاكيد حذف السجل ؟" };

            Predicate<DialogResult> predicate = canCloseFunc;
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Yes نعم", Result = System.Windows.Forms.DialogResult.Yes };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "No لا", Result = System.Windows.Forms.DialogResult.No };

            action.Commands.Add(command1);
            action.Commands.Add(command2); FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;
            if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this, action, properties, predicate) == System.Windows.Forms.DialogResult.Yes)
            {
                using (MyDbContext db = new MyDbContext())
                {
                   

                    if (obj != null)
                    {
                        var myOrders = await accControl.GetSubOrders(obj.Id);
                        if (myOrders.Count() > 0)
                        {
                            DesktopAlert.Show("لايمكن حذف هذه الدولة ! يوجد طلبات مرتبطة ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                            return;
                        }

                        if (db.Entry<Destination>(obj).State == EntityState.Detached)
                            db.Set<Destination>().Attach(obj);
                        db.Entry<Destination>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        DeleteFilee("visa_" + obj.Id);
                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        destinationBindingSource.RemoveCurrent();
                        TxtName.Enabled = false;
                        BtnAdd_Click(sender, e);

                    }
                }

            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();

        }



        private void TxtValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (BtnSave.Enabled)
                {
                    BtnSave_Click(sender, e);
                }
            }
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (BtnSave.Enabled)
                {
                    BtnSave_Click(sender, e);
                }
            }
        }

        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            Destination obj = destinationBindingSource.Current as Destination;
            if (obj != null)
            {
                TxtName.Enabled = true;
                BtnAdd.Enabled = true;
                BtnSave.Enabled = true;

                //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
            }
        }


        void DeleteFilee(string nameRpt)
        {
            //if (Directory.Exists(Application.StartupPath + @""))
            //{
                if (File.Exists(Application.StartupPath + @"\" + nameRpt + ".repx"))
                {
                    File.Delete(Application.StartupPath + @"\" + nameRpt + ".repx");
                }


            //}
        }

        bool SaveFormReport(string nameRpt)

        {
            //if (!Directory.Exists(Application.StartupPath + @""))
            //{
            //    Directory.CreateDirectory(Application.StartupPath + @"");
            //}


            //XtraReport report = new XtraReport()
            //{
            //    Name = "SimpleStaticReport",
            //    DisplayName = "Simple Static Report",
            //    PaperKind = PaperKind.Letter,
            //    Margins = new DXMargins(100, 100, 100, 100)
            //};

            using (RptVisa rd = new RptVisa())
            {
                rd.Name = nameRpt;// + ".repx";
                rd.DisplayName = nameRpt;// + ".repx";
                rd.PaperName = nameRpt;// + ".repx";

                ////rd.PrintingSystem.SaveDocument(Application.StartupPath + @"\" + nameRpt + ".prnx");// = nameRpt + ".repx";

                rd.SaveLayout(Application.StartupPath + @"\" + nameRpt + ".repx");

            }

            if (File.Exists(Application.StartupPath + @"\" + nameRpt+ ".repx"))
            {
                return true;
            }
            else
            {
                return false;
            }



        }


        void ShowFormReport(string nameRpt)

        {
            if (!File.Exists(Application.StartupPath + @"\" + nameRpt + ".repx"))
            {
                DesktopAlert.Show("النموذج غير موجود ! يرجى تعديل السجل وحفظه من جديد");

                return;
            }
            using (XtraReport rd =  RptVisa.FromFile(Application.StartupPath + @"\" + nameRpt + ".repx", true))
            {



                using (ReportDesignTool designTool = new ReportDesignTool(rd))
                {
                    rd.Name = nameRpt + ".repx";
                    rd.DisplayName = nameRpt + ".repx";
                    //rd.LoadLayout(Application.StartupPath + @"\" + nameRpt + ".repx");
                    rd.Name = nameRpt + ".repx";
                    rd.DisplayName = nameRpt + ".repx";

                    MessageBox.Show(rd.Name);
                    rd.Name = nameRpt + ".repx";
                    rd.DisplayName = nameRpt + ".repx";
                    rd.PaperName = nameRpt + ".repx";
                    MessageBox.Show(rd.Name);
                    MessageBox.Show(rd.DisplayName);
                    //designTool.Report.na
                    designTool.ShowRibbonDesignerDialog();





                }
            }

           



        }
        void ShowFormReportPrnx(string nameRpt)

        {
            if (!File.Exists(Application.StartupPath + @"\" + nameRpt + ".repx"))
            {
                DesktopAlert.Show("النموذج غير موجود ! يرجى تعديل السجل وحفظه من جديد");

                return;
            }
            DesktopAlert.Show("جاري فتح تصميم نموذج التأشيرة...... يرجى الانتظار قليلا", eDesktopAlertColor.Orange, eAlertPosition.TopRight);



            //ReportDesignTool printTool = new ReportDesignTool(new XtraReport());

            //// Access the Print Tool's Printing System and load the report document.
            //if (System.IO.File.Exists(Application.StartupPath + @"\" + nameRpt + ".prnx"))
            //{

            //    //printTool.Report.PrintingSystem.LoadDocument(Application.StartupPath + @"\" + nameRpt + ".prnx");
            //    printTool.Report.LoadLayoutFromXml(Application.StartupPath + @"\" + nameRpt + ".prnx");
            //    //printTool.Report.LoadLayout(Application.StartupPath + @"\" + nameRpt + ".repx");
            //}
            //else
            //{
            //    System.Console.WriteLine("The source file does not exist.");
            //}
            //printTool.ShowDesignerDialog();



            using (XtraReport rd = XtraReport.FromFile(Application.StartupPath + @"\" + nameRpt + ".repx", true))
            {



                using (ReportDesignTool designTool = new ReportDesignTool(rd))
                {
                    rd.Name = nameRpt;
                    rd.DisplayName = nameRpt;
                    //rd.LoadLayout(Application.StartupPath + @"\" + nameRpt);
                  
                    //designTool.Report.Site.Name = nameRpt;
                    
                    //MessageBox.Show(rd.Name);
                 
                    rd.PaperName = nameRpt;
                    designTool.Report.Name = nameRpt;
                    designTool.Report.DisplayName = nameRpt;
                    designTool.Report.PaperName = nameRpt;
                  
                    //designTool.Report.na
                    designTool.ShowRibbonDesignerDialog();





                }
            }





        }

        private void BtnView_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            Destination obj = destinationBindingSource.Current as Destination;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    return;
                }
                //ShowFormReport("visa_" + obj.Id);
                ShowFormReportPrnx("visa_" + obj.Id);

                
                //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\" + "visa_2" + ".repx"))
            {
                DesktopAlert.Show("النموذج غير موجود ! يرجى تعديل السجل وحفظه من جديد");

                return;
            }
            using (XtraReport rd = RptVisa.FromFile(Application.StartupPath + @"\" + "visa_2" + ".repx", true))
            {
                rd.SaveLayout(Application.StartupPath + @"\" + "visa_2" + ".repx");



                using (ReportDesignTool designTool = new ReportDesignTool(rd))
                {


                    designTool.ShowDesigner();




                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\" + "visa_2" + ".repx"))
            {
                DesktopAlert.Show("النموذج غير موجود ! يرجى تعديل السجل وحفظه من جديد");

                return;
            }
            using (XtraReport rd = RptVisa.FromFile(Application.StartupPath + @"\" + "visa_2" + ".repx", true))
            {
                rd.SaveLayout(Application.StartupPath + @"\" + "visa_2" + ".repx");



                using (ReportDesignTool designTool = new ReportDesignTool(rd))
                {


                    designTool.ShowDesignerDialog();




                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\" + "visa_0" + ".repx"))
            {
                DesktopAlert.Show("النموذج غير موجود ! يرجى تعديل السجل وحفظه من جديد");

                return;
            }
            using (XtraReport rd = XtraReport.FromFile(Application.StartupPath + @"\" + "visa_0" + ".repx", true))
            {
                //rd.SaveLayout(Application.StartupPath + @"\" + "visa_2" + ".repx");



                using (ReportDesignTool designTool = new ReportDesignTool(rd))
                {

                    rd.DisplayName = "visa_0" + ".repx";
                    rd.Name = "visa_0" + ".repx";

                    designTool.Report.DisplayName = "visa_0" + ".repx";
                    designTool.Report.Name = "visa_0" + ".repx";
                    designTool.Report.SaveLayout("visa_0" + ".repx");

                    designTool.ShowRibbonDesignerDialog();



                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\" + "visa_0" + ".repx"))
            {
                DesktopAlert.Show("النموذج غير موجود ! يرجى تعديل السجل وحفظه من جديد");

                return;
            }
            using (XtraReport rd = XtraReport.FromFile(Application.StartupPath + @"\" + "visa_0" + ".repx", true))
            {
                //rd.SaveLayout(Application.StartupPath + @"\" + "visa_2" + ".repx");



                using (ReportDesignTool designTool = new ReportDesignTool(rd))
                {

                    rd.DisplayName = "visa_0" + ".repx";
                    rd.Name = "visa_0" + ".repx";

                    designTool.Report.DisplayName =  "visa_0" + ".repx";
                    designTool.Report.Name ="visa_0" + ".repx";
                    //designTool.Report.SaveLayout("visa_2" + ".repx");

                    designTool.ShowRibbonDesignerDialog();



                }
            }
        }
    }
}