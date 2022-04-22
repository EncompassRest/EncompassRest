using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ManageBorrowersRights
    /// </summary>
    public sealed class ManageBorrowersRights : ParentAccessRights
    {
        /// <summary>
        /// ManageBorrowersRights ImportBorrowers
        /// </summary>
        [AllowNull]
        public ImportBorrowersRights ImportBorrowers { get => GetEntity<ImportBorrowersRights>(); set => SetEntity(value); }

        /// <summary>
        /// ManageBorrowersRights MoveBorrowers
        /// </summary>
        public bool? MoveBorrowers { get => GetValue<bool?>(); set => SetValue(value); }
    }
}