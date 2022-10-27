using BalanceSheetsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Interfaces
{
    public interface IDataExportService
    {
        Task<ICollection<Bank>> ExportBanks();
    }
}
