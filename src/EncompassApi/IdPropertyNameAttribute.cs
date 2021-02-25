using System;

namespace EncompassApi
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