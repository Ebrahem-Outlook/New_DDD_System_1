using New_DDD_System.Application.Core.CQRS;

namespace New_DDD_System.Application.Users.Commands.CreateUser;

public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    public Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
