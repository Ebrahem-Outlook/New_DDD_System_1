using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetAll;

public sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, IEnumerable<User>>
{
    public Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
