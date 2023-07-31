using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace ExmonSystem.Form
{
    public partial class FrmAccountsClose : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        int Accounttype { get; set; }

        public string formType { get; set; }
         string transType { get; set; }
         string EntryType { get; set; }

        AccountControl accControl = new AccountControl();
        public int mAccountId { get; set; }
        public FrmAccountsClose()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
          
        }
      
        async Task getAccountsName()
        {
            if (formType == "Payment")
            {
                cmbFrom.DataSource = await accControl.GetAllAccount(mAccountId);//db.itemCategories.ToList();
                cmbTo.DataSource = await accControl.GetAllAccount(101);//db.itemCategories.ToList();

                cmbFrom.DisplayMember = "AccountName";
                cmbFrom.ValueMember = "Id";
                cmbTo.DisplayMember = "AccountName";
                cmbTo.ValueMember = "Id";

            }
            else if (formType == "Receipt") //سندقبض
            {
                cmbFrom.DataSource = await accControl.GetAllAccount(101);//db.itemCategories.ToList();
                cmbTo.DataSource = await accControl.GetAllAccount(mAccountId);//db.itemCategories.ToList();
                cmbFrom.DisplayMember = "AccountName";
                cmbFrom.ValueMember = "Id";
                cmbTo.DisplayMember = "AccountName";
                cmbTo.ValueMember = "Id";

            }
            else if (formType == "DailEntry")
            {
                cmbFrom.DataSource = await accControl.Getaccounts(Properties.Settings.Default.PropBAccountCash);//db.itemCategories.ToList();
                cmbTo.DataSource = await accControl.Getaccounts(Program.logedUser.CashAccountId==0? Properties.Settings.Default.PropBAccountCash: Program.logedUser.CashAccountId);//db.itemCategories.ToList();
                cmbFrom.DisplayMember = "AccountName";
                cmbFrom.ValueMember = "Id";
                cmbTo.DisplayMember = "AccountName";
                cmbTo.ValueMember = "Id";

                cmbTo.SelectedValue = Program.logedUser.CashAccountId;


            }
            else
            {
                cmbFrom.DataSource = await accControl.GetAllAccount(mAccountId);//db.itemCategories.ToList();
                cmbTo.DataSource = await accControl.GetAllAccount(101);//db.itemCategories.ToList();
                cmbFrom.DisplayMember = "AccountName";
                cmbFrom.ValueMember = "Id";
                cmbTo.DisplayMember = "AccountName";
                cmbTo.ValueMember = "Id";
            }


        }
        async Task getMyRoll()
        {
            RollsControl control = new RollsControl();



            var myRoll = await control.getMyRoll(Program.userGroupId);
            //var json = JsonConvert.SerializeObject(myRoll);

            //var ss = JsonConvert.DeserializeObject(json);
            //var x = (List<Rolls>)ss;


            if (myRoll == null)
            {
                return;
            }

            if (formType == "Receipt")
            {
                foreach (var item in myRoll)
                {
                    
                    if (item.RollTitle == "حذف سند قبض")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }


                }


            }

            if (formType == "Payment")
            {
                foreach (var item in myRoll)
                {
                   
                    if (item.RollTitle == "حذف سند دفع")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }



                }


            }
            if (formType == "DailEntry")
            {
                foreach (var item in myRoll)
                {

                    if (item.RollTitle == "حذف سند ترحيل")
                    {
                        if (item.IsChecked == "False")
                        {
                            simpleButton2.Visible = Convert.ToBoolean(item.IsChecked);
                        }
                    }



                }


            }

        }

        private async void FrmPayments_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (true)
            {

            }
            await getAccountsName();
            TxtDate.DateTime = DateTime.Now;
            if (formType == "DailEntry")

            {
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.BackColor = Color.Gray;
                Accounttype = 0;
                transType = "قيد يومي";
                if (Properties.Settings.Default.Language == "ar")
                {
                    if (Program.userGroupName == "Manager" || Program.userGroupName == "Support")
                    {
                        LblHeader.Text = "ترحيل حساب نقدي";


                    }
                    else
                    {
                        LblHeader.Text = "ترحيل حسابي النقدي";

                    }

                    lblFrom.Text = "الحساب النقدي";
                    lblTo.Text = "حسابي";
                }
                else
                {
                    LblHeader.Text = "Cash Transfeer";

                    lblFrom.Text = "Cash Account";
                    lblTo.Text = "My Account";

                }
                await getToBalance();
                //TxtNote.Text = "اقفال الحساب النقدي لليوزر :  "+Program.logedUser.FullName+" تاريخ : "+TxtDate.DateTime.Date.ToString("dd/MM/yyyy");
                //TxtNote.ReadOnly = true;
            }
            if (formType == "Cash")
            {
                //TxtMAccountID.Text = "101";
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.Text = "Cash Voucher";
                LblHeader.BackColor = Color.Gray;
                Accounttype = 0;
                transType = "سند قيد";

            }

            if (formType == "Expens")
            {
               // TxtMAccountID.Text = "104";
                TxtMAccountID.Text = mAccountId.ToString();


                LblHeader.Text = "Expens Voucher";
                LblHeader.BackColor = Color.Olive;
                Accounttype = 0;
                transType = "سند قيد مصروف";
                EntryType = "مدين";
                if (Properties.Settings.Default.Language == "ar")
                {
                    lblFrom.Text = "حساب المصروفات";
                    lblTo.Text = "الحساب النقدي";
                }
                else
                {
                    lblFrom.Text = "Expens Account";
                    lblTo.Text = "Cash Account";

                }
            }

            if (formType == "Revenus")
            {
              //  TxtMAccountID.Text = "105";
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.Text = "Revenus Voucher";
                LblHeader.BackColor = Color.DarkRed;
                Accounttype = 1;
                transType = "سند قيد ايراد";
                EntryType = "دائن";

            }


            if (formType == "Receipt") //سندقبض
            {
              //  TxtMAccountID.Text = "102";
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.Text = "Receipt Voucher";
                LblHeader.BackColor = Color.Green;
                Accounttype = 0;
                transType = "سند قبض";
              
                EntryType = "دائن";
                if (Properties.Settings.Default.Language == "ar")
                {
                    lblFrom.Text = "الحساب النقدي";
                    lblTo.Text = "حساب العميل";
                }
                else
                {
                    lblFrom.Text = "Cash Account";
                    lblTo.Text = "Customer Account";

                }
            }

            if (formType == "Payment") //سندصرف
            {
           //    TxtMAccountID.Text = "103";
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.Text = "Payment Voucher";
                LblHeader.BackColor = Color.FromArgb(64, 64, 64);
                Accounttype = 1;
                transType = "سند صرف";
                EntryType = "مدين";
                if (Properties.Settings.Default.Language == "ar")
                {
                    lblTo.Text = "الحساب النقدي";
                    lblFrom.Text = "حساب المورد";
                }
                else
                {
                    lblTo.Text = "Cash Account";
                    lblFrom.Text = "Suplier Account";

                }
                   
            }
            await getMyRoll();

            if (string.IsNullOrEmpty(TxtEntryID.Text))
            { return;

            }

            AccountsTransactionSub obj =await accControl.GetVoucherForm(formType,Convert.ToInt32(TxtEntryID.Text),EntryType);

            var revresEntry = await accControl.GetVoucherForm(formType, Convert.ToInt32(TxtEntryID.Text), EntryType== "مدين" ? "دائن" : "مدين");
            if (obj != null && obj.TransId != 0)
            {
                mAccountId = mAccountId;
                TxtNote.Text = obj.DetailsNote;
                TxtAmount.Text = (obj.EntryType == "مدين" ? obj.FromAmount : obj.ToAmount).ToString(SD.NumDec);
                TxtDate.DateTime = obj.TransDate;
                cmbFrom.Text = (obj.EntryType == "مدين" ? obj.AccountName : revresEntry.AccountName);
                cmbTo.Text = (obj.EntryType == "مدين" ? revresEntry.AccountName : obj.AccountName);


            }

        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbFrom.Text))
            {
                DesktopAlert.Show("يجب اختيار الحساب " + "\n" + " From Account is not selected   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                cmbFrom.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbTo.Text))
            {
                DesktopAlert.Show("يجب اختيار الحساب " + "\n" + " To Account is not selected   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                cmbTo.Focus();
                return;
            }
            if (cmbFrom.Text== cmbTo.Text)
            {
                DesktopAlert.Show("لايمكن إختيار نفس الحساب " + "\n" + " Not allowed to select the same account   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                cmbTo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtAmount.Text))
            {
                DesktopAlert.Show("يجب ادخال المبلغ " + "\n" + " Ammount is not entered   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                TxtAmount.Focus();
                return;
            }

            await getToBalance();
            if (TxtAmount.Value>Convert.ToDecimal( TxtToBalance.Text))
            {
                DesktopAlert.Show("لأيسمح ترحيل مبلغ اكبر من رصيد الحساب  " + "\n" + " Ammount is not Equal Account Balance   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                return;
            }
            //
            var entryId = 0;
            if (string.IsNullOrEmpty( TxtEntryID.Text))
            {
                 entryId =await accControl.GetDefaultEntryId(formType);

            }
            else
            {
                entryId = Convert.ToInt32(TxtEntryID.Text);

              await  accControl.DeleteTransAcc(entryId, formType);
            }



            var fromAcctr = new AccountsTransactionSub()
            { 
                    EntryId = entryId,
                TransDate = TxtDate.DateTime,

                TransRefType = formType,
                    TransRefTypeAr=transType,
                    DetailsNote = TxtNote.Text,
                    AccountID = Convert.ToInt32(cmbFrom.SelectedValue),
                    AccountName = cmbFrom.Text,
                    FromAmount = Convert.ToDouble(TxtAmount.Value),// obj.balance,
                    ToAmount = 0,// obj.balance,
                    EntryType = "مدين" ,
                };
            var rslt1 = 0;
            var rslt2 = 0;

            if (fromAcctr != null)
                {
                 rslt1=    await accControl.AddToAccSubTrans(fromAcctr);
                }


            if (rslt1 > 0)
            {
                var toAcctr = new AccountsTransactionSub()
                {
                    EntryId = entryId,
                    TransDate = TxtDate.DateTime,

                    TransRefType = formType,
                    TransRefTypeAr = transType,
                    DetailsNote = TxtNote.Text,
                    AccountID = Convert.ToInt32(cmbTo.SelectedValue),
                    AccountName = cmbTo.Text,
                    FromAmount = 0,// obj.balance,
                    ToAmount = Convert.ToDouble(TxtAmount.Value),// obj.balance,
                    EntryType = "دائن",
                };
                rslt2 = await accControl.AddToAccSubTrans(toAcctr);

            }

            if (rslt2 >0)
            {
                TxtEntryID.Text = entryId.ToString();
                DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                BtnNew.Enabled = true;
                BtnSave.Enabled = false;
            } 
            else
            {
                await accControl.DeleteTransAcc(entryId, formType);
                DesktopAlert.Show("لم يتم حفظ السند تاكد من الحقول وحاول مرة أخرى1 "
                                        + "\n" + " Voucher is not correct ,Please check all fields and try again! ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                BtnSave.Enabled = true;
                BtnNew.Enabled = false;
                return;

            }



            //  BtnNew_Click(sender,e);
            //    Close();
        }

        void ClearControlls()
        {
            TxtId.Text = "0";
            TxtEntryID.Clear();
            TxtAmount.Value=0;
            TxtNote.Clear();

        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            BtnNew.Enabled = false;
            ClearControlls();
            cmbFrom.Focus();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

      //async  Task getFromBalance()
      //  {
      //      if (string.IsNullOrEmpty(cmbFrom.Text))
      //      {
      //          return;
      //      }
      //      try
      //      {
      //          var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbFrom.SelectedValue));
      //          TxtFromBalance.Text = sBalance.ToString("N2");

      //      }
      //      catch {
      //          TxtFromBalance.Text = "0";
      //          return;
      //      }

      //  }
        async Task getToBalance()
        {
            if (string.IsNullOrEmpty(cmbTo.Text))
            {
                return;
            }
            try
            {
                var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbTo.SelectedValue));

                TxtToBalance.Text = sBalance.ToString("N2");
            }
            catch
            {
                TxtToBalance.Text = "0";
                return;
            }

        }
        async Task getCurentBalance()
        {
            if (formType == "Receipt") //سندقبض
            {
                if (string.IsNullOrEmpty(cmbTo.Text))
                {
                    return;
                }
                try
                {
                    var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbTo.SelectedValue));

                    TxtRealBalance.Text = sBalance.ToString("N2");
                }
                catch
                {
                    TxtRealBalance.Text = "0";
                    return;
                }
            }

            if (formType == "Payment") //سندصرف
            {
                if (string.IsNullOrEmpty(cmbFrom.Text))
                {
                    return;
                }
                try
                {
                    var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbFrom.SelectedValue));

                    TxtRealBalance.Text = sBalance.ToString("N2");
                }
                catch
                {
                    TxtRealBalance.Text = "0";
                    return;
                }

            }
                //    TxtM
            

        }
        private async void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //await getFromBalance();
        }

        private async void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await getToBalance();

        }

        private void LblHeader_Click(object sender, EventArgs e)
        {

        }

        private async void BtnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( TxtEntryID.Text))
            {
                return;
            }
          await  getCurentBalance();

            await helper.myReportVoucher(false, false,Convert.ToInt32(TxtEntryID.Text), formType, transType, EntryType,TxtRealBalance.Text);

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}