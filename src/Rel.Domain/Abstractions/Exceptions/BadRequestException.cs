﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rel.Domain.Abstractions.Exceptions;

public abstract class BadRequestException : DomainException
{
    protected BadRequestException(string message) : base("Bad Request", message)
    {
    }
}
