using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Entities
{
    public class FinancialClass
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public string Name { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
