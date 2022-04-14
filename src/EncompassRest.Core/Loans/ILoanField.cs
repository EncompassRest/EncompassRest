using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan field.
    /// </summary>
    public interface ILoanField
    {
        /// <summary>
        /// The field attribute path for use with Webhook filter attributes.
        /// </summary>
        string AttributePath { get; }
        /// <summary>
        /// The field's borrower pair index.
        /// </summary>
        int? BorrowerPairIndex { get; }
        /// <summary>
        /// The field id.
        /// </summary>
        string FieldId { get; }
        /// <summary>
        /// The loan field's format.
        /// </summary>
        LoanFieldFormat? Format { get; }
        /// <summary>
        /// The field's formatted value.
        /// </summary>
        string FormattedValue { get; }
        /// <summary>
        /// Indicates if the field is empty.
        /// </summary>
        bool IsEmpty { get; }
        ///// <summary>
        ///// The field's locked status.
        ///// </summary>
        //bool Locked { get; set; }
        /// <summary>
        /// The field model path for use with loan field locking.
        /// </summary>
        string ModelPath { get; }
        /// <summary>
        /// Indicates if the field is read only.
        /// </summary>
        bool ReadOnly { get; }
        /// <summary>
        /// The field's unformatted value.
        /// </summary>
        string UnformattedValue { get; }
        /// <summary>
        /// The field's value.
        /// </summary>
        object? Value { get; set; }

        /// <summary>
        /// Returns the field's value as a <see cref="bool"/>.
        /// </summary>
        /// <returns></returns>
        bool? ToBoolean();
        /// <summary>
        /// Returns the field's value as a <see cref="DateTime"/>.
        /// </summary>
        /// <returns></returns>
        DateTime? ToDateTime();
        /// <summary>
        /// Returns the field's value as a <see cref="decimal"/>.
        /// </summary>
        /// <returns></returns>
        decimal? ToDecimal();
        /// <summary>
        /// Returns the field's value as an <see cref="int"/>.
        /// </summary>
        /// <returns></returns>
        int? ToInt32();
        /// <summary>
        /// Returns the field's value as a <see cref="string"/>.
        /// </summary>
        /// <returns></returns>
        string? ToString();
    }
}