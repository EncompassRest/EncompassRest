using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// MoveLoansRights
    /// </summary>
    public sealed class MoveLoansRights : ParentAccessRights
    {
        private DirtyDictionary<string, bool>? _moveFrom;
        private DirtyDictionary<string, bool>? _moveTo;

        /// <summary>
        /// MoveLoansRights MoveFrom
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> MoveFrom { get => GetField(ref _moveFrom); set => SetField(ref _moveFrom, value); }

        /// <summary>
        /// MoveLoansRights MoveTo
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> MoveTo { get => GetField(ref _moveTo); set => SetField(ref _moveTo, value); }
    }
}