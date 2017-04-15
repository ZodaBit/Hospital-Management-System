using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalMS
{
    public interface IEntityWithId
    {
        int Id { get; set; }
    }
}
