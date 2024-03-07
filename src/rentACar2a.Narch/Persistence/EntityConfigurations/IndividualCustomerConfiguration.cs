using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.ToTable("IndividualCustomers").HasKey(ic => ic.Id);

        builder.Property(ic => ic.Id).HasColumnName("Id").IsRequired();
        builder.Property(ic => ic.FirstName).HasColumnName("FirstName");
        builder.Property(ic => ic.LastName).HasColumnName("LastName");
        builder.Property(ic => ic.Password).HasColumnName("Password");
        builder.Property(ic => ic.Email).HasColumnName("Email");
        builder.Property(ic => ic.NationalIdentity).HasColumnName("NationalIdentity");
        builder.Property(ic => ic.CustomerId).HasColumnName("CustomerId");
        builder.Property(ic => ic.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ic => ic.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ic => ic.DeletedDate).HasColumnName("DeletedDate");
        builder.HasIndex(indexExpression: ic => ic.CustomerId, name: "CorporateCustomer_CustomerID_UK").IsUnique();

        builder.HasOne(ic => ic.Customer);

        builder.HasQueryFilter(ic => !ic.DeletedDate.HasValue);
    }
}