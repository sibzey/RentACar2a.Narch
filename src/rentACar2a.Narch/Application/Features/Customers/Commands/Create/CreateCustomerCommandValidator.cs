using FluentValidation;

namespace Application.Features.Customers.Commands.Create;

public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.Password).NotEmpty();
        RuleFor(c => c.CustomerNo).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.IndividualCustomerId).NotEmpty();
        RuleFor(c => c.CorporateCustomerId).NotEmpty();
    }
}