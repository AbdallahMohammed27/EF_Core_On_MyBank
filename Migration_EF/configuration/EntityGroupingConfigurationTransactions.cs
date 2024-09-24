using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration_EF.configuration
{
    public class EntityGroupingConfigurationTransactions : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(e=>e.TransactionId);
            builder.Property(e=>e.TransactionId).IsRequired().ValueGeneratedNever();
            builder.Property(e => e.Amount).HasPrecision(15, 2);
            builder.Property(e => e.TimeTamp).HasColumnType("DateTime");

            builder.ToTable("Transactions");

            builder.HasOne(e => e.Account)
                .WithMany(e => e.Transactions)
                .HasForeignKey(e => e.TransactionId)
                .IsRequired();

            builder.HasData(LoadTransaction());
        }

        private static List<Transaction> LoadTransaction()
        {
            return new List<Transaction>()
            {
                new Transaction{Account_Id=3,TransactionId=1,Amount=39303.3903m, TimeTamp = new DateTime(2003,4,2)}
            };
        }
    }
}
