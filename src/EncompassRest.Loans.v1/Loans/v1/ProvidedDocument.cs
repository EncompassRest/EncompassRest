using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ProvidedDocument
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ProvidedDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Documents Provided - ID [DOCPROVNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Borrower Type [DOCPROVNN01]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Date Provided [DOCPROVNN04]
    /// </summary>
    public DateTime? DateProvided { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Document Name [DOCPROVNN02]
    /// </summary>
    public string? DocumentName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ProvidedDocument EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ProvidedDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Required Indicator [DOCPROVNN03]
    /// </summary>
    public bool? RequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}