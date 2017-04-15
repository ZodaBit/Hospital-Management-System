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

namespace HospitalMS
{
    public partial class NewPatientsWaitingListForm : DevExpress.XtraEditors.XtraForm
    {
        DoctorBiz doctorBiz = new DoctorBiz();
        PatientBiz patientBiz = new PatientBiz();
        VitalBiz vitalBiz = new VitalBiz();
        SecBiz secBiz = new SecBiz();

        foVital vital;

        public NewPatientsWaitingListForm()
        {
            InitializeComponent();    
        }

        private void NewPatientsWaitingList_Load(object sender, EventArgs e)
        {
            //var user = secBiz.Get("secPermissions").Where(u=>u.Id == 1).FirstOrDefault();
            //HMSSecurity hmssecurity = new HMSSecurity();
            //hmssecurity.ApplySecurityToUi(this, user);

            DataBind();
        }

        private void DataBind()
        {
            dsVital.Clear();
            vital = new foVital();
            dsVital.Add(vital);

            dsDoctorList.Clear();
            dsDoctorList.DataSource = doctorBiz.GetAvailable();

            dsNewPatients.Clear();
            dsNewPatients.DataSource = patientBiz.GetWaitingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var vital = (foVital)dsVital.Current;
            var patient = (foPatient)dsNewPatients.Current;
            
            vital.PatientId = patient.Id;
            vitalBiz.Add(vital);

            var doctor = (foDoctor)dsDoctorList.Current;
            doctorBiz.AssignPatient(patient, doctor);

            patientBiz.RemoveFromNewPatientsList(patient);

            DataBind();
        }
    }
}