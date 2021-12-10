using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// FannieMae
    /// </summary>
    public sealed partial class FannieMae : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _assetRepAndWarrantyMessage;
        private DirtyValue<bool?>? _assetRepAndWarrantyReliefAvailable;
        private DirtyValue<bool?>? _caseIDAssignedByUCDIndicator;
        private DirtyValue<decimal?>? _cltv;
        private DirtyValue<string?>? _collateralUnderwriterScore;
        private DirtyValue<StringEnumValue<Community2ndRepaymentStructure>>? _community2ndRepaymentStructure;
        private DirtyValue<bool?>? _communityLending;
        private DirtyValue<string?>? _correspondentAssignmentID;
        private DirtyValue<string?>? _duVersion;
        private DirtyValue<string?>? _eCStatus1003;
        private DirtyValue<string?>? _fannieMaeOwnedMessage;
        private DirtyValue<decimal?>? _hcltv;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _interestedPartyContribution;
        private DirtyValue<decimal?>? _ltv;
        private DirtyValue<string?>? _mornetPlusCaseFileId;
        private DirtyValue<string?>? _pIWMessage;
        private DirtyValue<string?>? _propertyInspectionWaiverMessage;
        private DirtyValue<bool?>? _startUpMortgage;
        private DirtyValue<string?>? _uCDCollectionStatus;
        private DirtyValue<string?>? _uCDPStatus;
        private DirtyValue<string?>? _uLDDECStatus;
        private DirtyValue<bool?>? _valueRepAndWarrantyAvailable;
        private DirtyValue<string?>? _valueRepAndWarrantyMessage;

        /// <summary>
        /// Fannie Mae - Borrower - Asset Validation Message [MORNET.X100]
        /// </summary>
        public string? AssetRepAndWarrantyMessage { get => _assetRepAndWarrantyMessage; set => SetField(ref _assetRepAndWarrantyMessage, value); }

        /// <summary>
        /// Fannie Mae - Borrower - Asset Validation [MORNET.X103]
        /// </summary>
        public bool? AssetRepAndWarrantyReliefAvailable { get => _assetRepAndWarrantyReliefAvailable; set => SetField(ref _assetRepAndWarrantyReliefAvailable, value); }

        /// <summary>
        /// Fannie Mae Case File ID # Assigned by UCD [MORNET.X125]
        /// </summary>
        public bool? CaseIDAssignedByUCDIndicator { get => _caseIDAssignedByUCDIndicator; set => SetField(ref _caseIDAssignedByUCDIndicator, value); }

        /// <summary>
        /// Fannie Mae MORNETPlus CLTV [MORNET.X76]
        /// </summary>
        public decimal? Cltv { get => _cltv; set => SetField(ref _cltv, value); }

        /// <summary>
        /// Fannie Mae Collateral Underwriter Score [MORNET.X92]
        /// </summary>
        public string? CollateralUnderwriterScore { get => _collateralUnderwriterScore; set => SetField(ref _collateralUnderwriterScore, value); }

        /// <summary>
        /// Fannie Mae Community Seconds Repayment Structure [MORNET.X73]
        /// </summary>
        public StringEnumValue<Community2ndRepaymentStructure> Community2ndRepaymentStructure { get => _community2ndRepaymentStructure; set => SetField(ref _community2ndRepaymentStructure, value); }

        /// <summary>
        /// Fannie Mae Community Lending [MORNET.X72]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Community Lending\"}")]
        public bool? CommunityLending { get => _communityLending; set => SetField(ref _communityLending, value); }

        /// <summary>
        /// Fannie Mae Correspondent Assignment Center ID [MORNET.X126]
        /// </summary>
        public string? CorrespondentAssignmentID { get => _correspondentAssignmentID; set => SetField(ref _correspondentAssignmentID, value); }

        /// <summary>
        /// Fannie Mae MORNETPlus Version Number [MORNET.X74]
        /// </summary>
        public string? DuVersion { get => _duVersion; set => SetField(ref _duVersion, value); }

        /// <summary>
        /// Fannie Mae 1003 EC Status [MORNET.X94]
        /// </summary>
        public string? ECStatus1003 { get => _eCStatus1003; set => SetField(ref _eCStatus1003, value); }

        /// <summary>
        /// Fannie Mae Owned Message [MORNET.X157]
        /// </summary>
        public string? FannieMaeOwnedMessage { get => _fannieMaeOwnedMessage; set => SetField(ref _fannieMaeOwnedMessage, value); }

        /// <summary>
        /// Fannie Mae MORNETPlus HCLTV and HTLTV [MORNET.X77]
        /// </summary>
        public decimal? Hcltv { get => _hcltv; set => SetField(ref _hcltv, value); }

        /// <summary>
        /// FannieMae Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Interested Party Contribution [MORNET.X78]
        /// </summary>
        public decimal? InterestedPartyContribution { get => _interestedPartyContribution; set => SetField(ref _interestedPartyContribution, value); }

        /// <summary>
        /// Fannie Mae MORNETPlus LTV [MORNET.X75]
        /// </summary>
        public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }

        /// <summary>
        /// Fannie Mae MORNETPlus Case File ID # [MORNET.X4]
        /// </summary>
        public string? MornetPlusCaseFileId { get => _mornetPlusCaseFileId; set => SetField(ref _mornetPlusCaseFileId, value); }

        /// <summary>
        /// Fannie Mae - Borrower - PIW Message [MORNET.X97]
        /// </summary>
        public string? PIWMessage { get => _pIWMessage; set => SetField(ref _pIWMessage, value); }

        /// <summary>
        /// Fannie Mae Property Inspection Waiver Message [MORNET.X91]
        /// </summary>
        public string? PropertyInspectionWaiverMessage { get => _propertyInspectionWaiverMessage; set => SetField(ref _propertyInspectionWaiverMessage, value); }

        /// <summary>
        /// Fannie Mae Start-Up Mtg [MORNET.X11]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Start-up Mortgage\"}")]
        public bool? StartUpMortgage { get => _startUpMortgage; set => SetField(ref _startUpMortgage, value); }

        /// <summary>
        /// Fannie Mae UCD Collection Status [MORNET.X96]
        /// </summary>
        public string? UCDCollectionStatus { get => _uCDCollectionStatus; set => SetField(ref _uCDCollectionStatus, value); }

        /// <summary>
        /// Fannie Mae UCDP Status [MORNET.X93]
        /// </summary>
        public string? UCDPStatus { get => _uCDPStatus; set => SetField(ref _uCDPStatus, value); }

        /// <summary>
        /// Fannie Mae ULDD EC Status [MORNET.X95]
        /// </summary>
        public string? ULDDECStatus { get => _uLDDECStatus; set => SetField(ref _uLDDECStatus, value); }

        /// <summary>
        /// Fannie Mae - Borrower - Value Rep and Warranty [MORNET.X102]
        /// </summary>
        public bool? ValueRepAndWarrantyAvailable { get => _valueRepAndWarrantyAvailable; set => SetField(ref _valueRepAndWarrantyAvailable, value); }

        /// <summary>
        /// Fannie Mae - Borrower - Value Rep and Warranty Message [MORNET.X98]
        /// </summary>
        public string? ValueRepAndWarrantyMessage { get => _valueRepAndWarrantyMessage; set => SetField(ref _valueRepAndWarrantyMessage, value); }
    }
}