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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;


namespace HospitalMS
{
    public partial class Docters : DevExpress.XtraEditors.XtraForm
    {
        string connectionstring = null;
       // Perscription gg = new Perscription();
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        //string maintaind = "";
        string bioch = "";
        string stol = "";
        string blod = "";
        string cplon = "";
        string urn = "";
        string gastr = "";
        string xry = "";
        string sonog = "";
        string ecgs = "";
        string ultrs = "";
        string consis;string  olp;string consentr;string  occult;string  othr;
        string hgbs; string wbcs; string difaf; string hcts; string esrs; string rbcs; string platlats; string bllodgro; string bloodfilms;
        public Docters()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
            //checkedComboBoxEdit1.Properties.Items.Add("feysa", CheckState.Unchecked, true);
            //xkrayview();
            viewdata();
            //gg.perscribeload();
        }
        public void connecttion()
        {
           
            connectionstring = System.IO.File.ReadAllText("D:\\Test.txt");
        }
        public void perscriptionadd()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("insert into Perscription(ID,PatientID,PatientName,Sex,Age,Physician,Date,MedicineType,MedicineName,MedicineSpecification,Description,StartDate,UpTo,Dosage)values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14)", conn);
            //    gh.Parameters.Add("@1", textEdit18.Text);
            //    gh.Parameters.Add("@2", paitentid.Text);
            //    gh.Parameters.Add("@3", paitentname.Text);
            //    gh.Parameters.Add("@4", sex.Text);
            //    gh.Parameters.Add("@5", age.Text);
            //    gh.Parameters.Add("@6", physicianname.Text);
            //    gh.Parameters.Add("@7", date.Text);
            //    gh.Parameters.Add("@8", textEdit21.Text);
            //    gh.Parameters.Add("@9", textEdit22.Text);
            //    gh.Parameters.Add("@10", richEditControl1.Text);
            //    gh.Parameters.Add("@11", textEdit25.Text);
            //    gh.Parameters.Add("@12", dateEdit8.Text);
            //    gh.Parameters.Add("@13", dateEdit16.Text);
            //    gh.Parameters.Add("@14", textEdit24.Text);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value add Successfully ");
            //    perscriptionclear();
            //}
            //catch (Exception mn)
            //{
            //    MessageBox.Show(mn.Message.ToString());
            //    conn.Close();
            //    perscriptionclear();
            //}
        }
        public void perscriptionedit()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("Update  Perscription set PatientID=@2,PatientName=@3,Sex=@4,Age=@5,Physician=@6,Date=@7,MedicineType=@8,MedicineName=@9,MedicineSpecification=@10,Description=@11,StartDate=@12,UpTo=@13,Dosage=@14 where ID=@1", conn);
            //    gh.Parameters.Add("@1", textEdit18.Text);
            //    gh.Parameters.Add("@2", paitentid.Text);
            //    gh.Parameters.Add("@3", paitentname.Text);
            //    gh.Parameters.Add("@4", sex.Text);
            //    gh.Parameters.Add("@5", age.Text);
            //    gh.Parameters.Add("@6", physicianname.Text);
            //    gh.Parameters.Add("@7", date.Text);
            //    gh.Parameters.Add("@8", textEdit21.Text);
            //    gh.Parameters.Add("@9", textEdit22.Text);
            //    gh.Parameters.Add("@10", richEditControl1.Text);
            //    gh.Parameters.Add("@11", textEdit25.Text);
            //    gh.Parameters.Add("@12", dateEdit8.Text);
            //    gh.Parameters.Add("@13", dateEdit16.Text);
            //    gh.Parameters.Add("@14", textEdit24.Text);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value update Successfully ");
            //    perscriptionclear();
            //}
            //catch (Exception ser)
            //{
            //    MessageBox.Show(ser.Message.ToString());
            //    conn.Close();
            //    perscriptionclear();
            //}
        }
        public void perscriptiondeleted()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand sc = new SqlCommand("Delete From  Perscription  where ID=@selectedid", conn);
            //    string stdid = textEdit18.Text;
            //    sc.Parameters.AddWithValue("@selectedid", stdid);
            //    sc.ExecuteNonQuery();

            //    conn.Close();
            //    MessageBox.Show("deleted file");
            //    perscriptionclear();
            //}
            //catch (Exception es)
            //{
            //    MessageBox.Show(es.Message.ToString());
            //    conn.Close();
            //    perscriptionclear();
            //}
        }
        public void perscriptionclear()
        {
             medicinetype.Text="";
             medicinename.Text="";
             //Specification.Text="";
            Description.Text="";
             Frome.Text="";
           uptose.Text="";
           Dosage.Text = "";
           textEdit18.Text = "";
        }
        public void xrayadd()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("insert into xray(ID,PatientID,PatientName,Radiologist,Physician,Date,Sex,Age,ExaminationRequested)values(@1,@2,@3,@4,@5,@6,@7,@8,@9)", conn);
            //    //  gh.Parameters.Add("@1", textEdit46.Text);
            //    gh.Parameters.Add("@1", textEdit53.Text);
            //    gh.Parameters.Add("@2", paitentid.Text);
            //    gh.Parameters.Add("@3", paitentname.Text);
            //    gh.Parameters.Add("@4", xrayid.Text);
            //    gh.Parameters.Add("@5", physicianname.Text);
            //    gh.Parameters.Add("@6",date.Text);
            //    gh.Parameters.Add("@7", sex.Text);
            //    gh.Parameters.Add("@8", age.Text);
            //    gh.Parameters.Add("@9", richEditControl6.Text);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value add Successfully ");
            //    xrayclear();
            //}
            //catch (Exception mn)
            //{
            //    MessageBox.Show(mn.Message.ToString());
            //    conn.Close();
            //    xrayclear();
            //}
        }
        public void xrayedit()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("Update  Branch set PatientID=@2,PatientName=@3,Radiologist=@4,Physician=@5,Date=@6,Sex=@7,Age=@8,ExaminationRequested=@9 where ID=@1", conn);
            //    gh.Parameters.Add("@1", textEdit53.Text);
            //    gh.Parameters.Add("@2", paitentid.Text);
            //    gh.Parameters.Add("@3", paitentname.Text);
            //    gh.Parameters.Add("@4", xrayid.Text);
            //    gh.Parameters.Add("@5", physicianname.Text);
            //    gh.Parameters.Add("@6", date.Text);
            //    gh.Parameters.Add("@7", sex.Text);
            //    gh.Parameters.Add("@8", age.Text);
            //    gh.Parameters.Add("@9", richEditControl6.Text);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value update Successfully ");
            //    xrayclear();
            //}
            //catch (Exception re)
            //{
            //    MessageBox.Show(re.Message.ToString());
            //    conn.Close();
            //    xrayclear();
            //}
        }
        public void xraydeleted()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand sc = new SqlCommand("Delete From  xray  where ID=@selectedid", conn);
            //    string stdid = textEdit53.Text;
            //    sc.Parameters.AddWithValue("@selectedid", stdid);
            //    sc.ExecuteNonQuery();

            //    conn.Close();
            //    MessageBox.Show("deleted file");
            //    xrayclear();
            //}
            //catch (Exception es)
            //{
            //    MessageBox.Show(es.Message.ToString());
            //    conn.Close();
            //    xrayclear();
            //}
        }
        public void xrayclear()
        {
            //textEdit53.Text="";
            // textEdit1.Text="";
            //textEdit2.Text="";
            // textEdit52.Text="";
            //textEdit12.Text="";
            //dateEdit1.Text="";
            //comboBoxEdit3.Text="";
            age.Text="";
            richEditControl6.Text = "";
        }
        //public void diagnosisorder()
        //{
        //    try
        //    {
        //        conn.Open();
        //        if (checkEdit1.Checked == true)
        //        {
        //            bioch = checkEdit1.Text;

        //        }
        //        else if (checkEdit2.Checked == true)
        //        {
        //            stol = checkEdit2.Text;

        //        }
        //        if (checkEdit3.Checked == true)
        //        {
        //            blod = checkEdit3.Text;

        //        }
        //        if (checkEdit4.Checked == true)
        //        {
        //            cplon = checkEdit4.Text;

        //        }
        //        if (checkEdit6.Checked == true)
        //        {
        //            urn = checkEdit6.Text;

        //        }
        //        if (checkEdit5.Checked == true)
        //        {
        //            gastr = checkEdit5.Text;

        //        }
        //        if (checkEdit7.Checked == true)
        //        {
        //            xry = checkEdit7.Text;

        //        }
        //        if (checkEdit8.Checked == true)
        //        {
        //            sonog = checkEdit8.Text;

        //        }
        //        if (checkEdit9.Checked == true)
        //        {
        //            ecgs = checkEdit9.Text;

        //        }
        //        if (checkEdit10.Checked == true)
        //        {
        //            ultrs = checkEdit10.Text;

        //        }
        //        SqlCommand gh = new SqlCommand("insert into DiagnosisOrder(ID,PatientID,PatientName,PhysicianName,StaffID,Date,Biochemistry,Stool,Blood,Colonoscopy,Urine,Gastroscopy,Xray,Sonography,ECG,Ultrasound,OtherTest)values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17)", conn);
        //        gh.Parameters.Add("@1", textEdit48.Text);
        //        gh.Parameters.Add("@2", textEdit1.Text);
        //        gh.Parameters.Add("@3", textEdit2.Text);
        //        gh.Parameters.Add("@4", textEdit12.Text);
        //     //   gh.Parameters.Add("@5", textEdit13.Text);
        //        gh.Parameters.Add("@6", dateEdit1.Text);
        //        gh.Parameters.Add("@7", bioch);
        //        gh.Parameters.Add("@8", stol);
        //        gh.Parameters.Add("@9", blod);
        //        gh.Parameters.Add("@10", cplon);
        //        gh.Parameters.Add("@11", urn);
        //        gh.Parameters.Add("@12", gastr);
        //        gh.Parameters.Add("@13", xry);
        //        gh.Parameters.Add("@14", sonog);
        //        gh.Parameters.Add("@15", ecgs);
        //        gh.Parameters.Add("@16", ultrs);
        //        gh.Parameters.Add("@17", textEdit4.Text);
        //        gh.ExecuteNonQuery();
        //        conn.Close();
        //        MessageBox.Show("value add Successfully ");
        //        clear();
        //    }
        //    catch (Exception mn)
        //    {
        //        MessageBox.Show(mn.Message.ToString());
        //        conn.Close();
        //        clear();
        //    }
        //}
        public void diagnosisedit()
        {
        //    try
        //    {
        //        conn.Open();
        //        if (checkEdit1.Checked == true)
        //        {
        //            bioch = checkEdit1.Text;

        //        }
        //        else if (checkEdit2.Checked == true)
        //        {
        //            stol = checkEdit2.Text;

        //        }
        //        if (checkEdit3.Checked == true)
        //        {
        //            blod = checkEdit3.Text;

        //        }
        //        if (checkEdit4.Checked == true)
        //        {
        //            cplon = checkEdit4.Text;

        //        }
        //        if (checkEdit6.Checked == true)
        //        {
        //            urn = checkEdit6.Text;

        //        }
        //        if (checkEdit5.Checked == true)
        //        {
        //            gastr = checkEdit5.Text;

        //        }
        //        if (checkEdit7.Checked == true)
        //        {
        //            xry = checkEdit7.Text;

        //        }
        //        if (checkEdit8.Checked == true)
        //        {
        //            sonog = checkEdit8.Text;

        //        }
        //        if (checkEdit9.Checked == true)
        //        {
        //            ecgs = checkEdit9.Text;

        //        }
        //        if (checkEdit10.Checked == true)
        //        {
        //            ultrs = checkEdit10.Text;

        //        }
        //        SqlCommand gh = new SqlCommand("Update  DiagnosisOrder set PatientID=@2,PatientName=@3,PhysicianName=@4,StaffID=@5,Date=@6,Biochemistry=@7,Stool=@8,Blood=@9,Colonoscopy=@10,Urine=@11,Gastroscopy=@12,Xray=@13,Sonography=@14,ECG=@15,Ultrasound=@16,OtherTest=@17 where ID=@1", conn);
        //        gh.Parameters.Add("@1", textEdit48.Text);
        //        gh.Parameters.Add("@2", textEdit1.Text);
        //        gh.Parameters.Add("@3", textEdit2.Text);
        //        gh.Parameters.Add("@4", textEdit12.Text);
        //        gh.Parameters.Add("@5", textEdit13.Text);
        //        gh.Parameters.Add("@6", dateEdit1.Text);
        //        gh.Parameters.Add("@7", bioch);
        //        gh.Parameters.Add("@8", stol);
        //        gh.Parameters.Add("@9", blod);
        //        gh.Parameters.Add("@10", cplon);
        //        gh.Parameters.Add("@11", urn);
        //        gh.Parameters.Add("@12", gastr);
        //        gh.Parameters.Add("@13", xry);
        //        gh.Parameters.Add("@14", sonog);
        //        gh.Parameters.Add("@15", ecgs);
        //        gh.Parameters.Add("@16", ultrs);
        //        gh.Parameters.Add("@17", textEdit4.Text);
        //        gh.ExecuteNonQuery();
        //        conn.Close();
        //        MessageBox.Show("value update Successfully ");
        //        clear();
        //    }
        //    catch (Exception ser)
        //    {
        //        MessageBox.Show(ser.Message.ToString());
        //        conn.Close();
        //        clear();
        //    }
       }
        public void diagnosisdeleted()
        {
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand sc = new SqlCommand("Delete From  DiagnosisOrder   where ID=@selectedid", conn);
        //        string stdid = textEdit48.Text;
        //        sc.Parameters.AddWithValue("@selectedid", stdid);
        //        sc.ExecuteNonQuery();

        //        conn.Close();
        //        MessageBox.Show("deleted file");
        //        clear();
        //    }
        //    catch (Exception es)
        //    {
        //        MessageBox.Show(es.Message.ToString());
        //        conn.Close();
        //        clear();
        //    }
       }
        public void clear()
        {
            textEdit48.Text="";
             paitentid.Text="";
             paitentid.Text="";
            paitentname.Text="";
           textEdit3.Text="";
             date.Text="";
             checkEdit1.Checked = false;
             checkEdit2.Checked = false;
             checkEdit3.Checked = false;
             checkEdit4.Checked = false;
             checkEdit6.Checked = false;
             checkEdit5.Checked = false;
             checkEdit7.Checked = false;
             checkEdit8.Checked = false;
             checkEdit9.Checked = false;
             checkEdit10.Checked = false;
            textEdit4.Text = "";
        }
        private void xtraTabControl4_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage5_Paint(object sender,  PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter ada = new SqlDataAdapter("select * from FirstDiagnosis", conn);
            //DataTable dt = new DataTable();
            //ada.Fill(dt);
            //gridControl1.DataSource = dt;
        }
        public void stooltestadd()
        {
            //try
            //{
               
            //    if (checkEdit28.Checked == true)
            //    {
            //        consis = checkEdit28.Text;
            //    }
            //    else if (checkEdit27.Checked == true)
            //    {
            //        olp = "OP";
            //    }
            //    else if (checkEdit26.Checked == true)
            //    {
            //        consentr = checkEdit26.Text;
            //    }
            //    else if (checkEdit25.Checked == true)
            //    {
            //        occult = checkEdit25.Text;
            //    }
            //    else if (checkEdit24.Checked == true)
            //    {
            //        othr = checkEdit24.Text;
            //    }
            //    else
            //        return;
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("insert into StoolTest(ID,PatientID,PatientName,Sex,Age,Physician,Date,Consistency,OP,Consentration,OccultBlood,Other)values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", conn);
            //    gh.Parameters.Add("@1", textEdit48.Text);
            //    gh.Parameters.Add("@2", paitentid.Text);
            //    gh.Parameters.Add("@3", paitentname.Text);
            //    gh.Parameters.Add("@4", sex.Text);
            //    gh.Parameters.Add("@5", age.Text);
            //    gh.Parameters.Add("@6", physicianname.Text);
            //    gh.Parameters.Add("@7", date.Text);
            //    gh.Parameters.Add("@8", consis);
            //    gh.Parameters.Add("@9", olp);
            //    gh.Parameters.Add("@10", consentr);
            //    gh.Parameters.Add("@11", occult);
            //    gh.Parameters.Add("@12", othr);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value add Successfully ");
            //    clearstooltest();
            //}
            //catch (Exception gt)
            //{
            //    MessageBox.Show(gt.Message.ToString());
            //    conn.Close();
            //    clearstooltest();
            //}
        }
        public void stooltestedit()
        {
            //try
            //{
            //    conn.Open();
            //    if (checkEdit28.Checked == true)
            //    {
            //        consis = checkEdit28.Text;
            //    }
            //    if (checkEdit27.Checked == true)
            //    {
            //        olp = "OP";
            //    }
            //    if (checkEdit26.Checked == true)
            //    {
            //        consentr = checkEdit26.Text;
            //    }
            //    if (checkEdit25.Checked == true)
            //    {
            //        occult = checkEdit25.Text;
            //    }
            //    if (checkEdit24.Checked == true)
            //    {
            //        othr = checkEdit24.Text;
            //    }
            //    SqlCommand gh = new SqlCommand("Update  StoolTest set PatientID=@2,PatientName=@3,Sex=@4,Age=@5,Physician=@6,Date=@7,Consistency=@8,OP=@9,Consentration=@10,OccultBlood=@11,Other=@12 where ID=@1", conn);
            //    gh.Parameters.Add("@1", textEdit48.Text);
            //    gh.Parameters.Add("@2", paitentid.Text);
            //    gh.Parameters.Add("@3", paitentname.Text);
            //    gh.Parameters.Add("@4", sex.Text);
            //    gh.Parameters.Add("@5", age.Text);
            //    gh.Parameters.Add("@6", physicianname.Text);
            //    gh.Parameters.Add("@7", date.Text);
            //    gh.Parameters.Add("@8", consis);
            //    gh.Parameters.Add("@9", olp);
            //    gh.Parameters.Add("@10", consentr);
            //    gh.Parameters.Add("@11", occult);
            //    gh.Parameters.Add("@12", othr);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value update secssefuly");
            //    clearstooltest();
            //}
            //catch (Exception gt)
            //{
            //    MessageBox.Show(gt.Message.ToString());
            //    conn.Close();
            //    clearstooltest();
            //}
        }
        public void stooltestdeleted()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand sc = new SqlCommand("Delete From  StoolTest   where ID=@selectedid", conn);
            //    string stdid = textEdit48.Text;
            //    sc.Parameters.AddWithValue("@selectedid", stdid);
            //    sc.ExecuteNonQuery();

            //    conn.Close();
            //    MessageBox.Show("deleted file");
            //    clearstooltest();
            //}
            //catch (Exception es)
            //{
            //    MessageBox.Show(es.Message.ToString());
            //    conn.Close();
            //    clearstooltest();
                
            //}
        }
        public void clearstooltest()
        {
            checkEdit28.Checked = false;
            checkEdit27.Checked = false;
            checkEdit26.Checked = false;
            checkEdit25.Checked = false;
            checkEdit24.Checked = false;
        }
        public void hematologyadd()
        {
            //try
            //{
            //    conn.Open();
            //    if (checkEdit11.Checked)
            //    {
            //        wbcs = "tobecheaked";
            //    }
            //    if (checkEdit12.Checked)
            //    {
            //        difaf = "tobecheaked";
            //    }
                //if (checkEdit13.Checked)
                //{
                //    hgbs = "tobecheaked";
                //}
                //if (checkEdit14.Checked)
                //{
                //    hcts = "tobecheaked";
                //}
                //if (checkEdit15.Checked)
                //{
                //    esrs = "tobecheaked";
                //}
                //if (checkEdit16.Checked)
                //{
                //    rbcs = "tobecheaked";
                //}
                //if (checkEdit17.Checked)
                //{
                //    platlats = "tobecheaked";
                //}
                //if (checkEdit18.Checked)
                //{
                //    blod = "tobecheaked";
                //}
                //if (checkEdit19.Checked)
                //{
                //    bloodfilms = "tobecheaked";
                //}
            //    SqlCommand gh = new SqlCommand("insert into Hamatology(ID,PatientID,PatientName,Sex,Age,Physician,Date,WBC,DiffN,HGB,HCT,ESR,RBC,Platlate,BloodgroupsRh,BloodFilm)values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16)", conn);
            //    gh.Parameters.Add("@1", textEdit48.Text);
            //    gh.Parameters.Add("@2", paitentid.Text);
            //    gh.Parameters.Add("@3", paitentname.Text);
            //    gh.Parameters.Add("@4", sex.Text);
            //    gh.Parameters.Add("@5", age.Text);
            //    gh.Parameters.Add("@6", physicianname.Text);
            //    gh.Parameters.Add("@7", date.Text);
            //    gh.Parameters.Add("@8", wbcs);
            //    gh.Parameters.Add("@9", difaf);
            //    gh.Parameters.Add("@10", "vui");
            //    gh.Parameters.Add("@11", "hujh");
            //    gh.Parameters.Add("@12", "nmn");
            //    gh.Parameters.Add("@13", "bnmb");
            //    gh.Parameters.Add("@14", "hkj");
            //    gh.Parameters.Add("@15", "bnb");
            //    gh.Parameters.Add("@16", "fg");
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value add Successfully ");
            //    //clearstooltest();
            //}
            //catch (Exception gt)
            //{
            //    MessageBox.Show(gt.Message.ToString());
            //    conn.Close();
            //   // clearstooltest();
            //}


        }
        private void xtraTabPage15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl21_Paint(object sender, PaintEventArgs e)
        {

        }
        public void paitenthistoryadd()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("insert into PaitientHistory(ID,PatientName,Sex,Age,Physician,Date,Sign,History)values(@1,@2,@3,@4,@5,@6,@7,@8)", conn);
            //    gh.Parameters.Add("@1", paitentid.Text);
            //    gh.Parameters.Add("@2", paitentname.Text);
            //    gh.Parameters.Add("@3", sex.Text);
            //    gh.Parameters.Add("@4", age.Text);
            //    gh.Parameters.Add("@5", physicianname.Text);
            //    gh.Parameters.Add("@6", date.Text);
            //    gh.Parameters.Add("@7",richEditControl4.Text);
            //    gh.Parameters.Add("@8", richEditControl5.Text);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value add Successfully ");
            //    paitenhistoryclear();
            //}
            //catch (Exception mn)
            //{
            //    MessageBox.Show(mn.Message.ToString());
            //    conn.Close();
                //paitenhistoryclear();
            
        }
        public void paitenthistoryedit()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand gh = new SqlCommand("Update  PaitientHistory set PatientName=@2,Sex=@3,Age=@4,Physician=@5,Date=@6,Sign=@7,History=@8 where ID=@1", conn);
            //    gh.Parameters.Add("@1", paitentid.Text);
            //    gh.Parameters.Add("@2", paitentname.Text);
            //    gh.Parameters.Add("@3", sex.Text);
            //    gh.Parameters.Add("@4", age.Text);
            //    gh.Parameters.Add("@5", physicianname.Text);
            //    gh.Parameters.Add("@6", date.Text);
            //    gh.Parameters.Add("@7", richEditControl4.Text);
            //    gh.Parameters.Add("@8", richEditControl5.Text);
            //    gh.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("value update Successfully ");
            //    paitenhistoryclear();
            //}
            //catch (Exception ser)
            //{
            //    MessageBox.Show(ser.Message.ToString());
            //    conn.Close();
            //    paitenhistoryclear();
            //}
        }
        public void paitientdeleted()
        {
            //try
            //{
            //    conn.Open();
            //    SqlCommand sc = new SqlCommand("Delete From  PaitientHistory   where ID=@selectedid", conn);
            //    string stdid = paitentid.Text;
            //    sc.Parameters.AddWithValue("@selectedid", stdid);
            //    sc.ExecuteNonQuery();

            //    conn.Close();
            //    MessageBox.Show("deleted file");
            //    paitenhistoryclear();
            //}
            //catch (Exception es)
            //{
            //    MessageBox.Show(es.Message.ToString());
            //    conn.Close();
            //    paitenhistoryclear();
            //}
        }
        public void paitenhistoryclear()
        {
             //richEditControl4.Text="";
             //richEditControl5.Text = "";
        }
        private void Docters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet1.Previusillinese' table. You can move, or remove it, as needed.
            this.previusillineseTableAdapter.Fill(this.hMSDataSet1.Previusillinese);
            // TODO: This line of code loads data into the 'hMSDataSet.RoomService' table. You can move, or remove it, as needed.
            this.roomServiceTableAdapter.Fill(this.hMSDataSet.RoomService);

        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabControl6_Click(object sender, EventArgs e)
        {

        }

        private void gridControl7_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton56_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //diagnosisorder();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //diagnosisedit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //diagnosisdeleted();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void xtraTabControl12_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl11_Click(object sender, EventArgs e)
        {
           
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton65_Click(object sender, EventArgs e)
        {
            stooltestadd();
        }

        private void toolStripButton66_Click(object sender, EventArgs e)
        {
            stooltestedit();
        }

        private void toolStripButton67_Click(object sender, EventArgs e)
        {
            stooltestdeleted();
        }

        private void toolStripButton68_Click(object sender, EventArgs e)
        {
            clearstooltest();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton97_Click(object sender, EventArgs e)
        {
            xrayadd();
        }

        private void toolStripButton98_Click(object sender, EventArgs e)
        {
            xrayedit();
        }

        private void toolStripButton99_Click(object sender, EventArgs e)
        {
            xraydeleted();
        }

        private void toolStripButton100_Click(object sender, EventArgs e)
        {
            xrayclear();
        }

        private void toolStripButton61_Click(object sender, EventArgs e)
        {
            hematologyadd();
        }

        private void toolStripButton93_Click(object sender, EventArgs e)
        {
            paitenthistoryadd();
        }

        private void toolStripButton94_Click(object sender, EventArgs e)
        {
            paitenthistoryedit();
        }

        private void toolStripButton95_Click(object sender, EventArgs e)
        {
            paitientdeleted();
        }

        private void toolStripButton96_Click(object sender, EventArgs e)
        {
            paitenhistoryclear();
        }

        private void toolStripButton27_Click(object sender, EventArgs e)
        {
            perscriptionadd();
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            perscriptionedit();
        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            perscriptiondeleted();
        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            perscriptionclear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl5_Click(object sender, EventArgs e)
        {
            xrayrequsten hy = new xrayrequsten();
             var query = from c in hy.xrayrequs select c;
              var users = query.ToList();
              gridControl3.DataSource = users;
            
        }

        private void xtraTabPage19_Paint(object sender, PaintEventArgs e)
        {
           
        }
        
        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter ada = new SqlDataAdapter("select * from Blood", conn);
            //DataTable dt = new DataTable();
            //ada.Fill(dt);
            //gridControl2.DataSource = dt;
        }

        private void gridControl3_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter ada = new SqlDataAdapter("select * from xray", conn);
            //DataTable dt = new DataTable();
            //ada.Fill(dt);
            //gridControl3.DataSource = dt;
        }

        private void xtraTabPage45_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl13_Click(object sender, EventArgs e)
        {

        }

        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBoxEdit14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xrayivetstigationtype.SelectedIndex == 0)
            {
                xrayinvestigationentity.Properties.Items.Clear();
                xrayinvestigationentity.Properties.Items.Add("LAT, APOM, APLC (3 views) ");
                xrayinvestigationentity.Properties.Items.Add("Cervical obliques (2 views) ");
                xrayinvestigationentity.Properties.Items.Add("Cervical Flex/Ext (2 views) ");
                xrayinvestigationentity.Properties.Items.Add("Cervical Lateral bending (2 views)  ");
            }
        }
        public void xkrayview()
        {
            
        }

        private void panelControl64_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void comboBoxEdit10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InvestigationType.SelectedIndex == 0)
            {
                investigationentity.Properties.Items.Clear();
                investigationentity.Properties.Items.Add("Complet Blood Count(CBC)");
                investigationentity.Properties.Items.Add("ESR");
                investigationentity.Properties.Items.Add("Hemoglobin ALC");
                investigationentity.Properties.Items.Add("Reticloyte count");
                investigationentity.Properties.Items.Add("Comb's Test(D)");
                investigationentity.Properties.Items.Add("Blood Group");
                investigationentity.Properties.Items.Add("Blood Film");
                investigationentity.Properties.Items.Add("Malaria Ag Test");
                investigationentity.Properties.Items.Add("CD4");
                investigationentity.Properties.Items.Add("COOMBSTest(Indirect)");
                investigationentity.Properties.Items.Add("Prepherial Smear");
                investigationentity.Properties.Items.Add("DIFFRENTIAL count");
                investigationentity.Properties.Items.Add("PLATELATE COUNT");
                investigationentity.Properties.Items.Add("COAGULATTION TIME");
                investigationentity.Properties.Items.Add("RBC MORPHOLOGY");
                investigationentity.Properties.Items.Add("SERUMIRON");
                investigationentity.Properties.Items.Add("FGRRITIN");
                investigationentity.Properties.Items.Add("VITB12");
                investigationentity.Properties.Items.Add("VOLATE");
                investigationentity.Properties.Items.Add("Pherepherial blood morphology");
                investigationentity.Properties.Items.Add("TIBC");


            }
        }

        private void checkedComboBoxEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
          
        }

        private void checkedComboBoxEdit2_GetItemEnabled(object sender, DevExpress.XtraEditors.Controls.GetCheckedComboBoxItemEnabledEventArgs e)
        {
           
        }

        private void checkedComboBoxEdit3_EditValueChanged(object sender, EventArgs e)
        {
         
        }
      
        public void SimpanGrid()
        {
            DataRow dr1 = dt.NewRow();
            dr1[0] = paitentid.Text;
            dr1[1] = paitentname.Text;
            dr1[2] = sex.Text;
            dr1[3] = age.Text;
            dr1[4] = date.Text;
            dr1[5] = physicianname.Text;
            dr1[6] = InvestigationType.Text;
            dr1[7] = investigationentity.Text;
            dr1[8] = subentity.Text;
            dr1[9] = chargeamount.Text; ;
            dr1[10] = xraychargestatus.Text;
            dt.Rows.Add(dr1);
            gridControl8.DataSource = dt;
        }
        public void simplexrayadd()
        {
            DataRow dr1 = dt1.NewRow();
            dr1[0] = paitentid.Text;
            dr1[1] = paitentname.Text;
            dr1[2] = sex.Text;
            dr1[3] = age.Text;
            dr1[4] = date.Text;
            dr1[5] = physicianname.Text;
            dr1[6] = xrayivetstigationtype.Text;
            dr1[7] = xrayinvestigationentity.Text;
            dr1[8] = xraychargeamount.Text;
            dr1[9] = xraychargestatus.Text;

            dt1.Rows.Add(dr1);
            gridControl7.DataSource = dt1;
        }
        public void ultrasoundprevew()
        {
            DataRow dr1 = dt2.NewRow();
            dr1[0] = paitentid.Text;
            dr1[1] = paitentname.Text;
            dr1[2] = sex.Text;
            dr1[3] = age.Text;
            dr1[4] = date.Text;
            dr1[5] = physicianname.Text;
            dr1[6] = ultrasoundinvestigationtype.Text;
            dr1[7] = ultrsoundinvestigationentity.Text;
            dr1[8] = ultrasoundchargeamount.Text;
            dr1[9] = ultrasoundchargestatus.Text;
            
            dt2.Rows.Add(dr1);
            gridControl9.DataSource = dt2;
        }
       
        private void gridControl7_Click_1(object sender, EventArgs e)
        {
            
              
            

        }
        protected void BindGrid()
        {
        }
        protected void Insert(object sender, EventArgs e)
        {
           
        }

        private void comboBoxEdit8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit8_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (investigationentity.SelectedIndex == 0)
            {
                subentity.Properties.Items.Clear();
                subentity.Properties.Items.Add("WBC");
                subentity.Properties.Items.Add("N");
                subentity.Properties.Items.Add("L");
                subentity.Properties.Items.Add("M");
                subentity.Properties.Items.Add("E");
                subentity.Properties.Items.Add("B");
                subentity.Properties.Items.Add("HGB");
                subentity.Properties.Items.Add("HCT");
                subentity.Properties.Items.Add("PLT");
                subentity.Properties.Items.Add("RBC");
                subentity.Properties.Items.Add("MCV");
                subentity.Properties.Items.Add("RDWC");
                subentity.Properties.Items.Add("MCH");
                subentity.Properties.Items.Add("MCHC");

            }
            else if (investigationentity.SelectedIndex == 5)
            {
                subentity.Properties.Items.Clear();
                subentity.Properties.Items.Add("ABO");
                subentity.Properties.Items.Add("RH");
            }
            else if (investigationentity.SelectedIndex == 13)
            {
                subentity.Properties.Items.Clear();
                subentity.Properties.Items.Add("PT");
                subentity.Properties.Items.Add("PTT");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridControl7_Load(object sender, EventArgs e)
        {
            
        }

        private void gridControl8_Load(object sender, EventArgs e)
        {
            DataColumn dc1 = new DataColumn("PatientID");
            DataColumn dc2 = new DataColumn("PatientName");
            DataColumn dc3 = new DataColumn("Sex");
            DataColumn dc4 = new DataColumn("Age");
            DataColumn dc5 = new DataColumn("Date");
            DataColumn dc6 = new DataColumn("PhysicianName");
            DataColumn dc7 = new DataColumn("InvestigationType");
            DataColumn dc8 = new DataColumn("InvestigationEntity");
            DataColumn dc9 = new DataColumn("SubEntity");
            DataColumn dc10 = new DataColumn("ChargeAmount");
            DataColumn dc11 = new DataColumn("ChargeStatus");
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
            DataRow dr1 = dt.NewRow();
            gridControl8.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBoxEdit9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl7_Load_1(object sender, EventArgs e)
        {
            DataColumn dc11 = new DataColumn("PatientID");
            DataColumn dc21 = new DataColumn("PatientName");
            DataColumn dc31 = new DataColumn("Sex");
            DataColumn dc41 = new DataColumn("Age");
            DataColumn dc51 = new DataColumn("Date");
            DataColumn dc61 = new DataColumn("PhysicianName");
            DataColumn dc7 = new DataColumn("InvestigationType");
            DataColumn dc8 = new DataColumn("InvestigationEntity");
            DataColumn dc9 = new DataColumn("ChargeAmount");
            DataColumn dc10 = new DataColumn("ChargeStatus");
            dt1.Columns.Add(dc11);
            dt1.Columns.Add(dc21);
            dt1.Columns.Add(dc31);
            dt1.Columns.Add(dc41);
            dt1.Columns.Add(dc51);
            dt1.Columns.Add(dc61);
            dt1.Columns.Add(dc7);
            dt1.Columns.Add(dc8);
            dt1.Columns.Add(dc9);
            dt1.Columns.Add(dc10);

            DataRow dr1 = dt1.NewRow();
            gridControl7.DataSource = dt1;
        }

        private void gridControl7_Click_2(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void insertToOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //void somemethod()
        //{
        //    DevExpress.XtraPrinting.PrintableComponentLink pl = new DevExpress.XtraPrinting.PrintableComponentLink();
        //    printingSystem1 = new PrintingSystem();
        //    printingSystem1.Links.Add(pl);

        //    pl.Component = _gridControl;

        //    pl.CreateReportHeaderArea += new CreateAreaEventHandler(pl_CreateReportHeaderArea);
        //}

        //void pl_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        //{
        //    TextBrick brick1 = e.Graph.DrawString("Your text goes here", Color.Black,
        //    new RectangleF(0, 0, 620, 20), DevExpress.XtraPrinting.BorderSide.None);
        //    brick1.HorzAlignment = HorzAlignment.Center;
        //    brick1.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        //}
        private void simpleButton7_Click(object sender, EventArgs e)
        {
        
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void gridControl9_Click(object sender, EventArgs e)
        {

        }

        private void gridControl9_Load(object sender, EventArgs e)
        {
           // RepositoryItemCheckEdit repositoryCheckEdit1 = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;
            DataColumn dc1 = new DataColumn("PatientID");
            DataColumn dc2 = new DataColumn("PatientName");
            DataColumn dc3 = new DataColumn("Sex");
            DataColumn dc4 = new DataColumn("Age");
            DataColumn dc5 = new DataColumn("Date");
            DataColumn dc6 = new DataColumn("PhysicianName");
            DataColumn dc7 = new DataColumn("InvestigationType");
            DataColumn dc8 = new DataColumn("InvestigationEntity");
            DataColumn dc9 = new DataColumn("ChargeAmount");
            DataColumn dc10 = new DataColumn("ChargeStatus");
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

            DataRow dr3 = dt2.NewRow();
            gridControl9.DataSource = dt2;
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton129_Click(object sender, EventArgs e)
        {
            SimpanGrid();
          ///  gg.perscribe();
        }

        private void toolStripButton130_Click(object sender, EventArgs e)
        {
            //gridView9.DeleteSelectedRows();
        }

        private void toolStripButton131_Click(object sender, EventArgs e)
        {
            gridControl8.ShowPrintPreview();
        }

        private void toolStripButton132_Click(object sender, EventArgs e)
        {
            simplexrayadd();
        }

        private void toolStripButton133_Click(object sender, EventArgs e)
        {
            gridView7.DeleteSelectedRows();
        }

        private void toolStripButton134_Click(object sender, EventArgs e)
        {
            gridControl7.ShowPrintPreview();
        }

        private void toolStripButton135_Click(object sender, EventArgs e)
        {
            ultrasoundprevew();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton144_Click(object sender, EventArgs e)
        {

        }

        private void gridControl14_Load(object sender, EventArgs e)
        {
            viewdata();
        }
        public void viewdata()
        {
           

        }
        private void gridView14_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //GridView view = (GridView)sender;
            //if (e.Column.FieldName == "Item")
            //{
            //    RepositoryItemCheckEdit check = new RepositoryItemCheckEdit();
            //    string clickedJobName = view.GetRowCellValue(e.RowHandle, view.Columns["Item"]).ToString();
            //    check.Name = clickedJobName;
            //    e.RepositoryItem = check;
            //    check.AllowGrayed = true;

            //    e.Column.ColumnEdit = check;

            //}
           
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            viewdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.previusillineseTableAdapter.FillBy(this.hMSDataSet1.Previusillinese);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void gridControl14_Click(object sender, EventArgs e)
        {

        }

        private void groupControl10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richEditControl4_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage51_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl13_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            gridControl3.ShowPrintPreview();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xtraTabControl2_Click(object sender, EventArgs e)
        {

        }
    }
}