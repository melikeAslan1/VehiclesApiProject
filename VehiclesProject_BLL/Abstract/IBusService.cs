using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_EL;

namespace VehiclesProject_BLL.Abstract
{
    public interface IBusService
    {
        Task<IList<Bus>> GetAll(int id);
        Task<IList<Bus>> GetAll();
    }
}
