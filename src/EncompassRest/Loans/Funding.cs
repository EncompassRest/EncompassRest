using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Funding : IClean
    {
        private Value<DateTime?> _collateralSentDate;
        public DateTime? CollateralSentDate { get { return _collateralSentDate; } set { _collateralSentDate = value; } }
        private Value<string> _funderName;
        public string FunderName { get { return _funderName; } set { _funderName = value; } }
        private Value<string> _funderUrl;
        public string FunderUrl { get { return _funderUrl; } set { _funderUrl = value; } }
        private Value<string> _fundingClearedBy;
        public string FundingClearedBy { get { return _fundingClearedBy; } set { _fundingClearedBy = value; } }
        private Value<DateTime?> _fundingCloseDate;
        public DateTime? FundingCloseDate { get { return _fundingCloseDate; } set { _fundingCloseDate = value; } }
        private Value<string> _fundingFees;
        public string FundingFees { get { return _fundingFees; } set { _fundingFees = value; } }
        private Value<DateTime?> _fundingOrderDate;
        public DateTime? FundingOrderDate { get { return _fundingOrderDate; } set { _fundingOrderDate = value; } }
        private Value<string> _fundingType;
        public string FundingType { get { return _fundingType; } set { _fundingType = value; } }
        private Value<DateTime?> _fundsReleasedDate;
        public DateTime? FundsReleasedDate { get { return _fundsReleasedDate; } set { _fundsReleasedDate = value; } }
        private Value<string> _fundsReleaseNumber;
        public string FundsReleaseNumber { get { return _fundsReleaseNumber; } set { _fundsReleaseNumber = value; } }
        private Value<DateTime?> _fundsSentDate;
        public DateTime? FundsSentDate { get { return _fundsSentDate; } set { _fundsSentDate = value; } }
        private Value<string> _fundsWireTo;
        public string FundsWireTo { get { return _fundsWireTo; } set { _fundsWireTo = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<DateTime?> _sentToFunderDate;
        public DateTime? SentToFunderDate { get { return _sentToFunderDate; } set { _sentToFunderDate = value; } }
        private Value<string> _wiredToAbaNumber;
        public string WiredToAbaNumber { get { return _wiredToAbaNumber; } set { _wiredToAbaNumber = value; } }
        private Value<string> _wiredToAccountNumber;
        public string WiredToAccountNumber { get { return _wiredToAccountNumber; } set { _wiredToAccountNumber = value; } }
        private Value<string> _wiredToForCreditTo;
        public string WiredToForCreditTo { get { return _wiredToForCreditTo; } set { _wiredToForCreditTo = value; } }
        private Value<string> _wiredToForCreditTo1;
        public string WiredToForCreditTo1 { get { return _wiredToForCreditTo1; } set { _wiredToForCreditTo1 = value; } }
        private Value<string> _wiredToForCreditTo2;
        public string WiredToForCreditTo2 { get { return _wiredToForCreditTo2; } set { _wiredToForCreditTo2 = value; } }
        private Value<string> _wiredToForFurtherCreditTo1;
        public string WiredToForFurtherCreditTo1 { get { return _wiredToForFurtherCreditTo1; } set { _wiredToForFurtherCreditTo1 = value; } }
        private Value<string> _wiredToForFurtherCreditTo2;
        public string WiredToForFurtherCreditTo2 { get { return _wiredToForFurtherCreditTo2; } set { _wiredToForFurtherCreditTo2 = value; } }
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
                var collateralSentDate = _collateralSentDate; collateralSentDate.Clean = value; _collateralSentDate = collateralSentDate;
                var funderName = _funderName; funderName.Clean = value; _funderName = funderName;
                var funderUrl = _funderUrl; funderUrl.Clean = value; _funderUrl = funderUrl;
                var fundingClearedBy = _fundingClearedBy; fundingClearedBy.Clean = value; _fundingClearedBy = fundingClearedBy;
                var fundingCloseDate = _fundingCloseDate; fundingCloseDate.Clean = value; _fundingCloseDate = fundingCloseDate;
                var fundingFees = _fundingFees; fundingFees.Clean = value; _fundingFees = fundingFees;
                var fundingOrderDate = _fundingOrderDate; fundingOrderDate.Clean = value; _fundingOrderDate = fundingOrderDate;
                var fundingType = _fundingType; fundingType.Clean = value; _fundingType = fundingType;
                var fundsReleasedDate = _fundsReleasedDate; fundsReleasedDate.Clean = value; _fundsReleasedDate = fundsReleasedDate;
                var fundsReleaseNumber = _fundsReleaseNumber; fundsReleaseNumber.Clean = value; _fundsReleaseNumber = fundsReleaseNumber;
                var fundsSentDate = _fundsSentDate; fundsSentDate.Clean = value; _fundsSentDate = fundsSentDate;
                var fundsWireTo = _fundsWireTo; fundsWireTo.Clean = value; _fundsWireTo = fundsWireTo;
                var id = _id; id.Clean = value; _id = id;
                var sentToFunderDate = _sentToFunderDate; sentToFunderDate.Clean = value; _sentToFunderDate = sentToFunderDate;
                var wiredToAbaNumber = _wiredToAbaNumber; wiredToAbaNumber.Clean = value; _wiredToAbaNumber = wiredToAbaNumber;
                var wiredToAccountNumber = _wiredToAccountNumber; wiredToAccountNumber.Clean = value; _wiredToAccountNumber = wiredToAccountNumber;
                var wiredToForCreditTo = _wiredToForCreditTo; wiredToForCreditTo.Clean = value; _wiredToForCreditTo = wiredToForCreditTo;
                var wiredToForCreditTo1 = _wiredToForCreditTo1; wiredToForCreditTo1.Clean = value; _wiredToForCreditTo1 = wiredToForCreditTo1;
                var wiredToForCreditTo2 = _wiredToForCreditTo2; wiredToForCreditTo2.Clean = value; _wiredToForCreditTo2 = wiredToForCreditTo2;
                var wiredToForFurtherCreditTo1 = _wiredToForFurtherCreditTo1; wiredToForFurtherCreditTo1.Clean = value; _wiredToForFurtherCreditTo1 = wiredToForFurtherCreditTo1;
                var wiredToForFurtherCreditTo2 = _wiredToForFurtherCreditTo2; wiredToForFurtherCreditTo2.Clean = value; _wiredToForFurtherCreditTo2 = wiredToForFurtherCreditTo2;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Funding()
        {
            Clean = true;
        }
    }
}