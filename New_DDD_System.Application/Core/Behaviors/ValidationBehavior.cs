using MediatR;
using System.Runtime.CompilerServices;

namespace New_DDD_System.Application.Core.Behaviors;

internal sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest
    where TResponse : class
{
    public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        

        throw new NotImplementedException();
    }
}
