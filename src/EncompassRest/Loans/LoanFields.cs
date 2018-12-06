using System;
using System.ComponentModel;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan fields collection.
    /// </summary>
    public sealed class LoanFields
    {
        [Obsolete("Use LoanFieldDescriptors.FieldMappings instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static LoanFieldMappings FieldMappings => LoanFieldDescriptors.FieldMappings;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [Obsolete("Use LoanFieldDescriptors.FieldPatternMappings instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static LoanFieldPatternMappings FieldPatternMappings => LoanFieldDescriptors.FieldPatternMappings;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private readonly Loan _loan;

        /// <summary>
        /// Gets the loan field with the specified <paramref name="fieldId"/>.
        /// </summary>
        /// <param name="fieldId">The field id of the loan field to get. Borrower pair specified fields are supported, e.g. "4000#2".</param>
        /// <returns></returns>
        public LoanField this[string fieldId]
        {
            get
            {
                Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

                FieldDescriptor descriptor;
                int? borrowerPairIndex = null;
                ModelPath modelPath = null;
                if (fieldId.Length > 2 && fieldId[fieldId.Length - 2] == '#')
                {
                    borrowerPairIndex = fieldId[fieldId.Length - 1] - '1';
                    if (borrowerPairIndex < 0 || borrowerPairIndex > 5)
                    {
                        throw new ArgumentException($"Could not find field '{fieldId}'");
                    }

                    var strippedFieldId = fieldId.Substring(0, fieldId.Length - 2);

                    descriptor = LoanFieldDescriptors.GetFieldDescriptor(strippedFieldId, _loan.Client?.Loans.FieldDescriptors.CustomFields);
                    
                    if (!descriptor.IsBorrowerPairSpecific)
                    {
                        throw new ArgumentException($"Could not find field '{fieldId}'");
                    }

                    modelPath = LoanFieldDescriptors.CreateModelPath($"Loan.Applications[(ApplicationIndex == '{borrowerPairIndex}')]{descriptor.ModelPath.Substring(23)}");
                }
                else
                {
                    descriptor = LoanFieldDescriptors.GetFieldDescriptor(fieldId, _loan.Client?.Loans.FieldDescriptors.CustomFields);
                }

                switch (descriptor.Type)
                {
                    case LoanFieldType.Custom:
                        return new CustomLoanField(descriptor, _loan);
                    case LoanFieldType.Virtual:
                        return new VirtualLoanField(descriptor, _loan);
                    default:
                        return new LoanField(descriptor, _loan, modelPath, borrowerPairIndex);
                }
            }
        }

        internal LoanFields(Loan loan)
        {
            _loan = loan;
        }
    }
}