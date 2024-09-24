using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migration_EF.configuration
{
    public class EntityGroupingConfigurationEmployee : IEntityTypeConfiguration<Empolyee>
    {
        public void Configure(EntityTypeBuilder<Empolyee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired().ValueGeneratedNever();
            builder.Property(e=>e.Salary).IsRequired().HasPrecision(15,2);
            builder.Property(e=>e.Title).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Birth_Date).HasColumnType("DateTime");
            builder.Property(e => e.Lname).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Fname).HasColumnType("varchar").HasMaxLength(50);

            builder.ToTable("Empolyees");

            builder.HasOne(e => e.Branch)
                .WithMany(e => e.empolyees)
                .HasForeignKey(e => e.Branch_Id)
                .IsRequired();

            builder.HasData(LoadEmpolyees());
        }

        private static List<Empolyee> LoadEmpolyees()
        {
            return new List<Empolyee>
            {
                new Empolyee{Id=3,Birth_Date=new DateTime(2014,5,6),Branch_Id=1,Fname="abdallah",Lname="ali",Salary=453.3343m, Title= "Gaza"}
            };
        }
    }
}
