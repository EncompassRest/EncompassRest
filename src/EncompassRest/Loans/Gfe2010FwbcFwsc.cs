using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010FwbcFwsc
    {
        public Value<string> Fwbc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFwbc() => !Fwbc.Clean;
        public Value<string> Fwsc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFwsc() => !Fwsc.Clean;
        public Value<int?> Gfe2010FwbcFwscIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010FwbcFwscIndex() => !Gfe2010FwbcFwscIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LineLetter { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineLetter() => !LineLetter.Clean;
        public Value<int?> LineNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNumber() => !LineNumber.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Fwbc.Clean
                    && Fwsc.Clean
                    && Gfe2010FwbcFwscIndex.Clean
                    && Id.Clean
                    && LineLetter.Clean
                    && LineNumber.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Fwbc; v0.Clean = value; Fwbc = v0;
                var v1 = Fwsc; v1.Clean = value; Fwsc = v1;
                var v2 = Gfe2010FwbcFwscIndex; v2.Clean = value; Gfe2010FwbcFwscIndex = v2;
                var v3 = Id; v3.Clean = value; Id = v3;
                var v4 = LineLetter; v4.Clean = value; LineLetter = v4;
                var v5 = LineNumber; v5.Clean = value; LineNumber = v5;
                _settingClean = 0;
            }
        }
    }
}