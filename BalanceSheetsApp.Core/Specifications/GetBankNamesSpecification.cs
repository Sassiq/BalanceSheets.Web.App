using BalanceSheetsApp.Core.Entities;
using BalanceSheetsApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Specifications
{
    public class GetBankNamesSpecification : ISpecification<Bank>
    {
        public IList<string> Includes => null;

        public IQueryable<Bank> Apply(IQueryable<Bank> query)
        {
            return query;
        }
    }
}
