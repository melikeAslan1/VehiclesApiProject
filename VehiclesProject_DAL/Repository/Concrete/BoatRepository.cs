using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_DAL.Repository.Concrete
{
    public class BoatRepository : IBoatRepository
    {
        private MyDBContext _context;

        public BoatRepository(MyDBContext context)
        {
            _context = context;
        }

        public Task ChangeHeadlights(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Boat>> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Boat>> GetAll()
        {
            throw new NotImplementedException();
        }

       
    }
}
