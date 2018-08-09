using System;
using System.Linq;

namespace EncompassRest.Loans
{
    internal sealed class CustomLoanField : LoanField
    {
        public override object Value
        {
            get
            {
                var customField = GetCustomField();
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
                var customField = GetCustomField();
                if (customField == null)
                {
                    customField = new CustomField { FieldName = FieldId };
                    Loan.CustomFields.Add(customField);
                }
                if (customField.DateValue.HasValue || customField._dateValue?.Dirty == true)
                {
                    customField.DateValue = value != null ? Convert.ToDateTime(value) : (DateTime?)null;
                    customField.StringValue = value?.ToString();
                    customField._stringValue.Dirty = false;
                }
                else if (customField.NumericValue.HasValue || customField._numericValue?.Dirty == true)
                {
                    customField.NumericValue = value != null ? Convert.ToDecimal(value) : (decimal?)null;
                    customField.StringValue = value != null ? FormattedValue : null;
                    customField._stringValue.Dirty = false;
                }
                else if (customField.StringValue != null || customField._stringValue?.Dirty == true)
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

        public override string ToString()
        {
            var customField = GetCustomField();
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

        private CustomField GetCustomField() => Loan.CustomFields.FirstOrDefault(f => string.Equals(FieldId, f.FieldName, StringComparison.OrdinalIgnoreCase));
    }
}