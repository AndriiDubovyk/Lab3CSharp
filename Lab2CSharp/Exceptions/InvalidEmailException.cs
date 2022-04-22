using System;

namespace Lab3CSharp.Exceptions
{
    class InvalidEmailException : Exception
    {

        public InvalidEmailException()
        {
        }

        public InvalidEmailException(string message)
            : base(message)
        {
        }

        public InvalidEmailException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
