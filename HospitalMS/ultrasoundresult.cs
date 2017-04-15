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
    public partial class Ultrasoundresult : DevExpress.XtraEditors.XtraForm
    {
        
        public Ultrasoundresult()
        {
            InitializeComponent();
            //idautocomplet();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        string connectionstring = null;
        //HMSDataSet hh = new HMSDataSet();

        SqlConnection conn;
        DataTable dt = new DataTable();
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
      
        public void connecttion()
        {

            connectionstring = System.IO.File.ReadAllText("Test.txt");
        }
        public void viewsearchdata()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select View1,View2,View3 From UltrasoundRsultview where InvestigationType='" + InvestigationType.Text + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vw1.Text = reader["View1"].ToString();
                    vw2.Text = reader["View2"].ToString();
                    vw3.Text = reader["View3"].ToString();


                }
                conn.Close();
            }
            catch (Exception cz)
            {
                MessageBox.Show(cz.Message.ToString());
            }
        }
        public void savedata()
        {
            try
            {
                using (SqlBulkCopy rt = new SqlBulkCopy(conn))
                {
                    rt.DestinationTableName = "UltrasoundRsultview";
                  //  rt.ColumnMappings.Add("Ultrsoundrequsid", "Ultrsoundrequsid");
                    rt.ColumnMappings.Add("PatientID", "PatientID");
                    rt.ColumnMappings.Add("PatientName", "PatientName");
                    rt.ColumnMappings.Add("FatherName", "FatherName");
                    rt.ColumnMappings.Add("Sex", "Sex");
                    rt.ColumnMappings.Add("Age", "Age");
                    rt.ColumnMappings.Add("Date", "Date");
                    rt.ColumnMappings.Add("PhysicianName", "PhysicianName");
                    rt.ColumnMappings.Add("InvestigationType", "InvestigationType");
                    rt.ColumnMappings.Add("InvestigationEntity", "InvestigationEntity");
                    rt.ColumnMappings.Add("ChargeAmount", "ChargeAmount");
                    rt.ColumnMappings.Add("ChargeStatus", "ChargeStatus");
                    rt.ColumnMappings.Add("Result", "Result");
                    rt.ColumnMappings.Add("TechnicianName", "TechnicianName");
                    rt.ColumnMappings.Add("View1", "View1");
                    rt.ColumnMappings.Add("View2", "View2");
                    rt.ColumnMappings.Add("View3", "View3");
                   
                    conn.Open();
                    rt.WriteToServer(dt);
                    conn.Close();
                }

            }
            catch (Exception mh)
            {
                MessageBox.Show(mh.Message.ToString());
            }
        }
        private void Ultrasoundresult_Load(object sender, EventArgs e)
        {
            var query = from c in HMSgeneralentity.ultrsasoundrequsts select c;
            var users = query.ToList();
            dataGridView1.DataSource = users;
        }

        private void toolStripButton97_Click(object sender, EventArgs e)
        {
            savedata();
            clerrdats();
        }
        public void clerrdats()
        {
            vw1.Text = "";
            vw2.Text = "";
            vw3.Text = "";
            InvestigationType.Text = "";
            investigationentity.Text = "";
            ChargeAmount.Text = "";
            ChargeStatus.Text = "";
             gridControl8.DataSource = null; 
        }
        private void toolStripButton98_Click(object sender, EventArgs e)
        {
            clerrdats();
        }

        private void toolStripButton99_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton100_Click(object sender, EventArgs e)
        {
           
        }

        private void panelControl47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           // Result.ShowPrintPreview();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Result.Text = "";
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
           // Result.Undo();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
          //  Result.Redo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           // gridView1.ShowPrintPreview();
        }

        private void gridView9_Load(object sender, DevExpress.Utils.LayoutAllowEventArgs e)
        {
           
        }
         public void SimpanGrid()
        {
             
            DataRow dr1 = dt.NewRow();
            dr1[0] = labids.Text;
            dr1[1] = paitentid.Text;
            dr1[2] = name.Text;
            dr1[3] = fathername.Text;
            dr1[4] = sex.Text;
            dr1[5] = Agess.Text;
            dr1[6] = dates.Text;
            dr1[7] = physicianname.Text;
            dr1[8] = InvestigationType.Text;
            dr1[9] = investigationentity.Text;
            dr1[10] = ChargeAmount.Text ;
            dr1[11] = ChargeStatus.Text;
            dr1[12] = vw1.Text;
            dr1[13] = technitianname.Text;
            dr1[14] = vw1.Text;
            dr1[15] = vw2.Text;
            dr1[16] = vw3.Text;
            dt.Rows.Add(dr1);
            gridControl8.DataSource = dt;
        }
        private void toolStripButton129_Click(object sender, EventArgs e)
        {
            SimpanGrid();
        }

        private void toolStripButton131_Click(object sender, EventArgs e)
        {
           //gridView9.ShowPrintPreview();
        }

        private void toolStripButton130_Click(object sender, EventArgs e)
        {
           // gridView9.DeleteSelectedRows();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    if (row != null)

                        name.Text = row.Cells["PatientName"].Value.ToString(); ;
                    fathername.Text = row.Cells["FatherName"].Value.ToString();
                    sex.Text = row.Cells["Sex"].Value.ToString();
                    Agess.Text = row.Cells["Age"].Value.ToString();
                    //  int ag = Convert.ToInt32(Agess.Text);
                    dates.Text = row.Cells["Date"].Value.ToString();
                    physicianname.Text = row.Cells["PhysicianName"].Value.ToString();
                    paitentid.Text = row.Cells["PatientID"].Value.ToString();
                    InvestigationType.Text = row.Cells["InvestigationType"].Value.ToString();
                    investigationentity.Text = row.Cells["InvestigationEntity"].Value.ToString();
                    // subentity.Text = row.Cells["SubEntity"].Value.ToString();
                   
                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void gridControl8_Load(object sender, EventArgs e)
        {
            DataColumn dc1 = new DataColumn("Ultrsoundrequsid", typeof(int));
            DataColumn dc2 = new DataColumn("PatientID", typeof(int));
            DataColumn dc3 = new DataColumn("PatientName", typeof(string));
            DataColumn dc4 = new DataColumn("FatherName", typeof(string));
            DataColumn dc5 = new DataColumn("Sex", typeof(string));
            DataColumn dc6 = new DataColumn("Age", typeof(int));
            DataColumn dc7 = new DataColumn("Date", typeof(DateTime));
            DataColumn dc8 = new DataColumn("PhysicianName", typeof(string));
            DataColumn dc9 = new DataColumn("InvestigationType", typeof(string));
            DataColumn dc10 = new DataColumn("InvestigationEntity", typeof(string));
            DataColumn dc11 = new DataColumn("ChargeAmount", typeof(int));
            DataColumn dc12 = new DataColumn("ChargeStatus", typeof(string));
            DataColumn dc13 = new DataColumn("Result", typeof(string));
            DataColumn dc14 = new DataColumn("TechnicianName", typeof(string));
            DataColumn dc15 = new DataColumn("View1", typeof(string));
            DataColumn dc16 = new DataColumn("View2", typeof(string));
            DataColumn dc17 = new DataColumn("View3", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Columns.Add(dc9);
            dt.Columns.Add(dc10);
            dt.Columns.Add(dc11);
            dt.Columns.Add(dc12);
            dt.Columns.Add(dc13);
            dt.Columns.Add(dc14);
            dt.Columns.Add(dc15);
            dt.Columns.Add(dc16);
            dt.Columns.Add(dc17);
           
            DataRow dr1 = dt.NewRow();
            gridControl8.DataSource = dt;
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void xtraTabControl2_Click(object sender, EventArgs e)
        {
            viewsearchdata();
        }
    }
}