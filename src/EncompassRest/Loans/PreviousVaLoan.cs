using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PreviousVaLoan : IDirty
    {
        private DirtyValue<DateTime?> _dateOfLoan;
        public DateTime? DateOfLoan { get { return _dateOfLoan; } set { _dateOfLoan = value; } }
        private DirtyValue<DateTime?> _dateSold;
        public DateTime? DateSold { get { return _dateSold; } set { _dateSold = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private StringEnumValue<PreviousVaLoanLoanType> _loanType;
        public StringEnumValue<PreviousVaLoanLoanType> LoanType { get { return _loanType; } set { _loanType = value; } }
        private DirtyValue<int?> _previousVaLoanIndex;
        public int? PreviousVaLoanIndex { get { return _previousVaLoanIndex; } set { _previousVaLoanIndex = value; } }
        private DirtyValue<string> _propertyAddress;
        public string PropertyAddress { get { return _propertyAddress; } set { _propertyAddress = value; } }
        private DirtyValue<string> _propertyCity;
        public string PropertyCity { get { return _propertyCity; } set { _propertyCity = value; } }
        private DirtyValue<bool?> _propertyOwned;
        public bool? PropertyOwned { get { return _propertyOwned; } set { _propertyOwned = value; } }
        private DirtyValue<string> _propertyPostalCode;
        public string PropertyPostalCode { get { return _propertyPostalCode; } set { _propertyPostalCode = value; } }
        private DirtyValue<string> _propertyState;
        public string PropertyState { get { return _propertyState; } set { _propertyState = value; } }
        private DirtyValue<string> _vALoanNumber;
        public string VALoanNumber { get { return _vALoanNumber; } set { _vALoanNumber = value; } }
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
                var dirty = _dateOfLoan.Dirty
                    || _dateSold.Dirty
                    || _id.Dirty
                    || _loanType.Dirty
                    || _previousVaLoanIndex.Dirty
                    || _propertyAddress.Dirty
                    || _propertyCity.Dirty
                    || _propertyOwned.Dirty
                    || _propertyPostalCode.Dirty
                    || _propertyState.Dirty
                    || _vALoanNumber.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _dateOfLoan.Dirty = value;
                _dateSold.Dirty = value;
                _id.Dirty = value;
                _loanType.Dirty = value;
                _previousVaLoanIndex.Dirty = value;
                _propertyAddress.Dirty = value;
                _propertyCity.Dirty = value;
                _propertyOwned.Dirty = value;
                _propertyPostalCode.Dirty = value;
                _propertyState.Dirty = value;
                _vALoanNumber.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}