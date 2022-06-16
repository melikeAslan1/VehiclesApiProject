using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Abstract
{
    public interface IBoatService
    {
        Task<IList<Boat>> GetAll(int id);
    }
}
