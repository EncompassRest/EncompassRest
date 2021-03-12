namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// SecurityTradesRights
    /// </summary>
    public sealed class SecurityTradesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editSecurityTrades;

        /// <summary>
        /// SecurityTradesRights EditSecurityTrades
        /// </summary>
        public bool? EditSecurityTrades { get => _editSecurityTrades; set => SetField(ref _editSecurityTrades, value); }
    }
}