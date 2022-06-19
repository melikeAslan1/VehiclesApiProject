using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_DAL.Repository.Concrete;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Concrete
{
    public class CarManager : ICarService
    {
        private ICarRepository _carRepository;

        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Task ChangeHeadlights(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            await _carRepository.Delete(id);
        }

        public Task<IList<Car>> GetAll(int id)
        {
            return _carRepository.GetAll(id);
        }

        public Task<IList<Car>> GetAll()
        {
            return _carRepository.GetAll();
        }

        
    }
}
