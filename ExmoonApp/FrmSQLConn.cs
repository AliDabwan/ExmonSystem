using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExmonSystem.Models;
using DevComponents.DotNetBar.Controls;

namespace ExmonSystem
{
    public partial class FrmSQLConn : DevExpress.XtraEditors.XtraForm
    {
        public FrmSQLConn()
        {
            InitializeComponent();
        }

        private void ButTestSQL_Click(object sender, EventArgs e)
        {
            string ConnectionString = "";
            if (radioLocal.Checked == true)
            {
                ConnectionString = string.Format("Data Source={0};Initial Catalog={1};", cboServer.Text, txtDBName.Text);


            }
            else
            {
                ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDBName.Text, txtUsername.Text, txtPassword.Text);

            }
            try
            {
                SQLHelpr helper = new SQLHelpr(ConnectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Connction succeeded","Message",MessageBoxButtons.OK , MessageBoxIcon.Information );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSQLConn_Load(object sender, EventArgs e)
        {
            var conType = "";
            if (Properties.Settings.Default.ConType=="Server")
            {
                conType = "cn";
                radioServer.Checked = true;
            }else
            {
                conType = "ln";

                radioLocal.Checked = true;
            }
            lblConName.Text = conType;

            cboServer.Items.Add(".");
            cboServer.Items.Add(@"(LocalDb)\MSSQLLocalDB");
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format (@"{0}\SQLEXPRESS", Environment.MachineName) );
            AppSettings setting = new AppSettings();

           
          
            cboServer.Items.Add( setting.conDetails(conType).DataSource);
            cboServer.Text = setting.conDetails(conType).DataSource;

           txtDBName.Text = setting.conDetails(conType).InitialCatalog;
            try
            {
                txtUsername.Text = setting.conDetails(conType).UserID;
                txtPassword.Text = setting.conDetails(conType).Password;
            }
            catch
            {

                return;
            }
           

        }
        void GetCon()
        {

            AppSettings setting = new AppSettings();
         var cons=   setting.GetConnectionString ("cn")[0].ToString();
            MessageBox.Show(cons);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AppSettings setting = new AppSettings();

            string ConnectionString = "";
            if (radioLocal.Checked==true)
            {
                ConnectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true", cboServer.Text, txtDBName.Text);

                setting.SaveConnectionString("ln", ConnectionString);
                Properties.Settings.Default.ConType = "Local";
                Properties.Settings.Default.ConName = "ln";
                lblConName.Text = "ln";
                Properties.Settings.Default.Save();
                //MessageBox.Show(setting.GetConnectionString(lblConName.Text));
            }
            else
            {
                ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDBName.Text, txtUsername.Text, txtPassword.Text);

                setting.SaveConnectionString("cn", ConnectionString);
                Properties.Settings.Default.ConType = "Server";
                Properties.Settings.Default.ConName = "cn";
                lblConName.Text = "cn";

                Properties.Settings.Default.Save();
            }
            //DesktopAlert.Show(setting.conDetails(Properties.Settings.Default.ConName).DataSource);
            //DesktopAlert.Show(setting.conDetails(Properties.Settings.Default.ConName).InitialCatalog);
            //DesktopAlert.Show(setting.conDetails(Properties.Settings.Default.ConName).UserID);
            //DesktopAlert.Show(setting.conDetails(Properties.Settings.Default.ConName).Password);

            var myCon = new myserverCon()
            {
                name = Properties.Settings.Default.ConName,
                DataSource = setting.conDetails(Properties.Settings.Default.ConName).DataSource,
                InitialCatalog = setting.conDetails(Properties.Settings.Default.ConName).InitialCatalog,
                UserID = setting.conDetails(Properties.Settings.Default.ConName).UserID,
                Password = setting.conDetails(Properties.Settings.Default.ConName).Password
            };

            GoogleDriveFilesRepository.SetServerCon(myCon);
            //try
            //{



            //    SQLHelpr helper = new SQLHelpr(ConnectionString);
            //    if (helper.IsConnection)
            //    {

            //            MessageBox.Show("Connction succeeded Saved "+Properties.Settings.Default.ConType, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConType = "Local";
            Properties.Settings.Default.ConName = "ln";

            Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.ConType = "Server";
            Properties.Settings.Default.ConName = "cn";

            Properties.Settings.Default.Save();
        }

        private void FrmSQLConn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.isSuccessfullogin = true;

            Application.Exit();
        }
    }
}