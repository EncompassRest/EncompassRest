using System;

namespace EncompassApi.Loans
{
    internal sealed class VirtualLoanField : LoanField
    {
        public override object? Value
        {
            get => Loan.VirtualFields.TryGetValue(FieldId, out var value) ? value : null;
            set
            {
                if (!Loan.Fields.AllowWritesToReadOnlyFieldsLocally)
                {
                    throw new InvalidOperationException($"cannot set value of field '{FieldId}' as it's virtual");
                }
                Loan.VirtualFields[FieldId] = value?.ToString();
            }
        }

        public override bool Locked
        {
            get => false;
            set => throw new InvalidOperationException($"cannot lock/unlock field '{FieldId}' as it's virtual");
        }

        internal VirtualLoanField(FieldDescriptor descriptor, Loan loan)
            : base(descriptor, loan)
        {
        }
    }
}