namespace EncompassRest.Loans.v3
{
    internal sealed class VirtualLoanField : LoanField
    {
        //public override object? Value
        //{
        //    get => Loan.VirtualFields.TryGetValue(FieldId, out var value) ? value : null;
        //    set
        //    {
        //        if (!Loan.Fields.AllowWritesToReadOnlyFieldsLocally)
        //        {
        //            throw new InvalidOperationException($"cannot set value of field '{FieldId}' as it's virtual");
        //        }
        //        Loan.VirtualFields[FieldId] = value?.ToString();
        //    }
        //}

        internal override bool LockedInternal => false;

        internal VirtualLoanField(FieldDescriptor descriptor, Loan loan)
            : base(descriptor, loan)
        {
        }
    }
}