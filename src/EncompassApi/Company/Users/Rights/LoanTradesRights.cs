namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// LoanTradesRights
    /// </summary>
    public sealed class LoanTradesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editLoanTrades;

        /// <summary>
        /// LoanTradesRights EditLoanTrades
        /// </summary>
        public bool? EditLoanTrades { get => _editLoanTrades; set => SetField(ref _editLoanTrades, value); }
    }
}