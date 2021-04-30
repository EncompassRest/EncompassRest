namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AccessToTPOTradeManagementRights
    /// </summary>
    public sealed class AccessToTPOTradeManagementRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _updateCorrespondentTrades;
        private DirtyValue<bool?>? _viewCorrespondentMasterCommitments;
        private DirtyValue<bool?>? _viewCorrespondentTrades;

        /// <summary>
        /// AccessToTPOTradeManagementRights UpdateCorrespondentTrades
        /// </summary>
        public bool? UpdateCorrespondentTrades { get => _updateCorrespondentTrades; set => SetField(ref _updateCorrespondentTrades, value); }

        /// <summary>
        /// AccessToTPOTradeManagementRights ViewCorrespondentMasterCommitments
        /// </summary>
        public bool? ViewCorrespondentMasterCommitments { get => _viewCorrespondentMasterCommitments; set => SetField(ref _viewCorrespondentMasterCommitments, value); }

        /// <summary>
        /// AccessToTPOTradeManagementRights ViewCorrespondentTrades
        /// </summary>
        public bool? ViewCorrespondentTrades { get => _viewCorrespondentTrades; set => SetField(ref _viewCorrespondentTrades, value); }
    }
}