using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ExmonSystem.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using ExmonSystem.Models;

namespace ExmonSystem.Form
{
    public partial class FrmRollsNames : DevExpress.XtraEditors.XtraForm
    {
        DataTable ItemDt = new DataTable();
        RollsControl rollsControl = new RollsControl();

        Helper helper = new Helper(); 

        public FrmRollsNames()
        {
            InitializeComponent();
            gridView1.CellValueChanged += GridView1_CellValueChanged;

        }


        async Task AddItem()
        {
          
          var items=await rollsControl.GetAllNames();
            if (items == null)
            {
                return;
            }
            foreach (var item in items)
            {
                ItemDt.Rows.Add();
                ItemDt.Rows[ItemDt.Rows.Count - 1]["Id"] = item.Id;
                ItemDt.Rows[ItemDt.Rows.Count - 1]["RollName"] = item.RollName;

            }


            DgvItem.DataSource =  ItemDt;
      
            gridView1.Columns[0].Width=80;
            gridView1.Columns[1].Width = 150;

            if (gridView1.RowCount > 0)
            {
                gridView1.Columns[0].OptionsColumn.AllowEdit = false ;
              

                gridView1.Columns[0].OptionsColumn.AllowFocus = false;
             




            }
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
           

        }

        private async void FrmStocktaking_Load(object sender, EventArgs e)
        {
            GridView gridView1 = DgvItem.MainView as GridView;

            ItemDt.Columns.Add("Id", typeof(System.Int32));
            ItemDt.Columns.Add("RollName", typeof(System.String));


          await  AddItem();
        }
        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            int rowHandle = 0;
            if (gridView1.RowCount<=0)
            {
              
                DesktopAlert.Show("لاتوجد سجلات " + "\n" + " No records to add   ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                return;
            }

            progressBarControl1.Properties.Maximum = gridView1.RowCount;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                rowHandle = i;
                //try
                //{
             

                var cellValueItemID = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "ItemId"));
                var cellValueName = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
              


                var newRoll = new RollNames()
                {
                    RollName = cellValueName
                };
                if (newRoll != null)
                {
                  await rollsControl.AddRollNamesDirect(newRoll);
                }
            
                progressBarControl1.Position = (rowHandle + 1);
            }
            BtnSave.Enabled = false;
            helper.ShowMessage(this, "Additional of Rolls إضافة الصلاحيات ", "Roll Added Successfully تم الصلاحية بنجاح");

        }
        private  void TxtBarcod_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void TxtBarcod_TextChanged(object sender, EventArgs e)
        {

        }

        private async void TxtBarcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                await AddItem();

            }
        }

        private void DgvItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                ItemDt.Clear();
                DgvItem.DataSource = ItemDt;
            }
            BtnSave.Enabled = true;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}