using System.Collections.Generic;
using DAL;

namespace SCHERP.Models
{
    public class UsersViewModel :AspNetUser
    {
        //public AspNetUser AspNetUser { get; set; }
        public List<AspNetRole> AspNetRole { get; set; }
    }
}