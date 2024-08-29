using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetByName;

internal sealed class GetUserByNameQueryHandler : IQueryHandler<GetUserByNameQuery, User>
{
    public Task<User> Handle(GetUserByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
