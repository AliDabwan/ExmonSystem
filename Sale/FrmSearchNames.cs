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

namespace ExmonSystem.Sale
{
    public partial class FrmSearchNames : DevExpress.XtraEditors.XtraForm
    {
        DataTable ItemDt = new DataTable();
        AccountControl cControl = new AccountControl();
        public int macAccount { get; set; }
        Helper helper = new Helper();
        public FrmSearchNames()
        {
            InitializeComponent();
        }
        async Task GetLoad()
        {


            accountsBindingSource.DataSource = await cControl.GetAllAccount(macAccount);//db.itemCategories.ToList();


        }

        private async void FrmSearchNames_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            await GetLoad();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            if (e.KeyCode==Keys.Enter)
            {
                Properties.Settings.Default.itemId = 0;
                Properties.Settings.Default.itemName = "";
                Properties.Settings.Default.UnitName = "";

                Properties.Settings.Default.Save();
                //DesktopAlert.Show("1");
                if (gridView1.RowCount<=0)
                {
                    //DesktopAlert.Show("2");

                    return;
                }
                //DesktopAlert.Show("3");

                var obj = accountsBindingSource.Current as Accounts;

                if (obj!=null)
                {
                    //DesktopAlert.Show("4"+ obj.Id);


                    //Properties.Settings.Default.itemId = obj.mId;
                    Properties.Settings.Default.itemId = obj.Id;

                    Properties.Settings.Default.itemName = obj.AccountName;
                    Properties.Settings.Default.UnitName = obj.taxnumber;

                    Properties.Settings.Default.Save();

                    if (Properties.Settings.Default.itemId>0)
                    {
                        //DesktopAlert.Show("5");

                        Close();

                    }
                }


            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selectItem();

        }

        void selectItem()
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }

            Properties.Settings.Default.itemId = 0;
            Properties.Settings.Default.itemName = "";
            Properties.Settings.Default.UnitName = "";

            Properties.Settings.Default.Save();
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            var obj = accountsBindingSource.Current as Accounts;
            
            if (obj != null)
            {


                Properties.Settings.Default.itemId = obj.Id;

                Properties.Settings.Default.itemName = obj.AccountName;
                Properties.Settings.Default.UnitName = obj.taxnumber;

                Properties.Settings.Default.Save();

                if (Properties.Settings.Default.itemId > 0)
                {
                    Close();

                }
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            selectItem();


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSearchNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}