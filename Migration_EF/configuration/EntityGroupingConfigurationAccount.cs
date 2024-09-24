using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration_Ef.configuration
{
    public class EntityGroupingConfigurationAccount : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(e => e.Account_Id);
            builder.Property(e => e.Account_Id).IsRequired().ValueGeneratedNever();
            builder.Property(e => e.Balance).IsRequired().HasPrecision(15, 2);

            builder.ToTable("Accounts");

            builder.HasOne(e => e.Branch)
                .WithMany(e => e.Accounts)
                .HasForeignKey(e => e.Branch_Id)
                .IsRequired();

            builder.HasOne(e => e.Customer)
                .WithMany(e => e.Accounts)
                .HasForeignKey(e=>e.Customer_Id)
                .IsRequired()
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(LoadAccounts());
        }

        private  static List<Account> LoadAccounts()
        {
            return new List<Account>
            {
                new Account{Account_Id = 3, Balance = 33.33m, Customer_Id = 1, Branch_Id = 1}
            };
        }
    }
}
