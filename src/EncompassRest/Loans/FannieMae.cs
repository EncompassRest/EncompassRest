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
                var v0 = _cltv; v0.Clean = value; _cltv = v0;
                var v1 = _collateralUnderwriterScore; v1.Clean = value; _collateralUnderwriterScore = v1;
                var v2 = _community2ndRepaymentStructure; v2.Clean = value; _community2ndRepaymentStructure = v2;
                var v3 = _communityLending; v3.Clean = value; _communityLending = v3;
                var v4 = _duVersion; v4.Clean = value; _duVersion = v4;
                var v5 = _eCStatus1003; v5.Clean = value; _eCStatus1003 = v5;
                var v6 = _hcltv; v6.Clean = value; _hcltv = v6;
                var v7 = _id; v7.Clean = value; _id = v7;
                var v8 = _interestedPartyContribution; v8.Clean = value; _interestedPartyContribution = v8;
                var v9 = _ltv; v9.Clean = value; _ltv = v9;
                var v10 = _mornetPlusCaseFileId; v10.Clean = value; _mornetPlusCaseFileId = v10;
                var v11 = _propertyInspectionWaiverMessage; v11.Clean = value; _propertyInspectionWaiverMessage = v11;
                var v12 = _startUpMortgage; v12.Clean = value; _startUpMortgage = v12;
                var v13 = _uCDCollectionStatus; v13.Clean = value; _uCDCollectionStatus = v13;
                var v14 = _uCDPStatus; v14.Clean = value; _uCDPStatus = v14;
                var v15 = _uLDDECStatus; v15.Clean = value; _uLDDECStatus = v15;
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