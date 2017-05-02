using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SooRepository : BaseRepository<StateCapital>
    {
        public IQueryable<StateCapital> GetAllStates()
        {
            return GetAll();
        }

        public StateCapital GetStatesById(int id)
        {
            return GetById(id);
        }
    }
}
