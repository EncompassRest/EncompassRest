using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RegistrationLog
/// </summary>
public sealed partial class RegistrationLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _createdDate;
    private DirtyValue<DateTime?>? _expirationDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _investorName;
    private DirtyValue<bool?>? _isCurrent;
    private DirtyValue<string?>? _referenceNumber;
    private EntityReference? _registeredBy;
    private DirtyValue<DateTime?>? _registrationDate;

    /// <summary>
    /// RegistrationLogContract CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

    /// <summary>
    /// RegistrationLogContract ExpirationDate
    /// </summary>
    public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }

    /// <summary>
    /// RegistrationLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// RegistrationLogContract InvestorName
    /// </summary>
    public string? InvestorName { get => _investorName; set => SetField(ref _investorName, value); }

    /// <summary>
    /// RegistrationLogContract IsCurrent
    /// </summary>
    public bool? IsCurrent { get => _isCurrent; set => SetField(ref _isCurrent, value); }

    /// <summary>
    /// RegistrationLogContract ReferenceNumber
    /// </summary>
    public string? ReferenceNumber { get => _referenceNumber; set => SetField(ref _referenceNumber, value); }

    /// <summary>
    /// RegistrationLogContract RegisteredBy
    /// </summary>
    [AllowNull]
    public EntityReference RegisteredBy { get => GetField(ref _registeredBy); set => SetField(ref _registeredBy, value); }

    /// <summary>
    /// RegistrationLogContract RegistrationDate
    /// </summary>
    public DateTime? RegistrationDate { get => _registrationDate; set => SetField(ref _registrationDate, value); }
}