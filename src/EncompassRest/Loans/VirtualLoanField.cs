using System;

namespace EncompassRest.Loans
{
    internal sealed class VirtualLoanField : LoanField
    {
        public override object? Value
        {
            get => Loan.VirtualFields.TryGetValue(FieldId, out var value) ? value : null;
            set => throw new InvalidOperationException($"cannot set value of field '{FieldId}' as it's virtual");
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