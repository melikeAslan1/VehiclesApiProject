using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Abstract
{
   public interface ICarService
    {
        Task<IList<Car>> GetAll(string color);

        Task<IList<Car>> GetAll();
        Task Delete(int id);

        Task<bool> TurnOn(int id);
    }
}
