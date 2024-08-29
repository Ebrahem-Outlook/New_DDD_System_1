using MediatR;

namespace New_DDD_System.Application.Core.CQRS;

public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
    where TCommand : ICommand
{

}
