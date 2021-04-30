using System;

namespace EncompassRest
{
    internal sealed class IdPropertyNameAttribute : Attribute
    {
        public string IdPropertyName { get; }

        public IdPropertyNameAttribute(string idPropertyName)
        {
            IdPropertyName = idPropertyName;
        }
    }
}