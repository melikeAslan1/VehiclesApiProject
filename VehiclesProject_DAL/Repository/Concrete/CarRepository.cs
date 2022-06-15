using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_DAL.Repository.Concrete
{
    public class CarRepository : ICarRepository
    {
        private MyDBContext _context;

        public CarRepository(MyDBContext context)
        {
            _context = context;
        }
        public async Task Delete(int id)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(p => p.Id == id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
        }

        public Task<IList<Car>> GetAll(Color color)
        {
            var cars= await _context.Cars.
        }

        public Task<bool> TurnOn(int id)
        {
            throw new NotImplementedException();
        }
    }
}
