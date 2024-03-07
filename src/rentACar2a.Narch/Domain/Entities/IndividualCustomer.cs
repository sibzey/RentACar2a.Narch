using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class IndividualCustomer : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string NationalIdentity { get; set; }
    public Guid CustomerId { get; set; }
    public virtual Customer Customer  { get; set; }
}
