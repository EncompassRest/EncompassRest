namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// CorrespondentTradesRights
    /// </summary>
    public sealed class CorrespondentTradesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editCorrespondentTrades;

        /// <summary>
        /// CorrespondentTradesRights EditCorrespondentTrades
        /// </summary>
        public bool? EditCorrespondentTrades { get => _editCorrespondentTrades; set => SetField(ref _editCorrespondentTrades, value); }
    }
}