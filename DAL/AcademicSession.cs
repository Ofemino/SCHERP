//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AcademicSession
    {
        public int Id { get; set; }
        public string Session { get; set; }
        public string Term { get; set; }
        public string Year { get; set; }
        public string TermBegins { get; set; }
        public string TermEnds { get; set; }
        public Nullable<int> SchoolOpens { get; set; }
        public string CreatedBy { get; set; }
        public byte[] CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}