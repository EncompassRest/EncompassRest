using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010WholePoc
    {
        public Value<int?> Gfe2010WholePocIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010WholePocIndex() => !Gfe2010WholePocIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<int?> LineNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !LineNumber.Clean;
        public Value<decimal?> WholePoc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWholePoc() => !WholePoc.Clean;
        public Value<string> WholePocPaidByType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWholePocPaidByType() => !WholePocPaidByType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Gfe2010WholePocIndex.Clean
                    && Id.Clean
                    && LineNumber.Clean
                    && WholePoc.Clean
                    && WholePocPaidByType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Gfe2010WholePocIndex; v0.Clean = value; Gfe2010WholePocIndex = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = LineNumber; v2.Clean = value; LineNumber = v2;
                var v3 = WholePoc; v3.Clean = value; WholePoc = v3;
                var v4 = WholePocPaidByType; v4.Clean = value; WholePocPaidByType = v4;
                _settingClean = 0;
            }
        }
    }
}