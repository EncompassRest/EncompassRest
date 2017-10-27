using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Tax4506 : IDirty
    {
        private DirtyValue<bool?> _accountTranscript;
        public bool? AccountTranscript { get { return _accountTranscript; } set { _accountTranscript = value; } }
        private DirtyValue<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private DirtyValue<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private DirtyValue<decimal?> _costForEachPeriod;
        public decimal? CostForEachPeriod { get { return _costForEachPeriod; } set { _costForEachPeriod = value; } }
        private DirtyValue<string> _currentFirst;
        public string CurrentFirst { get { return _currentFirst; } set { _currentFirst = value; } }
        private DirtyValue<string> _currentLast;
        public string CurrentLast { get { return _currentLast; } set { _currentLast = value; } }
        private DirtyValue<string> _first;
        public string First { get { return _first; } set { _first = value; } }
        private DirtyValue<bool?> _formsSeriesTranscript;
        public bool? FormsSeriesTranscript { get { return _formsSeriesTranscript; } set { _formsSeriesTranscript = value; } }
        private DirtyValue<string> _historyId;
        public string HistoryId { get { return _historyId; } set { _historyId = value; } }
        private DirtyValue<bool?> _historyIndicator;
        public bool? HistoryIndicator { get { return _historyIndicator; } set { _historyIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _ifTaxRecordNotFound;
        public bool? IfTaxRecordNotFound { get { return _ifTaxRecordNotFound; } set { _ifTaxRecordNotFound = value; } }
        private DirtyValue<string> _last;
        public string Last { get { return _last; } set { _last = value; } }
        private DirtyValue<DateTime?> _lastUpdatedDate;
        public DateTime? LastUpdatedDate { get { return _lastUpdatedDate; } set { _lastUpdatedDate = value; } }
        private DirtyValue<int?> _lastUpdatedHistory;
        public int? LastUpdatedHistory { get { return _lastUpdatedHistory; } set { _lastUpdatedHistory = value; } }
        private DirtyValue<string> _lastUpdatedTime;
        public string LastUpdatedTime { get { return _lastUpdatedTime; } set { _lastUpdatedTime = value; } }
        private DirtyValue<bool?> _notifiedIrsIdentityTheftIndicator;
        public bool? NotifiedIrsIdentityTheftIndicator { get { return _notifiedIrsIdentityTheftIndicator; } set { _notifiedIrsIdentityTheftIndicator = value; } }
        private DirtyValue<int?> _numberOfPeriods;
        public int? NumberOfPeriods { get { return _numberOfPeriods; } set { _numberOfPeriods = value; } }
        private DirtyValue<string> _person;
        public string Person { get { return _person; } set { _person = value; } }
        private DirtyValue<bool?> _recordOfAccount;
        public bool? RecordOfAccount { get { return _recordOfAccount; } set { _recordOfAccount = value; } }
        private DirtyValue<string> _requestorPhoneNumber;
        public string RequestorPhoneNumber { get { return _requestorPhoneNumber; } set { _requestorPhoneNumber = value; } }
        private DirtyValue<string> _requestorTitle;
        public string RequestorTitle { get { return _requestorTitle; } set { _requestorTitle = value; } }
        private DirtyValue<DateTime?> _requestYear1;
        public DateTime? RequestYear1 { get { return _requestYear1; } set { _requestYear1 = value; } }
        private DirtyValue<DateTime?> _requestYear2;
        public DateTime? RequestYear2 { get { return _requestYear2; } set { _requestYear2 = value; } }
        private DirtyValue<DateTime?> _requestYear3;
        public DateTime? RequestYear3 { get { return _requestYear3; } set { _requestYear3 = value; } }
        private DirtyValue<DateTime?> _requestYear4;
        public DateTime? RequestYear4 { get { return _requestYear4; } set { _requestYear4 = value; } }
        private DirtyValue<DateTime?> _requestYear5;
        public DateTime? RequestYear5 { get { return _requestYear5; } set { _requestYear5 = value; } }
        private DirtyValue<DateTime?> _requestYear6;
        public DateTime? RequestYear6 { get { return _requestYear6; } set { _requestYear6 = value; } }
        private DirtyValue<DateTime?> _requestYear7;
        public DateTime? RequestYear7 { get { return _requestYear7; } set { _requestYear7 = value; } }
        private DirtyValue<DateTime?> _requestYear8;
        public DateTime? RequestYear8 { get { return _requestYear8; } set { _requestYear8 = value; } }
        private DirtyValue<string> _returnAddress;
        public string ReturnAddress { get { return _returnAddress; } set { _returnAddress = value; } }
        private DirtyValue<string> _returnCity;
        public string ReturnCity { get { return _returnCity; } set { _returnCity = value; } }
        private DirtyValue<string> _returnState;
        public string ReturnState { get { return _returnState; } set { _returnState = value; } }
        private DirtyValue<bool?> _returnTranscript;
        public bool? ReturnTranscript { get { return _returnTranscript; } set { _returnTranscript = value; } }
        private DirtyValue<string> _returnZip;
        public string ReturnZip { get { return _returnZip; } set { _returnZip = value; } }
        private DirtyValue<string> _selectedRecordNumber;
        public string SelectedRecordNumber { get { return _selectedRecordNumber; } set { _selectedRecordNumber = value; } }
        private DirtyValue<string> _sendAddress;
        public string SendAddress { get { return _sendAddress; } set { _sendAddress = value; } }
        private DirtyValue<string> _sendCity;
        public string SendCity { get { return _sendCity; } set { _sendCity = value; } }
        private DirtyValue<string> _sendFirst;
        public string SendFirst { get { return _sendFirst; } set { _sendFirst = value; } }
        private DirtyValue<string> _sendLast;
        public string SendLast { get { return _sendLast; } set { _sendLast = value; } }
        private DirtyValue<string> _sendPhone;
        public string SendPhone { get { return _sendPhone; } set { _sendPhone = value; } }
        private DirtyValue<string> _sendState;
        public string SendState { get { return _sendState; } set { _sendState = value; } }
        private DirtyValue<string> _sendZip;
        public string SendZip { get { return _sendZip; } set { _sendZip = value; } }
        private DirtyValue<bool?> _signatoryAttestation;
        public bool? SignatoryAttestation { get { return _signatoryAttestation; } set { _signatoryAttestation = value; } }
        private DirtyValue<bool?> _signatoryAttestationT;
        public bool? SignatoryAttestationT { get { return _signatoryAttestationT; } set { _signatoryAttestationT = value; } }
        private DirtyValue<string> _spouseFirst;
        public string SpouseFirst { get { return _spouseFirst; } set { _spouseFirst = value; } }
        private DirtyValue<string> _spouseLast;
        public string SpouseLast { get { return _spouseLast; } set { _spouseLast = value; } }
        private DirtyValue<string> _spouseSSN;
        public string SpouseSSN { get { return _spouseSSN; } set { _spouseSSN = value; } }
        private DirtyValue<bool?> _spouseUseEIN;
        public bool? SpouseUseEIN { get { return _spouseUseEIN; } set { _spouseUseEIN = value; } }
        private DirtyValue<string> _sSN;
        public string SSN { get { return _sSN; } set { _sSN = value; } }
        private DirtyValue<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private DirtyValue<int?> _tax4506Index;
        public int? Tax4506Index { get { return _tax4506Index; } set { _tax4506Index = value; } }
        private DirtyValue<bool?> _tax4506TIndicator;
        public bool? Tax4506TIndicator { get { return _tax4506TIndicator; } set { _tax4506TIndicator = value; } }
        private DirtyValue<string> _taxFormNumber;
        public string TaxFormNumber { get { return _taxFormNumber; } set { _taxFormNumber = value; } }
        private DirtyValue<bool?> _theseCopiesMustBeCertified;
        public bool? TheseCopiesMustBeCertified { get { return _theseCopiesMustBeCertified; } set { _theseCopiesMustBeCertified = value; } }
        private DirtyValue<decimal?> _totalCost;
        public decimal? TotalCost { get { return _totalCost; } set { _totalCost = value; } }
        private DirtyValue<bool?> _useEIN;
        public bool? UseEIN { get { return _useEIN; } set { _useEIN = value; } }
        private DirtyValue<bool?> _useWellsFargoRules;
        public bool? UseWellsFargoRules { get { return _useWellsFargoRules; } set { _useWellsFargoRules = value; } }
        private DirtyValue<bool?> _verificationOfNonfiling;
        public bool? VerificationOfNonfiling { get { return _verificationOfNonfiling; } set { _verificationOfNonfiling = value; } }
        private DirtyValue<string> _zip;
        public string Zip { get { return _zip; } set { _zip = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _accountTranscript.Dirty
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
                    || _zip.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}