using BalanceSheets.Infrastructure.Configuration;
using BalanceSheetsApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheets.Infrastructure
{
    public class BalanceSheetsDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<FinancialClass> FinancialClasses { get; set; }
        public DbSet<MoneyTurnover> MoneyTurnovers { get; set; }

        public BalanceSheetsDbContext(DbContextOptions<BalanceSheetsDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AccountConfiguration().Configure(modelBuilder.Entity<Account>());
            new BalanceConfiguration().Configure(modelBuilder.Entity<Balance>());
            new BankConfiguration().Configure(modelBuilder.Entity<Bank>());
            new FinancialClassConfiguration().Configure(modelBuilder.Entity<FinancialClass>());
            new MoneyTurnoverConfiguration().Configure(modelBuilder.Entity<MoneyTurnover>());
        }
    }
}
