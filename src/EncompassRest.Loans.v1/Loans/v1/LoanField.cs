using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1;

/// <summary>
/// The loan field.
/// </summary>
public class LoanField : LoanFieldBase
{
    internal new Loan Loan => (Loan)base.Loan;

    /// <inheritdoc cref="ILoanField.Descriptor"/>
    public new FieldDescriptor Descriptor => (FieldDescriptor)base.Descriptor;

    /// <inheritdoc/>
    public string AttributePath => _modelPath.ToString(name => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(name, false), true).Replace("/currentApplication", "/applications/*");

    /// <inheritdoc/>
    public new virtual bool Locked
    {
        get
        {
            var fieldLockData = Loan.FieldLockData.GetById(ModelPath);
            return fieldLockData != null && fieldLockData.LockRemoved != true;
        }
        set
        {
            var allFieldLockData = Loan.FieldLockData;
            var modelPath = ModelPath;
            var fieldLockData = allFieldLockData.GetById(modelPath);
            if (fieldLockData == null)
            {
                fieldLockData = new FieldLockData { ModelPath = modelPath };
                allFieldLockData.Add(fieldLockData);
            }
            fieldLockData.LockRemoved = !value;
        }
    }

    internal override bool LockedInternal => Locked;

    internal LoanField(FieldDescriptor descriptor, Loan loan, ModelPath? modelPath = null, int? borrowerPairIndex = null)
        : base(descriptor, loan, modelPath, borrowerPairIndex)
    {
    }
}