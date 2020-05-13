using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Algorithms.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException() : base("Falha de domínio") { }

        public DomainException(string message) : base(message) { }

        public DomainException(string message, Exception innerException) : base(message, innerException) { }

        public DomainException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}