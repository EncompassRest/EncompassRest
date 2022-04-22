using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tax4506
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Tax4506 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Tax4506 AccountTranscript
    /// </summary>
    public bool? AccountTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Current Addr [AR0035]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Tax Form for Borr/Co-Borr/Both [AR0065]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignor { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Tax Form for Borr/Co-Borr/Both [AR0066]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignorSpouse { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Current City [AR0036]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Fee Per Yr/Period [AR0052]
    /// </summary>
    public decimal? CostForEachPeriod { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Current Name First [AR0039]
    /// </summary>
    public string? CurrentFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Current Name Last [AR0040]
    /// </summary>
    public string? CurrentLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - First Name [AR0002]
    /// </summary>
    public string? First { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 FormsSeriesTranscript
    /// </summary>
    public bool? FormsSeriesTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record ID [AR0063]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HistoryId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Refund to Third Party [AR0014]
    /// </summary>
    public bool? IfTaxRecordNotFound { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Irs4506C
    /// </summary>
    public bool? Irs4506C { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Last Name [AR0003]
    /// </summary>
    public string? Last { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Last Updated Date [AR0061]
    /// </summary>
    public DateTime? LastUpdatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 LastUpdatedHistory
    /// </summary>
    public int? LastUpdatedHistory { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Last Updated Time [AR0062]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LastUpdatedTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 NotifiedIrsIdentityTheftIndicator
    /// </summary>
    public bool? NotifiedIrsIdentityTheftIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - # Tax Periods Requested [AR0031]
    /// </summary>
    public int? NumberOfPeriods { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Tax Form for Borr/Co-Borr/Both [AR0001]
    /// </summary>
    public StringEnumValue<Person> Person { get => GetValue<StringEnumValue<Person>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RecordOfAccount
    /// </summary>
    public bool? RecordOfAccount { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Taxpayer Phone [AR0027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RequestorPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Taxpayer Title [AR0028]
    /// </summary>
    public StringEnumValue<RequestorTitle> RequestorTitle { get => GetValue<StringEnumValue<RequestorTitle>>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 1 [AR0025]
    /// </summary>
    public DateTime? RequestYear1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 2 [AR0026]
    /// </summary>
    public DateTime? RequestYear2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 3 [AR0029]
    /// </summary>
    public DateTime? RequestYear3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 4 [AR0030]
    /// </summary>
    public DateTime? RequestYear4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 5 [AR0053]
    /// </summary>
    public DateTime? RequestYear5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 6 [AR0054]
    /// </summary>
    public DateTime? RequestYear6 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 7 [AR0055]
    /// </summary>
    public DateTime? RequestYear7 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 8 [AR0056]
    /// </summary>
    public DateTime? RequestYear8 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Return Addr [AR0041]
    /// </summary>
    public string? ReturnAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Return City [AR0042]
    /// </summary>
    public string? ReturnCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Return State [AR0043]
    /// </summary>
    public string? ReturnState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 ReturnTranscript
    /// </summary>
    public bool? ReturnTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Return Zip [AR0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ReturnZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SelectedRecordNumber
    /// </summary>
    public string? SelectedRecordNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Addr [AR0010]
    /// </summary>
    public string? SendAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Send Return to City [AR0011]
    /// </summary>
    public string? SendCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Send Return to First Name [AR0008]
    /// </summary>
    public string? SendFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Last Name [AR0009]
    /// </summary>
    public string? SendLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Phone [AR0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SendPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Send Return to State [AR0012]
    /// </summary>
    public string? SendState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Zip [AR0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SendZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SignatoryAttestation
    /// </summary>
    public bool? SignatoryAttestation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SignatoryAttestationT
    /// </summary>
    public bool? SignatoryAttestationT { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Spouse First Name [AR0006]
    /// </summary>
    public string? SpouseFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Spouse Last Name [AR0007]
    /// </summary>
    public string? SpouseLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Second SSN/Empl ID # [AR0005]
    /// </summary>
    public string? SpouseSsn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Second SSN/Empl ID Format # [AR0058]
    /// </summary>
    public bool? SpouseUseEin { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - First SSN/Empl ID # [AR0004]
    /// </summary>
    public string? Ssn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Current State [AR0037]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Tax Return Requested Descr [AR0024]
    /// </summary>
    public string? TaxFormNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Copies Certified [AR0018]
    /// </summary>
    public bool? TheseCopiesMustBeCertified { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Total Cost [AR0032]
    /// </summary>
    public decimal? TotalCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - First SSN/Empl ID Format # [AR0057]
    /// </summary>
    public bool? UseEin { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Default to Wells Fargo Rules [AR0059]
    /// </summary>
    public bool? UseWellsFargoRules { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 VerificationOfNonfiling
    /// </summary>
    public bool? VerificationOfNonfiling { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Current Zip [AR0038]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
}