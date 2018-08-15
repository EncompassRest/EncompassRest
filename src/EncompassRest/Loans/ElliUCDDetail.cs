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
        public IDictionary<string, string> CDFields { get => GetField(ref _cDFields); set => SetField(ref _cDFields, value); }
        private DirtyDictionary<string, string> _lEFields;
        /// <summary>
        /// ElliUCDDetail LEFields
        /// </summary>
        public IDictionary<string, string> LEFields { get => GetField(ref _lEFields); set => SetField(ref _lEFields, value); }
    }
}