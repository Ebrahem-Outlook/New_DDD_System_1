using FluentValidation;

namespace New_DDD_System.Application.Users.Queries.GetByEmail;

public sealed class GetUserByEmailQueryValidator : AbstractValidator<GetUserByEmailQuery>
{
    public GetUserByEmailQueryValidator()
    {
        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("Email of user can't be null or empty.");
    }
}
