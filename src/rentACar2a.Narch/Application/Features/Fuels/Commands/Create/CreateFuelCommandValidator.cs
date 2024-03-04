using FluentValidation;

namespace Application.Features.Fuels.Commands.Create;

public class CreateFuelCommandValidator : AbstractValidator<CreateFuelCommand>
{
    public CreateFuelCommandValidator()
    {
        RuleFor(f => f.Name).NotEmpty();
    }
}
