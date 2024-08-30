using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetByName;

internal sealed class GetUserByNameQueryHandler : IQueryHandler<GetUserByNameQuery, IEnumerable<User>>
{
    private readonly IUserRepository _userRepository;

    public GetUserByNameQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> Handle(GetUserByNameQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetByNameAsync(request.Name.ToLower(), cancellationToken);
    }
}
