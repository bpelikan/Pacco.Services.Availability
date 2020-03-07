using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class InvalidAggregateIdException : DomainException
    {
        public override string Code => "invalid_aggregate_id";
        public Guid Id{ get; set; }

        public InvalidAggregateIdException(Guid id) : base($"Invalid aggregate id: {id}")
        {
            Id = id;
        }
    }
}
