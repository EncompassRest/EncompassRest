using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tax4506T
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Tax4506T : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// IRS Transcript - History Record - Account Transcript [IR0047]
    /// </summary>
    public bool? AccountTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Current Addr [IR0035]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Tax Form for Borr/Co-Borr/Both [IR0065]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignor { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Tax Form for Borr/Co-Borr/Both [IR0066]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignorSpouse { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Current City [IR0036]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T CostForEachPeriod
    /// </summary>
    public decimal? CostForEachPeriod { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Current Name First [IR0039]
    /// </summary>
    public string? CurrentFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Current Name Last [IR0040]
    /// </summary>
    public string? CurrentLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - First Name [IR0002]
    /// </summary>
    public string? First { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - History Record - Form W-2/1099/1098/5498 [IR0050]
    /// </summary>
    public bool? FormsSeriesTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record ID [IR0063]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HistoryId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T IfTaxRecordNotFound
    /// </summary>
    public bool? IfTaxRecordNotFound { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T Irs4506C
    /// </summary>
    public bool? Irs4506C { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Last Name [IR0003]
    /// </summary>
    public string? Last { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Last Updated Date [IR0061]
    /// </summary>
    public DateTime? LastUpdatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T LastUpdatedHistory
    /// </summary>
    public int? LastUpdatedHistory { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Last Updated Time [IR0062]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LastUpdatedTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Identified IRS Identity Theft [IR0060]
    /// </summary>
    public bool? NotifiedIrsIdentityTheftIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T NumberOfPeriods
    /// </summary>
    public int? NumberOfPeriods { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Tax Form for Borr/Co-Borr/Both [IR0001]
    /// </summary>
    public StringEnumValue<Person> Person { get => GetValue<StringEnumValue<Person>>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - History Record - Record of Account [IR0048]
    /// </summary>
    public bool? RecordOfAccount { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Taxpayer Phone [IR0027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RequestorPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Taxpayer Title [IR0028]
    /// </summary>
    public StringEnumValue<RequestorTitle> RequestorTitle { get => GetValue<StringEnumValue<RequestorTitle>>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Yr/Period Requested 1 [IR0025]
    /// </summary>
    public DateTime? RequestYear1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Yr/Period Requested 2 [IR0026]
    /// </summary>
    public DateTime? RequestYear2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Yr/Period Requested 3 [IR0029]
    /// </summary>
    public DateTime? RequestYear3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Yr/Period Requested 4 [IR0030]
    /// </summary>
    public DateTime? RequestYear4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T RequestYear5
    /// </summary>
    public DateTime? RequestYear5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T RequestYear6
    /// </summary>
    public DateTime? RequestYear6 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T RequestYear7
    /// </summary>
    public DateTime? RequestYear7 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T RequestYear8
    /// </summary>
    public DateTime? RequestYear8 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Return Addr [IR0041]
    /// </summary>
    public string? ReturnAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Return City [IR0042]
    /// </summary>
    public string? ReturnCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Return State [IR0043]
    /// </summary>
    public string? ReturnState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - History Record - Return Transcript [IR0046]
    /// </summary>
    public bool? ReturnTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Return Zip [IR0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ReturnZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T SelectedRecordNumber
    /// </summary>
    public string? SelectedRecordNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Send Return to Addr [IR0010]
    /// </summary>
    public string? SendAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Send Return to City [IR0011]
    /// </summary>
    public string? SendCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Send Return to First Name [IR0008]
    /// </summary>
    public string? SendFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Send Return to Last Name [IR0009]
    /// </summary>
    public string? SendLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Send Return to Phone [IR0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SendPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Send Return to State [IR0012]
    /// </summary>
    public string? SendState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Send Return to Zip [IR0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SendZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - History Record - Signatory Attestation [IR0064]
    /// </summary>
    public bool? SignatoryAttestation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T SignatoryAttestationT
    /// </summary>
    public bool? SignatoryAttestationT { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Spouse First Name [IR0006]
    /// </summary>
    public string? SpouseFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Spouse Last Name [IR0007]
    /// </summary>
    public string? SpouseLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Second SSN/Empl ID # [IR0005]
    /// </summary>
    public string? SpouseSsn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Second SSN/Empl ID Format # [IR0058]
    /// </summary>
    public bool? SpouseUseEin { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - First SSN/Empl ID # [IR0004]
    /// </summary>
    public string? Ssn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Current State [IR0037]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Tax Return Requested Descr [IR0024]
    /// </summary>
    public string? TaxFormNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T TheseCopiesMustBeCertified
    /// </summary>
    public bool? TheseCopiesMustBeCertified { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506T TotalCost
    /// </summary>
    public decimal? TotalCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - First SSN/Empl ID Format # [IR0057]
    /// </summary>
    public bool? UseEin { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Default to Wells Fargo Rules [IR0059]
    /// </summary>
    public bool? UseWellsFargoRules { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - History Record - Verif of Nonfiling [IR0049]
    /// </summary>
    public bool? VerificationOfNonfiling { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 T Record - Current Zip [IR0038]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
}