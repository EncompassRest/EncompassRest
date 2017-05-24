using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class SecondaryFinancingProvider
    {
        public Value<decimal?> FinancingAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancingAmount() => !FinancingAmount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> SecondaryFinancingProviderType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondaryFinancingProviderType() => !SecondaryFinancingProviderType.Clean;
        public Value<bool?> SellerFundedDapIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerFundedDapIndicator() => !SellerFundedDapIndicator.Clean;
        public Value<string> Source { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSource() => !Source.Clean;
        public Value<bool?> SourceFromFamilyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromFamilyIndicator() => !SourceFromFamilyIndicator.Clean;
        public Value<bool?> SourceFromGovernmentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromGovernmentIndicator() => !SourceFromGovernmentIndicator.Clean;
        public Value<bool?> SourceFromNPIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromNPIndicator() => !SourceFromNPIndicator.Clean;
        public Value<bool?> SourceFromOtherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceFromOtherIndicator() => !SourceFromOtherIndicator.Clean;
        public Value<string> SourceOtherDetail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceOtherDetail() => !SourceOtherDetail.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = FinancingAmount.Clean
                    && Id.Clean
                    && SecondaryFinancingProviderType.Clean
                    && SellerFundedDapIndicator.Clean
                    && Source.Clean
                    && SourceFromFamilyIndicator.Clean
                    && SourceFromGovernmentIndicator.Clean
                    && SourceFromNPIndicator.Clean
                    && SourceFromOtherIndicator.Clean
                    && SourceOtherDetail.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = FinancingAmount; v0.Clean = value; FinancingAmount = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = SecondaryFinancingProviderType; v2.Clean = value; SecondaryFinancingProviderType = v2;
                var v3 = SellerFundedDapIndicator; v3.Clean = value; SellerFundedDapIndicator = v3;
                var v4 = Source; v4.Clean = value; Source = v4;
                var v5 = SourceFromFamilyIndicator; v5.Clean = value; SourceFromFamilyIndicator = v5;
                var v6 = SourceFromGovernmentIndicator; v6.Clean = value; SourceFromGovernmentIndicator = v6;
                var v7 = SourceFromNPIndicator; v7.Clean = value; SourceFromNPIndicator = v7;
                var v8 = SourceFromOtherIndicator; v8.Clean = value; SourceFromOtherIndicator = v8;
                var v9 = SourceOtherDetail; v9.Clean = value; SourceOtherDetail = v9;
                _settingClean = 0;
            }
        }
    }
}