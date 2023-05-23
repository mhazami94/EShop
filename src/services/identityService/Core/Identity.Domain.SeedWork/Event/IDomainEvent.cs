using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.SeedWork.Event
{
    public interface IDomainEvent : INotification
    {
        DateTime CreateAt { get; }
    }
}
