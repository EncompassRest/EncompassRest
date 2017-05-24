using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureForm
    {
        public Value<string> FormName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormName() => !FormName.Clean;
        public Value<string> FormType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormType() => !FormType.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = FormName.Clean
                    && FormType.Clean
                    && Id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = FormName; v0.Clean = value; FormName = v0;
                var v1 = FormType; v1.Clean = value; FormType = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                _settingClean = 0;
            }
        }
    }
}