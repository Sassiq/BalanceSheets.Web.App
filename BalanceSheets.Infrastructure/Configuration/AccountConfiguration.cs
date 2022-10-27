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
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Ignore(a => a.ClosingBalance);

            builder
                .HasOne(a => a.OpeningBalance)
                .WithOne(b => b.Account)
                .HasForeignKey<Balance>(b => b.AccountId);
                

            builder
                .HasOne(a => a.Turnover)
                .WithOne(b => b.Account)
                .HasForeignKey<MoneyTurnover>(a => a.AccountId);

            builder
                .HasOne(a => a.FinancialClass)
                .WithMany(f => f.Accounts)
                .HasForeignKey(f => f.FinancialClassId);
        }
    }
}
