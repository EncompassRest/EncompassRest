using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// ClosingDisclosure5
    /// </summary>
    public sealed partial class ClosingDisclosure5 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<CDLiabilityAfterForeclosure>>? _cDLiabilityAfterForeclosure;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _lenderAddress;
        private DirtyValue<string?>? _lenderCity;
        private DirtyValue<string?>? _lenderContact;
        private DirtyValue<string?>? _lenderContactATLicenseID;
        private DirtyValue<string?>? _lenderContactNMLSID;
        private DirtyValue<string?>? _lenderEmail;
        private DirtyValue<string?>? _lenderName;
        private DirtyValue<string?>? _lenderNMLSID;
        private DirtyValue<string?>? _lenderPhone;
        private DirtyValue<StringEnumValue<State>>? _lenderState;
        private DirtyValue<string?>? _lenderSTLicenseID;
        private DirtyValue<string?>? _lenderZip;
        private DirtyValue<string?>? _mortgageBrokerAddress;
        private DirtyValue<string?>? _mortgageBrokerCity;
        private DirtyValue<string?>? _mortgageBrokerContact;
        private DirtyValue<string?>? _mortgageBrokerContactATLicenseID;
        private DirtyValue<string?>? _mortgageBrokerContactNMLSID;
        private DirtyValue<string?>? _mortgageBrokerEmail;
        private DirtyValue<string?>? _mortgageBrokerName;
        private DirtyValue<string?>? _mortgageBrokerNMLSID;
        private DirtyValue<string?>? _mortgageBrokerPhone;
        private DirtyValue<StringEnumValue<State>>? _mortgageBrokerState;
        private DirtyValue<string?>? _mortgageBrokerSTLicenseID;
        private DirtyValue<string?>? _mortgageBrokerZip;
        private DirtyValue<string?>? _realEstateBrokerBAddress;
        private DirtyValue<string?>? _realEstateBrokerBCity;
        private DirtyValue<string?>? _realEstateBrokerBContact;
        private DirtyValue<string?>? _realEstateBrokerBContactATLicenseID;
        private DirtyValue<string?>? _realEstateBrokerBContactNMLSID;
        private DirtyValue<string?>? _realEstateBrokerBEmail;
        private DirtyValue<string?>? _realEstateBrokerBName;
        private DirtyValue<string?>? _realEstateBrokerBNMLSID;
        private DirtyValue<string?>? _realEstateBrokerBPhone;
        private DirtyValue<StringEnumValue<State>>? _realEstateBrokerBState;
        private DirtyValue<string?>? _realEstateBrokerBSTLicenseID;
        private DirtyValue<string?>? _realEstateBrokerBZip;
        private DirtyValue<string?>? _realEstateBrokerSAddress;
        private DirtyValue<string?>? _realEstateBrokerSCity;
        private DirtyValue<string?>? _realEstateBrokerSContact;
        private DirtyValue<string?>? _realEstateBrokerSContactATLicenseID;
        private DirtyValue<string?>? _realEstateBrokerSContactNMLSID;
        private DirtyValue<string?>? _realEstateBrokerSEmail;
        private DirtyValue<string?>? _realEstateBrokerSName;
        private DirtyValue<string?>? _realEstateBrokerSNMLSID;
        private DirtyValue<string?>? _realEstateBrokerSPhone;
        private DirtyValue<StringEnumValue<State>>? _realEstateBrokerSState;
        private DirtyValue<string?>? _realEstateBrokerSSTLicenseID;
        private DirtyValue<string?>? _realEstateBrokerSZip;
        private DirtyValue<string?>? _settlementAgentAddress;
        private DirtyValue<string?>? _settlementAgentCity;
        private DirtyValue<string?>? _settlementAgentContact;
        private DirtyValue<string?>? _settlementAgentContactATLicenseID;
        private DirtyValue<string?>? _settlementAgentContactNMLSID;
        private DirtyValue<string?>? _settlementAgentEmail;
        private DirtyValue<string?>? _settlementAgentName;
        private DirtyValue<string?>? _settlementAgentNMLSID;
        private DirtyValue<string?>? _settlementAgentPhone;
        private DirtyValue<StringEnumValue<State>>? _settlementAgentState;
        private DirtyValue<string?>? _settlementAgentSTLicenseID;
        private DirtyValue<string?>? _settlementAgentZip;
        private DirtyValue<StringEnumValue<SignatureType>>? _signatureType;
        private DirtyValue<decimal?>? _totalPayments;

        /// <summary>
        /// Liability after Foreclosure for Closing Disclosure [CD5.X6]
        /// </summary>
        public StringEnumValue<CDLiabilityAfterForeclosure> CDLiabilityAfterForeclosure { get => _cDLiabilityAfterForeclosure; set => SetField(ref _cDLiabilityAfterForeclosure, value); }

        /// <summary>
        /// ClosingDisclosure5 Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Lender Address [CD5.X8]
        /// </summary>
        public string? LenderAddress { get => _lenderAddress; set => SetField(ref _lenderAddress, value); }

        /// <summary>
        /// Lender City [CD5.X9]
        /// </summary>
        public string? LenderCity { get => _lenderCity; set => SetField(ref _lenderCity, value); }

        /// <summary>
        /// Lender Contact [CD5.X14]
        /// </summary>
        public string? LenderContact { get => _lenderContact; set => SetField(ref _lenderContact, value); }

        /// <summary>
        /// Lender Contact ST License ID [CD5.X16]
        /// </summary>
        public string? LenderContactATLicenseID { get => _lenderContactATLicenseID; set => SetField(ref _lenderContactATLicenseID, value); }

        /// <summary>
        /// Lender Contact NMLSID [CD5.X15]
        /// </summary>
        public string? LenderContactNMLSID { get => _lenderContactNMLSID; set => SetField(ref _lenderContactNMLSID, value); }

        /// <summary>
        /// Lender Email [CD5.X17]
        /// </summary>
        public string? LenderEmail { get => _lenderEmail; set => SetField(ref _lenderEmail, value); }

        /// <summary>
        /// Lender Name [CD5.X7]
        /// </summary>
        public string? LenderName { get => _lenderName; set => SetField(ref _lenderName, value); }

        /// <summary>
        /// Lender NMLS ID [CD5.X12]
        /// </summary>
        public string? LenderNMLSID { get => _lenderNMLSID; set => SetField(ref _lenderNMLSID, value); }

        /// <summary>
        /// Lender Phone [CD5.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? LenderPhone { get => _lenderPhone; set => SetField(ref _lenderPhone, value); }

        /// <summary>
        /// Lender State [CD5.X10]
        /// </summary>
        public StringEnumValue<State> LenderState { get => _lenderState; set => SetField(ref _lenderState, value); }

        /// <summary>
        /// Lender ST License ID [CD5.X13]
        /// </summary>
        public string? LenderSTLicenseID { get => _lenderSTLicenseID; set => SetField(ref _lenderSTLicenseID, value); }

        /// <summary>
        /// Lender Zip [CD5.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? LenderZip { get => _lenderZip; set => SetField(ref _lenderZip, value); }

        /// <summary>
        /// MortgageBroker Address [CD5.X20]
        /// </summary>
        public string? MortgageBrokerAddress { get => _mortgageBrokerAddress; set => SetField(ref _mortgageBrokerAddress, value); }

        /// <summary>
        /// MortgageBroker City [CD5.X21]
        /// </summary>
        public string? MortgageBrokerCity { get => _mortgageBrokerCity; set => SetField(ref _mortgageBrokerCity, value); }

        /// <summary>
        /// MortgageBroker Contact [CD5.X26]
        /// </summary>
        public string? MortgageBrokerContact { get => _mortgageBrokerContact; set => SetField(ref _mortgageBrokerContact, value); }

        /// <summary>
        /// Mortgage Broker Contact ST License ID [CD5.X28]
        /// </summary>
        public string? MortgageBrokerContactATLicenseID { get => _mortgageBrokerContactATLicenseID; set => SetField(ref _mortgageBrokerContactATLicenseID, value); }

        /// <summary>
        /// MortgageBroker Contact NMLSID [CD5.X27]
        /// </summary>
        public string? MortgageBrokerContactNMLSID { get => _mortgageBrokerContactNMLSID; set => SetField(ref _mortgageBrokerContactNMLSID, value); }

        /// <summary>
        /// MortgageBroker Email [CD5.X29]
        /// </summary>
        public string? MortgageBrokerEmail { get => _mortgageBrokerEmail; set => SetField(ref _mortgageBrokerEmail, value); }

        /// <summary>
        /// MortgageBroker Name [CD5.X19]
        /// </summary>
        public string? MortgageBrokerName { get => _mortgageBrokerName; set => SetField(ref _mortgageBrokerName, value); }

        /// <summary>
        /// MortgageBroker NMLS ID [CD5.X24]
        /// </summary>
        public string? MortgageBrokerNMLSID { get => _mortgageBrokerNMLSID; set => SetField(ref _mortgageBrokerNMLSID, value); }

        /// <summary>
        /// MortgageBroker Phone [CD5.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? MortgageBrokerPhone { get => _mortgageBrokerPhone; set => SetField(ref _mortgageBrokerPhone, value); }

        /// <summary>
        /// MortgageBroker State [CD5.X22]
        /// </summary>
        public StringEnumValue<State> MortgageBrokerState { get => _mortgageBrokerState; set => SetField(ref _mortgageBrokerState, value); }

        /// <summary>
        /// MortgageBroker ST License ID [CD5.X25]
        /// </summary>
        public string? MortgageBrokerSTLicenseID { get => _mortgageBrokerSTLicenseID; set => SetField(ref _mortgageBrokerSTLicenseID, value); }

        /// <summary>
        /// MortgageBroker Zip [CD5.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? MortgageBrokerZip { get => _mortgageBrokerZip; set => SetField(ref _mortgageBrokerZip, value); }

        /// <summary>
        /// RealEstateBrokerB Address [CD5.X32]
        /// </summary>
        public string? RealEstateBrokerBAddress { get => _realEstateBrokerBAddress; set => SetField(ref _realEstateBrokerBAddress, value); }

        /// <summary>
        /// RealEstateBrokerB City [CD5.X33]
        /// </summary>
        public string? RealEstateBrokerBCity { get => _realEstateBrokerBCity; set => SetField(ref _realEstateBrokerBCity, value); }

        /// <summary>
        /// RealEstateBrokerB Contact [CD5.X38]
        /// </summary>
        public string? RealEstateBrokerBContact { get => _realEstateBrokerBContact; set => SetField(ref _realEstateBrokerBContact, value); }

        /// <summary>
        /// Real Estate Broker (B) Contact ST License ID [CD5.X40]
        /// </summary>
        public string? RealEstateBrokerBContactATLicenseID { get => _realEstateBrokerBContactATLicenseID; set => SetField(ref _realEstateBrokerBContactATLicenseID, value); }

        /// <summary>
        /// RealEstateBrokerB Contact NMLSID [CD5.X39]
        /// </summary>
        public string? RealEstateBrokerBContactNMLSID { get => _realEstateBrokerBContactNMLSID; set => SetField(ref _realEstateBrokerBContactNMLSID, value); }

        /// <summary>
        /// RealEstateBrokerB Email [CD5.X41]
        /// </summary>
        public string? RealEstateBrokerBEmail { get => _realEstateBrokerBEmail; set => SetField(ref _realEstateBrokerBEmail, value); }

        /// <summary>
        /// RealEstateBrokerB Name [CD5.X31]
        /// </summary>
        public string? RealEstateBrokerBName { get => _realEstateBrokerBName; set => SetField(ref _realEstateBrokerBName, value); }

        /// <summary>
        /// RealEstateBrokerB NMLS ID [CD5.X36]
        /// </summary>
        public string? RealEstateBrokerBNMLSID { get => _realEstateBrokerBNMLSID; set => SetField(ref _realEstateBrokerBNMLSID, value); }

        /// <summary>
        /// RealEstateBrokerB Phone [CD5.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? RealEstateBrokerBPhone { get => _realEstateBrokerBPhone; set => SetField(ref _realEstateBrokerBPhone, value); }

        /// <summary>
        /// RealEstateBrokerB State [CD5.X34]
        /// </summary>
        public StringEnumValue<State> RealEstateBrokerBState { get => _realEstateBrokerBState; set => SetField(ref _realEstateBrokerBState, value); }

        /// <summary>
        /// RealEstateBrokerB ST License ID [CD5.X37]
        /// </summary>
        public string? RealEstateBrokerBSTLicenseID { get => _realEstateBrokerBSTLicenseID; set => SetField(ref _realEstateBrokerBSTLicenseID, value); }

        /// <summary>
        /// RealEstateBrokerB Zip [CD5.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? RealEstateBrokerBZip { get => _realEstateBrokerBZip; set => SetField(ref _realEstateBrokerBZip, value); }

        /// <summary>
        /// RealEstateBrokerS Address [CD5.X44]
        /// </summary>
        public string? RealEstateBrokerSAddress { get => _realEstateBrokerSAddress; set => SetField(ref _realEstateBrokerSAddress, value); }

        /// <summary>
        /// RealEstateBrokerS City [CD5.X45]
        /// </summary>
        public string? RealEstateBrokerSCity { get => _realEstateBrokerSCity; set => SetField(ref _realEstateBrokerSCity, value); }

        /// <summary>
        /// RealEstateBrokerS Contact [CD5.X50]
        /// </summary>
        public string? RealEstateBrokerSContact { get => _realEstateBrokerSContact; set => SetField(ref _realEstateBrokerSContact, value); }

        /// <summary>
        /// Real Estate Broker (S) Contact ST License ID [CD5.X52]
        /// </summary>
        public string? RealEstateBrokerSContactATLicenseID { get => _realEstateBrokerSContactATLicenseID; set => SetField(ref _realEstateBrokerSContactATLicenseID, value); }

        /// <summary>
        /// RealEstateBrokerS Contact NMLSID [CD5.X51]
        /// </summary>
        public string? RealEstateBrokerSContactNMLSID { get => _realEstateBrokerSContactNMLSID; set => SetField(ref _realEstateBrokerSContactNMLSID, value); }

        /// <summary>
        /// RealEstateBrokerS Email [CD5.X53]
        /// </summary>
        public string? RealEstateBrokerSEmail { get => _realEstateBrokerSEmail; set => SetField(ref _realEstateBrokerSEmail, value); }

        /// <summary>
        /// RealEstateBrokerS Name [CD5.X43]
        /// </summary>
        public string? RealEstateBrokerSName { get => _realEstateBrokerSName; set => SetField(ref _realEstateBrokerSName, value); }

        /// <summary>
        /// RealEstateBrokerS NMLS ID [CD5.X48]
        /// </summary>
        public string? RealEstateBrokerSNMLSID { get => _realEstateBrokerSNMLSID; set => SetField(ref _realEstateBrokerSNMLSID, value); }

        /// <summary>
        /// RealEstateBrokerS Phone [CD5.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? RealEstateBrokerSPhone { get => _realEstateBrokerSPhone; set => SetField(ref _realEstateBrokerSPhone, value); }

        /// <summary>
        /// RealEstateBrokerS State [CD5.X46]
        /// </summary>
        public StringEnumValue<State> RealEstateBrokerSState { get => _realEstateBrokerSState; set => SetField(ref _realEstateBrokerSState, value); }

        /// <summary>
        /// RealEstateBrokerS ST License ID [CD5.X49]
        /// </summary>
        public string? RealEstateBrokerSSTLicenseID { get => _realEstateBrokerSSTLicenseID; set => SetField(ref _realEstateBrokerSSTLicenseID, value); }

        /// <summary>
        /// RealEstateBrokerS Zip [CD5.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? RealEstateBrokerSZip { get => _realEstateBrokerSZip; set => SetField(ref _realEstateBrokerSZip, value); }

        /// <summary>
        /// SettlementAgent Address [CD5.X56]
        /// </summary>
        public string? SettlementAgentAddress { get => _settlementAgentAddress; set => SetField(ref _settlementAgentAddress, value); }

        /// <summary>
        /// SettlementAgent City [CD5.X57]
        /// </summary>
        public string? SettlementAgentCity { get => _settlementAgentCity; set => SetField(ref _settlementAgentCity, value); }

        /// <summary>
        /// SettlementAgent Contact [CD5.X62]
        /// </summary>
        public string? SettlementAgentContact { get => _settlementAgentContact; set => SetField(ref _settlementAgentContact, value); }

        /// <summary>
        /// Settlement Agent Contact ST License ID [CD5.X64]
        /// </summary>
        public string? SettlementAgentContactATLicenseID { get => _settlementAgentContactATLicenseID; set => SetField(ref _settlementAgentContactATLicenseID, value); }

        /// <summary>
        /// SettlementAgent Contact NMLSID [CD5.X63]
        /// </summary>
        public string? SettlementAgentContactNMLSID { get => _settlementAgentContactNMLSID; set => SetField(ref _settlementAgentContactNMLSID, value); }

        /// <summary>
        /// SettlementAgent Email [CD5.X65]
        /// </summary>
        public string? SettlementAgentEmail { get => _settlementAgentEmail; set => SetField(ref _settlementAgentEmail, value); }

        /// <summary>
        /// SettlementAgent Name [CD5.X55]
        /// </summary>
        public string? SettlementAgentName { get => _settlementAgentName; set => SetField(ref _settlementAgentName, value); }

        /// <summary>
        /// SettlementAgent NMLS ID [CD5.X60]
        /// </summary>
        public string? SettlementAgentNMLSID { get => _settlementAgentNMLSID; set => SetField(ref _settlementAgentNMLSID, value); }

        /// <summary>
        /// SettlementAgent Phone [CD5.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? SettlementAgentPhone { get => _settlementAgentPhone; set => SetField(ref _settlementAgentPhone, value); }

        /// <summary>
        /// SettlementAgent State [CD5.X58]
        /// </summary>
        public StringEnumValue<State> SettlementAgentState { get => _settlementAgentState; set => SetField(ref _settlementAgentState, value); }

        /// <summary>
        /// SettlementAgent ST License ID [CD5.X61]
        /// </summary>
        public string? SettlementAgentSTLicenseID { get => _settlementAgentSTLicenseID; set => SetField(ref _settlementAgentSTLicenseID, value); }

        /// <summary>
        /// SettlementAgent Zip [CD5.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? SettlementAgentZip { get => _settlementAgentZip; set => SetField(ref _settlementAgentZip, value); }

        /// <summary>
        /// Closing Disclosure - Signature Type [CD5.X67]
        /// </summary>
        public StringEnumValue<SignatureType> SignatureType { get => _signatureType; set => SetField(ref _signatureType, value); }

        /// <summary>
        /// Closing disclosure 5 - Total Payments [CD5.X1]
        /// </summary>
        public decimal? TotalPayments { get => _totalPayments; set => SetField(ref _totalPayments, value); }
    }
}