using DevComponents.DotNetBar.Controls;
using DevExpress.XtraSplashScreen;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem
{
    public partial class SplashScree1 : SplashScreen
    {
        RollsControl rollsControl = new RollsControl();

        AccountControl accountControl = new AccountControl();
        CompanyControl company = new CompanyControl();

        public SplashScree1()
        {
            InitializeComponent();
            if (ExmonSystem.Properties.Settings.Default.Language == "ar")
            {
                this.labelControl1.Text = "-حقوق البرنامج محفوظة © 2023 " + DateTime.Now.Year.ToString(); ;

            }
            else
            {
                this.labelControl1.Text = "Copyright © 2023-" + DateTime.Now.Year.ToString();

            }
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

       async Task<int> AddNewRollName()
        {
            try
            {

                var rolls = await rollsControl.GetRollName();
                this.Show();

                if (rolls != null)
                {

                    return 1;
                }
                else
                {
                    this.Show();
                    //FrmSQLConn frmSQLConn = new FrmSQLConn();
                    //frmSQLConn.ShowDialog();

                    //timer1.Start();
                    //return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Roll  -: " + ex.Message.ToString());
                if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                {
                    this.labelControl2.Text = "!خطأ في الإتصال بالسيرفر";

                }
                else
                {
                    this.labelControl2.Text = "Connction Error!";

                }
                Thread.Sleep(500);
                //MessageBox.Show("62");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }
         
            
            this.labelControl2.Text = "Please wait , adding the applications roll";
            List<RollNames> rollNames = new List<RollNames>()
            {
                //card
                new RollNames() { RollName = "ادارة الزبائن" },
                new RollNames() { RollName = "دول الوجهات" },
                new RollNames() { RollName = "شركات الطيران" },
                new RollNames() { RollName = "ادارة شركات الصرافة" },
              
                new RollNames() { RollName = "حسابات الشركات" },
                new RollNames() { RollName = "الاشتراكات" },
                new RollNames() { RollName = "اضافة طلب" },
                new RollNames() { RollName = "طباعة طلب" },
                new RollNames() { RollName = "الطلبات" },
                new RollNames() { RollName = "البيانات الاساسية" },


                 new RollNames() { RollName = "سند مصروف" },
                new RollNames() { RollName = "الاستيراد" },
                 new RollNames() { RollName = "التصدير" },
                new RollNames() { RollName = "اعدادات البرنامج" },
                new RollNames() { RollName = "المستخدمين" },
                new RollNames() { RollName = "مجموعات المستخدمين" },

                new RollNames() { RollName = "إضافة حساب" },
                new RollNames() { RollName = "إضافة عميل" },
                //new RollNames() { RollName = "إضافة مورد" },

                 new RollNames() { RollName = "تعديل حساب" },

                new RollNames() { RollName = "تعديل عميل" },
                //new RollNames() { RollName = "تعديل مورد" },

                   new RollNames() { RollName = "حذف حساب" },
                new RollNames() { RollName = "حذف عميل" },
                //new RollNames() { RollName = "حذف مورد" },

                //new RollNames() { RollName = "سند قبض" },
                //new RollNames() { RollName = "حذف سند قبض" },
                //new RollNames() { RollName = "عرض سند قبض" },

                //   new RollNames() { RollName = "سند دفع" },
                //new RollNames() { RollName = "حذف سند دفع" },
                //new RollNames() { RollName = "عرض سند دفع" },
                //new RollNames() { RollName = "ترحيل حساب" },
                //new RollNames() { RollName = "تقارير ترحيل الحسابات" },


               ///

                //bills
                //new RollNames() { RollName = "نقاط البيع" },
                //new RollNames() { RollName = "فاتورة المبيعات" },
                //new RollNames() { RollName = "تعديل المبيعات" },
                //new RollNames() { RollName = "حذف المبيعات" },
                //new RollNames() { RollName = "عرض المبيعات" },
                //new RollNames() { RollName = "تقارير المبيعات" },
              
                //new RollNames() { RollName = "فاتورة المشتريات" },
                //new RollNames() { RollName = "تعديل المشتريات" },
                //new RollNames() { RollName = "حذف المشتريات" },
                //new RollNames() { RollName = "عرض المشتريات" },
                //new RollNames() { RollName = "تقارير المشتريات" },

                //  new RollNames() { RollName = "فاتورة مرتجع المبيعات" },
                //new RollNames() { RollName = "حذف مرتجع المبيعات" },
                //new RollNames() { RollName = "عرض مرتجع المبيعات" },

                //new RollNames() { RollName = "فاتورة مرتجع المشتريات" },
                //new RollNames() { RollName = "حذف مرتجع المشتريات" },
                //new RollNames() { RollName = "عرض مرتجع المشتريات" },

                //new RollNames() { RollName = "تقرير المبيعات اليومي" },
                //new RollNames() { RollName = "تقرير الارباح" },
                //new RollNames() { RollName = "تقرير الضريبة" },




            };

            var rslr = 0;
                if (rollNames != null)
                {
                rslr= await rollsControl.AddListRollNamesDirect(rollNames);
                }

            return rslr;
        }




        async Task<int> AddNewRollName(string roolNam)
        {
            try
            {

                var rolls = await rollsControl.GetRollName(roolNam);
                this.Show();

                if (rolls != null)
                {

                    return 1;
                }
                else
                {
                    this.Show();
               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Roll  -: " + ex.Message.ToString());
                if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                {
                    this.labelControl2.Text = "!خطأ في الإتصال بالسيرفر";

                }
                else
                {
                    this.labelControl2.Text = "Connction Error!";

                }
                Thread.Sleep(500);
                //MessageBox.Show("62");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }


            List<RollNames> rollNames = new List<RollNames>()
            {
                //card
                new RollNames() { RollName =roolNam },
        




            };

            var rslr = 0;
            if (rollNames != null)
            {
                rslr = await rollsControl.AddListRollNamesDirect(rollNames);
            }

            return rslr;
        }

        async Task<int> AddNewRollGroup()
        {
            try
            {
                var groups = await rollsControl.GetGroup();
                if (groups != null)
                {
                    return 1;
                }
                else
                {

                    this.Show();

                }

            }
            catch
            {

                this.labelControl2.Text = "Connction Error";
                Thread.Sleep(500);

                //MessageBox.Show("179");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }
            this.labelControl2.Text = "Please wait , adding the applications Roll Groups";
            List<RollGroups> rollGroups= new List<RollGroups>()
            {
                //card
                new RollGroups() { GroupRollName = "Support" },
                new RollGroups() { GroupRollName = "Manager" },
                //new RollGroups() { GroupRollName = "Saler" },
                //new RollGroups() { GroupRollName = "Pos" },
                //new RollGroups() { GroupRollName = "Inventory" },

            };

            var rslr = 0;
            if (rollGroups != null)
            {
                rslr = await rollsControl.AddListGroupsDirect(rollGroups);

            }

            return rslr;
        }



        async Task<int> fillusersByRool()
        {
            try
            {
                var users = await rollsControl.GetUsers("Support", "Manager");
                if (users == null)
                {
                    //DesktopAlert.Show("null");

                    return 1;
                }





               
                foreach (var item in users)
                {
                    //MessageBox.Show(item.UserName+" ");


                    var rollnames = await rollsControl.GetAllNames();
                    List<Rolls> rollList = new List<Rolls>();

                    foreach (var rollname in rollnames)
                    {

                        //DesktopAlert.Show("add new rools");

                        var myrollofusre = await rollsControl.getMyRoll(item.groupRollId, rollname.RollName);

                        if (myrollofusre==null)
                        {
                            //DesktopAlert.Show("    هذه الصلاحية ليست مضافة "  + rollname.RollName);

                            Rolls rolls = new Rolls()
                                {
                                    RollTitle = rollname.RollName,
                                    IsChecked = "True",
                                    groupRollId = item.groupRollId
                                };

                                rollList.Add(rolls);


                        }
                        else
                        {
                            continue;
                        }

                    }

                    if (rollList.Count>0)
                    {
                        //DesktopAlert.Show("its not null"+ rollList.Count);

                        var rsltroll = await rollsControl.AddListRollDirect(rollList);
                    }

                }






            }
            catch
            {

                this.labelControl2.Text = "Connction Error";
                Thread.Sleep(500);

                //MessageBox.Show("224");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }






            return 1;
        }
        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        async Task<int> AddNewUsers()
        {
            try { 
            var users = await rollsControl.GetUser();
            if (users != null)
            {
                return 1;
            }
           
            }
            catch
            {

                this.labelControl2.Text = "Connction Error";
                Thread.Sleep(500);

                //MessageBox.Show("224");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }
            this.labelControl2.Text = "Please wait , adding the applications Users";

            var groupId =await rollsControl.GetGroups("Support");

            if (groupId==null)
            {
                return 0;
            }

            //card
            User usrer = new User()
            {
                UserName = "admin",
                Pwd = Base64Encode("1"),
                FullName = "admin",
                groupRollId = groupId.Id,
                IsEncrept=true
            };
               

           

            var rslr = 0;
            if (usrer != null)
            {
                rslr = await rollsControl.AddUserDirect(usrer);
            }


            if (rslr>0)
            {
                var rollnames = await rollsControl.GetAllNames();
                List<Rolls> rollList = new List<Rolls>();

                foreach (var rollname in rollnames)
                {
                    Rolls rolls = new Rolls()
                    {
                        RollTitle = rollname.RollName,
                        IsChecked = "True",
                        groupRollId = groupId.Id
                    };

                    rollList.Add(rolls);
                }

                if (rollList!=null)
                {
                    var rsltroll = await rollsControl.AddListRollDirect(rollList);
                }





            }


            return rslr;
        }
        async Task<int> addMaccount()
        {
            try
            {
                var MainAccCash = await accountControl.GetMainaccount("Cashers");

                if (MainAccCash != null)
                {
                    return 1;
                }
            }
            catch
            {

                this.labelControl2.Text = "Connction Error";
                Thread.Sleep(500);

                //MessageBox.Show("304"); 
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }


            List<AccountsLabels> accountsLabels = new List<AccountsLabels>()
            {
                //card
                new AccountsLabels() {MAccountId=101, MAccountName = "Cashers" },
                new AccountsLabels() {MAccountId=102, MAccountName = "Customers" },
                new AccountsLabels() {MAccountId=103,MAccountName = "Supliers" },
                new AccountsLabels() {MAccountId=104,MAccountName = "Expenses" },
                new AccountsLabels() {MAccountId=105,MAccountName = "Revenses" },
                new AccountsLabels() {MAccountId=106,MAccountName = "Goods" },
                new AccountsLabels() {MAccountId=107,MAccountName = "Sales" },
                new AccountsLabels() {MAccountId=108,MAccountName = "Purchase" },

            };

            var rslr = 0;
            if (accountsLabels != null)
            {

                rslr = await accountControl.addListAccountsLabels(accountsLabels);

            }

            return rslr;
        }

        async Task<int> addSubMaccount()
        {
            try
            {
                var GetSubaccount = await accountControl.GetSubaccount("الصندوق النقدي");
                //  DesktopAlert.Show("Go addSubMaccount");

                if (GetSubaccount != null)
                {
                    this.Show();

                    return 1;
                }
                this.Show();

            }
            catch
            {

                this.labelControl2.Text = "Connction Error";
                //Thread.Sleep(500);

                //MessageBox.Show("354");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }
    // DesktopAlert.Show(" addSubMaccount");


    List<Accounts> accountssub = new List<Accounts>()
            {
                //card
                new Accounts() {MAccountLabelId=101,AccountID=1010001,Accounttype=0, AccountName = "الصندوق النقدي" },
               
                new Accounts() {MAccountLabelId=103,AccountID=1030001,Accounttype=1, AccountName = "مورد" },
                new Accounts() {MAccountLabelId=102,AccountID=1020001,Accounttype=0, AccountName = "عميل" },
                new Accounts() {MAccountLabelId=104,AccountID=1040001,Accounttype=0, AccountName = "مصروفات عامه" },
                //new Accounts() {MAccountLabelId=106,AccountID=1060001,Accounttype=0, AccountName = "Goods مخزون" },
                new Accounts() {MAccountLabelId=107,AccountID=1070001,Accounttype=1, AccountName = "مبيعات" },
                //new Accounts() {MAccountLabelId=108,AccountID=1080001,Accounttype=0, AccountName = "Purchase المشتريات" },
                //new Accounts() {MAccountLabelId=104,AccountID=1040002,Accounttype=0, AccountName = "ضريبة المصروفات" }



            };



            ExmonSystem.Properties.Settings.Default.PropMainAccountCashes = 101;
            ExmonSystem.Properties.Settings.Default.PropMainAccountCustomers= 102;
            ExmonSystem.Properties.Settings.Default.PropMainAccountSuplier= 103;
            ExmonSystem.Properties.Settings.Default.PropMainAccountExpens = 104;
            ExmonSystem.Properties.Settings.Default.Save();



            var rslr = 0;
            if (accountssub != null)
            {
              //  DesktopAlert.Show(" accountssub");

                rslr = await accountControl.addListAccountsSub(accountssub);
             //   DesktopAlert.Show(" accountssub"+ rslr);

            }

            return rslr;
        }




        //async Task<int> addGeneral()
        //{
        //    var tax = await company.GetWasherCounter();
        // //   DesktopAlert.Show(" accaddGeneralountssub");

        //    if (tax != null)
        //    {
        //        return 1;
        //    }

        //    //  DesktopAlert.Show(" accaddGeneralountssub");


        //    ////card
        //    //WashingCounter acc = new WashingCounter()
        //    //{
        //    //    Name="1",
        //    //    Statue=true,
        //    //    AdminName="افتراضي"
              
        //    //};
        //    //Taxes acc2 = new Taxes()
        //    //{
        //    //    TaxValue = 0,
        //    //    TaxName = "بدون ضريبة"
        //    //};

        //    //ItemCategory cat = new ItemCategory()
        //    //{
        //    //    Name = "General عام"
        //    //};

        //    //ItemUnit unt = new ItemUnit()
        //    //{
        //    //    Name = "Pcs حبة",
        //    //    Sympol= "Pcs حبة"
        //    //};



        //    var taxRslt = 0;
        //    if (acc != null)
        //    {
        //        //  DesktopAlert.Show(" accaddGeneralountssub");


        //        taxRslt = await company.AddWashingCounterDirect(acc);

        //        //taxRslt = await accountControl.addCategoryDirect(cat);
        //        //taxRslt = await accountControl.addunitDirect(unt);

        //    }

        //    return taxRslt;
        //}
        async Task<int> addCompany()
        {


            var tax = await company.GetCompany();

            if (tax == null)
            {

                var GetSubaccount = await accountControl.GetSubaccount("الصندوق النقدي");
                //  DesktopAlert.Show("Go addSubMaccount");

                if (GetSubaccount != null)
                {
                    var newCompany = new Company()
                    {
                        NameAr = "تسجيل إسم المنشأة هنا",

                        PropAccAtmAccountId = GetSubaccount.Id
                    };
                    await company.AddCompany(newCompany);
                }
                return 1;
            }

            //  DesktopAlert.Show(" accaddGeneralountssub");

            var taxRslt = 0;

            //card

            //if (tax.PropAccAtmAccountId==0)
            //{

            //    var GetSubaccount = await accountControl.GetSubaccount("ATM بطاقة");
            //    //  DesktopAlert.Show("Go addSubMaccount");

            //    if (GetSubaccount != null)
            //    {
            //        tax.PropAccAtmAccountId = GetSubaccount.Id;

            //        taxRslt = await company.AddCompany(tax);
            //    }
            //    else
            //    {

            //        List<Accounts> accountssub = new List<Accounts>()
            //        {
            //    //card
            //     new Accounts() {MAccountLabelId=101,AccountID=1010003,Accounttype=0, AccountName = "ATM بطاقة" },



            //        };

            //        if (accountssub != null)
            //        {
            //            //  DesktopAlert.Show(" accountssub");

            //            await accountControl.addListAccountsSub(accountssub);
            //            //   DesktopAlert.Show(" accountssub"+ rslr);

            //            var GetSubaccount2 = await accountControl.GetSubaccount("ATM بطاقة");
            //            //  DesktopAlert.Show("Go addSubMaccount");

            //            if (GetSubaccount2 != null)
            //            {
            //                tax.PropAccAtmAccountId = GetSubaccount2.Id;

            //                taxRslt = await company.AddCompany(tax);
            //            }
            //        }


            //    }
               

            //}


            //  DesktopAlert.Show(" accaddGeneralountssub");






            return taxRslt;
        }

        async Task GetDefault()
        {
            //MessageBox.Show("14");
            this.Show();

            await AddNewRollName();
            await AddNewRollGroup();
            await AddNewUsers();
            await addMaccount();
            await addSubMaccount();
            //await addGeneral();




            //AddNewRollName("الحسابات النقدية");
            //AddNewRollName("ترحيل الحسابات النقدية");
            //AddNewRollName("حسابات المصروفات");
            //AddNewRollName("المرسلين");
            //AddNewRollName("المندوبين");
            //AddNewRollName("قائمة المندوبين الدائنين");
            //AddNewRollName("قائمة المرسلين المدينين");
            //AddNewRollName("انواع الدفع");
            //AddNewRollName("الاشعارات الدائنة والمدينة");
            //AddNewRollName("عرض الاشعارات");
            //AddNewRollName("حذف الاشعارات");
            //AddNewRollName("نهاية اليوم");
            //AddNewRollName("اضافة الاصناف من شاشة الفواتير");


            await fillusersByRool();

            await addCompany();
            this.Show();






            // var MainAccCash= await accountControl.GetMainaccount("Cashers");
            // var MainAccSales= await accountControl.GetMainaccount("Sales");

            //Main Accunt


            try
            {
                var CashAcc = await accountControl.Getaccount("الصندوق النقدي");
                if (CashAcc == null)
                {


                    return;
                }


                ExmonSystem.Properties.Settings.Default.PropBAccountCash = CashAcc != null ? CashAcc.Id : 1;
                ExmonSystem.Properties.Settings.Default.Save();

            }
            catch
            {

                if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                {
                    this.labelControl2.Text = "@خطأ في الإتصال بالسيرفر";

                }
                else
                {
                    this.labelControl2.Text = "Connction Error@";

                }
                //Thread.Sleep(500);

                //MessageBox.Show("496");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
            }

            try
            {

          
            var BankAcc = await accountControl.Getaccount("مصروفات عامه");
                if (BankAcc == null)
                {


                    return;
                }
                ExmonSystem.Properties.Settings.Default.PropBExpensesTaxAccount = BankAcc != null ? BankAcc.Id : 5;
                ExmonSystem.Properties.Settings.Default.Save();
                //DesktopAlert.Show("BankAcc.Id " + BankAcc.Id);

            }
            catch
            {

                if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                {
                    this.labelControl2.Text = "#خطأ في الإتصال بالسيرفر";

                }
                else
                {
                    this.labelControl2.Text = "Connction Error#";

                }
                //Thread.Sleep(500);

                //MessageBox.Show("521");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
            }
            try
            {

                var SalesAcc = await accountControl.Getaccount("مبيعات");
                if (SalesAcc == null)
                {


                    return;
                }
                ExmonSystem.Properties.Settings.Default.PropBAccountSales = SalesAcc != null ? SalesAcc.Id : 6;
                ExmonSystem.Properties.Settings.Default.Save();

            }
            catch
            {

                if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                {
                    this.labelControl2.Text = "%خطأ في الإتصال بالسيرفر";

                }
                else
                {
                    this.labelControl2.Text = "Connction Error%";

                }
                //Thread.Sleep(500);

                //MessageBox.Show("544");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
            }
            //try
            //{
            //    var PurchasAcc = await accountControl.Getaccount("Purchase المشتريات");
            //    if (PurchasAcc == null)
            //    {


            //        return;
            //    }
            //    ExmonSystem.Properties.Settings.Default.PropBAccountPurchase = PurchasAcc != null ? PurchasAcc.Id : 9;
            //    ExmonSystem.Properties.Settings.Default.Save();

            //}
            //catch
            //{

            //    if (ExmonSystem.Properties.Settings.Default.Language == "ar")
            //    {
            //        this.labelControl2.Text = "$خطأ في الإتصال بالسيرفر";

            //    }
            //    else
            //    {
            //        this.labelControl2.Text = "Connction Error$";

            //    }
            //    //Thread.Sleep(500);
            //    //MessageBox.Show("565");
            //    FrmSQLConn frmSQLConn = new FrmSQLConn();
            //    frmSQLConn.ShowDialog();
            //}


            //sub Accounts

         
        }



        //async Task SetDef()
        //{



        //    ExmonSystem.Properties.Settings.Default.PropBAccountCash = 1;
        //        ExmonSystem.Properties.Settings.Default.Save();

        //        ExmonSystem.Properties.Settings.Default.PropBAccountBank = 2 ;
        //        ExmonSystem.Properties.Settings.Default.Save();
        //    ExmonSystem.Properties.Settings.Default.PropBExpensesTaxAccount = 4;
        //    ExmonSystem.Properties.Settings.Default.Save();



        //    ExmonSystem.Properties.Settings.Default.PropBAccountSales = 8;
        //        ExmonSystem.Properties.Settings.Default.Save();

           
        //        ExmonSystem.Properties.Settings.Default.PropBAccountPurchase = 9  ;
        //        ExmonSystem.Properties.Settings.Default.Save();


        //    //await addSubExpTaxMaccount(104, 1040002, 0, "ضريبة المصروفات");
        //    //await addSubExpTaxMaccount(104, 1040003, 0, "الخصم المسموح به");
        //    //await addSubExpTaxMaccount(104, 1040004, 1, "الخصم المكتسب");


        //}
        async Task chkCon()
        {
            if (ExmonSystem.Properties.Settings.Default.Language == "ar")
            {
                this.labelControl2.Text = "بدء تشغيل البرنامج - التحقق من البيانات";

            }
            else
            {
                this.labelControl2.Text = "checking StartUp Data";

            }

            Thread.Sleep(500);

            //string ConnectionString = "";
            this.Show();

            //await SetDef();
            this.Show();

            try
            {

                //AppSettings appSettings = new AppSettings();



                await GetDefault();

                //if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                //{
                //    this.labelControl2.Text = " التحقق من الاتصال بقاعدة البيانات";

                //}
                //else
                //{
                //    this.labelControl2.Text = "checking server connection";

                //}

                ////if (ExmonSystem.Properties.Settings.Default.ConType == "Server")
                ////{

                ////ConnectionString = appSettings.GetConnectionString("cn");
                //ConnectionString = appSettings.GetConnectionString(ExmonSystem.Properties.Settings.Default.ConName);

                //}else
                //{
                //    ConnectionString = appSettings.GetConnectionString("ln");

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("check 1 -: "+ex.Message.ToString());
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
              
                timer1.Start();
                return;
            }
            try
            {


                //SQLHelpr helper = new SQLHelpr(ConnectionString);
                //if (helper.IsConnection)
                //{
                //if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                //{
                //    this.labelControl2.Text = "تم الإتصال بقاعدة البيانات";

                //}
                //else
                //{
                //    this.labelControl2.Text = "Connction succeeded";

                //}

                this.Show();


                Thread.Sleep(500);
                try
                {
                    //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", true);
                    //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US", true);
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(ExmonSystem.Properties.Settings.Default.Language, true);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(ExmonSystem.Properties.Settings.Default.Language, true);
                    Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

                    DateTimeFormatInfo englishDatetime = new CultureInfo("en-US", true).DateTimeFormat;
                    NumberFormatInfo numberFormatInfo = new CultureInfo("en-US", true).NumberFormat;
                    Thread.CurrentThread.CurrentCulture.DateTimeFormat = englishDatetime;
                    Thread.CurrentThread.CurrentCulture.NumberFormat = numberFormatInfo;

                    GregorianCalendar GregorianCalendarr = new GregorianCalendar(GregorianCalendarTypes.USEnglish);
                    GregorianCalendarr.Clone();
                    Thread.CurrentThread.CurrentCulture.DateTimeFormat.Calendar = GregorianCalendarr;


                }
                catch (Exception ex)
                {
                    GoogleDriveFilesRepository.SetLog("Calture error before start menu","CaluturErr");
                    DesktopAlert.Show("check 2 -: " + ex.Message.ToString());
                    this.Hide();

                    MainMenu fd = new MainMenu();
                    fd.IsMdiContainer = true;
                    fd.Show();
                    return;
                }






                this.Hide();

                MainMenu f = new MainMenu();
                f.IsMdiContainer = true;
                f.Show();
                //}
                //else
                //{
                //    if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                //    {
                //        this.labelControl2.Text = "&خطأ في الإتصال بالسيرفر";

                //    }
                //    else
                //    {
                //        this.labelControl2.Text = "Connction Error&";

                //    }
                //    //Thread.Sleep(500);

                //    //MessageBox.Show("640");
                //    FrmSQLConn frmSQLConn = new FrmSQLConn();
                //    frmSQLConn.ShowDialog();
                //    timer1.Start();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("check 3 -: " + ex.Message.ToString());
                if (ExmonSystem.Properties.Settings.Default.Language == "ar")
                {
                    this.labelControl2.Text = "&&خطأ في الإتصال بالسيرفر";

                }
                else
                {
                    this.labelControl2.Text = "Connction Error&&";

                }                    //MessageBox.Show("649");
                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timer1.Start();
            }
}
        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Show();

            if (ExmonSystem.Properties.Settings.Default.Language == "ar")
            {
                this.labelControl2.Text = "بدء تشغيل البرنامج ...";

            }
            else
            {
                this.labelControl2.Text = "Starting...";

            }

            await chkCon();
          
        }

        private void marqueeProgressBarControl1_EditValueChanged(object sender, EventArgs e)
        {

        }
        void getConnection()
        {
            timerConn.Stop();
            if (ExmonSystem.Properties.Settings.Default.Language == "ar")
            {
                this.labelControl2.Text = " التحقق من الاتصال بقاعدة البيانات";

            }
            else
            {
                this.labelControl2.Text = "checking server connection";

            }
            try
            {
                var tax = company.GetCompany();

            }
            catch
            {

                FrmSQLConn frmSQLConn = new FrmSQLConn();
                frmSQLConn.ShowDialog();
                timerConn.Start();
                return;
            }


            string ConnectionString = "";

            AppSettings appSettings = new AppSettings();

            ConnectionString = appSettings.GetConnectionString(ExmonSystem.Properties.Settings.Default.ConName);

            SQLHelpr helper = new SQLHelpr(ConnectionString);
            if (helper.IsConnection)
            {


                //MessageBox.Show("Connction succeeded Saved " + ExmonSystem.Properties.Settings.Default.ConType, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var myCon = new myserverCon()
                {
                    name = ExmonSystem.Properties.Settings.Default.ConName,
                    DataSource = appSettings.conDetails(ExmonSystem.Properties.Settings.Default.ConName).DataSource,
                    InitialCatalog = appSettings.conDetails(ExmonSystem.Properties.Settings.Default.ConName).InitialCatalog,
                    UserID = appSettings.conDetails(ExmonSystem.Properties.Settings.Default.ConName).UserID,
                    Password = appSettings.conDetails(ExmonSystem.Properties.Settings.Default.ConName).Password
                };

                GoogleDriveFilesRepository.SetServerCon(myCon);
                timer1.Start();
            }
            else
            {
                if (File.Exists(@".\serverCon.json"))
                {

                var mycon=    GoogleDriveFilesRepository.GetServerCon();

                    if (mycon!=null)
                    {
                        if (mycon.name == "ln")
                        {
                            ConnectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true", mycon.DataSource, mycon.InitialCatalog);

                            appSettings.SaveConnectionString(mycon.name, ConnectionString);
                           ExmonSystem.Properties.Settings.Default.ConType = "Local";
                           ExmonSystem.Properties.Settings.Default.ConName = mycon.name;
                            ExmonSystem.Properties.Settings.Default.Save();
                            //MessageBox.Show(setting.GetConnectionString(lblConName.Text));
                        }
                        else
                        {
                            ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", mycon.DataSource, mycon.InitialCatalog, mycon.UserID, mycon.Password);

                            appSettings.SaveConnectionString(mycon.name, ConnectionString);
                           ExmonSystem.Properties.Settings.Default.ConType = "Server";
                           ExmonSystem.Properties.Settings.Default.ConName = mycon.name;
                            ExmonSystem.Properties.Settings.Default.Save();
                        }
                        Close();
                        //timerConn.Start();
                    }
                    else
                    {
                        //open sqlform
                        FrmSQLConn frmSQLConn = new FrmSQLConn();
                        frmSQLConn.ShowDialog();
                        timerConn.Start();
                    }
                }
                else
                {
                    FrmSQLConn frmSQLConn = new FrmSQLConn();
                    frmSQLConn.ShowDialog();
                    timerConn.Start();
                    //open sqlform
                }

            }


        }
        private void SplashScree1_Load(object sender, EventArgs e)
        {

            if (ExmonSystem.Properties.Settings.Default.ConType== "Local"&& ExmonSystem.Properties.Settings.Default.ConName== "cn")
            {
                Console.Beep();

                ExmonSystem.Properties.Settings.Default.ConType = "Server";
                ExmonSystem.Properties.Settings.Default.Save();
            }




            //MessageBox.Show("1   :  "+ExmonSystem.Properties.Settings.Default.ConType+"  : "+ ExmonSystem.Properties.Settings.Default.ConName);

            timerConn.Start();
        }

        private void SplashScree1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F12)
            {
                var swl = new FrmSQLConn();
                swl.ShowDialog();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var s = new FrmSQLConn();
            s.ShowDialog();
        }

        private void timerConn_Tick(object sender, EventArgs e)
        {
            timerConn.Stop();
            getConnection();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}