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
    public partial class Appointments : DevExpress.XtraEditors.XtraForm
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet3.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.AppointmentsDataSet.Appointments);
        }

        private void OnAppointmentChangedInsertedDeleted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(AppointmentsDataSet);
            AppointmentsDataSet.AcceptChanges();
        }

    }
}