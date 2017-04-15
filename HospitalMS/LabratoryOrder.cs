using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace HospitalMS
{

    public partial class LabratoryOrder : DevExpress.XtraEditors.XtraForm
    {

        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
       
        IEntity hw = new IEntity();
        ISubentity ng = new ISubentity();
        string connectionstring = null;
        SqlConnection conn;
        SqlCommand cmd;
        public LabratoryOrder()
        {
            InitializeComponent();
            loaddata();
            
            //bindingSource4.DataSource = labreqqquest;
            connecttion();
            conn = new SqlConnection(connectionstring);
         //   SqlDependency.Start(connectionstring);
        }
        public void loadinvestigation()
        {
           
          
             
        }
        public void connecttion()
        {
            try
            {
                connectionstring = System.IO.File.ReadAllText("Test.txt");
               
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
           
        }

        DataTable dt2 = new DataTable();
        laborderrequest kl = new laborderrequest();
        Labtest hh = new Labtest();
        Labrequst nm = new Labrequst();
        public Docterview labrq;
        labrequstts hj = new labrequstts();
        HMSgeneralentity hy = new HMSgeneralentity();
        List<Labrequst> labreqqquest = new List<Labrequst>();


        public void loadsdata()
        {
           name.Text= ((Docterview)labrq).paitentname.Text;
            fathername.Text = ((Docterview)labrq).fathername.Text;
            sex.Text = ((Docterview)labrq).sex.Text;
            dates.Text = ((Docterview)labrq).date.Text;
            physicianname.Text = ((Docterview)labrq).physitianname.Text;
            paitentid.Text = ((Docterview)labrq).paitentid.Text;
            Age.Text = ((Docterview)labrq).age.Text;

            

           
        }
        public void loadgrideview()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Labelemntadd where InvestigationType like('" + InvestigationType.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        public void labgroup()
        {
             var cnts = from t in hy.Labgroupnames select t;
            var lis = cnts.ToList();
            foreach (var p in lis)
            {
               // InvestigationType.Properties.Items.Clear();
                InvestigationType.Properties.Items.Add(p.GroupName);
               // comboBox1.Items.Clear();
                //comboBox1.Items.Add(p.GroupName);
            }
        }
        private void LabratoryOrder_Load(object sender, EventArgs e)
        {
            
            loadsdata();
            labgroup();
           
        }
       
        public void addlabreqsst()
        {
            
            //labrequstTableAdapter1.Insert(,paitidees, name, fathername.Text, sex.Text, aaages, dtt, physicianname.Text, InvestigationType.Text, investigationentity.Text, subentity.Text, crgeamoun, chargestatus.Text);
            DataSet sourceDataSet = new DataSet();
           // labrequstTableAdapter.Fill(sourceDataSet);
            gridControl8.DataSource = sourceDataSet.Tables[0];
           

        }
        
        public void SimpanGrid()
        {
            try
            {
                DataRow dr1 = dt2.NewRow();
                //LabrequstID
                //dr1[0] = int.Parse(labid.Text);
                dr1[1] = paitentid.Text;
                dr1[2] = name.Text;
                dr1[3] = fathername.Text;
                dr1[4] = sex.Text;
                dr1[5] = Age.Text;
                dr1[6] = dates.Text;
                dr1[7] = physicianname.Text;
                dr1[8] = InvestigationType.Text;
                dr1[9] = investigationentity.Text;
                dr1[10] = subentity.Text;
                dr1[11] = chargeamount.Text;
                dr1[12] = chargestatus.Text;
                dr1[13] = lwrbound.Text;
                dr1[14] = upprbound.Text;
                dt2.Rows.Add(dr1);
                gridControl8.DataSource = dt2;
            }
            catch (Exception nr)
            {
                MessageBox.Show(nr.Message.ToString());
            }
          
        }
        public void loaddata()
        {
            
        
        }
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void toolStripButton129_Click(object sender, EventArgs e)
        {
            SimpanGrid();
        }
        public void savedata()
        {
            try
            {
                using (SqlBulkCopy rt = new SqlBulkCopy(conn))
                {
                    rt.DestinationTableName = "Labrequst";
                    rt.ColumnMappings.Add("LabrequstID", "LabrequstID");
                    rt.ColumnMappings.Add("PatientID", "PatientID");
                    rt.ColumnMappings.Add("PatientName", "PatientName");
                    rt.ColumnMappings.Add("FatherName", "FatherName");
                    rt.ColumnMappings.Add("Sex", "Sex");
                    rt.ColumnMappings.Add("Age", "Age");
                    rt.ColumnMappings.Add("Date", "Date");
                    rt.ColumnMappings.Add("PhysicianName", "PhysicianName");
                    rt.ColumnMappings.Add("InvestigationType", "InvestigationType");
                    rt.ColumnMappings.Add("InvestigationEntity", "InvestigationEntity");
                    rt.ColumnMappings.Add("SubEntity", "SubEntity");
                    rt.ColumnMappings.Add("ChargeAmount", "ChargeAmount");
                    rt.ColumnMappings.Add("ChargeStatus", "ChargeStatus");
                    rt.ColumnMappings.Add("LowerBound", "LowerBound");
                    rt.ColumnMappings.Add("UpperBound", "UpperBound");
                    conn.Open();
                    rt.WriteToServer(dt2); 
                    conn.Close();
                    gridControl8.Controls.Clear();

                    //rt.NotifyAfter = 4;
                    //SqlNotificationType trt = new SqlNotificationType();
                    //SqlNotificationSource gd = new SqlNotificationSource();
                    //SqlInfoMessageEventArgs bh = new SqlInfoMessageEventArgs();
                    //SqlDependency fdu = new SqlDependency();


                    

                   
                }
            }
            catch (Exception gt)
            {
                MessageBox.Show(gt.Message.ToString());
            }
        }
        public void notifier()
        {
            SqlDependency.Stop(connectionstring);
            SqlDependency.Start(connectionstring);
       
            using (cmd=conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT PatientID, PatientName FROM Labrequst";
                cmd.Notification = null;
                SqlDependency dep = new SqlDependency(cmd);
                dep.OnChange += new OnChangeEventHandler(dep_onchange);
                cmd.ExecuteReader();
                MessageBox.Show("the data iserted");
            }
        }
        void dep_onchange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
                labelControl4.BeginInvoke(new MethodInvoker(notifier));
            else
                notifier();
            SqlDependency dep = sender as SqlDependency;
            dep.OnChange -= new OnChangeEventHandler(dep_onchange);
        }
       
        private void gridControl8_Load(object sender, EventArgs e)
        {
            try
            {
                DataColumn dc0 = new DataColumn("LabrequstID", typeof(int));
                DataColumn dc1 = new DataColumn("PatientID", typeof(int));
                DataColumn dc2 = new DataColumn("PatientName", typeof(string));
                DataColumn dc3 = new DataColumn("FatherName", typeof(string));
                DataColumn dc4 = new DataColumn("Sex", typeof(string));
                DataColumn dc5 = new DataColumn("Age", typeof(int));
                DataColumn dc6 = new DataColumn("Date", typeof(DateTime));
                DataColumn dc7 = new DataColumn("PhysicianName", typeof(string));
                DataColumn dc8 = new DataColumn("InvestigationType", typeof(string));
                DataColumn dc9 = new DataColumn("InvestigationEntity", typeof(string));
                DataColumn dc10 = new DataColumn("SubEntity", typeof(string));
                DataColumn dc11 = new DataColumn("ChargeAmount", typeof(int));
                DataColumn dc12 = new DataColumn("ChargeStatus", typeof(string));
                DataColumn dc13 = new DataColumn("LowerBound", typeof(string));
                DataColumn dc14 = new DataColumn("UpperBound", typeof(string));
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
                dt2.Columns.Add(dc12);
                dt2.Columns.Add(dc13);
                dt2.Columns.Add(dc14);
                DataRow dr3 = dt2.NewRow();
                gridControl8.DataSource = dt2;
              
            }
            catch (Exception we)
            {
                MessageBox.Show(we.Message.ToString());
            }
         
        }
        private DataRow LastDataRow = null;
        public void updats()
        {
            if (LastDataRow != null)
            {
                if (LastDataRow.RowState == DataRowState.Modified)
                {
                    labrequstTableAdapter1.Update(LastDataRow);
                }
            } 
        }
      
        private void regionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // if the user moves to a new row, check if the last row was changed
            BindingSource thisBindingSource = (BindingSource)sender;
            DataRow ThisDataRow = ((DataRowView)thisBindingSource.Current).Row;
            if (ThisDataRow == LastDataRow)
            {
              
                throw new ApplicationException("It seems the PositionChanged event was fired twice for the same row");
            }

            updats();
           
            LastDataRow = ThisDataRow;
        }
        private void toolStripButton131_Click(object sender, EventArgs e)
        {
         //   gridView1.ShowPrintPreview();
            gridControl8.ShowPrintPreview();
        }

        private void toolStripButton117_Click(object sender, EventArgs e)
        {
          
            savedata();
            cleardatss();
        }
        public void cleardatss()
        {
            InvestigationType.Text = "";
            investigationentity.Text = "";
            subentity.Text = "";
            gridControl8.DataSource = null;
            dataGridView1.DataSource = null;
            chargeamount.Text = "";
        }
        private void toolStripButton118_Click(object sender, EventArgs e)
        {
            gridControl8.Refresh();
        }

        private void LabratoryOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            updats();
        }

        private void InvestigationType_EditValueChanged(object sender, EventArgs e)
        {
           // gridView1.RefreshData();
        }

        private void InvestigationType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void InvestigationType_Leave(object sender, EventArgs e)
        {
            loadgrideview();
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
                    subentity.Text = row.Cells["SubEntity"].Value.ToString();
                    chargeamount.Text = row.Cells["Coast"].Value.ToString();
                    units.Text = row.Cells["Unit"].Value.ToString();
                    lwrbound.Text = row.Cells["LowerBound"].Value.ToString();
                    upprbound.Text = row.Cells["UpperBound"].Value.ToString();


                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void toolStrip32_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

                            bulkCopy.ColumnMappings.Add("Unit", "Unit");
                            bulkCopy.ColumnMappings.Add("Lowerbound", "Lowerbound");
                            bulkCopy.ColumnMappings.Add("Upperbound", "Upperbound");
                            bulkCopy.ColumnMappings.Add("Formula", "Formula");
                            bulkCopy.ColumnMappings.Add("UpperboundChildren", "UpperboundChildren");
                            bulkCopy.ColumnMappings.Add("LowerboundChildren", "LowerboundChildren");
                            bulkCopy.ColumnMappings.Add("TestType", "TestType");
                            bulkCopy.ColumnMappings.Add("defval", "defval");
                            bulkCopy.ColumnMappings.Add("UboundmC", "UboundmC");
                            bulkCopy.ColumnMappings.Add("lboundfC", "lboundfC");
                            bulkCopy.ColumnMappings.Add("Result", "Result");
                            bulkCopy.ColumnMappings.Add("Coast", "Coast");
                            bulkCopy.DestinationTableName = "Labelemntadd";

                            bulkCopy.WriteToServer(dr);

                        }
                        conn.Close();
                        MessageBox.Show("sucessfully added");
                        notifier();
                    }
                }
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message.ToString());
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton130_Click(object sender, EventArgs e)
        {
        
        }
    }
}