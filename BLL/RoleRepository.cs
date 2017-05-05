using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class RoleRepository : BaseRepository<AspNetRole>
    {
        public IQueryable<AspNetRole> GetRoles()
        {
            return GetAll();
        }

        public IQueryable<AspNetRole> FindById(string id)
        {
            return GetRoles().Where(r => r.Id.Equals(id));
        }

        public int RemoveRole(string id)
        {
            AspNetRole r = GetById(id);
            var i = Delete(r);
            return i;
        }
    }
}
