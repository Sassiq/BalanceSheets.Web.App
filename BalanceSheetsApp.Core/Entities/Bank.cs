using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Entities
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FinancialClass> FinancialClasses { get; set; }
    }
}
