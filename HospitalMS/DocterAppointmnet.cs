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
    public partial class DocterAppointmnet : DevExpress.XtraEditors.XtraForm
    {
        public DocterAppointmnet()
        {
            InitializeComponent();
        }
        public Docterview labrq;
       
        public void loadsdata()
        {
            name.Text = ((Docterview)labrq).paitentname.Text;
            fathername.Text = ((Docterview)labrq).fathername.Text;
            sex.Text = ((Docterview)labrq).sex.Text;
            dates.Text = ((Docterview)labrq).date.Text;
            physciitianname.Text = ((Docterview)labrq).physitianname.Text;
            ids.Text = ((Docterview)labrq).paitentid.Text;
            Age.Text = ((Docterview)labrq).age.Text;

        }
        private void DocterAppointmnet_Load(object sender, EventArgs e)
        {

        }
    }
}