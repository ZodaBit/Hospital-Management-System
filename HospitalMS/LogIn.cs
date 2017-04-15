using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HospitalMS
{
    public partial class LogIn : DevExpress.XtraEditors.XtraForm
    {
        HMSgeneralentity db = new HMSgeneralentity();

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var theUser = db.secUsers.Include("secPermissions").ToList().Where(u =>
            {
                return u.Name.ToLower() == txtUserName.Text.ToLower()
                         &&
                       u.PassWord == txtPassWord.Text;
            }).FirstOrDefault();

           if (theUser == null)
               MessageBox.Show("Log In failed user name or password incorrect.");
           else
           {
               this.Hide();
               Global.currentUser = theUser;
               MainForm mainForm = new MainForm();
               mainForm.Show();
           }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //.prevFormBoundApplication.Exit();

            //Application.Exit();

         
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}