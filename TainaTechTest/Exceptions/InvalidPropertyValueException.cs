using System;

namespace TainaTechTest.Exceptions
{
    /// <summary>
    /// A user defined exception to be thrown when invalid data is supplied by the client
    /// </summary>
    public class InvalidPropertyValueException : Exception
    {
        public InvalidPropertyValueException()
        {
        }

        public InvalidPropertyValueException(string property)
            : base($"{property} was assigned with an invalid value")
        {
        }

        public InvalidPropertyValueException(string property, string value)
            : base($"{property} was assigned with an invalid value of {value}")
        {
        }
    }
}