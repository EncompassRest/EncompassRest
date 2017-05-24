using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class UCDDetail
    {
        public Value<string> FeeAccountType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAccountType() => !FeeAccountType.Clean;
        public Value<decimal?> FeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeAmount() => !FeeAmount.Clean;
        public Value<DateTime?> FeeDateFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDateFrom() => !FeeDateFrom.Clean;
        public Value<DateTime?> FeeDateTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDateTo() => !FeeDateTo.Clean;
        public Value<string> FeeDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeDesc() => !FeeDesc.Clean;
        public Value<int?> FeeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeIndex() => !FeeIndex.Clean;
        public Value<string> FeePaidTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeePaidTo() => !FeePaidTo.Clean;
        public Value<bool?> FeePOC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeePOC() => !FeePOC.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<int?> LineNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !LineNumber.Clean;
        public Value<string> Section { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection() => !Section.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = FeeAccountType.Clean
                    && FeeAmount.Clean
                    && FeeDateFrom.Clean
                    && FeeDateTo.Clean
                    && FeeDesc.Clean
                    && FeeIndex.Clean
                    && FeePaidTo.Clean
                    && FeePOC.Clean
                    && Id.Clean
                    && LineNumber.Clean
                    && Section.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = FeeAccountType; v0.Clean = value; FeeAccountType = v0;
                var v1 = FeeAmount; v1.Clean = value; FeeAmount = v1;
                var v2 = FeeDateFrom; v2.Clean = value; FeeDateFrom = v2;
                var v3 = FeeDateTo; v3.Clean = value; FeeDateTo = v3;
                var v4 = FeeDesc; v4.Clean = value; FeeDesc = v4;
                var v5 = FeeIndex; v5.Clean = value; FeeIndex = v5;
                var v6 = FeePaidTo; v6.Clean = value; FeePaidTo = v6;
                var v7 = FeePOC; v7.Clean = value; FeePOC = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = LineNumber; v9.Clean = value; LineNumber = v9;
                var v10 = Section; v10.Clean = value; Section = v10;
                _settingClean = 0;
            }
        }
    }
}