using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Interfaces
{
    public interface ISpecification<T>
    {
        public IList<string> Includes { get; }
        public IQueryable<T> Apply(IQueryable<T> query);
    }
}
