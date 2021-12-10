using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CreditReport
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class CreditReport : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _creditReportCompany;
    private DirtyValue<DateTime?>? _creditReportDate;
    private DirtyValue<string?>? _creditReportId;
    private DirtyValue<DateTime?>? _dateOfBirth;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _nonTraditionalCredit;
    private DirtyValue<string?>? _verifySsn;

    /// <summary>
    /// CreditReportContract AltId
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// CreditReportContract CreditReportCompany [BCRED0003], [CCRED0003]
    /// </summary>
    public string? CreditReportCompany { get => _creditReportCompany; set => SetField(ref _creditReportCompany, value); }

    /// <summary>
    /// CreditReportContract CreditReportDate [BCRED0004], [CCRED0004]
    /// </summary>
    public DateTime? CreditReportDate { get => _creditReportDate; set => SetField(ref _creditReportDate, value); }

    /// <summary>
    /// CreditReportContract CreditReportId [BCRED0005], [CCRED0005]
    /// </summary>
    public string? CreditReportId { get => _creditReportId; set => SetField(ref _creditReportId, value); }

    /// <summary>
    /// CreditReportContract DateOfBirth [BCRED0002], [CCRED0002]
    /// </summary>
    public DateTime? DateOfBirth { get => _dateOfBirth; set => SetField(ref _dateOfBirth, value); }

    /// <summary>
    /// CreditReportContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// CreditReportContract NonTraditionalCredit [BCRED0006], [CCRED0006]
    /// </summary>
    public bool? NonTraditionalCredit { get => _nonTraditionalCredit; set => SetField(ref _nonTraditionalCredit, value); }

    /// <summary>
    /// CreditReportContract VerifySsn [BCRED0001], [CCRED0001]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? VerifySsn { get => _verifySsn; set => SetField(ref _verifySsn, value); }
}