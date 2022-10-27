using BalanceSheetsApp.Core.Entities;
using BalanceSheetsApp.Core.Interfaces;
using BalanceSheetsApp.Web.Interfaces;
using BalanceSheetsApp.Web.Models;

namespace BalanceSheetsApp.Web.Services
{
    public class ExportViewModelService : IExportViewModelService
    {
        private readonly IDataExportService service;

        public ExportViewModelService(IDataExportService service)
        {
            this.service = service;
        }

        public async Task<BankViewModel> ExportBank(int id)
        {
            return ConvertToModel(await service.ExportBank(id));
        }

        public async Task<ICollection<BankViewModel>> ExportBankNames()
        {
            var bankViewModels = new List<BankViewModel>();
            foreach (var bank in await service.ExportBankNames())
            {
                bankViewModels.Add(new BankViewModel()
                {
                    Id = bank.Id,
                    Name = bank.Name,
                });
            }

            return bankViewModels;
        }

        private BankViewModel ConvertToModel(Bank bank)
        {
            BankViewModel bankViewModel = new BankViewModel();
            bankViewModel.Name = bank.Name;
            bankViewModel.Id = bank.Id;
            bankViewModel.FinancialClasses = new List<FinancialClassViewModel>();
            foreach (var financialClass in bank.FinancialClasses)
            {
                bankViewModel.FinancialClasses.Add(ConvertToModel(financialClass));
            }

            return bankViewModel;
        }
        
        private FinancialClassViewModel ConvertToModel(FinancialClass financialClass)
        {
            FinancialClassViewModel financialClassViewModel = new FinancialClassViewModel();
            financialClassViewModel.Name = financialClass.Name;
            financialClassViewModel.Accounts = new List<AccountViewModel>();
            foreach (var account in financialClass.Accounts)
            {
                financialClassViewModel.Accounts.Add(ConvertToModel(account));
            }

            return financialClassViewModel;
        }

        private AccountViewModel ConvertToModel(Account account) => new AccountViewModel()
        {
            Number = account.Number,
            Credit = account.Turnover.Credit,
            Debit = account.Turnover.Debit,
            OpeningBalance = ConvertToModel(account.OpeningBalance),
            ClosingBalance = ConvertToModel(account.ClosingBalance),
        };

        private BalanceViewModel ConvertToModel(Balance balance) => new BalanceViewModel()
        {
            Active = balance.Active,
            Passive = balance.Passive,
        };
    }
}
