using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Queries.GetById;

public class GetByIdCustomerResponse : IResponse
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