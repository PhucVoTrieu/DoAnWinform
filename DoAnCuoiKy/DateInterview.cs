//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCuoiKy
{
    using System;
    using System.Collections.Generic;
    
    public partial class DateInterview
    {
        public int DateID { get; set; }
        public Nullable<int> ApplicantID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<System.DateTime> DateInterview1 { get; set; }
    
        public virtual Applicant Applicant { get; set; }
        public virtual Company Company { get; set; }
    }
}
