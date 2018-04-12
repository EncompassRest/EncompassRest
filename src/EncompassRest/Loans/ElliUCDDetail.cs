#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ElliUCDDetail : ExtensibleObject, IIdentifiable
    {
        private DirtyDictionary<string, string> _cDFields;
        public IDictionary<string, string> CDFields { get => _cDFields ?? (_cDFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _cDFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }
        private DirtyDictionary<string, string> _lEFields;
        public IDictionary<string, string> LEFields { get => _lEFields ?? (_lEFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _lEFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }
        internal override bool DirtyInternal
        {
            get
            {
                return _cDFields?.Dirty == true
                    || _lEFields?.Dirty == true;
            }
            set
            {
                if (_cDFields != null) _cDFields.Dirty = value;
                if (_lEFields != null) _lEFields.Dirty = value;
            }
        }
    }
}