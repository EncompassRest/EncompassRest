using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// TradesRights
    /// </summary>
    public sealed class TradesRights : DirtyExtensibleObject
    {
        private AccessToTradesTabRights? _accessToTradesTab;
        private DirtyValue<bool?>? _editTrades;

        /// <summary>
        /// TradesRights AccessToTradesTab
        /// </summary>
        [AllowNull]
        public AccessToTradesTabRights AccessToTradesTab { get => GetField(ref _accessToTradesTab); set => SetField(ref _accessToTradesTab, value); }

        /// <summary>
        /// TradesRights EditTrades
        /// </summary>
        public bool? EditTrades { get => _editTrades; set => SetField(ref _editTrades, value); }
    }
}