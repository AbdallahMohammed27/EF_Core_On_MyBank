using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration_EF.configuration
{
    public class EntityGroupingConfigurationCustomer : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e=>e.Id);
            builder.Property(e=>e.Id).IsRequired().ValueGeneratedNever();
            builder.Property(e => e.Title).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Birth_Date).HasColumnType("DateTime");
            builder.Property(e => e.Fname).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Lname).HasColumnType("varchar").HasMaxLength(50);

            builder.ToTable("Customers");

            builder.HasData(LoadCustomers());
        }

        private static List<Customer> LoadCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=3,Fname="abdallah",Lname="mohammed",Birth_Date=new DateTime(2003,1,2),Title="Luxor"}
            };
        }
    }
}
