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
    public partial class FrmOrderList : DevExpress.XtraEditors.XtraForm
    {
        AccountControl accControl = new AccountControl();

        public FrmOrderList()
        {
            InitializeComponent();
        }
      

        private  void FrmTaxValue_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            timerLoad.Start();
        }
       
        async Task GetLoad()
        {

            orderBindingSource.DataSource = await accControl.GetAllOrders(false);//db.itemCategories.ToList();

          


        }
        private async void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
          await GetLoad();
        }

        private async void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }

            if (e.Column.Name== "gridColumnPrint")
            {
                
                   Order obj = orderBindingSource.Current as Order;
                if (obj != null)
                {
                    if (obj.Id==0)
                    {
                        return;
                    }
                    FrmOrderPrint print = new FrmOrderPrint();
                    print.Id = obj.Id;
                    print.ExCompanyId = obj.ExCompanyId;
                    print.TxtCompanyEn.Text = obj.ExCompany.NameEn;
                    print.ShowDialog();
                    await GetLoad();

                    //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
                }
            }
        }

    

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();

        }




        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }

        }

     

     

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            Order obj = orderBindingSource.Current as Order;
            if (obj != null)
            {
                //TxtValue.Value=Convert.ToDecimal( obj.Price) ;
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            await GetLoad();

        }
    }
}