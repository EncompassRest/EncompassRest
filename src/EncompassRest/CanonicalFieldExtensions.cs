using EnumsNET;

namespace EncompassRest
{
    public static class CanonicalFieldExtensions
    {
        public static string GetCanonicalName(this CanonicalLoanField value) => $"Loan.{value.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)}";

        public static bool IsDateValued(this CanonicalLoanField value) => value >= 0 && (int)value < 100;

        public static bool IsNumeric(this CanonicalLoanField value) => (int)value >= 100 && (int)value < 200;

        public static bool IsStringValued(this CanonicalLoanField value) => (int)value >= 200;

        public static string GetCanonicalName(this CanonicalContactField value) => $"Contact.{value.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)}";

        public static bool IsDateValued(this CanonicalContactField value) => value >= 0 && (int)value < 100;

        public static bool IsNumeric(this CanonicalContactField value) => (int)value >= 100 && (int)value < 200;

        public static bool IsStringValued(this CanonicalContactField value) => (int)value >= 200;
    }
}