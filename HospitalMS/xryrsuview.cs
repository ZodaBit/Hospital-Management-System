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
    public partial class xryrsuview : DevExpress.XtraEditors.XtraForm
    {
        public xryrsuview()
        {
            InitializeComponent();
        }
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        DataTable dt2 = new DataTable();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            var query = from c in HMSgeneralentity.Xrayresultviews select c;
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

                     ClinicalFindings.Text = row.Cells["ClinicalFindings"].Value.ToString(); ;
                    protocol.Text = row.Cells["Protocol"].Value.ToString();
                    Conclusion.Text = row.Cells["Conclusion"].Value.ToString();
                    imagestudyfindings.Text = row.Cells["View1"].Value.ToString();
                    view2.Text = row.Cells["View2"].Value.ToString();
                    view3.Text = row.Cells["View3"].Value.ToString();
                    //ClinicalFindings.Text = "";
                    //protocol.Text = "";
                    //Conclusion.Text = "";

                }
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void xryrsuview_Load(object sender, EventArgs e)
        {

        }

        private void imagestudyfindings_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl2_Click(object sender, EventArgs e)
        {

        }
    }
}