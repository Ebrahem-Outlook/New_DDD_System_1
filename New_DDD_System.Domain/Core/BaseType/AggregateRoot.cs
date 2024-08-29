using New_DDD_System.Domain.Core.Events;

namespace New_DDD_System.Domain.Core.BaseType;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() : base() { }

    private readonly IList<IDomainEvent> domainEvent;

    public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvent.AsReadOnly();

    public void Raise(IDomainEvent @event) => domainEvent.Add(@event);

    public void Clear() => domainEvent.Clear();
}
