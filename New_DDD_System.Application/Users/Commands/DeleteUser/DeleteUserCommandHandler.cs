using MediatR;
using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Application.Core.Data;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Commands.DeleteUser;

public sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

        if(user is null)
        {
            throw new NullReferenceException("User with specified Id does't exsit.");
        }

        _userRepository.Delete(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
