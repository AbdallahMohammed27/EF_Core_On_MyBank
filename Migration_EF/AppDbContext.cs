using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Migration_EF.configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration_EF
{
    public class AppDbContext : DbContext
    {

        DbSet<Account> Accounts;
        DbSet<Branch>Branches;
        DbSet<Empolyee> Empolyees;
        DbSet<Transaction> Transactions;
        DbSet<Customer>Customers;
        DbSet<Manager> Managers;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<Account>();
            //modelBuilder.ApplyConfiguration(new EntityGroupingConfigurationBranch());
            //modelBuilder.ApplyConfiguration(new EntityGroupingConfigurationEmployee());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr,o=>o.MinBatchSize(1),o.MaxBatchSize(4));
        }
    }
}
