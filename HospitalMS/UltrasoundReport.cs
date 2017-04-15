using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HospitalMS
{
    public partial class UltrasoundReport : DevExpress.XtraEditors.XtraForm
    {
        public UltrasoundReport()
        {
            InitializeComponent();
        }
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        DataTable dt2 = new DataTable();
        private void UltrasoundReport_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl34_Click(object sender, EventArgs e)
        {

        }
       
        private void toolStripButton129_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            //var query = from c in HMSgeneralentity. select c;
            //var users = query.ToList();
            //dataGridView1.DataSource = users;
        }
    }
}