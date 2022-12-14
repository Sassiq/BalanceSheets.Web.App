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
        private readonly IRepository<Bank> bankRepos;
        public DataImportService(IRepository<Bank> bankRepos)
        {
            this.bankRepos = bankRepos;
        }

        public async Task ImportBank(Bank bank)
        {
            await this.bankRepos.Add(bank);
        }
    }
}
