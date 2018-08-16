using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Tax4506
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(HistoryIndicator) + "," + nameof(Tax4506TIndicator), SerializeWholeListWhenDirty = true)]
    public sealed partial class Tax4506 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _accountTranscript;
        /// <summary>
        /// Tax4506 AccountTranscript [IRS4506.X47]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"b\"}")]
        public bool? AccountTranscript { get => _accountTranscript; set => SetField(ref _accountTranscript, value); }
        private DirtyValue<string> _address;
        /// <summary>
        /// Tax4506 Address [IRS4506.X35]
        /// </summary>
        public string Address { get => _address; set => SetField(ref _address, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// Tax4506 City [IRS4506.X36]
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<decimal?> _costForEachPeriod;
        /// <summary>
        /// Tax4506 CostForEachPeriod [IRS4506.X52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CostForEachPeriod { get => _costForEachPeriod; set => SetField(ref _costForEachPeriod, value); }
        private DirtyValue<string> _currentFirst;
        /// <summary>
        /// Tax4506 CurrentFirst [IRS4506.X39]
        /// </summary>
        public string CurrentFirst { get => _currentFirst; set => SetField(ref _currentFirst, value); }
        private DirtyValue<string> _currentLast;
        /// <summary>
        /// Tax4506 CurrentLast [IRS4506.X40]
        /// </summary>
        public string CurrentLast { get => _currentLast; set => SetField(ref _currentLast, value); }
        private DirtyValue<string> _first;
        /// <summary>
        /// Tax4506 First [IRS4506.X2]
        /// </summary>
        public string First { get => _first; set => SetField(ref _first, value); }
        private DirtyValue<bool?> _formsSeriesTranscript;
        /// <summary>
        /// Tax4506 FormsSeriesTranscript [IRS4506.X50]
        /// </summary>
        public bool? FormsSeriesTranscript { get => _formsSeriesTranscript; set => SetField(ref _formsSeriesTranscript, value); }
        private DirtyValue<string> _historyId;
        /// <summary>
        /// Tax4506 HistoryId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HistoryId { get => _historyId; set => SetField(ref _historyId, value); }
        private DirtyValue<bool?> _historyIndicator;
        /// <summary>
        /// Tax4506 HistoryIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"false\":\"false\",\"true\":\"true\"}")]
        public bool? HistoryIndicator { get => _historyIndicator; set => SetField(ref _historyIndicator, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Tax4506 Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _ifTaxRecordNotFound;
        /// <summary>
        /// Tax4506 IfTaxRecordNotFound [IRS4506.X14]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"If we cannot find the tax return, we will refund the fee. If the refund should go to the third party listed on line 5, check here.\"}")]
        public bool? IfTaxRecordNotFound { get => _ifTaxRecordNotFound; set => SetField(ref _ifTaxRecordNotFound, value); }
        private DirtyValue<string> _last;
        /// <summary>
        /// Tax4506 Last [IRS4506.X3]
        /// </summary>
        public string Last { get => _last; set => SetField(ref _last, value); }
        private DirtyValue<DateTime?> _lastUpdatedDate;
        /// <summary>
        /// Tax4506 LastUpdatedDate
        /// </summary>
        public DateTime? LastUpdatedDate { get => _lastUpdatedDate; set => SetField(ref _lastUpdatedDate, value); }
        private DirtyValue<int?> _lastUpdatedHistory;
        /// <summary>
        /// Tax4506 LastUpdatedHistory
        /// </summary>
        public int? LastUpdatedHistory { get => _lastUpdatedHistory; set => SetField(ref _lastUpdatedHistory, value); }
        private DirtyValue<string> _lastUpdatedTime;
        /// <summary>
        /// Tax4506 LastUpdatedTime
        /// </summary>
        public string LastUpdatedTime { get => _lastUpdatedTime; set => SetField(ref _lastUpdatedTime, value); }
        private DirtyValue<bool?> _notifiedIrsIdentityTheftIndicator;
        /// <summary>
        /// Tax4506 NotifiedIrsIdentityTheftIndicator [IRS4506.X60]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? NotifiedIrsIdentityTheftIndicator { get => _notifiedIrsIdentityTheftIndicator; set => SetField(ref _notifiedIrsIdentityTheftIndicator, value); }
        private DirtyValue<int?> _numberOfPeriods;
        /// <summary>
        /// Tax4506 NumberOfPeriods [IRS4506.X31]
        /// </summary>
        public int? NumberOfPeriods { get => _numberOfPeriods; set => SetField(ref _numberOfPeriods, value); }
        private DirtyValue<StringEnumValue<Person>> _person;
        /// <summary>
        /// Tax4506 Person [IRS4506.X1]
        /// </summary>
        public StringEnumValue<Person> Person { get => _person; set => SetField(ref _person, value); }
        private DirtyValue<bool?> _recordOfAccount;
        /// <summary>
        /// Tax4506 RecordOfAccount [IRS4506.X48]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"c\"}")]
        public bool? RecordOfAccount { get => _recordOfAccount; set => SetField(ref _recordOfAccount, value); }
        private DirtyValue<string> _requestorPhoneNumber;
        /// <summary>
        /// Tax4506 RequestorPhoneNumber [IRS4506.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string RequestorPhoneNumber { get => _requestorPhoneNumber; set => SetField(ref _requestorPhoneNumber, value); }
        private DirtyValue<StringEnumValue<RequestorTitle>> _requestorTitle;
        /// <summary>
        /// Tax4506 RequestorTitle [IRS4506.X28]
        /// </summary>
        public StringEnumValue<RequestorTitle> RequestorTitle { get => _requestorTitle; set => SetField(ref _requestorTitle, value); }
        private DirtyValue<DateTime?> _requestYear1;
        /// <summary>
        /// Tax4506 RequestYear1 [IRS4506.X25]
        /// </summary>
        public DateTime? RequestYear1 { get => _requestYear1; set => SetField(ref _requestYear1, value); }
        private DirtyValue<DateTime?> _requestYear2;
        /// <summary>
        /// Tax4506 RequestYear2 [IRS4506.X26]
        /// </summary>
        public DateTime? RequestYear2 { get => _requestYear2; set => SetField(ref _requestYear2, value); }
        private DirtyValue<DateTime?> _requestYear3;
        /// <summary>
        /// Tax4506 RequestYear3 [IRS4506.X29]
        /// </summary>
        public DateTime? RequestYear3 { get => _requestYear3; set => SetField(ref _requestYear3, value); }
        private DirtyValue<DateTime?> _requestYear4;
        /// <summary>
        /// Tax4506 RequestYear4 [IRS4506.X30]
        /// </summary>
        public DateTime? RequestYear4 { get => _requestYear4; set => SetField(ref _requestYear4, value); }
        private DirtyValue<DateTime?> _requestYear5;
        /// <summary>
        /// Tax4506 RequestYear5 [IRS4506.X53]
        /// </summary>
        public DateTime? RequestYear5 { get => _requestYear5; set => SetField(ref _requestYear5, value); }
        private DirtyValue<DateTime?> _requestYear6;
        /// <summary>
        /// Tax4506 RequestYear6 [IRS4506.X54]
        /// </summary>
        public DateTime? RequestYear6 { get => _requestYear6; set => SetField(ref _requestYear6, value); }
        private DirtyValue<DateTime?> _requestYear7;
        /// <summary>
        /// Tax4506 RequestYear7 [IRS4506.X55]
        /// </summary>
        public DateTime? RequestYear7 { get => _requestYear7; set => SetField(ref _requestYear7, value); }
        private DirtyValue<DateTime?> _requestYear8;
        /// <summary>
        /// Tax4506 RequestYear8 [IRS4506.X56]
        /// </summary>
        public DateTime? RequestYear8 { get => _requestYear8; set => SetField(ref _requestYear8, value); }
        private DirtyValue<string> _returnAddress;
        /// <summary>
        /// Tax4506 ReturnAddress [IRS4506.X41]
        /// </summary>
        public string ReturnAddress { get => _returnAddress; set => SetField(ref _returnAddress, value); }
        private DirtyValue<string> _returnCity;
        /// <summary>
        /// Tax4506 ReturnCity [IRS4506.X42]
        /// </summary>
        public string ReturnCity { get => _returnCity; set => SetField(ref _returnCity, value); }
        private DirtyValue<StringEnumValue<State>> _returnState;
        /// <summary>
        /// Tax4506 ReturnState [IRS4506.X43]
        /// </summary>
        public StringEnumValue<State> ReturnState { get => _returnState; set => SetField(ref _returnState, value); }
        private DirtyValue<bool?> _returnTranscript;
        /// <summary>
        /// Tax4506 ReturnTranscript [IRS4506.X46]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"a\"}")]
        public bool? ReturnTranscript { get => _returnTranscript; set => SetField(ref _returnTranscript, value); }
        private DirtyValue<string> _returnZip;
        /// <summary>
        /// Tax4506 ReturnZip [IRS4506.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string ReturnZip { get => _returnZip; set => SetField(ref _returnZip, value); }
        private DirtyValue<string> _selectedRecordNumber;
        /// <summary>
        /// IRS - Selected Record Number [IRS4506.X98]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "IRS - Selected Record Number")]
        public string SelectedRecordNumber { get => _selectedRecordNumber; set => SetField(ref _selectedRecordNumber, value); }
        private DirtyValue<string> _sendAddress;
        /// <summary>
        /// Tax4506 SendAddress [IRS4506.X10]
        /// </summary>
        public string SendAddress { get => _sendAddress; set => SetField(ref _sendAddress, value); }
        private DirtyValue<string> _sendCity;
        /// <summary>
        /// Tax4506 SendCity [IRS4506.X11]
        /// </summary>
        public string SendCity { get => _sendCity; set => SetField(ref _sendCity, value); }
        private DirtyValue<string> _sendFirst;
        /// <summary>
        /// Tax4506 SendFirst [IRS4506.X8]
        /// </summary>
        public string SendFirst { get => _sendFirst; set => SetField(ref _sendFirst, value); }
        private DirtyValue<string> _sendLast;
        /// <summary>
        /// Tax4506 SendLast [IRS4506.X9]
        /// </summary>
        public string SendLast { get => _sendLast; set => SetField(ref _sendLast, value); }
        private DirtyValue<string> _sendPhone;
        /// <summary>
        /// Tax4506 SendPhone [IRS4506.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string SendPhone { get => _sendPhone; set => SetField(ref _sendPhone, value); }
        private DirtyValue<StringEnumValue<State>> _sendState;
        /// <summary>
        /// Tax4506 SendState [IRS4506.X12]
        /// </summary>
        public StringEnumValue<State> SendState { get => _sendState; set => SetField(ref _sendState, value); }
        private DirtyValue<string> _sendZip;
        /// <summary>
        /// Tax4506 SendZip [IRS4506.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string SendZip { get => _sendZip; set => SetField(ref _sendZip, value); }
        private DirtyValue<bool?> _signatoryAttestation;
        /// <summary>
        /// Tax4506 SignatoryAttestation
        /// </summary>
        public bool? SignatoryAttestation { get => _signatoryAttestation; set => SetField(ref _signatoryAttestation, value); }
        private DirtyValue<bool?> _signatoryAttestationT;
        /// <summary>
        /// IRS 4506T - Signatory Attestation [IRS4506.X62]
        /// </summary>
        [LoanFieldProperty(Description = "IRS 4506T - Signatory Attestation")]
        public bool? SignatoryAttestationT { get => _signatoryAttestationT; set => SetField(ref _signatoryAttestationT, value); }
        private DirtyValue<string> _spouseFirst;
        /// <summary>
        /// Tax4506 SpouseFirst [IRS4506.X6]
        /// </summary>
        public string SpouseFirst { get => _spouseFirst; set => SetField(ref _spouseFirst, value); }
        private DirtyValue<string> _spouseLast;
        /// <summary>
        /// Tax4506 SpouseLast [IRS4506.X7]
        /// </summary>
        public string SpouseLast { get => _spouseLast; set => SetField(ref _spouseLast, value); }
        private DirtyValue<string> _spouseSSN;
        /// <summary>
        /// Tax4506 SpouseSSN [IRS4506.X5]
        /// </summary>
        public string SpouseSSN { get => _spouseSSN; set => SetField(ref _spouseSSN, value); }
        private DirtyValue<bool?> _spouseUseEIN;
        /// <summary>
        /// Tax4506 SpouseUseEIN [IRS4506.X58]
        /// </summary>
        public bool? SpouseUseEIN { get => _spouseUseEIN; set => SetField(ref _spouseUseEIN, value); }
        private DirtyValue<string> _sSN;
        /// <summary>
        /// Tax4506 SSN [IRS4506.X4]
        /// </summary>
        public string SSN { get => _sSN; set => SetField(ref _sSN, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// Tax4506 State [IRS4506.X37]
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
        private DirtyValue<int?> _tax4506Index;
        /// <summary>
        /// Tax4506 Tax4506Index
        /// </summary>
        public int? Tax4506Index { get => _tax4506Index; set => SetField(ref _tax4506Index, value); }
        private DirtyValue<bool?> _tax4506TIndicator;
        /// <summary>
        /// Tax4506 Tax4506TIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"false\":\"false\",\"true\":\"true\"}")]
        public bool? Tax4506TIndicator { get => _tax4506TIndicator; set => SetField(ref _tax4506TIndicator, value); }
        private DirtyValue<string> _taxFormNumber;
        /// <summary>
        /// Tax4506 TaxFormNumber [IRS4506.X24]
        /// </summary>
        public string TaxFormNumber { get => _taxFormNumber; set => SetField(ref _taxFormNumber, value); }
        private DirtyValue<bool?> _theseCopiesMustBeCertified;
        /// <summary>
        /// Tax4506 TheseCopiesMustBeCertified [IRS4506.X18]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Copies must be certified for court or administrative proceedings\"}")]
        public bool? TheseCopiesMustBeCertified { get => _theseCopiesMustBeCertified; set => SetField(ref _theseCopiesMustBeCertified, value); }
        private DirtyValue<decimal?> _totalCost;
        /// <summary>
        /// Tax4506 TotalCost [IRS4506.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalCost { get => _totalCost; set => SetField(ref _totalCost, value); }
        private DirtyValue<bool?> _useEIN;
        /// <summary>
        /// Tax4506 UseEIN [IRS4506.X57]
        /// </summary>
        public bool? UseEIN { get => _useEIN; set => SetField(ref _useEIN, value); }
        private DirtyValue<bool?> _useWellsFargoRules;
        /// <summary>
        /// Tax4506 UseWellsFargoRules [IRS4506.X59]
        /// </summary>
        public bool? UseWellsFargoRules { get => _useWellsFargoRules; set => SetField(ref _useWellsFargoRules, value); }
        private DirtyValue<bool?> _verificationOfNonfiling;
        /// <summary>
        /// Tax4506 VerificationOfNonfiling [IRS4506.X49]
        /// </summary>
        public bool? VerificationOfNonfiling { get => _verificationOfNonfiling; set => SetField(ref _verificationOfNonfiling, value); }
        private DirtyValue<string> _zip;
        /// <summary>
        /// Tax4506 Zip [IRS4506.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string Zip { get => _zip; set => SetField(ref _zip, value); }
    }
}