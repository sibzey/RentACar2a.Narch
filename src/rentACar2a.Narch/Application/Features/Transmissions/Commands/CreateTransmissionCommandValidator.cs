using FluentValidation;

namespace Application.Features.Transmissions.Commands;

public class CreateTransmissionCommandValidator : AbstractValidator<CreateTransmissionCommand>
{
    public CreateTransmissionCommandValidator()
    {
        RuleFor(t => t.Name).NotEmpty();
    }
}