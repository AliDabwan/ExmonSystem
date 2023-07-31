using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace ExmonSystem.RPT
{
    public partial class RptPrescripUsageLabel50X25 : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPrescripUsageLabel50X25()
        {
            InitializeComponent();

            foreach (var item in Parameters)
            {
                item.Visible = false;
            }
            if (CompanyName==null)
            {
                xrLabelCompany.Visible = false;
            }
        }

    }
}
