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
    
    public partial class StudentPreAdmission
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string Surname { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> Soo { get; set; }
        public string Nationality { get; set; }
        public byte[] Avatar { get; set; }
    }
}
