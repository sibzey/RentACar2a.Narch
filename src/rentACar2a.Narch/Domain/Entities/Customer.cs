using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Customer : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public IndividualCustomer? IndividualCustomer { get; set; } = null;
    public CorporateCustomer? CorporateCustomer { get; set; } = null;
    public Guid IndividualCustomerId { get; set; }
    public Guid CorporateCustomerId { get; set; } 
}
