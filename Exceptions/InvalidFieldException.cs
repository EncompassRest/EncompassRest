using System;

namespace EncompassRest.Exceptions
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