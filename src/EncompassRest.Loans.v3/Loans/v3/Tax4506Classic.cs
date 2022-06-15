using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tax4506Classic
/// </summary>
public sealed partial class Tax4506Classic : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// IRS Transcript - Account Transcript [IRS4506.X47]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"b\"}")]
    public bool? AccountTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Current Addr [IRS4506.X35]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Tax Form for Borr/Co-Borr/Both [IRS4506.X63]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignor { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Tax Form for Borr/Co-Borr/Both [IRS4506.X64]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignorSpouse { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Current City [IRS4506.X36]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Fee Per Yr/Period [IRS4506.X52]
    /// </summary>
    public decimal? CostForEachPeriod { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Current Name First [IRS4506.X39]
    /// </summary>
    public string? CurrentFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Current Name Last [IRS4506.X40]
    /// </summary>
    public string? CurrentLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - First Name [IRS4506.X2]
    /// </summary>
    public string? First { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - Form W-2/1099/1098/5498 [IRS4506.X50]
    /// </summary>
    public bool? FormsSeriesTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506Classic HistoryId
    /// </summary>
    public string? HistoryId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Refund to Third Party [IRS4506.X14]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"If we cannot find the tax return, we will refund the fee. If the refund should go to the third party listed on line 5, check here.\"}")]
    public bool? IfTaxRecordNotFound { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Use IRS 4506-C [IRS4506.X67]
    /// </summary>
    public bool? Irs4506C { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Last Name [IRS4506.X3]
    /// </summary>
    public string? Last { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506Classic LastUpdatedDate
    /// </summary>
    public DateTime? LastUpdatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS4506 Record - Last Updated History Record [AR0099]
    /// </summary>
    public int? LastUpdatedHistory { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506Classic LastUpdatedTime
    /// </summary>
    public DateTime? LastUpdatedTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Identified IRS Identity Theft [IRS4506.X60]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? NotifiedIrsIdentityTheftIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - # Tax Periods Requested [IRS4506.X31]
    /// </summary>
    public int? NumberOfPeriods { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Tax Form for Borr/Co-Borr/Both [IRS4506.X1]
    /// </summary>
    public StringEnumValue<Person> Person { get => GetValue<StringEnumValue<Person>>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - Record of Account [IRS4506.X48]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"c\"}")]
    public bool? RecordOfAccount { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Taxpayer Phone [IRS4506.X27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RequestorPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Taxpayer Title [IRS4506.X28]
    /// </summary>
    public StringEnumValue<RequestorTitle> RequestorTitle { get => GetValue<StringEnumValue<RequestorTitle>>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 1 [IRS4506.X25]
    /// </summary>
    public DateTime? RequestYear1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 2 [IRS4506.X26]
    /// </summary>
    public DateTime? RequestYear2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 3 [IRS4506.X29]
    /// </summary>
    public DateTime? RequestYear3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 4 [IRS4506.X30]
    /// </summary>
    public DateTime? RequestYear4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 5 [IRS4506.X53]
    /// </summary>
    public DateTime? RequestYear5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 6 [IRS4506.X54]
    /// </summary>
    public DateTime? RequestYear6 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 7 [IRS4506.X55]
    /// </summary>
    public DateTime? RequestYear7 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Yr/Period Requested 8 [IRS4506.X56]
    /// </summary>
    public DateTime? RequestYear8 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Return Addr [IRS4506.X41]
    /// </summary>
    public string? ReturnAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Return City [IRS4506.X42]
    /// </summary>
    public string? ReturnCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Return State [IRS4506.X43]
    /// </summary>
    public string? ReturnState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - Return Transcript [IRS4506.X46]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"a\"}")]
    public bool? ReturnTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Return Zip [IRS4506.X44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ReturnZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Selected Record Number [IRS4506.X98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SelectedRecordNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Send Return to Addr [IRS4506.X10]
    /// </summary>
    public string? SendAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Send Return to City [IRS4506.X11]
    /// </summary>
    public string? SendCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Send Return to First Name [IRS4506.X8]
    /// </summary>
    public string? SendFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Send Return to Last Name [IRS4506.X9]
    /// </summary>
    public string? SendLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Send Return to Phone [IRS4506.X45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SendPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Send Return to State [IRS4506.X12]
    /// </summary>
    public string? SendState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Send Return to Zip [IRS4506.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SendZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Signatory Attestation [IRS4506.X61]
    /// </summary>
    public bool? SignatoryAttestation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS 4506T - Signatory Attestation [IRS4506.X62]
    /// </summary>
    public bool? SignatoryAttestationT { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Spouse First Name [IRS4506.X6]
    /// </summary>
    public string? SpouseFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Spouse Last Name [IRS4506.X7]
    /// </summary>
    public string? SpouseLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Second SSN/Empl ID # [IRS4506.X5]
    /// </summary>
    public string? SpouseSsn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Second SSN/Empl ID Format # [IRS4506.X58]
    /// </summary>
    public bool? SpouseUseEin { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - First SSN/Empl ID # [IRS4506.X4]
    /// </summary>
    public string? Ssn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Current State [IRS4506.X37]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Tax Return Requested Descr [IRS4506.X24]
    /// </summary>
    public string? TaxFormNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Copies Certified [IRS4506.X18]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Copies must be certified for court or administrative proceedings\"}")]
    public bool? TheseCopiesMustBeCertified { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Total Cost [IRS4506.X32]
    /// </summary>
    public decimal? TotalCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - First SSN/Empl ID Format # [IRS4506.X57]
    /// </summary>
    public bool? UseEin { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Default to Wells Fargo Rules [IRS4506.X59]
    /// </summary>
    public bool? UseWellsFargoRules { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Transcript - Verif of Nonfiling [IRS4506.X49]
    /// </summary>
    public bool? VerificationOfNonfiling { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Current Zip [IRS4506.X38]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
}