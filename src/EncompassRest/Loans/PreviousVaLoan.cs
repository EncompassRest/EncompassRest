using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PreviousVaLoan : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _dateOfLoan.Clean
                    && _dateSold.Clean
                    && _id.Clean
                    && _loanType.Clean
                    && _previousVaLoanIndex.Clean
                    && _propertyAddress.Clean
                    && _propertyCity.Clean
                    && _propertyOwned.Clean
                    && _propertyPostalCode.Clean
                    && _propertyState.Clean
                    && _vALoanNumber.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var dateOfLoan = _dateOfLoan; dateOfLoan.Clean = value; _dateOfLoan = dateOfLoan;
                var dateSold = _dateSold; dateSold.Clean = value; _dateSold = dateSold;
                var id = _id; id.Clean = value; _id = id;
                var loanType = _loanType; loanType.Clean = value; _loanType = loanType;
                var previousVaLoanIndex = _previousVaLoanIndex; previousVaLoanIndex.Clean = value; _previousVaLoanIndex = previousVaLoanIndex;
                var propertyAddress = _propertyAddress; propertyAddress.Clean = value; _propertyAddress = propertyAddress;
                var propertyCity = _propertyCity; propertyCity.Clean = value; _propertyCity = propertyCity;
                var propertyOwned = _propertyOwned; propertyOwned.Clean = value; _propertyOwned = propertyOwned;
                var propertyPostalCode = _propertyPostalCode; propertyPostalCode.Clean = value; _propertyPostalCode = propertyPostalCode;
                var propertyState = _propertyState; propertyState.Clean = value; _propertyState = propertyState;
                var vALoanNumber = _vALoanNumber; vALoanNumber.Clean = value; _vALoanNumber = vALoanNumber;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PreviousVaLoan()
        {
            Clean = true;
        }
    }
}