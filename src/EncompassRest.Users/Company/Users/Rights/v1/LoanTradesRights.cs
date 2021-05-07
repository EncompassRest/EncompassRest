namespace EncompassRest.Company.Users.Rights.v1
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