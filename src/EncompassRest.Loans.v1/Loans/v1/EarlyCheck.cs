using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// EarlyCheck
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class EarlyCheck : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Early Check Appraisal Value [ECNN02]
    /// </summary>
    public decimal? EcAppraisalValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Early Check Document File Id [ECNN03]
    /// </summary>
    public string? EcDocumentFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Early Check UCDP Last Submission Date Time Early [ECNN01]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EcUcdpLastSubmissionDateTimeEarly { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EarlyCheck Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}