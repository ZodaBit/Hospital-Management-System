using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMS;

namespace HospitalMS
{
    public class VitalBiz : GenericBiz<foVital>
    {
        public Response<foVital> AddOrUpdate(foVital vital)
        {
            if (vital.Id == 0)
                return Add(vital);
            return Update(vital);
        }
    }
}
