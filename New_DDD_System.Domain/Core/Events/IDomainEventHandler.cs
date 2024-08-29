using MediatR;

namespace New_DDD_System.Domain.Core.Events;

public interface IDomainEventHandler<in TDomainEvent> : INotificationHandler<TDomainEvent>
    where TDomainEvent : IDomainEvent
{

}
