namespace EncompassRest.Loans.FieldReader
{
    /// <summary>
    /// LoanFieldValue
    /// </summary>
    public sealed class LoanFieldValue : ExtensibleObject
    {
        /// <summary>
        /// Loan field ID.
        /// </summary>
        public string FieldId { get; set; }

        /// <summary>
        /// Value of the field in the loan.
        /// </summary>
        public string Value { get; set; }
    }
}