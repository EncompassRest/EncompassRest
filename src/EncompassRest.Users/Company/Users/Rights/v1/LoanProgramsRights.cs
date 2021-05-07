namespace EncompassRest.Company.Users.Rights.v1
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