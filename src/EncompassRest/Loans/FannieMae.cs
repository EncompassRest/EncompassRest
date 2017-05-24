using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FannieMae
    {
        private Value<decimal?> _cltv;
        public decimal? Cltv { get { return _cltv; } set { _cltv = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCltv() => !_cltv.Clean;
        private Value<string> _collateralUnderwriterScore;
        public string CollateralUnderwriterScore { get { return _collateralUnderwriterScore; } set { _collateralUnderwriterScore = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCollateralUnderwriterScore() => !_collateralUnderwriterScore.Clean;
        private Value<string> _community2ndRepaymentStructure;
        public string Community2ndRepaymentStructure { get { return _community2ndRepaymentStructure; } set { _community2ndRepaymentStructure = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommunity2ndRepaymentStructure() => !_community2ndRepaymentStructure.Clean;
        private Value<bool?> _communityLending;
        public bool? CommunityLending { get { return _communityLending; } set { _communityLending = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommunityLending() => !_communityLending.Clean;
        private Value<string> _duVersion;
        public string DuVersion { get { return _duVersion; } set { _duVersion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuVersion() => !_duVersion.Clean;
        private Value<decimal?> _hcltv;
        public decimal? Hcltv { get { return _hcltv; } set { _hcltv = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHcltv() => !_hcltv.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _interestedPartyContribution;
        public decimal? InterestedPartyContribution { get { return _interestedPartyContribution; } set { _interestedPartyContribution = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestedPartyContribution() => !_interestedPartyContribution.Clean;
        private Value<decimal?> _ltv;
        public decimal? Ltv { get { return _ltv; } set { _ltv = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLtv() => !_ltv.Clean;
        private Value<string> _mornetPlusCaseFileId;
        public string MornetPlusCaseFileId { get { return _mornetPlusCaseFileId; } set { _mornetPlusCaseFileId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMornetPlusCaseFileId() => !_mornetPlusCaseFileId.Clean;
        private Value<string> _propertyInspectionWaiverMessage;
        public string PropertyInspectionWaiverMessage { get { return _propertyInspectionWaiverMessage; } set { _propertyInspectionWaiverMessage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyInspectionWaiverMessage() => !_propertyInspectionWaiverMessage.Clean;
        private Value<bool?> _startUpMortgage;
        public bool? StartUpMortgage { get { return _startUpMortgage; } set { _startUpMortgage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartUpMortgage() => !_startUpMortgage.Clean;
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
                    && _hcltv.Clean
                    && _id.Clean
                    && _interestedPartyContribution.Clean
                    && _ltv.Clean
                    && _mornetPlusCaseFileId.Clean
                    && _propertyInspectionWaiverMessage.Clean
                    && _startUpMortgage.Clean;
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
                var v5 = _hcltv; v5.Clean = value; _hcltv = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _interestedPartyContribution; v7.Clean = value; _interestedPartyContribution = v7;
                var v8 = _ltv; v8.Clean = value; _ltv = v8;
                var v9 = _mornetPlusCaseFileId; v9.Clean = value; _mornetPlusCaseFileId = v9;
                var v10 = _propertyInspectionWaiverMessage; v10.Clean = value; _propertyInspectionWaiverMessage = v10;
                var v11 = _startUpMortgage; v11.Clean = value; _startUpMortgage = v11;
                _settingClean = 0;
            }
        }
    }
}