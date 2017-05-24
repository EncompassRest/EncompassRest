using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LogSnapshotField
    {
        public Value<string> FieldID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFieldID() => !FieldID.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> ModalPath { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModalPath() => !ModalPath.Clean;
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
                var clean = FieldID.Clean
                    && Id.Clean
                    && ModalPath.Clean
                    && Value.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = FieldID; v0.Clean = value; FieldID = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = ModalPath; v2.Clean = value; ModalPath = v2;
                var v3 = Value; v3.Clean = value; Value = v3;
                _settingClean = 0;
            }
        }
    }
}