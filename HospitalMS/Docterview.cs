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
    public partial class Docterview : DevExpress.XtraEditors.XtraForm
    {
        public Docterview()
        {
            InitializeComponent();
        }
        HMSgeneralentity gn = new HMSgeneralentity();
        foPatient pa = new foPatient();
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void xrayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Docterview_Load(object sender, EventArgs e)
        {
            var query = from c in gn.foPatients select c;
            var users = query.ToList();
            dataGridView1.DataSource = users;
            this.reportViewer1.RefreshReport();
        }
        public void datapass()
        {
            // Docterview.ActiveForm.IsMdiContainer = true;
           
        }
        private void xrayOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            X_rayorder ny = new X_rayorder();
            ny.labrq = this;
            ny.Show();
        }

        private void toolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void labratoryOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            LabratoryOrder nu = new LabratoryOrder();
            nu.labrq = this;
            nu.Show();
        }

        private void ultrasounToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Ultrasoundoredr hh = new Ultrasoundoredr();
            hh.labrq = this;
            hh.Show();
        }

        private void eCGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ECGorder nn = new ECGorder();
            nn.labrq = this;
            nn.Show();
        }

        private void cTScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docters.ActiveForm.IsMdiContainer = true;
            Ctscanorder nh = new Ctscanorder();
            nh.MdiParent = Docters.ActiveForm;
            nh.Show();
        }

        private void xrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            xryrsuview rr = new xryrsuview();
          
            rr.Show();
        }

        private void toolStripDropDownButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Paitenthistory gh = new Paitenthistory(Convert.ToInt32(paitentid.Text));
            //gh.labrq = this;
            gh.Show();
        }

        private void toolStripDropDownButton3_Click_2(object sender, EventArgs e)
        {

        }

        private void bedWardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bedwards bds = new bedwards();
            bds.labrq = this;
            bds.Show();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labrToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Labrprt nb = new Labrprt();
           
            nb.Show();
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frntPart gh = new frntPart();
            gh.labrq = this;
            gh.Show();
        }

        private void oPDOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPDs gf = new OPDs();
            gf.labrq = this;
            gf.Show();
        }

        private void referToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refferorder tw = new Refferorder();
            tw.labrq = this;
            tw.Show();
        }

        private void meToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicalcerteficatorder bt = new Medicalcerteficatorder();
            bt.labrq = this;
            bt.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DocterAppointmnet ap = new DocterAppointmnet();
            ap.labrq = this;
            ap.Show();
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
            Docterview.ActiveForm.IsMdiContainer = true;
            Pharmacy br = new Pharmacy();
            br.MdiParent = Docterview.ActiveForm;
            br.Show();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    if (row != null)

                    paitentname.Text= row.Cells["FirstName"].Value.ToString(); ;
                     fathername.Text= row.Cells["MiddleName"].Value.ToString();
                     sex.Text = row.Cells["Sex"].Value.ToString();
                     date.DateTime = DateTime.Now;
                     age.Text = row.Cells["Age"].Value.ToString();
                     paitentid.Text= row.Cells["Id"].Value.ToString();



                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Vital_Signss bv = new Vital_Signss();
            bv.labrq = this;
            bv.Show();
        }

        private void outPaitentToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Outpaitent bc = new Outpaitent();
            bc.labrq = this;
            bc.Show();
        }

        private void inpaitentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            inpatient hj = new inpatient();
            hj.labrq = this;
            hj.Show();
        }

        private void ultrasoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ultrasounview bt = new ultrasounview();
            bt.Show();
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cTScanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CTscanview be = new CTscanview();
            be.Show();
        }

        private void paitenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labrepo ht = new labrepo();
            ht.Show();
        }

        private void xrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            X_rayreportForm bgt = new X_rayreportForm();
            bgt.Show();
        }

        private void perscribtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medhanit bt9 = new medhanit();
            bt9.Show();
        }

        private void labratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Labmelesemasayaform cew = new Labmelesemasayaform();
            cew.Show();
        }

        private void ultrasoundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ultrasoundmelseresult br = new Ultrasoundmelseresult();
            br.Show();
        }

        private void medicalCerteficateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicalcerteficateForm cd = new MedicalcerteficateForm();
            cd.Show();
        }

        private void refferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefferForm bw = new RefferForm();
            bw.Show();
        }

        private void toolStripDropDownButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void paitentid_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                int ideo = int.Parse(toolStripTextBox1.Text);
                var query = gn.foPatients.Where(c => c.Id == ideo).ToList();

                //  gridControl1.DataSource = query;
                dataGridView1.DataSource = query;
            }
            catch (Exception bf)
            {
            }
        }
    }
}