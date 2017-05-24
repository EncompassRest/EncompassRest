using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FannieMae
    {
        public Value<decimal?> Cltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCltv() => !Cltv.Clean;
        public Value<string> CollateralUnderwriterScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCollateralUnderwriterScore() => !CollateralUnderwriterScore.Clean;
        public Value<string> Community2ndRepaymentStructure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommunity2ndRepaymentStructure() => !Community2ndRepaymentStructure.Clean;
        public Value<bool?> CommunityLending { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommunityLending() => !CommunityLending.Clean;
        public Value<string> DuVersion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuVersion() => !DuVersion.Clean;
        public Value<decimal?> Hcltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHcltv() => !Hcltv.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InterestedPartyContribution { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestedPartyContribution() => !InterestedPartyContribution.Clean;
        public Value<decimal?> Ltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLtv() => !Ltv.Clean;
        public Value<string> MornetPlusCaseFileId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMornetPlusCaseFileId() => !MornetPlusCaseFileId.Clean;
        public Value<string> PropertyInspectionWaiverMessage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyInspectionWaiverMessage() => !PropertyInspectionWaiverMessage.Clean;
        public Value<bool?> StartUpMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartUpMortgage() => !StartUpMortgage.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Cltv.Clean
                    && CollateralUnderwriterScore.Clean
                    && Community2ndRepaymentStructure.Clean
                    && CommunityLending.Clean
                    && DuVersion.Clean
                    && Hcltv.Clean
                    && Id.Clean
                    && InterestedPartyContribution.Clean
                    && Ltv.Clean
                    && MornetPlusCaseFileId.Clean
                    && PropertyInspectionWaiverMessage.Clean
                    && StartUpMortgage.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Cltv; v0.Clean = value; Cltv = v0;
                var v1 = CollateralUnderwriterScore; v1.Clean = value; CollateralUnderwriterScore = v1;
                var v2 = Community2ndRepaymentStructure; v2.Clean = value; Community2ndRepaymentStructure = v2;
                var v3 = CommunityLending; v3.Clean = value; CommunityLending = v3;
                var v4 = DuVersion; v4.Clean = value; DuVersion = v4;
                var v5 = Hcltv; v5.Clean = value; Hcltv = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = InterestedPartyContribution; v7.Clean = value; InterestedPartyContribution = v7;
                var v8 = Ltv; v8.Clean = value; Ltv = v8;
                var v9 = MornetPlusCaseFileId; v9.Clean = value; MornetPlusCaseFileId = v9;
                var v10 = PropertyInspectionWaiverMessage; v10.Clean = value; PropertyInspectionWaiverMessage = v10;
                var v11 = StartUpMortgage; v11.Clean = value; StartUpMortgage = v11;
                _settingClean = 0;
            }
        }
    }
}