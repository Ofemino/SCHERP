using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AcademicSessionRepository:BaseRepository<AcademicSession>
    {
        public IQueryable<AcademicSession> GetAllSession()
        {
            return GetAll();
        }

        public AcademicSession FindSessionById(int id)
        {
            return GetById(id);
        }

        public IQueryable<AcademicSession> FindBySession(Expression<Func<AcademicSession, bool>> session)
        {
            return SearchFor(session);
        }

        public int DeleteSession(int id)
        {
            AcademicSession session = GetById(id);
            return Delete(session);
        }

        public int UpdateSession(AcademicSession session)
        {
            return Update(session);
        }
    }
}
