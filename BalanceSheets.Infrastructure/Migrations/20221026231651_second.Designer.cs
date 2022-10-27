﻿// <auto-generated />
using BalanceSheets.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BalanceSheets.Infrastructure.Migrations
{
    [DbContext(typeof(BalanceSheetsDbContext))]
    [Migration("20221026231651_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OpeningBalanceId")
                        .HasColumnType("int");

                    b.Property<int>("TurnoverId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OpeningBalanceId")
                        .IsUnique();

                    b.HasIndex("TurnoverId")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.Balance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Active")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Passive")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.FinancialClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("FinancialClasses");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.MoneyTurnover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<decimal>("Credit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Debit")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MoneyTurnovers");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.Account", b =>
                {
                    b.HasOne("BalanceSheetsApp.Core.Entities.Balance", "OpeningBalance")
                        .WithOne("Account")
                        .HasForeignKey("BalanceSheetsApp.Core.Entities.Account", "OpeningBalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BalanceSheetsApp.Core.Entities.MoneyTurnover", "Turnover")
                        .WithOne("Account")
                        .HasForeignKey("BalanceSheetsApp.Core.Entities.Account", "TurnoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OpeningBalance");

                    b.Navigation("Turnover");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.FinancialClass", b =>
                {
                    b.HasOne("BalanceSheetsApp.Core.Entities.Bank", "Bank")
                        .WithMany("FinancialClasses")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.Balance", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.Bank", b =>
                {
                    b.Navigation("FinancialClasses");
                });

            modelBuilder.Entity("BalanceSheetsApp.Core.Entities.MoneyTurnover", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}