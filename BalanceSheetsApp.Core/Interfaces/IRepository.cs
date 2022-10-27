using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<T> Get(int id);
        public Task Add(T item);
        public Task Delete(T item);
        public Task Update(T item);
        public Task<ICollection<T>> GetAll();
        public T Get(ISpecification<T> specification);
        public ICollection<T> GetAll(ISpecification<T> specification);
    }
}
