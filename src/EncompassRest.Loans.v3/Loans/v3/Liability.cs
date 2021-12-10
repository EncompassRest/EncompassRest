using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Liability
/// </summary>
public sealed partial class Liability : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountIdentifier;
    private DirtyValue<string?>? _country;
    private DirtyValue<string?>? _description;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<StringEnumValue<AltLiabilityType>>? _liabilityType;
    private DirtyValue<int?>? _liabilityTypeIndex;
    private DirtyValue<decimal?>? _monthlyPaymentAmount;
    private DirtyValue<int?>? _remainingTermMonths;

    /// <summary>
    /// LiabilityContract AccountIdentifier [255], [1058]
    /// </summary>
    public string? AccountIdentifier { get => _accountIdentifier; set => SetField(ref _accountIdentifier, value); }

    /// <summary>
    /// LiabilityContract Country
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// Liabilities Alimony/Child Support Descr [271]
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// LiabilityContract ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// LiabilityContract LiabilityType
    /// </summary>
    public StringEnumValue<AltLiabilityType> LiabilityType { get => _liabilityType; set => SetField(ref _liabilityType, value); }

    /// <summary>
    /// LiabilityContract LiabilityTypeIndex
    /// </summary>
    public int? LiabilityTypeIndex { get => _liabilityTypeIndex; set => SetField(ref _liabilityTypeIndex, value); }

    /// <summary>
    /// LiabilityContract MonthlyPaymentAmount
    /// </summary>
    public decimal? MonthlyPaymentAmount { get => _monthlyPaymentAmount; set => SetField(ref _monthlyPaymentAmount, value); }

    /// <summary>
    /// LiabilityContract RemainingTermMonths
    /// </summary>
    public int? RemainingTermMonths { get => _remainingTermMonths; set => SetField(ref _remainingTermMonths, value); }
}