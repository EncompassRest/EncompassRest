using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// MailingAddress
/// </summary>
public sealed partial class MailingAddress : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _addressCity;
    private DirtyValue<string?>? _addressCounty;
    private DirtyValue<string?>? _addressPostalCode;
    private DirtyValue<string?>? _addressState;
    private DirtyValue<string?>? _addressStreetLine1;
    private DirtyValue<StringEnumValue<UnitType>>? _addressUnitDesignatorType;
    private DirtyValue<string?>? _addressUnitIdentifier;
    private DirtyValue<string?>? _country;
    private DirtyValue<string?>? _countryCode;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _urla2020StreetAddress;

    /// <summary>
    /// MailingAddressContract AddressCity [1417], [1520]
    /// </summary>
    public string? AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

    /// <summary>
    /// MailingAddressContract AddressCounty
    /// </summary>
    public string? AddressCounty { get => _addressCounty; set => SetField(ref _addressCounty, value); }

    /// <summary>
    /// MailingAddressContract AddressPostalCode [1419], [1522]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

    /// <summary>
    /// MailingAddressContract AddressState [1418], [1521]
    /// </summary>
    public string? AddressState { get => _addressState; set => SetField(ref _addressState, value); }

    /// <summary>
    /// MailingAddressContract AddressStreetLine1 [1416], [1519]
    /// </summary>
    public string? AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }

    /// <summary>
    /// MailingAddressContract AddressUnitDesignatorType [URLA.X7], [URLA.X9]
    /// </summary>
    public StringEnumValue<UnitType> AddressUnitDesignatorType { get => _addressUnitDesignatorType; set => SetField(ref _addressUnitDesignatorType, value); }

    /// <summary>
    /// MailingAddressContract AddressUnitIdentifier [URLA.X10], [URLA.X8]
    /// </summary>
    public string? AddressUnitIdentifier { get => _addressUnitIdentifier; set => SetField(ref _addressUnitIdentifier, value); }

    /// <summary>
    /// MailingAddressContract Country [URLA.X269], [URLA.X270]
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// MailingAddressContract CountryCode [URLA.X11], [URLA.X12]
    /// </summary>
    public string? CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }

    /// <summary>
    /// MailingAddressContract ForeignAddressIndicator [URLA.X267], [URLA.X268]
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// MailingAddressContract Urla2020StreetAddress [URLA.X197], [URLA.X198]
    /// </summary>
    public string? Urla2020StreetAddress { get => _urla2020StreetAddress; set => SetField(ref _urla2020StreetAddress, value); }
}