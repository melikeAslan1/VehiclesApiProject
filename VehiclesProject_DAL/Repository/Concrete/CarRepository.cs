using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_EL;
using System.Linq;

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

        public async Task<IList<Car>> GetAll(int id)
        {
            var cars = await _context.Cars.FirstOrDefaultAsync(p => p.ColorId == id);
            return (IList<Car>)cars;


            //throw new NotImplementedException();
        }

        public async Task<IList<Car>> GetAll()
        {
            var cars = await _context.Cars.ToListAsync();
            return cars;
        }

        public async Task ChangeHeadlights(int id)
        {

            var car = await _context.Cars.FirstOrDefaultAsync(p => p.Id == id);

            if(car.Headlights.Equals(true))
            {
                // _context.Cars.Set

                await _context.SaveChangesAsync();
            }

            throw new NotImplementedException();
        }
    }
}
