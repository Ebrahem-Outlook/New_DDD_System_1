using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetByEmail;

public sealed class GetByEmailQueryHandler : IQueryHandler<GetByEmailQuery, User>
{
    public Task<User> Handle(GetByEmailQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
