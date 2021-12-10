using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureRecipient
/// </summary>
public sealed partial class DisclosureRecipient : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _actualReceivedDate;
    private LockableBorrowerTypeField? _borrowerType;
    private DirtyValue<StringEnumValue<DisclosedOrReceivedMethod>>? _disclosedMethod;
    private DirtyValue<string?>? _disclosedMethodDescription;
    private DirtyValue<string?>? _email;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _name;
    private LockableDateField? _presumedReceivedDate;
    private DirtyValue<StringEnumValue<RecipientType>>? _recipientType;
    private DisclosureRecipientRoleReference? _role;
    private DisclosureRecipientTracking? _tracking;

    /// <summary>
    /// DisclosureRecipientContract ActualReceivedDate
    /// </summary>
    public DateTime? ActualReceivedDate { get => _actualReceivedDate; set => SetField(ref _actualReceivedDate, value); }

    /// <summary>
    /// DisclosureRecipientContract BorrowerType
    /// </summary>
    [AllowNull]
    public LockableBorrowerTypeField BorrowerType { get => GetField(ref _borrowerType); set => SetField(ref _borrowerType, value); }

    /// <summary>
    /// DisclosureRecipientContract DisclosedMethod
    /// </summary>
    public StringEnumValue<DisclosedOrReceivedMethod> DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }

    /// <summary>
    /// DisclosureRecipientContract DisclosedMethodDescription
    /// </summary>
    public string? DisclosedMethodDescription { get => _disclosedMethodDescription; set => SetField(ref _disclosedMethodDescription, value); }

    /// <summary>
    /// DisclosureRecipientContract Email
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// DisclosureRecipientContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// DisclosureRecipientContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// DisclosureRecipientContract PresumedReceivedDate
    /// </summary>
    [AllowNull]
    public LockableDateField PresumedReceivedDate { get => GetField(ref _presumedReceivedDate); set => SetField(ref _presumedReceivedDate, value); }

    /// <summary>
    /// DisclosureRecipientContract RecipientType
    /// </summary>
    public StringEnumValue<RecipientType> RecipientType { get => _recipientType; set => SetField(ref _recipientType, value); }

    /// <summary>
    /// DisclosureRecipientContract Role
    /// </summary>
    [AllowNull]
    public DisclosureRecipientRoleReference Role { get => GetField(ref _role); set => SetField(ref _role, value); }

    /// <summary>
    /// DisclosureRecipientContract Tracking
    /// </summary>
    [AllowNull]
    public DisclosureRecipientTracking Tracking { get => GetField(ref _tracking); set => SetField(ref _tracking, value); }
}