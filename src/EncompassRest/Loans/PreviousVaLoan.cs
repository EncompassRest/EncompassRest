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
                var v0 = _dateOfLoan; v0.Clean = value; _dateOfLoan = v0;
                var v1 = _dateSold; v1.Clean = value; _dateSold = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _loanType; v3.Clean = value; _loanType = v3;
                var v4 = _previousVaLoanIndex; v4.Clean = value; _previousVaLoanIndex = v4;
                var v5 = _propertyAddress; v5.Clean = value; _propertyAddress = v5;
                var v6 = _propertyCity; v6.Clean = value; _propertyCity = v6;
                var v7 = _propertyOwned; v7.Clean = value; _propertyOwned = v7;
                var v8 = _propertyPostalCode; v8.Clean = value; _propertyPostalCode = v8;
                var v9 = _propertyState; v9.Clean = value; _propertyState = v9;
                var v10 = _vALoanNumber; v10.Clean = value; _vALoanNumber = v10;
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