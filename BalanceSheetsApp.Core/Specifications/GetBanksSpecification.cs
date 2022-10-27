using BalanceSheetsApp.Core.Entities;
using BalanceSheetsApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Specifications
{
    public class GetBanksSpecification : ISpecification<Bank>
    {
        public IList<string> Includes => new List<string>()
        {
            $"{nameof(Bank.FinancialClasses)}" +
            $".{nameof(FinancialClass.Accounts)}" +
            $".{nameof(Account.OpeningBalance)}",
            $"{nameof(Bank.FinancialClasses)}" +
            $".{nameof(FinancialClass.Accounts)}" +
            $".{nameof(Account.Turnover)}"
        };

        public IQueryable<Bank> Apply(IQueryable<Bank> query)
        {
            return query;
        }
    }
}
