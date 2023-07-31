using DevComponents.DotNetBar.Controls;
using DevExpress.Xpo;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;

using System.Drawing;
using System.IO;

namespace ExmonSystem.RPT
{
    public partial class RptPassport : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPassport()
        {
            InitializeComponent();
        }

        private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            byte[] bytes = (byte[])GetCurrentColumnValue("AttachmeedFile");
            MemoryStream mem = new MemoryStream(bytes);
            Bitmap bmp = new Bitmap(mem);   
            Image img = bmp;

            XRPictureBox pictureBox = (XRPictureBox)sender;
            pictureBox.ImageSource = new ImageSource(img);
        }
    }
}
