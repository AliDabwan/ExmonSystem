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
    public partial class FrmExCompany : DevExpress.XtraEditors.XtraForm
    {
        ItemGoverControl accControl = new ItemGoverControl();

        public FrmExCompany()
        {
            InitializeComponent();
        }
        public List<ItemGover> listGovers = new List<ItemGover>();
        public List<District> listDistricts = new List<District>();
        public List<Driver> listDriver = new List<Driver>();


        async Task  GetLoadFields()
        {
            try
            {
                var mySubscribers = await accControl.GetAllSubscribers();
                foreach (var item in mySubscribers)
                {
                    SubscrberIdRadioGroup.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem { Value = item.Id, Description = item.Name, Enabled = true });
                }
                SubscrberIdRadioGroup.SelectedIndex = 0;




            }
            catch 
            {

                
            }
          
            var xx = await accControl.GetAllItemGover();
            //listGovers.Add(new ItemGover() { Id = 0, Name = "الكل" });

            foreach (var item in xx)
            {
                listGovers.Add(new ItemGover() { Id = item.Id, Name = item.Name});

            }
            GoverNameLookUpEdit.Properties.DataSource = listGovers;
            GoverNameLookUpEdit.Properties.DisplayMember = "Name";
            GoverNameLookUpEdit.Properties.ValueMember = "Id";
            GoverNameLookUpEdit.Properties.PopulateColumns();
            GoverNameLookUpEdit.Properties.Columns[2].Visible = false;
            GoverNameLookUpEdit.Properties.Columns[3].Visible = false;


            var xxDis = await accControl.GetAllDistricts();
            //listDistricts.Add(new District() { Id = 0, Name = "الكل" });

            foreach (var item in xxDis)
            {
                listDistricts.Add(new District() { Id = item.Id, Name = item.Name });

            }
            //DesktopAlert.Show("district:" + listDistricts.Count);

            DistrictNameLookUpEdit.Properties.DataSource = listDistricts;
            DistrictNameLookUpEdit.Properties.DisplayMember = "Name";
            DistrictNameLookUpEdit.Properties.ValueMember = "Id";
            DistrictNameLookUpEdit.Properties.PopulateColumns();
            DistrictNameLookUpEdit.Properties.Columns[2].Visible = false;




            var xxDri = await accControl.GetAllDrivers();
            //listDriver.Add(new Driver() { Id = 0, Name = "الكل" });

            foreach (var item in xxDri)
            {
                listDriver.Add(new Driver() { Id = item.Id, Name = item.Name });

            }
            //DesktopAlert.Show("driver:" + listDriver.Count);

            DriverIdLookUpEdit.Properties.DataSource = listDriver;
            DriverIdLookUpEdit.Properties.DisplayMember = "Name";
            DriverIdLookUpEdit.Properties.ValueMember = "Id";
            DriverIdLookUpEdit.Properties.PopulateColumns();
            DriverIdLookUpEdit.Properties.Columns[2].Visible = false;


        }
        public int Id { get; set; } = 0;
        private async void FrmTaxValue_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            await GetLoadFields();
            if (Id>0)
            {
                var myexco = await accControl.GetExCompany(Id);
                exCompanyBindingSource.DataSource = myexco;
                NameTextEdit.Enabled = true;
                layoutControlGroup1.Enabled = true;
                return;
            }
            timerLoad.Start();
        }
       
        async Task GetLoad()
        {
            GridView gridView1 = DgvRecords.MainView as GridView;

            exCompanyBindingSource.DataSource = await accControl.GetAllExCompanies();//db.itemCategories.ToList();

            NameTextEdit.Enabled = true;
            layoutControlGroup1.Enabled = true;

            exCompanyBindingSource.Add(new ExCompany());
            exCompanyBindingSource.MoveLast();
            NameTextEdit.Focus();

            SubscrberIdRadioGroup.SelectedIndex = 0;


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
                NameTextEdit.Enabled = true;
                layoutControlGroup1.Enabled = true;

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            layoutControlGroup1.Enabled = true;
            NameTextEdit.Enabled = true;
            BtnSave.Enabled = true;
            BtnAdd.Enabled = false;
            SubscrberIdRadioGroup.SelectedIndex = 0;
            exCompanyBindingSource.MoveLast();
            ExCompany obj = exCompanyBindingSource.Current as ExCompany;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    NameTextEdit.Focus();
                }
                else
                {
                    exCompanyBindingSource.Add(new ExCompany());
                    exCompanyBindingSource.MoveLast();
                    NameTextEdit.Focus();
                }
            }

        }

        private async void  BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextEdit.Text))
            {
                DesktopAlert.Show("الحقل الاسم فارغ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                NameTextEdit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(GoverNameLookUpEdit.Text))
            {
                DesktopAlert.Show("الحقل اسم المحافظة فارغ ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                GoverNameLookUpEdit.Focus();

                return;
            }
            if (string.IsNullOrEmpty(DistrictNameLookUpEdit.Text))
            {
                DesktopAlert.Show("الحقل المنطقة فارغ ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                DistrictNameLookUpEdit.Focus();

                return;
            }
            if (string.IsNullOrEmpty(DriverIdLookUpEdit.Text))
            {
                DesktopAlert.Show("الحقل السائق فارغ ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                DriverIdLookUpEdit.Focus();
                return;
            }  if (SubscrberIdRadioGroup.SelectedIndex< 0)
            {
                DesktopAlert.Show("يجب اختيار نوع الاشتراك ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                SubscrberIdRadioGroup.Focus();
                return;
            }
            if (string.IsNullOrEmpty(PriceForPassportCalcEdit.Text))
            {
                DesktopAlert.Show("الحقل سعر الجواز فارغ ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                DesktopAlert.Show("يجب اختيار نوع الاشتراك أو تحديد سعر الجواز الواحد ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                PriceForPassportCalcEdit.Focus();
                return;
            }
            if (Convert.ToDouble(PriceForPassportCalcEdit.Text)<=0)
            {
                DesktopAlert.Show("الحقل سعر الجواز لايقبل 0 ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                DesktopAlert.Show("يجب اختيار نوع الاشتراك أو تحديد سعر الجواز الواحد ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                PriceForPassportCalcEdit.Focus();
                return;

            }
            BtnSave.Enabled = false;

            using (MyDbContext db = new MyDbContext())
            {
                ExCompany obj = exCompanyBindingSource.Current as ExCompany;
                if (obj != null)
                {
                    obj.Subscriber = null;
                    obj.Driver = null;
                    obj.BillCreatedUser = null;

                    if (db.Entry<ExCompany>(obj).State == EntityState.Detached)
                        db.Set<ExCompany>().Attach(obj);


                    obj.PriceForPassport = Convert.ToDouble(PriceForPassportCalcEdit.Text);

                    if (obj.Id == 0)
                    {
                        db.Entry<ExCompany>(obj).State = EntityState.Added;
                    }
                    else
                    {
                       

                        obj.LastUpdateDate = DateTime.Now;
                        obj.LastUpdateUserId = Program.userId;
                        db.Entry<ExCompany>(obj).State = EntityState.Modified;
                    }
                    var rslt=await  db.SaveChangesAsync();
                    //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
                    if (rslt>0)
                    {
                        DgvRecords.Refresh();
                        NameTextEdit.Enabled = false;
                        layoutControlGroup1.Enabled = false;
                        
                        exCompanyBindingSource.ResetBindings(false);
                        gridView1.RefreshData();
                        DesktopAlert.Show("تم الحفظ بنجاح ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                        NameTextEdit.Enabled = false;
                        layoutControlGroup1.Enabled = false;
                        BtnAdd_Click(sender, e);
                    }else
                    {
                        DesktopAlert.Show("لم يتم الحفظ  ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

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
            if (string.IsNullOrEmpty(NameTextEdit.Text))
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل   ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

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


                    ExCompany obj = exCompanyBindingSource.Current as ExCompany;
                    if (obj != null)
                    {
                        var myOrders = await accControl.GetOrders(obj.Id);
                        if (myOrders.Count()>0 )
                        {
                            DesktopAlert.Show("لايمكن حذف هذه الشركة ! يوجد طلبات مرتبطة ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);

                            return;
                        }

                        if (db.Entry<ExCompany>(obj).State == EntityState.Detached)
                            db.Set<ExCompany>().Attach(obj);
                        db.Entry<ExCompany>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        exCompanyBindingSource.RemoveCurrent();
                        NameTextEdit.Enabled = false;
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

        private void NameTextEdit_KeyDown(object sender, KeyEventArgs e)
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
                ExCompany obj = exCompanyBindingSource.Current as ExCompany;
            if (obj != null)
            {
                BtnAdd.Enabled = true;
                BtnSave.Enabled = true;

                PriceForPassportCalcEdit.Text = obj.PriceForPassport.ToString(SD.NumDec);
              //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
            }
            }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

     

        private void AttachmeedFilePictureEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void DistrictNameComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BtnSave.Focus();

            }
        }

        private async void SubscrberIdRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var indexx = SubscrberIdRadioGroup.Properties.Items[SubscrberIdRadioGroup.SelectedIndex].Value;
                if (indexx == null)
                {
                    return;
                }

                var subscriber = await accControl.GetSubscribers(Convert.ToInt32(indexx));

                if (subscriber != null)
                {
                    PriceForPassportCalcEdit.Text = subscriber.Price.ToString(SD.NumDec);
                }


            }
            catch 
            {

                
            }
           
            


        }

        private void NameEnTextEdit_Enter(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void NameEnTextEdit_Leave(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("ar");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }
    }
}