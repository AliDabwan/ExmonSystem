using DevExpress.XtraBars;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using ExmonSystem.Setting;
using ExmonSystem.Controls;
using System.Threading.Tasks;
using DevComponents.DotNetBar.Controls;
using DevExpress.XtraSplashScreen;
using System.Drawing;
using ExmonSystem.FrmForm;
using ExmonSystem.Acc;
using ExmonSystem.Sale;
using DevExpress.LookAndFeel;
using System.IO;
using ExmonSystem.Models;
using ExmonSystem.Form;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraReports.UI;
using ExmonSystem.RPT;

namespace ExmonSystem
{

    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Helper helper = new Helper();
        CompanyControl company = new CompanyControl();
        AccountControl accountControl = new AccountControl();

        //public static void OpenFromByName(string name)
        //{
        //    var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
        //    if (ins != null)
        //    {
        //        var frm = Activator.CreateInstance(ins) as DevExpress.XtraBars.Ribbon.RibbonForm;
        //        if (Application.OpenForms[frm.Name] != null)
        //        {
        //            frm = Application.OpenForms[frm.Name];
        //        }
        //        else
        //        {
        //            frm.Show();
        //        }
        //        frm.BringToFront();
        //    }
        //}
        public MainMenu()
        {

            InitializeComponent();
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default["ApplicationSkinName"].ToString();


        }


        IEnumerable<BillsProfitTaxDTO> billList = new List<BillsProfitTaxDTO>();

        async Task GetLoad()
        {
            var typee = "sales";
          
                typee = "sales";

            int showCount = 0;

            if (Properties.Settings.Default.Language == "ar")
            {
                if (showCount == 0)
                {
                    chartControl1.Legend.Title.Text = "افضل " + "" + " المبيعات ";
                }
                else
                {
                    chartControl1.Legend.Title.Text = "افضل " + showCount + " مبيعات ";

                }

            }
           
           



            //string billorder = "";
            //if (CheckLocal.Checked)
            //{
            //    billorder = "محلي Local";

            //}
            //else if (CheckExternal.Checked)
            //{
            //    billorder = "خارجي External";


            //}
            //else if (CheckDelivery.Checked)
            //{
            //    billorder = "توصيل Delivery";

            //}
            //else
            //{
            //    billorder = "";
            //}




                billList = await accountControl.GetBillsAnalysis_Net(false, showCount, TxtDateFrom.DateTime.Date, TxtDateTo.DateTime.Date);//db.itemCategories.ToList();

           
            billsProfitTaxDTOBindingSource.DataSource = billList;

            chartControl1.DataSource = billList;


            gridView1.UpdateSummary();


            //await calcSums(billList);



            //   await calcSums();

        }


        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.VersonNo = Program.appNewVersionNo;
            Properties.Settings.Default.Save();

            timerCheckUpdate.Start();


            if (File.Exists(Application.StartupPath + @"\updateDone.txt"))
            {
                await Task.Run(() => GoogleDriveFilesRepository.ReadSeriallAndUpdateVersonNo());

            }
            HeaderVersion.Caption = "V." + Properties.Settings.Default.VersonNo.ToString();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);


            var mycompany = await company.GetCompany();
            Program.myCompany = mycompany;

            var frm = new FrmLogin();
            frm.ShowDialog();








            if (Program.isSuccessfullogin == false)
            {
                ShowLogin();
                return;
            }

            if (Program.myCompany == null)
            {
                FrmStrat ss = new FrmStrat();
                ss.ShowDialog();

            }
            if (!Properties.Settings.Default.IsInitialize)
            {
                var stf = new FrmStrat();
                stf.ShowDialog();
            }
            UserLoginLabel.Refresh();

            if (Properties.Settings.Default.Language == "ar")
            {
                UserLoginLabel.Caption = "مرحبا : " + Program.userFullName;
                //isChanged = true;
                lblLanguage.Caption = "English";
            }
            else
            {
                UserLoginLabel.Caption = "wilcome: " + Program.userFullName;
                lblLanguage.Caption = "عربي";


            }

            timer1.Start();
            timerBck.Start();

            timer2.Start();
            await getMyRoll();

            if (ProdllClass.PwdDecre(Properties.Settings.Default.Propfree) == "true")
            {
                HeaderActivat.Visibility = BarItemVisibility.Always;
            }
            else
            {
                HeaderActivat.Visibility = BarItemVisibility.Never;

            }
            HeaderVersion.Caption = "V." + Properties.Settings.Default.VersonNo.ToString();

            if (Program.myCompany.UseResurantMode)
            {

                Properties.Settings.Default.AllowPrescription = false;
                Properties.Settings.Default.Save();


                if (Properties.Settings.Default.Language == "ar")
                {
                    barButPCat.Caption = "الاقسام";
                }
                else
                {
                    barButPCat.Caption = "Sections";

                }
            }
            BarTorism.Visibility = BarItemVisibility.Always;

            radioGroup1.SelectedIndex = 0;
            radioGroup1.SelectedIndex = 3;
            await GetLoad();

        }


        // void CheckUpdate()
        //{

        //    GoogleDriveFilesRepository.dooo();
        //}
        async Task GetValues()
        {
            //var Items= await ;
          
            int s = 0;
            int p = 0;
            int c = 0;
            int v = 0;

            ShowWaitForm();

            //for (int i = 0; i < await itemProductsControl.GetAllItemProducts().Result.Count(); i++)
            //{

            //}


            try
            {

                //foreach (var item in await accountControl.GetParcelForOut())
                //{
                //labParcelAll.Text = s.ToString(SD.NumDec);
                //}
            }
            catch
            {
                //labParcelAll.Text = "0";


            }



            try
            {
                //labParcelIn.Text = p.ToString(SD.NumDec);

            }
            catch
            {
                //labParcelIn.Text = "0";


            }
            try
            {

                c = await accountControl.GetSendersCount();
                //labMainCustomers.Text = c.ToString(SD.NumDec);

            }
            catch
            {
                //labMainCustomers.Text = "0";


            }
            try
            {

                v = await accountControl.GetVendorsCount();
                //labMainSuppliers.Text = v.ToString(SD.NumDec);


            }
            catch
            {
                //labMainSuppliers.Text = "0";

            }

            CloseWaitForm();

        }

        private void barButPunits_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButPCat_ItemClick(object sender, ItemClickEventArgs e)
        {
            

        }

        private void barButPItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var frm = new Acc.FrmCustomersList();
            //frm.formType = "Suplier";
            //frm.mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;

            //frm.Show();
            var frm = new FrmDriver();
            frm.ShowDialog();

        }

        private async void barButStar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmStrat();
            frm.ShowDialog();
            var mycomp = await company.GetCompany();
            Program.myCompany = mycomp;
        }

        private void barButCashAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var frm = new Form.FrmCashAccounts();
            var frm = new Acc.FrmPaymentTypesList();
            frm.formType = "Cash";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountCashes == 0 ? 101 : Properties.Settings.Default.PropMainAccountCashes;

            frm.Show();
        }

        private void barButCustAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Acc.FrmCustomersList();
            frm.formType = "Suplier";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;

            frm.Show();
        }

        private void barButVendorAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Acc.FrmCustomersList(); 
            frm.formType = "Customer";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountCustomers == 0 ? 102 : Properties.Settings.Default.PropMainAccountCustomers;

            frm.Show();
        }

        private void barButPayments_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Form.FrmPayments();
            frm.formType = "Payment";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;

            frm.Show();
        }

        private void barButReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Form.FrmPayments();
            frm.formType = "Receipt";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountCustomers == 0 ? 102 : Properties.Settings.Default.PropMainAccountCustomers;

            frm.Show();
        }

        private void barButExpenses_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Acc.FrmCustomersList();
            frm.formType = "Expens";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;

            frm.Show();
            //var frm = new Form.FrmCashAccounts();
            //frm.formType = "Expens";
            //frm.mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;
            //frm.Show();
        }

        async void ShowLogin()
        {
            var frm = new FrmLogin();
            frm.ShowDialog();
            if (Program.isSuccessfullogin == false)
            {
                ShowLogin();
                return;
            }
            UserLoginLabel.Refresh();
            if (Properties.Settings.Default.Language == "ar")
            {
                UserLoginLabel.Caption = "مرحبا : " + Program.userFullName;

                BarLanguageSwitch.Checked = false;
            }
            else
            {
                UserLoginLabel.Caption = "wilcome: " + Program.userFullName;

                BarLanguageSwitch.Checked = true;

            }
            timer1.Start();


            timer2.Start();
            await getMyRoll();
        }
        private async void barButExt_ItemClick(object sender, ItemClickEventArgs e)
        {


            var frm = new FrmLogin();
            frm.ShowDialog();
            if (Program.isSuccessfullogin == false)
            {
                ShowLogin();
                return;
            }
            UserLoginLabel.Refresh();
            if (Properties.Settings.Default.Language == "ar")
            {
                UserLoginLabel.Caption = "مرحبا : " + Program.userFullName;

                BarLanguageSwitch.Checked = false;
            }
            else
            {
                UserLoginLabel.Caption = "wilcome: " + Program.userFullName;

                BarLanguageSwitch.Checked = true;

            }
            timer1.Start();


            timer2.Start();
            await getMyRoll();


        }

        private void barButSaleInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnFromVendorToStore_Click(sender, e);
        }

        private void barButSaleReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barButSaleQuotation_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void butMainPurchase_Click(object sender, EventArgs e)
        {
           
        }

        private void barButSaleReports_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barStockAdjustment_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButQAddProducts_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButTaxReports_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

      

        private void barButProductsReports_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButUserSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Setting.FrmUserSetting();
            frm.ShowDialog();
            getMyRoll();

        }

        private void barButCustomerReports_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButSuppliersReports_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButPrintBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButPOSTouch_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void barButLocked_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButSQLConn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmSQLConn();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void barButTaxValue_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void BarButtonSettings_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BarLanguageSwitch_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void ShowWaitForm()
        {
            Point waitFormLocation = GetWaitFormLocation();
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, SplashFormStartPosition.CenterScreen, waitFormLocation);
        }

        private Point GetWaitFormLocation()
        {
            var waitFormSize = GetWaitFormSize();
            //var waitFormLocation = new System.Drawing.Point(butMainSale.Right - butMainSale.Width / 2 - waitFormSize.Width / 2, butMainSale.Bottom - butMainSale.Height / 2 - waitFormSize.Height / 2);
            var waitFormLocation = panelFixedLocation.Location;

            return PointToScreen(waitFormLocation);
        }

        private static void CloseWaitForm()
        {
            SplashScreenManager.CloseForm();
        }

        private static Size GetWaitFormSize()
        {
            var waitForm1 = new WaitForm1();
            var size = waitForm1.Size;
            waitForm1.Dispose();
            return size;
        }
        private void flyoutPanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            await GetValues();
        }

        private void UserLoginLabel_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //   Application.Exit();
            this.Dispose();
        }

        private void barButExpenses_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var frm = new Form.FrmPayments();
            frm.formType = "Expens";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmVouchersList();
            frm.formType = "Payment";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmVouchersList();
            frm.formType = "Receipt";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountCustomers == 0 ? 102 : Properties.Settings.Default.PropMainAccountCustomers;

            frm.Show();

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmVouchersList();
            frm.formType = "Expens";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;

            frm.Show();
        }

        private async void butMainSale_Click(object sender, EventArgs e)
        {
            //if (Program.myCompany == null)
            //{
            //    DesktopAlert.Show("يجب تسجيل بيانات المنشأة " + "\n" + " Please Register Your Compapny Detauls", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
            //    FrmStrat ss = new FrmStrat();
            //    ss.ShowDialog();
            //    return;

            //}





        }

        private async void butMainSRutern_Click(object sender, EventArgs e)
        {




        }

        private void butMainPReturn_Click(object sender, EventArgs e)
        {
          
        }

        private void butMainDailyS_Click(object sender, EventArgs e)
        {
           ;
        }

        private void ButMainReceipt_Click(object sender, EventArgs e)
        {

            var frm = new Form.FrmPayments();
            frm.formType = "Receipt";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountCustomers == 0 ? 102 : Properties.Settings.Default.PropMainAccountCustomers;

            frm.Show();
        }

        private void ButMainPayment_Click(object sender, EventArgs e)
        {
            var frm = new Form.FrmPayments();
            frm.formType = "Expens";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;
            frm.Show();
        }

        private void butMainCustomer_Click(object sender, EventArgs e)
        {
            var frm = new Form.FrmCustomerAcc();
            frm.formType = "Suplier";//: "Suplier";
            frm.Id = 0;
            frm.mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;

            frm.ShowDialog();
        }

        private void butMainSuppliers_Click(object sender, EventArgs e)
        {
            var frm = new Form.FrmCustomerAcc();
            frm.formType = "Customer";//: "Customer";
            frm.Id = 0;
            frm.mAccountId = Properties.Settings.Default.PropMainAccountCustomers == 0 ? 10 : Properties.Settings.Default.PropMainAccountCustomers;
            frm.ShowDialog();
        }

        private void butMainPurchaesReports_Click(object sender, EventArgs e)
        {
          
        }

        private void barButPurchaseInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            butMainPurchase_Click(sender, e);
        }

        private void barButPurchaseReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            butMainPReturn_Click(sender, e);

        }

        private void barButPurchaseReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButExpiredProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButCashAccountReports_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButProfitLossReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            //FrmStoreProfits pp = new FrmStoreProfits();
            //pp.ShowDialog();



            var myr = new FrmOrdersRpt();
            myr.formType = "Profit";
            myr.Show();
        }

        private async void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.PropAutoBackupinClose)
                {
                    await Task.Run(() => helper.DoBackup());
                }
                GC.Collect();
                System.Windows.Forms.Application.Exit();



            }
            catch
            {
                GC.Collect();

                System.Windows.Forms.Application.Exit();



            }


        }

        async Task getMyRoll()
        {
            RollsControl control = new RollsControl();


            var myRoll = await control.getMyRoll(Program.userGroupId);

            if (Program.userGroupName != "Manager" && Program.userGroupName != "Support")
            {
                barButTaxValue.Enabled = false;
            }

            if (myRoll == null)
            {
                //PnlHome.Enabled = false;
                //ribbonProducts.Enabled =  false;
                return;
            }
            if (!myRoll.Any())
            {
                //PnlHome.Enabled = false;
                //ribbonProducts.Enabled = false;
                //ribbonAcu.Enabled = false;
                //ribbonSale.Enabled = false;
                //ribbon.Enabled = false;
                return;
            }
            PnlHome.Enabled = true;

            SetDisbled();

            foreach (var item in myRoll)
            {
                if (item.RollTitle == "اعدادات البرنامج")
                {
                    if (item.IsChecked == "True")
                    {
                        barButStar.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }
                if (item.RollTitle == "المستخدمين")
                {
                    if (item.IsChecked == "True")
                    {
                        barButUserSettings.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }
                if (item.RollTitle == "الاستيراد")
                {
                    if (item.IsChecked == "True")
                    {
                        barButImportProducts.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }




                if (item.RollTitle == "البيانات الاساسية")
                {
                    if (item.IsChecked == "True")
                    {
                        ribbonProducts.Enabled = Convert.ToBoolean(item.IsChecked);
                        BarTorism.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }

                if (item.RollTitle == "ادارة الزبائن")
                {
                    if (item.IsChecked == "True")
                    {
                        BarTorism.Enabled = Convert.ToBoolean(item.IsChecked);

                        BtnCustomers.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }


                if (item.RollTitle == "دول الوجهات")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnContry.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }

                
                if (item.RollTitle == "شركات الطيران")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnAirLines.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }    
                if (item.RollTitle == "ادارة شركات الصرافة")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnExchangeCompany.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }

                 if (item.RollTitle == "حسابات الشركات")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnCompanyAccounts.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }



                     if (item.RollTitle == "الاشتراكات")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnMemberShips.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }
                     if (item.RollTitle == "اضافة طلب")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnOrderAdd.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }
                if (item.RollTitle == "طباعة طلب")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnOrderPrint.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }
                 if (item.RollTitle == "الطلبات")
                {
                    if (item.IsChecked == "True")
                    {
                        BtnOrderView.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }






                if (item.RollTitle == "سند قبض")
                {
                    if (item.IsChecked == "True")
                    {
                        barButReceipt.Enabled = Convert.ToBoolean(item.IsChecked);
                        barButtonItem6.Enabled = Convert.ToBoolean(item.IsChecked);

                    }
                }

                
                if (item.RollTitle == "سند مصروف")
                {
                    if (item.IsChecked == "True")
                    {
                        barButExpenses.Enabled = Convert.ToBoolean(item.IsChecked);
                        barbtnExp.Enabled = Convert.ToBoolean(item.IsChecked);

                    }
                }





              
                if (item.RollTitle == "تقارير المبيعات")
                {
                    if (item.IsChecked == "True")
                    {
                        barButSaleReports.Enabled = Convert.ToBoolean(item.IsChecked);

                    }
                } 
                
              


                if (item.RollTitle == "حسابات المصروفات")
                {
                    if (item.IsChecked == "True")
                    {
                        barButExpensesAccount.Enabled = Convert.ToBoolean(item.IsChecked);
                        barbtnExp.Enabled = Convert.ToBoolean(item.IsChecked);
                        barButExpenses.Enabled = Convert.ToBoolean(item.IsChecked);
                     
                    }
                }

                //if (item.RollTitle == "المرسلين")
                //{
                //    if (item.IsChecked == "True")
                //    {
                //        barButCustAcc.Enabled = Convert.ToBoolean(item.IsChecked);
                //        barButCustomerReports.Enabled = Convert.ToBoolean(item.IsChecked);
                //        barButPItems.Enabled = Convert.ToBoolean(item.IsChecked);


                //    }
                //}
                //if (item.RollTitle == "المندوبين")
                //{
                //    if (item.IsChecked == "True")
                //    {
                //        barButVendorAcc.Enabled = Convert.ToBoolean(item.IsChecked);
                //        barButSuppliersReports.Enabled = Convert.ToBoolean(item.IsChecked);
                //        barButQickAddItems.Enabled = Convert.ToBoolean(item.IsChecked);

                //    }
                //}

                if (item.RollTitle == "ترحيل الحسابات النقدية")
                {
                    if (item.IsChecked == "True")
                    {
                        btnCloseAccount.Enabled = Convert.ToBoolean(item.IsChecked);

                    }
                }


             


            }

            timerRoll.Start();



        }

        void SetDisbled()
        {

            barButStar.Enabled = false;

            barButUserSettings.Enabled = false;

            barButImportProducts.Enabled = false;
            ribbonProducts.Enabled = false;
            BtnCustomers.Enabled = false;
            BtnContry.Enabled = false;
            BtnAirLines.Enabled = false;
            BtnCompanyAccounts.Enabled = false;
            BtnMemberShips.Enabled = false;
            BtnOrderAdd.Enabled = false;
            BtnOrderView.Enabled = false;
            BtnOrderPrint.Enabled = false;

          
            BtnExchangeCompany.Enabled = false;

            barButPunits.Enabled = false;

            barButPCat.Enabled = false;

            barStockAdjustment.Enabled = false;


            barButReceipt.Enabled = false;
            barButtonItem6.Enabled = false;


            barButPayments.Enabled = false;
            barButtonItem5.Enabled = false;


            barButPOSDown.Enabled = false;
            barButPOSTouch.Enabled = false;

            BtnNoteDebit.Enabled = false;
            BtnNoteCredit.Enabled = false;
            BtnCreditNoteReport.Enabled = false;
            BtnDebitNoteReport.Enabled = false;



            BtnContry.Enabled = false;
            BtnCustomers.Enabled = false;
            //barButSaleInvoice.Enabled = false;

            //barButSaleReturn.Enabled = false;


            barButPurchaseReturn.Enabled = false;

            barButSaleReports.Enabled = false;


            barButPurchaseInvoice.Enabled = false;


            barButTaxReports.Enabled = false;
            //barButTax2Reports.vis =false;

            barButProfitLossReport.Enabled = false;
            BtnEndDay.Enabled = false;

            barButCashAcc.Enabled = false;
            barButCashAccountReports.Enabled = false;
            barButtonItem10.Enabled = false;


            barButExpensesAccount.Enabled = false;
            barbtnExp.Enabled = false;
            barButExpenses.Enabled = false;

            barButCustAcc.Enabled = false;
            barButCustomerReports.Enabled = false;


            barButVendorAcc.Enabled = false;
            barButSuppliersReports.Enabled = false;


            btnCloseAccount.Enabled = false;


            barButCashAcc.Enabled = false;
            barButCashAccountReports.Enabled = false;
            barButtonItem10.Enabled = false;



            barButExpensesAccount.Enabled = false;
            barbtnExp.Enabled = false;
            barButExpenses.Enabled = false;


            barButProductsReports.Enabled = false;

            barButExpiredProducts.Enabled = false;

            barButPrintBarcode.Enabled = false;

            barButSaleReports.Enabled = false;


            barButPurchaseInvoice.Enabled = false;

            barButPurchaseReports.Enabled = false;

            BarTorism.Enabled = false;


        }
        private void BarLanguageSwitch_ItemPress(object sender, ItemClickEventArgs e)
        {

        }

        private void barButQickAddItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var frm = new Acc.FrmCustomersList();
            //frm.formType = "Customer";
            //frm.mAccountId = Properties.Settings.Default.PropMainAccountCustomers == 0 ? 102 : Properties.Settings.Default.PropMainAccountCustomers;

            //frm.Show();

            var frm = new Acc.FrmCompanyTorism();

            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            butMainSale_Click(sender, e);
        }

        private void barButSupplierDebtReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Acc.FrmCustomersDebits();
            frm.formType = "Suplier";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;

            frm.Show();
        }

        private void barButUserProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmProfile();

            frm.ShowDialog();
        }

        private void HeaderActivat_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private async  void BtnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GoogleDriveFilesRepository.checkInternet())
            {
                DesktopAlert.Show("لايوجد اتصال انترنت للتحقق من التحديثات " + "\n" + "No Internet Connection ");
                return;
            }
            await helper.AddGigalog("Update", "Check", "Version: " + Properties.Settings.Default.VersonNo, "", "");
            await Task.Run(() => helper.DoBackupSilent());

            // var rr = new FrmCheckUpdate();
            //rr.ShowDialog();
            try
            {
                if (File.Exists(@".\Updator.exe"))
                {
                    System.Diagnostics.Process.Start(@".\Updator.exe");

                }
                else
                {
                    System.Diagnostics.Process.Start(@".\Updater.exe");

                }
                Application.Exit();

            }
            catch
            {

                return;
            }
        }

        private void barSubHelp_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new Form.FrmAccountsClose();
            frm.formType = "DailEntry";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountCashes == 0 ? 101 : Properties.Settings.Default.PropMainAccountCashes;

            frm.ShowDialog();
        }
        bool isChanged = false;

        private void BarLanguageSwitch_CheckedChanged(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FrmAccountClosinglist();
            frm.Accounttype = 0;
            frm.accountId = Program.userCashAccountId == 0 ? Properties.Settings.Default.PropBAccountCash : Program.userCashAccountId;

            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "ar")
            {
                CultureInfo cut = new CultureInfo("EN");
                //cut.DateTimeFormat.Calendar = new GregorianCalendar();
                Thread.CurrentThread.CurrentCulture = cut;
                Thread.CurrentThread.CurrentUICulture = cut;

                // MessageBox.Show(Thread.CurrentThread.CurrentUICulture.ToString());
                Properties.Settings.Default.Language = "EN";
                Properties.Settings.Default.Save();
            }
            else
            {
                CultureInfo cut = new CultureInfo("AR");
                //cut.DateTimeFormat.Calendar = new GregorianCalendar();
                Thread.CurrentThread.CurrentCulture = cut;
                Thread.CurrentThread.CurrentUICulture = cut;

                // MessageBox.Show(Thread.CurrentThread.CurrentUICulture.ToString());
                Properties.Settings.Default.Language = "AR";
                Properties.Settings.Default.Save();
            }

            DesktopAlert.Show(" LANG= " + Properties.Settings.Default.Language + "  ------    " + Thread.CurrentThread.CurrentCulture.Name);

            var MEN = new MainMenu();
            MEN.ShowDialog();
        }

        private void BarLanguageSwitch_CheckedChanged_1(object sender, ItemClickEventArgs e)
        {


        }

        private void lblLanguage_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Properties.Settings.Default.Language == "EN")
            {
                if (helper.ShowMessageConfirm(this, "Application Language", "Are you sure , Change Application Language to Arabic ? " + "\n" + "Application will be closed to apply the new changes"))
                {
                    CultureInfo cut = new CultureInfo("ar");
                    //cut.DateTimeFormat.Calendar = new GregorianCalendar();
                    Thread.CurrentThread.CurrentCulture = cut;
                    Thread.CurrentThread.CurrentUICulture = cut;

                    // MessageBox.Show(Thread.CurrentThread.CurrentUICulture.ToString());
                    Properties.Settings.Default.Language = "ar";
                    Properties.Settings.Default.Save();
                    Close();

                }

            }
            else if (Properties.Settings.Default.Language == "ar")

            {
                if (helper.ShowMessageConfirm(this, "لغة البرنامج", "هل بالتأكيد تريد تغيير اللغة إلى اللغة الإنجليزية ؟ "
                    + "\n" + "سيتم إغلاق البرنامج لتطبيق التغييرات"))
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    //  MessageBox.Show(Thread.CurrentThread.CurrentUICulture.ToString());
                    Properties.Settings.Default.Language = "EN";
                    Properties.Settings.Default.Save();
                    Close();


                }

            }
        }

        private async void timerRoll_Tick(object sender, EventArgs e)
        {
            timerRoll.Stop();
            await getMyRoll();

        }

        private  void BtnEndDay_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnNoteCredit_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem2_ItemClick_2(object sender, ItemClickEventArgs e)
        {
        
        }

        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           
        }

        private void BtnNoteDebit_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinDropBT_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnNoteCreditRe_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void BtnNoteDebitRe_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButTax2Reports_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private async void timerBck_Tick(object sender, EventArgs e)
        {
            timerBck.Stop();
            await Task.Run(() => helper.DoBackupSilent());
            timerBck.Interval = 10800000;
            timerBck.Start();

        }

        private async void timerCheckUpdate_Tick(object sender, EventArgs e)
        {
            timerCheckUpdate.Stop();

            int mydbVersion = helper.GetVersionInfo();


            if (mydbVersion > Program.appNewVersionNo)
            {
                if (Properties.Settings.Default.Language == "ar")
                {

                    helper.ShowMessage(this, "تحديث البرنامج", "يجب تحديث البرنامج في جميع حواسيبك إلى  إصدار متوافق مع قاعدة البيانات الخاصة بك");
                    if (!GoogleDriveFilesRepository.checkInternet())
                    {
                        DesktopAlert.Show("لايوجد اتصال انترنت للتحقق من التحديثات " + "\n" + "No Internet Connection ");
                        return;
                    }
                    await helper.AddGigalog("Update", "Check", "Version: " + Properties.Settings.Default.VersonNo, "", "");
                    await Task.Run(() => helper.DoBackupSilent());
                }
                else
                {
                    helper.ShowMessage(this, "ExmonSystem Upgragde", "ExmonSystem Must be Compatible with Your DB in all your Computers!");

                }
                Program.isSuccessfullogin = true;

                System.Windows.Forms.Application.Exit();


            }



            timerCheckUpdate.Interval = 60000;
            timerCheckUpdate.Start();


        }

        private void barButtonItem7_ItemClick_2(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem2_ItemClick_3(object sender, ItemClickEventArgs e)
        {

       
        }

        private void barButProductsSalesReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var xx = new FrmItemGover();
            xx.ShowDialog();
        }

        private async void BtnFromVendorToStore_Click(object sender, EventArgs e)
        {
            //FrmStoreInAdd dd = new FrmStoreInAdd();
            //dd.Id = 0;
            //dd.ShowDialog(); 
        
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var frm = new FrmVouchersList();
            frm.formType = "Expens";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;

            frm.Show();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //var myr = new FrmParcelsListReports();
            //myr.formType = "In";
            //myr.Show();
        
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
         
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
           
        }

        private  void simpleButton4_Click(object sender, EventArgs e)
        {
            var frm = new FrmVouchersList();
            frm.formType = "Payment";
            frm.formTypeAr = "دفعة مقدم";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;

            frm.ShowDialog();
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          



        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //FrmStoreProfits pp = new FrmStoreProfits();
            //pp.ShowDialog();


            var myr = new FrmOrdersRpt();
            myr.formType = "Profit";
            myr.Show();
         
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
          
        }

        private async void simpleButton13_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            //var myr = new FrmParcelsListForSendersPaid();
            //myr.formType = "Sender";
            //myr.Show();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
          
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var myr = new FrmParcelsListForSendersPaid();
            //myr.formType = "Sender";
            //myr.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void TableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCarTypes_Click(object sender, EventArgs e)
        {
            var frm = new FrmDestination();
            frm.Show();
        }

        private async void BtnAddCar_Click(object sender, EventArgs e)
        {
            var myr = new FrmCustomer();
            myr.Show();

        }

        private void BtnExpensesReport_Click(object sender, EventArgs e)
        {
            var frm = new FrmVouchersList();
            frm.formType = "Expens";
            frm.mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;

            frm.ShowDialog();
        }

        private async void SimpleButton3_Click_1(object sender, EventArgs e)
        {
            await GetLoad();
            await PrintLabels(false);


        }
        async Task PrintLabels(bool isPrint)
        {
            var typee = "sales";
            var typeePar = "sales";

         
                    typeePar = "المبيعات";


               
                typee = "sales";
            
           


            var mydt = await accountControl.Getdatatable( billList) ;

            if (createdb_BARACODE(mydt))
            {

                XtraReport rd = new XtraReport();
              
                    rd = new BillsAnalysis();

                
               

                //XtraReport rd = BillsReports.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "BillsReports.repx", true);


                rd.Parameters["billtype"].Value = "احصائيات المبيعات";
                rd.Parameters["datefrom"].Value = TxtDateFrom.DateTime;
                rd.Parameters["dateto"].Value = TxtDateTo.DateTime;

                rd.Parameters["CompanyName"].Value = Properties.Settings.Default.COMPANY;
                rd.Parameters["CompanyDetails"].Value = Properties.Settings.Default.CompanyDetailsAr;
                rd.Parameters["CompanyTax"].Value = Properties.Settings.Default.CompanyTaxNumber;
                rd.Parameters["CompanyPhone"].Value = Properties.Settings.Default.CompanyPhons;
                rd.Parameters["logoPath"].Value = Application.StartupPath + @"\" + Properties.Settings.Default.PropLogoName;

                foreach (var item in rd.Parameters)
                {
                    if (item.Name == "totalSum")
                    {
                        //item.Value = TxtTotal.Text;
                    }
                    if (item.Name == "lang")
                    {
                        item.Value = Properties.Settings.Default.Language;
                    }
                    item.Visible = false;
                }


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

                    DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
                    ds.Dispose();
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
            string outpath = System.Windows.Forms.Application.StartupPath + "\\" + "BillsReports.xml";
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

        private void RadioGroup1_SelectedIndexChanged(object sender, EventArgs e)
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
                TxtDateFrom.DateTime = DateTime.Now.AddDays(-1);
                TxtDateTo.DateTime = DateTime.Now;
            }
            else if (radioGroup1.SelectedIndex == 2)//فترتين 
            {
                TxtDateFrom.Enabled = true;
                TxtDateTo.Enabled = true;
                TxtDateFrom.DateTime = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + "01" + "-" + "01");
                TxtDateTo.DateTime = DateTime.Now;
            }
            else if (radioGroup1.SelectedIndex == 3)//الكل 
            {
                TxtDateFrom.DateTime = Convert.ToDateTime("2023" + "-" + "01" + "-" + "01");
                TxtDateTo.DateTime = DateTime.Now;
                TxtDateFrom.Enabled = false;
                TxtDateTo.Enabled = false;

            }
        }

        private async void SimpleButton1_Click_1(object sender, EventArgs e)
        {
            await GetLoad();

        }

        private void BtnSalesReport_Click(object sender, EventArgs e)
        {
            var myr = new FrmOrdersRpt();
            myr.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            var myr = new FrmDistrict();
            myr.ShowDialog();

        }

        private void barButtonCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            var myr = new FrmCustomer();
            myr.Show();

        }

        private void BtnAirLines_Click(object sender, EventArgs e)
        {
            var frm = new FrmAirLine();
            frm.Show();
        }

        private void BtnMemberShips_Click(object sender, EventArgs e)
        {
            var frm = new FrmSubscriber();
            frm.ShowDialog();
        }

        private void BtnExchangeCompany_Click(object sender, EventArgs e)
        {
            var frm = new FrmExCompany();
            frm.ShowDialog();
        }

        private void BtnOrderAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmOrder();
            frm.ShowDialog();
        }

        private void BtnOrderView_Click(object sender, EventArgs e)
        {
            var frm = new FrmOrderList();
            frm.ShowDialog();
        }

        private void BtnOrderPrint_Click(object sender, EventArgs e)
        {
            var frm = new FrmOrdersPrintedRpt();
            frm.Show();
        }

        private void BtnCompanyAccounts_Click(object sender, EventArgs e)
        {
            var frm = new FrmExCompanyAccounts();
            frm.Show();
        }
    }
}