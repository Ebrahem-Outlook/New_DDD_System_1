using Microsoft.VisualBasic;
using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetByEmail;

public sealed class GetUserByEmailQueryHandler : IQueryHandler<GetUserByEmailQuery, User>
{
    private IUserRepository _userRepository;

    public GetUserByEmailQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetByEmailAsync(request.Email.ToLower(), cancellationToken);

        if (user == null)
        {
            throw new NullReferenceException("User with specified Email does't exsit.");
        }

        return user;
    }
}
