namespace EncompassRest.Utilities
{
    internal enum EnumOutput
    {
        Integer,
        Name,
        CamelCaseName,
        EnumMemberValue
    }

    internal static class EnumOutputExtensions
    {
        public static EnumFormat GetEnumFormat(this EnumOutput value)
        {
            switch (value)
            {
                case EnumOutput.Name:
                    return EnumFormat.Name;
                case EnumOutput.CamelCaseName:
                    return EnumJsonConverter.CamelCaseNameFormat;
                case EnumOutput.EnumMemberValue:
                    return EnumFormat.EnumMemberValue;
                default:
                    return EnumFormat.DecimalValue;
            }
        }
    }
}