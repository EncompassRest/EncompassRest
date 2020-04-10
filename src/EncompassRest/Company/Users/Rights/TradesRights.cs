namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TradesRights
    /// </summary>
    public sealed class TradesRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _accessToTradesTab;
        private DirtyValue<bool?>? _editTrades;

        /// <summary>
        /// TradesRights AccessToTradesTab
        /// </summary>
        public bool? AccessToTradesTab { get => _accessToTradesTab; set => SetField(ref _accessToTradesTab, value); }

        /// <summary>
        /// TradesRights EditTrades
        /// </summary>
        public bool? EditTrades { get => _editTrades; set => SetField(ref _editTrades, value); }
    }
}