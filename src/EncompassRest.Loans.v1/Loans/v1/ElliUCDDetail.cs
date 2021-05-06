using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// ElliUCDDetail
    /// </summary>
    public sealed partial class ElliUCDDetail : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyDictionary<string, string?>? _cDFields;
        private DirtyDictionary<string, string?>? _lEFields;

        /// <summary>
        /// ElliUCDDetail CDFields
        /// </summary>
        [AllowNull]
        public IDictionary<string, string?> CDFields { get => GetField(ref _cDFields); set => SetField(ref _cDFields, value); }

        /// <summary>
        /// ElliUCDDetail LEFields
        /// </summary>
        [AllowNull]
        public IDictionary<string, string?> LEFields { get => GetField(ref _lEFields); set => SetField(ref _lEFields, value); }
    }
}