namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LoanTradesRights
    /// </summary>
    public sealed class LoanTradesRights : ParentAccessRights
    {
        /// <summary>
        /// LoanTradesRights EditLoanTrades
        /// </summary>
        public bool? EditLoanTrades { get => GetValue<bool?>(); set => SetValue(value); }
    }
}