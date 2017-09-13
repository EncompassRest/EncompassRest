using System;

namespace EncompassRest.Utilities
{
    internal sealed class EnumOutputAttribute : Attribute
    {
        public EnumOutput EnumOutput { get; }

        public EnumOutputAttribute(EnumOutput enumOutput)
        {
            EnumOutput = enumOutput;
        }
    }
}