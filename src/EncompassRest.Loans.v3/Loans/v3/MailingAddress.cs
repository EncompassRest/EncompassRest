using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// MailingAddress
/// </summary>
public sealed partial class MailingAddress : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MailingAddress AddressCity [1417], [1520]
    /// </summary>
    public string? AddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress AddressCounty
    /// </summary>
    public string? AddressCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress AddressPostalCode [1419], [1522]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress AddressState [1418], [1521]
    /// </summary>
    public string? AddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress AddressStreetLine1 [1416], [1519]
    /// </summary>
    public string? AddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress AddressUnitDesignatorType [URLA.X7], [URLA.X9]
    /// </summary>
    public StringEnumValue<UnitType> AddressUnitDesignatorType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress AddressUnitIdentifier [URLA.X10], [URLA.X8]
    /// </summary>
    public string? AddressUnitIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress Country [URLA.X269], [URLA.X270]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress CountryCode [URLA.X11], [URLA.X12]
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress ForeignAddressIndicator [URLA.X267], [URLA.X268]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MailingAddress Urla2020StreetAddress [URLA.X197], [URLA.X198]
    /// </summary>
    public string? Urla2020StreetAddress { get => GetValue<string?>(); set => SetValue(value); }
}