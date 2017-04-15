using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.common
{
    public class MaternalState
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public static IList<MaternalState> Get()
        {
            List<MaternalState> maternalStates = new List<MaternalState>() {
                new MaternalState { Name = "Maried", Value = 0 },
                new MaternalState { Name = "Single", Value = 1 }
            };

            return maternalStates;
        }
    }
}
