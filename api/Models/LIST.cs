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
    
    public partial class LIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIST()
        {
            this.con_LIST_SOUL = new HashSet<con_LIST_SOUL>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string segment { get; set; }
        public Nullable<long> order_number { get; set; }
        public string res_code { get; set; }
        public Nullable<long> order_quantity { get; set; }
        public Nullable<System.DateTime> date_emailed { get; set; }
        public Nullable<long> final_quantity { get; set; }
        public Nullable<System.DateTime> date_mailed { get; set; }
        public Nullable<long> mail_quantity { get; set; }
        public Nullable<long> response_count { get; set; }
        public Nullable<long> accepted_count { get; set; }
        public Nullable<System.DateTime> last_hit { get; set; }
        public Nullable<System.DateTime> last_update { get; set; }
        public Nullable<System.DateTime> last_update_by { get; set; }
        public string drop_description { get; set; }
        public string phone_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<con_LIST_SOUL> con_LIST_SOUL { get; set; }
    }
}