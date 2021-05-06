namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LoanSearchRights
    /// </summary>
    public sealed class LoanSearchRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editLoanSearch;

        /// <summary>
        /// LoanSearchRights EditLoanSearch
        /// </summary>
        public bool? EditLoanSearch { get => _editLoanSearch; set => SetField(ref _editLoanSearch, value); }
    }
}