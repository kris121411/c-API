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
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.log_USER = new HashSet<log_USER>();
            this.ORDERPROCs = new HashSet<ORDERPROC>();
        }
    
        public long id { get; set; }
        public string rel_ref_user_type_code { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name_first { get; set; }
        public string name_last { get; set; }
        public Nullable<System.DateTime> last_login { get; set; }
        public bool active { get; set; }
        public string meta { get; set; }
        public Nullable<bool> logged_in { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_USER> log_USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERPROC> ORDERPROCs { get; set; }
        public virtual ref_user_type ref_user_type { get; set; }
    }
}
