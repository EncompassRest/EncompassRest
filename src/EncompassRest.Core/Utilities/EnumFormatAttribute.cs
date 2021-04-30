using System;
using EnumsNET;

namespace EncompassRest.Utilities
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class EnumFormatAttribute : Attribute
    {
        public EnumFormat EnumFormat { get; }

        public EnumFormatAttribute(EnumFormat enumFormat)
        {
            EnumFormat = enumFormat;
        }
    }
}