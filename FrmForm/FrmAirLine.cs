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
    public partial class FrmAirLine : DevExpress.XtraEditors.XtraForm
    {
        ItemGoverControl accControl = new ItemGoverControl();

        public FrmAirLine()
        {
            InitializeComponent();
        }

        private void FrmTaxValue_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            timerLoad.Start();

        }

        async Task GetLoad()
        {
            GridView gridView1 = DgvRecords.MainView as GridView;

            airLineBindingSource.DataSource = await accControl.GetAllAirlines();//db.itemCategories.ToList();

            TxtName.Enabled = true;

            airLineBindingSource.Add(new AirLine());
            airLineBindingSource.MoveLast();
            TxtName.Focus();

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

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtName.Enabled = true;
            BtnSave.Enabled = true;
            BtnAdd.Enabled = false;
            airLineBindingSource.MoveLast();
            AirLine obj = airLineBindingSource.Current as AirLine;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    TxtName.Focus();
                }
                else
                {
                    airLineBindingSource.Add(new AirLine());
                    airLineBindingSource.MoveLast();
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
                AirLine obj = airLineBindingSource.Current as AirLine;
                if (obj != null)
                {
                    if (db.Entry<AirLine>(obj).State == EntityState.Detached)
                        db.Set<AirLine>().Attach(obj);
                    if (obj.Id == 0)
                    {
                        db.Entry<AirLine>(obj).State = EntityState.Added;
                        var rslt1 = await db.SaveChangesAsync();


                        if (rslt1 > 0)
                        {


                            if (SaveFormReport("tickt_" + obj.Id))
                            {

                            }
                            else
                            {
                                DesktopAlert.Show("لم يتم حفظ نموذج التيكت ! حاول مرة اخرى ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                BtnSave.Enabled = true;
                                BtnAdd.Enabled = false;
                                return;
                            }
                            DgvRecords.Refresh();
                            TxtName.Enabled = false;
                            airLineBindingSource.ResetBindings(false);
                            DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

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
                        db.Entry<AirLine>(obj).State = EntityState.Modified;
                        var rslt2 = await db.SaveChangesAsync();
                        if (rslt2 > 0)
                        {

                            if (!File.Exists(Application.StartupPath + @"\" + "tickt_" + obj.Id + ".repx"))
                            {
                                if (SaveFormReport("tickt_" + obj.Id))
                                {

                                }
                                else
                                {
                                    DesktopAlert.Show("لم يتم حفظ نموذج التيكت ! حاول مرة اخرى او قم بتعديل السجل ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                                    BtnSave.Enabled = true;
                                    BtnAdd.Enabled = false;
                                    return;
                                }
                            }

                            DgvRecords.Refresh();
                            TxtName.Enabled = false;
                            airLineBindingSource.ResetBindings(false);
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
            AirLine obj = airLineBindingSource.Current as AirLine;
            if (obj.Id == 0)
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


                    //AirLine obj = airLineBindingSource.Current as AirLine;
                    if (obj != null)
                    {
                        var myOrders = await accControl.GetSubOrderByAirlines(obj.Id);
                        if (myOrders.Count() > 0)
                        {
                            DesktopAlert.Show("لايمكن حذف  شركة الطيران ! يوجد طلبات مرتبطة ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                            return;
                        }


                        if (db.Entry<AirLine>(obj).State == EntityState.Detached)
                            db.Set<AirLine>().Attach(obj);
                        db.Entry<AirLine>(obj).State = EntityState.Deleted;
                        db.SaveChanges();

                        DeleteFilee("tickt_" + obj.Id);

                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        airLineBindingSource.RemoveCurrent();
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
                TxtCountries.Focus();
               
            }
        }

        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            AirLine obj = airLineBindingSource.Current as AirLine;
            if (obj != null)
            {
                TxtName.Enabled = true;
                BtnAdd.Enabled = true;
                BtnSave.Enabled = true;
            }
        }

        void DeleteFilee(string nameRpt)
        {
            //if (Directory.Exists(Application.StartupPath + @"\Tickets"))
            //{
                if (File.Exists(Application.StartupPath + @"\" + nameRpt + ".repx"))
                {
                    File.Delete(Application.StartupPath + @"\" + nameRpt + ".repx");
                }


            //}
        }
        bool SaveFormReport(string nameRpt)

        {
            //if (!Directory.Exists(Application.StartupPath + @"\Tickets"))
            //{
            //    Directory.CreateDirectory(Application.StartupPath + @"\Tickets");
            //}
            using (RptTicket rd = new RptTicket())
            {
                rd.Name = nameRpt ;
                rd.DisplayName = nameRpt ;
                rd.PaperName = nameRpt ;
               
                //rd.PrintingSystem.SaveDocument(Application.StartupPath + @"\Visas\" + nameRpt + ".prnx");// = nameRpt + ".repx";

                rd.SaveLayout(Application.StartupPath + @"\" + nameRpt + ".repx");

            }
            //.FromFile(System.Windows.Forms.Application.StartupPath + @"\" + "AccountExpensesReports.repx", true);

            if (File.Exists(Application.StartupPath + @"\" + nameRpt+ ".repx"))
            {
                return true;
            }
            else
            {
                return false;
            }



        }


        void ShowFormReportPrnx(string nameRpt)

        {
            if (!File.Exists(Application.StartupPath + @"\" + nameRpt + ".repx"))
            {
                DesktopAlert.Show("النموذج غير موجود ! يرجى تعديل السجل وحفظه من جديد");

                return;
            }

            DesktopAlert.Show("جاري فتح تصميم نموذج التذكرة...... يرجى الانتظار قليلا", eDesktopAlertColor.Orange, eAlertPosition.TopRight);


            //ReportDesignTool printTool = new ReportDesignTool(new XtraReport());

            //// Access the Print Tool's Printing System and load the report document.
            //if (System.IO.File.Exists(Application.StartupPath + @"\Visas\" + nameRpt + ".prnx"))
            //{

            //    //printTool.Report.PrintingSystem.LoadDocument(Application.StartupPath + @"\Visas\" + nameRpt + ".prnx");
            //    printTool.Report.LoadLayoutFromXml(Application.StartupPath + @"\Visas\" + nameRpt + ".prnx");
            //    //printTool.Report.LoadLayout(Application.StartupPath + @"\Visas\" + nameRpt + ".repx");
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
            AirLine obj = airLineBindingSource.Current as AirLine;
            if (obj != null)
            {
                if (obj.Id==0)
                {
                    return;
                }
                //ShowFormReport("visa_" + obj.Id);
                ShowFormReportPrnx("tickt_" + obj.Id);

                
                //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
            }
        }




        private void simpleButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void TxtCountries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (BtnSave.Enabled)
                {
                    BtnSave_Click(sender, e);
                }
            }
        }
    }
}