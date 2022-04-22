using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MoveLoansRights
    /// </summary>
    public sealed class MoveLoansRights : ParentAccessRights
    {
        /// <summary>
        /// MoveLoansRights MoveFrom
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> MoveFrom { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// MoveLoansRights MoveTo
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> MoveTo { get => GetDictionary<string, bool>(); set => SetDictionary(value); }
    }
}