using BalanceSheetsApp.Web.Models;

namespace BalanceSheetsApp.Web.Interfaces
{
    public interface IExportViewModelService
    {
        Task<ICollection<BankViewModel>> ExportBankNames();
        Task<BankViewModel> ExportBank(int id);
    }
}
