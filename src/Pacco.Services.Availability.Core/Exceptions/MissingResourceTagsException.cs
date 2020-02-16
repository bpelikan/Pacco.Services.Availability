﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class MissingResourceTagsException : DomainExceptionBase
    {
        public override string Code => "missing_resource_tags";

        public MissingResourceTagsException() : base("Resource tags is missing.")
        {
        }
    }
}
