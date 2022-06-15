using System;

namespace EncompassRest.Loans.v1;

internal sealed class CustomLoanField : LoanField
{
    public override object? Value
    {
        get
        {
            var customField = Loan.CustomFields.GetById(FieldId);
            if (customField != null)
            {
                if (customField.DateValue.HasValue)
                {
                    return customField.DateValue;
                }
                if (customField.NumericValue.HasValue)
                {
                    return customField.NumericValue;
                }
                return customField.StringValue;
            }
            return null;
        }
        set
        {
            if (value is ILoanField loanField)
            {
                value = loanField.Value;
            }

            var customField = Loan.CustomFields.GetById(FieldId);
            if (customField == null)
            {
                customField = new CustomField { FieldName = FieldId };
                Loan.CustomFields.Add(customField);
            }
            if (customField.DateValue.HasValue || (customField.Properties.TryGetValue(nameof(CustomField.DateValue), out var existing) && existing.Dirty))
            {
                customField.DateValue = value != null ? Convert.ToDateTime(value) : (DateTime?)null;
                customField.StringValue = value?.ToString();
                if (customField.Properties.TryGetValue(nameof(CustomField.StringValue), out var v))
                {
                    v.Dirty = false;
                }
            }
            else if (customField.NumericValue.HasValue || (customField.Properties.TryGetValue(nameof(CustomField.NumericValue), out existing) && existing.Dirty))
            {
                customField.NumericValue = value != null ? Convert.ToDecimal(value) : (decimal?)null;
                customField.StringValue = value != null ? FormattedValue : null;
                if (customField.Properties.TryGetValue(nameof(CustomField.StringValue), out var v))
                {
                    v.Dirty = false;
                }
            }
            else if (customField.StringValue != null || (customField.Properties.TryGetValue(nameof(CustomField.StringValue), out existing) && existing.Dirty))
            {
                customField.StringValue = value?.ToString();
            }
            else
            {
                switch (value)
                {
                    case null:
                        customField.StringValue = null;
                        break;
                    case string str:
                        customField.StringValue = str;
                        break;
                    case DateTime dateTime:
                        customField.DateValue = dateTime;
                        break;
                    default:
                        customField.NumericValue = Convert.ToDecimal(value);
                        break;
                }
            }
        }
    }

    internal CustomLoanField(FieldDescriptor descriptor, Loan loan)
        : base(descriptor, loan)
    {
    }

    public override string? ToString()
    {
        var customField = Loan.CustomFields.GetById(FieldId);
        if (customField != null)
        {
            if (customField.StringValue != null)
            {
                return customField.StringValue;
            }
            if (customField.DateValue.HasValue)
            {
                return customField.DateValue.ToString();
            }
            if (customField.NumericValue.HasValue)
            {
                return customField.NumericValue.ToString();
            }
        }
        return null;
    }
}
