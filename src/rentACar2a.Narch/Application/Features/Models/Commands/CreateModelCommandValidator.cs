using FluentValidation;

namespace Application.Features.Models.Commands;

public class CreateModelCommandValidator : AbstractValidator<CreateModelCommand>
{
    public CreateModelCommandValidator()
    {
        RuleFor(m => m.BrandId).NotEmpty();
        RuleFor(m => m.FuelId).NotEmpty();
        RuleFor(m => m.TransmissionId).NotEmpty();
        RuleFor(m => m.Name).NotEmpty();
        RuleFor(m => m.DailyPrice).NotEmpty();
    }
}
