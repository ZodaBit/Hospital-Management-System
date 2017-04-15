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
    public partial class Front_Office : DevExpress.XtraEditors.XtraForm
    {
        public Front_Office()
        {
            InitializeComponent();
        }
        HMSgeneralentity HMSgeneralentity = new HMSgeneralentity();
        string invstgtiontype;
        string investigationentity;
        string subentity;
        string servicetyipe;
        string amout;
        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            var patientEditorForm = new PatientEditorForm();
            patientEditorForm.ShowDialog();
        }

        private void btnAllPatient_Click(object sender, EventArgs e)
        {
            var patientsForm = new AllPatientsForm();
            patientsForm.ShowDialog();

        }

        private void btnWaitingList_Click(object sender, EventArgs e)
        {
            var patientsWaitingForm = new NewPatientsWaitingListForm();
            patientsWaitingForm.ShowDialog();

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            var newAppointmentForm = new Appointments();
            newAppointmentForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
                
        }
        public void chargestate()
        {
        //    int crge = int.Parse(chargeidse.Text);
        //    if (crge == 1)
        //    {
        //        if (comboBoxEdit1.SelectedIndex == 1)
        //        {

        //        }
        //    }
        }
        private void Front_Office_Load(object sender, EventArgs e)
        {
            var query = from c in HMSgeneralentity.foPatients select c;
            var users = query.ToList();
            dataGridView1.DataSource = users;
        }
        public Labratory lab;
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int crge = int.Parse(chargeidse.Text);
            //try
            //{
            //    if (e.RowIndex >= 0)
            //    {
                   
            //        DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            //        if (row != null)


                   
                    
            //            name.Text = row.Cells["PatientName"].Value.ToString();
            //            fathername.Text = row.Cells["FatherName"].Value.ToString();
            //            sex.Text = row.Cells["Sex"].Value.ToString();
            //            Agess.Text = row.Cells["Age"].Value.ToString();
            //            dates.Text = row.Cells["Date"].Value.ToString();
            //            physicianname.Text = row.Cells["PhysicianName"].Value.ToString();
            //            paitentid.Text = row.Cells["PatientID"].Value.ToString();
            //            invstgtiontype = row.Cells["InvestigationType"].Value.ToString();
            //            investigationentity = row.Cells["InvestigationEntity"].Value.ToString();
            //            subentity = row.Cells["SubEntity"].Value.ToString();
            //            amout = row.Cells["ChargeAmount"].Value.ToString();
            //            servicetyipe = row.Cells["ChargeAmount"].Value.ToString();
                         
                   
            //        //  int ag = Convert.ToInt32(Agess.Text);
                   
                  

            //    }
            //}
            //catch (Exception vr)
            //{
            //    MessageBox.Show(vr.Message.ToString());
            //}
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Docterview.ActiveForm.IsMdiContainer = true;
            srviccharge br = new srviccharge();
            br.MdiParent =Docterview.ActiveForm;
            br.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
          {
        //    AssignRoomForm nt = new AssignRoomForm();
        //    nt.Show();
         }
        private void AssignRoomForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                e.Row.DefaultCellStyle.SelectionBackColor = Color.Red;
            }
           // else
               // e.Row.DefaultCellStyle.SelectionBackColor = Color.White;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}