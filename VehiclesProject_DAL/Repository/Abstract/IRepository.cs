using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehiclesProject_EL;

namespace VehiclesProject_DAL.Repository.Abstract
{
    public interface IRepository<T> where T : Vehicle, new()
    {
        Task<IList<T>> GetAll(int id);

        Task<IList<T>> GetAll();
        Task Delete(int id);

        Task ChangeHeadlights(int id);
    }
}
