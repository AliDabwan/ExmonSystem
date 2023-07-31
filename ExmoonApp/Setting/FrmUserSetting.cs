using DevComponents.DotNetBar.Controls;
using DevExpress.XtraEditors;
using ExmonSystem.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem.Setting
{
    public partial class FrmUserSetting : DevExpress.XtraEditors.XtraForm
    {
        RollsControl rollsControl = new RollsControl();
        string AttachedFile = "";
        AccountControl accControl = new AccountControl();
        Helper helper = new Helper();

        public FrmUserSetting()
        {
            InitializeComponent();
        }
        async void GetLoad()
        {
                userBindingSource.DataSource = await rollsControl.GetUsersSettings();//db.itemCategories.ToList();
        
            TxtName.Enabled = true;
            if (CheckIsAcc.Checked)
            {
                CmbAccounts.Visible = true;
            }
            else
            {
                CmbAccounts.Visible = false;

            }

            userBindingSource.Add(new User());
            userBindingSource.MoveLast();
            TxtName.Focus();

        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var frm = new Setting.FrmUserAuthorityGroups();
            frm.ShowDialog();
        }
        async Task GetLoadGroupTry()
        {

            CmbGroup.DataSource = await rollsControl.GetGroups();//db.itemCategories.ToList();
            CmbGroup.DisplayMember = "GroupRollName";
            CmbGroup.ValueMember = "Id";
            try
            {
                CmbGroup.SelectedItem = 0;

            }
            catch
            {

                return;
            }


        }
        async Task getMyRoll()
        {
            RollsControl control = new RollsControl();


            var myRoll = await control.getMyRoll(Program.userGroupId);


            if (myRoll == null)
            {
                return;
            }


            foreach (var item in myRoll)
            {

                if (item.RollTitle == "المجموعات")
                {
                    if (item.IsChecked == "False")
                    {
                        simpleButton5.Enabled = Convert.ToBoolean(item.IsChecked);
                    }
                }


            }






        }
        async Task GetAccounts()
        {
            AccountControl accControl = new AccountControl();

            CmbAccounts.DataSource = await accControl.GetAllAccount(Properties.Settings.Default.PropMainAccountCashes);//db.itemCategories.ToList();
            CmbAccounts.DisplayMember = "AccountName";
            CmbAccounts.ValueMember = "Id";

        }

        private async void FrmUserSetting_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            await GetAccounts();

            await GetLoadGroupTry();
            timerLoad.Start();

        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            timerLoad.Stop();
            GetLoad();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtName.Enabled = true;
            userBindingSource.MoveLast();
            User obj = userBindingSource.Current as User;
            if (obj != null)
            {
                if (obj.Id == 0)
                {
                    TxtName.Focus();
                }
                else
                {
                    userBindingSource.Add(new User());
                    userBindingSource.MoveLast();
                    TxtName.Focus();
                    pictureEdit1.Image = null;

                }
            }
        }

      async  private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtName.Focus();

                return;
            }
            if (string.IsNullOrEmpty(TxtFullName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtFullName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtPwd.Text))
            {
                DesktopAlert.Show("حقل رمز المرور فارغ " + "\n" + "Password is Empity ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtPwd.Focus();

                return;
            }
            if (string.IsNullOrEmpty(TxtPwd2.Text))
            {
                DesktopAlert.Show("حقل رمز المرور فارغ " + "\n" + "Password is Empity ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtPwd2.Focus();

                return;
            }
            if (TxtPwd.Text!=TxtPwd2.Text)
            {
                DesktopAlert.Show("حقلين رمز المرور غير متطابقين " + "\n" + " Password Fields is not matched ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                return;


            }
            if (CmbGroup.Text =="" || string.IsNullOrEmpty(CmbGroup.Text))
            {
                CmbGroup.Focus();

                DesktopAlert.Show(" يجب اختيار مجموعة الصلاحيات " + "\n" + " Group of Rolls is not selected ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                return;

            }

            if (!string.IsNullOrEmpty(TxtQuestion.Text))
            {
                if (string.IsNullOrEmpty(TxtAnswer.Text))
                {
                    DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                    TxtAnswer.Focus();
                    return;
                }
              
            }
            else
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtQuestion.Focus();
                return;
            }

            User obj = userBindingSource.Current as User;

            if (obj.Id>0)
            {
                if (CheckIsAcc.Checked)
                {
                    if (string.IsNullOrEmpty(CmbAccounts.Text))
                    {
                        DesktopAlert.Show(" يجب إختيار الحساب النقدي " + "\n" + " Cash Account Not Selected ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                        return;

                    }
                }

            }
          

            if (obj != null)
            {

                obj.Image = AttachInvoiceFile(AttachedFile);
                if (obj.Id == 0)
                {
                    if (CheckIsAcc.Checked)
                    {
                        var acc = new Accounts()
                        {
                            MAccountLabelId = 101,
                            Accounttype = 0,
                            AccountName ="نقدي - "+ obj.FullName
                        };

                   var rsltAc=     await accControl.AddToAcc(acc);

                        if (rsltAc<=0)
                        {
                            DesktopAlert.Show(" لم يتم إضافة الحساب النقدي " + "\n" + " Cash Account No Exsist Try Again ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                            return;
                        }else
                        {

                            obj.CashAccountId = acc.Id;
                        }
                    }

                }

                obj.groupRoll = null;
                obj.Pwd = helper.Base64Encode(TxtPwd.Text);
                var s = await rollsControl.AddUser(obj);
                if (s > 0)
                {
                    DgvUsers.Refresh();
                    TxtName.Enabled = false;
                    userBindingSource.ResetBindings(false);
                    DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                    await GetAccounts();

                    TxtName.Enabled = false;
                    BtnAdd.Focus();

                }else
                {
                    DesktopAlert.Show("لم يتم الحفظ بنجاح " + "\n" + " Saved  Faild ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                }



            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (helper.ShowMessageConfirm(this.ParentForm, "Confirm   تأكيد ", " Delete this User ? | تاكيد حذف المستخدم ؟"))
            {



                using (MyDbContext db = new MyDbContext())
                {
                    User obj = userBindingSource.Current as User;




                    if (obj != null)
                    {

                        var grouped = db.RollGroup.Find(obj.groupRollId);

                        if (grouped!=null)
                        {
                            if (grouped.GroupRollName== "Support")
                            {
                                DesktopAlert.Show("لايمكن حذف هذا المستخدم  " + "\n" + " this user undeletable ", eDesktopAlertColor.Black, eAlertPosition.TopRight);

                                return;
                            }

                        }

                        //var bills = await A.GetaBillbyUserId(obj.Id);
                        //if (bills != null)
                        //{
                        //    DesktopAlert.Show("يوجد فواتير مرتبطة ! لايمكن حذف المستخدم " + "\n" + "user has a bill related ! ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        //    return;
                        //}


                        var trans = await accControl.GetTransByUseer(obj.Id);
                        if (trans != null)
                        {
                            DesktopAlert.Show("يوجد حركة على الحساب ! لايمكن حذف المستخدم " + "\n" + "user has a trans related ! ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                            return;
                        }

                        if (db.Entry<User>(obj).State == EntityState.Detached)
                            db.Set<User>().Attach(obj);
                        db.Entry<User>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                        //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                        userBindingSource.RemoveCurrent();
                        TxtName.Enabled = false;
                        pictureEdit1.Image = null;

                    }
                }
            }
        }

        byte[] AttachInvoiceFile(string FileName)
        {
            byte[] byteimag = new byte[0];

            if (FileName == string.Empty)
            {
                if (pictureEdit1.Image == null)
                {
                    //pictureEdit1.Image = Properties.Resources.;
                }
                try
                {
                    MemoryStream ms2 = new MemoryStream();
                    pictureEdit1.Image.Save(ms2, pictureEdit1.Image.RawFormat);
                    byteimag = ms2.ToArray();
                    return byteimag;
                }
                catch
                {
                    return byteimag;
                }

            }


            MemoryStream ms = new MemoryStream();
            pictureEdit1.Image.Save(ms, pictureEdit1.Image.RawFormat);
            byteimag = ms.ToArray();
            return byteimag;


            //FileStream fstream = File.OpenRead(FileName);
            //byte[] contents = new byte[fstream.Length];
            //fstream.Read(contents, 0, (int)fstream.Length);
            //fstream.Close();
            //byteimag = contents;
            //return contents;
        }

        void readimg()
        {
            MemoryStream ms = new MemoryStream();
            pictureEdit1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] imgData = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imgData, 0, imgData.Length);
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvUsers.Rows.Count > 0)
            {
                TxtName.Enabled = true;
            }

            User obj = userBindingSource.Current as User;
            pictureEdit1.Image = null;

            if (obj!=null)
            {
                TxtPwd.Text =helper.Base64Decode( obj.Pwd);
                TxtPwd2.Text = helper.Base64Decode(obj.Pwd);
                if (obj.Image!=null)
                {
                    try
                    {
                        byte[] img = (byte[])obj.Image;
                        MemoryStream ms = new MemoryStream(img);
                        pictureEdit1.Image = Image.FromStream(ms);
                    }
                    catch 
                    {

                        return;
                    }
                   
                }

            }

        }

        private void TxtPwd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (TxtPwd.Properties.PasswordChar=='*')
            {
                TxtPwd.Properties.PasswordChar = '\0';

            }else
            {
                TxtPwd.Properties.PasswordChar = '*';

            }
        }

        private void ButbrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureEdit1.Image = new Bitmap(open.FileName);
                AttachedFile = open.FileName;
                // image file path  
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image = null;
        }

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckIsAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIsAcc.Checked)
            {
                CmbAccounts.Visible = true;
            }
            else
            {
                CmbAccounts.Visible = false;

            }
        }
    }
}