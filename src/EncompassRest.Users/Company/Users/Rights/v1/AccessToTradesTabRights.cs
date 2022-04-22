using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToTradesTabRights
    /// </summary>
    public sealed class AccessToTradesTabRights : ParentAccessRights
    {
        /// <summary>
        /// AccessToTradesTabRights BidTapeManagement
        /// </summary>
        [AllowNull]
        public BidTapeManagementRights BidTapeManagement { get => GetEntity<BidTapeManagementRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights CorrespondentMasters
        /// </summary>
        [AllowNull]
        public CorrespondentMastersRights CorrespondentMasters { get => GetEntity<CorrespondentMastersRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights CorrespondentTrades
        /// </summary>
        [AllowNull]
        public CorrespondentTradesRights CorrespondentTrades { get => GetEntity<CorrespondentTradesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights GSECommitments
        /// </summary>
        [AllowNull]
        public GSECommitmentsRights GSECommitments { get => GetEntity<GSECommitmentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights LoanSearch
        /// </summary>
        [AllowNull]
        public LoanSearchRights LoanSearch { get => GetEntity<LoanSearchRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights LoanTrades
        /// </summary>
        [AllowNull]
        public LoanTradesRights LoanTrades { get => GetEntity<LoanTradesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights MasterCommitments
        /// </summary>
        [AllowNull]
        public MasterCommitmentsRights MasterCommitments { get => GetEntity<MasterCommitmentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights MBSPools
        /// </summary>
        [AllowNull]
        public MBSPoolsRights MBSPools { get => GetEntity<MBSPoolsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToTradesTabRights SecurityTrades
        /// </summary>
        [AllowNull]
        public SecurityTradesRights SecurityTrades { get => GetEntity<SecurityTradesRights>(); set => SetEntity(value); }
    }
}