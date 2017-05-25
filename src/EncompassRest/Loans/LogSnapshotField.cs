using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LogSnapshotField : IClean
    {
        private Value<string> _fieldID;
        public string FieldID { get { return _fieldID; } set { _fieldID = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _modalPath;
        public string ModalPath { get { return _modalPath; } set { _modalPath = value; } }
        private Value<string> _value;
        public string Value { get { return _value; } set { _value = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _fieldID.Clean
                    && _id.Clean
                    && _modalPath.Clean
                    && _value.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _fieldID; v0.Clean = value; _fieldID = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _modalPath; v2.Clean = value; _modalPath = v2;
                var v3 = _value; v3.Clean = value; _value = v3;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}