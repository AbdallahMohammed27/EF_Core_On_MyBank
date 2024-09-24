using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migration_EF.configuration
{
    public class EntityGroupingConfigurationBranch : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired().ValueGeneratedNever();
            builder.Property(e => e.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Location).HasColumnType("varchar").HasMaxLength(50);
            builder.ToTable("Branchs");

            builder.HasData(LoadBranchs());
        }

        private static List<Branch> LoadBranchs()
        {
            return new List<Branch>
            {
                new Branch{Id=3,Location="Luxor",Name="LuxorBank"}
            };
        }
    }
}
