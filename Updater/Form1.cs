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
using System.Threading;

namespace Updater
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    //MessageBox.Show(file.Name+"----------"+ completeFileName);

                    file.ExtractToFile(completeFileName, true);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerStartUpdate.Start();

        }
        public void DownloadFile(string id)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GoogleDriveFilesRepository.dooo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoogleDriveFilesRepository.Seriall();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GoogleDriveFilesRepository.ReadSeriall();
        }
         //
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            System.Diagnostics.Process.Start(@".\ExmonSystem.exe");
            Application.Exit();
        }

        private async  void timerStartUpdate_Tick(object sender, EventArgs e)
        {
            timerStartUpdate.Stop();

            if (File.Exists(Application.StartupPath + @"\updateDone.txt"))
            {

                File.Delete(Application.StartupPath + @"\updateDone.txt");
            }
            if (File.Exists(@".\updater.zip"))
            {
                LblConfirm.Visible = true;
                progress1.Visible = true;
                //Thread.Sleep(500);

                //MessageBox.Show("2");
          await   Task.Run(()=>   ExtractZipFileToDirectory(@".\updater.zip", @".\", true));
                //ZipFile.ExtractToDirectory(@".\updater.zip", @".\");


                //MessageBox.Show("3");

                if (!File.Exists(Application.StartupPath + @"\updateDone.txt"))
                {

                    LblConfirm.Visible = false;
                    progress1.Visible = false;



                    LblConfirm1.Visible = true;
                    LblConfirm2.Visible = true;
                    progress2.Visible = true;

                    //MessageBox.Show("4");

                    File.Create(Application.StartupPath + @"\updateDone.txt");
                    timer1.Start();

                }
                else
                {

                    timer1.Start();

                }

            }else
            {
                Application.Exit();

            }
        }

        private void LblConfirm1_Click(object sender, EventArgs e)
        {

        }

        private void progress2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
