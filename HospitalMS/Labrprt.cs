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
    public partial class Labrprt : DevExpress.XtraEditors.XtraForm
    {
        public Labrprt()
        {
            InitializeComponent();
        }
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        Labratoryresult lr = new Labratoryresult();
        private void Labrprt_Load(object sender, EventArgs e)
        {
            var query = from c in HMSgeneralentity.Labratoryresults select c;
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



                    //    name.Text = row.Cells["PatientName"].Value.ToString();

                    //fathername.Text = row.Cells["FatherName"].Value.ToString();
                    //sex.Text = row.Cells["Sex"].Value.ToString();
                    //Agess.Text = row.Cells["Age"].Value.ToString();
                    ////  int ag = Convert.ToInt32(Agess.Text);
                    //dates.Text = row.Cells["Date"].Value.ToString();
                    //physicianname.Text = row.Cells["PhysicianName"].Value.ToString();
                    //paitentid.Text = row.Cells["PatientID"].Value.ToString();
                    InvestigationType.Text = row.Cells["InvestigationType"].Value.ToString();
                investigationentity.Text = row.Cells["InvestigationEntity"].Value.ToString();
                subentity.Text = row.Cells["SubEntity"].Value.ToString();
                lwrbund.Text = row.Cells["Lowerbound"].Value.ToString();
                uperbund.Text = row.Cells["Upperbound"].Value.ToString();
                result.Text = row.Cells["Result"].Value.ToString();
                status.Text = row.Cells["InvestigationStatus"].Value.ToString();
                // description.Text = row.Cells["Description"].Value.ToString();
            }
                
            }
            catch (Exception vr)
            {
                MessageBox.Show(vr.Message.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}