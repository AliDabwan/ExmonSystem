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
    public partial class FrmRestorePassword : DevExpress.XtraEditors.XtraForm
    {
        RollsControl rollsControl = new RollsControl();
        Helper helper = new Helper();

        string AttachedFile = "";
        public FrmRestorePassword()
        {
            InitializeComponent();
        }
        async void GetLoad()
        {
            TxtPassord.Visible = false;

            answer = "";
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                TxtPassord.Visible = false;

                DesktopAlert.Show("اكتب اليوزر الخاص بك بشكل صحيح " + "\n" + " Enter User Name", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtName.Focus();
                answer = "";
                return;
            }
            var myuser= await rollsControl.GetUsers(TxtName.Text);
            if (myuser==null)
            {
                TxtPassord.Visible = false;

                DesktopAlert.Show("ليس لهذا اليوزر سؤال امان " + "\n" + " No Security Question For this User", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                answer = ""; Close();


                return;

            }
            TxtQuest.Text = myuser.SecurityQuestion;
            answer = myuser.SecurityAnswer;
            TxtPassord.Text = helper.Base64Decode(myuser.Pwd);
            if (string.IsNullOrEmpty(answer))
            {
                TxtPassord.Visible = false;

                DesktopAlert.Show("لاتوجد إجابة لسؤال الامان " + "\n" + " No Answer For this user ", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                answer = "";
                Close();
                return;
            }


        }
        private string answer = "";
          private void FrmRestorePassword_Load(object sender, EventArgs e)
        {
            GetLoad();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TxtPassord.Visible = false;

            if (string.IsNullOrEmpty(TxtAnswer.Text))
            {
                DesktopAlert.Show("إكتب إجابة سؤال الامان " + "\n" + " Enter Your Answer", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtAnswer.Focus();
                return;
            }
            
            if (TxtAnswer.Text == answer)
            {
                TxtPassord.Visible = true;
                timer1.Start();
            }
            else
            {
                DesktopAlert.Show("إجابة السؤال خاطئة " + "\n" + " Invalid Answer!", eDesktopAlertColor.Default, eAlertPosition.TopRight);
                TxtAnswer.Focus();
                TxtPassord.Visible = false;

                return;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnBrowes_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }

        private  void btnCheck_Click(object sender, EventArgs e)
        {
             GetLoad();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}