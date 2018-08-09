using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ElliUCDDetail
    /// </summary>
    public sealed partial class ElliUCDDetail : ExtensibleObject, IIdentifiable
    {
        private DirtyDictionary<string, string> _cDFields;
        /// <summary>
        /// ElliUCDDetail CDFields
        /// </summary>
        public IDictionary<string, string> CDFields { get => _cDFields ?? (_cDFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _cDFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }
        private DirtyDictionary<string, string> _lEFields;
        /// <summary>
        /// ElliUCDDetail LEFields
        /// </summary>
        public IDictionary<string, string> LEFields { get => _lEFields ?? (_lEFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _lEFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }
    }
}