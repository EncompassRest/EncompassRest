using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CreditReport
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class CreditReport : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CreditReport AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport CreditReportCompany [BCRED0003], [CCRED0003]
    /// </summary>
    public string? CreditReportCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport CreditReportDate [BCRED0004], [CCRED0004]
    /// </summary>
    public DateTime? CreditReportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport CreditReportId [BCRED0005], [CCRED0005]
    /// </summary>
    public string? CreditReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport DateOfBirth [BCRED0002], [CCRED0002]
    /// </summary>
    public DateTime? DateOfBirth { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport NonTraditionalCredit [BCRED0006], [CCRED0006]
    /// </summary>
    public bool? NonTraditionalCredit { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport VerifySsn [BCRED0001], [CCRED0001]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? VerifySsn { get => GetValue<string?>(); set => SetValue(value); }
}