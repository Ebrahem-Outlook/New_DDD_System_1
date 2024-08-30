using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetAll;

public sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, IEnumerable<User>>
{
    private readonly IUserRepository _userRepository;

    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetAllAsync(cancellationToken);
    }
}
