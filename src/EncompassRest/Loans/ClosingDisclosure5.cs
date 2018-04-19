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
        public StringEnumValue<CDLiabilityAfterForeclosure> CDLiabilityAfterForeclosure { get => _cDLiabilityAfterForeclosure; set => _cDLiabilityAfterForeclosure = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDisclosure5 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lenderAddress;
        /// <summary>
        /// Lender Address [CD5.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Address")]
        public string LenderAddress { get => _lenderAddress; set => _lenderAddress = value; }
        private DirtyValue<string> _lenderCity;
        /// <summary>
        /// Lender City [CD5.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Lender City")]
        public string LenderCity { get => _lenderCity; set => _lenderCity = value; }
        private DirtyValue<string> _lenderContact;
        /// <summary>
        /// Lender Contact [CD5.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Contact")]
        public string LenderContact { get => _lenderContact; set => _lenderContact = value; }
        private DirtyValue<string> _lenderContactATLicenseID;
        /// <summary>
        /// Lender Contact ST License ID [CD5.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Contact ST License ID")]
        public string LenderContactATLicenseID { get => _lenderContactATLicenseID; set => _lenderContactATLicenseID = value; }
        private DirtyValue<string> _lenderContactNMLSID;
        /// <summary>
        /// Lender Contact NMLSID [CD5.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Contact NMLSID")]
        public string LenderContactNMLSID { get => _lenderContactNMLSID; set => _lenderContactNMLSID = value; }
        private DirtyValue<string> _lenderEmail;
        /// <summary>
        /// Lender Email [CD5.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Email")]
        public string LenderEmail { get => _lenderEmail; set => _lenderEmail = value; }
        private DirtyValue<string> _lenderName;
        /// <summary>
        /// Lender Name [CD5.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Name")]
        public string LenderName { get => _lenderName; set => _lenderName = value; }
        private DirtyValue<string> _lenderNMLSID;
        /// <summary>
        /// Lender NMLS ID [CD5.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Lender NMLS ID")]
        public string LenderNMLSID { get => _lenderNMLSID; set => _lenderNMLSID = value; }
        private DirtyValue<string> _lenderPhone;
        /// <summary>
        /// Lender Phone [CD5.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Lender Phone")]
        public string LenderPhone { get => _lenderPhone; set => _lenderPhone = value; }
        private DirtyValue<string> _lenderState;
        /// <summary>
        /// Lender State [CD5.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Lender State")]
        public string LenderState { get => _lenderState; set => _lenderState = value; }
        private DirtyValue<string> _lenderSTLicenseID;
        /// <summary>
        /// Lender ST License ID [CD5.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Lender ST License ID")]
        public string LenderSTLicenseID { get => _lenderSTLicenseID; set => _lenderSTLicenseID = value; }
        private DirtyValue<string> _lenderZip;
        /// <summary>
        /// Lender Zip [CD5.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Lender Zip")]
        public string LenderZip { get => _lenderZip; set => _lenderZip = value; }
        private DirtyValue<string> _mortgageBrokerAddress;
        /// <summary>
        /// MortgageBroker Address [CD5.X20]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Address")]
        public string MortgageBrokerAddress { get => _mortgageBrokerAddress; set => _mortgageBrokerAddress = value; }
        private DirtyValue<string> _mortgageBrokerCity;
        /// <summary>
        /// MortgageBroker City [CD5.X21]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker City")]
        public string MortgageBrokerCity { get => _mortgageBrokerCity; set => _mortgageBrokerCity = value; }
        private DirtyValue<string> _mortgageBrokerContact;
        /// <summary>
        /// MortgageBroker Contact [CD5.X26]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Contact")]
        public string MortgageBrokerContact { get => _mortgageBrokerContact; set => _mortgageBrokerContact = value; }
        private DirtyValue<string> _mortgageBrokerContactATLicenseID;
        /// <summary>
        /// Mortgage Broker Contact ST License ID [CD5.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Broker Contact ST License ID")]
        public string MortgageBrokerContactATLicenseID { get => _mortgageBrokerContactATLicenseID; set => _mortgageBrokerContactATLicenseID = value; }
        private DirtyValue<string> _mortgageBrokerContactNMLSID;
        /// <summary>
        /// MortgageBroker Contact NMLSID [CD5.X27]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Contact NMLSID")]
        public string MortgageBrokerContactNMLSID { get => _mortgageBrokerContactNMLSID; set => _mortgageBrokerContactNMLSID = value; }
        private DirtyValue<string> _mortgageBrokerEmail;
        /// <summary>
        /// MortgageBroker Email [CD5.X29]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Email")]
        public string MortgageBrokerEmail { get => _mortgageBrokerEmail; set => _mortgageBrokerEmail = value; }
        private DirtyValue<string> _mortgageBrokerName;
        /// <summary>
        /// MortgageBroker Name [CD5.X19]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker Name")]
        public string MortgageBrokerName { get => _mortgageBrokerName; set => _mortgageBrokerName = value; }
        private DirtyValue<string> _mortgageBrokerNMLSID;
        /// <summary>
        /// MortgageBroker NMLS ID [CD5.X24]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker NMLS ID")]
        public string MortgageBrokerNMLSID { get => _mortgageBrokerNMLSID; set => _mortgageBrokerNMLSID = value; }
        private DirtyValue<string> _mortgageBrokerPhone;
        /// <summary>
        /// MortgageBroker Phone [CD5.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "MortgageBroker Phone")]
        public string MortgageBrokerPhone { get => _mortgageBrokerPhone; set => _mortgageBrokerPhone = value; }
        private DirtyValue<string> _mortgageBrokerState;
        /// <summary>
        /// MortgageBroker State [CD5.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "MortgageBroker State")]
        public string MortgageBrokerState { get => _mortgageBrokerState; set => _mortgageBrokerState = value; }
        private DirtyValue<string> _mortgageBrokerSTLicenseID;
        /// <summary>
        /// MortgageBroker ST License ID [CD5.X25]
        /// </summary>
        [LoanFieldProperty(Description = "MortgageBroker ST License ID")]
        public string MortgageBrokerSTLicenseID { get => _mortgageBrokerSTLicenseID; set => _mortgageBrokerSTLicenseID = value; }
        private DirtyValue<string> _mortgageBrokerZip;
        /// <summary>
        /// MortgageBroker Zip [CD5.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "MortgageBroker Zip")]
        public string MortgageBrokerZip { get => _mortgageBrokerZip; set => _mortgageBrokerZip = value; }
        private DirtyValue<string> _realEstateBrokerBAddress;
        /// <summary>
        /// RealEstateBrokerB Address [CD5.X32]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Address")]
        public string RealEstateBrokerBAddress { get => _realEstateBrokerBAddress; set => _realEstateBrokerBAddress = value; }
        private DirtyValue<string> _realEstateBrokerBCity;
        /// <summary>
        /// RealEstateBrokerB City [CD5.X33]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB City")]
        public string RealEstateBrokerBCity { get => _realEstateBrokerBCity; set => _realEstateBrokerBCity = value; }
        private DirtyValue<string> _realEstateBrokerBContact;
        /// <summary>
        /// RealEstateBrokerB Contact [CD5.X38]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Contact")]
        public string RealEstateBrokerBContact { get => _realEstateBrokerBContact; set => _realEstateBrokerBContact = value; }
        private DirtyValue<string> _realEstateBrokerBContactATLicenseID;
        /// <summary>
        /// Real Estate Broker (B) Contact ST License ID [CD5.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Real Estate Broker (B) Contact ST License ID")]
        public string RealEstateBrokerBContactATLicenseID { get => _realEstateBrokerBContactATLicenseID; set => _realEstateBrokerBContactATLicenseID = value; }
        private DirtyValue<string> _realEstateBrokerBContactNMLSID;
        /// <summary>
        /// RealEstateBrokerB Contact NMLSID [CD5.X39]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Contact NMLSID")]
        public string RealEstateBrokerBContactNMLSID { get => _realEstateBrokerBContactNMLSID; set => _realEstateBrokerBContactNMLSID = value; }
        private DirtyValue<string> _realEstateBrokerBEmail;
        /// <summary>
        /// RealEstateBrokerB Email [CD5.X41]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Email")]
        public string RealEstateBrokerBEmail { get => _realEstateBrokerBEmail; set => _realEstateBrokerBEmail = value; }
        private DirtyValue<string> _realEstateBrokerBName;
        /// <summary>
        /// RealEstateBrokerB Name [CD5.X31]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB Name")]
        public string RealEstateBrokerBName { get => _realEstateBrokerBName; set => _realEstateBrokerBName = value; }
        private DirtyValue<string> _realEstateBrokerBNMLSID;
        /// <summary>
        /// RealEstateBrokerB NMLS ID [CD5.X36]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB NMLS ID")]
        public string RealEstateBrokerBNMLSID { get => _realEstateBrokerBNMLSID; set => _realEstateBrokerBNMLSID = value; }
        private DirtyValue<string> _realEstateBrokerBPhone;
        /// <summary>
        /// RealEstateBrokerB Phone [CD5.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "RealEstateBrokerB Phone")]
        public string RealEstateBrokerBPhone { get => _realEstateBrokerBPhone; set => _realEstateBrokerBPhone = value; }
        private DirtyValue<string> _realEstateBrokerBState;
        /// <summary>
        /// RealEstateBrokerB State [CD5.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "RealEstateBrokerB State")]
        public string RealEstateBrokerBState { get => _realEstateBrokerBState; set => _realEstateBrokerBState = value; }
        private DirtyValue<string> _realEstateBrokerBSTLicenseID;
        /// <summary>
        /// RealEstateBrokerB ST License ID [CD5.X37]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerB ST License ID")]
        public string RealEstateBrokerBSTLicenseID { get => _realEstateBrokerBSTLicenseID; set => _realEstateBrokerBSTLicenseID = value; }
        private DirtyValue<string> _realEstateBrokerBZip;
        /// <summary>
        /// RealEstateBrokerB Zip [CD5.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "RealEstateBrokerB Zip")]
        public string RealEstateBrokerBZip { get => _realEstateBrokerBZip; set => _realEstateBrokerBZip = value; }
        private DirtyValue<string> _realEstateBrokerSAddress;
        /// <summary>
        /// RealEstateBrokerS Address [CD5.X44]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Address")]
        public string RealEstateBrokerSAddress { get => _realEstateBrokerSAddress; set => _realEstateBrokerSAddress = value; }
        private DirtyValue<string> _realEstateBrokerSCity;
        /// <summary>
        /// RealEstateBrokerS City [CD5.X45]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS City")]
        public string RealEstateBrokerSCity { get => _realEstateBrokerSCity; set => _realEstateBrokerSCity = value; }
        private DirtyValue<string> _realEstateBrokerSContact;
        /// <summary>
        /// RealEstateBrokerS Contact [CD5.X50]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Contact")]
        public string RealEstateBrokerSContact { get => _realEstateBrokerSContact; set => _realEstateBrokerSContact = value; }
        private DirtyValue<string> _realEstateBrokerSContactATLicenseID;
        /// <summary>
        /// Real Estate Broker (S) Contact ST License ID [CD5.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Real Estate Broker (S) Contact ST License ID")]
        public string RealEstateBrokerSContactATLicenseID { get => _realEstateBrokerSContactATLicenseID; set => _realEstateBrokerSContactATLicenseID = value; }
        private DirtyValue<string> _realEstateBrokerSContactNMLSID;
        /// <summary>
        /// RealEstateBrokerS Contact NMLSID [CD5.X51]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Contact NMLSID")]
        public string RealEstateBrokerSContactNMLSID { get => _realEstateBrokerSContactNMLSID; set => _realEstateBrokerSContactNMLSID = value; }
        private DirtyValue<string> _realEstateBrokerSEmail;
        /// <summary>
        /// RealEstateBrokerS Email [CD5.X53]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Email")]
        public string RealEstateBrokerSEmail { get => _realEstateBrokerSEmail; set => _realEstateBrokerSEmail = value; }
        private DirtyValue<string> _realEstateBrokerSName;
        /// <summary>
        /// RealEstateBrokerS Name [CD5.X43]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS Name")]
        public string RealEstateBrokerSName { get => _realEstateBrokerSName; set => _realEstateBrokerSName = value; }
        private DirtyValue<string> _realEstateBrokerSNMLSID;
        /// <summary>
        /// RealEstateBrokerS NMLS ID [CD5.X48]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS NMLS ID")]
        public string RealEstateBrokerSNMLSID { get => _realEstateBrokerSNMLSID; set => _realEstateBrokerSNMLSID = value; }
        private DirtyValue<string> _realEstateBrokerSPhone;
        /// <summary>
        /// RealEstateBrokerS Phone [CD5.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "RealEstateBrokerS Phone")]
        public string RealEstateBrokerSPhone { get => _realEstateBrokerSPhone; set => _realEstateBrokerSPhone = value; }
        private DirtyValue<string> _realEstateBrokerSState;
        /// <summary>
        /// RealEstateBrokerS State [CD5.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "RealEstateBrokerS State")]
        public string RealEstateBrokerSState { get => _realEstateBrokerSState; set => _realEstateBrokerSState = value; }
        private DirtyValue<string> _realEstateBrokerSSTLicenseID;
        /// <summary>
        /// RealEstateBrokerS ST License ID [CD5.X49]
        /// </summary>
        [LoanFieldProperty(Description = "RealEstateBrokerS ST License ID")]
        public string RealEstateBrokerSSTLicenseID { get => _realEstateBrokerSSTLicenseID; set => _realEstateBrokerSSTLicenseID = value; }
        private DirtyValue<string> _realEstateBrokerSZip;
        /// <summary>
        /// RealEstateBrokerS Zip [CD5.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "RealEstateBrokerS Zip")]
        public string RealEstateBrokerSZip { get => _realEstateBrokerSZip; set => _realEstateBrokerSZip = value; }
        private DirtyValue<string> _settlementAgentAddress;
        /// <summary>
        /// SettlementAgent Address [CD5.X56]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Address")]
        public string SettlementAgentAddress { get => _settlementAgentAddress; set => _settlementAgentAddress = value; }
        private DirtyValue<string> _settlementAgentCity;
        /// <summary>
        /// SettlementAgent City [CD5.X57]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent City")]
        public string SettlementAgentCity { get => _settlementAgentCity; set => _settlementAgentCity = value; }
        private DirtyValue<string> _settlementAgentContact;
        /// <summary>
        /// SettlementAgent Contact [CD5.X62]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Contact")]
        public string SettlementAgentContact { get => _settlementAgentContact; set => _settlementAgentContact = value; }
        private DirtyValue<string> _settlementAgentContactATLicenseID;
        /// <summary>
        /// Settlement Agent Contact ST License ID [CD5.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Agent Contact ST License ID")]
        public string SettlementAgentContactATLicenseID { get => _settlementAgentContactATLicenseID; set => _settlementAgentContactATLicenseID = value; }
        private DirtyValue<string> _settlementAgentContactNMLSID;
        /// <summary>
        /// SettlementAgent Contact NMLSID [CD5.X63]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Contact NMLSID")]
        public string SettlementAgentContactNMLSID { get => _settlementAgentContactNMLSID; set => _settlementAgentContactNMLSID = value; }
        private DirtyValue<string> _settlementAgentEmail;
        /// <summary>
        /// SettlementAgent Email [CD5.X65]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Email")]
        public string SettlementAgentEmail { get => _settlementAgentEmail; set => _settlementAgentEmail = value; }
        private DirtyValue<string> _settlementAgentName;
        /// <summary>
        /// SettlementAgent Name [CD5.X55]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent Name")]
        public string SettlementAgentName { get => _settlementAgentName; set => _settlementAgentName = value; }
        private DirtyValue<string> _settlementAgentNMLSID;
        /// <summary>
        /// SettlementAgent NMLS ID [CD5.X60]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent NMLS ID")]
        public string SettlementAgentNMLSID { get => _settlementAgentNMLSID; set => _settlementAgentNMLSID = value; }
        private DirtyValue<string> _settlementAgentPhone;
        /// <summary>
        /// SettlementAgent Phone [CD5.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "SettlementAgent Phone")]
        public string SettlementAgentPhone { get => _settlementAgentPhone; set => _settlementAgentPhone = value; }
        private DirtyValue<string> _settlementAgentState;
        /// <summary>
        /// SettlementAgent State [CD5.X58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "SettlementAgent State")]
        public string SettlementAgentState { get => _settlementAgentState; set => _settlementAgentState = value; }
        private DirtyValue<string> _settlementAgentSTLicenseID;
        /// <summary>
        /// SettlementAgent ST License ID [CD5.X61]
        /// </summary>
        [LoanFieldProperty(Description = "SettlementAgent ST License ID")]
        public string SettlementAgentSTLicenseID { get => _settlementAgentSTLicenseID; set => _settlementAgentSTLicenseID = value; }
        private DirtyValue<string> _settlementAgentZip;
        /// <summary>
        /// SettlementAgent Zip [CD5.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "SettlementAgent Zip")]
        public string SettlementAgentZip { get => _settlementAgentZip; set => _settlementAgentZip = value; }
        private DirtyValue<StringEnumValue<SignatureType>> _signatureType;
        /// <summary>
        /// Closing Disclosure - Signature Type [CD5.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Signature Type")]
        public StringEnumValue<SignatureType> SignatureType { get => _signatureType; set => _signatureType = value; }
        private DirtyValue<decimal?> _totalPayments;
        /// <summary>
        /// Closing disclosure 5 - Total Payments [CD5.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure 5 - Total Payments")]
        public decimal? TotalPayments { get => _totalPayments; set => _totalPayments = value; }
        internal override bool DirtyInternal
        {
            get => _cDLiabilityAfterForeclosure.Dirty
                || _id.Dirty
                || _lenderAddress.Dirty
                || _lenderCity.Dirty
                || _lenderContact.Dirty
                || _lenderContactATLicenseID.Dirty
                || _lenderContactNMLSID.Dirty
                || _lenderEmail.Dirty
                || _lenderName.Dirty
                || _lenderNMLSID.Dirty
                || _lenderPhone.Dirty
                || _lenderState.Dirty
                || _lenderSTLicenseID.Dirty
                || _lenderZip.Dirty
                || _mortgageBrokerAddress.Dirty
                || _mortgageBrokerCity.Dirty
                || _mortgageBrokerContact.Dirty
                || _mortgageBrokerContactATLicenseID.Dirty
                || _mortgageBrokerContactNMLSID.Dirty
                || _mortgageBrokerEmail.Dirty
                || _mortgageBrokerName.Dirty
                || _mortgageBrokerNMLSID.Dirty
                || _mortgageBrokerPhone.Dirty
                || _mortgageBrokerState.Dirty
                || _mortgageBrokerSTLicenseID.Dirty
                || _mortgageBrokerZip.Dirty
                || _realEstateBrokerBAddress.Dirty
                || _realEstateBrokerBCity.Dirty
                || _realEstateBrokerBContact.Dirty
                || _realEstateBrokerBContactATLicenseID.Dirty
                || _realEstateBrokerBContactNMLSID.Dirty
                || _realEstateBrokerBEmail.Dirty
                || _realEstateBrokerBName.Dirty
                || _realEstateBrokerBNMLSID.Dirty
                || _realEstateBrokerBPhone.Dirty
                || _realEstateBrokerBState.Dirty
                || _realEstateBrokerBSTLicenseID.Dirty
                || _realEstateBrokerBZip.Dirty
                || _realEstateBrokerSAddress.Dirty
                || _realEstateBrokerSCity.Dirty
                || _realEstateBrokerSContact.Dirty
                || _realEstateBrokerSContactATLicenseID.Dirty
                || _realEstateBrokerSContactNMLSID.Dirty
                || _realEstateBrokerSEmail.Dirty
                || _realEstateBrokerSName.Dirty
                || _realEstateBrokerSNMLSID.Dirty
                || _realEstateBrokerSPhone.Dirty
                || _realEstateBrokerSState.Dirty
                || _realEstateBrokerSSTLicenseID.Dirty
                || _realEstateBrokerSZip.Dirty
                || _settlementAgentAddress.Dirty
                || _settlementAgentCity.Dirty
                || _settlementAgentContact.Dirty
                || _settlementAgentContactATLicenseID.Dirty
                || _settlementAgentContactNMLSID.Dirty
                || _settlementAgentEmail.Dirty
                || _settlementAgentName.Dirty
                || _settlementAgentNMLSID.Dirty
                || _settlementAgentPhone.Dirty
                || _settlementAgentState.Dirty
                || _settlementAgentSTLicenseID.Dirty
                || _settlementAgentZip.Dirty
                || _signatureType.Dirty
                || _totalPayments.Dirty;
            set
            {
                _cDLiabilityAfterForeclosure.Dirty = value;
                _id.Dirty = value;
                _lenderAddress.Dirty = value;
                _lenderCity.Dirty = value;
                _lenderContact.Dirty = value;
                _lenderContactATLicenseID.Dirty = value;
                _lenderContactNMLSID.Dirty = value;
                _lenderEmail.Dirty = value;
                _lenderName.Dirty = value;
                _lenderNMLSID.Dirty = value;
                _lenderPhone.Dirty = value;
                _lenderState.Dirty = value;
                _lenderSTLicenseID.Dirty = value;
                _lenderZip.Dirty = value;
                _mortgageBrokerAddress.Dirty = value;
                _mortgageBrokerCity.Dirty = value;
                _mortgageBrokerContact.Dirty = value;
                _mortgageBrokerContactATLicenseID.Dirty = value;
                _mortgageBrokerContactNMLSID.Dirty = value;
                _mortgageBrokerEmail.Dirty = value;
                _mortgageBrokerName.Dirty = value;
                _mortgageBrokerNMLSID.Dirty = value;
                _mortgageBrokerPhone.Dirty = value;
                _mortgageBrokerState.Dirty = value;
                _mortgageBrokerSTLicenseID.Dirty = value;
                _mortgageBrokerZip.Dirty = value;
                _realEstateBrokerBAddress.Dirty = value;
                _realEstateBrokerBCity.Dirty = value;
                _realEstateBrokerBContact.Dirty = value;
                _realEstateBrokerBContactATLicenseID.Dirty = value;
                _realEstateBrokerBContactNMLSID.Dirty = value;
                _realEstateBrokerBEmail.Dirty = value;
                _realEstateBrokerBName.Dirty = value;
                _realEstateBrokerBNMLSID.Dirty = value;
                _realEstateBrokerBPhone.Dirty = value;
                _realEstateBrokerBState.Dirty = value;
                _realEstateBrokerBSTLicenseID.Dirty = value;
                _realEstateBrokerBZip.Dirty = value;
                _realEstateBrokerSAddress.Dirty = value;
                _realEstateBrokerSCity.Dirty = value;
                _realEstateBrokerSContact.Dirty = value;
                _realEstateBrokerSContactATLicenseID.Dirty = value;
                _realEstateBrokerSContactNMLSID.Dirty = value;
                _realEstateBrokerSEmail.Dirty = value;
                _realEstateBrokerSName.Dirty = value;
                _realEstateBrokerSNMLSID.Dirty = value;
                _realEstateBrokerSPhone.Dirty = value;
                _realEstateBrokerSState.Dirty = value;
                _realEstateBrokerSSTLicenseID.Dirty = value;
                _realEstateBrokerSZip.Dirty = value;
                _settlementAgentAddress.Dirty = value;
                _settlementAgentCity.Dirty = value;
                _settlementAgentContact.Dirty = value;
                _settlementAgentContactATLicenseID.Dirty = value;
                _settlementAgentContactNMLSID.Dirty = value;
                _settlementAgentEmail.Dirty = value;
                _settlementAgentName.Dirty = value;
                _settlementAgentNMLSID.Dirty = value;
                _settlementAgentPhone.Dirty = value;
                _settlementAgentState.Dirty = value;
                _settlementAgentSTLicenseID.Dirty = value;
                _settlementAgentZip.Dirty = value;
                _signatureType.Dirty = value;
                _totalPayments.Dirty = value;
            }
        }
    }
}