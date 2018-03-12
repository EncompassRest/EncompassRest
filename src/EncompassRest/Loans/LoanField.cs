using System;
using System.Linq;
using System.Reflection;
using EncompassRest.Utilities;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Loans
{
    internal sealed class CustomLoanField : LoanField
    {
        public override object Value
        {
            get
            {
                var customField = Loan.CustomFields.FirstOrDefault(f => string.Equals(FieldId, f.FieldName, StringComparison.OrdinalIgnoreCase));
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
                var customFields = Loan.CustomFields;
                var customField = customFields.FirstOrDefault(f => string.Equals(FieldId, f.FieldName, StringComparison.OrdinalIgnoreCase));
                if (customField == null)
                {
                    customField = new CustomField { FieldName = FieldId };
                    customFields.Add(customField);
                }
                if (customField.DateValue.HasValue)
                {
                    customField.DateValue = value != null ? Convert.ToDateTime(value) : (DateTime?)null;
                }
                else if (customField.NumericValue.HasValue)
                {
                    customField.NumericValue = value != null ? Convert.ToDecimal(value) : (decimal?)null;
                }
                else if (customField.StringValue != null)
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

        internal CustomLoanField(string fieldId, Loan loan)
            : base(fieldId, loan, $"Loan.CustomFields[(FieldName == '{fieldId}')].StringValue")
        {
        }
    }

    public class LoanField
    {
        private readonly JsonProperty _modelProperty;
        private readonly object _target;

        protected readonly Loan Loan;

        public string FieldId { get; }

        public virtual string ModelPath { get; }

        public virtual object Value
        {
            get
            {
                var result = _modelProperty.ValueProvider.GetValue(_target);
                var propertyTypeInfo = _modelProperty.PropertyType.GetTypeInfo();
                if (propertyTypeInfo.IsGenericType && !propertyTypeInfo.IsGenericTypeDefinition)
                {
                    var genericTypeDefinition = propertyTypeInfo.GetGenericTypeDefinition();
                    if (genericTypeDefinition == TypeData.OpenStringEnumValueType || genericTypeDefinition == TypeData.OpenNaType)
                    {
                        result = result.ToString();
                    }
                }
                return result;
            }
            set
            {
                var destinationValue = value;
                var propertyType = _modelProperty.PropertyType;
                if (value != null && (propertyType == TypeData<string>.Type || propertyType == TypeData<DateTime?>.Type || propertyType == TypeData<decimal?>.Type || propertyType == TypeData<int?>.Type || propertyType == TypeData<bool?>.Type))
                {
                    destinationValue = Convert.ChangeType(value, Nullable.GetUnderlyingType(propertyType) ?? propertyType);
                }
                else
                {
                    var propertyTypeContract = JsonHelper.InternalPrivateContractResolver.ResolveContract(propertyType);
                    if (propertyTypeContract.Converter is IStringCreator stringCreator)
                    {
                        destinationValue = stringCreator.Create(value?.ToString());
                    }
                }
                _modelProperty.ValueProvider.SetValue(_target, destinationValue);
            }
        }

        public bool IsEmpty
        {
            get
            {
                var value = Value;
                return value == null || (value is string str && str.Length == 0);
            }
        }

        public bool Locked
        {
            get
            {
                var fieldLockData = Loan.FieldLockData.FirstOrDefault(f => string.Equals(f.ModelPath, ModelPath, StringComparison.OrdinalIgnoreCase));
                return fieldLockData != null && fieldLockData.LockRemoved != true;
            }
            set
            {
                var allFieldLockData = Loan.FieldLockData;
                var fieldLockData = allFieldLockData.FirstOrDefault(f => string.Equals(f.ModelPath, ModelPath, StringComparison.OrdinalIgnoreCase));
                if (fieldLockData == null)
                {
                    fieldLockData = new FieldLockData { ModelPath = ModelPath };
                    allFieldLockData.Add(fieldLockData);
                }
                fieldLockData.LockRemoved = !value;
            }
        }

        internal LoanField(string fieldId, Loan loan, string modelPath, JsonProperty modelProperty = null, object target = null)
        {
            Loan = loan;
            FieldId = fieldId;
            ModelPath = modelPath;
            _modelProperty = modelProperty;
            _target = target;
        }

        public override string ToString() => Value?.ToString();

        public DateTime? ToDateTime()
        {
            var value = Value;
            switch (value)
            {
                case DateTime dateTime:
                    return dateTime;
                case string str:
                    return DateTime.TryParse(str, out var dt) ? dt : (DateTime?)null;
                default:
                    return null;
            }
        }

        public decimal? ToDecimal()
        {
            var value = Value;
            switch (value)
            {
                case string str:
                    return decimal.TryParse(str, out var n) ? n : (decimal?)null;
                case decimal d:
                    return d;
                case int i:
                    return i;
                default:
                    return null;
            }
        }

        public int? ToInt32()
        {
            var value = Value;
            switch (value)
            {
                case string str:
                    return int.TryParse(str, out var n) ? n : (int?)null;
                case decimal d:
                    return d <= int.MaxValue && d >= int.MinValue ? Convert.ToInt32(d) : (int?)null;
                case int i:
                    return i;
                default:
                    return null;
            }
        }

        public bool? ToBoolean()
        {
            var value = Value;
            switch (value)
            {
                case string str:
                    return bool.TryParse(str, out var b) ? b : (bool?)null;
                case bool boolean:
                    return boolean;
                default:
                    return null;
            }
        }
    }
}