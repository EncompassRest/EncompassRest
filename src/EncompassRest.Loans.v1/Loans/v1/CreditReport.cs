using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// CreditReport
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class CreditReport : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CreditReport Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport CreditReportCompany [BCREDNN03], [CCREDNN03]
    /// </summary>
    public string? CreditReportCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport CreditReportDate [BCREDNN04], [CCREDNN04]
    /// </summary>
    public DateTime? CreditReportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport CreditReportId [BCREDNN05], [CCREDNN05]
    /// </summary>
    public string? CreditReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport DateOfBirth [BCREDNN02], [CCREDNN02]
    /// </summary>
    public DateTime? DateOfBirth { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport NonTraditionalCredit [BCREDNN06], [CCREDNN06]
    /// </summary>
    public bool? NonTraditionalCredit { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CreditReport VerifySsn [BCREDNN01], [CCREDNN01]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? VerifySsn { get => GetValue<string?>(); set => SetValue(value); }
}