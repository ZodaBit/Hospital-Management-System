using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace HospitalMS
{
    public partial class LabreadingResult : DevExpress.XtraEditors.XtraForm
    {
        public LabreadingResult()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        string connectionstring = null;
        //HMSDataSet hh = new HMSDataSet();

        SqlConnection conn;
        //SqlCommand cmd;
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        DataTable dt2 = new DataTable();
        public void connecttion()
        {

            connectionstring = System.IO.File.ReadAllText("Test.txt");
        }
        private void LabreadingResult_Load(object sender, EventArgs e)
        {
            columnsadd();
            var query = from c in HMSgeneralentity.xrayrequs select c;
            var users = query.ToList();
            dataGridView1.DataSource = users;
            
        }
        public void viewsearchdata()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select View1,View2,View3 From Xrayentityadd where InvestigationType='" + InvestigationType.Text + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    imagestudyfindings.Text = reader["View1"].ToString();
                    view2.Text = reader["View2"].ToString();
                    view3.Text = reader["View3"].ToString();
                   
                   
                }
                conn.Close();
            }
            catch (Exception cz)
            {
                MessageBox.Show(cz.Message.ToString());
            }
        }
        public void columnsadd()
        {
            DataColumn dc1 = new DataColumn("XrayresultID", typeof(int));
            DataColumn dc2 = new DataColumn("PatientID", typeof(int));
            DataColumn dc3 = new DataColumn("PatientName", typeof(string));
            DataColumn dc4 = new DataColumn("FatherName", typeof(string));
            DataColumn dc5 = new DataColumn("Sex", typeof(string));
            DataColumn dc6 = new DataColumn("Age", typeof(int));
            DataColumn dc7 = new DataColumn("Date", typeof(DateTime));
            DataColumn dc8 = new DataColumn("PhysicianName", typeof(string));
            DataColumn dc9 = new DataColumn("InvestigationType", typeof(string));
            DataColumn dc10 = new DataColumn("InvestigationEntity", typeof(string));
            DataColumn dc11 = new DataColumn("ClinicalFindings", typeof(string));
            DataColumn dc12 = new DataColumn("Protocol", typeof(string));
            DataColumn dc13 = new DataColumn("ImageStuddingFindings", typeof(string));
            DataColumn dc14 = new DataColumn("Conclusion", typeof(string));
            DataColumn dc15 = new DataColumn("RadilogistName", typeof(string));
            DataColumn dc16 = new DataColumn("View1", typeof(string));
            DataColumn dc17 = new DataColumn("View2", typeof(string));
            DataColumn dc18 = new DataColumn("View3", typeof(string));
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
            dt2.Columns.Add(dc12);
            dt2.Columns.Add(dc13);
            dt2.Columns.Add(dc14);
            dt2.Columns.Add(dc15);
            dt2.Columns.Add(dc16);
            dt2.Columns.Add(dc17);
            dt2.Columns.Add(dc18);
            DataRow dr1 = dt2.NewRow();
            gridControl8.DataSource = dt2;
        }
        public void SimpanGrid()
        {
            DataRow dr1 = dt2.NewRow();
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
            dr1[10] = ClinicalFindings.Text;
            dr1[11] = protocol.Text;
            dr1[12] = imagestudyfindings.Text;
            dr1[13] = Conclusion.Text;
            dr1[14] = RadilogistNam.Text;
            dr1[15] = imagestudyfindings.Text;
            dr1[16] = view2.Text;
            dr1[17] = view3.Text;
           
            dt2.Rows.Add(dr1);
            gridControl8.DataSource = dt2;
        }
        public void savedata()
        {
            try
            {
                using (SqlBulkCopy rt = new SqlBulkCopy(conn))
                {
                    rt.DestinationTableName = "Xrayresultview";
                    rt.ColumnMappings.Add("XrayresultID", "XrayresultID");
                    rt.ColumnMappings.Add("PatientID", "PatientID");
                    rt.ColumnMappings.Add("PatientName", "PatientName");
                    rt.ColumnMappings.Add("FatherName", "FatherName");
                    rt.ColumnMappings.Add("Sex", "Sex");
                    rt.ColumnMappings.Add("Age", "Age");
                    rt.ColumnMappings.Add("Date", "Date");
                    rt.ColumnMappings.Add("PhysicianName", "PhysicianName");
                    rt.ColumnMappings.Add("InvestigationType", "InvestigationType");
                    rt.ColumnMappings.Add("InvestigationEntity", "InvestigationEntity");
                    rt.ColumnMappings.Add("ClinicalFindings", "ClinicalFindings");
                    rt.ColumnMappings.Add("Protocol", "Protocol");
                    rt.ColumnMappings.Add("ImageStuddingFindings", "ImageStuddingFindings");
                    rt.ColumnMappings.Add("Conclusion", "Conclusion");
                    rt.ColumnMappings.Add("RadilogistName", "RadilogistName");
                    rt.ColumnMappings.Add("View1", "View1");
                    rt.ColumnMappings.Add("View2", "View2");
                    rt.ColumnMappings.Add("View3", "View3");
                    conn.Open();
                    rt.WriteToServer(dt2);
                    conn.Close();
                }

            }
            catch (Exception mh)
            {
                MessageBox.Show(mh.Message.ToString());
            }
        }
        //public void requstadd()
        //{
        //    try
        //    {
        //        int ages = Convert.ToInt32(age.Text);
        //        DateTime dt = Convert.ToDateTime(date.Text);
        //        int amount = Convert.ToInt32(chargeamount.Text);
        //        int paitennam = Convert.ToInt32(paitentid.Text);
        //        gg = hh.xrayrequs.Create();
        //        gg.PatientName = paitentname.Text;
        //        gg.FatherName = fathername.Text;
        //        gg.Sex = Sex.Text;
        //        gg.Age = ages;
        //        gg.Date = dt;
        //        gg.ChargeAmount = amount;
        //        gg.ChargeStatus = chargestatus.Text;
        //        gg.PhysicianName = physician.Text;
        //        gg.InvestigationType = Investigationtype.Text;
        //        gg.InvestigationEntity = invstiationentity.Text;
        //        gg.Result = result.Text;
        //        gg.PatientID = paitennam;
        //        hh.xrayrequs.Add(gg);
        //        hh.SaveChanges();
        //        MessageBox.Show("add sucessfuly");
        //        requstclear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //        requstclear();
        //    }
        //}
        //public void requstupdate()
        //{
        //    try
        //    {
        //        int ages = Convert.ToInt32(age.Text);
        //        DateTime dt = Convert.ToDateTime(date.Text);
        //        int amount = Convert.ToInt32(chargeamount.Text);
        //        int paitennam = Convert.ToInt32(paitentid.Text);
        //        int xrayrqstid = Convert.ToInt32(xrayid.Text);
        //        gg = hh.xrayrequs.Where(p => p.xrayrequsID == xrayrqstid).First();
        //        gg.PatientName = paitentname.Text;
        //        gg.FatherName = fathername.Text;
        //        gg.Sex = Sex.Text;
        //        gg.Age = ages;
        //        gg.Date = dt;
        //        gg.ChargeAmount = amount;
        //        gg.ChargeStatus = chargestatus.Text;
        //        gg.PhysicianName = physician.Text;
        //        gg.InvestigationType = Investigationtype.Text;
        //        gg.InvestigationEntity = invstiationentity.Text;
        //        gg.Result = result.Text;
        //        gg.PatientID = paitennam;
        //        hh.SaveChanges();
        //        MessageBox.Show("Update sucessfuly");
        //        requstclear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //        requstclear();
        //    }
        //}
        //public void requstdeleted()
        //{
        //    try
        //    {
        //        int xrayrqstid = Convert.ToInt32(xrayid.Text);
        //        gg = hh.xrayrequs.Where(p => p.xrayrequsID == xrayrqstid).First();
        //        hh.xrayrequs.Remove(gg);
        //        hh.SaveChanges();
        //        MessageBox.Show("Deleted sucessfuly");
        //        requstclear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //        requstclear();
        //    }

        //}
        //public void requstclear()
        //{
        //    xrayid.Text = "";
        //    paitentid.Text = "";
        //    paitentname.Text = "";
        //    fathername.Text = "";
        //    Sex.Text = "";
        //    age.Text = "";
        //    date.DateTime = DateTime.Now;
        //    physician.Text = "";
        //    Radiologyst.Text = "";
        //    invstiationentity.Text = "";
        //    Investigationtype.Text = "";
        //    chargeamount.Text = "";
        //    chargestatus.Text = "";
        //    result.Text = "";
        //}
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           
        }
        //
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           // result.ShowPrintPreview();
        }

        private void richEditControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton97_Click(object sender, EventArgs e)
        {
            //requstadd();
            savedata();
            clrdatss();
        }
        public void clrdatss()
        {
            ClinicalFindings.Text = "";
            protocol.Text = "";
            Conclusion.Text = "";
            InvestigationType.Text = "";
            investigationentity.Text = "";
            chargeamount.Text = "";
            chargestatus.Text = "";
            gridControl8.DataSource = null;
            imagestudyfindings.Text = "";
            view2.Text = "";
            view3.Text = "";
        }
        private void toolStripButton98_Click(object sender, EventArgs e)
        {
            //requstupdate();
        }

        private void toolStripButton99_Click(object sender, EventArgs e)
        {
            //requstdeleted();
        }

        private void toolStripButton100_Click(object sender, EventArgs e)
        {
            //requstclear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton131_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton129_Click(object sender, EventArgs e)
        {
            SimpanGrid();
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
                   // int ag = Convert.ToInt32(Agess.Text);
                    dates.Text = row.Cells["Date"].Value.ToString();
                    physicianname.Text = row.Cells["PhysicianName"].Value.ToString();
                    paitentid.Text = row.Cells["PatientID"].Value.ToString();
                   // imagestudyfindings.Text = row.Cells["PatientID"].Value.ToString();
                    InvestigationType.Text = row.Cells["InvestigationType"].Value.ToString();
                    investigationentity.Text = row.Cells["InvestigationEntity"].Value.ToString();
                  //  subentity.Text = row.Cells["SubEntity"].Value.ToString();
                    viewsearchdata();
                    ClinicalFindings.Text = "";
                    protocol.Text = "";
                    Conclusion.Text = "";
                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void xtraTabControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
           
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl2_Click(object sender, EventArgs e)
        {
          //  viewsearchdata();
        }

        private void imagestudyfindings_Click(object sender, EventArgs e)
        {

        }
    }
}