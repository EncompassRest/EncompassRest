using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ManageBorrowersRights
    /// </summary>
    public sealed class ManageBorrowersRights : ParentAccessRights
    {
        private ImportBorrowersRights? _importBorrowers;
        private DirtyValue<bool?>? _moveBorrowers;

        /// <summary>
        /// ManageBorrowersRights ImportBorrowers
        /// </summary>
        [AllowNull]
        public ImportBorrowersRights ImportBorrowers { get => GetField(ref _importBorrowers); set => SetField(ref _importBorrowers, value); }

        /// <summary>
        /// ManageBorrowersRights MoveBorrowers
        /// </summary>
        public bool? MoveBorrowers { get => _moveBorrowers; set => SetField(ref _moveBorrowers, value); }
    }
}