using System;
using EncompassApi.Utilities;

namespace EncompassApi.Loans
{
    /// <summary>
    /// The loan fields collection.
    /// </summary>
    public sealed class LoanFields
    {
        private readonly Loan _loan;

        /// <summary>
        /// Allows writing to read-only fields for local purposes such as unit tests. Sending an update request to Encompass with
        /// a read-only field's value being set is likely to produce an error.
        /// </summary>
        public bool AllowWritesToReadOnlyFieldsLocally { get; set; }

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
                ModelPath? modelPath = null;
                if (fieldId.Length > 2 && fieldId[fieldId.Length - 2] == '#')
                {
                    borrowerPairIndex = fieldId[fieldId.Length - 1] - '1';
                    if (borrowerPairIndex < 0 || borrowerPairIndex > 5)
                    {
                        throw new ArgumentException($"Could not find field '{fieldId}'");
                    }

                    var strippedFieldId = fieldId.Substring(0, fieldId.Length - 2);

                    descriptor = LoanFieldDescriptors.GetFieldDescriptor(strippedFieldId, _loan.Client?.Loans.FieldDescriptors.CustomFields, UndefinedCustomFieldHandling.Default);
                    
                    if (!descriptor.IsBorrowerPairSpecific)
                    {
                        throw new ArgumentException($"Could not find field '{fieldId}'");
                    }

                    modelPath = LoanFieldDescriptors.CreateModelPath($"Loan.Applications[(ApplicationIndex == '{borrowerPairIndex}')]{descriptor.ModelPath.Substring(23)}");
                }
                else
                {
                    descriptor = LoanFieldDescriptors.GetFieldDescriptor(fieldId, _loan.Client?.Loans.FieldDescriptors.CustomFields, _loan.Client?.UndefinedCustomFieldHandling ?? UndefinedCustomFieldHandling.Default);
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