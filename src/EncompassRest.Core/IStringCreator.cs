using System;

namespace EncompassRest
{
    internal interface IStringCreator
    {
        object Create(Type type, string? value);
    }
}