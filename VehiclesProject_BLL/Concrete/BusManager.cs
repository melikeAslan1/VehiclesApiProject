using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Concrete
{
    public class BusManager : IBusService
    {
        public Task<IList<Bus>> GetAll(string color)
        {
            throw new NotImplementedException();
        }
    }
}
