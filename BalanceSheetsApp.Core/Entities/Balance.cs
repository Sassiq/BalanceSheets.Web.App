using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheetsApp.Core.Entities
{
    public class Balance
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public decimal Active { get; set; }
        public decimal Passive { get; set; }
    }
}
