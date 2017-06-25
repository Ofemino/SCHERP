using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserProfileRepository : BaseRepository<UserProfile>
    {
        private ScherpDbContext _db;

        public IQueryable<UserProfile> GetProfiles()
        {
            return GetAll();
        }

        public UserProfile FindById(string id)
        {
            return GetById(id);
        }

        public UserProfile FindById(int id)
        {
            return GetById(id);
        }
        public int UpdateProfile(UserProfile userProfile)
        {
            return Update(userProfile);
        }
    }
}
