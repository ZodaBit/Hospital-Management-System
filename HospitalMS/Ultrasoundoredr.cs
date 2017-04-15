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
using System.Data.OleDb;

namespace HospitalMS
{
    public partial class Ultrasoundoredr : DevExpress.XtraEditors.XtraForm
    {
        public Ultrasoundoredr()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        HMSgeneralentity hy = new HMSgeneralentity();
        SqlCommand cmd;
        public void ultrasoundgroup()
        {
            var cnts = from t in hy.ultrasoundgroups select t;
            var lis = cnts.ToList();
            foreach (var p in lis)
            {
                // InvestigationType.Properties.Items.Clear();
                InvestigationType.Properties.Items.Add(p.GroupName);
                // comboBox1.Items.Clear();
                //comboBox1.Items.Add(p.GroupName);
            }
        }
        public void datagrd()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ultrasoundelemntadd where InvestigationType like('" + InvestigationType.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        string connectionstring = null;
        SqlConnection conn;
        DataTable dt2 = new DataTable();
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
        public void connecttion()
        {
            connectionstring = System.IO.File.ReadAllText("Test.txt");
        }
        public void savedata()
        {
            using (SqlBulkCopy rt = new SqlBulkCopy(conn))
            {
                rt.DestinationTableName = "ultrsasoundrequst";
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
                conn.Open();
                rt.WriteToServer(dt2);
                conn.Close();
            }
        }
        public void columnss()
        {
            DataColumn dc0 = new DataColumn("Ultrsoundrequsid", typeof(int));
            DataColumn dc1 = new DataColumn("PatientID", typeof(int));
            DataColumn dc2 = new DataColumn("PatientName", typeof(string));
            DataColumn dc3 = new DataColumn("FatherName", typeof(string));
            DataColumn dc4 = new DataColumn("Sex", typeof(string));
            DataColumn dc5 = new DataColumn("Age", typeof(int));
            DataColumn dc6 = new DataColumn("Date", typeof(DateTime));
            DataColumn dc7 = new DataColumn("PhysicianName", typeof(string));
            DataColumn dc8 = new DataColumn("InvestigationType", typeof(string));
            DataColumn dc9 = new DataColumn("InvestigationEntity", typeof(string));
            DataColumn dc10 = new DataColumn("ChargeAmount", typeof(int));
            DataColumn dc11 = new DataColumn("ChargeStatus", typeof(string));
            dt2.Columns.Add(dc0);
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
            gridControl9.DataSource = dt2;
        }
        public void SimpanGrid()
        {
            DataRow dr1 = dt2.NewRow();
            dr1[1] = paitentid.Text;
            dr1[2] = name.Text;
            dr1[3] = fathername.Text;
            dr1[4] = sex.Text;
            dr1[5] = Age.Text;
            dr1[6] = dates.Text;
            dr1[7] = physicianname.Text;
            dr1[8] = InvestigationType.Text;
            dr1[9] = investigationentity.Text;
            dr1[10] = chargeamount.Text;
            dr1[11] = chargestatus.Text;
            dt2.Rows.Add(dr1);
            gridControl9.DataSource = dt2;
        }
        private void Ultrasoundoredr_Load(object sender, EventArgs e)
        {
            loadsdata();
            columnss();
            ultrasoundgroup();
            notifyIcon1.ShowBalloonTip(60);
           
        }

        private void toolStripButton135_Click(object sender, EventArgs e)
        {
            SimpanGrid();
           
        }

        private void toolStripButton101_Click(object sender, EventArgs e)
        {
            savedata();
            cleardatas();
        }
        public void cleardatas()
        {
            InvestigationType.Text = "";
            investigationentity.Text = "";
            gridControl9.DataSource = null;
            dataGridView1.DataSource = null;
            chargeamount.Text = "";
        }
        private void InvestigationType_Leave(object sender, EventArgs e)
        {
            datagrd();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    if (row != null)

                        investigationentity.Text = row.Cells["InvestigationEntity"].Value.ToString();
                    chargeamount.Text = row.Cells["Coast"].Value.ToString();
                  
                   


                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void panelControl107_Paint(object sender, PaintEventArgs e)
        {

        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    string excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;data source=" + path + ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                    OleDbConnection cones;
                    cones = new OleDbConnection(excelConnectionString);
                    cones.Open();

                    OleDbCommand com = new OleDbCommand("Select * from [Sheet1$]", cones);
                    OleDbDataReader dr = com.ExecuteReader();
                    using (conn)
                    {
                        conn.Open();
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                        {
                            // bulkCopy.ColumnMappings.Add("DrugId", "DrugId");

                            bulkCopy.ColumnMappings.Add("InvestigationType", "InvestigationType");

                            bulkCopy.ColumnMappings.Add("InvestigationEntity", "InvestigationEntity");

                            bulkCopy.ColumnMappings.Add("SubEntity", "SubEntity");

                            bulkCopy.ColumnMappings.Add("Report", "Report");
                            bulkCopy.ColumnMappings.Add("Coast", "Coast");
                            bulkCopy.ColumnMappings.Add("View1", "View1");
                            bulkCopy.ColumnMappings.Add("View2", "View2");
                            bulkCopy.ColumnMappings.Add("View3", "View3");
                         


                            bulkCopy.DestinationTableName = "ultrasoundelemntadd";

                            bulkCopy.WriteToServer(dr);

                        }
                        conn.Close();
                        MessageBox.Show("sucessfully added");
                    }
                }
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message.ToString());
            }
        }

        private void InvestigationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}