using System;
using System.Collections.Generic;
using System.Linq;
using Convey.CQRS.Commands;

namespace Pacco.Services.Availability.Application.Commands
{
    [Contract]
    public class AddResource : ICommand
    {
        public Guid ResourceId { get; }
        public IEnumerable<string> Tags { get; }

        public AddResource(Guid resourceId, IEnumerable<string> tags)
        {
            ResourceId = resourceId == Guid.Empty ? Guid.NewGuid() : resourceId;
            Tags = tags ?? Enumerable.Empty<string>();
        }
    }
}