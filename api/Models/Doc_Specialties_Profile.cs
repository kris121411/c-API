//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Doc_Specialties_Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doc_Specialties_Profile()
        {
            this.DOCTORs = new HashSet<DOCTOR>();
        }
    
        public long id { get; set; }
        public Nullable<long> doctor_id { get; set; }
        public Nullable<long> specialty_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCTOR> DOCTORs { get; set; }
        public virtual ref_specialties ref_specialties { get; set; }
        public virtual DOCTOR DOCTOR { get; set; }
    }
}