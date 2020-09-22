using System;
using System.Collections.Generic;
using System.Text;

namespace Cap11_Exercicios.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
