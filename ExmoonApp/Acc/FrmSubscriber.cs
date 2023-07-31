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
    public partial class FrmSubscriber : DevExpress.XtraEditors.XtraForm
    {
        ItemGoverControl accControl = new ItemGoverControl();

        public FrmSubscriber()
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

            subscriberBindingSource.DataSource = await accControl.GetAllSubscribers();//db.itemCategories.ToList();

            TxtName.Enabled = true;

            subscriberBindingSource.Add(new Subscriber());
            subscriberBindingSource.MoveLast();
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
            TxtValue.Value = 0;
            subscriberBindingSource.MoveLast();
            Subscriber obj = subscriberBindingSource.Current as Subscriber;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    TxtName.Focus();
                }
                else
                {
                    subscriberBindingSource.Add(new Subscriber());
                    subscriberBindingSource.MoveLast();
                    TxtName.Focus();
                }
            }

        }

        private async void  BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (string.IsNullOrEmpty(TxtValue.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }

            if (!CheckPassport.Checked && !CheckTicket.Checked && !CheckVisa.Checked && !CheckExcell.Checked && !checkVoucher.Checked )
            {
                DesktopAlert.Show("يجب اختيار نوع الطباعة ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            BtnSave.Enabled = false;

            using (MyDbContext db = new MyDbContext())
            {
                Subscriber obj = subscriberBindingSource.Current as Subscriber;
                if (obj != null)
                {
                    obj.Price =Convert.ToDouble( TxtValue.Value);
                    if (db.Entry<Subscriber>(obj).State == EntityState.Detached)
                        db.Set<Subscriber>().Attach(obj);
                    if (obj.Id == 0)

                        db.Entry<Subscriber>(obj).State = EntityState.Added;
                    else
                        db.Entry<Subscriber>(obj).State = EntityState.Modified;
                  var rslt=await  db.SaveChangesAsync();
                    //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
                    if (rslt>0)
                    {
                        DgvRecords.Refresh();
                        TxtName.Enabled = false;
                        subscriberBindingSource.ResetBindings(false);
                        DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                        TxtName.Enabled = false;
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


                    Subscriber obj = subscriberBindingSource.Current as Subscriber;
                    if (obj != null)
                    {

                        var getCheck =await accControl.GetSubscriberCheck(obj.Id);
                        if (!getCheck)
                        {
                            DesktopAlert.Show("لا يمكن الحذف يوجد شركات مرتبطة ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                            return;
                        }

                        if (db.Entry<Subscriber>(obj).State == EntityState.Detached)
                            db.Set<Subscriber>().Attach(obj);
                        db.Entry<Subscriber>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        subscriberBindingSource.RemoveCurrent();
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
            if (e.KeyCode==Keys.Enter)
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

                groupControl1.Focus();
                
            }
        }

        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
                Subscriber obj = subscriberBindingSource.Current as Subscriber;
            if (obj != null)
            {
              TxtValue.Value=Convert.ToDecimal( obj.Price) ;
            }
            }
    }
}