using System;

namespace EncompassRest.Utilities
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class EnumOutputAttribute : Attribute
    {
        public EnumOutput EnumOutput { get; }

        public EnumOutputAttribute(EnumOutput enumOutput)
        {
            EnumOutput = enumOutput;
        }
    }
}