using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Tax4506
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(HistoryIndicator) + "," + nameof(Tax4506TIndicator), SerializeWholeListWhenDirty = true)]
public sealed partial class Tax4506 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Tax4506 AccountTranscript [IRS4506.X47]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"b\"}")]
    public bool? AccountTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Address [IRS4506.X35]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 AuthorizedSignor [IRS4506.X63]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"CoBorrower\":\"Co-Borrower\"}")]
    public StringEnumValue<Owner> AuthorizedSignor { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 AuthorizedSignorSpouse [IRS4506.X64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"CoBorrower\":\"Co-Borrower\"}")]
    public StringEnumValue<Owner> AuthorizedSignorSpouse { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 City [IRS4506.X36]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 CostForEachPeriod [IRS4506.X52]
    /// </summary>
    public decimal? CostForEachPeriod { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 CurrentFirst [IRS4506.X39]
    /// </summary>
    public string? CurrentFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 CurrentLast [IRS4506.X40]
    /// </summary>
    public string? CurrentLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 First [IRS4506.X2]
    /// </summary>
    public string? First { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 FormsSeriesTranscript [IRS4506.X50]
    /// </summary>
    public bool? FormsSeriesTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 HistoryId [IRNN63], [ARNN63]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HistoryId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 HistoryIndicator
    /// </summary>
    public bool? HistoryIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 IfTaxRecordNotFound [IRS4506.X14]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"If we cannot find the tax return, we will refund the fee. If the refund should go to the third party listed on line 5, check here.\"}")]
    public bool? IfTaxRecordNotFound { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Use IRS 4506-C [IRS4506.X67]
    /// </summary>
    public bool? Irs4506C { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Last [IRS4506.X3]
    /// </summary>
    public string? Last { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 LastUpdatedDate [IRNN61], [ARNN61]
    /// </summary>
    public DateTime? LastUpdatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 LastUpdatedHistory [IR0099], [AR0099]
    /// </summary>
    public int? LastUpdatedHistory { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 LastUpdatedTime [IRNN62], [ARNN62]
    /// </summary>
    public string? LastUpdatedTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 NotifiedIrsIdentityTheftIndicator [IRS4506.X60]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? NotifiedIrsIdentityTheftIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 NumberOfPeriods [IRS4506.X31]
    /// </summary>
    public int? NumberOfPeriods { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Person [IRS4506.X1]
    /// </summary>
    public StringEnumValue<Person> Person { get => GetValue<StringEnumValue<Person>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RecordOfAccount [IRS4506.X48]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"c\"}")]
    public bool? RecordOfAccount { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestorPhoneNumber [IRS4506.X27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RequestorPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestorTitle [IRS4506.X28]
    /// </summary>
    public StringEnumValue<RequestorTitle> RequestorTitle { get => GetValue<StringEnumValue<RequestorTitle>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear1 [IRS4506.X25]
    /// </summary>
    public DateTime? RequestYear1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear2 [IRS4506.X26]
    /// </summary>
    public DateTime? RequestYear2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear3 [IRS4506.X29]
    /// </summary>
    public DateTime? RequestYear3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear4 [IRS4506.X30]
    /// </summary>
    public DateTime? RequestYear4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear5 [IRS4506.X53]
    /// </summary>
    public DateTime? RequestYear5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear6 [IRS4506.X54]
    /// </summary>
    public DateTime? RequestYear6 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear7 [IRS4506.X55]
    /// </summary>
    public DateTime? RequestYear7 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 RequestYear8 [IRS4506.X56]
    /// </summary>
    public DateTime? RequestYear8 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 ReturnAddress [IRS4506.X41]
    /// </summary>
    public string? ReturnAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 ReturnCity [IRS4506.X42]
    /// </summary>
    public string? ReturnCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 ReturnState [IRS4506.X43]
    /// </summary>
    public StringEnumValue<State> ReturnState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 ReturnTranscript [IRS4506.X46]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"a\"}")]
    public bool? ReturnTranscript { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 ReturnZip [IRS4506.X44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ReturnZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS - Selected Record Number [IRS4506.X98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SelectedRecordNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SendAddress [IRS4506.X10]
    /// </summary>
    public string? SendAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SendCity [IRS4506.X11]
    /// </summary>
    public string? SendCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SendFirst [IRS4506.X8]
    /// </summary>
    public string? SendFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SendLast [IRS4506.X9]
    /// </summary>
    public string? SendLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SendPhone [IRS4506.X45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SendPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SendState [IRS4506.X12]
    /// </summary>
    public StringEnumValue<State> SendState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SendZip [IRS4506.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SendZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SignatoryAttestation [IRS4506.X61], [IR0064]
    /// </summary>
    public bool? SignatoryAttestation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IRS 4506T - Signatory Attestation [IRS4506.X62]
    /// </summary>
    public bool? SignatoryAttestationT { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SpouseFirst [IRS4506.X6]
    /// </summary>
    public string? SpouseFirst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SpouseLast [IRS4506.X7]
    /// </summary>
    public string? SpouseLast { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SpouseSSN [IRS4506.X5]
    /// </summary>
    public string? SpouseSSN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SpouseUseEIN [IRS4506.X58]
    /// </summary>
    public bool? SpouseUseEIN { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 SSN [IRS4506.X4]
    /// </summary>
    public string? SSN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 State [IRS4506.X37]
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Tax4506Index
    /// </summary>
    public int? Tax4506Index { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Tax4506TIndicator
    /// </summary>
    public bool? Tax4506TIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 TaxFormNumber [IRS4506.X24]
    /// </summary>
    public string? TaxFormNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 TheseCopiesMustBeCertified [IRS4506.X18]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Copies must be certified for court or administrative proceedings\"}")]
    public bool? TheseCopiesMustBeCertified { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 TotalCost [IRS4506.X32]
    /// </summary>
    public decimal? TotalCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 UseEIN [IRS4506.X57]
    /// </summary>
    public bool? UseEIN { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 UseWellsFargoRules [IRS4506.X59]
    /// </summary>
    public bool? UseWellsFargoRules { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 VerificationOfNonfiling [IRS4506.X49]
    /// </summary>
    public bool? VerificationOfNonfiling { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Tax4506 Zip [IRS4506.X38]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
}