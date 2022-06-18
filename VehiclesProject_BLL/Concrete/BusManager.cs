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
        private IBusRepository _busRepository;

        public BusManager(IBusRepository carRepository)
        {
            _busRepository = carRepository;
        }
        public Task<IList<Bus>> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAll()
        {
            

            return _busRepository.GetAll();
        }
    }
}
