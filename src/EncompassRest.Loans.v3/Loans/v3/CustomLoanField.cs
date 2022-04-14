namespace EncompassRest.Loans.v3
{
    internal sealed class CustomLoanField : LoanField
    {
        public override object? Value
        {
            get
            {
                var customField = Loan.CustomFields.GetById(FieldId);
                return customField?.Value;
            }
            set
            {
                if (value is LoanField loanField)
                {
                    value = loanField.Value;
                }

                var customField = Loan.CustomFields.GetById(FieldId);
                if (customField == null)
                {
                    customField = new CustomField { FieldName = FieldId };
                    Loan.CustomFields.Add(customField);
                }
                customField.Value = value;
            }
        }

        internal CustomLoanField(FieldDescriptor descriptor, Loan loan)
            : base(descriptor, loan)
        {
        }

        public override string? ToString()
        {
            var customField = Loan.CustomFields.GetById(FieldId);
            return customField?.Value?.ToString();
        }
    }
}