using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;
using EnumsNET.NonGeneric;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Loans
{
    public class LoanField
    {
        private readonly ModelPath _modelPath;
        private LoanFieldValueType? _valueType;
        private int? _borrowerPairIndex;
        private bool _propertyAttributeIsSet;
        private LoanFieldPropertyAttribute _propertyAttribute;
        private ReadOnlyCollection<FieldOption> _options;
        private bool _loanEntitySet;
        private LoanEntity? _loanEntity;

        internal readonly Loan Loan;

        public string FieldId { get; }

        public string ModelPath => _modelPath.ToString();

        public bool MultiInstance => InstanceSpecifier != null;

        public string InstanceSpecifier { get; }

        public bool IsBorrowerPairSpecific => BorrowerPairIndex.HasValue;

        public int? BorrowerPairIndex => _borrowerPairIndex < 0 ? Loan.CurrentApplicationIndex : _borrowerPairIndex;

        public virtual LoanFieldValueType ValueType
        {
            get
            {
                var valueType = _valueType;
                if (valueType == null)
                {
                    var declaredType = _modelPath.GetDeclaredType(TypeData<Loan>.Type);
                    if (declaredType == typeof(string))
                    {
                        valueType = LoanFieldValueType.String;
                    }
                    else if (declaredType == typeof(DateTime?))
                    {
                        valueType = LoanFieldValueType.DateTime;
                    }
                    else if (declaredType == typeof(decimal?))
                    {
                        valueType = LoanFieldValueType.Decimal;
                    }
                    else if (declaredType == typeof(int?))
                    {
                        valueType = LoanFieldValueType.Int32;
                    }
                    else if (declaredType == typeof(bool?))
                    {
                        valueType = LoanFieldValueType.Boolean;
                    }
                    else
                    {
                        valueType = LoanFieldValueType.Unknown;
                        if (declaredType != null)
                        {
                            var typeInfo = declaredType.GetTypeInfo();
                            if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition)
                            {
                                var genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
                                if (genericTypeDefinition == TypeData.OpenStringEnumValueType)
                                {
                                    valueType = LoanFieldValueType.String;
                                }
                                else if (genericTypeDefinition == TypeData.OpenNaType)
                                {
                                    valueType = LoanFieldValueType.NADecimal;
                                }
                            }
                        }
                    }
                    _valueType = valueType;
                }
                return valueType.GetValueOrDefault();
            }
        }

        public virtual LoanFieldType Type => LoanFieldType.Standard;

        public LoanFieldFormat? Format => PropertyAttribute?._format;

        public bool ReadOnly => PropertyAttribute?.ReadOnly == true;

        public string Description => PropertyAttribute?.Description;

        public string UnformattedValue => GetUnformattedValue() ?? string.Empty;

        private string GetUnformattedValue()
        {
            string value;
            switch (Format)
            {
                case LoanFieldFormat.DECIMAL_1:
                case LoanFieldFormat.DECIMAL_2:
                case LoanFieldFormat.DECIMAL_3:
                case LoanFieldFormat.DECIMAL_4:
                case LoanFieldFormat.DECIMAL_5:
                case LoanFieldFormat.DECIMAL_6:
                case LoanFieldFormat.DECIMAL_7:
                case LoanFieldFormat.DECIMAL_10:
                    return ToDecimal()?.ToString();
                case LoanFieldFormat.SSN:
                    value = Value?.ToString();
                    return value?.Replace("-", string.Empty);
                case LoanFieldFormat.PHONE:
                    value = Value?.ToString();
                    return value?.Replace("-", string.Empty).Replace(" ", string.Empty);
                case LoanFieldFormat.ZIPCODE:
                    value = Value?.ToString();
                    return value?.Replace("-", string.Empty);
            }
            return Value?.ToString();
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
                case LoanFieldFormat.SSN:
                    value = Value?.ToString();
                    return value?.Length == 9 ? $"{value.Substring(0, 4)}-{value.Substring(4, 2)}-{value.Substring(6)}" : value;
                case LoanFieldFormat.PHONE:
                    value = Value?.ToString();
                    return value?.Length >= 7 && value.Cast<char>().All(c => char.IsDigit(c)) ? $"{value.Substring(0, 3)}-{value.Substring(3, 3)}-{value.Substring(6, Math.Min(4, value.Length - 6))}{(value.Length > 10 ? $" {value.Substring(10)}" : string.Empty)}" : value;
                case LoanFieldFormat.ZIPCODE:
                    value = Value?.ToString();
                    return value?.Length == 9 ? $"{value.Substring(0, 5)}-{value.Substring(5)}" : value;
            }
            return Value?.ToString();
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
                var fieldLockData = Loan.FieldLockData.FirstOrDefault(f => _modelPath.Equals(f._modelPathInternal));
                return fieldLockData != null && fieldLockData.LockRemoved != true;
            }
            set
            {
                var allFieldLockData = Loan.FieldLockData;
                var fieldLockData = allFieldLockData.FirstOrDefault(f => _modelPath.Equals(f._modelPathInternal));
                if (fieldLockData == null)
                {
                    fieldLockData = new FieldLockData { _modelPathInternal = _modelPath, _modelPath = ModelPath };
                    allFieldLockData.Add(fieldLockData);
                }
                fieldLockData.LockRemoved = !value;
            }
        }

        public ReadOnlyCollection<FieldOption> Options
        {
            get
            {
                var options = _options;
                if (options == null)
                {
                    var dictionary = new Dictionary<string, string>();
                    var declaredType = _modelPath.GetDeclaredType(TypeData<Loan>.Type);
                    if (declaredType != null)
                    {
                        if (declaredType == TypeData<bool?>.Type)
                        {
                            dictionary.Add("true", "Yes");
                            dictionary.Add("false", "No");
                        }
                        else
                        {
                            var typeInfo = declaredType.GetTypeInfo();
                            if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition)
                            {
                                var genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
                                if (genericTypeDefinition == TypeData.OpenStringEnumValueType)
                                {
                                    var enumType = typeInfo.GenericTypeArguments[0];
                                    foreach (var member in NonGenericEnums.GetMembers(enumType))
                                    {
                                        var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
                                        if (!dictionary.ContainsKey(value))
                                        {
                                            dictionary.Add(value, member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var propertyOptions = PropertyAttribute?.Options;
                    if (propertyOptions != null)
                    {
                        foreach (var pair in propertyOptions)
                        {
                            dictionary[pair.Key] = pair.Value;
                        }
                    }
                    var missingOptions = PropertyAttribute?.MissingOptions;
                    if (missingOptions != null)
                    {
                        foreach (var missingOption in missingOptions)
                        {
                            dictionary.Remove(missingOption);
                        }
                    }
                    
                    options = new ReadOnlyCollection<FieldOption>(dictionary.Select(p => new FieldOption { Value = p.Key, Text = p.Value }).ToList());
                    _options = options;
                }
                return options;
            }
        }

        public virtual LoanEntity? LoanEntity
        {
            get
            {
                if (_loanEntitySet)
                {
                    return _loanEntity;
                }
                else
                {
                    var loanEntity = (LoanEntity?)null;
                    if (_modelPath.Segments.Count == 1)
                    {
                        loanEntity = EncompassRest.Loans.LoanEntity.Loan;
                    }
                    else
                    {
                        var finalSegmentIndex = _modelPath.Segments.Count - 2;

                        var declaredType = TypeData<Loan>.Type;
                        for (var i = 0; i <= finalSegmentIndex && declaredType != null; ++i)
                        {
                            declaredType = _modelPath.Segments[i].GetDeclaredType(declaredType);
                        }
                        if (declaredType != null && EnumsNET.Enums.TryParse<LoanEntity>(declaredType.Name, out var newLoanEntity, EnumFormat.Name))
                        {
                            loanEntity = newLoanEntity;
                        }
                    }
                    
                    _loanEntity = loanEntity;
                    _loanEntitySet = true;
                    return loanEntity;
                }
            }
        }

        internal LoanFieldPropertyAttribute PropertyAttribute
        {
            get
            {
                if (!_propertyAttributeIsSet)
                {
                    _propertyAttribute = _modelPath.GetAttribute<LoanFieldPropertyAttribute>(TypeData<Loan>.Type);
                    _propertyAttributeIsSet = true;
                }
                return _propertyAttribute;
            }
        }

        internal LoanField(string fieldId, Loan loan, ModelPath modelPath, int? borrowerPairIndex = null, string instanceSpecifier = null)
        {
            FieldId = fieldId;
            Loan = loan;
            _modelPath = modelPath;
            _borrowerPairIndex = borrowerPairIndex;
            InstanceSpecifier = instanceSpecifier;
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