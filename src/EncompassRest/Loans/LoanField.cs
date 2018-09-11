using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Loans
{
    public class LoanField
    {
        internal readonly Loan Loan;
        private readonly ModelPath _modelPath;

        public FieldDescriptor Descriptor { get; }

        public string FieldId => Descriptor.FieldId;

        /// <summary>
        /// For use with loan field locking.
        /// </summary>
        public string ModelPath => _modelPath.ToString();

        /// <summary>
        /// For use with Webhook filter attributes.
        /// </summary>
        public string AttributePath => _modelPath.ToString(name => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(name, false), true).Replace("/currentApplication", "/applications/*");

        [Obsolete("Use Descriptor.MultiInstance instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool MultiInstance => Descriptor.MultiInstance;

        [Obsolete("Use Descriptor.InstanceSpecifier instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string InstanceSpecifier => Descriptor.InstanceSpecifier;

        [Obsolete("Use Descriptor.IsBorrowerPairSpecific instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsBorrowerPairSpecific => Descriptor.IsBorrowerPairSpecific;

        public int? BorrowerPairIndex { get; }

        [Obsolete("Use Descriptor.ValueType instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public LoanFieldValueType ValueType => Descriptor.ValueType;

        [Obsolete("Use Descriptor.Type instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public LoanFieldType Type => Descriptor.Type;

        public LoanFieldFormat? Format => Descriptor.Format;

        public bool ReadOnly => Descriptor.ReadOnly;

        [Obsolete("Use Descriptor.Description instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Description => Descriptor.Description;

        public string UnformattedValue => GetUnformattedValue() ?? string.Empty;

        private string GetUnformattedValue()
        {
            switch (Format)
            {
                case LoanFieldFormat.DECIMAL:
                case LoanFieldFormat.DECIMAL_1:
                case LoanFieldFormat.DECIMAL_2:
                case LoanFieldFormat.DECIMAL_3:
                case LoanFieldFormat.DECIMAL_4:
                case LoanFieldFormat.DECIMAL_5:
                case LoanFieldFormat.DECIMAL_6:
                case LoanFieldFormat.DECIMAL_7:
                case LoanFieldFormat.DECIMAL_10:
                    return ToDecimal()?.ToString();
                case LoanFieldFormat.DATE:
                case LoanFieldFormat.DATETIME:
                    return ToDateTime()?.ToString();
                case LoanFieldFormat.YN:
                    var boolValue = ToBoolean();
                    return boolValue.HasValue ? (boolValue.GetValueOrDefault() ? "Y" : "N") : null;
                case LoanFieldFormat.INTEGER:
                    return ToInt32()?.ToString();
                case LoanFieldFormat.SSN:
                    return ToString()?.Replace("-", string.Empty);
                case LoanFieldFormat.PHONE:
                    return ToString()?.Replace("-", string.Empty).Replace(" ", string.Empty);
                case LoanFieldFormat.ZIPCODE:
                    return ToString()?.Replace("-", string.Empty);
            }
            return ToString();
        }

        public string FormattedValue => GetFormattedValue() ?? string.Empty;

        private string GetFormattedValue()
        {
            string value;
            switch (Format)
            {
                case LoanFieldFormat.DECIMAL_1:
                    return ToDecimal()?.ToString("#,0.0");
                case LoanFieldFormat.DECIMAL_2:
                    return ToDecimal()?.ToString("#,0.00");
                case LoanFieldFormat.DECIMAL_3:
                    return ToDecimal()?.ToString("#,0.000");
                case LoanFieldFormat.DECIMAL_4:
                    return ToDecimal()?.ToString("#,0.0000");
                case LoanFieldFormat.DECIMAL_5:
                    return ToDecimal()?.ToString("#,0.00000");
                case LoanFieldFormat.DECIMAL_6:
                    return ToDecimal()?.ToString("#,0.000000");
                case LoanFieldFormat.DECIMAL_7:
                    return ToDecimal()?.ToString("#,0.0000000");
                case LoanFieldFormat.DECIMAL_10:
                    return ToDecimal()?.ToString("#,0.0000000000");
                case LoanFieldFormat.INTEGER:
                    return ToInt32()?.ToString("#,0");
                case LoanFieldFormat.DATE:
                    return ToDateTime()?.ToString("MM/dd/yyyy");
                case LoanFieldFormat.DATETIME:
                    return ToDateTime()?.ToString();
                case LoanFieldFormat.YN:
                    var boolValue = ToBoolean();
                    return boolValue.HasValue ? (boolValue.GetValueOrDefault() ? "Y" : "N") : null;
                case LoanFieldFormat.SSN:
                    value = ToString();
                    return value?.Length == 9 ? $"{value.Substring(0, 4)}-{value.Substring(4, 2)}-{value.Substring(6)}" : value;
                case LoanFieldFormat.PHONE:
                    value = ToString();
                    return value?.Length >= 7 && value.Cast<char>().All(c => char.IsDigit(c)) ? $"{value.Substring(0, 3)}-{value.Substring(3, 3)}-{value.Substring(6, Math.Min(4, value.Length - 6))}{(value.Length > 10 ? $" {value.Substring(10)}" : string.Empty)}" : value;
                case LoanFieldFormat.ZIPCODE:
                    value = ToString();
                    return value?.Length == 9 ? $"{value.Substring(0, 5)}-{value.Substring(5)}" : value;
            }
            return ToString();
        }

        public virtual object Value
        {
            get
            {
                var result = _modelPath.GetValue(Loan, out _);
                return result is JValue jValue ? jValue.Value : result;
            }
            set
            {
                if (ReadOnly)
                {
                    throw new InvalidOperationException($"cannot set value of field '{FieldId}' as it's read-only");
                }
                _modelPath.SetValue(Loan, propertyType =>
                {
                    if (propertyType != null)
                    {
                        if (value != null && propertyType == TypeData<bool?>.Type && value is string str)
                        {
                            var result = ToBoolean(str);
                            if (result != null)
                            {
                                return result;
                            }
                        }
                        if (value != null && (propertyType == TypeData<string>.Type || propertyType == TypeData<DateTime?>.Type || propertyType == TypeData<decimal?>.Type || propertyType == TypeData<int?>.Type || propertyType == TypeData<bool?>.Type))
                        {
                            return Convert.ChangeType(value, Nullable.GetUnderlyingType(propertyType) ?? propertyType);
                        }
                        else
                        {
                            var propertyTypeContract = JsonHelper.InternalPrivateContractResolver.ResolveContract(propertyType);
                            if (propertyTypeContract.Converter is IStringCreator stringCreator)
                            {
                                return stringCreator.Create(value?.ToString());
                            }
                        }
                    }
                    return value;
                });
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

        public virtual bool Locked
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

        [Obsolete("Use Descriptor.Options instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ReadOnlyCollection<FieldOption> Options => Descriptor.Options;

        internal LoanField(FieldDescriptor descriptor, Loan loan, ModelPath modelPath = null, int? borrowerPairIndex = null)
        {
            Descriptor = descriptor;
            Loan = loan;
            BorrowerPairIndex = borrowerPairIndex;
            _modelPath = modelPath ?? descriptor._modelPath;
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
            }
            return null;
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
            }
            return null;
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
            }
            return null;
        }

        public bool? ToBoolean()
        {
            var value = Value;
            switch (value)
            {
                case string str:
                    return ToBoolean(str);
                case bool boolean:
                    return boolean;
            }
            return null;
        }

        private static bool? ToBoolean(string value)
        {
            switch (value.ToUpper())
            {
                case "Y":
                case "TRUE":
                    return true;
                case "N":
                case "FALSE":
                    return false;
            }
            return null;
        }
    }
}