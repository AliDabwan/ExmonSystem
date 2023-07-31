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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmonSystem
{
    public partial class FrmProfile : DevExpress.XtraEditors.XtraForm
    {
        Helper helper = new Helper();

        RollsControl rollsControl = new RollsControl();
        string AttachedFile = "";
        public FrmProfile()
        {
            InitializeComponent();
        }
        byte[] AttachInvoiceFile(string FileName)
        {
            byte[] byteimag = new byte[0];

            if (FileName == string.Empty)
            {
                if (pictureEdit1.Image == null)
                {
                    //pictureEdit1.Image = Properties.Resources.;
                    return byteimag;

                }
                MemoryStream ms2 = new MemoryStream();
                pictureEdit1.Image.Save(ms2, pictureEdit1.Image.RawFormat);
                byteimag = ms2.ToArray();
                return byteimag;
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
        async void GetLoad()
        {
            var myuser= await rollsControl.GetUsers(Program.userId);
            if (myuser==null)
            {
                return;

            }
            TxtGroupName.Text = myuser.groupRoll.GroupRollName;

            userBindingSource.DataSource = myuser; //db.itemCategories.ToList();
            TxtPwd.Text = helper.Base64Decode(myuser.Pwd);
            pictureEdit1.Image = null;

            if (myuser != null)
            {
                if (myuser.Image != null)
                {
                    try
                    {
                        byte[] img = (byte[])myuser.Image;
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
        async  private void FrmProfile_Load(object sender, EventArgs e)
        {
            GetLoad();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("الحقل فارغ " + "\n" + " Empity  Field ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
            if (string.IsNullOrEmpty(TxtPwd.Text))
            {
                DesktopAlert.Show("حقل رمز المرور فارغ " + "\n" + "Password is Empity ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }
           
         
            using (MyDbContext db = new MyDbContext())
            {
                User obj = userBindingSource.Current as User;
                if (obj != null)
                {

                    obj.Image = AttachInvoiceFile(AttachedFile);
                    obj.Pwd = helper.Base64Encode(TxtPwd.Text);
                    if (db.Entry<User>(obj).State == EntityState.Detached)
                        db.Set<User>().Attach(obj);
                    if (obj.Id == 0)

                        db.Entry<User>(obj).State = EntityState.Added;
                    else
                        db.Entry<User>(obj).State = EntityState.Modified;
                    db.SaveChangesAsync();
                    DesktopAlert.Show("تم الحفظ بنجاح " + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);

                   

                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return;
            }

            using (MyDbContext db = new MyDbContext())
            {
                User obj = userBindingSource.Current as User;
                if (obj != null)
                {
                    if (db.Entry<User>(obj).State == EntityState.Detached)
                        db.Set<User>().Attach(obj);
                    db.Entry<User>(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                    //helper.ShowMessage(this, "", "تم الحذف بنجاح " + "\n" + "Deleted  Done ");
                    //DesktopAlert.Show("تم بنجاح " + "\n" + " Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
                    DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                    userBindingSource.RemoveCurrent();
                    pictureEdit1.Image = null;

                }
            }
        }

        private void BtnBrowes_Click(object sender, EventArgs e)
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

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image = null;

        }
    }
}