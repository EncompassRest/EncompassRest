namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TradeMgmtRights
    /// </summary>
    public sealed class TradeMgmtRights : ParentAccessRights
    {
        /// <summary>
        /// TradeMgmtRights EditTradeMgmt
        /// </summary>
        public bool? EditTradeMgmt { get => GetValue<bool?>(); set => SetValue(value); }
    }
}