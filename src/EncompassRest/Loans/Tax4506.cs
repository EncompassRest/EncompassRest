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
                var v0 = _accountTranscript; v0.Clean = value; _accountTranscript = v0;
                var v1 = _address; v1.Clean = value; _address = v1;
                var v2 = _city; v2.Clean = value; _city = v2;
                var v3 = _costForEachPeriod; v3.Clean = value; _costForEachPeriod = v3;
                var v4 = _currentFirst; v4.Clean = value; _currentFirst = v4;
                var v5 = _currentLast; v5.Clean = value; _currentLast = v5;
                var v6 = _first; v6.Clean = value; _first = v6;
                var v7 = _formsSeriesTranscript; v7.Clean = value; _formsSeriesTranscript = v7;
                var v8 = _historyId; v8.Clean = value; _historyId = v8;
                var v9 = _historyIndicator; v9.Clean = value; _historyIndicator = v9;
                var v10 = _id; v10.Clean = value; _id = v10;
                var v11 = _ifTaxRecordNotFound; v11.Clean = value; _ifTaxRecordNotFound = v11;
                var v12 = _last; v12.Clean = value; _last = v12;
                var v13 = _lastUpdatedDate; v13.Clean = value; _lastUpdatedDate = v13;
                var v14 = _lastUpdatedHistory; v14.Clean = value; _lastUpdatedHistory = v14;
                var v15 = _lastUpdatedTime; v15.Clean = value; _lastUpdatedTime = v15;
                var v16 = _notifiedIrsIdentityTheftIndicator; v16.Clean = value; _notifiedIrsIdentityTheftIndicator = v16;
                var v17 = _numberOfPeriods; v17.Clean = value; _numberOfPeriods = v17;
                var v18 = _person; v18.Clean = value; _person = v18;
                var v19 = _recordOfAccount; v19.Clean = value; _recordOfAccount = v19;
                var v20 = _requestorPhoneNumber; v20.Clean = value; _requestorPhoneNumber = v20;
                var v21 = _requestorTitle; v21.Clean = value; _requestorTitle = v21;
                var v22 = _requestYear1; v22.Clean = value; _requestYear1 = v22;
                var v23 = _requestYear2; v23.Clean = value; _requestYear2 = v23;
                var v24 = _requestYear3; v24.Clean = value; _requestYear3 = v24;
                var v25 = _requestYear4; v25.Clean = value; _requestYear4 = v25;
                var v26 = _requestYear5; v26.Clean = value; _requestYear5 = v26;
                var v27 = _requestYear6; v27.Clean = value; _requestYear6 = v27;
                var v28 = _requestYear7; v28.Clean = value; _requestYear7 = v28;
                var v29 = _requestYear8; v29.Clean = value; _requestYear8 = v29;
                var v30 = _returnAddress; v30.Clean = value; _returnAddress = v30;
                var v31 = _returnCity; v31.Clean = value; _returnCity = v31;
                var v32 = _returnState; v32.Clean = value; _returnState = v32;
                var v33 = _returnTranscript; v33.Clean = value; _returnTranscript = v33;
                var v34 = _returnZip; v34.Clean = value; _returnZip = v34;
                var v35 = _selectedRecordNumber; v35.Clean = value; _selectedRecordNumber = v35;
                var v36 = _sendAddress; v36.Clean = value; _sendAddress = v36;
                var v37 = _sendCity; v37.Clean = value; _sendCity = v37;
                var v38 = _sendFirst; v38.Clean = value; _sendFirst = v38;
                var v39 = _sendLast; v39.Clean = value; _sendLast = v39;
                var v40 = _sendPhone; v40.Clean = value; _sendPhone = v40;
                var v41 = _sendState; v41.Clean = value; _sendState = v41;
                var v42 = _sendZip; v42.Clean = value; _sendZip = v42;
                var v43 = _signatoryAttestation; v43.Clean = value; _signatoryAttestation = v43;
                var v44 = _signatoryAttestationT; v44.Clean = value; _signatoryAttestationT = v44;
                var v45 = _spouseFirst; v45.Clean = value; _spouseFirst = v45;
                var v46 = _spouseLast; v46.Clean = value; _spouseLast = v46;
                var v47 = _spouseSSN; v47.Clean = value; _spouseSSN = v47;
                var v48 = _spouseUseEIN; v48.Clean = value; _spouseUseEIN = v48;
                var v49 = _sSN; v49.Clean = value; _sSN = v49;
                var v50 = _state; v50.Clean = value; _state = v50;
                var v51 = _tax4506Index; v51.Clean = value; _tax4506Index = v51;
                var v52 = _tax4506TIndicator; v52.Clean = value; _tax4506TIndicator = v52;
                var v53 = _taxFormNumber; v53.Clean = value; _taxFormNumber = v53;
                var v54 = _theseCopiesMustBeCertified; v54.Clean = value; _theseCopiesMustBeCertified = v54;
                var v55 = _totalCost; v55.Clean = value; _totalCost = v55;
                var v56 = _useEIN; v56.Clean = value; _useEIN = v56;
                var v57 = _useWellsFargoRules; v57.Clean = value; _useWellsFargoRules = v57;
                var v58 = _verificationOfNonfiling; v58.Clean = value; _verificationOfNonfiling = v58;
                var v59 = _zip; v59.Clean = value; _zip = v59;
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