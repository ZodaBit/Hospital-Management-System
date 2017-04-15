using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Text;
using System.Threading.Tasks;
using HospitalMS;

namespace HospitalMS
{
    public class DoctorBiz : GenericBiz<foDoctor>
    {

        public List<foDoctor> GetAvailable()
        {
            List<foDoctor> doctors;

            using (HMSgeneralentity db = new HMSgeneralentity())
            {
                doctors = db.foDoctors.Where(d => d.Id > 0).ToList();
            };

            return doctors;
        }

        public Response<foPatient> AssignPatient(foPatient patient, foDoctor doctor)
        {
            try
            {
                using (HMSgeneralentity db = new HMSgeneralentity())
                {
                    db.foDoctorAssignments.Add(new foDoctorAssignment()
                    {
                        DoctorId = doctor.Id,
                        PatientId = patient.Id
                    });

                    var result = db.SaveChanges();

                    if (result > 0)
                        return new SucessResponse<foPatient>();
                    else
                        throw new Exception("Not Saved");
                };
            }
            catch (Exception ex)
            {
                return new FailureResponse<foPatient>(ex);
            }
        }
    }
}
