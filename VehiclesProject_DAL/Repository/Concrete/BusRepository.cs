using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_DAL.Repository.Concrete
{
    public class BusRepository : IBusRepository
    {
        private MyDBContext _context;

        public BusRepository(MyDBContext context)
        {
            _context = context;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Bus>> GetAll(Color color)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Bus>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> TurnOn(int id)
        {
            throw new NotImplementedException();
        }
    }
}
