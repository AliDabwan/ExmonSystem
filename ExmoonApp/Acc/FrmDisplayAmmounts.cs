using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using ExmonSystem.Sale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem.Acc
{
    public partial class FrmDisplayAmmounts : DevExpress.XtraEditors.XtraForm
    {
        AccountControl accountControl = new AccountControl();
        public FrmDisplayAmmounts()
        {
            InitializeComponent();
        }
        public int workDayId { get; set; }
        public DateTime workDayDate { get; set; }
        public int userId { get; set; }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
        

        }

        private void spinEdit1_ValueChanged(object sender, EventArgs e)
        {
            if (TxtTotal.Value>0)
            {
                BtnSave.Enabled = true;
            }else
            {
                BtnSave.Enabled = false;

            }
        }

        private void BtnIn_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnIn.Checked)
            {
                
                BtnOut.Checked = false;
                BtnDelivery.Checked = false;

                lblType.Text = "إدخال المبلغ";
            }
        }

        private void BtnOut_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnOut.Checked)
            {
                BtnIn.Checked = false;
                BtnDelivery.Checked = false;

                lblType.Text = "صرف المبلغ";

            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {




            Program.DoSavePosNewTouch = true;
            
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {
        }

        private void FrmWorkInOut_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnDelivery.Checked)
            {
                BtnIn.Checked = false;
                BtnOut.Checked = false;

                lblType.Text = "صرف المبلغ";

            }
        }
    }
}