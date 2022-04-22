namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToTPOTradeManagementRights
    /// </summary>
    public sealed class AccessToTPOTradeManagementRights : ParentAccessRights
    {
        /// <summary>
        /// AccessToTPOTradeManagementRights UpdateCorrespondentTrades
        /// </summary>
        public bool? UpdateCorrespondentTrades { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToTPOTradeManagementRights ViewCorrespondentMasterCommitments
        /// </summary>
        public bool? ViewCorrespondentMasterCommitments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToTPOTradeManagementRights ViewCorrespondentTrades
        /// </summary>
        public bool? ViewCorrespondentTrades { get => GetValue<bool?>(); set => SetValue(value); }
    }
}