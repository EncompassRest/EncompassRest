#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Funding : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _collateralSentDate;
        public DateTime? CollateralSentDate { get => _collateralSentDate; set => _collateralSentDate = value; }
        private DirtyValue<string> _funderName;
        public string FunderName { get => _funderName; set => _funderName = value; }
        private DirtyValue<string> _funderUrl;
        public string FunderUrl { get => _funderUrl; set => _funderUrl = value; }
        private DirtyValue<string> _fundingClearedBy;
        public string FundingClearedBy { get => _fundingClearedBy; set => _fundingClearedBy = value; }
        private DirtyValue<DateTime?> _fundingCloseDate;
        public DateTime? FundingCloseDate { get => _fundingCloseDate; set => _fundingCloseDate = value; }
        private DirtyValue<string> _fundingFees;
        public string FundingFees { get => _fundingFees; set => _fundingFees = value; }
        private DirtyValue<DateTime?> _fundingOrderDate;
        public DateTime? FundingOrderDate { get => _fundingOrderDate; set => _fundingOrderDate = value; }
        private DirtyValue<string> _fundingType;
        public string FundingType { get => _fundingType; set => _fundingType = value; }
        private DirtyValue<DateTime?> _fundsReleasedDate;
        public DateTime? FundsReleasedDate { get => _fundsReleasedDate; set => _fundsReleasedDate = value; }
        private DirtyValue<string> _fundsReleaseNumber;
        public string FundsReleaseNumber { get => _fundsReleaseNumber; set => _fundsReleaseNumber = value; }
        private DirtyValue<DateTime?> _fundsSentDate;
        public DateTime? FundsSentDate { get => _fundsSentDate; set => _fundsSentDate = value; }
        private DirtyValue<string> _fundsWireTo;
        public string FundsWireTo { get => _fundsWireTo; set => _fundsWireTo = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _sentToFunderDate;
        public DateTime? SentToFunderDate { get => _sentToFunderDate; set => _sentToFunderDate = value; }
        private DirtyValue<string> _wiredToAbaNumber;
        public string WiredToAbaNumber { get => _wiredToAbaNumber; set => _wiredToAbaNumber = value; }
        private DirtyValue<string> _wiredToAccountNumber;
        public string WiredToAccountNumber { get => _wiredToAccountNumber; set => _wiredToAccountNumber = value; }
        private DirtyValue<string> _wiredToForCreditTo;
        public string WiredToForCreditTo { get => _wiredToForCreditTo; set => _wiredToForCreditTo = value; }
        private DirtyValue<string> _wiredToForCreditTo1;
        public string WiredToForCreditTo1 { get => _wiredToForCreditTo1; set => _wiredToForCreditTo1 = value; }
        private DirtyValue<string> _wiredToForCreditTo2;
        public string WiredToForCreditTo2 { get => _wiredToForCreditTo2; set => _wiredToForCreditTo2 = value; }
        private DirtyValue<string> _wiredToForFurtherCreditTo1;
        public string WiredToForFurtherCreditTo1 { get => _wiredToForFurtherCreditTo1; set => _wiredToForFurtherCreditTo1 = value; }
        private DirtyValue<string> _wiredToForFurtherCreditTo2;
        public string WiredToForFurtherCreditTo2 { get => _wiredToForFurtherCreditTo2; set => _wiredToForFurtherCreditTo2 = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _collateralSentDate.Dirty
                    || _funderName.Dirty
                    || _funderUrl.Dirty
                    || _fundingClearedBy.Dirty
                    || _fundingCloseDate.Dirty
                    || _fundingFees.Dirty
                    || _fundingOrderDate.Dirty
                    || _fundingType.Dirty
                    || _fundsReleasedDate.Dirty
                    || _fundsReleaseNumber.Dirty
                    || _fundsSentDate.Dirty
                    || _fundsWireTo.Dirty
                    || _id.Dirty
                    || _sentToFunderDate.Dirty
                    || _wiredToAbaNumber.Dirty
                    || _wiredToAccountNumber.Dirty
                    || _wiredToForCreditTo.Dirty
                    || _wiredToForCreditTo1.Dirty
                    || _wiredToForCreditTo2.Dirty
                    || _wiredToForFurtherCreditTo1.Dirty
                    || _wiredToForFurtherCreditTo2.Dirty;
            }
            set
            {
                _collateralSentDate.Dirty = value;
                _funderName.Dirty = value;
                _funderUrl.Dirty = value;
                _fundingClearedBy.Dirty = value;
                _fundingCloseDate.Dirty = value;
                _fundingFees.Dirty = value;
                _fundingOrderDate.Dirty = value;
                _fundingType.Dirty = value;
                _fundsReleasedDate.Dirty = value;
                _fundsReleaseNumber.Dirty = value;
                _fundsSentDate.Dirty = value;
                _fundsWireTo.Dirty = value;
                _id.Dirty = value;
                _sentToFunderDate.Dirty = value;
                _wiredToAbaNumber.Dirty = value;
                _wiredToAccountNumber.Dirty = value;
                _wiredToForCreditTo.Dirty = value;
                _wiredToForCreditTo1.Dirty = value;
                _wiredToForCreditTo2.Dirty = value;
                _wiredToForFurtherCreditTo1.Dirty = value;
                _wiredToForFurtherCreditTo2.Dirty = value;
            }
        }
    }
}