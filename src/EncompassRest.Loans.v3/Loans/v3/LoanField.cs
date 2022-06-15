using System.Linq;

namespace EncompassRest.Loans.v3;

/// <summary>
/// The loan field.
/// </summary>
public class LoanField : LoanFieldBase
{
    internal new Loan Loan => (Loan)base.Loan;

    /// <inheritdoc cref="ILoanField.Descriptor"/>
    public new FieldDescriptor Descriptor => (FieldDescriptor)base.Descriptor;

    internal override bool LockedInternal => Loan.FieldLockData.Any(m => !string.IsNullOrEmpty(m) && _modelPath.Equals(LoanFieldDescriptors.CreateModelPath(m)));

    internal LoanField(FieldDescriptor descriptor, Loan loan, ModelPath? modelPath = null, int? borrowerPairIndex = null)
        : base(descriptor, loan, modelPath, borrowerPairIndex)
    {
    }
}
