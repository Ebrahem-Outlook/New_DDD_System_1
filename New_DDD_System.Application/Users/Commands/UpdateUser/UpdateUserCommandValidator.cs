using FluentValidation;

namespace New_DDD_System.Application.Users.Commands.UpdateUser;

public sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(user => user.Id).NotNull().NotEmpty().WithMessage("User Id can't be null or empty.");

        RuleFor(user => user.FirstName).NotNull().NotEmpty().WithMessage("User FristName can't be null or empty.");

        RuleFor(user => user.LastName).NotNull().NotEmpty().WithMessage("User LastName can't be null or empty.");

        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("User Email can't be null or empty.");

        RuleFor(user => user.Phone).NotNull().NotEmpty().WithMessage("User Phone can't be null or empty.");
    }
}
