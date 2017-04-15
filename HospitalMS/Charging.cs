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
    public partial class Charging : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn;
        string connectionstring = null;
        string yese;
        string nooo;
        public Charging()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
           
        }
        public void connecttion()
        {
            connectionstring = System.IO.File.ReadAllText("D:\\Test.txt");
        }
        public void chargeadd()
        {
            try
            {
                conn.Open();
                if (radioGroup1.SelectedIndex == 0)
                {
                
                    yese = "Yes";
                }
                if (radioGroup1.SelectedIndex == 1)
                {
                    yese = "No";
                   
                }
                SqlCommand gh = new SqlCommand("insert into Charge(ID,ServiceName,ChargeIncludeTax,TaxID,AmountOfCharge,Discount)values(@1,@2,@3,@4,@5,@6)", conn);
                //  gh.Parameters.Add("@1", textEdit46.Text);
                gh.Parameters.Add("@1", textEdit1.Text);
                gh.Parameters.Add("@2", textEdit2.Text);
                gh.Parameters.Add("@3", yese);
                gh.Parameters.Add("@4", textEdit3.Text);
                gh.Parameters.Add("@5", textEdit9.Text);
                gh.Parameters.Add("@6", textEdit10.Text);
                gh.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("value add Successfully ");
                chargeclear();
            }
            catch (Exception mn)
            {
                MessageBox.Show(mn.Message.ToString());
                conn.Close();
                chargeclear();
            }
        }
        public void chargeedit()
        {
          try
            {
                conn.Open();
               
                if (radioGroup1.SelectedIndex == 0)
                {
                    yese = "Yes";
                }
                if (radioGroup1.SelectedIndex == 1)
                {
                    yese = "No";
                }
                SqlCommand gh = new SqlCommand("Update  Charge set ServiceName=@2,ChargeIncludeTax=@3,TaxID=@4,AmountOfCharge=@5,Discount=@6 where ID=@1", conn);
                gh.Parameters.Add("@1", textEdit1.Text);
                gh.Parameters.Add("@2", textEdit2.Text);
                gh.Parameters.Add("@3", yese);
                gh.Parameters.Add("@4", textEdit3.Text);
                gh.Parameters.Add("@5", textEdit9.Text);
                gh.Parameters.Add("@6", textEdit10.Text);
                gh.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("value update Successfully ");
                chargeclear();
            }
            catch (Exception ser)
            {
                MessageBox.Show(ser.Message.ToString());
                conn.Close();
                chargeclear();
            }

        }
        public void chargedeled()
        {
            try
            {
                conn.Open();
                SqlCommand sc = new SqlCommand("Delete From  Charge   where ID=@selectedid", conn);
                string stdid = textEdit1.Text;
                sc.Parameters.AddWithValue("@selectedid", stdid);
                sc.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("deleted file");
                chargeclear();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message.ToString());
                conn.Close();
                chargeclear();
            }
        }
        public void chargeclear()
        {
            textEdit1.Text="";
             textEdit2.Text="";
            
             textEdit3.Text="";
            textEdit9.Text="";
            textEdit10.Text = "";
        }
        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void Charging_Load(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            chargeadd();
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            chargeedit();
        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            chargedeled();
        }

        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            chargeclear();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 1)
            {
                textEdit3.Visible = false;
                labelControl4.Visible = false;
            }
            if (radioGroup1.SelectedIndex == 0)
            {
                textEdit3.Visible = true;
                labelControl4.Visible = true;
            }
        }
    }
}