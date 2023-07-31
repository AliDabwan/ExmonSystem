using DevExpress.XtraReports.UI;
using GIGAPOS.Controls;
using GIGAPOS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GIGAPOS.RPT
{
    public partial class BillsAnalysisItems : DevExpress.XtraReports.UI.XtraReport
    {
     //   ItemProductsControl itemProductsControl = new ItemProductsControl();

        public BillsAnalysisItems()
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
