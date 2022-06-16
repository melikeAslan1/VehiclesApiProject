using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;
using VehiclesProject_DAL.Repository.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Concrete
{
    public class BusManager : IBusService
    {
        private IBusRepository _carRepository;

        public BusManager(IBusRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public Task<IList<Bus>> GetAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
