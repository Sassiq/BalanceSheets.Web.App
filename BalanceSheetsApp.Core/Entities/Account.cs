using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public MoneyTurnover Turnover { get; set; }
        public Balance OpeningBalance { get; set; }
        public Balance ClosingBalance 
        {
            get => new Balance()
            {
                Active = OpeningBalance.Active != 0 ? OpeningBalance.Active + Turnover.Debit - Turnover.Credit : 0,
                Passive = OpeningBalance.Passive != 0 ? OpeningBalance.Passive - Turnover.Debit + Turnover.Credit : 0,
            };
        }
        public int FinancialClassId { get; set; }
        public FinancialClass FinancialClass { get; set; }
    }
}
