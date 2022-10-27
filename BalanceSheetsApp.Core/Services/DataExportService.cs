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

        public async Task<ICollection<Bank>> ExportBanks()
        {
            return await this.bankRepos.GetAll(new GetBanksSpecification());
        }
    }
}
