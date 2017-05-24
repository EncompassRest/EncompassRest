using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureForm
    {
        private Value<string> _formName;
        public string FormName { get { return _formName; } set { _formName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormName() => !_formName.Clean;
        private Value<string> _formType;
        public string FormType { get { return _formType; } set { _formType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormType() => !_formType.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _formName.Clean
                    && _formType.Clean
                    && _id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _formName; v0.Clean = value; _formName = v0;
                var v1 = _formType; v1.Clean = value; _formType = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                _settingClean = 0;
            }
        }
    }
}