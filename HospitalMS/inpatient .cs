using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace HospitalMS
{
    public partial class inpatient : DevExpress.XtraEditors.XtraForm
    {
        public inpatient()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        string connectionstring = null;
        //HMSDataSet hh = new HMSDataSet();

        SqlConnection conn;
        HMSgeneralentity hgen = new HMSgeneralentity();
        foPatient pt = new foPatient();
        public void connecttion()
        {

            connectionstring = System.IO.File.ReadAllText("Test.txt");
        }

        public void viewdata()
        {
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select FirstName, MiddleName,Sex,Age From foPatient where Id='" + paitenids.Text + "'", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    name.Text = reader["FirstName"].ToString();
            //    fathername.Text = reader["MiddleName"].ToString();
            //    sex.Text = reader["Sex"].ToString();
            //    Age.Text = reader["Age"].ToString();
            //}
            //conn.Close();


        }
        public Docterview labrq;
        public void loadsdata()
        {
            name.Text = ((Docterview)labrq).paitentname.Text;
            fathername.Text = ((Docterview)labrq).fathername.Text;
            sex.Text = ((Docterview)labrq).sex.Text;
            dates.Text = ((Docterview)labrq).date.Text;
            physicianname.Text = ((Docterview)labrq).physitianname.Text;
            paitenids.Text = ((Docterview)labrq).paitentid.Text;
            Age.Text = ((Docterview)labrq).age.Text;




        }
        private void inpatient_Load(object sender, EventArgs e)
        {
            loadsdata();
        }

        private void panelControl6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton27_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton26_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paitenids_Leave(object sender, EventArgs e)
        {
            viewdata();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.foVitals.Where(c => c.PatientId == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void xrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Xrayresultviews.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void labrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Labratoryresults.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void ultrasoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.UltrasoundRsultviews.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void cTScanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Perscriptions.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void bedWardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.bedwards.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void oPDOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.OperationRequsts.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void referToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Reffers.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void meToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.medicalcerteficateees.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Perscriptions.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.bedwards.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.OperationRequsts.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Reffers.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.medicalcerteficateees.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Paitenthistory gh = new Paitenthistory(Convert.ToInt32(paitenids.Text));
            gh.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ProgressNote fr = new ProgressNote();
            fr.Show();
        }
    }
}