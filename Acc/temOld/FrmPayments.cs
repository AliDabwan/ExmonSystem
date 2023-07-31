using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using TAWSEEL.Controls;
using TAWSEEL.Models;
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
using System.IO;
using TAWSEEL.RPT;
using DevExpress.XtraReports.UI;

namespace TAWSEEL.Form
{
    public partial class FrmPayments : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        int Accounttype { get; set; }
        byte[] byteimag = new byte[0];
        string AttachmentFile = "", AttachmentName = "", AttachmentType = "";
        public string formType { get; set; }
         string transType { get; set; }
         string EntryType { get; set; }

        AccountControl accControl = new AccountControl();
        public int mAccountId { get; set; }
        public FrmPayments()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //    var frm = new FrmPaymentList();
            //    frm.Show();
        }
        public List<ExampleFrom> elistFrom = new List<ExampleFrom>();
        public class ExampleFrom
        {
            public int Id { get; set; }
            public int AccountNo { get; set; }

            public string AccountName { get; set; }
            public string Phone { get; set; }
            public string TaxNumber { get; set; }

        }
        public List<ExampleTo> elistTo = new List<ExampleTo>();
        public class ExampleTo
        {
            public int Id { get; set; }
            public int AccountNo { get; set; }

            public string AccountName { get; set; }
            public string Phone { get; set; }
            public string TaxNumber { get; set; }

        }
        async Task getAccountsName()
        {
            if (formType == "Payment")
            {
                //cmbFrom.DataSource = await accControl.GetAllAccount(mAccountId);//db.itemCategories.ToList();
                //cmbTo.DataSource =Program.userCashAccountId==0? await accControl.GetAllAccount(101): await accControl.Getaccounts(Program.logedUser.CashAccountId);//db.itemCategories.ToList();



                var xx = await accControl.GetAllAccount(mAccountId);
                foreach (var item in xx)
                {
                    elistFrom.Add(new ExampleFrom() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbFrom.Properties.DataSource = elistFrom;
                cmbFrom.Properties.DisplayMember = "AccountName";
                cmbFrom.Properties.ValueMember = "Id";


                var xxto = Program.userCashAccountId == 0 ? await accControl.GetAllAccount(101) : await accControl.Getaccounts(Program.logedUser.CashAccountId);
                foreach (var item in xxto)
                {
                    elistTo.Add(new ExampleTo() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbTo.Properties.DataSource = elistTo;
                cmbTo.Properties.DisplayMember = "AccountName";
                cmbTo.Properties.ValueMember = "Id";






                //cmbFrom.DisplayMember = "AccountName";
                //cmbFrom.ValueMember = "Id";
                //cmbTo.DisplayMember = "AccountName";
                //cmbTo.ValueMember = "Id";

            }
            else if (formType == "Receipt") //سندقبض
            {
                //cmbFrom.DataSource = Program.userCashAccountId == 0 ? await accControl.GetAllAccount(101) : await accControl.Getaccounts(Program.logedUser.CashAccountId);//db.itemCategories.ToList();
                //cmbTo.DataSource = await accControl.GetAllAccount(mAccountId);//db.itemCategories.ToList();
                //                                                              //cmbFrom.DisplayMember = "AccountName";
                //                                                              //cmbFrom.ValueMember = "Id";
                                                                              //cmbTo.DisplayMember = "AccountName";
                                                                              //cmbTo.ValueMember = "Id";



                var xx = Program.userCashAccountId == 0 ? await accControl.GetAllAccount(101) : await accControl.Getaccounts(Program.logedUser.CashAccountId);
                foreach (var item in xx)
                {
                    elistFrom.Add(new ExampleFrom() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbFrom.Properties.DataSource = elistFrom;
                cmbFrom.Properties.DisplayMember = "AccountName";
                cmbFrom.Properties.ValueMember = "Id";


                var xxto = await accControl.GetAllAccount(mAccountId);
                foreach (var item in xxto)
                {
                    elistTo.Add(new ExampleTo() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbTo.Properties.DataSource = elistTo;
                cmbTo.Properties.DisplayMember = "AccountName";
                cmbTo.Properties.ValueMember = "Id";





            }
            else if (formType == "DailEntry")
            {
                //cmbFrom.DataSource = await accControl.Getaccounts(Properties.Settings.Default.PropBAccountCash);//db.itemCategories.ToList();
                //cmbTo.DataSource = await accControl.Getaccounts(Program.logedUser.CashAccountId);//db.itemCategories.ToList();
                //                                                                                 //cmbFrom.DisplayMember = "AccountName";
                //                                                                                 //cmbFrom.ValueMember = "Id";
                                                                                                 //cmbTo.DisplayMember = "AccountName";
                                                                                                 //cmbTo.ValueMember = "Id";





                var xx = await accControl.Getaccounts(Properties.Settings.Default.PropBAccountCash);
                foreach (var item in xx)
                {
                    elistFrom.Add(new ExampleFrom() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbFrom.Properties.DataSource = elistFrom;
                cmbFrom.Properties.DisplayMember = "AccountName";
                cmbFrom.Properties.ValueMember = "Id";


                var xxto = await accControl.Getaccounts(Program.logedUser.CashAccountId);
                foreach (var item in xxto)
                {
                    elistTo.Add(new ExampleTo() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbTo.Properties.DataSource = elistTo;
                cmbTo.Properties.DisplayMember = "AccountName";
                cmbTo.Properties.ValueMember = "Id";




                cmbTo.EditValue = Program.logedUser.CashAccountId;


            }
            else
            {
                //cmbFrom.DataSource = await accControl.GetAllAccount(mAccountId);//db.itemCategories.ToList();
                //cmbTo.DataSource = Program.userCashAccountId == 0 ? await accControl.GetAllAccount(101) : await accControl.Getaccounts(Program.logedUser.CashAccountId);//db.itemCategories.ToList();
                //                                                                                                                                                        //cmbFrom.DisplayMember = "AccountName";
                                                                                                                                                                        //cmbFrom.ValueMember = "Id";
                                                                                                                                                                        //cmbTo.DisplayMember = "AccountName";
                                                                                                                                                                        //cmbTo.ValueMember = "Id
                                                                                                                                                                        //



                var xx = await accControl.GetAllAccount(mAccountId);
                foreach (var item in xx)
                {
                    elistFrom.Add(new ExampleFrom() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbFrom.Properties.DataSource = elistFrom;
                cmbFrom.Properties.DisplayMember = "AccountName";
                cmbFrom.Properties.ValueMember = "Id";


                var xxto = Program.userCashAccountId == 0 ? await accControl.GetAllAccount(101) : await accControl.Getaccounts(Program.logedUser.CashAccountId);
                foreach (var item in xxto)
                {
                    elistTo.Add(new ExampleTo() { Id = item.Id, AccountNo = item.AccountID, AccountName = item.AccountName, Phone = item.phone, TaxNumber = item.taxnumber });

                }

                cmbTo.Properties.DataSource = elistTo;
                cmbTo.Properties.DisplayMember = "AccountName";
                cmbTo.Properties.ValueMember = "Id";





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

                LblHeader.Text = "Cash Transfeer";
                LblHeader.BackColor = Color.Gray;
                Accounttype = 0;
                transType = "قيد يومي";
                if (Properties.Settings.Default.Language == "ar")
                {
                    lblFrom.Text = "الحساب النقدي";
                    lblTo.Text = "حسابي";
                }
                else
                {
                    lblFrom.Text = "Cash Account";
                    lblTo.Text = "My Account";

                }
                await getToBalance();
                TxtNote.Text = "اقفال الحساب النقدي لليوزر :  "+Program.logedUser.FullName+" تاريخ : "+TxtDate.DateTime.Date.ToString("dd/MM/yyyy");
                TxtNote.ReadOnly = true;
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
                cmbFrom.ItemIndex = 0;
                cmbTo.ItemIndex = 0;
                LblHeader.Text = "Expens Voucher";
                LblHeader.BackColor = Color.Olive;
                Accounttype = 0;
                transType = "سند قيد مصروف";
                EntryType = "مدين";
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "سند مصاريف";

                    lblFrom.Text = "حساب المصروفات";
                    lblTo.Text = "الحساب النقدي";
                }
                else
                {
                    LblHeader.Text = "Expens Voucher";

                    lblFrom.Text = "Expens Account";
                    lblTo.Text = "Cash Account";

                }
                //if (!cmbFrom.Text.Contains("ضريبة"))
                //{
                //    lblTax.Visible = true;
                //    TxtTax.Visible = true;
                //}

            }

            if (formType == "Revenus")
            {
              //  TxtMAccountID.Text = "105";
                TxtMAccountID.Text = mAccountId.ToString();

                LblHeader.Text = "Revenus Voucher";
                LblHeader.BackColor = Color.SteelBlue;
                Accounttype = 1;
                transType = "سند قيد ايراد";
                EntryType = "دائن";
                if (Properties.Settings.Default.Language == "ar")
                {
                    LblHeader.Text = "سند ايرادات";


                }
                else
                {



                }
                }


            if (formType == "Receipt") //سندقبض
            {
              //  TxtMAccountID.Text = "102";

                TxtMAccountID.Text = mAccountId.ToString();
                cmbFrom.ItemIndex = 0;
                cmbTo.ItemIndex = 0;
                LblHeader.BackColor = Color.Green;
                Accounttype = 0;
                transType = "سند قبض";
              
                EntryType = "دائن";
                lblFrom.Visible = false;
                cmbFrom.Visible = false;
                TxtFromBalance.Visible = false;
                if (Properties.Settings.Default.Language == "ar")
                {
                    lblFrom.Text = "الحساب النقدي";
                    lblTo.Text = "حساب المرسل";
                    LblHeader.Text = PaymentType;

                }
                else
                {
                    lblFrom.Text = "Cash Account";
                    lblTo.Text = "Customer Account";
                    LblHeader.Text = "Receipt Voucher";

                }
            }

          
            if (formType == "Payment") //سندصرف
            {
                //    TxtMAccountID.Text = "103";
                TxtMAccountID.Text = mAccountId.ToString();
                cmbFrom.ItemIndex = 0;
                cmbTo.ItemIndex = 0;
                LblHeader.BackColor = Color.FromArgb(64, 64, 64);
                Accounttype = 1;
                lblFrom.Visible = false;
                cmbFrom.Visible = false;
                TxtFromBalance.Visible = false;
                transType = "سند صرف";
                EntryType = "مدين";
                if (Properties.Settings.Default.Language == "ar")
                {
                    lblTo.Text = "الحساب النقدي";
                    lblTo.Text = "حساب المرسل";
                    LblHeader.Text = PaymentType;

                }
                else
                {
                    lblTo.Text = "Cash Account";
                    lblFrom.Text = "Suplier Account";
                    LblHeader.Text = "Payment Voucher";

                }

            }
            this.Text = LblHeader.Text;
            await getMyRoll();
            cmbFrom.Properties.PopulateColumns();
            //DesktopAlert.Show(lookUpEdit1.Properties.Columns.Count + "");
            if (cmbFrom.Properties.Columns.Count > 0)
            {
                cmbFrom.Properties.Columns[0].Visible = false;
                cmbFrom.Properties.Columns[1].Visible = false;
                cmbFrom.Properties.Columns[4].Visible = false;
                if (Properties.Settings.Default.Language == "ar")
                {
                    cmbFrom.Properties.Columns[1].Caption = "رقم الحساب";
                    cmbFrom.Properties.Columns[2].Caption = "اسم الحساب";
                    cmbFrom.Properties.Columns[3].Caption = "الجوال";


                }
            }

            cmbTo.Properties.PopulateColumns();
            //DesktopAlert.Show(lookUpEdit1.Properties.Columns.Count + "");
            if (cmbTo.Properties.Columns.Count > 0)
            {
                cmbTo.Properties.Columns[0].Visible = false;
                cmbTo.Properties.Columns[1].Visible = false;
                cmbTo.Properties.Columns[4].Visible = false;
                if (Properties.Settings.Default.Language == "ar")
                {
                    cmbTo.Properties.Columns[1].Caption = "رقم الحساب";
                    cmbTo.Properties.Columns[2].Caption = "اسم الحساب";
                    cmbTo.Properties.Columns[3].Caption = "الجوال";


                }
            }
            if (string.IsNullOrEmpty(TxtEntryID.Text))
            { return;

            }

            AccountsTransactionSub obj =await accControl.GetVoucherForm(formType,Convert.ToInt32(TxtEntryID.Text),EntryType);

            var revresEntry = await accControl.GetVoucherForm(formType, Convert.ToInt32(TxtEntryID.Text), EntryType== "مدين" ? "دائن" : "مدين");
            if (obj != null && obj.TransId != 0)
            {
                mAccountId = mAccountId;
                TxtRef.Text = obj.TransRefNo;
                TxtNote.Text = obj.DetailsNote;
                TxtAmount.Text = (obj.EntryType == "مدين" ? obj.FromAmount : obj.ToAmount).ToString(SD.NumDec);
                TxtDate.DateTime = obj.TransDate;
                //cmbFrom.Text = (obj.EntryType == "مدين" ? obj.AccountName : revresEntry.AccountName);
                //cmbTo.Text = (obj.EntryType == "مدين" ? revresEntry.AccountName : obj.AccountName);
                cmbFrom.EditValue = (obj.EntryType == "مدين" ? obj.AccountID : revresEntry.AccountID);
                cmbTo.EditValue = (obj.EntryType == "مدين" ? revresEntry.AccountID : obj.AccountID);

                if (obj.AttachmeedFile != null)
                {
                    //DesktopAlert.Show(myBill.AttachmeedFile.ToString());
                    byteimag = (byte[])obj.AttachmeedFile;

                }
                if (!string.IsNullOrEmpty(obj.AttachmentType))
                {
                    AttachmentType = obj.AttachmentType;
                    AttachmentName = obj.AttachmentName;

                    lblAtatch.Visible = true;
                    lblAtatch.ToolTip = AttachmentName;
                    //DesktopAlert.Show(AttachmentType);

                }
                else
                {
                    AttachmentFile = "";
                    AttachmentName = "";

                    AttachmentType = "";
                    lblAtatch.Visible = false;
                }

            }
            if (formType == "Expens")
            {
                // TxtMAccountID.Text = "104";
              
                if (cmbFrom.Text.Contains("ضريبة"))
                {
                    lblTax.Visible = false;
                    TxtTax.Visible = false;
                }

            }
        }
        public string PaymentType { get; set; } = "دفعة مقدم";
        async Task<bool> addtax()
        {

            var entryId = 0;
            if (string.IsNullOrEmpty(TxtEntryID.Text))
            {
                entryId = await accControl.GetDefaultEntryId(formType);

            }
            else
            {
                entryId = Convert.ToInt32(TxtEntryID.Text);

                await accControl.DeleteTransAcc(entryId, formType);
            }


            var note = "ضريبة على اجمالي مصروفات : "+TxtAmount.Text+" ( حساب "+cmbFrom.Text+") "+TxtNote.Text;
            var fromAcctr = new AccountsTransactionSub()
            {
                EntryId = entryId,
                TransDate = TxtDate.DateTime,

                TransRefType = formType,
                TransRefTypeAr = transType,
                TransRefNo = TxtRef.Text,
                DetailsNote = note,
                AccountID =Properties.Settings.Default.PropBExpensesTaxAccount,
                AccountName ="ضريبة المصروفات",
                FromAmount = Convert.ToDouble(TxtTax.Value),// obj.balance,
                ToAmount = 0,// obj.balance,
                EntryType = "مدين",
            };
            var rslt1 = 0;
            var rslt2 = 0;

            if (fromAcctr != null)
            {
                rslt1 = await accControl.AddToAccSubTrans(fromAcctr);
            }
            else
            {
                return false;
            }


            if (rslt1 > 0)
            {
                var toAcctr = new AccountsTransactionSub()
                {
                    EntryId = entryId,
                    TransDate = TxtDate.DateTime,

                    TransRefType = formType,
                    TransRefTypeAr = transType,
                    TransRefNo = TxtRef.Text,
                    DetailsNote = note,
                    AccountID = Convert.ToInt32(cmbTo.EditValue),
                    AccountName = cmbTo.Text,
                    FromAmount = 0,// obj.balance,
                    ToAmount = Convert.ToDouble(TxtTax.Value),// obj.balance,
                    EntryType = "دائن",
                };
                rslt2 = await accControl.AddToAccSubTrans(toAcctr);
                if (rslt2>0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {


            int cfromId = 0;
            int ctoId = 0;



            try
            {
                var cfrom = cmbFrom.GetSelectedDataRow() as ExampleFrom;
                if (cfrom != null)
                {
                    cfromId = cfrom.Id;

                }

            }
            catch
            {

                cfromId = 0;
            }
            if (cfromId<=0)
            {
                DesktopAlert.Show("يجب اختيار الحساب " + "\n" + " From Account is not selected   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                cmbFrom.Focus();
            }
            try
            {
                var cto = cmbTo.GetSelectedDataRow() as ExampleTo;
                if (cto != null)
                {
                    ctoId = cto.Id;

                }

            }
            catch
            {

                ctoId = 0;
            }
            if (ctoId <= 0)
            {
                DesktopAlert.Show("يجب اختيار الحساب " + "\n" + " To Account is not selected   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                cmbTo.Focus();
            }
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
            if (string.IsNullOrEmpty(TxtNote.Text))
            {
                TxtNote.Text = "";


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
                    TransRefNo = TxtRef.Text,
                    DetailsNote = TxtNote.Text,
                    AccountID = Convert.ToInt32(cmbFrom.EditValue),
                    AccountName = cmbFrom.Text,
                    FromAmount = Convert.ToDouble(TxtAmount.Value),// obj.balance,
                    ToAmount = 0,// obj.balance,
                    EntryType = "مدين" ,

             

        };
            var rslt1 = 0;
            var rslt2 = 0;

            if (fromAcctr != null)
                {


                fromAcctr.AttachmentType = AttachmentType;
                fromAcctr.AttachmentName = AttachmentName;
                fromAcctr.AttachmeedFile = AttachInvoiceFile(AttachmentFile);
                rslt1 =    await accControl.AddToAccSubTrans(fromAcctr);
                }


            if (rslt1 > 0)
            {
                var toAcctr = new AccountsTransactionSub()
                {
                    EntryId = entryId,
                    TransDate = TxtDate.DateTime,

                    TransRefType = formType,
                    TransRefTypeAr = transType,
                    TransRefNo = TxtRef.Text,
                    DetailsNote = TxtNote.Text,
                    AccountID = Convert.ToInt32(cmbTo.EditValue),
                    AccountName = cmbTo.Text,
                    FromAmount = 0,// obj.balance,
                    ToAmount = Convert.ToDouble(TxtAmount.Value),// obj.balance,
                    EntryType = "دائن",
                };
                if (toAcctr != null)
                {
                    toAcctr.AttachmentType = AttachmentType;
                    toAcctr.AttachmentName = AttachmentName;
                    toAcctr.AttachmeedFile = AttachInvoiceFile(AttachmentFile);

                    rslt2 = await accControl.AddToAccSubTrans(toAcctr);
                }
              

            }

            if (rslt2 >0)
            {

                if (formType == "Expens")
                {
                    if (TxtTax.Value > 0)
                    {


                        if (!cmbFrom.Text.Contains("ضريبة"))
                        {
                            await addtax();


                        }
                    }

                }


                    TxtEntryID.Text = entryId.ToString();
                DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);


                helper.Xmlcreatedb_Voucher(entryId, entryId, formType);

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
            TxtRef.Clear();
            TxtNote.Clear();
            AttachmentType = "";
            AttachmentFile = "";
            AttachmentName = "";
            byteimag = null;
            lblAtatch.Visible = false;
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            BtnNew.Enabled = false;
            BtnSave.Enabled = true;
            ClearControlls();
            cmbFrom.Focus();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

      async  Task getFromBalance()
        {
            if (string.IsNullOrEmpty(cmbFrom.Text))
            {
                return;
            }
            try
            {
                var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbFrom.EditValue));
                TxtFromBalance.Text = sBalance.ToString(SD.NumDec);

            }
            catch {
                TxtFromBalance.Text = "0";
                return;
            }

        }
        async Task getToBalance()
        {
            if (string.IsNullOrEmpty(cmbTo.Text))
            {
                return;
            }
            try
            {
                var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbTo.EditValue));

                TxtToBalance.Text = sBalance.ToString(SD.NumDec);
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
                    var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbTo.EditValue));

                    TxtRealBalance.Text = sBalance.ToString(SD.NumDec);
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
                    var sBalance = await accControl.GetAccountsSubBalance(Convert.ToInt32(cmbFrom.EditValue));

                    TxtRealBalance.Text = sBalance.ToString(SD.NumDec);
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
            await getFromBalance();
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

        private async void TxtAmount_ValueChanged(object sender, EventArgs e)
        {

            if (TxtAmount.Value>=0)
            {
                try
                {
                    var myacc = await accControl.Getaccount(Convert.ToInt32(cmbFrom.EditValue));
                    if (!myacc.IsHasTax)
                    {
                        return;
                    }
                    lblTax.Text = "Tax= ";
                    TxtTax.Value= TxtAmount.Value * Properties.Settings.Default.PropValueExpensesTax / 100;

                }
                catch
                {

                    return; 
                }
            }
        }

        private void btnAtatch_Click(object sender, EventArgs e)
        {
            opFile.Title = "Select a File";
            opFile.DefaultExt = ".pdf";
            opFile.Filter = "ملفات | *.jpg; *.png; *.bmp; *.docx; *.pdf";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                AttachmentFile = opFile.FileName;
                AttachmentType = Path.GetExtension(AttachmentFile);
                AttachmentName = Path.GetFileNameWithoutExtension(AttachmentFile);
                if (AttachmentType != ".pdf" && AttachmentType != ".PDF" && AttachmentType != ".docx" && AttachmentType != ".jpg" && AttachmentType != ".JPG"
                    && AttachmentType != ".png" && AttachmentType != ".PNG")
                {
                    DesktopAlert.Show("الملف المرفق غير صحيح"
                                                         + "\n" + "Invalid File ! ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                    return;
                }
                lblAtatch.Visible = true;

            }

        }
        void DisplayAttachment(string type)
        {
            xtraFolderBrowserDialog1.Description = "إختر مجلد لإستخراج فاتورة المشتريات المرفقة اليه";
            if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string PATHH = "";
                PATHH = xtraFolderBrowserDialog1.SelectedPath;

                FileStream fs = new FileStream(PATHH + @"\" + AttachmentName + type, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(byteimag);
                bw.Close();
                DesktopAlert.Show("تم إستخراج الملف المرفق إلى المسار" + PATHH
                                                                        + "\n" + "File Extracted to " + PATHH, eDesktopAlertColor.Blue, eAlertPosition.TopRight);

            }
        }

        private void desingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraReport rd = RptVoucher.FromFile(System.Windows.Forms.Application.StartupPath + @"\rpt\" + "RptVoucher.repx", true);

            ReportDesignTool printTool = new ReportDesignTool(rd);
            printTool.ShowRibbonDesignerDialog();
            DevExpress.DataAccess.Sql.SqlDataSource ds = rd.DataSource as DevExpress.DataAccess.Sql.SqlDataSource;
            ds.Dispose();
        }

        private async void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            await getFromBalance();

        }

        private async void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            await getToBalance();

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void lblAtatch_Click(object sender, EventArgs e)
        {
            if (AttachmentType == string.Empty)
            {
                DesktopAlert.Show("لاتوجد ملفات مرفقة"
                                                                     + "\n" + "No Attached Files ! ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                return;
            }
            DisplayAttachment(AttachmentType);
        }
        byte[] AttachInvoiceFile(string FileName)
        {
            if (FileName == string.Empty)
            {
                return byteimag;
            }
            FileStream fstream = File.OpenRead(FileName);
            byte[] contents = new byte[fstream.Length];
            fstream.Read(contents, 0, (int)fstream.Length);
            fstream.Close();
            byteimag = contents;
            return contents;
        }
    }
}