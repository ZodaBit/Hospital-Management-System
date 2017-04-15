using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMS;

namespace HospitalMS
{
    public class PatientBiz : GenericBiz<foPatient>
    {
        public Response<List<foPatient>> GetPatientHistory(int patientId)
        {
            try
            {
                var result = base.Get("foPaitientHistories").ToList();
                return new SucessResponse<List<foPatient>>(result);
            }
            catch (Exception exception)
            {
                return new FailureResponse<List<foPatient>>(exception);
            }
        }

        public override Response<foPatient> Add(foPatient entity)
        {
            try
            {
                using (HMSgeneralentity db = new HMSgeneralentity())
                {
                    db.foPatients.Add(entity);
                    db.foNewPatients.Add(new foNewPatient()
                    {
                        Id = entity.Id
                    });

                    db.SaveChanges();

                    return new SucessResponse<foPatient>(entity);
                };
            }
            catch (Exception ex)
            {
                return new FailureResponse<foPatient>(ex);
            }
        }

        public Response<foPatient> AddOrUpdate(foPatient patient)
        {
            if (patient.Id == 0)
                return Add(patient);
            return Update(patient);
        }

        public Response<foPatient> RemoveFromNewPatientsList(foPatient entity)
        {
            try
            {
                using (HMSgeneralentity db = new HMSgeneralentity())
                {
                   var newPatient = db.foNewPatients.Find(entity.Id);
                   db.foNewPatients.Remove(newPatient);
                   db.SaveChanges();
                   return new SucessResponse<foPatient>(entity);
                };
            }
            catch (Exception ex)
            {
                return new FailureResponse<foPatient>(ex);
            }

        }

        public List<foPatient> GetWaitingList()
        {
            using (HMSgeneralentity db = new HMSgeneralentity())
            {
                List<foPatient> waitingList = new List<foPatient>();
                db.foNewPatients.Include("foPatient")
                    .ToList().ForEach(np =>
                    {
                        waitingList.Add(np.foPatient);
                    });

                return waitingList;
            };
        }
    }
}
