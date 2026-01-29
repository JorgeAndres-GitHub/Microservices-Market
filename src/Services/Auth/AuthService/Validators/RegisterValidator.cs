using FluentValidation;
using Interface_Adapters.DTOs;

namespace AuthService.Validators
{
    public sealed class RegisterValidator : AbstractValidator<RegisterUserDto>
    {
        public RegisterValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required.").EmailAddress().WithMessage("Invalid email format.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm Password is required.").Equal(x => x.Password).WithMessage("Passwords do not match.");
        }
    }
}
