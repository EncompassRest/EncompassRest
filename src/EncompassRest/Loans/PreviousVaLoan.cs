using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PreviousVaLoan : IDirty
    {
        private Value<DateTime?> _dateOfLoan;
        public DateTime? DateOfLoan { get { return _dateOfLoan; } set { _dateOfLoan = value; } }
        private Value<DateTime?> _dateSold;
        public DateTime? DateSold { get { return _dateSold; } set { _dateSold = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _loanType;
        public string LoanType { get { return _loanType; } set { _loanType = value; } }
        private Value<int?> _previousVaLoanIndex;
        public int? PreviousVaLoanIndex { get { return _previousVaLoanIndex; } set { _previousVaLoanIndex = value; } }
        private Value<string> _propertyAddress;
        public string PropertyAddress { get { return _propertyAddress; } set { _propertyAddress = value; } }
        private Value<string> _propertyCity;
        public string PropertyCity { get { return _propertyCity; } set { _propertyCity = value; } }
        private Value<bool?> _propertyOwned;
        public bool? PropertyOwned { get { return _propertyOwned; } set { _propertyOwned = value; } }
        private Value<string> _propertyPostalCode;
        public string PropertyPostalCode { get { return _propertyPostalCode; } set { _propertyPostalCode = value; } }
        private Value<string> _propertyState;
        public string PropertyState { get { return _propertyState; } set { _propertyState = value; } }
        private Value<string> _vALoanNumber;
        public string VALoanNumber { get { return _vALoanNumber; } set { _vALoanNumber = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _vALoanNumber.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}