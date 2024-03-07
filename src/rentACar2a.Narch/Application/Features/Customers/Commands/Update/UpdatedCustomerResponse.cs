using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Commands.Update;

public class UpdatedCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? CustomerNo { get; set; }
    public Guid UserId { get; set; }
    public Guid IndividualCustomerId { get; set; }
    public Guid CorporateCustomerId { get; set; }
}