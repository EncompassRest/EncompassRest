using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class PreviousVaLoan : IDirty
    {
        private DirtyValue<DateTime?> _dateOfLoan;
        public DateTime? DateOfLoan { get => _dateOfLoan; set => _dateOfLoan = value; }
        private DirtyValue<DateTime?> _dateSold;
        public DateTime? DateSold { get => _dateSold; set => _dateSold = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<PreviousVaLoanLoanType>> _loanType;
        public StringEnumValue<PreviousVaLoanLoanType> LoanType { get => _loanType; set => _loanType = value; }
        private DirtyValue<int?> _previousVaLoanIndex;
        public int? PreviousVaLoanIndex { get => _previousVaLoanIndex; set => _previousVaLoanIndex = value; }
        private DirtyValue<string> _propertyAddress;
        public string PropertyAddress { get => _propertyAddress; set => _propertyAddress = value; }
        private DirtyValue<string> _propertyCity;
        public string PropertyCity { get => _propertyCity; set => _propertyCity = value; }
        private DirtyValue<bool?> _propertyOwned;
        public bool? PropertyOwned { get => _propertyOwned; set => _propertyOwned = value; }
        private DirtyValue<string> _propertyPostalCode;
        public string PropertyPostalCode { get => _propertyPostalCode; set => _propertyPostalCode = value; }
        private DirtyValue<string> _propertyState;
        public string PropertyState { get => _propertyState; set => _propertyState = value; }
        private DirtyValue<string> _vALoanNumber;
        public string VALoanNumber { get => _vALoanNumber; set => _vALoanNumber = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
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
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}