using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Concrete
{
    public class CarManager : ICarService
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Car>> GetAll(string color)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TurnOn(int id)
        {
            throw new NotImplementedException();
        }
    }
}
