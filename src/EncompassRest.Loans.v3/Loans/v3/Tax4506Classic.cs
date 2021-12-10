using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tax4506Classic
/// </summary>
public sealed partial class Tax4506Classic : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _accountTranscript;
    private DirtyValue<string?>? _address;
    private DirtyValue<StringEnumValue<Owner>>? _authorizedSignor;
    private DirtyValue<StringEnumValue<Owner>>? _authorizedSignorSpouse;
    private DirtyValue<string?>? _city;
    private DirtyValue<decimal?>? _costForEachPeriod;
    private DirtyValue<string?>? _currentFirst;
    private DirtyValue<string?>? _currentLast;
    private DirtyValue<string?>? _first;
    private DirtyValue<bool?>? _formsSeriesTranscript;
    private DirtyValue<string?>? _historyId;
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
    /// IRS Transcript - Account Transcript [IRS4506.X47]
    /// </summary>
    public bool? AccountTranscript { get => _accountTranscript; set => SetField(ref _accountTranscript, value); }

    /// <summary>
    /// IRS - Current Addr [IRS4506.X35]
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// IRS - Tax Form for Borr/Co-Borr/Both [IRS4506.X63]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignor { get => _authorizedSignor; set => SetField(ref _authorizedSignor, value); }

    /// <summary>
    /// IRS - Tax Form for Borr/Co-Borr/Both [IRS4506.X64]
    /// </summary>
    public StringEnumValue<Owner> AuthorizedSignorSpouse { get => _authorizedSignorSpouse; set => SetField(ref _authorizedSignorSpouse, value); }

    /// <summary>
    /// IRS - Current City [IRS4506.X36]
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// IRS - Fee Per Yr/Period [IRS4506.X52]
    /// </summary>
    public decimal? CostForEachPeriod { get => _costForEachPeriod; set => SetField(ref _costForEachPeriod, value); }

    /// <summary>
    /// IRS - Current Name First [IRS4506.X39]
    /// </summary>
    public string? CurrentFirst { get => _currentFirst; set => SetField(ref _currentFirst, value); }

    /// <summary>
    /// IRS - Current Name Last [IRS4506.X40]
    /// </summary>
    public string? CurrentLast { get => _currentLast; set => SetField(ref _currentLast, value); }

    /// <summary>
    /// IRS - First Name [IRS4506.X2]
    /// </summary>
    public string? First { get => _first; set => SetField(ref _first, value); }

    /// <summary>
    /// IRS Transcript - Form W-2/1099/1098/5498 [IRS4506.X50]
    /// </summary>
    public bool? FormsSeriesTranscript { get => _formsSeriesTranscript; set => SetField(ref _formsSeriesTranscript, value); }

    /// <summary>
    /// Tax4506ClassicContract HistoryId
    /// </summary>
    public string? HistoryId { get => _historyId; set => SetField(ref _historyId, value); }

    /// <summary>
    /// IRS - Refund to Third Party [IRS4506.X14]
    /// </summary>
    public bool? IfTaxRecordNotFound { get => _ifTaxRecordNotFound; set => SetField(ref _ifTaxRecordNotFound, value); }

    /// <summary>
    /// Use IRS 4506-C [IRS4506.X67]
    /// </summary>
    public bool? Irs4506C { get => _irs4506C; set => SetField(ref _irs4506C, value); }

    /// <summary>
    /// IRS - Last Name [IRS4506.X3]
    /// </summary>
    public string? Last { get => _last; set => SetField(ref _last, value); }

    /// <summary>
    /// Tax4506ClassicContract LastUpdatedDate
    /// </summary>
    public DateTime? LastUpdatedDate { get => _lastUpdatedDate; set => SetField(ref _lastUpdatedDate, value); }

    /// <summary>
    /// IRS4506 Record - Last Updated History Record [AR0099]
    /// </summary>
    public int? LastUpdatedHistory { get => _lastUpdatedHistory; set => SetField(ref _lastUpdatedHistory, value); }

    /// <summary>
    /// Tax4506ClassicContract LastUpdatedTime
    /// </summary>
    public DateTime? LastUpdatedTime { get => _lastUpdatedTime; set => SetField(ref _lastUpdatedTime, value); }

    /// <summary>
    /// IRS - Identified IRS Identity Theft [IRS4506.X60]
    /// </summary>
    public bool? NotifiedIrsIdentityTheftIndicator { get => _notifiedIrsIdentityTheftIndicator; set => SetField(ref _notifiedIrsIdentityTheftIndicator, value); }

    /// <summary>
    /// IRS - # Tax Periods Requested [IRS4506.X31]
    /// </summary>
    public int? NumberOfPeriods { get => _numberOfPeriods; set => SetField(ref _numberOfPeriods, value); }

    /// <summary>
    /// IRS - Tax Form for Borr/Co-Borr/Both [IRS4506.X1]
    /// </summary>
    public StringEnumValue<Person> Person { get => _person; set => SetField(ref _person, value); }

    /// <summary>
    /// IRS Transcript - Record of Account [IRS4506.X48]
    /// </summary>
    public bool? RecordOfAccount { get => _recordOfAccount; set => SetField(ref _recordOfAccount, value); }

    /// <summary>
    /// IRS - Taxpayer Phone [IRS4506.X27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RequestorPhoneNumber { get => _requestorPhoneNumber; set => SetField(ref _requestorPhoneNumber, value); }

    /// <summary>
    /// IRS - Taxpayer Title [IRS4506.X28]
    /// </summary>
    public StringEnumValue<RequestorTitle> RequestorTitle { get => _requestorTitle; set => SetField(ref _requestorTitle, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 1 [IRS4506.X25]
    /// </summary>
    public DateTime? RequestYear1 { get => _requestYear1; set => SetField(ref _requestYear1, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 2 [IRS4506.X26]
    /// </summary>
    public DateTime? RequestYear2 { get => _requestYear2; set => SetField(ref _requestYear2, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 3 [IRS4506.X29]
    /// </summary>
    public DateTime? RequestYear3 { get => _requestYear3; set => SetField(ref _requestYear3, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 4 [IRS4506.X30]
    /// </summary>
    public DateTime? RequestYear4 { get => _requestYear4; set => SetField(ref _requestYear4, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 5 [IRS4506.X53]
    /// </summary>
    public DateTime? RequestYear5 { get => _requestYear5; set => SetField(ref _requestYear5, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 6 [IRS4506.X54]
    /// </summary>
    public DateTime? RequestYear6 { get => _requestYear6; set => SetField(ref _requestYear6, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 7 [IRS4506.X55]
    /// </summary>
    public DateTime? RequestYear7 { get => _requestYear7; set => SetField(ref _requestYear7, value); }

    /// <summary>
    /// IRS - Yr/Period Requested 8 [IRS4506.X56]
    /// </summary>
    public DateTime? RequestYear8 { get => _requestYear8; set => SetField(ref _requestYear8, value); }

    /// <summary>
    /// IRS - Return Addr [IRS4506.X41]
    /// </summary>
    public string? ReturnAddress { get => _returnAddress; set => SetField(ref _returnAddress, value); }

    /// <summary>
    /// IRS - Return City [IRS4506.X42]
    /// </summary>
    public string? ReturnCity { get => _returnCity; set => SetField(ref _returnCity, value); }

    /// <summary>
    /// IRS - Return State [IRS4506.X43]
    /// </summary>
    public string? ReturnState { get => _returnState; set => SetField(ref _returnState, value); }

    /// <summary>
    /// IRS Transcript - Return Transcript [IRS4506.X46]
    /// </summary>
    public bool? ReturnTranscript { get => _returnTranscript; set => SetField(ref _returnTranscript, value); }

    /// <summary>
    /// IRS - Return Zip [IRS4506.X44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ReturnZip { get => _returnZip; set => SetField(ref _returnZip, value); }

    /// <summary>
    /// IRS - Selected Record Number [IRS4506.X98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SelectedRecordNumber { get => _selectedRecordNumber; set => SetField(ref _selectedRecordNumber, value); }

    /// <summary>
    /// IRS - Send Return to Addr [IRS4506.X10]
    /// </summary>
    public string? SendAddress { get => _sendAddress; set => SetField(ref _sendAddress, value); }

    /// <summary>
    /// IRS - Send Return to City [IRS4506.X11]
    /// </summary>
    public string? SendCity { get => _sendCity; set => SetField(ref _sendCity, value); }

    /// <summary>
    /// IRS - Send Return to First Name [IRS4506.X8]
    /// </summary>
    public string? SendFirst { get => _sendFirst; set => SetField(ref _sendFirst, value); }

    /// <summary>
    /// IRS - Send Return to Last Name [IRS4506.X9]
    /// </summary>
    public string? SendLast { get => _sendLast; set => SetField(ref _sendLast, value); }

    /// <summary>
    /// IRS - Send Return to Phone [IRS4506.X45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SendPhone { get => _sendPhone; set => SetField(ref _sendPhone, value); }

    /// <summary>
    /// IRS - Send Return to State [IRS4506.X12]
    /// </summary>
    public string? SendState { get => _sendState; set => SetField(ref _sendState, value); }

    /// <summary>
    /// IRS - Send Return to Zip [IRS4506.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SendZip { get => _sendZip; set => SetField(ref _sendZip, value); }

    /// <summary>
    /// IRS - Signatory Attestation [IRS4506.X61]
    /// </summary>
    public bool? SignatoryAttestation { get => _signatoryAttestation; set => SetField(ref _signatoryAttestation, value); }

    /// <summary>
    /// IRS 4506T - Signatory Attestation [IRS4506.X62]
    /// </summary>
    public bool? SignatoryAttestationT { get => _signatoryAttestationT; set => SetField(ref _signatoryAttestationT, value); }

    /// <summary>
    /// IRS - Spouse First Name [IRS4506.X6]
    /// </summary>
    public string? SpouseFirst { get => _spouseFirst; set => SetField(ref _spouseFirst, value); }

    /// <summary>
    /// IRS - Spouse Last Name [IRS4506.X7]
    /// </summary>
    public string? SpouseLast { get => _spouseLast; set => SetField(ref _spouseLast, value); }

    /// <summary>
    /// IRS - Second SSN/Empl ID # [IRS4506.X5]
    /// </summary>
    public string? SpouseSsn { get => _spouseSsn; set => SetField(ref _spouseSsn, value); }

    /// <summary>
    /// IRS - Second SSN/Empl ID Format # [IRS4506.X58]
    /// </summary>
    public bool? SpouseUseEin { get => _spouseUseEin; set => SetField(ref _spouseUseEin, value); }

    /// <summary>
    /// IRS - First SSN/Empl ID # [IRS4506.X4]
    /// </summary>
    public string? Ssn { get => _ssn; set => SetField(ref _ssn, value); }

    /// <summary>
    /// IRS - Current State [IRS4506.X37]
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// IRS - Tax Return Requested Descr [IRS4506.X24]
    /// </summary>
    public string? TaxFormNumber { get => _taxFormNumber; set => SetField(ref _taxFormNumber, value); }

    /// <summary>
    /// IRS - Copies Certified [IRS4506.X18]
    /// </summary>
    public bool? TheseCopiesMustBeCertified { get => _theseCopiesMustBeCertified; set => SetField(ref _theseCopiesMustBeCertified, value); }

    /// <summary>
    /// IRS - Total Cost [IRS4506.X32]
    /// </summary>
    public decimal? TotalCost { get => _totalCost; set => SetField(ref _totalCost, value); }

    /// <summary>
    /// IRS - First SSN/Empl ID Format # [IRS4506.X57]
    /// </summary>
    public bool? UseEin { get => _useEin; set => SetField(ref _useEin, value); }

    /// <summary>
    /// IRS - Default to Wells Fargo Rules [IRS4506.X59]
    /// </summary>
    public bool? UseWellsFargoRules { get => _useWellsFargoRules; set => SetField(ref _useWellsFargoRules, value); }

    /// <summary>
    /// IRS Transcript - Verif of Nonfiling [IRS4506.X49]
    /// </summary>
    public bool? VerificationOfNonfiling { get => _verificationOfNonfiling; set => SetField(ref _verificationOfNonfiling, value); }

    /// <summary>
    /// IRS - Current Zip [IRS4506.X38]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? Zip { get => _zip; set => SetField(ref _zip, value); }
}