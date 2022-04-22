using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TradesRights
    /// </summary>
    public sealed class TradesRights : DirtyExtensibleObject
    {
        /// <summary>
        /// TradesRights AccessToTradesTab
        /// </summary>
        [AllowNull]
        public AccessToTradesTabRights AccessToTradesTab { get => GetEntity<AccessToTradesTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// TradesRights EditTrades
        /// </summary>
        public bool? EditTrades { get => GetValue<bool?>(); set => SetValue(value); }
    }
}