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
    
    public partial class ClassTeacher
    {
        public int Id { get; set; }
        public Nullable<int> StaffId { get; set; }
        public string ClassGroup { get; set; }
        public string Class { get; set; }
        public string Arm { get; set; }
        public int SessionId { get; set; }
        public byte[] CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
