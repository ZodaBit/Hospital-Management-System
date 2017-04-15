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
    public partial class Refferorder : DevExpress.XtraEditors.XtraForm
    {
        public Refferorder()
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
            physicianname.Text = ((Docterview)labrq).physitianname.Text;
            paitentid.Text = ((Docterview)labrq).paitentid.Text;
            Age.Text = ((Docterview)labrq).age.Text;
        }
        HMSgeneralentity hn = new HMSgeneralentity();
        Reffer rf = new Reffer();
        private void panelControl62_Paint(object sender, PaintEventArgs e)
        {

        }
        public void savedataa()
        {
            try
            {
                rf = hn.Reffers.Create();
                rf.PatientID = int.Parse(paitentid.Text);
                rf.PatientName = name.Text;
                rf.FatherName = fathername.Text;
                rf.Sex = sex.Text;
                rf.Age = int.Parse(Age.Text);
                rf.Date = DateTime.Parse(dates.Text);
                rf.PhysicianName= physicianname.Text;
                rf.PaitientCase = paitentcase.Text;
                rf.TreatmentStartFrom = DateTime.Parse(treatmentstartfrm.Text);
                rf.DetailInformation = Detailinformation.Text;
                rf.RefferTo=referto.Text;
                hn.Reffers.Add(rf);
                hn.SaveChanges();
                clear();
            }
            catch (Exception ser)
            {
                MessageBox.Show(ser.Message.ToString());
                clear();
            }
        }
        public void updatsdata()
        {
            try
            {
                int refids = int.Parse(refferids.Text);
                rf = hn.Reffers.Where(p => p.RefferId == refids).First();
                rf.PatientID = int.Parse(paitentid.Text);
                rf.PatientName = name.Text;
                rf.FatherName = fathername.Text;
                rf.Sex = sex.Text;
                rf.Age = int.Parse(Age.Text);
                rf.Date = DateTime.Parse(dates.Text);
                rf.PhysicianName = physicianname.Text;
                rf.PaitientCase = paitentcase.Text;
                rf.TreatmentStartFrom = DateTime.Parse(treatmentstartfrm.Text);
                rf.DetailInformation = Detailinformation.Text;
                rf.RefferTo = referto.Text;
                hn.SaveChanges();
                clear();
            }
            catch (Exception qw)
            {
                MessageBox.Show(qw.Message.ToString());
                clear();


            }
        }
        public void removddata()
        {
            try
            {
                int refids = int.Parse(refferids.Text);
                rf = hn.Reffers.Where(p => p.RefferId == refids).First();
                hn.Reffers.Remove(rf);
                hn.SaveChanges();
                clear();
            }
            catch (Exception ju)
            {
                MessageBox.Show(ju.Message.ToString());
                clear();
            }
        }
        public void clear()
        {
            paitentcase.Text = "";
            treatmentstartfrm.DateTime = DateTime.Now;
            approvedby.Text = "";
            referto.Text = "";
            Detailinformation.Text = "";
            refferids.Value = 0;
            Detailinformation.Text="";
        }
        private void Refferorder_Load(object sender, EventArgs e)
        {
            loadsdata();
        }

        private void toolStripButton57_Click(object sender, EventArgs e)
        {
            savedataa();
        }

        private void toolStripButton58_Click(object sender, EventArgs e)
        {
            updatsdata();
        }

        private void toolStripButton59_Click(object sender, EventArgs e)
        {
            removddata();
        }
    }
}