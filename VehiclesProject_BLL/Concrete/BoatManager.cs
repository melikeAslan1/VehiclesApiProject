using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Concrete
{
    public class BoatManager : IBoatService
    {
        private IBoatRepository _carRepository;

        public BoatManager(IBoatRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public Task<IList<Boat>> GetAll(string color)
        {
            throw new NotImplementedException();
        }
    }
}
