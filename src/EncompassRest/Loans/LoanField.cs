using System;
using System.Linq;
using System.Reflection;
using EncompassRest.Utilities;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Loans
{
    public class LoanField
    {
        private readonly ModelPath _modelPath;
        private LoanFieldType? _type;

        internal readonly Loan Loan;

        public string FieldId { get; }

        public string ModelPath => _modelPath.ToString();

        public virtual LoanFieldType Type
        {
            get
            {
                var type = _type;
                if (type == null)
                {
                    var declaredType = _modelPath.GetDeclaredType(TypeData<Loan>.Type);
                    if (declaredType == typeof(string))
                    {
                        type = LoanFieldType.String;
                    }
                    else if (declaredType == typeof(DateTime?))
                    {
                        type = LoanFieldType.DateTime;
                    }
                    else if (declaredType == typeof(decimal?))
                    {
                        type = LoanFieldType.Decimal;
                    }
                    else if (declaredType == typeof(int?))
                    {
                        type = LoanFieldType.Int32;
                    }
                    else if (declaredType == typeof(bool?))
                    {
                        type = LoanFieldType.Boolean;
                    }
                    else
                    {
                        type = LoanFieldType.Unknown;
                        if (declaredType != null)
                        {
                            var typeInfo = declaredType.GetTypeInfo();
                            if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition)
                            {
                                var genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
                                if (genericTypeDefinition == TypeData.OpenStringEnumValueType)
                                {
                                    type = LoanFieldType.String;
                                }
                                else if (genericTypeDefinition == TypeData.OpenNaType)
                                {
                                    type = LoanFieldType.NADecimal;
                                }
                            }
                        }
                    }
                    _type = type;
                }
                return type.GetValueOrDefault();
            }
        }

        public virtual object Value
        {
            get
            {
                var result = _modelPath.GetValue(Loan, out var propertyType);
                if (result is JValue jValue)
                {
                    result = jValue.Value;
                }
                else if (propertyType != null)
                {
                    var propertyTypeInfo = propertyType.GetTypeInfo();
                    if (propertyTypeInfo.IsGenericType && !propertyTypeInfo.IsGenericTypeDefinition)
                    {
                        var genericTypeDefinition = propertyTypeInfo.GetGenericTypeDefinition();
                        if (genericTypeDefinition == TypeData.OpenStringEnumValueType || genericTypeDefinition == TypeData.OpenNaType)
                        {
                            result = result.ToString();
                        }
                    }
                }
                return result;
            }
            set
            {
#pragma warning disable IDE0027 // Use expression body for accessors
                _modelPath.SetValue(Loan, propertyType =>
                {
                    if (propertyType != null)
                    {
                        if (value != null && propertyType == TypeData<bool?>.Type)
                        {
                            if (value is string str)
                            {
                                switch (str.ToUpper())
                                {
                                    case "Y":
                                    case "TRUE":
                                        return true;
                                    case "N":
                                    case "FALSE":
                                        return false;
                                }
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
#pragma warning restore IDE0027 // Use expression body for accessors
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

        internal LoanField(string fieldId, Loan loan, ModelPath modelPath)
        {
            FieldId = fieldId;
            Loan = loan;
            _modelPath = modelPath;
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
                    switch (str.ToUpper())
                    {
                        case "Y":
                        case "TRUE":
                            return true;
                        case "N":
                        case "FALSE":
                            return false;
                    }
                    return null;
                case bool boolean:
                    return boolean;
            }
            return null;
        }
    }
}