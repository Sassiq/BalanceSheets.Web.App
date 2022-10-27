using BalanceSheetsApp.Web.Models;

namespace BalanceSheetsApp.Web.Interfaces
{
    public interface IImportViewModelService
    {
        Task Parse(ImportViewModel model);
    }
}
