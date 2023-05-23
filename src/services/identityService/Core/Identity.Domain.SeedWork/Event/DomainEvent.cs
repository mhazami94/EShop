using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.SeedWork.Event
{
    public abstract record class DomainEvent : Message, IDomainEvent
    {
        public DateTime CreateAt { get; init; }
        public DomainEvent()
        {
            CreateAt = DateTime.Now;
        }
    }
}
