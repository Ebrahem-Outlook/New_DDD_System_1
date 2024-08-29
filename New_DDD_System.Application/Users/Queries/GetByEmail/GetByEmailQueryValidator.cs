using FluentValidation;

namespace New_DDD_System.Application.Users.Queries.GetByEmail;

public sealed class GetByEmailQueryValidator : AbstractValidator<GetByEmailQuery>
{
    public GetByEmailQueryValidator()
    {
        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("User");
    }
}
