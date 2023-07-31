using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ExmonSystem.Controls;
using ExmonSystem.Form;
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

namespace ExmonSystem.Setting
{
    public partial class FrmUserAuthorityGroups : DevExpress.XtraEditors.XtraForm
    {
        RollsControl rollsControl = new RollsControl();
                DataTable dataTable = new DataTable();

        public FrmUserAuthorityGroups()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var frmroll = new FrmRollsNames();
            frmroll.ShowDialog();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtGroupName.Enabled = true;
            rollGroupsBindingSource.MoveLast();
            RollGroups obj = rollGroupsBindingSource.Current as RollGroups;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    TxtGroupName.Focus();
                }
                else
                {
                    rollGroupsBindingSource.Add(new RollGroups());
                    rollGroupsBindingSource.MoveLast();
                    TxtGroupName.Focus();
                }
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtGroupName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (gridView1.RowCount<=0)
            {
                DesktopAlert.Show("يجب إضافة صلاحيات لليوزر " + "\n" + " No Rolls For User ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;

            }
            using (MyDbContext db = new MyDbContext())
            {
                RollGroups obj = rollGroupsBindingSource.Current as RollGroups;
                if (obj != null)
                {

                    if (db.Entry<RollGroups>(obj).State == EntityState.Detached)
                        db.Set<RollGroups>().Attach(obj);
                    if (obj.Id == 0)

                        db.Entry<RollGroups>(obj).State = EntityState.Added;
                    else
                        db.Entry<RollGroups>(obj).State = EntityState.Modified;
                    db.SaveChangesAsync();

                  await rollsControl.DeleteRolls(obj.Id);
                    var rowHandle = 0;
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        rowHandle = i;
                        //try
                        //{

                        var cellValueRollTitel = gridView1.GetRowCellValue(rowHandle, "RollTitle").ToString();
                        var cellValueRollIsChecked = gridView1.GetRowCellValue(rowHandle, "IsChecked").ToString();

                        var newRollGroup = obj.Id;

                        var newUnit = new Rolls()
                        {
                            RollTitle = cellValueRollTitel,
                            groupRollId = newRollGroup,
                            IsChecked = cellValueRollIsChecked
                        };
                        if (newUnit != null)
                        {
                            await rollsControl.AddGroupsRollDirect(newUnit);
                        }
                    }
                   

                    DgvGroups.Refresh();
                    TxtGroupName.Enabled = false;
                    rollGroupsBindingSource.ResetBindings(false);
                    DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                    TxtGroupName.Enabled = false;
                    BtnNew.Focus();

                }
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtGroupName.Text))
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }

            using (MyDbContext db = new MyDbContext())
            {
                RollGroups obj = rollGroupsBindingSource.Current as RollGroups;
               


                if (obj != null)
                {
                    var group =await db.RollGroup.Include(r => r.Users).FirstOrDefaultAsync(r => r.Id == obj.Id);

                    if (group.Users.Any())
                    {
                        DesktopAlert.Show("لايمكن الحذف يوجد يوزرات مرتبطة " + "\n" + " Unable to delete , related with users . ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        return;
                    }


                await    rollsControl.DeleteRollGroup(obj);
                   rollGroupsBindingSource.RemoveCurrent();
                    TxtGroupName.Enabled = false;

                }
            }


        }

        private async void DgvGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvGroups.Rows.Count > 0)
            {
                TxtGroupName.Enabled = true;

            }

            if (gridView1.RowCount > 0)
            {
                dataTable.Clear();
                DgvRolls.DataSource = dataTable;
            }
            RollGroups obj = rollGroupsBindingSource.Current as RollGroups;

            if (obj != null)
            {

                var objRoll = await rollsControl.GetGroupRolls(obj.Id);
                if (objRoll!=null)
                {
                    foreach (var item in objRoll)
                    {
                        dataTable.Rows.Add();
                        dataTable.Rows[dataTable.Rows.Count - 1]["Id"] = item.Id;
                        dataTable.Rows[dataTable.Rows.Count - 1]["RollTitle"] = item.RollTitle;
                        dataTable.Rows[dataTable.Rows.Count - 1]["groupRollId"] = item.groupRollId;
                        dataTable.Rows[dataTable.Rows.Count - 1]["IsChecked"] = item.IsChecked==null?"False": item.IsChecked;

                    }

                    DgvRolls.DataSource = dataTable;
                    gridView1.Columns[0].OptionsColumn.AllowEdit = false;
                    gridView1.Columns[1].OptionsColumn.AllowEdit = false;
                    gridView1.Columns[2].OptionsColumn.AllowEdit = false;

                }

            }



        }

        private async void FrmUserAuthorityGroups_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            timerLoad.Start();
            GridView gridView1 = DgvRolls.MainView as GridView;
            GridView gridView2 = dgvRollsNames.MainView as GridView;

            dgvRollsNames.DataSource = await rollsControl.GetAllNames();
            gridView2.Columns[0].OptionsColumn.AllowEdit = false;
            gridView2.Columns[1].OptionsColumn.AllowEdit = false;
            gridView2.Columns[0].Width = 60;
            gridView2.Columns[1].Width = 200;

            dataTable.Columns.Add("Id", typeof(System.Int32));
            dataTable.Columns.Add("RollTitle", typeof(System.String));
            dataTable.Columns.Add("groupRollId", typeof(System.Int32));
            dataTable.Columns.Add("IsChecked", typeof(System.Boolean));

        }
        async void GetLoad()
        {
             rollGroupsBindingSource.DataSource = await rollsControl.GetGroups();//db.itemCategories.ToList();
            
            TxtGroupName.Enabled = true;

            rollGroupsBindingSource.Add(new RollGroups());
            rollGroupsBindingSource.MoveLast();
            TxtGroupName.Focus();

        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
            GetLoad();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            flyoutPanel1.ShowBeakForm();

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
          
         

        }

        private void dgvRollsNames_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_RowCellClick(object sender, RowCellClickEventArgs e)
        {
         

            var cellValueRollTitel = gridView2.GetRowCellValue(e.RowHandle, "RollName").ToString();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "RollTitle").ToString()== cellValueRollTitel)
                {
                    return;
                }
            }
                dataTable.Rows.Add();
            dataTable.Rows[dataTable.Rows.Count - 1]["RollTitle"] = cellValueRollTitel;
            dataTable.Rows[dataTable.Rows.Count - 1]["IsChecked"] = "False";

                
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}