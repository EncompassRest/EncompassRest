using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FannieMae : IClean
    {
        private Value<decimal?> _cltv;
        public decimal? Cltv { get { return _cltv; } set { _cltv = value; } }
        private Value<string> _collateralUnderwriterScore;
        public string CollateralUnderwriterScore { get { return _collateralUnderwriterScore; } set { _collateralUnderwriterScore = value; } }
        private Value<string> _community2ndRepaymentStructure;
        public string Community2ndRepaymentStructure { get { return _community2ndRepaymentStructure; } set { _community2ndRepaymentStructure = value; } }
        private Value<bool?> _communityLending;
        public bool? CommunityLending { get { return _communityLending; } set { _communityLending = value; } }
        private Value<string> _duVersion;
        public string DuVersion { get { return _duVersion; } set { _duVersion = value; } }
        private Value<string> _eCStatus1003;
        public string ECStatus1003 { get { return _eCStatus1003; } set { _eCStatus1003 = value; } }
        private Value<decimal?> _hcltv;
        public decimal? Hcltv { get { return _hcltv; } set { _hcltv = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _interestedPartyContribution;
        public decimal? InterestedPartyContribution { get { return _interestedPartyContribution; } set { _interestedPartyContribution = value; } }
        private Value<decimal?> _ltv;
        public decimal? Ltv { get { return _ltv; } set { _ltv = value; } }
        private Value<string> _mornetPlusCaseFileId;
        public string MornetPlusCaseFileId { get { return _mornetPlusCaseFileId; } set { _mornetPlusCaseFileId = value; } }
        private Value<string> _propertyInspectionWaiverMessage;
        public string PropertyInspectionWaiverMessage { get { return _propertyInspectionWaiverMessage; } set { _propertyInspectionWaiverMessage = value; } }
        private Value<bool?> _startUpMortgage;
        public bool? StartUpMortgage { get { return _startUpMortgage; } set { _startUpMortgage = value; } }
        private Value<string> _uCDCollectionStatus;
        public string UCDCollectionStatus { get { return _uCDCollectionStatus; } set { _uCDCollectionStatus = value; } }
        private Value<string> _uCDPStatus;
        public string UCDPStatus { get { return _uCDPStatus; } set { _uCDPStatus = value; } }
        private Value<string> _uLDDECStatus;
        public string ULDDECStatus { get { return _uLDDECStatus; } set { _uLDDECStatus = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _cltv.Clean
                    && _collateralUnderwriterScore.Clean
                    && _community2ndRepaymentStructure.Clean
                    && _communityLending.Clean
                    && _duVersion.Clean
                    && _eCStatus1003.Clean
                    && _hcltv.Clean
                    && _id.Clean
                    && _interestedPartyContribution.Clean
                    && _ltv.Clean
                    && _mornetPlusCaseFileId.Clean
                    && _propertyInspectionWaiverMessage.Clean
                    && _startUpMortgage.Clean
                    && _uCDCollectionStatus.Clean
                    && _uCDPStatus.Clean
                    && _uLDDECStatus.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var cltv = _cltv; cltv.Clean = value; _cltv = cltv;
                var collateralUnderwriterScore = _collateralUnderwriterScore; collateralUnderwriterScore.Clean = value; _collateralUnderwriterScore = collateralUnderwriterScore;
                var community2ndRepaymentStructure = _community2ndRepaymentStructure; community2ndRepaymentStructure.Clean = value; _community2ndRepaymentStructure = community2ndRepaymentStructure;
                var communityLending = _communityLending; communityLending.Clean = value; _communityLending = communityLending;
                var duVersion = _duVersion; duVersion.Clean = value; _duVersion = duVersion;
                var eCStatus1003 = _eCStatus1003; eCStatus1003.Clean = value; _eCStatus1003 = eCStatus1003;
                var hcltv = _hcltv; hcltv.Clean = value; _hcltv = hcltv;
                var id = _id; id.Clean = value; _id = id;
                var interestedPartyContribution = _interestedPartyContribution; interestedPartyContribution.Clean = value; _interestedPartyContribution = interestedPartyContribution;
                var ltv = _ltv; ltv.Clean = value; _ltv = ltv;
                var mornetPlusCaseFileId = _mornetPlusCaseFileId; mornetPlusCaseFileId.Clean = value; _mornetPlusCaseFileId = mornetPlusCaseFileId;
                var propertyInspectionWaiverMessage = _propertyInspectionWaiverMessage; propertyInspectionWaiverMessage.Clean = value; _propertyInspectionWaiverMessage = propertyInspectionWaiverMessage;
                var startUpMortgage = _startUpMortgage; startUpMortgage.Clean = value; _startUpMortgage = startUpMortgage;
                var uCDCollectionStatus = _uCDCollectionStatus; uCDCollectionStatus.Clean = value; _uCDCollectionStatus = uCDCollectionStatus;
                var uCDPStatus = _uCDPStatus; uCDPStatus.Clean = value; _uCDPStatus = uCDPStatus;
                var uLDDECStatus = _uLDDECStatus; uLDDECStatus.Clean = value; _uLDDECStatus = uLDDECStatus;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public FannieMae()
        {
            Clean = true;
        }
    }
}