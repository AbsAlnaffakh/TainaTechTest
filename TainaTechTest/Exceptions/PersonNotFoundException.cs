using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TainaTechTest.Exceptions
{
    /// <summary>
    /// A user defined exception to be thrown when a person entity with the specified id does not exist
    /// </summary>
    public class PersonNotFoundException : Exception
    {
        public PersonNotFoundException()
        {
        }

        public PersonNotFoundException(string message)
            : base(message)
        {
        }

        public PersonNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}