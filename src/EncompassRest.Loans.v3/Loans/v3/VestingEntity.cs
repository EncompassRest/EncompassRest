using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// VestingEntity
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class VestingEntity : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Vesting Party - Alias [TR0002]
    /// </summary>
    public string? Alias { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VestingEntity Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetEntity<ApplicationReference>(); set => SetEntity(value); }

    /// <summary>
    /// Vesting Party - Authorized to Sign [TR0009]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Authorized to Sign\"}")]
    public bool? AuthorizedToSignIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Date of Birth [TR0012]
    /// </summary>
    public DateTime? BirthDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VestingEntity Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VestingEntity NonBorrowingOwner
    /// </summary>
    [AllowNull]
    public EntityReference NonBorrowingOwner { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Vesting Party - POA Occupancy Intent [TR0014]
    /// </summary>
    public StringEnumValue<OccupancyIntent> OccupancyIntent { get => GetValue<StringEnumValue<OccupancyIntent>>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Occupancy Status [TR0013]
    /// </summary>
    public StringEnumValue<PropertyUsageType> OccupancyStatus { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Signature Text [TR0011]
    /// </summary>
    public string? PoaSignatureText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Power of Attroney [TR0007]
    /// </summary>
    public string? PowerOfAttorney { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Social Security Number [TR0003]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? Ssn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Name [TR0001]
    /// </summary>
    public string? UnparsedName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Vesting [TR0008]
    /// </summary>
    public string? Vesting { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Unique ID [TR0010]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VestingGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Trustee Of [TR0006]
    /// </summary>
    public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => GetValue<StringEnumValue<VestingTrusteeOfType>>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Vesting Type [TR0004]
    /// </summary>
    public StringEnumValue<BorrowerType> VestingType { get => GetValue<StringEnumValue<BorrowerType>>(); set => SetValue(value); }
}