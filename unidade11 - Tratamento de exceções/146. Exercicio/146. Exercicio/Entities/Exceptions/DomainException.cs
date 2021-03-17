using System;
using System.Collections.Generic;
using System.Text;

namespace _146._Exercicio.Entities.Exceptions
{
    class DomainException: ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
