//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Xrayresultview
    {
        public int XrayresultID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string PatientName { get; set; }
        public string FatherName { get; set; }
        public string Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string PhysicianName { get; set; }
        public string InvestigationType { get; set; }
        public string InvestigationEntity { get; set; }
        public string ClinicalFindings { get; set; }
        public string Protocol { get; set; }
        public string ImageStuddingFindings { get; set; }
        public string Conclusion { get; set; }
        public string RadilogistName { get; set; }
    }
}
