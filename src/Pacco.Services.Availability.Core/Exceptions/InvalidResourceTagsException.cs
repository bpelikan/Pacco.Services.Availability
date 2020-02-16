﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class InvalidResourceTagsException : DomainExceptionBase
    {
        public override string Code => "invalid_resource_tags";

        public InvalidResourceTagsException() : base("Resource tags is invalid.")
        {
        }
    }
}
