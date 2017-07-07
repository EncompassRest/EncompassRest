using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class StatusOnlineEvent : IClean
    {
        private Value<string> _dateText;
        public string DateText { get { return _dateText; } set { _dateText = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _dateText.Clean
                    && _description.Clean
                    && _id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var dateText = _dateText; dateText.Clean = value; _dateText = dateText;
                var description = _description; description.Clean = value; _description = description;
                var id = _id; id.Clean = value; _id = id;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public StatusOnlineEvent()
        {
            Clean = true;
        }
    }
}