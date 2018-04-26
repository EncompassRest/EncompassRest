using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Tax4506
    /// </summary>
    public sealed partial class Tax4506 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _accountTranscript;
        /// <summary>
        /// Tax4506 AccountTranscript [IRS4506.X47]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"b\"}")]
        public bool? AccountTranscript { get => _accountTranscript; set => _accountTranscript = value; }
        private DirtyValue<string> _address;
        /// <summary>
        /// Tax4506 Address [IRS4506.X35]
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// Tax4506 City [IRS4506.X36]
        /// </summary>
        public string City { get => _city; set => _city = value; }
        private DirtyValue<decimal?> _costForEachPeriod;
        /// <summary>
        /// Tax4506 CostForEachPeriod [IRS4506.X52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CostForEachPeriod { get => _costForEachPeriod; set => _costForEachPeriod = value; }
        private DirtyValue<string> _currentFirst;
        /// <summary>
        /// Tax4506 CurrentFirst [IRS4506.X39]
        /// </summary>
        public string CurrentFirst { get => _currentFirst; set => _currentFirst = value; }
        private DirtyValue<string> _currentLast;
        /// <summary>
        /// Tax4506 CurrentLast [IRS4506.X40]
        /// </summary>
        public string CurrentLast { get => _currentLast; set => _currentLast = value; }
        private DirtyValue<string> _first;
        /// <summary>
        /// Tax4506 First [IRS4506.X2]
        /// </summary>
        public string First { get => _first; set => _first = value; }
        private DirtyValue<bool?> _formsSeriesTranscript;
        /// <summary>
        /// Tax4506 FormsSeriesTranscript [IRS4506.X50]
        /// </summary>
        public bool? FormsSeriesTranscript { get => _formsSeriesTranscript; set => _formsSeriesTranscript = value; }
        private DirtyValue<string> _historyId;
        /// <summary>
        /// Tax4506 HistoryId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HistoryId { get => _historyId; set => _historyId = value; }
        private DirtyValue<bool?> _historyIndicator;
        /// <summary>
        /// Tax4506 HistoryIndicator
        /// </summary>
        public bool? HistoryIndicator { get => _historyIndicator; set => _historyIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Tax4506 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _ifTaxRecordNotFound;
        /// <summary>
        /// Tax4506 IfTaxRecordNotFound [IRS4506.X14]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"If we cannot find the tax return, we will refund the fee. If the refund should go to the third party listed on line 5, check here.\"}")]
        public bool? IfTaxRecordNotFound { get => _ifTaxRecordNotFound; set => _ifTaxRecordNotFound = value; }
        private DirtyValue<string> _last;
        /// <summary>
        /// Tax4506 Last [IRS4506.X3]
        /// </summary>
        public string Last { get => _last; set => _last = value; }
        private DirtyValue<DateTime?> _lastUpdatedDate;
        /// <summary>
        /// Tax4506 LastUpdatedDate
        /// </summary>
        public DateTime? LastUpdatedDate { get => _lastUpdatedDate; set => _lastUpdatedDate = value; }
        private DirtyValue<int?> _lastUpdatedHistory;
        /// <summary>
        /// Tax4506 LastUpdatedHistory
        /// </summary>
        public int? LastUpdatedHistory { get => _lastUpdatedHistory; set => _lastUpdatedHistory = value; }
        private DirtyValue<string> _lastUpdatedTime;
        /// <summary>
        /// Tax4506 LastUpdatedTime
        /// </summary>
        public string LastUpdatedTime { get => _lastUpdatedTime; set => _lastUpdatedTime = value; }
        private DirtyValue<bool?> _notifiedIrsIdentityTheftIndicator;
        /// <summary>
        /// Tax4506 NotifiedIrsIdentityTheftIndicator [IRS4506.X60]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? NotifiedIrsIdentityTheftIndicator { get => _notifiedIrsIdentityTheftIndicator; set => _notifiedIrsIdentityTheftIndicator = value; }
        private DirtyValue<int?> _numberOfPeriods;
        /// <summary>
        /// Tax4506 NumberOfPeriods [IRS4506.X31]
        /// </summary>
        public int? NumberOfPeriods { get => _numberOfPeriods; set => _numberOfPeriods = value; }
        private DirtyValue<StringEnumValue<Person>> _person;
        /// <summary>
        /// Tax4506 Person [IRS4506.X1]
        /// </summary>
        public StringEnumValue<Person> Person { get => _person; set => _person = value; }
        private DirtyValue<bool?> _recordOfAccount;
        /// <summary>
        /// Tax4506 RecordOfAccount [IRS4506.X48]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"c\"}")]
        public bool? RecordOfAccount { get => _recordOfAccount; set => _recordOfAccount = value; }
        private DirtyValue<string> _requestorPhoneNumber;
        /// <summary>
        /// Tax4506 RequestorPhoneNumber [IRS4506.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string RequestorPhoneNumber { get => _requestorPhoneNumber; set => _requestorPhoneNumber = value; }
        private DirtyValue<StringEnumValue<RequestorTitle>> _requestorTitle;
        /// <summary>
        /// Tax4506 RequestorTitle [IRS4506.X28]
        /// </summary>
        public StringEnumValue<RequestorTitle> RequestorTitle { get => _requestorTitle; set => _requestorTitle = value; }
        private DirtyValue<DateTime?> _requestYear1;
        /// <summary>
        /// Tax4506 RequestYear1 [IRS4506.X25]
        /// </summary>
        public DateTime? RequestYear1 { get => _requestYear1; set => _requestYear1 = value; }
        private DirtyValue<DateTime?> _requestYear2;
        /// <summary>
        /// Tax4506 RequestYear2 [IRS4506.X26]
        /// </summary>
        public DateTime? RequestYear2 { get => _requestYear2; set => _requestYear2 = value; }
        private DirtyValue<DateTime?> _requestYear3;
        /// <summary>
        /// Tax4506 RequestYear3 [IRS4506.X29]
        /// </summary>
        public DateTime? RequestYear3 { get => _requestYear3; set => _requestYear3 = value; }
        private DirtyValue<DateTime?> _requestYear4;
        /// <summary>
        /// Tax4506 RequestYear4 [IRS4506.X30]
        /// </summary>
        public DateTime? RequestYear4 { get => _requestYear4; set => _requestYear4 = value; }
        private DirtyValue<DateTime?> _requestYear5;
        /// <summary>
        /// Tax4506 RequestYear5 [IRS4506.X53]
        /// </summary>
        public DateTime? RequestYear5 { get => _requestYear5; set => _requestYear5 = value; }
        private DirtyValue<DateTime?> _requestYear6;
        /// <summary>
        /// Tax4506 RequestYear6 [IRS4506.X54]
        /// </summary>
        public DateTime? RequestYear6 { get => _requestYear6; set => _requestYear6 = value; }
        private DirtyValue<DateTime?> _requestYear7;
        /// <summary>
        /// Tax4506 RequestYear7 [IRS4506.X55]
        /// </summary>
        public DateTime? RequestYear7 { get => _requestYear7; set => _requestYear7 = value; }
        private DirtyValue<DateTime?> _requestYear8;
        /// <summary>
        /// Tax4506 RequestYear8 [IRS4506.X56]
        /// </summary>
        public DateTime? RequestYear8 { get => _requestYear8; set => _requestYear8 = value; }
        private DirtyValue<string> _returnAddress;
        /// <summary>
        /// Tax4506 ReturnAddress [IRS4506.X41]
        /// </summary>
        public string ReturnAddress { get => _returnAddress; set => _returnAddress = value; }
        private DirtyValue<string> _returnCity;
        /// <summary>
        /// Tax4506 ReturnCity [IRS4506.X42]
        /// </summary>
        public string ReturnCity { get => _returnCity; set => _returnCity = value; }
        private DirtyValue<string> _returnState;
        /// <summary>
        /// Tax4506 ReturnState [IRS4506.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE)]
        public string ReturnState { get => _returnState; set => _returnState = value; }
        private DirtyValue<bool?> _returnTranscript;
        /// <summary>
        /// Tax4506 ReturnTranscript [IRS4506.X46]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"a\"}")]
        public bool? ReturnTranscript { get => _returnTranscript; set => _returnTranscript = value; }
        private DirtyValue<string> _returnZip;
        /// <summary>
        /// Tax4506 ReturnZip [IRS4506.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string ReturnZip { get => _returnZip; set => _returnZip = value; }
        private DirtyValue<string> _selectedRecordNumber;
        /// <summary>
        /// IRS - Selected Record Number [IRS4506.X98]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "IRS - Selected Record Number")]
        public string SelectedRecordNumber { get => _selectedRecordNumber; set => _selectedRecordNumber = value; }
        private DirtyValue<string> _sendAddress;
        /// <summary>
        /// Tax4506 SendAddress [IRS4506.X10]
        /// </summary>
        public string SendAddress { get => _sendAddress; set => _sendAddress = value; }
        private DirtyValue<string> _sendCity;
        /// <summary>
        /// Tax4506 SendCity [IRS4506.X11]
        /// </summary>
        public string SendCity { get => _sendCity; set => _sendCity = value; }
        private DirtyValue<string> _sendFirst;
        /// <summary>
        /// Tax4506 SendFirst [IRS4506.X8]
        /// </summary>
        public string SendFirst { get => _sendFirst; set => _sendFirst = value; }
        private DirtyValue<string> _sendLast;
        /// <summary>
        /// Tax4506 SendLast [IRS4506.X9]
        /// </summary>
        public string SendLast { get => _sendLast; set => _sendLast = value; }
        private DirtyValue<string> _sendPhone;
        /// <summary>
        /// Tax4506 SendPhone [IRS4506.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string SendPhone { get => _sendPhone; set => _sendPhone = value; }
        private DirtyValue<string> _sendState;
        /// <summary>
        /// Tax4506 SendState [IRS4506.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE)]
        public string SendState { get => _sendState; set => _sendState = value; }
        private DirtyValue<string> _sendZip;
        /// <summary>
        /// Tax4506 SendZip [IRS4506.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string SendZip { get => _sendZip; set => _sendZip = value; }
        private DirtyValue<bool?> _signatoryAttestation;
        /// <summary>
        /// Tax4506 SignatoryAttestation
        /// </summary>
        public bool? SignatoryAttestation { get => _signatoryAttestation; set => _signatoryAttestation = value; }
        private DirtyValue<bool?> _signatoryAttestationT;
        /// <summary>
        /// IRS 4506T - Signatory Attestation [IRS4506.X62]
        /// </summary>
        [LoanFieldProperty(Description = "IRS 4506T - Signatory Attestation")]
        public bool? SignatoryAttestationT { get => _signatoryAttestationT; set => _signatoryAttestationT = value; }
        private DirtyValue<string> _spouseFirst;
        /// <summary>
        /// Tax4506 SpouseFirst [IRS4506.X6]
        /// </summary>
        public string SpouseFirst { get => _spouseFirst; set => _spouseFirst = value; }
        private DirtyValue<string> _spouseLast;
        /// <summary>
        /// Tax4506 SpouseLast [IRS4506.X7]
        /// </summary>
        public string SpouseLast { get => _spouseLast; set => _spouseLast = value; }
        private DirtyValue<string> _spouseSSN;
        /// <summary>
        /// Tax4506 SpouseSSN [IRS4506.X5]
        /// </summary>
        public string SpouseSSN { get => _spouseSSN; set => _spouseSSN = value; }
        private DirtyValue<bool?> _spouseUseEIN;
        /// <summary>
        /// Tax4506 SpouseUseEIN [IRS4506.X58]
        /// </summary>
        public bool? SpouseUseEIN { get => _spouseUseEIN; set => _spouseUseEIN = value; }
        private DirtyValue<string> _sSN;
        /// <summary>
        /// Tax4506 SSN [IRS4506.X4]
        /// </summary>
        public string SSN { get => _sSN; set => _sSN = value; }
        private DirtyValue<string> _state;
        /// <summary>
        /// Tax4506 State [IRS4506.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE)]
        public string State { get => _state; set => _state = value; }
        private DirtyValue<int?> _tax4506Index;
        /// <summary>
        /// Tax4506 Tax4506Index
        /// </summary>
        public int? Tax4506Index { get => _tax4506Index; set => _tax4506Index = value; }
        private DirtyValue<bool?> _tax4506TIndicator;
        /// <summary>
        /// Tax4506 Tax4506TIndicator
        /// </summary>
        public bool? Tax4506TIndicator { get => _tax4506TIndicator; set => _tax4506TIndicator = value; }
        private DirtyValue<string> _taxFormNumber;
        /// <summary>
        /// Tax4506 TaxFormNumber [IRS4506.X24]
        /// </summary>
        public string TaxFormNumber { get => _taxFormNumber; set => _taxFormNumber = value; }
        private DirtyValue<bool?> _theseCopiesMustBeCertified;
        /// <summary>
        /// Tax4506 TheseCopiesMustBeCertified [IRS4506.X18]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Copies must be certified for court or administrative proceedings\"}")]
        public bool? TheseCopiesMustBeCertified { get => _theseCopiesMustBeCertified; set => _theseCopiesMustBeCertified = value; }
        private DirtyValue<decimal?> _totalCost;
        /// <summary>
        /// Tax4506 TotalCost [IRS4506.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalCost { get => _totalCost; set => _totalCost = value; }
        private DirtyValue<bool?> _useEIN;
        /// <summary>
        /// Tax4506 UseEIN [IRS4506.X57]
        /// </summary>
        public bool? UseEIN { get => _useEIN; set => _useEIN = value; }
        private DirtyValue<bool?> _useWellsFargoRules;
        /// <summary>
        /// Tax4506 UseWellsFargoRules [IRS4506.X59]
        /// </summary>
        public bool? UseWellsFargoRules { get => _useWellsFargoRules; set => _useWellsFargoRules = value; }
        private DirtyValue<bool?> _verificationOfNonfiling;
        /// <summary>
        /// Tax4506 VerificationOfNonfiling [IRS4506.X49]
        /// </summary>
        public bool? VerificationOfNonfiling { get => _verificationOfNonfiling; set => _verificationOfNonfiling = value; }
        private DirtyValue<string> _zip;
        /// <summary>
        /// Tax4506 Zip [IRS4506.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string Zip { get => _zip; set => _zip = value; }
        internal override bool DirtyInternal
        {
            get => _accountTranscript.Dirty
                || _address.Dirty
                || _city.Dirty
                || _costForEachPeriod.Dirty
                || _currentFirst.Dirty
                || _currentLast.Dirty
                || _first.Dirty
                || _formsSeriesTranscript.Dirty
                || _historyId.Dirty
                || _historyIndicator.Dirty
                || _id.Dirty
                || _ifTaxRecordNotFound.Dirty
                || _last.Dirty
                || _lastUpdatedDate.Dirty
                || _lastUpdatedHistory.Dirty
                || _lastUpdatedTime.Dirty
                || _notifiedIrsIdentityTheftIndicator.Dirty
                || _numberOfPeriods.Dirty
                || _person.Dirty
                || _recordOfAccount.Dirty
                || _requestorPhoneNumber.Dirty
                || _requestorTitle.Dirty
                || _requestYear1.Dirty
                || _requestYear2.Dirty
                || _requestYear3.Dirty
                || _requestYear4.Dirty
                || _requestYear5.Dirty
                || _requestYear6.Dirty
                || _requestYear7.Dirty
                || _requestYear8.Dirty
                || _returnAddress.Dirty
                || _returnCity.Dirty
                || _returnState.Dirty
                || _returnTranscript.Dirty
                || _returnZip.Dirty
                || _selectedRecordNumber.Dirty
                || _sendAddress.Dirty
                || _sendCity.Dirty
                || _sendFirst.Dirty
                || _sendLast.Dirty
                || _sendPhone.Dirty
                || _sendState.Dirty
                || _sendZip.Dirty
                || _signatoryAttestation.Dirty
                || _signatoryAttestationT.Dirty
                || _spouseFirst.Dirty
                || _spouseLast.Dirty
                || _spouseSSN.Dirty
                || _spouseUseEIN.Dirty
                || _sSN.Dirty
                || _state.Dirty
                || _tax4506Index.Dirty
                || _tax4506TIndicator.Dirty
                || _taxFormNumber.Dirty
                || _theseCopiesMustBeCertified.Dirty
                || _totalCost.Dirty
                || _useEIN.Dirty
                || _useWellsFargoRules.Dirty
                || _verificationOfNonfiling.Dirty
                || _zip.Dirty;
            set
            {
                _accountTranscript.Dirty = value;
                _address.Dirty = value;
                _city.Dirty = value;
                _costForEachPeriod.Dirty = value;
                _currentFirst.Dirty = value;
                _currentLast.Dirty = value;
                _first.Dirty = value;
                _formsSeriesTranscript.Dirty = value;
                _historyId.Dirty = value;
                _historyIndicator.Dirty = value;
                _id.Dirty = value;
                _ifTaxRecordNotFound.Dirty = value;
                _last.Dirty = value;
                _lastUpdatedDate.Dirty = value;
                _lastUpdatedHistory.Dirty = value;
                _lastUpdatedTime.Dirty = value;
                _notifiedIrsIdentityTheftIndicator.Dirty = value;
                _numberOfPeriods.Dirty = value;
                _person.Dirty = value;
                _recordOfAccount.Dirty = value;
                _requestorPhoneNumber.Dirty = value;
                _requestorTitle.Dirty = value;
                _requestYear1.Dirty = value;
                _requestYear2.Dirty = value;
                _requestYear3.Dirty = value;
                _requestYear4.Dirty = value;
                _requestYear5.Dirty = value;
                _requestYear6.Dirty = value;
                _requestYear7.Dirty = value;
                _requestYear8.Dirty = value;
                _returnAddress.Dirty = value;
                _returnCity.Dirty = value;
                _returnState.Dirty = value;
                _returnTranscript.Dirty = value;
                _returnZip.Dirty = value;
                _selectedRecordNumber.Dirty = value;
                _sendAddress.Dirty = value;
                _sendCity.Dirty = value;
                _sendFirst.Dirty = value;
                _sendLast.Dirty = value;
                _sendPhone.Dirty = value;
                _sendState.Dirty = value;
                _sendZip.Dirty = value;
                _signatoryAttestation.Dirty = value;
                _signatoryAttestationT.Dirty = value;
                _spouseFirst.Dirty = value;
                _spouseLast.Dirty = value;
                _spouseSSN.Dirty = value;
                _spouseUseEIN.Dirty = value;
                _sSN.Dirty = value;
                _state.Dirty = value;
                _tax4506Index.Dirty = value;
                _tax4506TIndicator.Dirty = value;
                _taxFormNumber.Dirty = value;
                _theseCopiesMustBeCertified.Dirty = value;
                _totalCost.Dirty = value;
                _useEIN.Dirty = value;
                _useWellsFargoRules.Dirty = value;
                _verificationOfNonfiling.Dirty = value;
                _zip.Dirty = value;
            }
        }
    }
}