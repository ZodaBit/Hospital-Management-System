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
    public partial class frntPart : DevExpress.XtraEditors.XtraForm
    {
        public frntPart()
        {
            InitializeComponent();
        }
        string connectionstring = null;
        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
        AutoCompleteStringCollection dsr = new AutoCompleteStringCollection();
        SqlConnection conn;
        HMSgeneralentity gnr = new HMSgeneralentity();
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
            drugauto();
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
        public void drugauto()
        {
            DrugDescription ds = new DrugDescription();
            ds = gnr.DrugDescriptions.Create();
            var usw = gnr.DrugDescriptions;
            foreach (var g in usw)
            {
                data.Add(g.DrugName);
               
            }
            medicinename.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            medicinename.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            medicinename.MaskBox.AutoCompleteCustomSource = data;
           
        }
        public void ldty()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select DrugType From DrugDescription where DrugName='" + medicinename.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                medicinetype.Text = reader["DrugType"].ToString();
            }
            conn.Close();
            Frequancy.Text = "";
            Frome.Text = "";
            uptose.Text = "";
            Dosage.Text = "";
            Description.Text = "";
        }
           

        private void frntPart_Load(object sender, EventArgs e)
        {
            loadsdata();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        public void savedata()
        {
            try
            {
                using (SqlBulkCopy rt = new SqlBulkCopy(conn))
                {
                    rt.DestinationTableName = "Perscription";
                    rt.ColumnMappings.Add("perscriptionID", "perscriptionID");
                    rt.ColumnMappings.Add("PatientID", "PatientID");
                    rt.ColumnMappings.Add("PatientName", "PatientName");
                    rt.ColumnMappings.Add("FatherName", "FatherName");
                    rt.ColumnMappings.Add("Sex", "Sex");
                    rt.ColumnMappings.Add("Age", "Age");
                    rt.ColumnMappings.Add("Date", "Date");
                    rt.ColumnMappings.Add("PhysicianName", "PhysicianName");
                    rt.ColumnMappings.Add("MedicineType", "MedicineType");
                    rt.ColumnMappings.Add("MedicineName", "MedicineName");
                    rt.ColumnMappings.Add("Frequancy", "Frequancy");
                    rt.ColumnMappings.Add("Description", "Description");
                    rt.ColumnMappings.Add("StartDate", "StartDate");
                    rt.ColumnMappings.Add("UpTo", "UpTo");
                    rt.ColumnMappings.Add("Dosage", "Dosage");
                    conn.Open();
                    rt.WriteToServer(dt2);
                    conn.Close();
                }
            }
            catch (Exception gt)
            {
                MessageBox.Show(gt.Message.ToString());
            }
        }
        public void SimpanGrid()
        {
            DataRow dr1 = dt2.NewRow();
            dr1[0] =0;
            dr1[1] = paitentid.Text;
            dr1[2] = name.Text;
            dr1[3] = fathername.Text;
            dr1[4] = sex.Text;
            dr1[5] = Age.Text;
            dr1[6] = dates.Text;
            dr1[7] = physicianname.Text;
            dr1[8] = medicinetype.Text;
            dr1[9] = medicinename.Text;
            dr1[10] = Frequancy.Text;
            dr1[11] = Description.Text;
            dr1[12] = Frome.Text;
            dr1[13] = uptose.Text;
            dr1[14] = Dosage.Text;
           
            dt2.Rows.Add(dr1);
            gridControl14.DataSource = dt2;
        }
        private void gridControl14_Load(object sender, EventArgs e)
        {
            DataColumn dc1 = new DataColumn("perscriptionID", typeof(int));
            DataColumn dc2 = new DataColumn("PatientID", typeof(int));
            DataColumn dc3 = new DataColumn("PatientName", typeof(string));
            DataColumn dc4 = new DataColumn("FatherName", typeof(string));
            DataColumn dc5 = new DataColumn("Sex", typeof(string));
            DataColumn dc6 = new DataColumn("Age", typeof(int));
            DataColumn dc7 = new DataColumn("Date", typeof(DateTime));
            DataColumn dc8 = new DataColumn("PhysicianName", typeof(string));
            DataColumn dc9 = new DataColumn("MedicineType", typeof(string));
            DataColumn dc10 = new DataColumn("MedicineName", typeof(string));
            DataColumn dc11 = new DataColumn("Frequancy", typeof(string));
            DataColumn dc12 = new DataColumn("Description", typeof(string));
            DataColumn dc13 = new DataColumn("StartDate", typeof(DateTime));
            DataColumn dc14 = new DataColumn("UpTo", typeof(DateTime));
            DataColumn dc15 = new DataColumn("Dosage", typeof(string));
           
            // DataColumn dc16 = new DataColumn("Description");
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
            
            DataRow dr1 = dt2.NewRow();
            gridControl14.DataSource = dt2;
        }

        private void toolStripButton109_Click(object sender, EventArgs e)
        {
            SimpanGrid();
        }

        private void toolStripButton27_Click(object sender, EventArgs e)
        {
            savedata();
            cleardatts();
        }
        public void cleardatts()
        {
            medicinename.Text = "";
            medicinetype.Text = "";
            Frequancy.Text = "";
            Frome.Text = "";
            uptose.Text = "";
            Dosage.Text = "";
            Description.Text = "";
            gridControl14.DataSource = "";

        }
        private void medicinename_Leave(object sender, EventArgs e)
        {
            ldty();
        }

        private void toolStripButton111_Click(object sender, EventArgs e)
        {
            gridControl14.ShowPrintPreview();
        }
    }
}