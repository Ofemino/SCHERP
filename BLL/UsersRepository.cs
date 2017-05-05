using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UsersRepository : BaseRepository<AspNetUser>
    {
        private ScherpDbContext _db;

        public IQueryable<AspNetUser> GetUsers()
        {
            return GetAll();
        }

        public AspNetUser FindById(string id)
        {
            return GetById(id);
        } 
    }
}
