namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan fields collection.
    /// </summary>
    public interface ILoanFields
    {
        /// <summary>
        /// Gets the loan field with the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="fieldId">The field id of the loan field to get. Borrower pair specified fields are supported, e.g. "4000#2".</param>
        /// <returns></returns>
        ILoanField this[string fieldId] { get; }

        /// <summary>
        /// Allows writing to read-only fields for local purposes such as unit tests. Sending an update request to Encompass with
        /// a read-only field's value being set is likely to produce an error.
        /// </summary>
        bool AllowWritesToReadOnlyFieldsLocally { get; set; }
    }
}