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
    public partial class ECGorder : DevExpress.XtraEditors.XtraForm
    {
        public ECGorder()
        {
            InitializeComponent();
           
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        string connectionstring = null;
        SqlCommand cmd;
        SqlConnection conn;
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
        public void loadgrp()
        {
            var cnts = from t in hy.Ecggroups select t;
            var lis = cnts.ToList();
            foreach (var p in lis)
            {
                // InvestigationType.Properties.Items.Clear();
                InvestigationType.Properties.Items.Add(p.GroupName);
                // comboBox1.Items.Clear();
                //comboBox1.Items.Add(p.GroupName);
            }
        }
        public void connecttion()
        {
            try
            {
                connectionstring = System.IO.File.ReadAllText("Test.txt");
            }
            catch (Exception nr)
            {
                MessageBox.Show(nr.Message.ToString());
            }
        }
        public void SimpanGrid()
        {
            try
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
                gridControl10.DataSource = dt2;
            }
            catch (Exception br)
            {
                MessageBox.Show(br.Message.ToString());
            }
        }
        public void columnss()
        {
            try
            {
                DataColumn dc0 = new DataColumn("ECGrequstID", typeof(int));
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
                gridControl10.DataSource = dt2;
            }
            catch (Exception bw)
            {
                MessageBox.Show(bw.Message.ToString());
            }
        }
        public void savedata()
        {
            try
            {
                using (SqlBulkCopy rt = new SqlBulkCopy(conn))
                {
                    rt.DestinationTableName = "ECGrequst";
                    rt.ColumnMappings.Add("ECGrequstID", "ECGrequstID");
                    rt.ColumnMappings.Add("PatientID", "PatientID");
                    rt.ColumnMappings.Add("PatientName", "PatientName");
                    rt.ColumnMappings.Add("FatherName", "FatherName");
                    rt.ColumnMappings.Add("Sex", "Sex");
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
            catch (Exception mh)
            {
                MessageBox.Show(mh.Message.ToString());
            }
        }
        public void datagrd()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ecgelemntadd where InvestigationType like('" + InvestigationType.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ECGorder_Load(object sender, EventArgs e)
        {
            columnss();
            loadsdata();
            loadgrp();
        }

        private void toolStripButton138_Click(object sender, EventArgs e)
        {
            SimpanGrid();
            //loadsdata();
        }

        private void toolStripButton105_Click(object sender, EventArgs e)
        {
            savedata();
        }
        public void dataclear()
        {
            InvestigationType.Text = "";
            investigationentity.Text = "";
            chargeamount.Text = "";
            chargestatus.Text = "";
            gridControl10.DataSource = null;
            dataGridView1.DataSource = null;

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

                        investigationentity.Text = row.Cells["InvestigationEntity"].Value.ToString(); ;
                        chargeamount.Text = row.Cells["Coast"].Value.ToString();



                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }
    }
}