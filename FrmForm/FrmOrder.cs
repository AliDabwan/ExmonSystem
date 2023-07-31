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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem.Acc
{
    public partial class FrmOrder : DevExpress.XtraEditors.XtraForm
    {
        AccountControl accControl = new AccountControl();

        public FrmOrder()
        {
            InitializeComponent();
        }
        public List<ExCompany> listExCompany = new List<ExCompany>();
        public List<Driver> listDriver = new List<Driver>();


        async Task  GetLoadFields()
        {
            
            
            var xx = await accControl.GetAllExCompaniesForList();
            //listGovers.Add(new ItemGover() { Id = 0, Name = "الكل" });

            foreach (var item in xx)
            {
                listExCompany.Add(new ExCompany() { Id = item.Id, Name = item.Name,PriceForPassport=item.PriceForPassport});

            }
            ExCompanyIdLookUpEdit.Properties.DataSource = listExCompany;
            ExCompanyIdLookUpEdit.Properties.DisplayMember = "Name";
            ExCompanyIdLookUpEdit.Properties.ValueMember = "Id";
            ExCompanyIdLookUpEdit.Properties.PopulateColumns();
            ExCompanyIdLookUpEdit.Properties.Columns[2].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[3].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[4].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[5].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[6].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[7].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[8].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[9].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[10].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[11].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[12].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[13].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[14].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[15].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[16].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[17].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[18].Visible = false;
            ExCompanyIdLookUpEdit.Properties.Columns[19].Visible = false;




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
        private async void FrmTaxValue_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            await GetLoadFields();

            timerLoad.Start();
            CreatedDateDateEdit.DateTime = DateTime.Now;
        }
       
        async Task GetLoad()
        {
            GridView gridView1 = DgvRecords.MainView as GridView;

            orderBindingSource.DataSource = await accControl.GetAllOrders();//db.itemCategories.ToList();

            ExCompanyIdLookUpEdit.Enabled = true;
            layoutControlGroup1.Enabled = true;

            orderBindingSource.Add(new Order());
            orderBindingSource.MoveLast();
            ExCompanyIdLookUpEdit.Focus();

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
                ExCompanyIdLookUpEdit.Enabled = true;
                layoutControlGroup1.Enabled = true;

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            layoutControlGroup1.Enabled = true;
            ExCompanyIdLookUpEdit.Enabled = true;
            BtnSave.Enabled = true;
            BtnAdd.Enabled = false;
            TxtPrice.Text = "0";
            orderBindingSource.MoveLast();
            Order obj = orderBindingSource.Current as Order;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    ExCompanyIdLookUpEdit.Focus();
                }
                else
                {
                    orderBindingSource.Add(new Order());
                    orderBindingSource.MoveLast();
                    ExCompanyIdLookUpEdit.Focus();
                }
            }

        }
        Helper helper = new Helper();

        private async void  BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExCompanyIdLookUpEdit.Text))
            {
                DesktopAlert.Show("الحقل فارغ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                ExCompanyIdLookUpEdit.Focus();
                return;
            }
        
            if (string.IsNullOrEmpty(OrderCountCalcEdit.Text))
            {
                DesktopAlert.Show("الحقل عدد الجوازات فارغ ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                OrderCountCalcEdit.Focus();

                return;
            }
            if (OrderCountCalcEdit.Text=="0")
            {
                DesktopAlert.Show("الحقل عدد الجوازات لايقبل القيمة 0 ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                OrderCountCalcEdit.Focus();

                return;
            }
            if (Convert.ToInt32( OrderCountCalcEdit.Text)<=0)
            {
                DesktopAlert.Show("الحقل عدد الجوازات لايقبل القيمة 0 ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                OrderCountCalcEdit.Focus();

                return;
            }
            if (string.IsNullOrEmpty(DriverIdLookUpEdit.Text))
            {
                DesktopAlert.Show("الحقل السائق فارغ ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                DriverIdLookUpEdit.Focus();
                return;
            }
          
            BtnSave.Enabled = false;

            using (MyDbContext db = new MyDbContext())
            {
                Order obj = orderBindingSource.Current as Order;
                if (obj != null)
                {




                    obj.Driver = null;
                    obj.ExCompany = null;
                    obj.BillCreatedUser = null;
                    if (db.Entry<Order>(obj).State == EntityState.Detached)
                        db.Set<Order>().Attach(obj);



                    var count = await db.Orders.CountAsync();

                    if (count > 50)
                    {
                        helper.ShowMessage(this, "تفعيل النسخة", "لايمكن إضافة طلبات جديدة او تعديلها يرجى تفعيل النسخة ");
                        BtnSave.Enabled = true;
                        BtnAdd.Enabled = false;

                        return;
                    }
                    if (obj.Id == 0)
                    {
                        obj.Price =Convert.ToDouble( TxtPrice.Text);

                        obj.IsPaid = false;
                        obj.PaidStatue = "غيرمسدد";
                        obj.PrintedStatue = "غيرمطبوع";

                        db.Entry<Order>(obj).State = EntityState.Added;
                    }
                    else
                    {
                        if (obj.IsPaid)
                        {
                            BtnSave.Enabled = true;
                            BtnAdd.Enabled = false;

                            DesktopAlert.Show("هذا الطلب مدفوع ! لايمكن تعديله ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                            return;

                        }
                     

                        obj.LastUpdateDate = DateTime.Now;
                        obj.LastUpdateUserId = Program.userId;
                        db.Entry<Order>(obj).State = EntityState.Modified;
                    }
                    var rslt=await  db.SaveChangesAsync();
                    //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
                    if (rslt>0)
                    {
                        DgvRecords.Refresh();
                        ExCompanyIdLookUpEdit.Enabled = false;
                        layoutControlGroup1.Enabled = false;
                        orderBindingSource.ResetBindings(false);
                        gridView1.RefreshData();

                        DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                        ExCompanyIdLookUpEdit.Enabled = false;
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
            if (string.IsNullOrEmpty(ExCompanyIdLookUpEdit.Text))
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


                    Order obj = orderBindingSource.Current as Order;
                    if (obj != null)
                    {

                        var count = await db.Orders.CountAsync();

                        if (count > 50)
                        {
                            helper.ShowMessage(this, "تفعيل النسخة", "لايمكن حذف الطلبات يرجى تفعيل النسخة ");
                            BtnSave.Enabled = true;
                            BtnAdd.Enabled = false;
                            Close();
                            return;
                        }


                        if (db.Entry<Order>(obj).State == EntityState.Detached)
                            db.Set<Order>().Attach(obj);
                        db.Entry<Order>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        orderBindingSource.RemoveCurrent();
                        ExCompanyIdLookUpEdit.Enabled = false;
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

        }

        private void ExCompanyIdLookUpEdit_KeyDown(object sender, KeyEventArgs e)
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
                Order obj = orderBindingSource.Current as Order;
            if (obj != null)
            {
                TxtPrice.Text = obj.Price.ToString(SD.NumDec);
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

       

        private void DistrictNameComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NoteMemoEdit_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (BtnSave.Enabled)
                {
                    BtnSave_Click(sender, e);
                }
            }
        }

        private void ExCompanyIdLookUpEdit_EditValueChanged_1(object sender, EventArgs e)
        {

            try
            {
                var ExCompany = ExCompanyIdLookUpEdit.GetSelectedDataRow() as ExCompany;
                if (ExCompany != null)
                {
                    //DesktopAlert.Show(ExCompany.Id+" -"+ExCompany.Name);
                    //DesktopAlert.Show(ExCompany.PriceForPassport.ToString(SD.NumDec));
                    TxtPrice.Text = ExCompany.PriceForPassport.ToString(SD.NumDec);

                }
            }
            catch
            {
                TxtPrice.Text = "0";
            }
        }
    }
}