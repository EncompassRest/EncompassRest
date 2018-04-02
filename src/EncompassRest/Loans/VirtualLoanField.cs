using System;

namespace EncompassRest.Loans
{
    internal sealed class VirtualLoanField : LoanField
    {
        public override object Value
        {
            get => Loan.VirtualFields.TryGetValue(FieldId, out var value) ? value : null;
            set => throw new InvalidOperationException("cannot set value of virtual field");
        }

        public override bool Locked
        {
            get => false;
            set => throw new InvalidOperationException("cannot lock or unlock virtual field");
        }

        public override LoanFieldValueType ValueType => LoanFieldValueType.String;

        public override LoanFieldType Type => LoanFieldType.Virtual;

        internal VirtualLoanField(string fieldId, Loan loan, string instanceSpecifier = null)
            : base(fieldId, loan, LoanFields.CreateModelPath($"Loan.VirtualFields['{fieldId}']"), null, instanceSpecifier)
        {
        }
    }
}