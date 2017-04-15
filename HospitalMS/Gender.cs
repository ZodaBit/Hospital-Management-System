using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.common
{
    public class Gender
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public static IList<Gender> Get()
        {
            List<Gender> genders = new List<Gender>() {
                new Gender { Name = "Male", Value = 0 },
                new Gender { Name = "Female", Value = 1 }
            };

            return genders;
        }
    }
}
