using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Funding
    {
        private Value<DateTime?> _collateralSentDate;
        public DateTime? CollateralSentDate { get { return _collateralSentDate; } set { _collateralSentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCollateralSentDate() => !_collateralSentDate.Clean;
        private Value<string> _funderName;
        public string FunderName { get { return _funderName; } set { _funderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFunderName() => !_funderName.Clean;
        private Value<string> _funderUrl;
        public string FunderUrl { get { return _funderUrl; } set { _funderUrl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFunderUrl() => !_funderUrl.Clean;
        private Value<string> _fundingClearedBy;
        public string FundingClearedBy { get { return _fundingClearedBy; } set { _fundingClearedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingClearedBy() => !_fundingClearedBy.Clean;
        private Value<DateTime?> _fundingCloseDate;
        public DateTime? FundingCloseDate { get { return _fundingCloseDate; } set { _fundingCloseDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingCloseDate() => !_fundingCloseDate.Clean;
        private Value<string> _fundingFees;
        public string FundingFees { get { return _fundingFees; } set { _fundingFees = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFees() => !_fundingFees.Clean;
        private Value<DateTime?> _fundingOrderDate;
        public DateTime? FundingOrderDate { get { return _fundingOrderDate; } set { _fundingOrderDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingOrderDate() => !_fundingOrderDate.Clean;
        private Value<string> _fundingType;
        public string FundingType { get { return _fundingType; } set { _fundingType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingType() => !_fundingType.Clean;
        private Value<DateTime?> _fundsReleasedDate;
        public DateTime? FundsReleasedDate { get { return _fundsReleasedDate; } set { _fundsReleasedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsReleasedDate() => !_fundsReleasedDate.Clean;
        private Value<string> _fundsReleaseNumber;
        public string FundsReleaseNumber { get { return _fundsReleaseNumber; } set { _fundsReleaseNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsReleaseNumber() => !_fundsReleaseNumber.Clean;
        private Value<DateTime?> _fundsSentDate;
        public DateTime? FundsSentDate { get { return _fundsSentDate; } set { _fundsSentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsSentDate() => !_fundsSentDate.Clean;
        private Value<string> _fundsWireTo;
        public string FundsWireTo { get { return _fundsWireTo; } set { _fundsWireTo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsWireTo() => !_fundsWireTo.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<DateTime?> _sentToFunderDate;
        public DateTime? SentToFunderDate { get { return _sentToFunderDate; } set { _sentToFunderDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSentToFunderDate() => !_sentToFunderDate.Clean;
        private Value<string> _wiredToAbaNumber;
        public string WiredToAbaNumber { get { return _wiredToAbaNumber; } set { _wiredToAbaNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToAbaNumber() => !_wiredToAbaNumber.Clean;
        private Value<string> _wiredToAccountNumber;
        public string WiredToAccountNumber { get { return _wiredToAccountNumber; } set { _wiredToAccountNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToAccountNumber() => !_wiredToAccountNumber.Clean;
        private Value<string> _wiredToForCreditTo;
        public string WiredToForCreditTo { get { return _wiredToForCreditTo; } set { _wiredToForCreditTo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForCreditTo() => !_wiredToForCreditTo.Clean;
        private Value<string> _wiredToForCreditTo1;
        public string WiredToForCreditTo1 { get { return _wiredToForCreditTo1; } set { _wiredToForCreditTo1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForCreditTo1() => !_wiredToForCreditTo1.Clean;
        private Value<string> _wiredToForCreditTo2;
        public string WiredToForCreditTo2 { get { return _wiredToForCreditTo2; } set { _wiredToForCreditTo2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForCreditTo2() => !_wiredToForCreditTo2.Clean;
        private Value<string> _wiredToForFurtherCreditTo1;
        public string WiredToForFurtherCreditTo1 { get { return _wiredToForFurtherCreditTo1; } set { _wiredToForFurtherCreditTo1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForFurtherCreditTo1() => !_wiredToForFurtherCreditTo1.Clean;
        private Value<string> _wiredToForFurtherCreditTo2;
        public string WiredToForFurtherCreditTo2 { get { return _wiredToForFurtherCreditTo2; } set { _wiredToForFurtherCreditTo2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWiredToForFurtherCreditTo2() => !_wiredToForFurtherCreditTo2.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _collateralSentDate.Clean
                    && _funderName.Clean
                    && _funderUrl.Clean
                    && _fundingClearedBy.Clean
                    && _fundingCloseDate.Clean
                    && _fundingFees.Clean
                    && _fundingOrderDate.Clean
                    && _fundingType.Clean
                    && _fundsReleasedDate.Clean
                    && _fundsReleaseNumber.Clean
                    && _fundsSentDate.Clean
                    && _fundsWireTo.Clean
                    && _id.Clean
                    && _sentToFunderDate.Clean
                    && _wiredToAbaNumber.Clean
                    && _wiredToAccountNumber.Clean
                    && _wiredToForCreditTo.Clean
                    && _wiredToForCreditTo1.Clean
                    && _wiredToForCreditTo2.Clean
                    && _wiredToForFurtherCreditTo1.Clean
                    && _wiredToForFurtherCreditTo2.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _collateralSentDate; v0.Clean = value; _collateralSentDate = v0;
                var v1 = _funderName; v1.Clean = value; _funderName = v1;
                var v2 = _funderUrl; v2.Clean = value; _funderUrl = v2;
                var v3 = _fundingClearedBy; v3.Clean = value; _fundingClearedBy = v3;
                var v4 = _fundingCloseDate; v4.Clean = value; _fundingCloseDate = v4;
                var v5 = _fundingFees; v5.Clean = value; _fundingFees = v5;
                var v6 = _fundingOrderDate; v6.Clean = value; _fundingOrderDate = v6;
                var v7 = _fundingType; v7.Clean = value; _fundingType = v7;
                var v8 = _fundsReleasedDate; v8.Clean = value; _fundsReleasedDate = v8;
                var v9 = _fundsReleaseNumber; v9.Clean = value; _fundsReleaseNumber = v9;
                var v10 = _fundsSentDate; v10.Clean = value; _fundsSentDate = v10;
                var v11 = _fundsWireTo; v11.Clean = value; _fundsWireTo = v11;
                var v12 = _id; v12.Clean = value; _id = v12;
                var v13 = _sentToFunderDate; v13.Clean = value; _sentToFunderDate = v13;
                var v14 = _wiredToAbaNumber; v14.Clean = value; _wiredToAbaNumber = v14;
                var v15 = _wiredToAccountNumber; v15.Clean = value; _wiredToAccountNumber = v15;
                var v16 = _wiredToForCreditTo; v16.Clean = value; _wiredToForCreditTo = v16;
                var v17 = _wiredToForCreditTo1; v17.Clean = value; _wiredToForCreditTo1 = v17;
                var v18 = _wiredToForCreditTo2; v18.Clean = value; _wiredToForCreditTo2 = v18;
                var v19 = _wiredToForFurtherCreditTo1; v19.Clean = value; _wiredToForFurtherCreditTo1 = v19;
                var v20 = _wiredToForFurtherCreditTo2; v20.Clean = value; _wiredToForFurtherCreditTo2 = v20;
                _settingClean = 0;
            }
        }
    }
}