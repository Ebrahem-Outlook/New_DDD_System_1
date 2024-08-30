using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetById;

internal sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, User>
{
    private readonly IUserRepository _userRepository;

    public GetUserByIdQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            throw new NullReferenceException("User with specified Id does't exsit.");
        }

        return user;
    }
}
