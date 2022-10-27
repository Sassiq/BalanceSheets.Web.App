using BalanceSheetsApp.Core.Entities;
using BalanceSheetsApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Services
{
    public class DataImportService : IDataImportService
    {
        private readonly IRepository<Account> accountRepos;
        private readonly IRepository<Balance> balanceRepos;
        private readonly IRepository<Bank> bankRepos;
        private readonly IRepository<FinancialClass> financialClassRepos;
        private readonly IRepository<MoneyTurnover> moneyTurnoverRepos;

        public DataImportService(IRepository<Account> accountRepos, IRepository<Balance> balanceRepos, IRepository<Bank> bankRepos, IRepository<FinancialClass> financialClassRepos, IRepository<MoneyTurnover> moneyTurnoverRepos)
        {
            this.accountRepos = accountRepos;
            this.balanceRepos = balanceRepos;
            this.bankRepos = bankRepos;
            this.financialClassRepos = financialClassRepos;
            this.moneyTurnoverRepos = moneyTurnoverRepos;
        }

        public async Task ImportAccount(Account account)
        {
            await this.accountRepos.Add(account);
        }

        public async Task ImportBalance(Balance balance)
        {
            await this.balanceRepos.Add(balance);
        }

        public async Task ImportBank(Bank bank)
        {
            await this.bankRepos.Add(bank);
        }

        public async Task ImportFinancialClass(FinancialClass financialClass)
        {
            await this.financialClassRepos.Add(financialClass);
        }

        public async Task ImportMoneyTurnover(MoneyTurnover moneyTurnover)
        {
            await this.moneyTurnoverRepos.Add(moneyTurnover);
        }
    }
}
