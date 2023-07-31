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

namespace ExmonSystem
{
    public partial class FrmItemGover : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();
        ItemGoverControl itemunitcontrol = new ItemGoverControl();
        string PrevName = "";
        public FrmItemGover()
        {
            InitializeComponent();
        }
        async Task  GetLoad()
        {
          
                itemGoverBindingSource.DataSource = await itemunitcontrol.GetAllItemGover();//db.itemCategories.ToList();
            
            TxtName.Enabled = true;

            itemGoverBindingSource.Add(new ItemGover());
            itemGoverBindingSource.MoveLast();
            TxtName.Focus();

        }

        private async void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
          await  GetLoad();
        }

        private void FrmItemGover_Load(object sender, EventArgs e)
        {
            timerLoad.Start();


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
            action.Commands.Add(command2);
            FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(100, 40);
            properties.Style = FlyoutStyle.MessageBox;
            if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this, action, properties, predicate) == System.Windows.Forms.DialogResult.Yes)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    ItemGover obj = itemGoverBindingSource.Current as ItemGover;
                    if (obj != null)
                    {
                        //if (db.Entry<ItemGover>(obj).State == EntityState.Detached)
                        //    db.Set<ItemGover>().Attach(obj);
                        //db.Entry<ItemGover>(obj).State = EntityState.Deleted;
                        //db.SaveChanges();
                        ////helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        ////DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        //DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);


                   var rslt=  await   itemunitcontrol.DeleteGover(obj.Id);
                        if (rslt)
                        {
                            itemGoverBindingSource.RemoveCurrent();


                        }
                        TxtName.Enabled = false;

                    }
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
            using (MyDbContext db = new MyDbContext())
            {
                ItemGover obj = itemGoverBindingSource.Current as ItemGover;
                if (obj != null)
                {
                    if (db.Entry<ItemGover>(obj).State == EntityState.Detached)
                        db.Set<ItemGover>().Attach(obj);
                    if (obj.Id == 0)
                    {
                        db.Entry<ItemGover>(obj).State = EntityState.Added;


                    }
                    else
                    {
                        db.Entry<ItemGover>(obj).State = EntityState.Modified;

                    }
                    var rslt=  await db.SaveChangesAsync();

                  


                    if (rslt>0)
                    {

                        DgvRecord.Refresh();
                        TxtName.Enabled = false;
                        itemGoverBindingSource.ResetBindings(false);
                        DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                        TxtName.Enabled = false;
                        BtnAdd.Focus();
                    }
               
                }
            }
        }

        private void DgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvRecord.Rows.Count > 0)
            {
                TxtName.Enabled = true;
                ItemGover obj = itemGoverBindingSource.Current as ItemGover;

                if (obj != null)
                {
                    PrevName = obj.Name;
                }
                }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtName.Enabled = true;
            itemGoverBindingSource.MoveLast();
            ItemGover obj = itemGoverBindingSource.Current as ItemGover;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    TxtName.Focus();
                }
                else
                {
                    itemGoverBindingSource.Add(new ItemGover());
                    itemGoverBindingSource.MoveLast();
                    TxtName.Focus();
                }
            }

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}