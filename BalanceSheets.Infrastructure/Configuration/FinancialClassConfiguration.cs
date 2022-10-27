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
    internal class FinancialClassConfiguration : IEntityTypeConfiguration<FinancialClass>
    {
        public void Configure(EntityTypeBuilder<FinancialClass> builder)
        {
            builder.HasKey(k => k.Id);

            builder
                .HasOne(f => f.Bank)
                .WithMany(b => b.FinancialClasses)
                .HasForeignKey(f => f.BankId);
        }
    }
}
