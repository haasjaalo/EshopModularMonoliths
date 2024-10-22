using MediatR;

namespace Shared.DDD
    {
    public class IDomainEvent : INotification
        {
        Guid EventId=> Guid.NewGuid();

        public DateTime OccuredOn => DateTime.Now;

        public string EventType => GetType().AssemblyQualifiedName!;


        }
    }
