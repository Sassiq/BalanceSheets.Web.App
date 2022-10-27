using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task Add(T item);
        Task Delete(T item);
        Task Update(T item);
        Task<T> Get(ISpecification<T> specification);
        Task<ICollection<T>> GetAll();
        Task<ICollection<T>> GetAll(ISpecification<T> specification);
    }
}
