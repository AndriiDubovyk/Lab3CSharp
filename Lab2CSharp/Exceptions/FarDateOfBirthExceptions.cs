using System;

namespace Lab3CSharp.Exceptions
{
    class FarDateOfBirthException : Exception
    {

        public FarDateOfBirthException()
        {
        }

        public FarDateOfBirthException(string message)
            : base(message)
        {
        }

        public FarDateOfBirthException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
