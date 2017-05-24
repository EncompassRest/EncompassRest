using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PreviousVaLoan
    {
        public Value<DateTime?> DateOfLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateOfLoan() => !DateOfLoan.Clean;
        public Value<DateTime?> DateSold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateSold() => !DateSold.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanType() => !LoanType.Clean;
        public Value<int?> PreviousVaLoanIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousVaLoanIndex() => !PreviousVaLoanIndex.Clean;
        public Value<string> PropertyAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyAddress() => !PropertyAddress.Clean;
        public Value<string> PropertyCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyCity() => !PropertyCity.Clean;
        public Value<bool?> PropertyOwned { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwned() => !PropertyOwned.Clean;
        public Value<string> PropertyPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyPostalCode() => !PropertyPostalCode.Clean;
        public Value<string> PropertyState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyState() => !PropertyState.Clean;
        public Value<string> VALoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVALoanNumber() => !VALoanNumber.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = DateOfLoan.Clean
                    && DateSold.Clean
                    && Id.Clean
                    && LoanType.Clean
                    && PreviousVaLoanIndex.Clean
                    && PropertyAddress.Clean
                    && PropertyCity.Clean
                    && PropertyOwned.Clean
                    && PropertyPostalCode.Clean
                    && PropertyState.Clean
                    && VALoanNumber.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = DateOfLoan; v0.Clean = value; DateOfLoan = v0;
                var v1 = DateSold; v1.Clean = value; DateSold = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = LoanType; v3.Clean = value; LoanType = v3;
                var v4 = PreviousVaLoanIndex; v4.Clean = value; PreviousVaLoanIndex = v4;
                var v5 = PropertyAddress; v5.Clean = value; PropertyAddress = v5;
                var v6 = PropertyCity; v6.Clean = value; PropertyCity = v6;
                var v7 = PropertyOwned; v7.Clean = value; PropertyOwned = v7;
                var v8 = PropertyPostalCode; v8.Clean = value; PropertyPostalCode = v8;
                var v9 = PropertyState; v9.Clean = value; PropertyState = v9;
                var v10 = VALoanNumber; v10.Clean = value; VALoanNumber = v10;
                _settingClean = 0;
            }
        }
    }
}