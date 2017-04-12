using System;

namespace EncompassREST.Exceptions
{
    class InvalidFieldException : Exception
    {
        public string Field { get; }

        public InvalidFieldException(string field)
        {
            Field = field;
        }
    }
}
