using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FannieMae : IDirty
    {
        private DirtyValue<decimal?> _cltv;
        public decimal? Cltv { get { return _cltv; } set { _cltv = value; } }
        private DirtyValue<string> _collateralUnderwriterScore;
        public string CollateralUnderwriterScore { get { return _collateralUnderwriterScore; } set { _collateralUnderwriterScore = value; } }
        private DirtyValue<string> _community2ndRepaymentStructure;
        public string Community2ndRepaymentStructure { get { return _community2ndRepaymentStructure; } set { _community2ndRepaymentStructure = value; } }
        private DirtyValue<bool?> _communityLending;
        public bool? CommunityLending { get { return _communityLending; } set { _communityLending = value; } }
        private DirtyValue<string> _duVersion;
        public string DuVersion { get { return _duVersion; } set { _duVersion = value; } }
        private DirtyValue<string> _eCStatus1003;
        public string ECStatus1003 { get { return _eCStatus1003; } set { _eCStatus1003 = value; } }
        private DirtyValue<decimal?> _hcltv;
        public decimal? Hcltv { get { return _hcltv; } set { _hcltv = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _interestedPartyContribution;
        public decimal? InterestedPartyContribution { get { return _interestedPartyContribution; } set { _interestedPartyContribution = value; } }
        private DirtyValue<decimal?> _ltv;
        public decimal? Ltv { get { return _ltv; } set { _ltv = value; } }
        private DirtyValue<string> _mornetPlusCaseFileId;
        public string MornetPlusCaseFileId { get { return _mornetPlusCaseFileId; } set { _mornetPlusCaseFileId = value; } }
        private DirtyValue<string> _propertyInspectionWaiverMessage;
        public string PropertyInspectionWaiverMessage { get { return _propertyInspectionWaiverMessage; } set { _propertyInspectionWaiverMessage = value; } }
        private DirtyValue<bool?> _startUpMortgage;
        public bool? StartUpMortgage { get { return _startUpMortgage; } set { _startUpMortgage = value; } }
        private DirtyValue<string> _uCDCollectionStatus;
        public string UCDCollectionStatus { get { return _uCDCollectionStatus; } set { _uCDCollectionStatus = value; } }
        private DirtyValue<string> _uCDPStatus;
        public string UCDPStatus { get { return _uCDPStatus; } set { _uCDPStatus = value; } }
        private DirtyValue<string> _uLDDECStatus;
        public string ULDDECStatus { get { return _uLDDECStatus; } set { _uLDDECStatus = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _cltv.Dirty
                    || _collateralUnderwriterScore.Dirty
                    || _community2ndRepaymentStructure.Dirty
                    || _communityLending.Dirty
                    || _duVersion.Dirty
                    || _eCStatus1003.Dirty
                    || _hcltv.Dirty
                    || _id.Dirty
                    || _interestedPartyContribution.Dirty
                    || _ltv.Dirty
                    || _mornetPlusCaseFileId.Dirty
                    || _propertyInspectionWaiverMessage.Dirty
                    || _startUpMortgage.Dirty
                    || _uCDCollectionStatus.Dirty
                    || _uCDPStatus.Dirty
                    || _uLDDECStatus.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _cltv.Dirty = value;
                _collateralUnderwriterScore.Dirty = value;
                _community2ndRepaymentStructure.Dirty = value;
                _communityLending.Dirty = value;
                _duVersion.Dirty = value;
                _eCStatus1003.Dirty = value;
                _hcltv.Dirty = value;
                _id.Dirty = value;
                _interestedPartyContribution.Dirty = value;
                _ltv.Dirty = value;
                _mornetPlusCaseFileId.Dirty = value;
                _propertyInspectionWaiverMessage.Dirty = value;
                _startUpMortgage.Dirty = value;
                _uCDCollectionStatus.Dirty = value;
                _uCDPStatus.Dirty = value;
                _uLDDECStatus.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}