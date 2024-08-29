using New_DDD_System.Application.Core.CQRS;

namespace New_DDD_System.Application.Users.Commands.DeleteUser;

public sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
{
    public Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
