namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// LoanProgramsRights
    /// </summary>
    public sealed class LoanProgramsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _allowImport;

        /// <summary>
        /// LoanProgramsRights AllowImport
        /// </summary>
        public bool? AllowImport { get => _allowImport; set => SetField(ref _allowImport, value); }
    }
}