using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AccessToTradesTabRights
    /// </summary>
    public sealed class AccessToTradesTabRights : ParentAccessRights
    {
        private BidTapeManagementRights? _bidTapeManagement;
        private CorrespondentMastersRights? _correspondentMasters;
        private CorrespondentTradesRights? _correspondentTrades;
        private GSECommitmentsRights? _gSECommitments;
        private LoanSearchRights? _loanSearch;
        private LoanTradesRights? _loanTrades;
        private MasterCommitmentsRights? _masterCommitments;
        private MBSPoolsRights? _mBSPools;
        private SecurityTradesRights? _securityTrades;

        /// <summary>
        /// AccessToTradesTabRights BidTapeManagement
        /// </summary>
        [AllowNull]
        public BidTapeManagementRights BidTapeManagement { get => GetField(ref _bidTapeManagement); set => SetField(ref _bidTapeManagement, value); }

        /// <summary>
        /// AccessToTradesTabRights CorrespondentMasters
        /// </summary>
        [AllowNull]
        public CorrespondentMastersRights CorrespondentMasters { get => GetField(ref _correspondentMasters); set => SetField(ref _correspondentMasters, value); }

        /// <summary>
        /// AccessToTradesTabRights CorrespondentTrades
        /// </summary>
        [AllowNull]
        public CorrespondentTradesRights CorrespondentTrades { get => GetField(ref _correspondentTrades); set => SetField(ref _correspondentTrades, value); }

        /// <summary>
        /// AccessToTradesTabRights GSECommitments
        /// </summary>
        [AllowNull]
        public GSECommitmentsRights GSECommitments { get => GetField(ref _gSECommitments); set => SetField(ref _gSECommitments, value); }

        /// <summary>
        /// AccessToTradesTabRights LoanSearch
        /// </summary>
        [AllowNull]
        public LoanSearchRights LoanSearch { get => GetField(ref _loanSearch); set => SetField(ref _loanSearch, value); }

        /// <summary>
        /// AccessToTradesTabRights LoanTrades
        /// </summary>
        [AllowNull]
        public LoanTradesRights LoanTrades { get => GetField(ref _loanTrades); set => SetField(ref _loanTrades, value); }

        /// <summary>
        /// AccessToTradesTabRights MasterCommitments
        /// </summary>
        [AllowNull]
        public MasterCommitmentsRights MasterCommitments { get => GetField(ref _masterCommitments); set => SetField(ref _masterCommitments, value); }

        /// <summary>
        /// AccessToTradesTabRights MBSPools
        /// </summary>
        [AllowNull]
        public MBSPoolsRights MBSPools { get => GetField(ref _mBSPools); set => SetField(ref _mBSPools, value); }

        /// <summary>
        /// AccessToTradesTabRights SecurityTrades
        /// </summary>
        [AllowNull]
        public SecurityTradesRights SecurityTrades { get => GetField(ref _securityTrades); set => SetField(ref _securityTrades, value); }
    }
}