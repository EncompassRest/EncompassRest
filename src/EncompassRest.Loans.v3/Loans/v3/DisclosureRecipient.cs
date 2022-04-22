using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureRecipient
/// </summary>
public sealed partial class DisclosureRecipient : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosureRecipient ActualReceivedDate
    /// </summary>
    public DateTime? ActualReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipient BorrowerType
    /// </summary>
    [AllowNull]
    public LockableBorrowerTypeField BorrowerType { get => GetEntity<LockableBorrowerTypeField>(); set => SetEntity(value); }

    /// <summary>
    /// DisclosureRecipient DisclosedMethod
    /// </summary>
    public StringEnumValue<DisclosedOrReceivedMethod> DisclosedMethod { get => GetValue<StringEnumValue<DisclosedOrReceivedMethod>>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipient DisclosedMethodDescription
    /// </summary>
    public string? DisclosedMethodDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipient Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipient Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipient Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipient PresumedReceivedDate
    /// </summary>
    [AllowNull]
    public LockableDateField PresumedReceivedDate { get => GetEntity<LockableDateField>(); set => SetEntity(value); }

    /// <summary>
    /// DisclosureRecipient RecipientType
    /// </summary>
    public StringEnumValue<RecipientType> RecipientType { get => GetValue<StringEnumValue<RecipientType>>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipient Role
    /// </summary>
    [AllowNull]
    public DisclosureRecipientRoleReference Role { get => GetEntity<DisclosureRecipientRoleReference>(); set => SetEntity(value); }

    /// <summary>
    /// DisclosureRecipient Tracking
    /// </summary>
    [AllowNull]
    public DisclosureRecipientTracking Tracking { get => GetEntity<DisclosureRecipientTracking>(); set => SetEntity(value); }
}