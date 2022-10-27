using BalanceSheetsApp.Core.Entities;
using BalanceSheetsApp.Core.Interfaces;
using BalanceSheetsApp.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Services
{
    public class DataExportService : IDataExportService
    {
        private readonly IRepository<Bank> bankRepos;
        public DataExportService(IRepository<Bank> bankRepos)
        {
            this.bankRepos = bankRepos;
        }

        public async Task<ICollection<Bank>> ExportBankNames()
        {
            return await this.bankRepos.GetAll(new GetBankNamesSpecification());
        }

        public async Task<Bank> ExportBank(int id)
        {
            return await this.bankRepos.Get(new GetBankByIdSpecification(id));
        }
    }
}
