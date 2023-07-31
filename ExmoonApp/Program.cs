
using DevComponents.DotNetBar.Controls;
using DevExpress.Skins;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string ResturantItemNote { get; set; }
        public static string ParcelBaracod { get; set; } = " ";

        public static int appNewVersionNo { get; set; } = 2006;


        public static bool DoSavePosNewTouch { get; set; }



        public static bool closeMe { get; set; }
        public static bool IsWholeSalesPrice { get; set; }

        public static User logedUser;
        public static Company myCompany;
        public static int userCashAccountId { get; set; }
        public static int WorkDayId { get; set; }
        public static DateTime WorkDayDate { get; set; }

        public static int userId { get; set; }
        public static string userName { get; set; }
        public static string userFullName { get; set; }
        public static int userGroupId { get; set; }
         public static string userGroupName { get; set; }
         public static string prescriptionUsage { get; set; }

        public static bool isSuccessfullogin { get; set; }
        [STAThread]

        static void Main()
        {

            //using (var db = new MyDbContext())
            //{
            //    db.RollName.Add(new RollNames { RollName = "Admin" });
            //    db.SaveChanges();

            //}

            if (CheckSettings())
            {
                DesktopAlert.Show("Settings Will Rebuild");
            }
            else
            {

            }
            //try
            //{
            //    Properties.Settings.Default.Reload();
            //    Properties.Settings.Default.Reset();

            //    MessageBox.Show("reloaded");
            //}
            //catch (System.Configuration.ConfigurationErrorsException ex)
            //{
            //    string fname = ((ConfigurationErrorsException)ex.InnerException).Filename;

            //    if (MessageBox.Show("<ProgramName> has detected that your" +
            //                          " user settings file has become corrupted. " +
            //                          "This may be due to a crash or improper exiting" +
            //                          " of the program. <ProgramName> must reset your " +
            //                          "user settings in order to continue.\n\nClick" +
            //                          " Yes to reset your user settings and continue.\n\n" +
            //                          "Click No if you wish to attempt manual repair" +
            //                          " or to rescue information before proceeding.",
            //                          "Corrupt user settings",
            //                          MessageBoxButtons.YesNo
            //                       ) == DialogResult.Yes)
            //    {
            //        File.Delete(fname);
            //        Properties.Settings.Default.Reload();
            //        // you could optionally restart the app instead
            //    }
            //    else
            //    {
            //        System.Diagnostics.Process.GetCurrentProcess().Kill();
            //    }
            //    // avoid the inevitable crash
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (Properties.Settings.Default.Language == "ar" || Properties.Settings.Default.Language=="AR")
            //{
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ar");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
                CultureInfo cut = new CultureInfo("ar");
                cut.DateTimeFormat.Calendar = new GregorianCalendar();
                Thread.CurrentThread.CurrentCulture = cut;
                Thread.CurrentThread.CurrentUICulture = cut;

            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            //    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");


            //}
 //DesktopAlert.Show(Thread.CurrentThread.CurrentCulture.ToString());
            DevExpress.UserSkins.BonusSkins.Register();
            SkinManager.EnableFormSkins();
            isSuccessfullogin = false;

            GoogleDriveFilesRepository.SetUpdateValue(appNewVersionNo);


            if (Properties.Settings.Default.IsInitialize)
            {
                //if (ProdllClass.PwdDecre(Properties.Settings.Default.PropActv) == "true")
                //{
                if (File.Exists(@".\serverCon.json"))
                {
                    Application.Run(new SplashScree1());

                }
                else
                {

                    Application.Run(new FrmSQLConn());

                }                //}
                                 //else
                                 //{
                                 //Application.Run(new FrmActvition());
                                 //}

            }
            else
            {
                Application.Run(new FrmSQLHello());

            }

            //  DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");
        }
        public static bool CheckSettings()
        {
            Helper helper = new Helper();

            var isReset = false;

            try
            {
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            }
            catch (ConfigurationErrorsException ex)
            {
                string filename = string.Empty;
                if (!string.IsNullOrEmpty(ex.Filename))
                {
                    filename = ex.Filename;
                }
                else
                {
                    var innerEx = ex.InnerException as ConfigurationErrorsException;
                    if (innerEx != null && !string.IsNullOrEmpty(innerEx.Filename))
                    {
                        filename = innerEx.Filename;
                    }
                }

                if (!string.IsNullOrEmpty(filename))
                {
                    if (System.IO.File.Exists(filename))
                    {
                        var fileInfo = new System.IO.FileInfo(filename);
                        var watcher
                             = new System.IO.FileSystemWatcher(fileInfo.Directory.FullName, fileInfo.Name);
                        System.IO.File.Delete(filename);
                        isReset = true;
                        if (System.IO.File.Exists(filename))
                        {
                            watcher.WaitForChanged(System.IO.WatcherChangeTypes.Deleted);
                        }
                    }
                }
            }
            if (isReset)
            {
                helper.GetSettingsSaveMode();

            }
            return isReset;
        }

    }
}
