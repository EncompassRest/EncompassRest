namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TradesRights
    /// </summary>
    public sealed class TradesRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _accessToTradesTab;

        /// <summary>
        /// TradesRights AccessToTradesTab
        /// </summary>
        public bool? AccessToTradesTab { get => _accessToTradesTab; set => SetField(ref _accessToTradesTab, value); }
    }
}