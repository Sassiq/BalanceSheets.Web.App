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
        public int TurnoverId { get; set; }
        public MoneyTurnover Turnover { get; set; }
        public int OpeningBalanceId { get; set; }
        public Balance OpeningBalance { get; set; }
        public Balance ClosingBalance { get; set; }
        public int FinancialClassId { get; set; }
        public FinancialClass FinancialClass { get; set; }
    }
}
