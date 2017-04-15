using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace HospitalMS
{
    public partial class Drug_Interaction : DevExpress.XtraEditors.XtraForm
    {
        public Drug_Interaction()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        string connectionstring = null;
        //HMSDataSet hh = new HMSDataSet();

        SqlConnection conn;
        public void connecttion()
        {

            connectionstring = System.IO.File.ReadAllText("Test.txt");
        }
        private void Drug_Interaction_Load(object sender, EventArgs e)
        {

        }

        private void importDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;data source=" + path + ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                OleDbConnection cones;
                cones = new OleDbConnection(excelConnectionString);
                cones.Open();

                OleDbCommand com = new OleDbCommand("Select * from [Drug$]", cones);
                OleDbDataReader dr = com.ExecuteReader();
                using (conn)
                {
                    conn.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                       // bulkCopy.ColumnMappings.Add("DrugId", "DrugId");

                        bulkCopy.ColumnMappings.Add("DrugName", "DrugName");

                        bulkCopy.ColumnMappings.Add("DrugType", "DrugType");

                        bulkCopy.ColumnMappings.Add("Prescribed", "Prescribed");

                        bulkCopy.ColumnMappings.Add("CommonSide", "CommonSide");
                       bulkCopy.ColumnMappings.Add("PossibleSide", "PossibleSide");
                      // bulkCopy.ColumnMappings.Add("Warning", "Warning");
                        bulkCopy.ColumnMappings.Add("Alternatives", "Alternatives");
                        bulkCopy.ColumnMappings.Add("Brand", "Brand");

                        bulkCopy.DestinationTableName = "DrugDescription";

                        bulkCopy.WriteToServer(dr);

                    }
                    conn.Close();
                    MessageBox.Show("sucessfully added");
                }
            }
        }
    }
}