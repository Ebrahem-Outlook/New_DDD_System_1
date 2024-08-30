using MediatR;
using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Application.Core.Data;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Commands.UpdateUser;

public sealed class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

        if (user is null)
        {
            throw new NullReferenceException("User with specified Id does't exsit.");
        }

        user.UpdateUser(request.FirstName, request.LastName, request.Email, request.Phone);

        _userRepository.Update(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
