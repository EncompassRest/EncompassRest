using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ShippingContact
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ShippingContactType))]
public sealed partial class ShippingContact : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ShippingContact Address
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact Address2
    /// </summary>
    public string? Address2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact City
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact ContactName
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact Fax
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact Phone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact ShippingContactType
    /// </summary>
    public StringEnumValue<ShippingContactType> ShippingContactType { get => GetValue<StringEnumValue<ShippingContactType>>(); set => SetValue(value); }

    /// <summary>
    /// ShippingContact State
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }
}