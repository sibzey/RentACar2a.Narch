using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class CorporateCustomer : Entity<Guid>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
}
