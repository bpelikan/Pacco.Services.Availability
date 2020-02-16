using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public abstract class DomainExceptionBase : Exception
    {
        public abstract string Code { get; }

        protected DomainExceptionBase(string message) : base(message)
        { 
        }
    }
}
