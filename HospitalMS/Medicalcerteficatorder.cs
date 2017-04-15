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
    public partial class Medicalcerteficatorder : DevExpress.XtraEditors.XtraForm
    {
        public Medicalcerteficatorder()
        {
            InitializeComponent();
        }
        HMSgeneralentity hn = new HMSgeneralentity();
        medicalcerteficateee mc = new medicalcerteficateee();
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
        public void savedata()
        {
            try
            {
                mc = hn.medicalcerteficateees.Create();
                mc.PatientID = int.Parse(paitentid.Text);
                mc.PatientName = name.Text;
                mc.FatherName = fathername.Text;
                mc.Sex = sex.Text;
                mc.Age = int.Parse(Age.Text);
                mc.Date = DateTime.Parse(dates.Text);
                mc.PhysicianName = physicianname.Text;
                mc.DiseaseType = disesetype.Text;
                mc.MedicineStartFrom = DateTime.Parse(medicinstart.Text);
                mc.UpTo = DateTime.Parse(uptos.Text);
                mc.Reason = Reason.Text;
                mc.ApprovedBy = Approvedby.Text;
                hn.medicalcerteficateees.Add(mc);
                hn.SaveChanges();
                clear();
                
            }
            catch (Exception aw)
            {
                MessageBox.Show(aw.Message.ToString());
                clear(); 
            }
        }
        public void updatsdata()
        {
            try
            {
                int idss = int.Parse(mcerteficatid.Text);
                mc = hn.medicalcerteficateees.Where(p => p.medcertefiID == idss).First();
                mc.PatientID = int.Parse(paitentid.Text);
                mc.PatientName = name.Text;
                mc.FatherName = fathername.Text;
                mc.Sex = sex.Text;
                mc.Age = int.Parse(Age.Text);
                mc.Date = DateTime.Parse(dates.Text);
                mc.PhysicianName = physicianname.Text;
                mc.DiseaseType = disesetype.Text;
                mc.MedicineStartFrom = DateTime.Parse(medicinstart.Text);
                mc.UpTo = DateTime.Parse(uptos.Text);
                mc.Reason = Reason.Text;
                mc.ApprovedBy = Approvedby.Text;
                hn.SaveChanges();
                clear();
            }
            catch (Exception wy)
            {
                MessageBox.Show(wy.Message.ToString());
                clear();
            }
        }
        public void removedatsa()
        {
            try
            {
                int idss = int.Parse(mcerteficatid.Text);
                mc = hn.medicalcerteficateees.Where(p => p.medcertefiID == idss).First();
                hn.medicalcerteficateees.Remove(mc);
                hn.SaveChanges();
                clear();
            }
            catch (Exception op)
            {
                MessageBox.Show(op.Message.ToString());
                clear();
            }
        }
        public void clear()
        {
            disesetype.Text = "";
            medicinstart.DateTime = DateTime.Now;
            uptos.DateTime = DateTime.Now;
            Reason.Text = "";
            Approvedby.Text = "";
        }
        private void Medicalcerteficatorder_Load(object sender, EventArgs e)
        {
            loadsdata();
        }

        private void toolStripButton45_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void toolStripButton46_Click(object sender, EventArgs e)
        {
            updatsdata();
        }

        private void toolStripButton51_Click(object sender, EventArgs e)
        {
            removedatsa();
        }

        private void toolStripButton52_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}