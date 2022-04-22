namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SecurityTradesRights
    /// </summary>
    public sealed class SecurityTradesRights : ParentAccessRights
    {
        /// <summary>
        /// SecurityTradesRights EditSecurityTrades
        /// </summary>
        public bool? EditSecurityTrades { get => GetValue<bool?>(); set => SetValue(value); }
    }
}