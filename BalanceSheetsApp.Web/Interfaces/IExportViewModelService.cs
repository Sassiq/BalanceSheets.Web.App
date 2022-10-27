using BalanceSheetsApp.Web.Models;

namespace BalanceSheetsApp.Web.Interfaces
{
    public interface IExportViewModelService
    {
        Task<ICollection<BankViewModel>> ExportBanks();
    }
}
