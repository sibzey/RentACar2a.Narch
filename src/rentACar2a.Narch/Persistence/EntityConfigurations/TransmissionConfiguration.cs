using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.ToTable("Transmissions").HasKey(t => t.Id);
    }
}