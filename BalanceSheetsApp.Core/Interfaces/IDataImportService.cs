using BalanceSheetsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Interfaces
{
    public interface IDataImportService
    {
        Task ImportAccount(Account account);
        Task ImportBank(Bank bank);
        Task ImportBalance(Balance balance);
        Task ImportFinancialClass(FinancialClass financialClass);
        Task ImportMoneyTurnover(MoneyTurnover moneyTurnover);
    }
}
