using FluentValidation;

namespace New_DDD_System.Application.Users.Commands.CreateUser;

public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(user => user.FirstName).NotEmpty().NotEmpty().WithMessage("FirstName of User Can't be null or empty.");

        RuleFor(user => user.LastName).NotEmpty().NotEmpty().WithMessage("LastName ofUser Can't be null or empty.");

        RuleFor(user => user.Email).NotEmpty().NotEmpty().WithMessage("Email of User Can't be null or empty.");

        RuleFor(user => user.Phone).NotEmpty().NotEmpty().WithMessage("Phone of User Can't be null or empty.");
    }
}
