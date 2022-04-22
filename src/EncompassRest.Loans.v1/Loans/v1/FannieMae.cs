using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// FannieMae
/// </summary>
public sealed partial class FannieMae : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Fannie Mae - Borrower - Asset Validation Message [MORNET.X100]
    /// </summary>
    public string? AssetRepAndWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Borrower - Asset Validation [MORNET.X103]
    /// </summary>
    public bool? AssetRepAndWarrantyReliefAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Case File ID # Assigned by UCD [MORNET.X125]
    /// </summary>
    public bool? CaseIDAssignedByUCDIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae MORNETPlus CLTV [MORNET.X76]
    /// </summary>
    public decimal? Cltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Collateral Underwriter Score [MORNET.X92]
    /// </summary>
    public string? CollateralUnderwriterScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Community Seconds Repayment Structure [MORNET.X73]
    /// </summary>
    public StringEnumValue<Community2ndRepaymentStructure> Community2ndRepaymentStructure { get => GetValue<StringEnumValue<Community2ndRepaymentStructure>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Community Lending [MORNET.X72]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Community Lending\"}")]
    public bool? CommunityLending { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Correspondent Assignment Center ID [MORNET.X126]
    /// </summary>
    public string? CorrespondentAssignmentID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae MORNETPlus Version Number [MORNET.X74]
    /// </summary>
    public string? DuVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae 1003 EC Status [MORNET.X94]
    /// </summary>
    public string? ECStatus1003 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Owned Message [MORNET.X157]
    /// </summary>
    public string? FannieMaeOwnedMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae MORNETPlus HCLTV and HTLTV [MORNET.X77]
    /// </summary>
    public decimal? Hcltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FannieMae Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Interested Party Contribution [MORNET.X78]
    /// </summary>
    public decimal? InterestedPartyContribution { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae MORNETPlus LTV [MORNET.X75]
    /// </summary>
    public decimal? Ltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae MORNETPlus Case File ID # [MORNET.X4]
    /// </summary>
    public string? MornetPlusCaseFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Borrower - PIW Message [MORNET.X97]
    /// </summary>
    public string? PIWMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Property Inspection Waiver Message [MORNET.X91]
    /// </summary>
    public string? PropertyInspectionWaiverMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Start-Up Mtg [MORNET.X11]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Start-up Mortgage\"}")]
    public bool? StartUpMortgage { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae UCD Collection Status [MORNET.X96]
    /// </summary>
    public string? UCDCollectionStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae UCDP Status [MORNET.X93]
    /// </summary>
    public string? UCDPStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae ULDD EC Status [MORNET.X95]
    /// </summary>
    public string? ULDDECStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Borrower - Value Rep and Warranty [MORNET.X102]
    /// </summary>
    public bool? ValueRepAndWarrantyAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Borrower - Value Rep and Warranty Message [MORNET.X98]
    /// </summary>
    public string? ValueRepAndWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }
}