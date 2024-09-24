using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_EfCore.Data
{
    public class InternalConfiguration
    {
        public class AppDbContext : DbContext
        {
            public DbSet<Branch> Branchs { get; set; }
            public DbSet<Account> Accounts { get; set; }
             
            public DbSet<Empolyee> empolyees { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
                var constr = config.GetSection("constr").Value;
                optionsBuilder.UseSqlServer(constr);
            }
        }
    }

    // ConfigurationByConvention
    public class ExternalConfiguration
    {
        public class AppDbContext : DbContext
        {
            public DbSet<Branch> Branchs { get; set; } = null!;
            public DbSet<Empolyee>Empolyees { get; set; } = null!;

            public DbSet<Customer> Customers { get; set; } = null!;

            public DbSet<Transaction> Transactions { get; set; } = null!;

            public DbSet<Account>Accounts { get; set; } = null!;    

            public AppDbContext(DbContextOptions options):base(options) { }
        } 
    }

    public class ConfigurationByDataAnnotations
    {

        public class AppDbContext : DbContext
       {
            public DbSet<Branch> tbl_Branchs { get; set; } = null!;
            public DbSet<Empolyee> tbl_Empolyees { get; set; } = null!;

            public DbSet<Customer> tbl_Customers { get; set; } = null!;

            public DbSet<Transaction> tbl_Transactions { get; set; } = null!;

            public DbSet<Account> tbl_Accounts { get; set; } = null!;

            public AppDbContext(DbContextOptions options) : base(options) { } 

       }
    }

    public class ConfigurationByFluentApi
    {
        public class AppDbContext : DbContext
        {

            public DbSet<Transaction>tbl_Transactions { get; set; } = null!;    
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Transaction>().ToTable("Transactions");// ToTable(Database table's name)
                modelBuilder.Entity<Transaction>().Property(t => t.TransactionId).HasColumnName("Id");
                modelBuilder.Entity<Transaction>().Property(t=>t.TimeTamp).HasColumnName("TimeTamp");
            }

                public AppDbContext(DbContextOptions options) : base(options) { }
        }
    }

    public class ConfigruationByAssembley
    {
        public class AppDbContext : DbContext
        {

            public DbSet<Transaction> Transactions { get; set; } = null!;
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.ApplyConfigurationsFromAssembly(typeof(Transaction).Assembly);
            }

            public AppDbContext(DbContextOptions options) : base(options) { }
        }
    }

    public class ConfigrutionEntity
    {
        public class AppDbContext : DbContext
        {
           // public DbSet<Account> accounts { get; set; }
            public DbSet<Transaction> transactions { get; set; }
            public DbSet<Branch> branches { get; set; }
            public DbSet<Customer> customers { get; set; }
            public DbSet<Empolyee> empolyees { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Account>().ToTable("Accounts",schema:"dbo").HasKey(x => x.Account_Id);
                modelBuilder.Entity<Empolyee>().ToTable("Employees").HasKey(x => x.Id);
                //modelBuilder.Ignore<Account>();//expection
                modelBuilder.HasDefaultSchema("dbo");
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
                var constr = config.GetSection("constr").Value;
                optionsBuilder.UseSqlServer(constr);
            }
        }
    }
}
