using BalanceSheetsApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheets.Infrastructure.Configuration
{
    internal class MoneyTurnoverConfiguration : IEntityTypeConfiguration<MoneyTurnover>
    {
        public void Configure(EntityTypeBuilder<MoneyTurnover> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
