using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Tax4506 : IClean
    {
        private Value<bool?> _accountTranscript;
        public bool? AccountTranscript { get { return _accountTranscript; } set { _accountTranscript = value; } }
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<decimal?> _costForEachPeriod;
        public decimal? CostForEachPeriod { get { return _costForEachPeriod; } set { _costForEachPeriod = value; } }
        private Value<string> _currentFirst;
        public string CurrentFirst { get { return _currentFirst; } set { _currentFirst = value; } }
        private Value<string> _currentLast;
        public string CurrentLast { get { return _currentLast; } set { _currentLast = value; } }
        private Value<string> _first;
        public string First { get { return _first; } set { _first = value; } }
        private Value<bool?> _formsSeriesTranscript;
        public bool? FormsSeriesTranscript { get { return _formsSeriesTranscript; } set { _formsSeriesTranscript = value; } }
        private Value<string> _historyId;
        public string HistoryId { get { return _historyId; } set { _historyId = value; } }
        private Value<bool?> _historyIndicator;
        public bool? HistoryIndicator { get { return _historyIndicator; } set { _historyIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _ifTaxRecordNotFound;
        public bool? IfTaxRecordNotFound { get { return _ifTaxRecordNotFound; } set { _ifTaxRecordNotFound = value; } }
        private Value<string> _last;
        public string Last { get { return _last; } set { _last = value; } }
        private Value<DateTime?> _lastUpdatedDate;
        public DateTime? LastUpdatedDate { get { return _lastUpdatedDate; } set { _lastUpdatedDate = value; } }
        private Value<int?> _lastUpdatedHistory;
        public int? LastUpdatedHistory { get { return _lastUpdatedHistory; } set { _lastUpdatedHistory = value; } }
        private Value<string> _lastUpdatedTime;
        public string LastUpdatedTime { get { return _lastUpdatedTime; } set { _lastUpdatedTime = value; } }
        private Value<bool?> _notifiedIrsIdentityTheftIndicator;
        public bool? NotifiedIrsIdentityTheftIndicator { get { return _notifiedIrsIdentityTheftIndicator; } set { _notifiedIrsIdentityTheftIndicator = value; } }
        private Value<int?> _numberOfPeriods;
        public int? NumberOfPeriods { get { return _numberOfPeriods; } set { _numberOfPeriods = value; } }
        private Value<string> _person;
        public string Person { get { return _person; } set { _person = value; } }
        private Value<bool?> _recordOfAccount;
        public bool? RecordOfAccount { get { return _recordOfAccount; } set { _recordOfAccount = value; } }
        private Value<string> _requestorPhoneNumber;
        public string RequestorPhoneNumber { get { return _requestorPhoneNumber; } set { _requestorPhoneNumber = value; } }
        private Value<string> _requestorTitle;
        public string RequestorTitle { get { return _requestorTitle; } set { _requestorTitle = value; } }
        private Value<DateTime?> _requestYear1;
        public DateTime? RequestYear1 { get { return _requestYear1; } set { _requestYear1 = value; } }
        private Value<DateTime?> _requestYear2;
        public DateTime? RequestYear2 { get { return _requestYear2; } set { _requestYear2 = value; } }
        private Value<DateTime?> _requestYear3;
        public DateTime? RequestYear3 { get { return _requestYear3; } set { _requestYear3 = value; } }
        private Value<DateTime?> _requestYear4;
        public DateTime? RequestYear4 { get { return _requestYear4; } set { _requestYear4 = value; } }
        private Value<DateTime?> _requestYear5;
        public DateTime? RequestYear5 { get { return _requestYear5; } set { _requestYear5 = value; } }
        private Value<DateTime?> _requestYear6;
        public DateTime? RequestYear6 { get { return _requestYear6; } set { _requestYear6 = value; } }
        private Value<DateTime?> _requestYear7;
        public DateTime? RequestYear7 { get { return _requestYear7; } set { _requestYear7 = value; } }
        private Value<DateTime?> _requestYear8;
        public DateTime? RequestYear8 { get { return _requestYear8; } set { _requestYear8 = value; } }
        private Value<string> _returnAddress;
        public string ReturnAddress { get { return _returnAddress; } set { _returnAddress = value; } }
        private Value<string> _returnCity;
        public string ReturnCity { get { return _returnCity; } set { _returnCity = value; } }
        private Value<string> _returnState;
        public string ReturnState { get { return _returnState; } set { _returnState = value; } }
        private Value<bool?> _returnTranscript;
        public bool? ReturnTranscript { get { return _returnTranscript; } set { _returnTranscript = value; } }
        private Value<string> _returnZip;
        public string ReturnZip { get { return _returnZip; } set { _returnZip = value; } }
        private Value<string> _selectedRecordNumber;
        public string SelectedRecordNumber { get { return _selectedRecordNumber; } set { _selectedRecordNumber = value; } }
        private Value<string> _sendAddress;
        public string SendAddress { get { return _sendAddress; } set { _sendAddress = value; } }
        private Value<string> _sendCity;
        public string SendCity { get { return _sendCity; } set { _sendCity = value; } }
        private Value<string> _sendFirst;
        public string SendFirst { get { return _sendFirst; } set { _sendFirst = value; } }
        private Value<string> _sendLast;
        public string SendLast { get { return _sendLast; } set { _sendLast = value; } }
        private Value<string> _sendPhone;
        public string SendPhone { get { return _sendPhone; } set { _sendPhone = value; } }
        private Value<string> _sendState;
        public string SendState { get { return _sendState; } set { _sendState = value; } }
        private Value<string> _sendZip;
        public string SendZip { get { return _sendZip; } set { _sendZip = value; } }
        private Value<bool?> _signatoryAttestation;
        public bool? SignatoryAttestation { get { return _signatoryAttestation; } set { _signatoryAttestation = value; } }
        private Value<bool?> _signatoryAttestationT;
        public bool? SignatoryAttestationT { get { return _signatoryAttestationT; } set { _signatoryAttestationT = value; } }
        private Value<string> _spouseFirst;
        public string SpouseFirst { get { return _spouseFirst; } set { _spouseFirst = value; } }
        private Value<string> _spouseLast;
        public string SpouseLast { get { return _spouseLast; } set { _spouseLast = value; } }
        private Value<string> _spouseSSN;
        public string SpouseSSN { get { return _spouseSSN; } set { _spouseSSN = value; } }
        private Value<bool?> _spouseUseEIN;
        public bool? SpouseUseEIN { get { return _spouseUseEIN; } set { _spouseUseEIN = value; } }
        private Value<string> _sSN;
        public string SSN { get { return _sSN; } set { _sSN = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<int?> _tax4506Index;
        public int? Tax4506Index { get { return _tax4506Index; } set { _tax4506Index = value; } }
        private Value<bool?> _tax4506TIndicator;
        public bool? Tax4506TIndicator { get { return _tax4506TIndicator; } set { _tax4506TIndicator = value; } }
        private Value<string> _taxFormNumber;
        public string TaxFormNumber { get { return _taxFormNumber; } set { _taxFormNumber = value; } }
        private Value<bool?> _theseCopiesMustBeCertified;
        public bool? TheseCopiesMustBeCertified { get { return _theseCopiesMustBeCertified; } set { _theseCopiesMustBeCertified = value; } }
        private Value<decimal?> _totalCost;
        public decimal? TotalCost { get { return _totalCost; } set { _totalCost = value; } }
        private Value<bool?> _useEIN;
        public bool? UseEIN { get { return _useEIN; } set { _useEIN = value; } }
        private Value<bool?> _useWellsFargoRules;
        public bool? UseWellsFargoRules { get { return _useWellsFargoRules; } set { _useWellsFargoRules = value; } }
        private Value<bool?> _verificationOfNonfiling;
        public bool? VerificationOfNonfiling { get { return _verificationOfNonfiling; } set { _verificationOfNonfiling = value; } }
        private Value<string> _zip;
        public string Zip { get { return _zip; } set { _zip = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accountTranscript.Clean
                    && _address.Clean
                    && _city.Clean
                    && _costForEachPeriod.Clean
                    && _currentFirst.Clean
                    && _currentLast.Clean
                    && _first.Clean
                    && _formsSeriesTranscript.Clean
                    && _historyId.Clean
                    && _historyIndicator.Clean
                    && _id.Clean
                    && _ifTaxRecordNotFound.Clean
                    && _last.Clean
                    && _lastUpdatedDate.Clean
                    && _lastUpdatedHistory.Clean
                    && _lastUpdatedTime.Clean
                    && _notifiedIrsIdentityTheftIndicator.Clean
                    && _numberOfPeriods.Clean
                    && _person.Clean
                    && _recordOfAccount.Clean
                    && _requestorPhoneNumber.Clean
                    && _requestorTitle.Clean
                    && _requestYear1.Clean
                    && _requestYear2.Clean
                    && _requestYear3.Clean
                    && _requestYear4.Clean
                    && _requestYear5.Clean
                    && _requestYear6.Clean
                    && _requestYear7.Clean
                    && _requestYear8.Clean
                    && _returnAddress.Clean
                    && _returnCity.Clean
                    && _returnState.Clean
                    && _returnTranscript.Clean
                    && _returnZip.Clean
                    && _selectedRecordNumber.Clean
                    && _sendAddress.Clean
                    && _sendCity.Clean
                    && _sendFirst.Clean
                    && _sendLast.Clean
                    && _sendPhone.Clean
                    && _sendState.Clean
                    && _sendZip.Clean
                    && _signatoryAttestation.Clean
                    && _signatoryAttestationT.Clean
                    && _spouseFirst.Clean
                    && _spouseLast.Clean
                    && _spouseSSN.Clean
                    && _spouseUseEIN.Clean
                    && _sSN.Clean
                    && _state.Clean
                    && _tax4506Index.Clean
                    && _tax4506TIndicator.Clean
                    && _taxFormNumber.Clean
                    && _theseCopiesMustBeCertified.Clean
                    && _totalCost.Clean
                    && _useEIN.Clean
                    && _useWellsFargoRules.Clean
                    && _verificationOfNonfiling.Clean
                    && _zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var accountTranscript = _accountTranscript; accountTranscript.Clean = value; _accountTranscript = accountTranscript;
                var address = _address; address.Clean = value; _address = address;
                var city = _city; city.Clean = value; _city = city;
                var costForEachPeriod = _costForEachPeriod; costForEachPeriod.Clean = value; _costForEachPeriod = costForEachPeriod;
                var currentFirst = _currentFirst; currentFirst.Clean = value; _currentFirst = currentFirst;
                var currentLast = _currentLast; currentLast.Clean = value; _currentLast = currentLast;
                var first = _first; first.Clean = value; _first = first;
                var formsSeriesTranscript = _formsSeriesTranscript; formsSeriesTranscript.Clean = value; _formsSeriesTranscript = formsSeriesTranscript;
                var historyId = _historyId; historyId.Clean = value; _historyId = historyId;
                var historyIndicator = _historyIndicator; historyIndicator.Clean = value; _historyIndicator = historyIndicator;
                var id = _id; id.Clean = value; _id = id;
                var ifTaxRecordNotFound = _ifTaxRecordNotFound; ifTaxRecordNotFound.Clean = value; _ifTaxRecordNotFound = ifTaxRecordNotFound;
                var last = _last; last.Clean = value; _last = last;
                var lastUpdatedDate = _lastUpdatedDate; lastUpdatedDate.Clean = value; _lastUpdatedDate = lastUpdatedDate;
                var lastUpdatedHistory = _lastUpdatedHistory; lastUpdatedHistory.Clean = value; _lastUpdatedHistory = lastUpdatedHistory;
                var lastUpdatedTime = _lastUpdatedTime; lastUpdatedTime.Clean = value; _lastUpdatedTime = lastUpdatedTime;
                var notifiedIrsIdentityTheftIndicator = _notifiedIrsIdentityTheftIndicator; notifiedIrsIdentityTheftIndicator.Clean = value; _notifiedIrsIdentityTheftIndicator = notifiedIrsIdentityTheftIndicator;
                var numberOfPeriods = _numberOfPeriods; numberOfPeriods.Clean = value; _numberOfPeriods = numberOfPeriods;
                var person = _person; person.Clean = value; _person = person;
                var recordOfAccount = _recordOfAccount; recordOfAccount.Clean = value; _recordOfAccount = recordOfAccount;
                var requestorPhoneNumber = _requestorPhoneNumber; requestorPhoneNumber.Clean = value; _requestorPhoneNumber = requestorPhoneNumber;
                var requestorTitle = _requestorTitle; requestorTitle.Clean = value; _requestorTitle = requestorTitle;
                var requestYear1 = _requestYear1; requestYear1.Clean = value; _requestYear1 = requestYear1;
                var requestYear2 = _requestYear2; requestYear2.Clean = value; _requestYear2 = requestYear2;
                var requestYear3 = _requestYear3; requestYear3.Clean = value; _requestYear3 = requestYear3;
                var requestYear4 = _requestYear4; requestYear4.Clean = value; _requestYear4 = requestYear4;
                var requestYear5 = _requestYear5; requestYear5.Clean = value; _requestYear5 = requestYear5;
                var requestYear6 = _requestYear6; requestYear6.Clean = value; _requestYear6 = requestYear6;
                var requestYear7 = _requestYear7; requestYear7.Clean = value; _requestYear7 = requestYear7;
                var requestYear8 = _requestYear8; requestYear8.Clean = value; _requestYear8 = requestYear8;
                var returnAddress = _returnAddress; returnAddress.Clean = value; _returnAddress = returnAddress;
                var returnCity = _returnCity; returnCity.Clean = value; _returnCity = returnCity;
                var returnState = _returnState; returnState.Clean = value; _returnState = returnState;
                var returnTranscript = _returnTranscript; returnTranscript.Clean = value; _returnTranscript = returnTranscript;
                var returnZip = _returnZip; returnZip.Clean = value; _returnZip = returnZip;
                var selectedRecordNumber = _selectedRecordNumber; selectedRecordNumber.Clean = value; _selectedRecordNumber = selectedRecordNumber;
                var sendAddress = _sendAddress; sendAddress.Clean = value; _sendAddress = sendAddress;
                var sendCity = _sendCity; sendCity.Clean = value; _sendCity = sendCity;
                var sendFirst = _sendFirst; sendFirst.Clean = value; _sendFirst = sendFirst;
                var sendLast = _sendLast; sendLast.Clean = value; _sendLast = sendLast;
                var sendPhone = _sendPhone; sendPhone.Clean = value; _sendPhone = sendPhone;
                var sendState = _sendState; sendState.Clean = value; _sendState = sendState;
                var sendZip = _sendZip; sendZip.Clean = value; _sendZip = sendZip;
                var signatoryAttestation = _signatoryAttestation; signatoryAttestation.Clean = value; _signatoryAttestation = signatoryAttestation;
                var signatoryAttestationT = _signatoryAttestationT; signatoryAttestationT.Clean = value; _signatoryAttestationT = signatoryAttestationT;
                var spouseFirst = _spouseFirst; spouseFirst.Clean = value; _spouseFirst = spouseFirst;
                var spouseLast = _spouseLast; spouseLast.Clean = value; _spouseLast = spouseLast;
                var spouseSSN = _spouseSSN; spouseSSN.Clean = value; _spouseSSN = spouseSSN;
                var spouseUseEIN = _spouseUseEIN; spouseUseEIN.Clean = value; _spouseUseEIN = spouseUseEIN;
                var sSN = _sSN; sSN.Clean = value; _sSN = sSN;
                var state = _state; state.Clean = value; _state = state;
                var tax4506Index = _tax4506Index; tax4506Index.Clean = value; _tax4506Index = tax4506Index;
                var tax4506TIndicator = _tax4506TIndicator; tax4506TIndicator.Clean = value; _tax4506TIndicator = tax4506TIndicator;
                var taxFormNumber = _taxFormNumber; taxFormNumber.Clean = value; _taxFormNumber = taxFormNumber;
                var theseCopiesMustBeCertified = _theseCopiesMustBeCertified; theseCopiesMustBeCertified.Clean = value; _theseCopiesMustBeCertified = theseCopiesMustBeCertified;
                var totalCost = _totalCost; totalCost.Clean = value; _totalCost = totalCost;
                var useEIN = _useEIN; useEIN.Clean = value; _useEIN = useEIN;
                var useWellsFargoRules = _useWellsFargoRules; useWellsFargoRules.Clean = value; _useWellsFargoRules = useWellsFargoRules;
                var verificationOfNonfiling = _verificationOfNonfiling; verificationOfNonfiling.Clean = value; _verificationOfNonfiling = verificationOfNonfiling;
                var zip = _zip; zip.Clean = value; _zip = zip;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Tax4506()
        {
            Clean = true;
        }
    }
}