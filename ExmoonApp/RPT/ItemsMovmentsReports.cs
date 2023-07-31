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
    public partial class ItemsMovmentsReports : DevExpress.XtraReports.UI.XtraReport
    {
     //   ItemProductsControl itemProductsControl = new ItemProductsControl();

        public ItemsMovmentsReports()
        {
            InitializeComponent();
            //  InitialData("","");

            lblCompanyAr.Text = Properties.Settings.Default.COMPANY;
            lblCompanyDetailsAr.Text = Properties.Settings.Default.CompanyDetailsAr;
            lblCompanyDetailsEn.Text = Properties.Settings.Default.CompanyDetailsEn;
            lblCompanyPhone2.Text = Properties.Settings.Default.CompanyPhons;

            foreach (var item in this.Parameters)
            {
                item.Visible = false;

            }
        }


    }
}
