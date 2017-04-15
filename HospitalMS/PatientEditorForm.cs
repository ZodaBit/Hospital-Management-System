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
using HospitalMS.common;
using HospitalMS;


namespace HospitalMS
{
    public partial class PatientEditorForm : DevExpress.XtraEditors.XtraForm
    {
        PatientBiz patientBiz = new PatientBiz();

        foPatient patient;

        public PatientEditorForm()
        {
            InitializeComponent();
        }

        private void PatientEditor_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = patientBiz.AddOrUpdate(patient);
            if (result.Status)
            {
                DataBind();
            }
            else
                MessageBox.Show("Save failed. " + result.Message);
        }

        private void DataBind()
        {
            patient  = new foPatient();

            foPatientBindingSource.Clear();
            foPatientBindingSource.Add(patient);
            //genderBindingSource.DataSource = Gender.Get();
            maternalStateBindingSource.DataSource = MaternalState.Get();
        }

        private void foPatientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MaternalStateComboBoxEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}