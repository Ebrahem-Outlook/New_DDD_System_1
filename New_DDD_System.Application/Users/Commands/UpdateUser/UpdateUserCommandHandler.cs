using New_DDD_System.Application.Core.CQRS;

namespace New_DDD_System.Application.Users.Commands.UpdateUser;

public sealed class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
{
    public Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
