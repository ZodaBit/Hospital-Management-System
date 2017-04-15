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
    public partial class OPDs : DevExpress.XtraEditors.XtraForm
    {
        public OPDs()
        {
            InitializeComponent();
        }
        HMSgeneralentity gt = new HMSgeneralentity();
        OperationRequst hy = new OperationRequst();
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
        private void OPDs_Load(object sender, EventArgs e)
        {
            loadsdata();
        }
        public void savedata()
        {
            try
            {
                hy = gt.OperationRequsts.Create();
                hy.PatientID = int.Parse(paitentid.Text);
                hy.PatientName = name.Text;
                hy.FatherName = fathername.Text;
                hy.Sex = sex.Text;
                hy.Age = int.Parse(Age.Text);
                hy.Date = dates.Text;
                hy.PhysicianName = physicianname.Text;
                hy.OperatienDate =operationdate.Text ;
                hy.AssignedPhysician = assignphysician.Text;
                hy.Specification = specification.Text;
                gt.OperationRequsts.Add(hy);
                gt.SaveChanges();
                clear();

            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }
        public void updatss()
        {
            try
            {
                int idsds = int.Parse(operationis.Text);
                hy = gt.OperationRequsts.Where(p => p.operationID == idsds).First();
                hy.PatientID = int.Parse(paitentid.Text);
                hy.PatientName = name.Text;
                hy.FatherName = fathername.Text;
                hy.Sex = sex.Text;
                hy.Age = int.Parse(Age.Text);
                hy.Date = dates.Text;
                hy.PhysicianName = physicianname.Text;
                hy.OperatienDate = operationdate.Text;
                hy.AssignedPhysician = assignphysician.Text;
                hy.Specification = specification.Text;
                gt.SaveChanges();
                clear();
            }
            catch (Exception v3)
            {
                MessageBox.Show(v3.Message.ToString());
            }

        }
        public void remoeddata()
        {
            try
            {
                int idsds = int.Parse(operationis.Text);
                hy = gt.OperationRequsts.Where(p => p.operationID == idsds).First();
                gt.OperationRequsts.Remove(hy);
                gt.SaveChanges();
                clear();
            }
            catch (Exception wer)
            {
                MessageBox.Show(wer.Message.ToString());
            }
        }
        public void clear()
        {
            operationdate.DateTime = DateTime.Now;
            assignphysician.Text = "";
            operationtype.Text = "";
            specification.Text = "";
            requrment.Text = "";
            operationis.Text = "";
        }

        private void toolStripButton47_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void toolStripButton48_Click(object sender, EventArgs e)
        {
            updatss();
        }

        private void toolStripButton49_Click(object sender, EventArgs e)
        {
            remoeddata();
        }

        private void toolStripButton50_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}