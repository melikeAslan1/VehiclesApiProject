using Microsoft.EntityFrameworkCore;
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

        public Task ChangeHeadlights(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Bus>> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Bus>> GetAll()
        {
            var buses = await _context.Busses.ToListAsync();
            return buses;
        }

        
    }
}
