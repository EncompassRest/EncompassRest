using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EarlyCheck
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class EarlyCheck : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Early Check Appraisal Value [EC0002]
    /// </summary>
    public decimal? EcAppraisalValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Early Check Document File Id [EC0003]
    /// </summary>
    public string? EcDocumentFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Early Check UCDP Last Submission Date Time Early [EC0001]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EcUcdpLastSubmissionDateTimeEarly { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EarlyCheck Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}