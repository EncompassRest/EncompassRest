using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FieldLockData
    {
        public Value<bool?> LockRemoved { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockRemoved() => !LockRemoved.Clean;
        public Value<string> ModelPath { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModelPath() => !ModelPath.Clean;
        public Value<string> Value { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeValue() => !Value.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = LockRemoved.Clean
                    && ModelPath.Clean
                    && Value.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = LockRemoved; v0.Clean = value; LockRemoved = v0;
                var v1 = ModelPath; v1.Clean = value; ModelPath = v1;
                var v2 = Value; v2.Clean = value; Value = v2;
                _settingClean = 0;
            }
        }
    }
}