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
    private DirtyValue<bool?>? _accountTranscript;
    private DirtyValue<string?>? _address;
    private DirtyValue<string?>? _altId;
    private DirtyValue<StringEnumValue<Owner>>? _authorizedSignor;
    private DirtyValue<StringEnumValue<Owner>>? _authorizedSignorSpouse;
    private DirtyValue<string?>? _city;
    private DirtyValue<decimal?>? _costForEachPeriod;
    private DirtyValue<string?>? _currentFirst;
    private DirtyValue<string?>? _currentLast;
    private DirtyValue<string?>? _first;
    private DirtyValue<bool?>? _formsSeriesTranscript;
    private DirtyValue<string?>? _historyId;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _ifTaxRecordNotFound;
    private DirtyValue<bool?>? _irs4506C;
    private DirtyValue<string?>? _last;
    private DirtyValue<DateTime?>? _lastUpdatedDate;
    private DirtyValue<int?>? _lastUpdatedHistory;
    private DirtyValue<DateTime?>? _lastUpdatedTime;
    private DirtyValue<bool?>? _notifiedIrsIdentityTheftIndicator;
    private DirtyValue<int?>? _numberOfPeriods;
    private DirtyValue<StringEnumValue<Person>>? _person;
    private DirtyValue<bool?>? _recordOfAccount;
    private DirtyValue<string?>? _requestorPhoneNumber;
    private DirtyValue<StringEnumValue<RequestorTitle>>? _requestorTitle;
    private DirtyValue<DateTime?>? _requestYear1;
    private DirtyValue<DateTime?>? _requestYear2;
    private DirtyValue<DateTime?>? _requestYear3;
    private DirtyValue<DateTime?>? _requestYear4;
    private DirtyValue<DateTime?>? _requestYear5;
    private DirtyValue<DateTime?>? _requestYear6;
    private DirtyValue<DateTime?>? _requestYear7;
    private DirtyValue<DateTime?>? _requestYear8;
    private DirtyValue<string?>? _returnAddress;
    private DirtyValue<string?>? _returnCity;
    private DirtyValue<string?>? _returnState;
    private DirtyValue<bool?>? _returnTranscript;
    private DirtyValue<string?>? _returnZip;
    private DirtyValue<string?>? _selectedRecordNumber;
    private DirtyValue<string?>? _sendAddress;
    private DirtyValue<string?>? _sendCity;
    private DirtyValue<string?>? _sendFirst;
    private DirtyValue<string?>? _sendLast;
    private DirtyValue<string?>? _sendPhone;
    private DirtyValue<string?>? _sendState;
    private DirtyValue<string?>? _sendZip;
    private DirtyValue<bool?>? _signatoryAttestation;
    private DirtyValue<bool?>? _signatoryAttestationT;
    private DirtyValue<string?>? _spouseFirst;
    private DirtyValue<string?>? _spouseLast;
    private DirtyValue<string?>? _spouseSsn;
    private DirtyValue<bool?>? _spouseUseEin;
    private DirtyValue<string?>? _ssn;
    private DirtyValue<string?>? _state;
    private DirtyValue<string?>? _taxFormNumber;
    private DirtyValue<bool?>? _theseCopiesMustBeCertified;
    private DirtyValue<decimal?>? _totalCost;
    private DirtyValue<bool?>? _useEin;
    private DirtyValue<bool?>? _useWellsFargoRules;
    private DirtyValue<bool?>? _verificationOfNonfiling;
    private DirtyValue<string?>? _zip;

    /// <summary>
    /// Tax4506Contract AccountTranscript
    /// </summary>
    public bool? AccountTranscript { get => _accountTranscript; set => SetField(ref _accountTranscript, value); }

    /// <summary>
    /// IRS4506 Record - Current Addr [AR0035]
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// Tax4506Contract AltId
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// IRS4506 Record - Tax Form for Borr/Co-Borr/Both [AR0065]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignor { get => _authorizedSignor; set => SetField(ref _authorizedSignor, value); }

    /// <summary>
    /// IRS4506 Record - Tax Form for Borr/Co-Borr/Both [AR0066]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignorSpouse { get => _authorizedSignorSpouse; set => SetField(ref _authorizedSignorSpouse, value); }

    /// <summary>
    /// IRS4506 Record - Current City [AR0036]
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// IRS4506 Record - Fee Per Yr/Period [AR0052]
    /// </summary>
    public decimal? CostForEachPeriod { get => _costForEachPeriod; set => SetField(ref _costForEachPeriod, value); }

    /// <summary>
    /// IRS4506 Record - Current Name First [AR0039]
    /// </summary>
    public string? CurrentFirst { get => _currentFirst; set => SetField(ref _currentFirst, value); }

    /// <summary>
    /// IRS4506 Record - Current Name Last [AR0040]
    /// </summary>
    public string? CurrentLast { get => _currentLast; set => SetField(ref _currentLast, value); }

    /// <summary>
    /// IRS4506 Record - First Name [AR0002]
    /// </summary>
    public string? First { get => _first; set => SetField(ref _first, value); }

    /// <summary>
    /// Tax4506Contract FormsSeriesTranscript
    /// </summary>
    public bool? FormsSeriesTranscript { get => _formsSeriesTranscript; set => SetField(ref _formsSeriesTranscript, value); }

    /// <summary>
    /// IRS4506 Record ID [AR0063]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HistoryId { get => _historyId; set => SetField(ref _historyId, value); }

    /// <summary>
    /// Tax4506Contract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// IRS4506 Record - Refund to Third Party [AR0014]
    /// </summary>
    public bool? IfTaxRecordNotFound { get => _ifTaxRecordNotFound; set => SetField(ref _ifTaxRecordNotFound, value); }

    /// <summary>
    /// Tax4506Contract Irs4506C
    /// </summary>
    public bool? Irs4506C { get => _irs4506C; set => SetField(ref _irs4506C, value); }

    /// <summary>
    /// IRS4506 Record - Last Name [AR0003]
    /// </summary>
    public string? Last { get => _last; set => SetField(ref _last, value); }

    /// <summary>
    /// IRS4506 Record - Last Updated Date [AR0061]
    /// </summary>
    public DateTime? LastUpdatedDate { get => _lastUpdatedDate; set => SetField(ref _lastUpdatedDate, value); }

    /// <summary>
    /// Tax4506Contract LastUpdatedHistory
    /// </summary>
    public int? LastUpdatedHistory { get => _lastUpdatedHistory; set => SetField(ref _lastUpdatedHistory, value); }

    /// <summary>
    /// IRS4506 Record - Last Updated Time [AR0062]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LastUpdatedTime { get => _lastUpdatedTime; set => SetField(ref _lastUpdatedTime, value); }

    /// <summary>
    /// Tax4506Contract NotifiedIrsIdentityTheftIndicator
    /// </summary>
    public bool? NotifiedIrsIdentityTheftIndicator { get => _notifiedIrsIdentityTheftIndicator; set => SetField(ref _notifiedIrsIdentityTheftIndicator, value); }

    /// <summary>
    /// IRS4506 Record - # Tax Periods Requested [AR0031]
    /// </summary>
    public int? NumberOfPeriods { get => _numberOfPeriods; set => SetField(ref _numberOfPeriods, value); }

    /// <summary>
    /// IRS4506 Record - Tax Form for Borr/Co-Borr/Both [AR0001]
    /// </summary>
    public StringEnumValue<Person> Person { get => _person; set => SetField(ref _person, value); }

    /// <summary>
    /// Tax4506Contract RecordOfAccount
    /// </summary>
    public bool? RecordOfAccount { get => _recordOfAccount; set => SetField(ref _recordOfAccount, value); }

    /// <summary>
    /// IRS4506 Record - Taxpayer Phone [AR0027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RequestorPhoneNumber { get => _requestorPhoneNumber; set => SetField(ref _requestorPhoneNumber, value); }

    /// <summary>
    /// IRS4506 Record - Taxpayer Title [AR0028]
    /// </summary>
    public StringEnumValue<RequestorTitle> RequestorTitle { get => _requestorTitle; set => SetField(ref _requestorTitle, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 1 [AR0025]
    /// </summary>
    public DateTime? RequestYear1 { get => _requestYear1; set => SetField(ref _requestYear1, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 2 [AR0026]
    /// </summary>
    public DateTime? RequestYear2 { get => _requestYear2; set => SetField(ref _requestYear2, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 3 [AR0029]
    /// </summary>
    public DateTime? RequestYear3 { get => _requestYear3; set => SetField(ref _requestYear3, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 4 [AR0030]
    /// </summary>
    public DateTime? RequestYear4 { get => _requestYear4; set => SetField(ref _requestYear4, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 5 [AR0053]
    /// </summary>
    public DateTime? RequestYear5 { get => _requestYear5; set => SetField(ref _requestYear5, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 6 [AR0054]
    /// </summary>
    public DateTime? RequestYear6 { get => _requestYear6; set => SetField(ref _requestYear6, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 7 [AR0055]
    /// </summary>
    public DateTime? RequestYear7 { get => _requestYear7; set => SetField(ref _requestYear7, value); }

    /// <summary>
    /// IRS4506 Record - Yr/Period Requested 8 [AR0056]
    /// </summary>
    public DateTime? RequestYear8 { get => _requestYear8; set => SetField(ref _requestYear8, value); }

    /// <summary>
    /// IRS4506 Record - Return Addr [AR0041]
    /// </summary>
    public string? ReturnAddress { get => _returnAddress; set => SetField(ref _returnAddress, value); }

    /// <summary>
    /// IRS4506 Record - Return City [AR0042]
    /// </summary>
    public string? ReturnCity { get => _returnCity; set => SetField(ref _returnCity, value); }

    /// <summary>
    /// IRS4506 Record - Return State [AR0043]
    /// </summary>
    public string? ReturnState { get => _returnState; set => SetField(ref _returnState, value); }

    /// <summary>
    /// Tax4506Contract ReturnTranscript
    /// </summary>
    public bool? ReturnTranscript { get => _returnTranscript; set => SetField(ref _returnTranscript, value); }

    /// <summary>
    /// IRS4506 Record - Return Zip [AR0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ReturnZip { get => _returnZip; set => SetField(ref _returnZip, value); }

    /// <summary>
    /// Tax4506Contract SelectedRecordNumber
    /// </summary>
    public string? SelectedRecordNumber { get => _selectedRecordNumber; set => SetField(ref _selectedRecordNumber, value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Addr [AR0010]
    /// </summary>
    public string? SendAddress { get => _sendAddress; set => SetField(ref _sendAddress, value); }

    /// <summary>
    /// IRS4506 Record - Send Return to City [AR0011]
    /// </summary>
    public string? SendCity { get => _sendCity; set => SetField(ref _sendCity, value); }

    /// <summary>
    /// IRS4506 Record - Send Return to First Name [AR0008]
    /// </summary>
    public string? SendFirst { get => _sendFirst; set => SetField(ref _sendFirst, value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Last Name [AR0009]
    /// </summary>
    public string? SendLast { get => _sendLast; set => SetField(ref _sendLast, value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Phone [AR0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SendPhone { get => _sendPhone; set => SetField(ref _sendPhone, value); }

    /// <summary>
    /// IRS4506 Record - Send Return to State [AR0012]
    /// </summary>
    public string? SendState { get => _sendState; set => SetField(ref _sendState, value); }

    /// <summary>
    /// IRS4506 Record - Send Return to Zip [AR0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SendZip { get => _sendZip; set => SetField(ref _sendZip, value); }

    /// <summary>
    /// Tax4506Contract SignatoryAttestation
    /// </summary>
    public bool? SignatoryAttestation { get => _signatoryAttestation; set => SetField(ref _signatoryAttestation, value); }

    /// <summary>
    /// Tax4506Contract SignatoryAttestationT
    /// </summary>
    public bool? SignatoryAttestationT { get => _signatoryAttestationT; set => SetField(ref _signatoryAttestationT, value); }

    /// <summary>
    /// IRS4506 Record - Spouse First Name [AR0006]
    /// </summary>
    public string? SpouseFirst { get => _spouseFirst; set => SetField(ref _spouseFirst, value); }

    /// <summary>
    /// IRS4506 Record - Spouse Last Name [AR0007]
    /// </summary>
    public string? SpouseLast { get => _spouseLast; set => SetField(ref _spouseLast, value); }

    /// <summary>
    /// IRS4506 Record - Second SSN/Empl ID # [AR0005]
    /// </summary>
    public string? SpouseSsn { get => _spouseSsn; set => SetField(ref _spouseSsn, value); }

    /// <summary>
    /// IRS4506 Record - Second SSN/Empl ID Format # [AR0058]
    /// </summary>
    public bool? SpouseUseEin { get => _spouseUseEin; set => SetField(ref _spouseUseEin, value); }

    /// <summary>
    /// IRS4506 Record - First SSN/Empl ID # [AR0004]
    /// </summary>
    public string? Ssn { get => _ssn; set => SetField(ref _ssn, value); }

    /// <summary>
    /// IRS4506 Record - Current State [AR0037]
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// IRS4506 Record - Tax Return Requested Descr [AR0024]
    /// </summary>
    public string? TaxFormNumber { get => _taxFormNumber; set => SetField(ref _taxFormNumber, value); }

    /// <summary>
    /// IRS4506 Record - Copies Certified [AR0018]
    /// </summary>
    public bool? TheseCopiesMustBeCertified { get => _theseCopiesMustBeCertified; set => SetField(ref _theseCopiesMustBeCertified, value); }

    /// <summary>
    /// IRS4506 Record - Total Cost [AR0032]
    /// </summary>
    public decimal? TotalCost { get => _totalCost; set => SetField(ref _totalCost, value); }

    /// <summary>
    /// IRS4506 Record - First SSN/Empl ID Format # [AR0057]
    /// </summary>
    public bool? UseEin { get => _useEin; set => SetField(ref _useEin, value); }

    /// <summary>
    /// IRS4506 Record - Default to Wells Fargo Rules [AR0059]
    /// </summary>
    public bool? UseWellsFargoRules { get => _useWellsFargoRules; set => SetField(ref _useWellsFargoRules, value); }

    /// <summary>
    /// Tax4506Contract VerificationOfNonfiling
    /// </summary>
    public bool? VerificationOfNonfiling { get => _verificationOfNonfiling; set => SetField(ref _verificationOfNonfiling, value); }

    /// <summary>
    /// IRS4506 Record - Current Zip [AR0038]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? Zip { get => _zip; set => SetField(ref _zip, value); }
}