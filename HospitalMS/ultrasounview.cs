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
    public partial class ultrasounview : DevExpress.XtraEditors.XtraForm
    {
        public ultrasounview()
        {
            InitializeComponent();
            connecttion();
            conn = new SqlConnection(connectionstring);
        }
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        string connectionstring = null;
        //HMSDataSet hh = new HMSDataSet();

        SqlConnection conn;
        public void connecttion()
        {

            connectionstring = System.IO.File.ReadAllText("Test.txt");
        }
        private void ultrasounview_Load(object sender, EventArgs e)
        {
            var query = from c in HMSgeneralentity.UltrasoundRsultviews select c;
            var users = query.ToList();
            dataGridView1.DataSource = users;
        }
      
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    if (row != null)


                        imagestudyfindings.Text = row.Cells["Result"].Value.ToString();

                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }
    }
}