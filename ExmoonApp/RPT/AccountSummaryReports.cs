using DevExpress.XtraReports.UI;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExmonSystem.RPT
{
    public partial class AccountSummaryReports : DevExpress.XtraReports.UI.XtraReport
    {
     //   ItemProductsControl itemProductsControl = new ItemProductsControl();

        public AccountSummaryReports()
        {
            InitializeComponent();
            //  InitialData("","");
            foreach (var item in this.Parameters)
            {
                item.Visible = false;

            }
        }


    }
}
