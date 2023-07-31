using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        Dates MyDate = new Dates();
        Helper helper = new Helper();

        RollsControl rollsControl = new RollsControl();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            Program.isSuccessfullogin = true;

            System.Windows.Forms.Application.Exit();
            
        }
        Control Activecontrol;
        private void But1_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            Activecontrol.Focus();
            SendKeys.Send(btn.Text);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Activecontrol = (Control)sender;
        }

        string PwdDecre(string pwd)
        {
            string temp = "";
            byte[] tempData = Convert.FromBase64String(pwd);
            temp = new UTF8Encoding().GetString(tempData);




            return temp;
        }
        string PwdEncre(string pwd)
        {
            string temp = "";

            byte[] tempSource = new UTF8Encoding().GetBytes(pwd);
            temp = Convert.ToBase64String(tempSource);


            return temp;
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
        bool CheckDate()
        {
            //  timerAcs.Stop();
            if (PwdDecre(Properties.Settings.Default.PropVerisonSleep) == "")
            {
                return false;
            }

            DateTime sleep = DateTime.ParseExact(PwdDecre(Properties.Settings.Default.PropVerisonSleep), "yyyy/MM/dd", CultureInfo.InvariantCulture);// Convert.ToDateTime(Properties.Settings.Default.PropVerisonSleep);
            string now = MyDate.GDateNow("yyyy/MM/dd");
            string nowh = MyDate.HDateNow("yyyy/MM/dd");

            string Expier;
            Expier = sleep.ToString("yyyy/MM/dd");
            if (MyDate.IsGreg(Expier))
            {
                Expier = MyDate.FormatGreg(Expier, "yyyy/MM/dd");
                Properties.Settings.Default.PropVerisonSleep = PwdEncre(Expier);
                Properties.Settings.Default.Save();
            }
            else
            {
                Expier = MyDate.HijriToGreg(MyDate.FormatHijri(Expier, "yyyy/MM/dd"), "yyyy/MM/dd");
                Properties.Settings.Default.PropVerisonSleep = PwdEncre(Expier); // exps.ToString("yyyy/MM/dd");
                Properties.Settings.Default.Save();

            }
            DateTime nowww;
            string NowDay;
            if (MyDate.IsGreg(DateTime.Now.ToString("yyyy/MM/dd")))
            {
                nowww = Convert.ToDateTime(now);
                //MessageBox.Show("now g is  : " + now);

                // nowww = nowww.AddDays(29);
                NowDay = nowww.ToString("yyyy/MM/dd");
            }
            else
            {
                DateTime exps = Convert.ToDateTime(MyDate.FormatHijri(nowh, "yyyy/MM/dd"));
                //   exps = exps.AddDays(29);
                NowDay = MyDate.HijriToGreg(MyDate.FormatHijri(exps.ToString("yyyy/MM/dd"), "yyyy/MM/dd"), "yyyy/MM/dd");// exps.ToString("yyyy/MM/dd");
                //MessageBox.Show("nowh H is  : " + nowh);
            }
            //MyDate.Compare(NowDay, Expier); 

            DateTime NowDaynum = DateTime.ParseExact(NowDay, "yyyy/MM/dd", CultureInfo.CurrentCulture);// Convert.ToDateTime(Properties.Settings.Default.PropVerisonSleep);
            DateTime ExpDaynum = DateTime.ParseExact(Expier, "yyyy/MM/dd", CultureInfo.CurrentCulture);// Convert.ToDateTime(Properties.Settings.Default.PropVerisonSleep);
                                                                                                       //if (!string.IsNullOrEmpty(MyDate.GDateStamp(NowDay)))
                                                                                                       //{
                                                                                                       //     NowDaynum = Convert.ToInt32(MyDate.GDateStamp(NowDay));
                                                                                                       //}
                                                                                                       //else
                                                                                                       //{
                                                                                                       //    NowDaynum = 1;
                                                                                                       //}
                                                                                                       //if (!string.IsNullOrEmpty(MyDate.GDateStamp(Expier)))
                                                                                                       //{
                                                                                                       //     ExpDaynum = Convert.ToInt32(MyDate.GDateStamp(Expier));
                                                                                                       //}
                                                                                                       //else
                                                                                                       //{
                                                                                                       //    ExpDaynum = 30;

            //}

            //MessageBox.Show("ExpDaynum g is  : " + ExpDaynum);
            //MessageBox.Show("NowDaynum g is  : " + NowDaynum);
            TimeSpan TMS = ExpDaynum.Subtract(NowDaynum);
            double ValiedDays = TMS.TotalDays;
            //  MessageBox.Show("dayyyyyys Is  : " + ValiedDays);
            if (ValiedDays < 3)
            {
                //DateTime ff = sleep;
                //DateTime tt = DateTime.Now;

                //int x = ff.Day - tt.Day;

                //  MessageBox.Show((x).ToString());
             
                DesktopAlert.Show("تبقى للنسخة " + ValiedDays + "يوم");

                if (ValiedDays <= 0)
                {
                  
                    DesktopAlert.Show ( "انتهت صلاحية النسخة . الرجاء التواصل مع الدعم الفني ");
                
                    Properties.Settings.Default.PropActv = PwdEncre("false");
                    Properties.Settings.Default.Save();

                }
                return true;
            }

            return false;

        }

        private async void butLogin_Click(object sender, EventArgs e)
        {
            //CheckDate();
            //if (PwdDecre(Properties.Settings.Default.PropActv) == "false")
            //{
            //    FrmActvition FRM_ACS = new FrmActvition();
            //    FRM_ACS.ShowDialog();
              
            //    return;

            //}
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                DesktopAlert.Show(" حقل رمز المرور فارغ " + "\n" + " Password is empity ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                txtPassword.Focus();
          
                return;
            }
            if (CmbUsers.Text == "" || string.IsNullOrEmpty(CmbUsers.Text))
            {
                DesktopAlert.Show(" حقل اسم المستخدم فارغ " + "\n" + " User is empity ", eDesktopAlertColor.Gold, eAlertPosition.TopRight);
                CmbUsers.Focus();
                return;

            }

        var isAuthentcation=   await rollsControl.CheckLogin(CmbUsers.Text,helper.Base64Encode( txtPassword.Text));
            if (isAuthentcation)
            {
                var user =await rollsControl.GetUsers(Convert.ToInt32(CmbUsers.SelectedValue));
                Program.logedUser = user;
                if (user.IsHasCashAccount==true)
                {
                    Program.userCashAccountId = user.CashAccountId;
                }else
                {
                    Program.userCashAccountId = 0;

                }
                Program.userId = user.Id;
                Program.userName = user.UserName;
                Program.userFullName = user.FullName;
                Program.userGroupId = user.groupRollId;
                Program.userGroupName = user.groupRoll.GroupRollName;

                var myRoll = await rollsControl.getMyRoll(Program.userGroupId);





                if (!myRoll.Any())
                {
                    DesktopAlert.Show(" لاتوجد صلاحيات مرتبطه بالمجموعة الخاصة بهذا المستخدم " + "\n" + " Login faild ! No assocated rolls for this user ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                    txtPassword.Focus();
                    txtPassword.SelectAll();

                    return;
                }
                Program.isSuccessfullogin = true;

                DesktopAlert.Show(" تم تسجيل الدخول بنجاح " + "\n" + " Login Successfuly ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                Close();
            }
            else
            {
                Program.isSuccessfullogin = false;

                DesktopAlert.Show(" فشل تسجيل الدخول تاكد من البيانات " + "\n" + " Login faild ! check user name and password ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                txtPassword.Focus();
                txtPassword.SelectAll();

            }


        }
        async Task GetLoadGroupTry()
        {

            CmbUsers.DataSource = await rollsControl.GetUsers();//db.itemCategories.ToList();
            CmbUsers.DisplayMember = "UserName";
            CmbUsers.ValueMember = "Id";
            try
            {
                CmbUsers.SelectedItem = 0;

            }
            catch
            {

                return;
            }


        }
        async Task dbIntializer()
        {
            RollsControl RollsControl = new RollsControl();
            var rolnames =await RollsControl.GetAllNames();
            var newGroupId = 0;
            //MessageBox.Show("chk null ");

            if (rolnames == null)
            {
                //MessageBox.Show("null");
                var rnn = new RollGroups()

                { GroupRollName = "Admins" };

                newGroupId = await RollsControl.AddGroupsDirect(rnn);
            }
            var Usrname = await RollsControl.GetUsers();
            if (Usrname == null)
            {
                var rnnUser = new User()

                { UserName = "Admin", FullName = "Admin", Pwd =helper.Base64Encode("123"), groupRollId = newGroupId };

                await RollsControl.AddUserDirect(rnnUser);
            }



        }
        async Task ReEditUsers()
        {
            RollsControl RollsControl = new RollsControl();

            var Usrname = await RollsControl.GetUsers();
            foreach (var item in Usrname)
            {
                if (!item.IsEncrept)
                {
                    item.Pwd = helper.Base64Encode(item.Pwd);
                    item.IsEncrept = true;
                    await RollsControl.EditUserDirect(item);

                }

            }

        }
        async Task setSaveSettings()
        {
            var mysetting = new mySetingsSaveMode()
            {
                IsInitialize = Properties.Settings.Default.IsInitialize,
                PropActv = Properties.Settings.Default.PropActv,
                PropVerisonSleep =  Properties.Settings.Default.PropVerisonSleep,
                Propfree = Properties.Settings.Default.Propfree,
                ConType = Properties.Settings.Default.ConType,
                ConName = Properties.Settings.Default.ConName,

            };
            helper.SetSettingsSaveMode(mysetting);

        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.Focus();

            if (Properties.Settings.Default.VersonNo< Program.appNewVersionNo)
            {
                Properties.Settings.Default.VersonNo = Program.appNewVersionNo;
                Properties.Settings.Default.Save();
            }
            await setSaveSettings();

            await ReEditUsers();

           
            await dbIntializer();
           await GetLoadGroupTry();
        }

        private async void ButResPassword_Click(object sender, EventArgs e)
        {

            var user = await rollsControl.GetUsers(Convert.ToInt32(CmbUsers.SelectedValue));
            if (user==null)
            {
                DesktopAlert.Show(" اكتب او اختر اليوزر الخاص بك بشكل صحيح " + "\n" + "Enter or Select your User Name! ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                CmbUsers.Focus();
                return;
            }

            if (string.IsNullOrEmpty( user.SecurityQuestion))
            {
                DesktopAlert.Show("ليس لهذا اليوزر سؤال امان " + "\n" + " No Security Question For this User", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                return;

            }
            if (string.IsNullOrEmpty(user.SecurityAnswer))
            {
                DesktopAlert.Show("لاتوجد إجابة لسؤال الامان " + "\n" + " No Answer For this user ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                return;

            }
            var rr = new FrmRestorePassword();
            rr.TxtName.Text = user.UserName;
            rr.ShowDialog();
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            if (Program.isSuccessfullogin==false)
            {
                return;
            }
            Close();
        }

        private void CmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                butLogin_Click(sender,e);
            }
        }

        private void ButBack_Click(object sender, EventArgs e)
        {
            butLogin_Click(sender, e);

        }

        private void CmbUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F12)
            {
                FrmSQLConn frmSQL = new FrmSQLConn();
                frmSQL.ShowDialog();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_DoubleClick(object sender, EventArgs e)
        {
            //var x = helper.Base64Encode(txtPassword.Text);
            //DesktopAlert.Show("x - "+ x);

            //var dx = helper.Base64Decode(x);
            //DesktopAlert.Show("dx - " + dx);

        }
    }
}