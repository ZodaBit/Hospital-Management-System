using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HospitalMS
{
    public partial class Splush : DevExpress.XtraEditors.XtraForm
    {
        public Splush()
        {
            InitializeComponent();
        }

        private void Splush_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            shownligin();


            this.Hide();
        }
        public void shownligin()
        {

            LogIn vbe = new LogIn();
            vbe.Show();
        }

        private void Splush_Shown(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Splush_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Splush_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
      
    }
}