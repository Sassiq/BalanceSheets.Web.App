using BalanceSheetsApp.Core.Entities;
using BalanceSheetsApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Specifications
{
    public class GetBankByIdSpecification : ISpecification<Bank>
    {
        private int Id;

        public GetBankByIdSpecification(int id)        {
            this.Id = id;
        }

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
            return query.Where(b => b.Id == this.Id);
        }
    }
}
