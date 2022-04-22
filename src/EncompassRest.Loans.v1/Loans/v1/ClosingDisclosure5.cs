using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ClosingDisclosure5
/// </summary>
public sealed partial class ClosingDisclosure5 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Liability after Foreclosure for Closing Disclosure [CD5.X6]
    /// </summary>
    public StringEnumValue<CDLiabilityAfterForeclosure> CDLiabilityAfterForeclosure { get => GetValue<StringEnumValue<CDLiabilityAfterForeclosure>>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosure5 Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Address [CD5.X8]
    /// </summary>
    public string? LenderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender City [CD5.X9]
    /// </summary>
    public string? LenderCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Contact [CD5.X14]
    /// </summary>
    public string? LenderContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Contact ST License ID [CD5.X16]
    /// </summary>
    public string? LenderContactATLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Contact NMLSID [CD5.X15]
    /// </summary>
    public string? LenderContactNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Email [CD5.X17]
    /// </summary>
    public string? LenderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Name [CD5.X7]
    /// </summary>
    public string? LenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender NMLS ID [CD5.X12]
    /// </summary>
    public string? LenderNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Phone [CD5.X18]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender State [CD5.X10]
    /// </summary>
    public StringEnumValue<State> LenderState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Lender ST License ID [CD5.X13]
    /// </summary>
    public string? LenderSTLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Zip [CD5.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LenderZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker Address [CD5.X20]
    /// </summary>
    public string? MortgageBrokerAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker City [CD5.X21]
    /// </summary>
    public string? MortgageBrokerCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker Contact [CD5.X26]
    /// </summary>
    public string? MortgageBrokerContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Broker Contact ST License ID [CD5.X28]
    /// </summary>
    public string? MortgageBrokerContactATLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker Contact NMLSID [CD5.X27]
    /// </summary>
    public string? MortgageBrokerContactNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker Email [CD5.X29]
    /// </summary>
    public string? MortgageBrokerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker Name [CD5.X19]
    /// </summary>
    public string? MortgageBrokerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker NMLS ID [CD5.X24]
    /// </summary>
    public string? MortgageBrokerNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker Phone [CD5.X30]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? MortgageBrokerPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker State [CD5.X22]
    /// </summary>
    public StringEnumValue<State> MortgageBrokerState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker ST License ID [CD5.X25]
    /// </summary>
    public string? MortgageBrokerSTLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MortgageBroker Zip [CD5.X23]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? MortgageBrokerZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB Address [CD5.X32]
    /// </summary>
    public string? RealEstateBrokerBAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB City [CD5.X33]
    /// </summary>
    public string? RealEstateBrokerBCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB Contact [CD5.X38]
    /// </summary>
    public string? RealEstateBrokerBContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Real Estate Broker (B) Contact ST License ID [CD5.X40]
    /// </summary>
    public string? RealEstateBrokerBContactATLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB Contact NMLSID [CD5.X39]
    /// </summary>
    public string? RealEstateBrokerBContactNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB Email [CD5.X41]
    /// </summary>
    public string? RealEstateBrokerBEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB Name [CD5.X31]
    /// </summary>
    public string? RealEstateBrokerBName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB NMLS ID [CD5.X36]
    /// </summary>
    public string? RealEstateBrokerBNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB Phone [CD5.X42]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RealEstateBrokerBPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB State [CD5.X34]
    /// </summary>
    public StringEnumValue<State> RealEstateBrokerBState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB ST License ID [CD5.X37]
    /// </summary>
    public string? RealEstateBrokerBSTLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerB Zip [CD5.X35]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? RealEstateBrokerBZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS Address [CD5.X44]
    /// </summary>
    public string? RealEstateBrokerSAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS City [CD5.X45]
    /// </summary>
    public string? RealEstateBrokerSCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS Contact [CD5.X50]
    /// </summary>
    public string? RealEstateBrokerSContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Real Estate Broker (S) Contact ST License ID [CD5.X52]
    /// </summary>
    public string? RealEstateBrokerSContactATLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS Contact NMLSID [CD5.X51]
    /// </summary>
    public string? RealEstateBrokerSContactNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS Email [CD5.X53]
    /// </summary>
    public string? RealEstateBrokerSEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS Name [CD5.X43]
    /// </summary>
    public string? RealEstateBrokerSName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS NMLS ID [CD5.X48]
    /// </summary>
    public string? RealEstateBrokerSNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS Phone [CD5.X54]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RealEstateBrokerSPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS State [CD5.X46]
    /// </summary>
    public StringEnumValue<State> RealEstateBrokerSState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS ST License ID [CD5.X49]
    /// </summary>
    public string? RealEstateBrokerSSTLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RealEstateBrokerS Zip [CD5.X47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? RealEstateBrokerSZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent Address [CD5.X56]
    /// </summary>
    public string? SettlementAgentAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent City [CD5.X57]
    /// </summary>
    public string? SettlementAgentCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent Contact [CD5.X62]
    /// </summary>
    public string? SettlementAgentContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Agent Contact ST License ID [CD5.X64]
    /// </summary>
    public string? SettlementAgentContactATLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent Contact NMLSID [CD5.X63]
    /// </summary>
    public string? SettlementAgentContactNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent Email [CD5.X65]
    /// </summary>
    public string? SettlementAgentEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent Name [CD5.X55]
    /// </summary>
    public string? SettlementAgentName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent NMLS ID [CD5.X60]
    /// </summary>
    public string? SettlementAgentNMLSID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent Phone [CD5.X66]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SettlementAgentPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent State [CD5.X58]
    /// </summary>
    public StringEnumValue<State> SettlementAgentState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent ST License ID [CD5.X61]
    /// </summary>
    public string? SettlementAgentSTLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementAgent Zip [CD5.X59]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SettlementAgentZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Signature Type [CD5.X67]
    /// </summary>
    public StringEnumValue<SignatureType> SignatureType { get => GetValue<StringEnumValue<SignatureType>>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure 5 - Total Payments [CD5.X1]
    /// </summary>
    public decimal? TotalPayments { get => GetValue<decimal?>(); set => SetValue(value); }
}