﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class mainEntities : DbContext
    {
        public mainEntities()
            : base("name=mainEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADDRESS> ADDRESSes { get; set; }
        public virtual DbSet<CAMPAIGN> CAMPAIGNs { get; set; }
        public virtual DbSet<con_LIST_SOUL> con_LIST_SOUL { get; set; }
        public virtual DbSet<con_ORDERPROC_DOCTOR> con_ORDERPROC_DOCTOR { get; set; }
        public virtual DbSet<con_SOUL_ref_upsell> con_SOUL_ref_upsell { get; set; }
        public virtual DbSet<Conditions_Profile> Conditions_Profile { get; set; }
        public virtual DbSet<Doc_Insurance_Affiliation> Doc_Insurance_Affiliation { get; set; }
        public virtual DbSet<Doc_Specialties_Profile> Doc_Specialties_Profile { get; set; }
        public virtual DbSet<DOCTOR> DOCTORs { get; set; }
        public virtual DbSet<INS_info_2> INS_info_2 { get; set; }
        public virtual DbSet<Insurance_Profile> Insurance_Profile { get; set; }
        public virtual DbSet<ITEM> ITEMs { get; set; }
        public virtual DbSet<LIST> LISTs { get; set; }
        public virtual DbSet<log_EXTERNAL> log_EXTERNAL { get; set; }
        public virtual DbSet<log_ORPROC> log_ORPROC { get; set; }
        public virtual DbSet<log_ORPROC_ALL> log_ORPROC_ALL { get; set; }
        public virtual DbSet<LOG_Q1> LOG_Q1 { get; set; }
        public virtual DbSet<log_USER> log_USER { get; set; }
        public virtual DbSet<Med_Specialties> Med_Specialties { get; set; }
        public virtual DbSet<NOTE> NOTEs { get; set; }
        public virtual DbSet<ORDER_info_2> ORDER_info_2 { get; set; }
        public virtual DbSet<ORDER_shipping> ORDER_shipping { get; set; }
        public virtual DbSet<ORDERPROC> ORDERPROCs { get; set; }
        public virtual DbSet<ref_orproc_state> ref_orproc_state { get; set; }
        public virtual DbSet<ref_orproc_state_group> ref_orproc_state_group { get; set; }
        public virtual DbSet<ref_TAG> ref_TAG { get; set; }
        public virtual DbSet<ref_trans_type> ref_trans_type { get; set; }
        public virtual DbSet<ref_upsell> ref_upsell { get; set; }
        public virtual DbSet<ref_user_type> ref_user_type { get; set; }
        public virtual DbSet<ref_zip> ref_zip { get; set; }
        public virtual DbSet<SETTING> SETTINGS { get; set; }
        public virtual DbSet<SOUL> SOULs { get; set; }
        public virtual DbSet<SOUL_info_2> SOUL_info_2 { get; set; }
        public virtual DbSet<SOUL_info_3> SOUL_info_3 { get; set; }
        public virtual DbSet<TAG> TAGs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<vSOUL> vSOULs { get; set; }
        public virtual DbSet<ref_insurance_plan> ref_insurance_plan { get; set; }
        public virtual DbSet<ref_insurancecompanies> ref_insurancecompanies { get; set; }
        public virtual DbSet<ref_specialties> ref_specialties { get; set; }
        public virtual DbSet<Doc_Education> Doc_Education { get; set; }
        public virtual DbSet<Doc_Insurance> Doc_Insurance { get; set; }
    
        public virtual int usp_getport_number()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_getport_number");
        }
    }
}
