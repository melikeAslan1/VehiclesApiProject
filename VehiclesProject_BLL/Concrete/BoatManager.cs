using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_BLL.Abstract;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Concrete
{
    public class BoatManager : IBoatService
    {
        public Task<IList<Boat>> GetAll(string color)
        {
            throw new NotImplementedException();
        }
    }
}
