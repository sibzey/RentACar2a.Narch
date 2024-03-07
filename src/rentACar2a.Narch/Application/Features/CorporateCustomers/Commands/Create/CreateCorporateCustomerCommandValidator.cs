using FluentValidation;

namespace Application.Features.CorporateCustomers.Commands.Create;

public class CreateCorporateCustomerCommandValidator : AbstractValidator<CreateCorporateCustomerCommand>
{
    public CreateCorporateCustomerCommandValidator()
    {
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.Password).NotEmpty().MinimumLength(4);
        RuleFor(c => c.CompanyName).NotEmpty();
        RuleFor(c => c.TaxNo).NotEmpty();
        RuleFor(c => c.CustomerId).NotEmpty();
    }
}