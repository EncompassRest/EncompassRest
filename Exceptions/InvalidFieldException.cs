using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Exceptions
{
    class InvalidFieldException : Exception
    {
        private string _FieldID;

        public string Field
        {
            get { return _FieldID; }
        }

        public InvalidFieldException(string Field)
        {
            _FieldID = Field;
        }
    }
}
