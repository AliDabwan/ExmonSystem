using DevComponents.DotNetBar.Controls;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem.Form
{
    public partial class FrmCustomerAcc : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        public int mAccountId { get; set; }
        public string formType { get; set; }
        public int Id { get; set; }
         int Accounttype { get; set; }
        bool rollUpdate = true;

        AccountControl accControl = new AccountControl();

        public FrmCustomerAcc()
        {
            InitializeComponent();
        }
        async Task GetLoad()
        {

            accountsBindingSource.DataSource = await accControl.GetAllAccount(Convert.ToInt32( TxtMAccountID.Text));//db.itemCategories.ToList();

            TxtName.Enabled = true;

            accountsBindingSource.Add(new Accounts());
            accountsBindingSource.MoveLast();

        }
        private async void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
            TxtName.Focus();

            //await GetLoad();
        }



        void neww()
        {
            TxtName.Enabled = true;
            TxtBalance.Enabled = true;

            accountsBindingSource.MoveLast();
            Accounts obj = accountsBindingSource.Current as Accounts;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    TxtName.Focus();
                }
                else
                {
                    try
                    {
                        accountsBindingSource.ResetBindings(false);

                        accountsBindingSource.Add(new Accounts());
                        accountsBindingSource.MoveLast();
                        TxtName.Focus();
                    }
                    catch 
                    {

                        Close();
                    }
                  
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            neww();
            

        }

        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }

            if (formType == "Customer")
            {
                if (pnlVendorType.SelectedIndex<0)
                {
                    DesktopAlert.Show("يجب تحديد نوع المندوب", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                    return;
                }
            }
                var Maccount = Convert.ToInt32(TxtMAccountID.Text);
          
                Accounts obj = accountsBindingSource.Current as Accounts;
            if (obj.Id > 0)
            {
                if (!rollUpdate)
                {

                    DesktopAlert.Show("لاتوجد صلاحية للتعديل " + "\n" + " Edition is not allowed ", eDesktopAlertColor.DarkBlue, eAlertPosition.TopRight);
                    return;
                }
            }


            if (obj != null)
                {
                obj.MAccountLabelId = Maccount;
                obj.Accounttype = Accounttype;
                  var rslt=   await accControl.AddToAcc(obj);


                    TxtName.Enabled = false;
                    accountsBindingSource.ResetBindings(false);

                    TxtName.Enabled = false;
                //simpleButton1_Click(sender ,e);

                if (rslt>0)
                {
                    Close();

                }
            }
            
        }
        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

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
                    Accounts obj = accountsBindingSource.Current as Accounts;
                    if (obj != null)
                    {
                        if (db.Entry<Accounts>(obj).State == EntityState.Detached)
                            db.Set<Accounts>().Attach(obj);
                        db.Entry<Accounts>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        accountsBindingSource.RemoveCurrent();
                        TxtName.Enabled = false;

                    }
                }

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
            if (formType == "Cash"|| formType == "Expens")
            {
                foreach (var item in myRoll)
                {

                    if (item.RollTitle == "حذف حساب")
                    {
                        if (item.IsChecked == "False")
                        {
                            BtnDelete.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "إضافة حساب")
                    {
                        if (item.IsChecked == "False")
                        {
                            BtnAdd.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "تعديل حساب")
                    {
                        if (item.IsChecked == "False")
                        {
                            rollUpdate = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                }


            }
            if (formType == "Customer")
            {
                foreach (var item in myRoll)
                {

                    if (item.RollTitle == "حذف مندوب")
                    {
                        if (item.IsChecked == "False")
                        {
                            BtnDelete.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "إضافة مندوب")
                    {
                        if (item.IsChecked == "False")
                        {
                            BtnAdd.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "تعديل مندوب")
                    {
                        if (item.IsChecked == "False")
                        {
                            rollUpdate = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                }


            }

            if (formType == "Suplier")
            {
                foreach (var item in myRoll)
                {
                    if (item.RollTitle == "حذف مرسل")
                    {
                        if (item.IsChecked == "False")
                        {
                            BtnDelete.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "إضافة مرسل")
                    {
                        if (item.IsChecked == "False")
                        {
                            BtnAdd.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }

                    if (item.RollTitle == "تعديل مرسل")
                    {
                        if (item.IsChecked == "False")
                        {
                            rollUpdate = Convert.ToBoolean(item.IsChecked);
                        }
                    }
                   

                }


            }


        }

        private async void FrmCustomerAcc_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (formType == "Cash")
            {
                lblResName.Visible = false;
                txtresName.Visible = false;
            
                lblphone.Visible = false;
                txtphone.Visible = false;
                lblmobile.Visible = false;
                txtmobile.Visible = false; 
              

                //  TxtMAccountID.Text = "102";
                mAccountId = Properties.Settings.Default.PropMainAccountCashes == 0 ? 101 : Properties.Settings.Default.PropMainAccountCashes;

                TxtMAccountID.Text = mAccountId.ToString();
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblTitle.Text = "إضافة حساب نقدي";

                }
                else
                {
                    LblTitle.Text = "Add Cash Account";

                }
                LblTitle.BackColor = Color.Gray;
                Accounttype = 0;
            }
            else if (formType=="Customer")
            {
                //  TxtMAccountID.Text = "102";
               mAccountId = Properties.Settings.Default.PropMainAccountCustomers == 0 ? 102 : Properties.Settings.Default.PropMainAccountCustomers;
                txtresName.Visible = false;
                lblResName.Visible = false;
                pnlVendorType.EditValue = "مندوب توصيل";

                TxtMAccountID.Text = mAccountId.ToString();
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblTitle.Text = "إضافة حساب مندوب";

                }
                else
                {
                    LblTitle.Text = "Add Customer Account";

                }
                LblTitle.BackColor = Color.Teal;
                Accounttype = 0;

              
                lblVendorType.Visible = true;
                pnlVendorType.Visible = true;

                lblTasleemBaghdad.Visible = true;
                //lblTasleemBaghdadSub.Visible = true;
                //lblTasleemOthers.Visible = true;
                TxtTasleemBaghdad.Visible = true;
            }
            else if (formType == "Expens")
            {
                //  TxtMAccountID.Text = "102";

                lblResName.Visible = false;
                txtresName.Visible = false;
              
                lblphone.Visible = false;
                txtphone.Visible = false;
                lblmobile.Visible = false;
                txtmobile.Visible = false;
                mAccountId = Properties.Settings.Default.PropMainAccountExpens == 0 ? 104 : Properties.Settings.Default.PropMainAccountExpens;
                
                TxtMAccountID.Text = mAccountId.ToString();
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblTitle.Text = "إضافة حساب مصروفات";

                }
                else
                {
                    LblTitle.Text = "Add Expenses Account";

                }
                LblTitle.BackColor = Color.Teal;
                Accounttype = 0;
            }

            else if (formType == "Suplier")
            {
               mAccountId = Properties.Settings.Default.PropMainAccountSuplier == 0 ? 103 : Properties.Settings.Default.PropMainAccountSuplier;
              
                // TxtMAccountID.Text = "103";
                TxtMAccountID.Text = mAccountId.ToString();
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblTitle.Text = "إضافة حساب مرسل";

                }
                else
                {
                    LblTitle.Text = "Add Suplier Account";

                }
                lblVendorType.Visible = false;
                pnlVendorType.Visible = false;
                LblTitle.BackColor = Color.DarkRed;
                Accounttype = 1;
            }

            this.Text = LblTitle.Text;
            if (Id == 0)
            {
                //ItemProduct obj = new ItemProduct();

                //itemProductBindingSource.DataSource = obj;
                accountsBindingSource.Add(new Accounts());
                accountsBindingSource.MoveLast();
                TxtBalance.Enabled = true;
                TxtName.Focus();
                timerLoad.Start();
            }
            else
            {
                //TxtBalance.Enabled = false;

                var itemObj =await accControl.Getaccount(Id);
                //  itemProductBindingSource.ResetBindings(false);
                accountsBindingSource.DataSource = itemObj;
            }

            await getMyRoll();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void pnlVendorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlVendorType.SelectedIndex==0)
            {
                lblTawseelBaghdad.Visible = true;
                lblTawseelBaghdadSub.Visible = true;
                lblTawseelOther.Visible = true;
                TxtTawseelBaghdad.Visible = true;
                TxtTawseelBaghdadSub.Visible = true;
                TxtTawseelOthers.Visible = true;



                lblTasleemBaghdad.Visible = false;
                lblTasleemBaghdadSub.Visible = false;
                lblTasleemOthers.Visible = false;
                TxtTasleemBaghdad.Visible = false;
                TxtTasleemBaghdadSub.Visible = false;
                TxtTasleemOthers.Visible = false;
            }
            else if (pnlVendorType.SelectedIndex == 1)
            {
                lblTasleemBaghdad.Visible = true;
                //lblTasleemBaghdadSub.Visible = true;
                //lblTasleemOthers.Visible = true;
                TxtTasleemBaghdad.Visible = true;
                //TxtTasleemBaghdadSub.Visible = true;
                //TxtTasleemOthers.Visible = true;


                lblTawseelBaghdad.Visible = false;
                lblTawseelBaghdadSub.Visible = false;
                lblTawseelOther.Visible = false;
                TxtTawseelBaghdad.Visible = false;
                TxtTawseelBaghdadSub.Visible = false;
                TxtTawseelOthers.Visible = false;
            }else
            {
                lblTawseelBaghdad.Visible = true;
                lblTawseelBaghdadSub.Visible = true;
                lblTawseelOther.Visible = true;
                TxtTawseelBaghdad.Visible = true;
                TxtTawseelBaghdadSub.Visible = true;
                TxtTawseelOthers.Visible = true;
                lblTasleemBaghdad.Visible = true;
                //lblTasleemBaghdadSub.Visible = true;
                //lblTasleemOthers.Visible = true;
                TxtTasleemBaghdad.Visible = true;
                //TxtTasleemBaghdadSub.Visible = true;
                //TxtTasleemOthers.Visible = true;

            }
        }

        private void TxtTawseelBaghdad_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}