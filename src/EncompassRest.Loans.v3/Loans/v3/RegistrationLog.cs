using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RegistrationLog
/// </summary>
public sealed partial class RegistrationLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// RegistrationLog CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog ExpirationDate
    /// </summary>
    public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog InvestorName
    /// </summary>
    public string? InvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog IsCurrent
    /// </summary>
    public bool? IsCurrent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog ReferenceNumber
    /// </summary>
    public string? ReferenceNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog RegisteredBy
    /// </summary>
    [AllowNull]
    public EntityReference RegisteredBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// RegistrationLog RegistrationDate
    /// </summary>
    public DateTime? RegistrationDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}