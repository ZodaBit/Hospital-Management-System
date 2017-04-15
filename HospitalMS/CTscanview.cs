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
    public partial class CTscanview : DevExpress.XtraEditors.XtraForm
    {
        public CTscanview()
        {
            InitializeComponent();
        }
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        private void CTscanview_Load(object sender, EventArgs e)
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