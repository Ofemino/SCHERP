using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SchoolSessionRepository: BaseRepository<SchoolSession>
    {
        public IQueryable<SchoolSession> ListSessions()
        {
            IQueryable<SchoolSession> sessions = GetAll();
            return sessions;
        }

        public List<SchoolSession> FindById(int id)
        {
            List<SchoolSession> sl = new List<SchoolSession>();
            var ss = GetById(id);
            sl.Add(ss);
            return sl;
        }

        public int CreateSession(SchoolSession session)
        {
            int r = Insert(session);
            return r;
        }
    }
}
