﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HMSgeneralentity : DbContext
    {
        public HMSgeneralentity()
            : base("name=HMSgeneralentity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AmbulanceStatu> AmbulanceStatus { get; set; }
        public DbSet<BedRequst> BedRequsts { get; set; }
        public DbSet<Biochemistry> Biochemistries { get; set; }
        public DbSet<BirthRegestration> BirthRegestrations { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<ChargeOrder> ChargeOrders { get; set; }
        public DbSet<DiagnosisOrder> DiagnosisOrders { get; set; }
        public DbSet<FirstDiagnosi> FirstDiagnosis { get; set; }
        public DbSet<Hamatology> Hamatologies { get; set; }
        public DbSet<Labrequst> Labrequsts { get; set; }
        public DbSet<Labtest> Labtests { get; set; }
        public DbSet<OutpaitentActivity> OutpaitentActivities { get; set; }
        public DbSet<Perscript> Perscripts { get; set; }
        public DbSet<Possition> Possitions { get; set; }
        public DbSet<QueaManagment> QueaManagments { get; set; }
        public DbSet<Refferapproved> Refferapproveds { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomService> RoomServices { get; set; }
        public DbSet<RoomStatu> RoomStatus { get; set; }
        public DbSet<StaffAttendance> StaffAttendances { get; set; }
        public DbSet<Staffregistration> Staffregistrations { get; set; }
        public DbSet<Stool> Stools { get; set; }
        public DbSet<StoolTest> StoolTests { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<xray> xrays { get; set; }
        public DbSet<Previusillinese> Previusillinese { get; set; }
        public DbSet<ECGrequst> ECGrequsts { get; set; }
        public DbSet<IEntity> IEntities { get; set; }
        public DbSet<ISubentity> ISubentities { get; set; }
        public DbSet<IType> ITypes { get; set; }
        public DbSet<ultrsasoundrequst> ultrsasoundrequsts { get; set; }
        public DbSet<Perscription> Perscriptions { get; set; }
        public DbSet<OperationRequst> OperationRequsts { get; set; }
        public DbSet<Reffer> Reffers { get; set; }
        public DbSet<medicalcerteficateee> medicalcerteficateees { get; set; }
        public DbSet<foAddress> foAddresses { get; set; }
        public DbSet<foDoctor> foDoctors { get; set; }
        public DbSet<foDoctorAssignment> foDoctorAssignments { get; set; }
        public DbSet<foNewPatient> foNewPatients { get; set; }
        public DbSet<foVital> foVitals { get; set; }
        public DbSet<secPermission> secPermissions { get; set; }
        public DbSet<secUser> secUsers { get; set; }
        public DbSet<Pastmedicalhistory> Pastmedicalhistories { get; set; }
        public DbSet<family> families { get; set; }
        public DbSet<xraygroup> xraygroups { get; set; }
        public DbSet<ultrasoundgroup> ultrasoundgroups { get; set; }
        public DbSet<Labelemntadd> Labelemntadds { get; set; }
        public DbSet<Labgroupname> Labgroupnames { get; set; }
        public DbSet<ecgelemntadd> ecgelemntadds { get; set; }
        public DbSet<Ecggroup> Ecggroups { get; set; }
        public DbSet<PaitientHistory> PaitientHistories { get; set; }
        public DbSet<FoPastMedicalHistory> FoPastMedicalHistories { get; set; }
        public DbSet<foPatient> foPatients { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<bedward> bedwards { get; set; }
        public DbSet<xrayrequ> xrayrequs { get; set; }
        public DbSet<DrugDescription> DrugDescriptions { get; set; }
        public DbSet<Labratoryresult> Labratoryresults { get; set; }
        public DbSet<DeathRegestration> DeathRegestrations { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PatientRegistration> PatientRegistrations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<drugitem> drugitems { get; set; }
        public DbSet<Xrayresultview> Xrayresultviews { get; set; }
        public DbSet<UltrasoundRsultview> UltrasoundRsultviews { get; set; }
        public DbSet<Xrayentityadd> Xrayentityadds { get; set; }
        public DbSet<ultrasoundelemntadd> ultrasoundelemntadds { get; set; }
    }
}