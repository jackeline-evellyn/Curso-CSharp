using System;
using System.Collections.Generic;
using System.Text;

namespace _145._Excecoes_personalizadas_3.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }

    }
}
