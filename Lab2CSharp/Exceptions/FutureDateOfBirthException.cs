using System;

namespace Lab3CSharp.Exceptions
{
    class FutureDateOfBirthException : Exception
    {

        public FutureDateOfBirthException()
        {
        }

        public FutureDateOfBirthException(string message)
            : base(message)
        {
        }

        public FutureDateOfBirthException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
