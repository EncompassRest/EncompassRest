using System;
using System.Linq;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Loans.v3;

/// <summary>
/// The loan field.
/// </summary>
public class LoanField : ILoanField
{
    internal readonly Loan Loan;
    private readonly ModelPath _modelPath;

    /// <summary>
    /// The field descriptor.
    /// </summary>
    public FieldDescriptor Descriptor { get; }

    /// <inheritdoc/>
    public string FieldId => Descriptor.FieldId;

    /// <inheritdoc/>
    public string ModelPath => _modelPath.ToString();

    /// <inheritdoc/>
    public string AttributePath => _modelPath.ToString(name => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(name, false), true).Replace("/currentApplication", "/applications/*");

    /// <inheritdoc/>
    public int? BorrowerPairIndex { get; }

    /// <inheritdoc/>
    public LoanFieldFormat? Format => Descriptor.Format;

    /// <inheritdoc/>
    public bool ReadOnly => Descriptor.ReadOnly;

    /// <inheritdoc/>
    public string UnformattedValue => GetUnformattedValue() ?? string.Empty;

    private string? GetUnformattedValue()
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

    /// <inheritdoc/>
    public string FormattedValue => GetFormattedValue() ?? string.Empty;

    private string? GetFormattedValue()
    {
        string? value;
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

    /// <inheritdoc/>
    public virtual object? Value
    {
        get
        {
            var result = _modelPath.GetValue(Loan, out _);
            return result is JValue jValue ? jValue.Value : result;
        }
        set
        {
            if (!Loan.Fields.AllowWritesToReadOnlyFieldsLocally && ReadOnly)
            {
                throw new InvalidOperationException($"cannot set value of field '{FieldId}' as it's read-only");
            }

            if (value is LoanField loanField)
            {
                value = loanField.Value;
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
                        var i = 0;
                        var options = Descriptor.Options;
                        for (; i < options.Count; ++i)
                        {
                            if (options[i].Value.Equals(str, StringComparison.OrdinalIgnoreCase))
                            {
                                break;
                            }
                        }
                        if (i == 0)
                        {
                            return true;
                        }
                        if (i == 1 && options.Count > 1)
                        {
                            return false;
                        }
                        return null;
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

    /// <inheritdoc/>
    public bool IsEmpty
    {
        get
        {
            var value = Value;
            return value == null || (value is string str && str.Length == 0);
        }
    }

    ///// <inheritdoc/>
    //public virtual bool Locked
    //{
    //    get
    //    {
    //        var fieldLockData = Loan.FieldLockData.GetById(ModelPath);
    //        return fieldLockData != null && fieldLockData.LockRemoved != true;
    //    }
    //    set
    //    {
    //        var allFieldLockData = Loan.FieldLockData;
    //        var modelPath = ModelPath;
    //        var fieldLockData = allFieldLockData.GetById(modelPath);
    //        if (fieldLockData == null)
    //        {
    //            fieldLockData = new FieldLockData { ModelPath = modelPath };
    //            allFieldLockData.Add(fieldLockData);
    //        }
    //        fieldLockData.LockRemoved = !value;
    //    }
    //}

    internal LoanField(FieldDescriptor descriptor, Loan loan, ModelPath? modelPath = null, int? borrowerPairIndex = null)
    {
        Descriptor = descriptor;
        Loan = loan;
        BorrowerPairIndex = borrowerPairIndex;
        _modelPath = modelPath ?? descriptor._modelPath;
    }

    /// <summary>
    /// Returns the field's value as a <see cref="string"/>.
    /// </summary>
    /// <returns></returns>
    public override string? ToString()
    {
        if (Descriptor.ValueType == LoanFieldValueType.Boolean && Descriptor.Options.Count > 0)
        {
            var value = ToBoolean();
            if (value == true)
            {
                return Descriptor.Options[0].Value;
            }
            if (value == false && Descriptor.Options.Count > 1)
            {
                return Descriptor.Options[1].Value;
            }
            return null;
        }
        return Value?.ToString();
    }

    /// <inheritdoc/>
    public DateTime? ToDateTime() => Value switch
    {
        DateTime dateTime => dateTime,
        string str => DateTime.TryParse(str, out var dt) ? dt : null,
        _ => null,
    };

    /// <inheritdoc/>
    public decimal? ToDecimal() => Value switch
    {
        string str => decimal.TryParse(str, out var n) ? n : null,
        decimal d => d,
        int i => i,
        _ => null,
    };

    /// <inheritdoc/>
    public int? ToInt32() => Value switch
    {
        string str => int.TryParse(str, out var n) ? n : null,
        decimal d => d <= int.MaxValue && d >= int.MinValue ? Convert.ToInt32(d) : null,
        int i => i,
        _ => null,
    };

    /// <inheritdoc/>
    public bool? ToBoolean() => Value switch
    {
        string str => ToBoolean(str),
        bool boolean => boolean,
        _ => null,
    };

    private static bool? ToBoolean(string value) => value.ToUpper() switch
    {
        "Y" or "YES" or "TRUE" => true,
        "N" or "NO" or "FALSE" => false,
        _ => null,
    };
}
