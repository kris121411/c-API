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
    
    public partial class CAMPAIGN
    {
        public long id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> drop_date_set { get; set; }
        public Nullable<System.DateTime> drop_date_actual { get; set; }
        public Nullable<long> rel_ref_campaign_type { get; set; }
        public string type { get; set; }
        public Nullable<long> quantity { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public Nullable<long> created_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
        public Nullable<long> updated_by { get; set; }
    }
}