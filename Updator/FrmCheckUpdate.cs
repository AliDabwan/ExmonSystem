using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;
using GigaPosUpdator;
using DevComponents.DotNetBar.Controls;

namespace GigaPosUpdator
{
    public partial class FrmCheckUpdate : DevExpress.XtraEditors.XtraForm
    {
        public FrmCheckUpdate()
        {
            InitializeComponent();
        }


        public void ExtractZipFileToDirectory(string sourceZipFilePath, string destinationDirectoryName, bool overwrite)
        {
            using (var archive = ZipFile.Open(sourceZipFilePath, ZipArchiveMode.Read))
            {
                if (!overwrite)
                {
                    archive.ExtractToDirectory(destinationDirectoryName);
                    return;
                }

                DirectoryInfo di = Directory.CreateDirectory(destinationDirectoryName);
                string destinationDirectoryFullPath = di.FullName;

                foreach (ZipArchiveEntry file in archive.Entries)
                {
                    string completeFileName = Path.GetFullPath(Path.Combine(destinationDirectoryFullPath, file.FullName));

                    if (!completeFileName.StartsWith(destinationDirectoryFullPath, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new IOException("Trying to extract file outside of destination directory. See this link for more info: https://snyk.io/research/zip-slip-vulnerability");
                    }

                    if (file.Name == "")
                    {// Assuming Empty for Directory
                        Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                        continue;
                    }
                    file.ExtractToFile(completeFileName, true);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerStartUpdate.Start();

        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private async void timerStartUpdate_Tick(object sender, EventArgs e)
        {
            timerStartUpdate.Stop();
           var statue= await GoogleDriveFilesRepository.dooo();
            //MessageBox.Show("do done"+ statue);

            if (statue)
            {
                //MessageBox.Show("do true");

                lblResult.Visible = true;
                GoogleDriveFilesRepository.GetUpdateFile();

            }
            else
            {
                //MessageBox.Show("do false");

                DesktopAlert.Show("برنامجك محدث لأخر إصدار " + "\n" + "this is the last Version ");

                Close();
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
