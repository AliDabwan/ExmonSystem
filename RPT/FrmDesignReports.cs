using DevExpress.XtraEditors;
using ExmonSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem.RPT
{
    public partial class FrmDesignReports : DevExpress.XtraEditors.XtraForm
    {

        public FrmDesignReports()
        {
            InitializeComponent();
        }

        public void ShowItemsReport(string Title,string Filtered)
        {
            //ItemsReports itemsReports = new ItemsReports();
            //foreach (DevExpress.XtraReports.Parameters.Parameter item in itemsReports.Parameters)
            //{
            //    item.Visible = false;
            //}
            //itemsReports.InitialData(Title, Filtered);
            
            //itemsReports.CreateDocument();

           
        }
        private void FrmViewReports_Load(object sender, EventArgs e)
        {
        }
    }
}