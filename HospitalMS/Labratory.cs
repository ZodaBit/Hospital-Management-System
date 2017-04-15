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
using System.Data.Sql;

namespace HospitalMS
{
    public partial class Labratory : DevExpress.XtraEditors.XtraForm
    {

        string connectionstring = null;
        //HMSDataSet hh = new HMSDataSet();

        SqlConnection conn;
        //SqlCommand cmd;
       
        DataTable dt2 = new DataTable();

        public Labratory()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        public void connecttion()
        {
          
            connectionstring = System.IO.File.ReadAllText("Test.txt");
        }
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        Labratoryresult lr = new Labratoryresult();
        public Docterview labrq;
        public void loadsdata()
        {

            SqlDataAdapter ada = new SqlDataAdapter("select * from Labrequst", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public void bloodresultadd()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("insert into Blood(ID,PatientID,PatientName,Sex,Age,Date,Physician,TechnitianName,DiagnosisType,HAEMOGLOBIN,TLC,NEUTROPHILS,LYMPHOCYTES,EOSINOPHIL,MONOCYTES,BASOPHILS,OTHERS,ESR)values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18)", conn);
            //    gh.Parameters.Add("@1", textEdit69.Text);
            //    gh.Parameters.Add("@2", textEdit70.Text);
            //    gh.Parameters.Add("@3", textEdit71.Text);
            //    gh.Parameters.Add("@4", comboBoxEdit1.Text);
            //    gh.Parameters.Add("@5", textEdit74.Text);
            //    gh.Parameters.Add("@6", dateEdit1.Text);
            //    gh.Parameters.Add("@7", textEdit1.Text);
            //    gh.Parameters.Add("@8", textEdit73.Text);
            //    //gh.Parameters.Add("@9", comboBoxEdit2.Text);
            //    //gh.Parameters.Add("@10", textEdit37.Text);
            //    //gh.Parameters.Add("@11", textEdit36.Text);
            //    //gh.Parameters.Add("@12", textEdit35.Text);
            //    //gh.Parameters.Add("@13", textEdit34.Text);
            //    //gh.Parameters.Add("@14", textEdit33.Text);
            //    //gh.Parameters.Add("@15", textEdit32.Text);
            //    //gh.Parameters.Add("@16", textEdit31.Text);
            //    //gh.Parameters.Add("@17", textEdit30.Text);
            //    //gh.Parameters.Add("@18", textEdit29.Text);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value add Successfully ");
            //    bloodresultclear();
            //}
            //catch (Exception mn)
            //{
            //    MessageBox.Show(mn.Message.ToString());
            //    conn.Close();
            //    bloodresultclear();
            //}
        }
        public void bloodresuledit()
        {
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand gh = new SqlCommand("Update  Blood set PatientID=@2,PatientName=@3,Sex=@4,Age=@5,Date=@6,Physician=@7,TechnitianName=@8,DiagnosisType=@9,HAEMOGLOBIN=@10,TLC=@11,NEUTROPHILS=@12,LYMPHOCYTES=@13,LYMPHOCYTES=@14,MONOCYTES=@15,BASOPHILS=@16,OTHERS=@17,ESR=@18 where ID=@1", conn);
        //        gh.Parameters.Add("@1", textEdit69.Text);
        //        gh.Parameters.Add("@2", textEdit70.Text);
        //        gh.Parameters.Add("@3", textEdit71.Text);
        //        gh.Parameters.Add("@4", comboBoxEdit1.Text);
        //        gh.Parameters.Add("@5", textEdit74.Text);
        //        gh.Parameters.Add("@6", dateEdit1.Text);
        //        gh.Parameters.Add("@7", textEdit1.Text);
        //        gh.Parameters.Add("@8", textEdit73.Text);
        //        //gh.Parameters.Add("@9", textEdit37.Text);
        //        //gh.Parameters.Add("@10", comboBoxEdit2.Text);
        //        //gh.Parameters.Add("@11", textEdit36.Text);
        //        //gh.Parameters.Add("@12", textEdit35.Text);
        //        //gh.Parameters.Add("@13", textEdit34.Text);
        //        //gh.Parameters.Add("@14", textEdit33.Text);
        //        //gh.Parameters.Add("@15", textEdit32.Text);
        //        //gh.Parameters.Add("@16", textEdit31.Text);
        //        //gh.Parameters.Add("@17", textEdit30.Text);
        //        //gh.Parameters.Add("@18", textEdit29.Text);
        //        gh.ExecuteNonQuery();
        //        conn.Close();
        //        MessageBox.Show("value update Successfully ");
        //        bloodresultclear();
        //    }
        //    catch (Exception ser)
        //    {
        //        MessageBox.Show(ser.Message.ToString());
        //        conn.Close();
        //        bloodresultclear();
        //    }
        }
        public void bloodresultdeleted()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand sc = new SqlCommand("Delete From  Blood   where ID=@selectedid", conn);
            //    string stdid = textEdit69.Text;
            //    sc.Parameters.AddWithValue("@selectedid", stdid);
            //    sc.ExecuteNonQuery();

            //    conn.Close();
            //    MessageBox.Show("deleted file");
            //    bloodresultclear();
            //}
            //catch (Exception es)
            //{
            //    MessageBox.Show(es.Message.ToString());
            //    conn.Close();
            //    bloodresultclear();
            //}
        }
        public void bloodresultclear()
        {
            // textEdit37.Text="";
            //textEdit36.Text="";
            // textEdit35.Text="";
            //textEdit34.Text="";
            //textEdit33.Text="";
            // textEdit32.Text="";
            // textEdit31.Text="";
            //textEdit30.Text="";
            //textEdit29.Text = "";
            ////textEdit69.Text = "";
            //comboBoxEdit2.Text = "";
        }
        private void xtraTabPage5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl3_Click(object sender, EventArgs e)
        {

        }
        public void labresult()
        {

        }
        public Labratory lab;
        public void lodlabreq()
        {
         
           
            
        }
        private void Labratory_Load(object sender, EventArgs e)
        {
            loadsdata();
           // label1.Text=((Labratory)lab)
        }

        private void xtraTabPage14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

           
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            bloodresultadd();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            bloodresuledit();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            bloodresultdeleted();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            bloodresultclear();
        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (InvestigationType.SelectedIndex == 0)
            //{
            //    investigationentity.Properties.Items.Clear();
            //    investigationentity.Properties.Items.Add("Complet Blood Count(CBC)");
            //    investigationentity.Properties.Items.Add("ESR");
            //    investigationentity.Properties.Items.Add("Hemoglobin ALC");
            //    investigationentity.Properties.Items.Add("Reticloyte count");
            //    investigationentity.Properties.Items.Add("Comb's Test(D)");
            //    investigationentity.Properties.Items.Add("Blood Group");
            //    investigationentity.Properties.Items.Add("Blood Film");
            //    investigationentity.Properties.Items.Add("Malaria Ag Test");
            //    investigationentity.Properties.Items.Add("CD4");
            //    investigationentity.Properties.Items.Add("COOMBSTest(Indirect)");
            //    investigationentity.Properties.Items.Add("Prepherial Smear");
            //    investigationentity.Properties.Items.Add("DIFFRENTIAL count");
            //    investigationentity.Properties.Items.Add("PLATELATE COUNT");
            //    investigationentity.Properties.Items.Add("COAGULATTION TIME");
            //    investigationentity.Properties.Items.Add("RBC MORPHOLOGY");
            //    investigationentity.Properties.Items.Add("SERUMIRON");
            //    investigationentity.Properties.Items.Add("FGRRITIN");
            //    investigationentity.Properties.Items.Add("VITB12");
            //    investigationentity.Properties.Items.Add("VOLATE");
            //    investigationentity.Properties.Items.Add("Pherepherial blood morphology");
            //    investigationentity.Properties.Items.Add("TIBC");


            //}
        }
        
        private void comboBoxEdit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (investigationentity.SelectedIndex == 0)
            //{
            //    subentity.Properties.Items.Clear();
            //    subentity.Properties.Items.Add("WBC");
            //    subentity.Properties.Items.Add("N");
            //    subentity.Properties.Items.Add("L");
            //    subentity.Properties.Items.Add("M");
            //    subentity.Properties.Items.Add("E");
            //    subentity.Properties.Items.Add("B");
            //    subentity.Properties.Items.Add("HGB");
            //    subentity.Properties.Items.Add("HCT");
            //    subentity.Properties.Items.Add("PLT");
            //    subentity.Properties.Items.Add("RBC");
            //    subentity.Properties.Items.Add("MCV");
            //    subentity.Properties.Items.Add("RDWC");
            //    subentity.Properties.Items.Add("MCH");
            //    subentity.Properties.Items.Add("MCHC");

            //}
            //else if (investigationentity.SelectedIndex == 5)
            //{
            //    subentity.Properties.Items.Clear();
            //    subentity.Properties.Items.Add("ABO");
            //    subentity.Properties.Items.Add("RH");
            //}
            //else if (investigationentity.SelectedIndex == 13)
            //{
            //    subentity.Properties.Items.Clear();
            //    subentity.Properties.Items.Add("PT");
            //    subentity.Properties.Items.Add("PTT");
            //}
        }

        private void gridControl8_Click(object sender, EventArgs e)
        {
            
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
            dr1[10] = subentity.Text;
            dr1[11] = result.Text;
            dr1[12] = unit.Text;
            dr1[13] = normalrange.Text;
            dr1[14] =status.Text;
            dr1[15] = tecnitianname.Text;
            dr1[16] = lwrbund.Text;
            dr1[17] = uperbund.Text; 
            dt2.Rows.Add(dr1);
            gridControl8.DataSource = dt2;
        }
        private void gridControl8_Load(object sender, EventArgs e)
        {
            DataColumn dc1 = new DataColumn("LabID",typeof(int));
            DataColumn dc2 = new DataColumn("PatientID",typeof(int));
            DataColumn dc3 = new DataColumn("PatientName",typeof(string));
            DataColumn dc4 = new DataColumn("FatherName",typeof(string));
            DataColumn dc5= new DataColumn("Sex",typeof(string));
            DataColumn dc6 = new DataColumn("Age",typeof(int));
            DataColumn dc7= new DataColumn("Date",typeof(DateTime));
            DataColumn dc8 = new DataColumn("PhysicianName",typeof(string));
             DataColumn dc9 = new DataColumn("InvestigationType",typeof(string));
            DataColumn dc10 = new DataColumn("InvestigationEntity",typeof(string));
            DataColumn dc11 = new DataColumn("SubEntity",typeof(string));
            DataColumn dc12 = new DataColumn("Result",typeof(string));
            DataColumn dc13 = new DataColumn("Unit",typeof(string));
            DataColumn dc14 = new DataColumn("NormalRange",typeof(string));
            DataColumn dc15 = new DataColumn("InvestigationStatus",typeof(string));
            DataColumn dc16 = new DataColumn("TechnitianName",typeof(string));
            DataColumn dc17 = new DataColumn("LowerBound", typeof(string));
            DataColumn dc18 = new DataColumn("UpperBound", typeof(string));
          
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
        public void savedata()
        {
            try
            {
                using (SqlBulkCopy rt = new SqlBulkCopy(conn))
                {
                    rt.DestinationTableName = "Labratoryresult";
                    rt.ColumnMappings.Add("LabID", "LabID");
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
                    rt.ColumnMappings.Add("Result", "Result");
                    rt.ColumnMappings.Add("Unit", "Unit");
                    rt.ColumnMappings.Add("NormalRange", "NormalRange");
                    rt.ColumnMappings.Add("InvestigationStatus", "InvestigationStatus");
                    rt.ColumnMappings.Add("TechnitianName", "TechnitianName");
                    rt.ColumnMappings.Add("LowerBound", "LowerBound");
                    rt.ColumnMappings.Add("UpperBound", "UpperBound");
                    conn.Open();
                    rt.WriteToServer(dt2);
                    conn.Close();
              
                    //           SqlCommand command = new SqlCommand(
                    //"SELECT ShipperID, CompanyName, Phone FROM dbo.Shippers", connection);

                    //           SqlNotificationRequest notficationRequest = new SqlNotificationRequest();
                    //          // notficationRequest. = "NotificationID";
                    //           notficationRequest.Options = "mySSBQueue";
                   
                }

            }
            catch (Exception mh)
            {
                MessageBox.Show(mh.Message.ToString());
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxEdit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (subentity.SelectedIndex == 0)
            //    labelControl8.Text = "M= 4.5-6.5,F=3.8-5.8";            //{

            //    labelControl12.Text = "10^6/µL";
            //    richEditControl2.Text = "The WBCs are used to fight infection.  They may decrease in some viral infections but usually increase in bacterial infections.";
            //}
            //else if (subentity.SelectedIndex == 1)
            //{
            //    labelControl8.Text = "M=45-75,F=45-70";
            //    labelControl12.Text = "%";
            //    richEditControl2.Text = "NE are WBCs that are used to fight infection.  They are increased inbacterial infections, inflammation, hemorrhage, exercise, and other disease states.";
            //}
            //else if (subentity.SelectedIndex == 2)
            //{
            //    labelControl8.Text = "M=20-40,F=20-40";
            //    labelControl12.Text = "%";
            //    richEditControl2.Text = "Lymphocytes are WBCs that control the immune system.  They can be increased in viral infections and other disease states.";
            //}
            //else if (subentity.SelectedIndex == 3)
            //{
            //    labelControl8.Text = "M=3-10,F=3-10";
            //    labelControl12.Text = "%";
            //    richEditControl2.Text = "Monocytes are large WBCs that eat foreign cells, bacteria, and parasites.  They are increased in the above conditions  and other disease states.";
            //}
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void labelControl120_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton129_Click(object sender, EventArgs e)
        {
            SimpanGrid();
        } 

        private void toolStripButton130_Click(object sender, EventArgs e)
        {
           // gridView9.DeleteSelectedRows();
        }

        private void toolStripButton131_Click(object sender, EventArgs e)
        {
            gridControl8.ShowPrintPreview();
        }

        private void panelControl12_Paint(object sender, PaintEventArgs e)
        {
 //           SqlCommand command = new SqlCommand(
 //"SELECT ShipperID, CompanyName, Phone FROM dbo.Shippers", connection);
        
 //           SqlNotificationRequest notficationRequest = new SqlNotificationRequest();
 //          // notficationRequest. = "NotificationID";
 //           notficationRequest.Options = "mySSBQueue";


        }
        
        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            savedata();
            cleardatat();
        }
        public void cleardatat()
        {
            InvestigationType.Text = "";
            investigationentity.Text = "";
            subentity.Text = "";
            result.Text = "";
            status.Text = "";
            richEditControl2.Text = "";
            gridControl8.DataSource = null;
        }
        private void xtraTabPage19_Paint(object sender, PaintEventArgs e)
        {
            //var query = from c in HMSgeneralentity.Labrequsts select c;
            //var users = query.ToList();
            //dataGridView1.DataSource = users;
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
           // MessageBox.Show("");
        }

        private void gridView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            MessageBox.Show("");
           
        }
        
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            MessageBox.Show("");
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void gridView1_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            
                MessageBox.Show("");
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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



                        name.Text = row.Cells["PatientName"].Value.ToString(); 

                    fathername.Text = row.Cells["FatherName"].Value.ToString();
                    sex.Text = row.Cells["Sex"].Value.ToString();
                    Agess.Text = row.Cells["Age"].Value.ToString();
                    //  int ag = Convert.ToInt32(Agess.Text);
                    dates.Text = row.Cells["Date"].Value.ToString();
                    physicianname.Text = row.Cells["PhysicianName"].Value.ToString();
                    paitentid.Text = row.Cells["PatientID"].Value.ToString();
                    InvestigationType.Text = row.Cells["InvestigationType"].Value.ToString();
                    investigationentity.Text = row.Cells["InvestigationEntity"].Value.ToString();
                    subentity.Text = row.Cells["SubEntity"].Value.ToString();
                    lwrbund.Text = row.Cells["Lowerbound"].Value.ToString();
                    uperbund.Text = row.Cells["Upperbound"].Value.ToString();
                    result.Text = "";
                    status.Text = "";
                    richEditControl2.Text = "";
                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
      
        }
    }
}