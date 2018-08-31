using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure5
    /// </summary>
    public sealed partial class ClosingDisclosure5 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<CDLiabilityAfterForeclosure>> _cDLiabilityAfterForeclosure;
        /// <summary>
        /// Liability after Foreclosure for Closing Disclosure [CD5.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Liability after Foreclosure for Closing Disclosure")]
        public StringEnumValue<CDLiabilityAfterForeclosure> CDLiabilityAfterForeclosure { get => _cDLiabilityAfterForeclosure; set => SetField(ref _cDLiabilityAfterForeclosure, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDisclosure5 Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _lenderAddress;
        /// <summary>
        /// Lender Address [CD5.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Address")]
        public string LenderAddress { get => _lenderAddress; set => SetField(ref _lenderAddress, value); }
        private DirtyValue<string> _lenderCity;
        /// <summary>
        /// Lender City [CD5.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Lender City")]
        public string LenderCity { get => _lenderCity; set => SetField(ref _lenderCity, value); }
        private DirtyValue<string> _lenderContact;
        /// <summary>
        /// Lender Contact [CD5.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Contact")]
        public string LenderContact { get => _lenderContact; set => SetField(ref _lenderContact, value); }
        private DirtyValue<string> _lenderContactATLicenseID;
        /// <summary>
        /// Lender Contact ST License ID [CD5.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Contact ST License ID")]
        public string LenderContactATLicenseID { get => _lenderContactATLicenseID; set => SetField(ref _lenderContactATLicenseID, value); }
        private DirtyValue<string> _lenderContactNMLSID;
        /// <summary>
        /// Lender Contact NMLSID [CD5.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Contact NMLSID")]
        public string LenderContactNMLSID { get => _lenderContactNMLSID; set => SetField(ref _lenderContactNMLSID, value); }
        private DirtyValue<string> _lenderEmail;
        /// <summary>
        /// Lender Email [CD5.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Email")]
        public string LenderEmail { get => _lenderEmail; set => SetField(ref _lenderEmail, value); }
        private DirtyValue<string> _lenderName;
        /// <summary>
        /// Lender Name [CD5.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Name")]
        public string LenderName { get => _lenderName; set => SetField(ref _lenderName, value); }
        private DirtyValue<string> _lenderNMLSID;
        /// <summary>
        /// Lender NMLS ID [CD5.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Lender NMLS ID")]
        public string LenderNMLSID { get => _lenderNMLSID; set => SetField(ref _lenderNMLSID, value); }
        private DirtyValue<string> _lenderPhone;
        /// <summary>
        /// Lender Phone [CD5.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Lender Phone")]
        public string LenderPhone { get => _lenderPhone; set => SetField(ref _lenderPhone, value); }
        private DirtyValue<StringEnumValue<State>> _lenderState;
        /// <summary>
        /// Lender State [CD5.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Lender State")]
        public StringEnumValue<State> LenderState { get => _lenderState; set => SetField(ref _lenderState, value); }
        private DirtyValue<string> _lenderSTLicenseID;
        /// <summary>
        /// Lender ST License ID [CD5.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Lender ST License ID")]
        public string LenderSTLicenseID { get => _lenderSTLicenseID; set => SetField(ref _lenderSTLicenseID, value); }
        private DirtyValue<string> _lenderZip;
        /// <summary>
        /// Lender Zip [CD5.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Lender Zip")]
        public string LenderZip { get => _lenderZip; set => SetField(ref _lenderZip, value); }
        private DirtyValue<string> _mortgageBrokerAddress;
        /// <summary>
        /// MortgageBroker Address [CD5.X20]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Address")]
        public string MortgageBrokerAddress { get => _mortgageBrokerAddress; set => SetField(ref _mortgageBrokerAddress, value); }
        private DirtyValue<string> _mortgageBrokerCity;
        /// <summary>
        /// MortgageBroker City [CD5.X21]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker City")]
        public string MortgageBrokerCity { get => _mortgageBrokerCity; set => SetField(ref _mortgageBrokerCity, value); }
        private DirtyValue<string> _mortgageBrokerContact;
        /// <summary>
        /// MortgageBroker Contact [CD5.X26]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Contact")]
        public string MortgageBrokerContact { get => _mortgageBrokerContact; set => SetField(ref _mortgageBrokerContact, value); }
        private DirtyValue<string> _mortgageBrokerContactATLicenseID;
        /// <summary>
        /// Mortgage Broker Contact ST License ID [CD5.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Broker Contact ST License ID")]
        public string MortgageBrokerContactATLicenseID { get => _mortgageBrokerContactATLicenseID; set => SetField(ref _mortgageBrokerContactATLicenseID, value); }
        private DirtyValue<string> _mortgageBrokerContactNMLSID;
        /// <summary>
        /// MortgageBroker Contact NMLSID [CD5.X27]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Contact NMLSID")]
        public string MortgageBrokerContactNMLSID { get => _mortgageBrokerContactNMLSID; set => SetField(ref _mortgageBrokerContactNMLSID, value); }
        private DirtyValue<string> _mortgageBrokerEmail;
        /// <summary>
        /// MortgageBroker Email [CD5.X29]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Email")]
        public string MortgageBrokerEmail { get => _mortgageBrokerEmail; set => SetField(ref _mortgageBrokerEmail, value); }
        private DirtyValue<string> _mortgageBrokerName;
        /// <summary>
        /// MortgageBroker Name [CD5.X19]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Name")]
        public string MortgageBrokerName { get => _mortgageBrokerName; set => SetField(ref _mortgageBrokerName, value); }
        private DirtyValue<string> _mortgageBrokerNMLSID;
        /// <summary>
        /// MortgageBroker NMLS ID [CD5.X24]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker NMLS ID")]
        public string MortgageBrokerNMLSID { get => _mortgageBrokerNMLSID; set => SetField(ref _mortgageBrokerNMLSID, value); }
        private DirtyValue<string> _mortgageBrokerPhone;
        /// <summary>
        /// MortgageBroker Phone [CD5.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "MortgageBroker Phone")]
        public string MortgageBrokerPhone { get => _mortgageBrokerPhone; set => SetField(ref _mortgageBrokerPhone, value); }
        private DirtyValue<StringEnumValue<State>> _mortgageBrokerState;
        /// <summary>
        /// MortgageBroker State [CD5.X22]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker State")]
        public StringEnumValue<State> MortgageBrokerState { get => _mortgageBrokerState; set => SetField(ref _mortgageBrokerState, value); }
        private DirtyValue<string> _mortgageBrokerSTLicenseID;
        /// <summary>
        /// MortgageBroker ST License ID [CD5.X25]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker ST License ID")]
        public string MortgageBrokerSTLicenseID { get => _mortgageBrokerSTLicenseID; set => SetField(ref _mortgageBrokerSTLicenseID, value); }
        private DirtyValue<string> _mortgageBrokerZip;
        /// <summary>
        /// MortgageBroker Zip [CD5.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "MortgageBroker Zip")]
        public string MortgageBrokerZip { get => _mortgageBrokerZip; set => SetField(ref _mortgageBrokerZip, value); }
        private DirtyValue<string> _realEstateBrokerBAddress;
        /// <summary>
        /// RealEstateBrokerB Address [CD5.X32]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Address")]
        public string RealEstateBrokerBAddress { get => _realEstateBrokerBAddress; set => SetField(ref _realEstateBrokerBAddress, value); }
        private DirtyValue<string> _realEstateBrokerBCity;
        /// <summary>
        /// RealEstateBrokerB City [CD5.X33]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB City")]
        public string RealEstateBrokerBCity { get => _realEstateBrokerBCity; set => SetField(ref _realEstateBrokerBCity, value); }
        private DirtyValue<string> _realEstateBrokerBContact;
        /// <summary>
        /// RealEstateBrokerB Contact [CD5.X38]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Contact")]
        public string RealEstateBrokerBContact { get => _realEstateBrokerBContact; set => SetField(ref _realEstateBrokerBContact, value); }
        private DirtyValue<string> _realEstateBrokerBContactATLicenseID;
        /// <summary>
        /// Real Estate Broker (B) Contact ST License ID [CD5.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Real Estate Broker (B) Contact ST License ID")]
        public string RealEstateBrokerBContactATLicenseID { get => _realEstateBrokerBContactATLicenseID; set => SetField(ref _realEstateBrokerBContactATLicenseID, value); }
        private DirtyValue<string> _realEstateBrokerBContactNMLSID;
        /// <summary>
        /// RealEstateBrokerB Contact NMLSID [CD5.X39]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Contact NMLSID")]
        public string RealEstateBrokerBContactNMLSID { get => _realEstateBrokerBContactNMLSID; set => SetField(ref _realEstateBrokerBContactNMLSID, value); }
        private DirtyValue<string> _realEstateBrokerBEmail;
        /// <summary>
        /// RealEstateBrokerB Email [CD5.X41]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Email")]
        public string RealEstateBrokerBEmail { get => _realEstateBrokerBEmail; set => SetField(ref _realEstateBrokerBEmail, value); }
        private DirtyValue<string> _realEstateBrokerBName;
        /// <summary>
        /// RealEstateBrokerB Name [CD5.X31]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Name")]
        public string RealEstateBrokerBName { get => _realEstateBrokerBName; set => SetField(ref _realEstateBrokerBName, value); }
        private DirtyValue<string> _realEstateBrokerBNMLSID;
        /// <summary>
        /// RealEstateBrokerB NMLS ID [CD5.X36]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB NMLS ID")]
        public string RealEstateBrokerBNMLSID { get => _realEstateBrokerBNMLSID; set => SetField(ref _realEstateBrokerBNMLSID, value); }
        private DirtyValue<string> _realEstateBrokerBPhone;
        /// <summary>
        /// RealEstateBrokerB Phone [CD5.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "RealEstateBrokerB Phone")]
        public string RealEstateBrokerBPhone { get => _realEstateBrokerBPhone; set => SetField(ref _realEstateBrokerBPhone, value); }
        private DirtyValue<StringEnumValue<State>> _realEstateBrokerBState;
        /// <summary>
        /// RealEstateBrokerB State [CD5.X34]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB State")]
        public StringEnumValue<State> RealEstateBrokerBState { get => _realEstateBrokerBState; set => SetField(ref _realEstateBrokerBState, value); }
        private DirtyValue<string> _realEstateBrokerBSTLicenseID;
        /// <summary>
        /// RealEstateBrokerB ST License ID [CD5.X37]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB ST License ID")]
        public string RealEstateBrokerBSTLicenseID { get => _realEstateBrokerBSTLicenseID; set => SetField(ref _realEstateBrokerBSTLicenseID, value); }
        private DirtyValue<string> _realEstateBrokerBZip;
        /// <summary>
        /// RealEstateBrokerB Zip [CD5.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "RealEstateBrokerB Zip")]
        public string RealEstateBrokerBZip { get => _realEstateBrokerBZip; set => SetField(ref _realEstateBrokerBZip, value); }
        private DirtyValue<string> _realEstateBrokerSAddress;
        /// <summary>
        /// RealEstateBrokerS Address [CD5.X44]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Address")]
        public string RealEstateBrokerSAddress { get => _realEstateBrokerSAddress; set => SetField(ref _realEstateBrokerSAddress, value); }
        private DirtyValue<string> _realEstateBrokerSCity;
        /// <summary>
        /// RealEstateBrokerS City [CD5.X45]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS City")]
        public string RealEstateBrokerSCity { get => _realEstateBrokerSCity; set => SetField(ref _realEstateBrokerSCity, value); }
        private DirtyValue<string> _realEstateBrokerSContact;
        /// <summary>
        /// RealEstateBrokerS Contact [CD5.X50]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Contact")]
        public string RealEstateBrokerSContact { get => _realEstateBrokerSContact; set => SetField(ref _realEstateBrokerSContact, value); }
        private DirtyValue<string> _realEstateBrokerSContactATLicenseID;
        /// <summary>
        /// Real Estate Broker (S) Contact ST License ID [CD5.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Real Estate Broker (S) Contact ST License ID")]
        public string RealEstateBrokerSContactATLicenseID { get => _realEstateBrokerSContactATLicenseID; set => SetField(ref _realEstateBrokerSContactATLicenseID, value); }
        private DirtyValue<string> _realEstateBrokerSContactNMLSID;
        /// <summary>
        /// RealEstateBrokerS Contact NMLSID [CD5.X51]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Contact NMLSID")]
        public string RealEstateBrokerSContactNMLSID { get => _realEstateBrokerSContactNMLSID; set => SetField(ref _realEstateBrokerSContactNMLSID, value); }
        private DirtyValue<string> _realEstateBrokerSEmail;
        /// <summary>
        /// RealEstateBrokerS Email [CD5.X53]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Email")]
        public string RealEstateBrokerSEmail { get => _realEstateBrokerSEmail; set => SetField(ref _realEstateBrokerSEmail, value); }
        private DirtyValue<string> _realEstateBrokerSName;
        /// <summary>
        /// RealEstateBrokerS Name [CD5.X43]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Name")]
        public string RealEstateBrokerSName { get => _realEstateBrokerSName; set => SetField(ref _realEstateBrokerSName, value); }
        private DirtyValue<string> _realEstateBrokerSNMLSID;
        /// <summary>
        /// RealEstateBrokerS NMLS ID [CD5.X48]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS NMLS ID")]
        public string RealEstateBrokerSNMLSID { get => _realEstateBrokerSNMLSID; set => SetField(ref _realEstateBrokerSNMLSID, value); }
        private DirtyValue<string> _realEstateBrokerSPhone;
        /// <summary>
        /// RealEstateBrokerS Phone [CD5.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "RealEstateBrokerS Phone")]
        public string RealEstateBrokerSPhone { get => _realEstateBrokerSPhone; set => SetField(ref _realEstateBrokerSPhone, value); }
        private DirtyValue<StringEnumValue<State>> _realEstateBrokerSState;
        /// <summary>
        /// RealEstateBrokerS State [CD5.X46]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS State")]
        public StringEnumValue<State> RealEstateBrokerSState { get => _realEstateBrokerSState; set => SetField(ref _realEstateBrokerSState, value); }
        private DirtyValue<string> _realEstateBrokerSSTLicenseID;
        /// <summary>
        /// RealEstateBrokerS ST License ID [CD5.X49]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS ST License ID")]
        public string RealEstateBrokerSSTLicenseID { get => _realEstateBrokerSSTLicenseID; set => SetField(ref _realEstateBrokerSSTLicenseID, value); }
        private DirtyValue<string> _realEstateBrokerSZip;
        /// <summary>
        /// RealEstateBrokerS Zip [CD5.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "RealEstateBrokerS Zip")]
        public string RealEstateBrokerSZip { get => _realEstateBrokerSZip; set => SetField(ref _realEstateBrokerSZip, value); }
        private DirtyValue<string> _settlementAgentAddress;
        /// <summary>
        /// SettlementAgent Address [CD5.X56]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Address")]
        public string SettlementAgentAddress { get => _settlementAgentAddress; set => SetField(ref _settlementAgentAddress, value); }
        private DirtyValue<string> _settlementAgentCity;
        /// <summary>
        /// SettlementAgent City [CD5.X57]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent City")]
        public string SettlementAgentCity { get => _settlementAgentCity; set => SetField(ref _settlementAgentCity, value); }
        private DirtyValue<string> _settlementAgentContact;
        /// <summary>
        /// SettlementAgent Contact [CD5.X62]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Contact")]
        public string SettlementAgentContact { get => _settlementAgentContact; set => SetField(ref _settlementAgentContact, value); }
        private DirtyValue<string> _settlementAgentContactATLicenseID;
        /// <summary>
        /// Settlement Agent Contact ST License ID [CD5.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Agent Contact ST License ID")]
        public string SettlementAgentContactATLicenseID { get => _settlementAgentContactATLicenseID; set => SetField(ref _settlementAgentContactATLicenseID, value); }
        private DirtyValue<string> _settlementAgentContactNMLSID;
        /// <summary>
        /// SettlementAgent Contact NMLSID [CD5.X63]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Contact NMLSID")]
        public string SettlementAgentContactNMLSID { get => _settlementAgentContactNMLSID; set => SetField(ref _settlementAgentContactNMLSID, value); }
        private DirtyValue<string> _settlementAgentEmail;
        /// <summary>
        /// SettlementAgent Email [CD5.X65]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Email")]
        public string SettlementAgentEmail { get => _settlementAgentEmail; set => SetField(ref _settlementAgentEmail, value); }
        private DirtyValue<string> _settlementAgentName;
        /// <summary>
        /// SettlementAgent Name [CD5.X55]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Name")]
        public string SettlementAgentName { get => _settlementAgentName; set => SetField(ref _settlementAgentName, value); }
        private DirtyValue<string> _settlementAgentNMLSID;
        /// <summary>
        /// SettlementAgent NMLS ID [CD5.X60]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent NMLS ID")]
        public string SettlementAgentNMLSID { get => _settlementAgentNMLSID; set => SetField(ref _settlementAgentNMLSID, value); }
        private DirtyValue<string> _settlementAgentPhone;
        /// <summary>
        /// SettlementAgent Phone [CD5.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "SettlementAgent Phone")]
        public string SettlementAgentPhone { get => _settlementAgentPhone; set => SetField(ref _settlementAgentPhone, value); }
        private DirtyValue<StringEnumValue<State>> _settlementAgentState;
        /// <summary>
        /// SettlementAgent State [CD5.X58]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent State")]
        public StringEnumValue<State> SettlementAgentState { get => _settlementAgentState; set => SetField(ref _settlementAgentState, value); }
        private DirtyValue<string> _settlementAgentSTLicenseID;
        /// <summary>
        /// SettlementAgent ST License ID [CD5.X61]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent ST License ID")]
        public string SettlementAgentSTLicenseID { get => _settlementAgentSTLicenseID; set => SetField(ref _settlementAgentSTLicenseID, value); }
        private DirtyValue<string> _settlementAgentZip;
        /// <summary>
        /// SettlementAgent Zip [CD5.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "SettlementAgent Zip")]
        public string SettlementAgentZip { get => _settlementAgentZip; set => SetField(ref _settlementAgentZip, value); }
        private DirtyValue<StringEnumValue<SignatureType>> _signatureType;
        /// <summary>
        /// Closing Disclosure - Signature Type [CD5.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Signature Type")]
        public StringEnumValue<SignatureType> SignatureType { get => _signatureType; set => SetField(ref _signatureType, value); }
        private DirtyValue<decimal?> _totalPayments;
        /// <summary>
        /// Closing disclosure 5 - Total Payments [CD5.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure 5 - Total Payments")]
        public decimal? TotalPayments { get => _totalPayments; set => SetField(ref _totalPayments, value); }
    }
}