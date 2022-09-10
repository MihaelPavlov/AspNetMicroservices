namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    using FluentValidation;

    public class CheckoutOrderCommandValidator : AbstractValidator<CheckoutOrderCommand>
    {
        public CheckoutOrderCommandValidator()
        {
            this.RuleFor(p => p.UserName)
                  .NotEmpty().WithMessage("{UserName} is required.")
                  .NotNull()
                  .MaximumLength(50).WithMessage("{UserName} must not exceed 50 characters.");

            this.RuleFor(p => p.EmailAddress)
               .NotEmpty().WithMessage("{EmailAddress} is required.");

            this.RuleFor(p => p.TotalPrice)
                .NotEmpty().WithMessage("{TotalPrice} is required.")
                .GreaterThan(0).WithMessage("{TotalPrice} should be greater than zero.");
        }
    }
}
