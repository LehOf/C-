using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.Entities.Exception
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }
    }
}
