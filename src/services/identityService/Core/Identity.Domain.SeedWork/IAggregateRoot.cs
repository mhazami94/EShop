using Identity.Domain.SeedWork.Event;

namespace Identity.Domain.SeedWork
{
    public interface IAggregateRoot
    {
        IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
        void ClearDomainEvent();
    }
}
