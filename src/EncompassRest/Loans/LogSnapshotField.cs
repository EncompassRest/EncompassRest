using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var fieldID = _fieldID; fieldID.Clean = value; _fieldID = fieldID;
                var id = _id; id.Clean = value; _id = id;
                var modalPath = _modalPath; modalPath.Clean = value; _modalPath = modalPath;
                var v = _value; v.Clean = value; _value = v;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LogSnapshotField()
        {
            Clean = true;
        }
    }
}