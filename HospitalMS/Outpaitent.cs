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
    public partial class Outpaitent : DevExpress.XtraEditors.XtraForm
    {
        public Outpaitent()
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
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEdit8_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void trreview()
        {
          
        }
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
           

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
        private void Outpaitent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Perscription' table. You can move, or remove it, as needed.
         //   this.perscriptionTableAdapter.Fill(this.hMSDataSet.Perscription);
            viewdata();
            loadsdata();
        }

        private void paitenids_Leave(object sender, EventArgs e)
        {
            viewdata();
        }

        private void paitenids_Move(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           // gridView1.ClearDocument();
           // gridControl1.DataSource = "";
         //   gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.foVitals.Where(c => c.PatientId == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void xrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // gridView1.ClearDocument();
            //gridControl1.DataSource = "";
          //  gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Xrayresultviews.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void labrToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    gridView1.ClearDocument();
            //gridControl1.DataSource = "";
           // gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Labratoryresults.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void ultrasoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  gridView1.ClearDocument();
           // gridControl1.DataSource = "";
          //  gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.UltrasoundRsultviews.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  gridView1.ClearDocument();
          //  gridControl1.DataSource = "";
           // gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Perscriptions.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void bedWardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oPDOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // gridView1.ClearDocument();
         //   gridControl1.DataSource = "";
         //   gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.OperationRequsts.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void referToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gridView1.ClearDocument();
           // gridControl1.DataSource = "";
         //   gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.Reffers.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void meToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  gridView1.ClearDocument();
           // gridControl1.DataSource = "";
           // gridControl1.DataSource = null;
            int ideo = int.Parse(paitenids.Text);
            var query = hgen.medicalcerteficateees.Where(c => c.PatientID == ideo).ToList();

            gridControl1.DataSource = query;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            X_rayorder ny = new X_rayorder();
            ny.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LabratoryOrder nu = new LabratoryOrder();
            nu.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Ultrasoundoredr hh = new Ultrasoundoredr();
            hh.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ECGorder nn = new ECGorder();
            nn.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            xryrsuview rr = new xryrsuview();
            rr.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Labrprt nb = new Labrprt();
            nb.Show();
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            frntPart gh = new frntPart();
            gh.Show();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            bedwards bds = new bedwards();
            bds.Show();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            OPDs gf = new OPDs();
            gf.Show();
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            Refferorder tw = new Refferorder();
            tw.Show();
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            Medicalcerteficatorder bt = new Medicalcerteficatorder();
            bt.Show();
        }

        private void xtraTabControl1_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Paitenthistory gh = new Paitenthistory(Convert.ToInt32(paitenids.Text));
            gh.Show();
        }

        private void cTScanToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }
    }
}