using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EarlyCheck
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class EarlyCheck : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _ecAppraisalValue;
    private DirtyValue<string?>? _ecDocumentFileId;
    private DirtyValue<DateTime?>? _ecUcdpLastSubmissionDateTimeEarly;
    private DirtyValue<string?>? _id;

    /// <summary>
    /// Early Check Appraisal Value [EC0002]
    /// </summary>
    public decimal? EcAppraisalValue { get => _ecAppraisalValue; set => SetField(ref _ecAppraisalValue, value); }

    /// <summary>
    /// Early Check Document File Id [EC0003]
    /// </summary>
    public string? EcDocumentFileId { get => _ecDocumentFileId; set => SetField(ref _ecDocumentFileId, value); }

    /// <summary>
    /// Early Check UCDP Last Submission Date Time Early [EC0001]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EcUcdpLastSubmissionDateTimeEarly { get => _ecUcdpLastSubmissionDateTimeEarly; set => SetField(ref _ecUcdpLastSubmissionDateTimeEarly, value); }

    /// <summary>
    /// EarlyCheckContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }
}