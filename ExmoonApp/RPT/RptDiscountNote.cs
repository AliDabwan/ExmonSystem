using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ExmonSystem.RPT
{
    public partial class RptDiscountNote : DevExpress.XtraReports.UI.XtraReport
    {
        public RptDiscountNote()
        {
            InitializeComponent();
        }

        private void xrCharacterComb1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
