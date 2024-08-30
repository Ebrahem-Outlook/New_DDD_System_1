using MediatR;
using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Application.Core.Data;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Commands.CreateUser;

public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User user = User.Create(request.FirstName.ToLower(), request.LastName.ToLower(), request.Email.ToLower(), request.Phone);

        await _userRepository.AddAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
