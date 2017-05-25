using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EdmDocument : IClean
    {
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _id.Clean
                    && _title.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _id; v0.Clean = value; _id = v0;
                var v1 = _title; v1.Clean = value; _title = v1;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}