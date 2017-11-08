using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Funding : IDirty
    {
        private DirtyValue<DateTime?> _collateralSentDate;
        public DateTime? CollateralSentDate { get { return _collateralSentDate; } set { _collateralSentDate = value; } }
        private DirtyValue<string> _funderName;
        public string FunderName { get { return _funderName; } set { _funderName = value; } }
        private DirtyValue<string> _funderUrl;
        public string FunderUrl { get { return _funderUrl; } set { _funderUrl = value; } }
        private DirtyValue<string> _fundingClearedBy;
        public string FundingClearedBy { get { return _fundingClearedBy; } set { _fundingClearedBy = value; } }
        private DirtyValue<DateTime?> _fundingCloseDate;
        public DateTime? FundingCloseDate { get { return _fundingCloseDate; } set { _fundingCloseDate = value; } }
        private DirtyValue<string> _fundingFees;
        public string FundingFees { get { return _fundingFees; } set { _fundingFees = value; } }
        private DirtyValue<DateTime?> _fundingOrderDate;
        public DateTime? FundingOrderDate { get { return _fundingOrderDate; } set { _fundingOrderDate = value; } }
        private DirtyValue<string> _fundingType;
        public string FundingType { get { return _fundingType; } set { _fundingType = value; } }
        private DirtyValue<DateTime?> _fundsReleasedDate;
        public DateTime? FundsReleasedDate { get { return _fundsReleasedDate; } set { _fundsReleasedDate = value; } }
        private DirtyValue<string> _fundsReleaseNumber;
        public string FundsReleaseNumber { get { return _fundsReleaseNumber; } set { _fundsReleaseNumber = value; } }
        private DirtyValue<DateTime?> _fundsSentDate;
        public DateTime? FundsSentDate { get { return _fundsSentDate; } set { _fundsSentDate = value; } }
        private DirtyValue<string> _fundsWireTo;
        public string FundsWireTo { get { return _fundsWireTo; } set { _fundsWireTo = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<DateTime?> _sentToFunderDate;
        public DateTime? SentToFunderDate { get { return _sentToFunderDate; } set { _sentToFunderDate = value; } }
        private DirtyValue<string> _wiredToAbaNumber;
        public string WiredToAbaNumber { get { return _wiredToAbaNumber; } set { _wiredToAbaNumber = value; } }
        private DirtyValue<string> _wiredToAccountNumber;
        public string WiredToAccountNumber { get { return _wiredToAccountNumber; } set { _wiredToAccountNumber = value; } }
        private DirtyValue<string> _wiredToForCreditTo;
        public string WiredToForCreditTo { get { return _wiredToForCreditTo; } set { _wiredToForCreditTo = value; } }
        private DirtyValue<string> _wiredToForCreditTo1;
        public string WiredToForCreditTo1 { get { return _wiredToForCreditTo1; } set { _wiredToForCreditTo1 = value; } }
        private DirtyValue<string> _wiredToForCreditTo2;
        public string WiredToForCreditTo2 { get { return _wiredToForCreditTo2; } set { _wiredToForCreditTo2 = value; } }
        private DirtyValue<string> _wiredToForFurtherCreditTo1;
        public string WiredToForFurtherCreditTo1 { get { return _wiredToForFurtherCreditTo1; } set { _wiredToForFurtherCreditTo1 = value; } }
        private DirtyValue<string> _wiredToForFurtherCreditTo2;
        public string WiredToForFurtherCreditTo2 { get { return _wiredToForFurtherCreditTo2; } set { _wiredToForFurtherCreditTo2 = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _collateralSentDate.Dirty
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
                    || _wiredToForFurtherCreditTo2.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}