using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// FannieMae
/// </summary>
public sealed partial class FannieMae : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _assetRepAndWarrantyMessage;
    private DirtyValue<bool?>? _assetRepAndWarrantyReliefAvailable;
    private DirtyValue<bool?>? _caseIdAssignedByUcdIndicator;
    private DirtyValue<decimal?>? _cltv;
    private DirtyValue<string?>? _collateralUnderwriterScore;
    private DirtyValue<StringEnumValue<Community2ndRepaymentStructure>>? _community2ndRepaymentStructure;
    private DirtyValue<bool?>? _communityLending;
    private DirtyValue<string?>? _correspondentAssignmentId;
    private DirtyValue<string?>? _duVersion;
    private DirtyValue<string?>? _ecStatus1003;
    private DirtyValue<string?>? _fannieMaeOwnedMessage;
    private DirtyValue<decimal?>? _hcltv;
    private DirtyValue<decimal?>? _interestedPartyContribution;
    private DirtyValue<decimal?>? _ltv;
    private DirtyValue<string?>? _mornetPlusCaseFileId;
    private DirtyValue<string?>? _piwMessage;
    private DirtyValue<string?>? _propertyInspectionWaiverMessage;
    private DirtyValue<bool?>? _startUpMortgage;
    private DirtyValue<string?>? _ucdCollectionStatus;
    private DirtyValue<string?>? _ucdpStatus;
    private DirtyValue<string?>? _ulddecStatus;
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
    public bool? CaseIdAssignedByUcdIndicator { get => _caseIdAssignedByUcdIndicator; set => SetField(ref _caseIdAssignedByUcdIndicator, value); }

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
    public bool? CommunityLending { get => _communityLending; set => SetField(ref _communityLending, value); }

    /// <summary>
    /// Fannie Mae Correspondent Assignment Center ID [MORNET.X126]
    /// </summary>
    public string? CorrespondentAssignmentId { get => _correspondentAssignmentId; set => SetField(ref _correspondentAssignmentId, value); }

    /// <summary>
    /// Fannie Mae MORNETPlus Version Number [MORNET.X74]
    /// </summary>
    public string? DuVersion { get => _duVersion; set => SetField(ref _duVersion, value); }

    /// <summary>
    /// Fannie Mae 1003 EC Status [MORNET.X94]
    /// </summary>
    public string? EcStatus1003 { get => _ecStatus1003; set => SetField(ref _ecStatus1003, value); }

    /// <summary>
    /// Fannie Mae Owned Message [MORNET.X157]
    /// </summary>
    public string? FannieMaeOwnedMessage { get => _fannieMaeOwnedMessage; set => SetField(ref _fannieMaeOwnedMessage, value); }

    /// <summary>
    /// Fannie Mae MORNETPlus HCLTV and HTLTV [MORNET.X77]
    /// </summary>
    public decimal? Hcltv { get => _hcltv; set => SetField(ref _hcltv, value); }

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
    public string? PiwMessage { get => _piwMessage; set => SetField(ref _piwMessage, value); }

    /// <summary>
    /// Fannie Mae Property Inspection Waiver Message [MORNET.X91]
    /// </summary>
    public string? PropertyInspectionWaiverMessage { get => _propertyInspectionWaiverMessage; set => SetField(ref _propertyInspectionWaiverMessage, value); }

    /// <summary>
    /// Fannie Mae Start-Up Mtg [MORNET.X11]
    /// </summary>
    public bool? StartUpMortgage { get => _startUpMortgage; set => SetField(ref _startUpMortgage, value); }

    /// <summary>
    /// Fannie Mae UCD Collection Status [MORNET.X96]
    /// </summary>
    public string? UcdCollectionStatus { get => _ucdCollectionStatus; set => SetField(ref _ucdCollectionStatus, value); }

    /// <summary>
    /// Fannie Mae UCDP Status [MORNET.X93]
    /// </summary>
    public string? UcdpStatus { get => _ucdpStatus; set => SetField(ref _ucdpStatus, value); }

    /// <summary>
    /// Fannie Mae ULDD EC Status [MORNET.X95]
    /// </summary>
    public string? UlddecStatus { get => _ulddecStatus; set => SetField(ref _ulddecStatus, value); }

    /// <summary>
    /// Fannie Mae - Borrower - Value Rep and Warranty [MORNET.X102]
    /// </summary>
    public bool? ValueRepAndWarrantyAvailable { get => _valueRepAndWarrantyAvailable; set => SetField(ref _valueRepAndWarrantyAvailable, value); }

    /// <summary>
    /// Fannie Mae - Borrower - Value Rep and Warranty Message [MORNET.X98]
    /// </summary>
    public string? ValueRepAndWarrantyMessage { get => _valueRepAndWarrantyMessage; set => SetField(ref _valueRepAndWarrantyMessage, value); }
}