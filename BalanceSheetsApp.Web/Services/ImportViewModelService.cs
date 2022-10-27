using BalanceSheetsApp.Core.Entities;
using BalanceSheetsApp.Core.Interfaces;
using BalanceSheetsApp.Web.Interfaces;
using BalanceSheetsApp.Web.Models;
using IronXL;

namespace BalanceSheetsApp.Web.Services
{
    public class ImportViewModelService : IImportViewModelService
    {
        private readonly IDataImportService service;
        public ImportViewModelService(IDataImportService service)
        {
            this.service = service;
        }

        public async Task Parse(ImportViewModel model)
        {
            Bank bank = new Bank()
            {
                FinancialClasses = new List<FinancialClass>(),
            };

            using (Stream fileStream = model.File.OpenReadStream())
            {
                WorkBook workBook = new WorkBook(fileStream);
                WorkSheet cells = workBook.WorkSheets.First();
                bank.Name = cells["A1:A1"].First().Text;

                foreach (var cell in cells.Where(cell => cell.ColumnIndex == 0 && cell.RowIndex >= 8))
                {
                    if (cell.Text.Contains("КЛАСС "))
                    {
                        var newClass = new FinancialClass()
                        {
                            Name = cell.Text,
                            Bank = bank,
                            Accounts = new List<Account>(),
                        };

                        bank.FinancialClasses.Add(newClass);
                    }
                    else if (int.TryParse(cell.Text, out int intValue) && intValue / 1000 > 0)
                    {
                        int rowIndex = cell.RowIndex + 1;
                        Balance openingBalance = new Balance()
                        {
                            Active = Convert.ToDecimal(cells[$"B{rowIndex}:B{rowIndex}"].First().Text),
                            Passive = Convert.ToDecimal(cells[$"C{rowIndex}:C{rowIndex}"].First().Text),
                        };

                        MoneyTurnover turnover = new MoneyTurnover()
                        {
                            Debit = Convert.ToDecimal(cells[$"D{rowIndex}:D{rowIndex}"].First().Text),
                            Credit = Convert.ToDecimal(cells[$"E{rowIndex}:E{rowIndex}"].First().Text),
                        };

                        bank.FinancialClasses.Last().Accounts.Add(new Account()
                        {
                            Number = intValue,
                            Turnover = turnover,
                            OpeningBalance = openingBalance,
                            FinancialClass = bank.FinancialClasses.Last(),
                        });
                    }
                }
            }

            await this.service.ImportBank(bank);
        }
    }
}
