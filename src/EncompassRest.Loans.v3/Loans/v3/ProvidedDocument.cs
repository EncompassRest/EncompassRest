using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ProvidedDocument
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ProvidedDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Documents Provided - ID [DOCPROV0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Borrower Type [DOCPROV0001]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Date Provided [DOCPROV0004]
    /// </summary>
    public DateTime? DateProvided { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Document Name [DOCPROV0002]
    /// </summary>
    public string? DocumentName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ProvidedDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Documents Provided - Required Indicator [DOCPROV0003]
    /// </summary>
    public bool? RequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}