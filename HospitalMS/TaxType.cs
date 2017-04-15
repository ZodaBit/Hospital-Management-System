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
    public partial class TaxType : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn;
        string connectionstring = null;
        public TaxType()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        public void connecttion()
        {
            connectionstring = System.IO.File.ReadAllText("D:\\Test.txt");
        }
        public void taxadd()
        {
            try
            {
                conn.Open();
                SqlCommand gh = new SqlCommand("insert into Tax(ID,TaxTypeName,TaxAmountInPercent,TaxID)values(@1,@2,@3,@4)", conn);
                //  gh.Parameters.Add("@1", textEdit46.Text);
                gh.Parameters.Add("@1", textEdit1.Text);
                gh.Parameters.Add("@2", textEdit2.Text);
                gh.Parameters.Add("@3", textEdit3.Text);
                gh.Parameters.Add("@4", textEdit4.Text);
                gh.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("value add Successfully ");
                taxclear();
            }
            catch (Exception mn)
            {
                MessageBox.Show(mn.Message.ToString());
                conn.Close();
                taxclear();
            }
        }
        public void taxedit()
        {
            try
            {
                conn.Open();
                SqlCommand gh = new SqlCommand("Update  Tax set TaxTypeName=@2,TaxAmountInPercent=@3,TaxID=@4 where ID=@1", conn);
                gh.Parameters.Add("@1", textEdit1.Text);
                gh.Parameters.Add("@2", textEdit2.Text);
                gh.Parameters.Add("@3", textEdit3.Text);
                gh.Parameters.Add("@4", textEdit4.Text);
                gh.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("value update Successfully ");
                taxclear();
            }
            catch (Exception ser)
            {
                MessageBox.Show(ser.Message.ToString());
                conn.Close();
                taxclear();
            }
        }
        public void taxdeleted()
        {
            try
            {
                conn.Open();
                SqlCommand sc = new SqlCommand("Delete From  Tax   where ID=@selectedid", conn);
                string stdid = textEdit1.Text;
                sc.Parameters.AddWithValue("@selectedid", stdid);
                sc.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("deleted file");
                taxclear();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message.ToString());
                conn.Close();
                taxclear();
            }
        }
        public void taxclear()
        {
            textEdit1.Text="";
             textEdit2.Text="";
            textEdit3.Text="";
            textEdit4.Text = "";
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaxType_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            taxadd();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            taxedit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            taxdeleted();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            taxclear();
        }
    }
}