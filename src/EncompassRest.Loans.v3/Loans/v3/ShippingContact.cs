using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ShippingContact
/// </summary>
public sealed partial class ShippingContact : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _address;
    private DirtyValue<string?>? _address2;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _contactName;
    private DirtyValue<string?>? _email;
    private DirtyValue<string?>? _fax;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _phone;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<StringEnumValue<ShippingContactType>>? _shippingContactType;
    private DirtyValue<string?>? _state;

    /// <summary>
    /// ShippingContactContract Address
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// ShippingContactContract Address2
    /// </summary>
    public string? Address2 { get => _address2; set => SetField(ref _address2, value); }

    /// <summary>
    /// ShippingContactContract City
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// ShippingContactContract ContactName
    /// </summary>
    public string? ContactName { get => _contactName; set => SetField(ref _contactName, value); }

    /// <summary>
    /// ShippingContactContract Email
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// ShippingContactContract Fax
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => _fax; set => SetField(ref _fax, value); }

    /// <summary>
    /// ShippingContactContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// ShippingContactContract Phone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => _phone; set => SetField(ref _phone, value); }

    /// <summary>
    /// ShippingContactContract PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// ShippingContactContract ShippingContactType
    /// </summary>
    public StringEnumValue<ShippingContactType> ShippingContactType { get => _shippingContactType; set => SetField(ref _shippingContactType, value); }

    /// <summary>
    /// ShippingContactContract State
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }
}