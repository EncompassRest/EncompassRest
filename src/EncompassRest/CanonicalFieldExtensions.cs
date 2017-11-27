using EnumsNET;

namespace EncompassRest
{
    public static class CanonicalFieldExtensions
    {
        public static string GetCanonicalName(this LoanCanonicalField value) => $"Loan.{value.GetName()}";

        public static bool IsDateValued(this LoanCanonicalField value) => value >= 0 && (int)value < 100;

        public static bool IsNumeric(this LoanCanonicalField value) => (int)value >= 100 && (int)value < 200;

        public static bool IsStringValued(this LoanCanonicalField value) => (int)value >= 200;
    }
}