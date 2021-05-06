namespace EncompassRest.Company.Users.Rights.v1
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