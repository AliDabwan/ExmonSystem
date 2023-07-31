using DevComponents.DotNetBar.Controls;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem.Acc
{
    public partial class FrmCustomer : DevExpress.XtraEditors.XtraForm
    {
        ItemGoverControl accControl = new ItemGoverControl();

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmTaxValue_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //GenderComboBoxEdit.Text = "ذكر";
            //GenderComboBoxEdit.EditValue = "ذكر";
            //GenderComboBoxEdit.SelectedIndex = 0;

            timerLoad.Start();

        }

        async Task GetLoad()
        {
            GridView gridView1 = DgvRecords.MainView as GridView;

            customerBindingSource.DataSource = await accControl.GetAllCustomers();//db.itemCategories.ToList();

            FirstNameTextEdit.Enabled = true;
            layoutControlGroup1.Enabled = true;

            customerBindingSource.Add(new Customer());
            customerBindingSource.MoveLast();
            FirstNameTextEdit.Focus();
            GenderComboBoxEdit.EditValue = "ذكر";
            GenderComboBoxEdit.SelectedIndex = 0;

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
                FirstNameTextEdit.Enabled = true;
                layoutControlGroup1.Enabled = true;

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            layoutControlGroup1.Enabled = true;
            FirstNameTextEdit.Enabled = true;
            BtnSave.Enabled = true;
            BtnAdd.Enabled = false;
            //GenderComboBoxEdit.Text = "ذكر";
            GenderComboBoxEdit.EditValue = "ذكر";
            GenderComboBoxEdit.SelectedIndex = 0;
            customerBindingSource.MoveLast();
            Customer obj = customerBindingSource.Current as Customer;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    FirstNameTextEdit.Focus();
                }
                else
                {
                    customerBindingSource.Add(new Customer());
                    customerBindingSource.MoveLast();
                    FirstNameTextEdit.Focus();
                }
            }

        }

        private async void  BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextEdit.Text))
            {
                DesktopAlert.Show("الحقل الاسم الاول فارغ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                FirstNameTextEdit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(SecondNameTextEdit.Text))
            {
                DesktopAlert.Show("الحقل الاسم الثاني فارغ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                SecondNameTextEdit.Focus();

                return;
            }
            if (string.IsNullOrEmpty(PassportNoTextEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ رقم الجواز ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                PassportNoTextEdit.Focus();
                return;
            }
            if (PassportNoTextEdit.Text=="0")
            {
                DesktopAlert.Show("الحقل فارغ رقم الجواز ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                PassportNoTextEdit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(LastNameTextEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ اسم الجد ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                LastNameTextEdit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(FamilyNameTextEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ اللقب ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                FamilyNameTextEdit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(EnNameTextEdit.Text))
            {
                DesktopAlert.Show("الحقل الاسم واللقب بالانكليزي فارغ ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                EnNameTextEdit.Focus();
                return;
            }



            if (string.IsNullOrEmpty(GenderComboBoxEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ الجنس ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                GenderComboBoxEdit.Focus();
                return;
            }


            if (string.IsNullOrEmpty(IssuedDateDateEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ تاريخ الاصدار ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                IssuedDateDateEdit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ExpierDateDateEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ تاريخ الصلاحية ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                ExpierDateDateEdit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(BirthDateDateEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ تاريخ التولد ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                BirthDateDateEdit.Focus();
                return;
            }

            if (IssuedDateDateEdit.DateTime.Date<DateTime.Now.AddYears(-20))
            {
                DesktopAlert.Show("يرجى ادخال تاريخ الاصدار ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                IssuedDateDateEdit.Focus();
                return;
            }
            if (ExpierDateDateEdit.DateTime.Date < DateTime.Now.AddYears(-23))
            {
                DesktopAlert.Show("يرجى ادخال تاريخ الصلاحية ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                ExpierDateDateEdit.Focus();
                return;
            }
            if (BirthDateDateEdit.DateTime.Date < DateTime.Now.AddYears(-100))
            {
                DesktopAlert.Show("يرجى ادخال تاريخ التولد ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                BirthDateDateEdit.Focus();
                return;
            }

            if (ExpierDateDateEdit.DateTime.Date < IssuedDateDateEdit.DateTime.Date)
            {
                DesktopAlert.Show("لايقبل تاريخ الصلاحية قبل تاريخ الاصدار ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                ExpierDateDateEdit.Focus();
                return;
            }


            BtnSave.Enabled = false;

            using (MyDbContext db = new MyDbContext())
            {
                Customer obj = customerBindingSource.Current as Customer;
                if (obj != null)
                {
                    if (db.Entry<Customer>(obj).State == EntityState.Detached)
                        db.Set<Customer>().Attach(obj);

                    obj.FullName = FirstNameTextEdit.Text + " " + SecondNameTextEdit.Text + " " + LastNameTextEdit.Text + " " + FamilyNameTextEdit.Text;
                    if (obj.Id == 0)
                    {
                        db.Entry<Customer>(obj).State = EntityState.Added;

                    }
                    else
                    {
                        obj.LastUpdateDate = DateTime.Now;
                        obj.LastUpdateUserId = Program.userId;
                        db.Entry<Customer>(obj).State = EntityState.Modified;

                    }
                    var rslt=await  db.SaveChangesAsync();
                    //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
                    if (rslt>0)
                    {
                        DgvRecords.Refresh();
                        FirstNameTextEdit.Enabled = false;
                        layoutControlGroup1.Enabled = false;
                        customerBindingSource.ResetBindings(false);
                        DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                        FirstNameTextEdit.Enabled = false;
                        layoutControlGroup1.Enabled = false;
                        BtnAdd_Click(sender, e);
                    }else
                    {
                        BtnSave.Enabled = true;
                        BtnAdd.Enabled = false;
                    }
                  

                }
            }
        }
        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(FirstNameTextEdit.Text))
            //{
            //    DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

            //    return;
            //}

            if (gridView1.RowCount <= 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " , eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            Customer obj = customerBindingSource.Current as Customer;
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


                    if (obj != null)
                    {
                        var myOrders = await accControl.GetOrders(obj.Id);
                        if (myOrders.Count() > 0)
                        {
                            DesktopAlert.Show("لايمكن حذف هذه الجواز ! يوجد طلبات مرتبطة ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                            return;
                        }
                        if (db.Entry<Customer>(obj).State == EntityState.Detached)
                            db.Set<Customer>().Attach(obj);
                        db.Entry<Customer>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        customerBindingSource.RemoveCurrent();
                        FirstNameTextEdit.Enabled = false;
                        layoutControlGroup1.Enabled = false;
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
            if (e.KeyCode==Keys.Enter)
            {
                if (BtnSave.Enabled)
                {
                    BtnSave_Click(sender, e);
                }
            }
        }

        private void FirstNameTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                    BtnSave.Focus();
                
            }
        }

        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
                Customer obj = customerBindingSource.Current as Customer;
            if (obj != null)
            {
              //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
            }
            }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AttachmeedFilePictureEdit.LoadImage();
            AttachmeedFilePictureEdit.ShowImageEditorDialog();
        


        }

        private void AttachmeedFilePictureEdit_Properties_PopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e)
        {
            try{e.PopupMenu.Items["Load"].Caption = "تحميل صورة من ملف";}catch {}
            try{e.PopupMenu.Items["Edit"].Caption = "تعديل الصورة";}catch {}
            try{e.PopupMenu.Items["Save"].Caption = "حفظ الصورة";}catch {}
            try{e.PopupMenu.Items["Zoom"].Caption = "تكبير الصورة";}catch {}
            try{e.PopupMenu.Items["Take Picture from Camera"].Caption = "التقاط صورة";}catch {}
        }

        private void AttachmeedFilePictureEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BirthDateDateEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BtnSave.Focus();

            }

        }

        private void EnNameTextEdit_Enter(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void EnNameTextEdit_Leave(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("ar");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void FirstNameTextEdit_Enter(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("ar");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void EnNameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void PassportNoTextEdit_Enter(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void PassportNoTextEdit_Leave(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("ar");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void DgvRecords_Click(object sender, EventArgs e)
        {

        }
    }
}