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
    public partial class Ctscanorder : DevExpress.XtraEditors.XtraForm
    {
        public Ctscanorder()
        {
            InitializeComponent();
        }
        DataTable dt2 = new DataTable();
        HMSgeneralentity hy = new HMSgeneralentity();
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
        public void SimpanGrid()
        {
            DataRow dr1 = dt2.NewRow();
            dr1[0] = paitentid.Text;
            dr1[1] = name.Text;
            dr1[2] = fathername.Text;
            dr1[3] = sex.Text;
            dr1[4] = Age.Text;
            dr1[5] = dates.Text;
            dr1[6] = physicianname.Text;
            dr1[7] = InvestigationType.Text;
            dr1[8] = investigationentity.Text;
            dr1[9] = chargeamount.Text;
            dr1[10] = chargestatus.Text;
            dt2.Rows.Add(dr1);
            gridControl11.DataSource = dt2;
        }
        public void columnss()
        {
            DataColumn dc1 = new DataColumn("PatientID");
            DataColumn dc2 = new DataColumn("PatientName");
            DataColumn dc3 = new DataColumn("FatherName");
            DataColumn dc4 = new DataColumn("Sex");
            DataColumn dc5 = new DataColumn("Age");
            DataColumn dc6 = new DataColumn("Date");
            DataColumn dc7 = new DataColumn("PhysicianName");
            DataColumn dc8 = new DataColumn("InvestigationType");
            DataColumn dc9 = new DataColumn("InvestigationEntity");
            DataColumn dc10 = new DataColumn("ChargeAmount");
            DataColumn dc11 = new DataColumn("ChargeStatus");
            dt2.Columns.Add(dc1);
            dt2.Columns.Add(dc2);
            dt2.Columns.Add(dc3);
            dt2.Columns.Add(dc4);
            dt2.Columns.Add(dc5);
            dt2.Columns.Add(dc6);
            dt2.Columns.Add(dc7);
            dt2.Columns.Add(dc8);
            dt2.Columns.Add(dc9);
            dt2.Columns.Add(dc10);
            dt2.Columns.Add(dc11);
            DataRow dr3 = dt2.NewRow();
            gridControl11.DataSource = dt2;
        }
        private void Ctscanorder_Load(object sender, EventArgs e)
        {
            loadsdata();
            columnss();
        }

        private void toolStripButton141_Click(object sender, EventArgs e)
        {
            SimpanGrid();
        }
    }
}