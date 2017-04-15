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
using System.Data.Sql;

namespace HospitalMS
{
    public partial class Pharmacy : DevExpress.XtraEditors.XtraForm
    {
        public Pharmacy()
        {
            InitializeComponent();
            autocmplt();
            connecttion();
         conn = new SqlConnection(connectionstring);
        }
        HMSgeneralentity gnr = new HMSgeneralentity();
        DrugDescription dd = new DrugDescription();
        string connectionstring = null;
        //HMSDataSet hh = new HMSDataSet();
        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
        SqlConnection conn;
        SqlNotificationRequest request =
           new SqlNotificationRequest();
       
        public void connecttion()
        {

            connectionstring = System.IO.File.ReadAllText("Test.txt");
        
        }
        public void Insert(string msgTitle, string description)
        {
            SqlCommand hg = new SqlCommand();
          



        }

        public void savedata()
        {
            //dd = gnr.DrugDescriptions.Create();
            //dd.DrugName = drugname.Text;
            //dd.Prescribed = perscribed.Text;
            //dd.CommonSide = commonside.Text;
            //dd.PossibleSide = posibelside.Text;
            //dd.Alternatives = alternative.Text;
            //dd.Brand = brand.Text;
            //dd.Interaction = interaction.Text;
            //dd.Warning = warning.Text;
            //dd.DrugType = drugtype.Text;
            //gnr.DrugDescriptions.Add(dd);
            
            //MessageBox.Show("congra");
            NotifyIcon hhy = new NotifyIcon();
         
        }
        public void viewsearchdata()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select DrugType, Prescribed,CommonSide,PossibleSide,Interaction,Warning,Alternatives,Brand From DrugDescription where DrugName='" + drugname.Text + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    drugtype.Text = reader["DrugType"].ToString();
                    perscribed.Text = reader["Prescribed"].ToString();
                    commonside.Text = reader["CommonSide"].ToString();
                    posibelside.Text = reader["PossibleSide"].ToString();
                    alternative.Text = reader["Alternatives"].ToString();
                    brand.Text = reader["Brand"].ToString();
                    interaction.Text = reader["Interaction"].ToString();
                    warning.Text = reader["Warning"].ToString();
                }
                conn.Close();
            }
            catch (Exception cz)
            {
                MessageBox.Show(cz.Message.ToString());
            }
        }
        public void cler()
        {
           
        }
        private void Pharmacy_Load(object sender, EventArgs e)
        {

        }
        public void autocmplt()
        {
            DrugDescription ds = gnr.DrugDescriptions.Create();
            var polp = gnr.DrugDescriptions;
            foreach (var p in polp)
            {
                data.Add(p.DrugName);

            }
            drugname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            drugname.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            drugname.MaskBox.AutoCompleteCustomSource = data;
        }
        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drugname_Leave(object sender, EventArgs e)
        {
            viewsearchdata();
        }
    }
}