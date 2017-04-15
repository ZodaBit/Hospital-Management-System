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
    public partial class Vital_Signss : DevExpress.XtraEditors.XtraForm
    {
        public Vital_Signss()
        {
            InitializeComponent();
           
        }
        HMSgeneralentity gn = new HMSgeneralentity();
        foVital vt = new foVital();
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
           
            //var labEntities = hy.Labtests.Include(L => L.ChildEntities).Where(lt => lt.ChildEntities.Count > 1).ToList();

            //bindingSource1.DataSource = labEntities;
            //var labEntitiy = (Labtest)bindingSource1.Current;

            //    bindingSource2.DataSource = labEntitiy.ChildEntities;
            //var labSubEntitiy = (Labtest)bindingSource2.Current;

            //    bindingSource3.DataSource = labSubEntitiy.ChildEntities;


        }
        private void Vital_Signss_Load(object sender, EventArgs e)
        {
            loadsdata();
            int ideo = int.Parse(paitentid.Text);
            var query = gn.foVitals.Where(c => c.PatientId == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripButton131_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}