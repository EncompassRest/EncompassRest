namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TradeMgmtRights
    /// </summary>
    public sealed class TradeMgmtRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTradeMgmt;

        /// <summary>
        /// TradeMgmtRights EditTradeMgmt
        /// </summary>
        public bool? EditTradeMgmt { get => _editTradeMgmt; set => SetField(ref _editTradeMgmt, value); }
    }
}