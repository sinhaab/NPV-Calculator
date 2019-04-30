using FluentValidation;
using Model;

public class UserValidator : AbstractValidator<NpvEntity>
{
    public UserValidator()
    {
        RuleFor(x => x.lowerBoundRate)
        .NotNull()
        .WithMessage("Lower discount rate is mandatory.");

        RuleFor(x => x.upperBoundRate)
        .NotNull()
        .WithMessage("Upper discount rate is mandatory.");

        RuleFor(x => x.discountRate)
        .NotNull()
        .WithMessage("Discount rate increment is mandatory.");

    }
}
