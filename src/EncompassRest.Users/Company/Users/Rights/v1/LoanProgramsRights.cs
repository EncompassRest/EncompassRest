namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LoanProgramsRights
    /// </summary>
    public sealed class LoanProgramsRights : ParentAccessRights
    {
        /// <summary>
        /// LoanProgramsRights AllowImport
        /// </summary>
        public bool? AllowImport { get => GetValue<bool?>(); set => SetValue(value); }
    }
}