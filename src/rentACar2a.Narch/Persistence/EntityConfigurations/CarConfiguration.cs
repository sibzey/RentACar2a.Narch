using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars").HasKey(c => c.Id);
        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.ModelId).HasColumnName("ModelId");
        builder.Property(c => c.Name).HasColumnName("Ad");
        builder.Property(c => c.Color).HasColumnName("Renk");
        builder.Property(c => c.Kilometer).HasColumnName("Km");
        builder.Property(c => c.ModelYear).HasColumnName("ModelYearr");
        builder.Property(c => c.Plate).HasColumnName("Plate");

    }
}
