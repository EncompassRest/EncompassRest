namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LoanSearchRights
    /// </summary>
    public sealed class LoanSearchRights : ParentAccessRights
    {
        /// <summary>
        /// LoanSearchRights EditLoanSearch
        /// </summary>
        public bool? EditLoanSearch { get => GetValue<bool?>(); set => SetValue(value); }
    }
}