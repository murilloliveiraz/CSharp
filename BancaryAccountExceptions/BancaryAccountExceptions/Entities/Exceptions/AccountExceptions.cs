using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaryAccountExceptions.Entities.Exceptions
{
    internal class AccountExceptions : ApplicationException
    {
        public AccountExceptions(string message) : base(message)
        {
        }
    }
}
