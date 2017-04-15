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
using HospitalMS;


namespace HospitalMS
{
    public partial class AllPatientsForm : DevExpress.XtraEditors.XtraForm
    {
        PatientBiz patientBiz = new PatientBiz();

        public AllPatientsForm()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            foPatientBindingSource.DataSource = patientBiz.Get();
        }

        private void gvAllPatients_Click(object sender, EventArgs e)
        {
            var patient = (foPatient)foPatientBindingSource.Current;
            
            //var patientDetailForm = new PatientDetailForm();
            //patientDetailForm.ShowDialog();
        }
    }
}