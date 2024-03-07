using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
{
    public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
    {
        builder.ToTable("CorporateCustomers").HasKey(cc => cc.Id);

        builder.Property(cc => cc.Id).HasColumnName("Id").IsRequired();
        builder.Property(cc => cc.Email).HasColumnName("Email");
        builder.Property(cc => cc.Password).HasColumnName("Password");
        builder.Property(cc => cc.CompanyName).HasColumnName("CompanyName");
        builder.Property(cc => cc.TaxNo).HasColumnName("TaxNo");
        builder.Property(cc => cc.CustomerId).HasColumnName("CustomerId");
        builder.Property(cc => cc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(cc => cc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(cc => cc.DeletedDate).HasColumnName("DeletedDate");
        builder.HasIndex(indexExpression: cc => cc.CustomerId, name: "CorporateCustomer_CustomerID_UK").IsUnique();

        builder.HasOne(cc => cc.Customer);

        builder.HasQueryFilter(cc => !cc.DeletedDate.HasValue);
    }
}