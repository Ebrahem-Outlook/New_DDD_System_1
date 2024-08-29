using FluentValidation;

namespace New_DDD_System.Application.Users.Commands.DeleteUser;

public sealed class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        RuleFor(user => user.Id).NotNull().NotEmpty().WithMessage("User Id Can't be null or empty.");
    }
}
