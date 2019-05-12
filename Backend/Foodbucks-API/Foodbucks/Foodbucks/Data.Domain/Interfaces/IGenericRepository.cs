using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Foodbucks.Data.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Add(T entity);
        Task Edit(T entity);
        Task Save();
    }
}
