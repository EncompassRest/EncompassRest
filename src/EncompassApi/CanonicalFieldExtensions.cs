using EncompassApi.Extensions;

namespace EncompassApi
{
    /// <summary>
    /// Extensions for canonical fields.
    /// </summary>
    public static class CanonicalFieldExtensions
    {
        /// <summary>
        /// Gets the canonical name of the field.
        /// </summary>
        /// <param name="value">The canonical loan field.</param>
        /// <returns></returns>
        public static string GetCanonicalName(this CanonicalLoanField value) => $"Loan.{value.GetValue()}";

        /// <summary>
        /// Returns if the field is a date field.
        /// </summary>
        /// <param name="value">The canonical loan field.</param>
        /// <returns></returns>
        public static bool IsDateValued(this CanonicalLoanField value) => value >= 0 && (int)value < 100;

        /// <summary>
        /// Returns if the field is a numeric field.
        /// </summary>
        /// <param name="value">The canonical loan field.</param>
        /// <returns></returns>
        public static bool IsNumeric(this CanonicalLoanField value) => (int)value >= 100 && (int)value < 200;

        /// <summary>
        /// Returns if the field is a string field.
        /// </summary>
        /// <param name="value">The canonical loan field.</param>
        /// <returns></returns>
        public static bool IsStringValued(this CanonicalLoanField value) => (int)value >= 200;

        /// <summary>
        /// Gets the canonical name of the field.
        /// </summary>
        /// <param name="value">The canonical contact field.</param>
        /// <returns></returns>
        public static string GetCanonicalName(this CanonicalContactField value) => $"Contact.{value.GetValue()}";

        /// <summary>
        /// Returns if the field is a date field.
        /// </summary>
        /// <param name="value">The canonical contact field.</param>
        /// <returns></returns>
        public static bool IsDateValued(this CanonicalContactField value) => value >= 0 && (int)value < 100;

        /// <summary>
        /// Returns if the field is a numeric field.
        /// </summary>
        /// <param name="value">The canonical contact field.</param>
        /// <returns></returns>
        public static bool IsNumeric(this CanonicalContactField value) => (int)value >= 100 && (int)value < 200;

        /// <summary>
        /// Returns if the field is a string field.
        /// </summary>
        /// <param name="value">The canonical contact field.</param>
        /// <returns></returns>
        public static bool IsStringValued(this CanonicalContactField value) => (int)value >= 200;
    }
}