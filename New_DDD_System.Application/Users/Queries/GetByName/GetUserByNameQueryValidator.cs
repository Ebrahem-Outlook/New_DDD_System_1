using FluentValidation;

namespace New_DDD_System.Application.Users.Queries.GetByName;

internal sealed class GetUserByNameQueryValidator : AbstractValidator<GetUserByNameQuery>
{
    public GetUserByNameQueryValidator()
    {
        RuleFor(user => user.Name).NotNull().NotEmpty().WithMessage("Name of user can't be null or empty.");
    }
}
