using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// StateDisclosure
    /// </summary>
    public sealed partial class StateDisclosure : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _acceptedByBorrowerIndicator;
        /// <summary>
        /// Disclosure-FL Borr Accept [FLMTGCM.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Borr Accept", OptionsJson = "{\"true\":\"The date by which the commitment must be accepted by the borrower is\"}")]
        public bool? AcceptedByBorrowerIndicator { get => _acceptedByBorrowerIndicator; set => _acceptedByBorrowerIndicator = value; }
        private DirtyValue<DateTime?> _acceptedDate;
        /// <summary>
        /// Disclosure-FL Borr Accept Date [FLMTGCM.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Borr Accept Date")]
        public DateTime? AcceptedDate { get => _acceptedDate; set => _acceptedDate = value; }
        private DirtyValue<string> _actingOtherDescription1;
        /// <summary>
        /// Disclosure-TX Act Descr 1 [DISCLOSURE.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Act Descr 1")]
        public string ActingOtherDescription1 { get => _actingOtherDescription1; set => _actingOtherDescription1 = value; }
        private DirtyValue<string> _actingOtherDescription2;
        /// <summary>
        /// Disclosure-TX Act Descr 2 [DISCLOSURE.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Act Descr 2")]
        public string ActingOtherDescription2 { get => _actingOtherDescription2; set => _actingOtherDescription2 = value; }
        private DirtyValue<bool?> _actingOthersIndicator;
        /// <summary>
        /// Disclosure-TX Act as Follows [DISCLOSURE.X76]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Act as Follows", OptionsJson = "{\"true\":\"We will be acting as follows:\"}")]
        public bool? ActingOthersIndicator { get => _actingOthersIndicator; set => _actingOthersIndicator = value; }
        private DirtyValue<int?> _advFeeAgmtInEfctNumDay;
        /// <summary>
        /// Disclosure-AZ Advance Fee Agreement In Effect Number Of Days [DISCLOSURE.X915]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-AZ Advance Fee Agreement In Effect Number Of Days")]
        public int? AdvFeeAgmtInEfctNumDay { get => _advFeeAgmtInEfctNumDay; set => _advFeeAgmtInEfctNumDay = value; }
        private DirtyValue<string> _advisoryCondition1;
        /// <summary>
        /// Disclosure-NY Acknowledge 1 [DISCLOSURE.X105]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Acknowledge 1")]
        public string AdvisoryCondition1 { get => _advisoryCondition1; set => _advisoryCondition1 = value; }
        private DirtyValue<string> _advisoryCondition2;
        /// <summary>
        /// Disclosure-NY Acknowledge 2 [DISCLOSURE.X106]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Acknowledge 2")]
        public string AdvisoryCondition2 { get => _advisoryCondition2; set => _advisoryCondition2 = value; }
        private DirtyValue<string> _advisoryCondition3;
        /// <summary>
        /// Disclosure-NY Acknowledge 3 [DISCLOSURE.X107]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Acknowledge 3")]
        public string AdvisoryCondition3 { get => _advisoryCondition3; set => _advisoryCondition3 = value; }
        private DirtyValue<string> _advisoryCondition4;
        /// <summary>
        /// Disclosure-NY Acknowledge 4 [DISCLOSURE.X108]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Acknowledge 4")]
        public string AdvisoryCondition4 { get => _advisoryCondition4; set => _advisoryCondition4 = value; }
        private DirtyValue<decimal?> _amendedAcquisitionCost;
        /// <summary>
        /// Disclosure - AK - Amended Acquisition Cost [DISCLOSURE.X974]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Amended Acquisition Cost")]
        public decimal? AmendedAcquisitionCost { get => _amendedAcquisitionCost; set => _amendedAcquisitionCost = value; }
        private DirtyValue<DateTime?> _applicationDate;
        /// <summary>
        /// Disclosure-NY Application Date [DISCLOSURE.X172]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Application Date")]
        public DateTime? ApplicationDate { get => _applicationDate; set => _applicationDate = value; }
        private DirtyValue<string> _appraisalContact;
        /// <summary>
        /// Disclosure-TX Appraisal Fee Descr [DISCLOSURE.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Appraisal Fee Descr")]
        public string AppraisalContact { get => _appraisalContact; set => _appraisalContact = value; }
        private DirtyValue<decimal?> _appraisalDeposit;
        /// <summary>
        /// Disclosure-FL Appraisal Fee [DISCLOSURE.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Appraisal Fee")]
        public decimal? AppraisalDeposit { get => _appraisalDeposit; set => _appraisalDeposit = value; }
        private DirtyValue<StringEnumValue<Areas>> _areas;
        /// <summary>
        /// Disclosure - AK - Areas [DISCLOSURE.X960]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - AK - Areas")]
        public StringEnumValue<Areas> Areas { get => _areas; set => _areas = value; }
        private DirtyValue<bool?> _asAttorneyIndicator;
        /// <summary>
        /// Disclosure-TX Role - Attorney [DISCLOSURE.X99]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Role - Attorney", OptionsJson = "{\"true\":\"as an attorney for\"}")]
        public bool? AsAttorneyIndicator { get => _asAttorneyIndicator; set => _asAttorneyIndicator = value; }
        private DirtyValue<bool?> _asRealBrokerIndicator;
        /// <summary>
        /// Disclosure-TX Role - RE Broker/Agent [DISCLOSURE.X95]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Role - RE Broker/Agent", OptionsJson = "{\"true\":\"as a real estate broker, agent, or salesperson for\"}")]
        public bool? AsRealBrokerIndicator { get => _asRealBrokerIndicator; set => _asRealBrokerIndicator = value; }
        private DirtyValue<bool?> _attorneyForTheBuyerIndicator;
        /// <summary>
        /// Disclosure-TX Attorney for Buyer [DISCLOSURE.X101]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Attorney for Buyer", OptionsJson = "{\"true\":\"you (the buyer)\"}")]
        public bool? AttorneyForTheBuyerIndicator { get => _attorneyForTheBuyerIndicator; set => _attorneyForTheBuyerIndicator = value; }
        private DirtyValue<bool?> _attorneyForTheLenderIndicator;
        /// <summary>
        /// Disclosure-TX Attorney for Buyer/Seller [DISCLOSURE.X102]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Attorney for Buyer/Seller", OptionsJson = "{\"true\":\"the lender\"}")]
        public bool? AttorneyForTheLenderIndicator { get => _attorneyForTheLenderIndicator; set => _attorneyForTheLenderIndicator = value; }
        private DirtyValue<bool?> _attorneyForTheSellerIndicator;
        /// <summary>
        /// Disclosure-TX Attorney for Seller [DISCLOSURE.X100]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Attorney for Seller", OptionsJson = "{\"true\":\"the seller\"}")]
        public bool? AttorneyForTheSellerIndicator { get => _attorneyForTheSellerIndicator; set => _attorneyForTheSellerIndicator = value; }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1BlankFldDesc1;
        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document Description 1 [DISCLOSURE.X917]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-AZ AZ Complete Blank Spaces Document Description 1")]
        public string AZCmplBlankSpcsDoc1BlankFldDesc1 { get => _aZCmplBlankSpcsDoc1BlankFldDesc1; set => _aZCmplBlankSpcsDoc1BlankFldDesc1 = value; }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1BlankFldDesc2;
        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document Description 2 [DISCLOSURE.X919]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-AZ AZ Complete Blank Spaces Document Description 2")]
        public string AZCmplBlankSpcsDoc1BlankFldDesc2 { get => _aZCmplBlankSpcsDoc1BlankFldDesc2; set => _aZCmplBlankSpcsDoc1BlankFldDesc2 = value; }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1BlankFldDesc3;
        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document Description 3 [DISCLOSURE.X921]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-AZ AZ Complete Blank Spaces Document Description 3")]
        public string AZCmplBlankSpcsDoc1BlankFldDesc3 { get => _aZCmplBlankSpcsDoc1BlankFldDesc3; set => _aZCmplBlankSpcsDoc1BlankFldDesc3 = value; }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1Nm;
        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document 1 [DISCLOSURE.X916]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-AZ AZ Complete Blank Spaces Document 1")]
        public string AZCmplBlankSpcsDoc1Nm { get => _aZCmplBlankSpcsDoc1Nm; set => _aZCmplBlankSpcsDoc1Nm = value; }
        private DirtyValue<string> _aZCmplBlankSpcsDoc2Nm;
        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document 2 [DISCLOSURE.X918]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-AZ AZ Complete Blank Spaces Document 2")]
        public string AZCmplBlankSpcsDoc2Nm { get => _aZCmplBlankSpcsDoc2Nm; set => _aZCmplBlankSpcsDoc2Nm = value; }
        private DirtyValue<string> _aZCmplBlankSpcsDoc3Nm;
        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document 3 [DISCLOSURE.X920]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-AZ AZ Complete Blank Spaces Document 3")]
        public string AZCmplBlankSpcsDoc3Nm { get => _aZCmplBlankSpcsDoc3Nm; set => _aZCmplBlankSpcsDoc3Nm = value; }
        private DirtyValue<string> _basedOnOthersDescription;
        /// <summary>
        /// Disclosure-TX Compensated Based on Others Description [DISCLOSURE.X909]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Compensated Based on Others Description")]
        public string BasedOnOthersDescription { get => _basedOnOthersDescription; set => _basedOnOthersDescription = value; }
        private DirtyValue<bool?> _basedOnOthersIndicator;
        /// <summary>
        /// Disclosure-TX Compensated Based on Others [DISCLOSURE.X908]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Compensated Based on Others")]
        public bool? BasedOnOthersIndicator { get => _basedOnOthersIndicator; set => _basedOnOthersIndicator = value; }
        private DirtyValue<bool?> _basedOnWholesaleOptionsIndicator;
        /// <summary>
        /// Disclosure-TX Compensated Wholesale Options [DISCLOSURE.X80]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Compensated Wholesale Options", OptionsJson = "{\"true\":\"Our pricing for your loan is based upon current wholesale options available to us\"}")]
        public bool? BasedOnWholesaleOptionsIndicator { get => _basedOnWholesaleOptionsIndicator; set => _basedOnWholesaleOptionsIndicator = value; }
        private DirtyValue<decimal?> _borrowerElectsEstablishEscrowAmount;
        /// <summary>
        /// Disclosure- CA Borrower Elects To Establish Escrow Account Amount [DISCLOSURE.X914]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure- CA Borrower Elects To Establish Escrow Account Amount")]
        public decimal? BorrowerElectsEstablishEscrowAmount { get => _borrowerElectsEstablishEscrowAmount; set => _borrowerElectsEstablishEscrowAmount = value; }
        private DirtyValue<bool?> _borrowerElectsEstablishEscrowIndicator;
        /// <summary>
        /// Disclosure- CA Borrower Elects To Establish Escrow Account Indicator [DISCLOSURE.X913]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure- CA Borrower Elects To Establish Escrow Account Indicator")]
        public bool? BorrowerElectsEstablishEscrowIndicator { get => _borrowerElectsEstablishEscrowIndicator; set => _borrowerElectsEstablishEscrowIndicator = value; }
        private DirtyValue<decimal?> _brokerageFeeAddition1;
        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee Amt [DISCLOSURE.X62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Borr Paid Broker Fee Amt")]
        public decimal? BrokerageFeeAddition1 { get => _brokerageFeeAddition1; set => _brokerageFeeAddition1 = value; }
        private DirtyValue<decimal?> _brokerageFeeAddition2;
        /// <summary>
        /// Disclosure-FL Borr Paid Comp From Amt [DISCLOSURE.X64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Borr Paid Comp From Amt")]
        public decimal? BrokerageFeeAddition2 { get => _brokerageFeeAddition2; set => _brokerageFeeAddition2 = value; }
        private DirtyValue<decimal?> _brokerageFeeAddition3;
        /// <summary>
        /// Disclosure-FL Borr Paid Comp To Amt [DISCLOSURE.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Borr Paid Comp To Amt")]
        public decimal? BrokerageFeeAddition3 { get => _brokerageFeeAddition3; set => _brokerageFeeAddition3 = value; }
        private DirtyValue<decimal?> _brokerageFeeAmount1;
        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee Total [FLGFE.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Disclosure-FL Borr Paid Broker Fee Total")]
        public decimal? BrokerageFeeAmount1 { get => _brokerageFeeAmount1; set => _brokerageFeeAmount1 = value; }
        private DirtyValue<decimal?> _brokerageFeeAmount2;
        /// <summary>
        /// Disclosure-FL Borr Paid Comp From Total [FLGFE.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Disclosure-FL Borr Paid Comp From Total")]
        public decimal? BrokerageFeeAmount2 { get => _brokerageFeeAmount2; set => _brokerageFeeAmount2 = value; }
        private DirtyValue<decimal?> _brokerageFeeAmount3;
        /// <summary>
        /// Disclosure-FL Borr Paid Comp To Total [FLGFE.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Disclosure-FL Borr Paid Comp To Total")]
        public decimal? BrokerageFeeAmount3 { get => _brokerageFeeAmount3; set => _brokerageFeeAmount3 = value; }
        private DirtyValue<int?> _brokerageFeeDays;
        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee # Days [FLGFE.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Borr Paid Broker Fee # Days")]
        public int? BrokerageFeeDays { get => _brokerageFeeDays; set => _brokerageFeeDays = value; }
        private DirtyValue<decimal?> _brokerageFeePercent1;
        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee % [DISCLOSURE.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-FL Borr Paid Broker Fee %")]
        public decimal? BrokerageFeePercent1 { get => _brokerageFeePercent1; set => _brokerageFeePercent1 = value; }
        private DirtyValue<decimal?> _brokerageFeePercent2;
        /// <summary>
        /// Disclosure-FL Borr Paid Comp From % [DISCLOSURE.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-FL Borr Paid Comp From %")]
        public decimal? BrokerageFeePercent2 { get => _brokerageFeePercent2; set => _brokerageFeePercent2 = value; }
        private DirtyValue<decimal?> _brokerageFeePercent3;
        /// <summary>
        /// Disclosure-FL Borr Paid Comp To % [DISCLOSURE.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-FL Borr Paid Comp To %")]
        public decimal? BrokerageFeePercent3 { get => _brokerageFeePercent3; set => _brokerageFeePercent3 = value; }
        private DirtyValue<string> _brokerAuthorizedSigningRepName;
        /// <summary>
        /// Disclosure-NV Broker Authorized Signing Representative Name [DISCLOSURE.X922]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Broker Authorized Signing Representative Name")]
        public string BrokerAuthorizedSigningRepName { get => _brokerAuthorizedSigningRepName; set => _brokerAuthorizedSigningRepName = value; }
        private DirtyValue<string> _brokerAuthorizedSigningRepTitle;
        /// <summary>
        /// Disclosure-NV Broker Authorized Signing Representative Title [DISCLOSURE.X923]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Broker Authorized Signing Representative Title")]
        public string BrokerAuthorizedSigningRepTitle { get => _brokerAuthorizedSigningRepTitle; set => _brokerAuthorizedSigningRepTitle = value; }
        private DirtyValue<StringEnumValue<BrokerForTheSeller>> _brokerForTheSeller;
        /// <summary>
        /// Disclosure-TX Broker for Seller/Buyer/Buyer and Seller [DISCLOSURE.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Broker for Seller/Buyer/Buyer and Seller")]
        public StringEnumValue<BrokerForTheSeller> BrokerForTheSeller { get => _brokerForTheSeller; set => _brokerForTheSeller = value; }
        private DirtyValue<string> _brokerLicense;
        /// <summary>
        /// Disclosure-TX License # [DISCLOSURE.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX License #")]
        public string BrokerLicense { get => _brokerLicense; set => _brokerLicense = value; }
        private DirtyValue<string> _brokerName;
        /// <summary>
        /// Disclosure-TX Broker/Loan Officer [DISCLOSURE.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Broker/Loan Officer")]
        public string BrokerName { get => _brokerName; set => _brokerName = value; }
        private DirtyValue<decimal?> _brokerPayAddition;
        /// <summary>
        /// Disclosure-NY Broker Paid Fee + [DISCLOSURE.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Broker Paid Fee +")]
        public decimal? BrokerPayAddition { get => _brokerPayAddition; set => _brokerPayAddition = value; }
        private DirtyValue<decimal?> _brokerPayAmount;
        /// <summary>
        /// Disclosure-NY Broker Paid Fee Amt [DISCLOSURE.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Broker Paid Fee Amt")]
        public decimal? BrokerPayAmount { get => _brokerPayAmount; set => _brokerPayAmount = value; }
        private DirtyValue<bool?> _brokerPayIndicator;
        /// <summary>
        /// Disclosure-NY Broker Paid Fee [DISCLOSURE.X114]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Broker Paid Fee", OptionsJson = "{\"true\":\"I will pay you a fee of\"}")]
        public bool? BrokerPayIndicator { get => _brokerPayIndicator; set => _brokerPayIndicator = value; }
        private DirtyValue<decimal?> _brokerPayPercent;
        /// <summary>
        /// Disclosure-NY Broker Paid Fee % [DISCLOSURE.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-NY Broker Paid Fee %")]
        public decimal? BrokerPayPercent { get => _brokerPayPercent; set => _brokerPayPercent = value; }
        private DirtyValue<bool?> _cHARMBookletIndicator;
        /// <summary>
        /// Disclosure-FL Federal CHARM booklet [FLGFE.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Federal CHARM booklet")]
        public bool? CHARMBookletIndicator { get => _cHARMBookletIndicator; set => _cHARMBookletIndicator = value; }
        private DirtyValue<string> _checkPayableTo;
        /// <summary>
        /// Disclosure-FL Check Payable To [DISCLOSURE.X170]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Check Payable To")]
        public string CheckPayableTo { get => _checkPayableTo; set => _checkPayableTo = value; }
        private DirtyValue<decimal?> _commitmentAmount;
        /// <summary>
        /// Disclosure-FL Interest Rate Fee Amt [FLMTGCM.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Interest Rate Fee Amt")]
        public decimal? CommitmentAmount { get => _commitmentAmount; set => _commitmentAmount = value; }
        private DirtyValue<string> _commitmentCondition1;
        /// <summary>
        /// Disclosure-NY Loan Commit Conditions 1 [DISCLOSURE.X103]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Loan Commit Conditions 1")]
        public string CommitmentCondition1 { get => _commitmentCondition1; set => _commitmentCondition1 = value; }
        private DirtyValue<string> _commitmentCondition2;
        /// <summary>
        /// Disclosure-NY Loan Commit Conditions 2 [DISCLOSURE.X104]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Loan Commit Conditions 2")]
        public string CommitmentCondition2 { get => _commitmentCondition2; set => _commitmentCondition2 = value; }
        private DirtyValue<decimal?> _commitmentFee;
        /// <summary>
        /// Disclosure-FL Commitment Fee [FLMTGCM.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Commitment Fee")]
        public decimal? CommitmentFee { get => _commitmentFee; set => _commitmentFee = value; }
        private DirtyValue<decimal?> _commitmentPercent;
        /// <summary>
        /// Disclosure-FL Interest Rate Fee % [FLMTGCM.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-FL Interest Rate Fee %")]
        public decimal? CommitmentPercent { get => _commitmentPercent; set => _commitmentPercent = value; }
        private DirtyValue<decimal?> _compensationAddition;
        /// <summary>
        /// Disclosure-FL Lender Paid Broker Comp To % [FLGFE.X51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Disclosure-FL Lender Paid Broker Comp To %")]
        public decimal? CompensationAddition { get => _compensationAddition; set => _compensationAddition = value; }
        private DirtyValue<decimal?> _compensationPercent;
        /// <summary>
        /// Disclosure-FL Lender Paid Broker Comp From % [FLGFE.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Disclosure-FL Lender Paid Broker Comp From %")]
        public decimal? CompensationPercent { get => _compensationPercent; set => _compensationPercent = value; }
        private DirtyValue<decimal?> _creditDeposit;
        /// <summary>
        /// Disclosure-FL Credit Deposit [DISCLOSURE.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Credit Deposit")]
        public decimal? CreditDeposit { get => _creditDeposit; set => _creditDeposit = value; }
        private DirtyValue<string> _creditIsUsedForReason;
        /// <summary>
        /// Disclosure Credit Score Used From The Credit Report to Set the Terms of Credit [DISCLOSURE.X637]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Credit Score Used From The Credit Report to Set the Terms of Credit")]
        public string CreditIsUsedForReason { get => _creditIsUsedForReason; set => _creditIsUsedForReason = value; }
        private DirtyValue<string> _creditReportContact;
        /// <summary>
        /// Disclosure-TX Credit Rpt Fee Descr [DISCLOSURE.X86]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Credit Rpt Fee Descr")]
        public string CreditReportContact { get => _creditReportContact; set => _creditReportContact = value; }
        private DirtyValue<int?> _daysBeforeClosing;
        /// <summary>
        /// Disclosure-FL Rate Est # Days Before Close [FLMTGCM.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Rate Est # Days Before Close")]
        public int? DaysBeforeClosing { get => _daysBeforeClosing; set => _daysBeforeClosing = value; }
        private DirtyValue<decimal?> _depositReceipt;
        /// <summary>
        /// Disclosure-FL Receipt of Deposit Amt [FLGFE.X53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Receipt of Deposit Amt")]
        public decimal? DepositReceipt { get => _depositReceipt; set => _depositReceipt = value; }
        private DirtyValue<bool?> _depositRefundableIndicator;
        /// <summary>
        /// Disclosure-FL Deposit Refundable [FLGFE.X55]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure-FL Deposit Refundable", OptionsJson = "{\"true\":\"Refundable by\"}")]
        public bool? DepositRefundableIndicator { get => _depositRefundableIndicator; set => _depositRefundableIndicator = value; }
        private DirtyValue<string> _directContact;
        /// <summary>
        /// Disclosure-FL Direct inquiries To [FLGFE.X70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure-FL Direct inquiries To")]
        public string DirectContact { get => _directContact; set => _directContact = value; }
        private DirtyValue<decimal?> _directPayAmount;
        /// <summary>
        /// Disclosure-NY Broker Paid Direct Amt [DISCLOSURE.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Broker Paid Direct Amt")]
        public decimal? DirectPayAmount { get => _directPayAmount; set => _directPayAmount = value; }
        private DirtyValue<decimal?> _directPayClosing;
        /// <summary>
        /// Disclosure-NY  Broker Paid Direct at Close [DISCLOSURE.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY  Broker Paid Direct at Close")]
        public decimal? DirectPayClosing { get => _directPayClosing; set => _directPayClosing = value; }
        private DirtyValue<decimal?> _directPayCommitment;
        /// <summary>
        /// Disclosure-NY Broker Paid Direct at Commit [DISCLOSURE.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Broker Paid Direct at Commit")]
        public decimal? DirectPayCommitment { get => _directPayCommitment; set => _directPayCommitment = value; }
        private DirtyValue<bool?> _directPayIndicator;
        /// <summary>
        /// Disclosure-NY Broker Paid Direct [DISCLOSURE.X117]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Broker Paid Direct", OptionsJson = "{\"true\":\"I will pay you directly, upon my signed acceptance of a commitment\"}")]
        public bool? DirectPayIndicator { get => _directPayIndicator; set => _directPayIndicator = value; }
        private DirtyValue<decimal?> _directPayPercent;
        /// <summary>
        /// Disclosure-NY Broker Paid Direct % [DISCLOSURE.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-NY Broker Paid Direct %")]
        public decimal? DirectPayPercent { get => _directPayPercent; set => _directPayPercent = value; }
        private DirtyValue<StringEnumValue<DisclosureDeliveredBy>> _disclosureDeliveredBy;
        /// <summary>
        /// Disclosure - TX - Disclosure Delivered By [DISCLOSURE.X957]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - TX - Disclosure Delivered By")]
        public StringEnumValue<DisclosureDeliveredBy> DisclosureDeliveredBy { get => _disclosureDeliveredBy; set => _disclosureDeliveredBy = value; }
        private DirtyValue<string> _disclosureDeliveredByOtherMethod;
        /// <summary>
        /// Disclosure - TX - Disclosure Delivered By Other Method [DISCLOSURE.X958]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - TX - Disclosure Delivered By Other Method")]
        public string DisclosureDeliveredByOtherMethod { get => _disclosureDeliveredByOtherMethod; set => _disclosureDeliveredByOtherMethod = value; }
        private DirtyValue<DateTime?> _disclosureDeliveredDate;
        /// <summary>
        /// Disclosure - TX - Disclosure Delivered Date [DISCLOSURE.X959]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - TX - Disclosure Delivered Date")]
        public DateTime? DisclosureDeliveredDate { get => _disclosureDeliveredDate; set => _disclosureDeliveredDate = value; }
        private DirtyValue<bool?> _estimatedChargeShownOnGFEIndicator;
        /// <summary>
        /// Disclosure-TX Estimated fees Will be Shown on the Good Faith Estimate Which We are Providing Now or Within three (3) Days. [DISCLOSURE.X910]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Estimated fees Will be Shown on the Good Faith Estimate Which We are Providing Now or Within three (3) Days.")]
        public bool? EstimatedChargeShownOnGFEIndicator { get => _estimatedChargeShownOnGFEIndicator; set => _estimatedChargeShownOnGFEIndicator = value; }
        private DirtyValue<DateTime?> _expirationDate;
        /// <summary>
        /// Disclosure-FL Expiration Date [FLMTGCM.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Expiration Date")]
        public DateTime? ExpirationDate { get => _expirationDate; set => _expirationDate = value; }
        private DirtyValue<decimal?> _federallySubsidizedAmount;
        /// <summary>
        /// Disclosure - AK - Federally-Subsidized Amount [DISCLOSURE.X964]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Federally-Subsidized Amount")]
        public decimal? FederallySubsidizedAmount { get => _federallySubsidizedAmount; set => _federallySubsidizedAmount = value; }
        private DirtyValue<decimal?> _federallySubsidizedAmountPercentage;
        /// <summary>
        /// Disclosure - AK - Federally-Subsidized Amount Percentage [DISCLOSURE.X963]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure - AK - Federally-Subsidized Amount Percentage")]
        public decimal? FederallySubsidizedAmountPercentage { get => _federallySubsidizedAmountPercentage; set => _federallySubsidizedAmountPercentage = value; }
        private DirtyValue<decimal?> _feeReceived1;
        /// <summary>
        /// Disclosure-NY Fee Amt [DISCLOSURE.X150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Fee Amt")]
        public decimal? FeeReceived1 { get => _feeReceived1; set => _feeReceived1 = value; }
        private DirtyValue<decimal?> _feeReceived2;
        /// <summary>
        /// Disclosure-NY Recipient Fee Amt [DISCLOSURE.X152]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Recipient Fee Amt")]
        public decimal? FeeReceived2 { get => _feeReceived2; set => _feeReceived2 = value; }
        private DirtyValue<StringEnumValue<RefundableType>> _feeReceivedByLender;
        /// <summary>
        /// Disclosure-FL Lender Fee Refund/Non-Refund [FLGFE.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Lender Fee Refund/Non-Refund")]
        public StringEnumValue<RefundableType> FeeReceivedByLender { get => _feeReceivedByLender; set => _feeReceivedByLender = value; }
        private DirtyValue<decimal?> _feesReceiving;
        /// <summary>
        /// Disclosure-TX Rec $ Fees [DISCLOSURE.X81]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Rec $ Fees")]
        public decimal? FeesReceiving { get => _feesReceiving; set => _feesReceiving = value; }
        private DirtyValue<decimal?> _floridaApplicationFee;
        /// <summary>
        /// Disclosure-FL Application Fee [DISCLOSURE.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Application Fee")]
        public decimal? FloridaApplicationFee { get => _floridaApplicationFee; set => _floridaApplicationFee = value; }
        private DirtyValue<decimal?> _floridaOtherFee1;
        /// <summary>
        /// Disclosure-FL Other Fee 1 Amt [FLMTGCM.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Other Fee 1 Amt")]
        public decimal? FloridaOtherFee1 { get => _floridaOtherFee1; set => _floridaOtherFee1 = value; }
        private DirtyValue<decimal?> _floridaOtherFee2;
        /// <summary>
        /// Disclosure-FL Other Fee 3 Amt [FLMTGCM.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Other Fee 3 Amt")]
        public decimal? FloridaOtherFee2 { get => _floridaOtherFee2; set => _floridaOtherFee2 = value; }
        private DirtyValue<string> _floridaOtherFeeTo1;
        /// <summary>
        /// Disclosure-FL Other Fee 1 Descr [FLMTGCM.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Other Fee 1 Descr")]
        public string FloridaOtherFeeTo1 { get => _floridaOtherFeeTo1; set => _floridaOtherFeeTo1 = value; }
        private DirtyValue<string> _floridaOtherFeeTo2;
        /// <summary>
        /// Disclosure-FL Other Fee 2 Descr [FLMTGCM.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Other Fee 2 Descr")]
        public string FloridaOtherFeeTo2 { get => _floridaOtherFeeTo2; set => _floridaOtherFeeTo2 = value; }
        private DirtyValue<string> _floridaOtherFeeTo3;
        /// <summary>
        /// Disclosure-FL Other Fee 3 Descr [FLMTGCM.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Other Fee 3 Descr")]
        public string FloridaOtherFeeTo3 { get => _floridaOtherFeeTo3; set => _floridaOtherFeeTo3 = value; }
        private DirtyValue<string> _floridaOtherFeeTo4;
        /// <summary>
        /// Disclosure-FL Other Fee 4 Descr [FLMTGCM.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Other Fee 4 Descr")]
        public string FloridaOtherFeeTo4 { get => _floridaOtherFeeTo4; set => _floridaOtherFeeTo4 = value; }
        private DirtyValue<string> _furtherFeesEarnedByMortgageBroker;
        /// <summary>
        /// Disclosure-NV Further Explanation of Any Fee Earned by Mortgage Broker [DISCLOSURE.X949]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Further Explanation of Any Fee Earned by Mortgage Broker")]
        public string FurtherFeesEarnedByMortgageBroker { get => _furtherFeesEarnedByMortgageBroker; set => _furtherFeesEarnedByMortgageBroker = value; }
        private DirtyValue<decimal?> _gFEFeeReceived1;
        /// <summary>
        /// Disclosure-NY GFE Amt [DISCLOSURE.X151]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY GFE Amt")]
        public decimal? GFEFeeReceived1 { get => _gFEFeeReceived1; set => _gFEFeeReceived1 = value; }
        private DirtyValue<decimal?> _gFEFeeReceived2;
        /// <summary>
        /// Disclosure-NY Recipient GFE Amt [DISCLOSURE.X153]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Recipient GFE Amt")]
        public decimal? GFEFeeReceived2 { get => _gFEFeeReceived2; set => _gFEFeeReceived2 = value; }
        private DirtyValue<bool?> _hUDBookletIndicator;
        /// <summary>
        /// Disclosure-FL HUD settlement booklet [FLGFE.X75]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL HUD settlement booklet")]
        public bool? HUDBookletIndicator { get => _hUDBookletIndicator; set => _hUDBookletIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// StateDisclosure Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _independentContractorIndicator;
        /// <summary>
        /// Disclosure-TX Act as Independent Contractor [DISCLOSURE.X75]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Act as Independent Contractor", OptionsJson = "{\"true\":\"We are acting as an independent contractor\"}")]
        public bool? IndependentContractorIndicator { get => _independentContractorIndicator; set => _independentContractorIndicator = value; }
        private DirtyValue<string> _indexUsed;
        /// <summary>
        /// Disclosure-FL Int Rate Index Used [DISCLOSURE.X168]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Int Rate Index Used")]
        public string IndexUsed { get => _indexUsed; set => _indexUsed = value; }
        private DirtyValue<string> _informationAboutTheIndexCanBeFound;
        /// <summary>
        /// Disclosure-FL Int Rate Index Info [DISCLOSURE.X169]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Int Rate Index Info")]
        public string InformationAboutTheIndexCanBeFound { get => _informationAboutTheIndexCanBeFound; set => _informationAboutTheIndexCanBeFound = value; }
        private DirtyValue<string> _inLicensedNo;
        /// <summary>
        /// Disclosure Licensed No [DISCLOSURE.X1027]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Licensed No")]
        public string InLicensedNo { get => _inLicensedNo; set => _inLicensedNo = value; }
        private DirtyValue<StringEnumValue<InLicensedType>> _inLicensedType;
        /// <summary>
        /// Disclosure Licensed Type [DISCLOSURE.X1028]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Licensed Type")]
        public StringEnumValue<InLicensedType> InLicensedType { get => _inLicensedType; set => _inLicensedType = value; }
        private DirtyValue<bool?> _isEstimateIndicator;
        /// <summary>
        /// Disclosure-FL is Estimate [FLMTGCM.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL is Estimate", OptionsJson = "{\"true\":\"This disclosure is an ESTIMATE. Some of the information necessary for an accurate disclosure is unknown to the lender. This disclosure is based upon the best information reasonably available to the lender at this time.\"}")]
        public bool? IsEstimateIndicator { get => _isEstimateIndicator; set => _isEstimateIndicator = value; }
        private DirtyValue<bool?> _ksUcccElectionIndicator;
        /// <summary>
        /// Disclosure - KS - Kansas UCCC Election [DISCLOSURE.X954]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - KS - Kansas UCCC Election", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? KsUcccElectionIndicator { get => _ksUcccElectionIndicator; set => _ksUcccElectionIndicator = value; }
        private DirtyValue<bool?> _kyHomeSolicationLoanIndicator;
        /// <summary>
        /// Disclosure - KY - Kentucky Home Solicitation Loan [DISCLOSURE.X956]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - KY - Kentucky Home Solicitation Loan", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? KyHomeSolicationLoanIndicator { get => _kyHomeSolicationLoanIndicator; set => _kyHomeSolicationLoanIndicator = value; }
        private DirtyValue<DateTime?> _leaseAgreementDate;
        /// <summary>
        /// Disclosure - AK - Lease Agreement Date [DISCLOSURE.X975]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - AK - Lease Agreement Date")]
        public DateTime? LeaseAgreementDate { get => _leaseAgreementDate; set => _leaseAgreementDate = value; }
        private DirtyValue<DateTime?> _lenderDate;
        /// <summary>
        /// Disclosure-NY Date [DISCLOSURE.X156]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Date")]
        public DateTime? LenderDate { get => _lenderDate; set => _lenderDate = value; }
        private DirtyValue<string> _lenderName;
        /// <summary>
        /// Disclosure-NY Lender [DISCLOSURE.X154]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Lender")]
        public string LenderName { get => _lenderName; set => _lenderName = value; }
        private DirtyValue<decimal?> _lenderPaid;
        /// <summary>
        /// Disclosure-FL Lender fee paid to licensee [FLGFE.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Lender fee paid to licensee")]
        public decimal? LenderPaid { get => _lenderPaid; set => _lenderPaid = value; }
        private DirtyValue<decimal?> _lenderPayAmount;
        /// <summary>
        /// Disclosure-NY Lender Paid Fee Amt [DISCLOSURE.X111]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Lender Paid Fee Amt")]
        public decimal? LenderPayAmount { get => _lenderPayAmount; set => _lenderPayAmount = value; }
        private DirtyValue<bool?> _lenderPayIndicator;
        /// <summary>
        /// Disclosure-NY Lender Paid Fee [DISCLOSURE.X109]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Lender Paid Fee", OptionsJson = "{\"true\":\"The lender will pay you a fee of\"}")]
        public bool? LenderPayIndicator { get => _lenderPayIndicator; set => _lenderPayIndicator = value; }
        private DirtyValue<decimal?> _lenderPayMaxPoint;
        /// <summary>
        /// Disclosure-NY Lender Paid Points Max [DISCLOSURE.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Lender Paid Points Max")]
        public decimal? LenderPayMaxPoint { get => _lenderPayMaxPoint; set => _lenderPayMaxPoint = value; }
        private DirtyValue<decimal?> _lenderPayPercent;
        /// <summary>
        /// Disclosure-NY Lender Paid Fee % [DISCLOSURE.X110]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-NY Lender Paid Fee %")]
        public decimal? LenderPayPercent { get => _lenderPayPercent; set => _lenderPayPercent = value; }
        private DirtyValue<decimal?> _lenderPayPoint;
        /// <summary>
        /// Disclosure-NY Lender Paid Points [DISCLOSURE.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Lender Paid Points")]
        public decimal? LenderPayPoint { get => _lenderPayPoint; set => _lenderPayPoint = value; }
        private DirtyValue<bool?> _lenderPayUnknownIndicator;
        /// <summary>
        /// Disclosure-NY Lender Fee Unknown [DISCLOSURE.X97]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Lender Fee Unknown", OptionsJson = "{\"true\":\"The fee the lender will pay you is not known. The maximum points paid including premium pricing shall not\"}")]
        public bool? LenderPayUnknownIndicator { get => _lenderPayUnknownIndicator; set => _lenderPayUnknownIndicator = value; }
        private DirtyValue<string> _lenderStatus;
        /// <summary>
        /// Disclosure-NY Status/Disposition [DISCLOSURE.X155]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Status/Disposition")]
        public string LenderStatus { get => _lenderStatus; set => _lenderStatus = value; }
        private DirtyValue<string> _lessorName;
        /// <summary>
        /// Disclosure - AK - Lessor Name [DISCLOSURE.X976]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - AK - Lessor Name")]
        public string LessorName { get => _lessorName; set => _lessorName = value; }
        private DirtyValue<bool?> _loanTermsFixedThroughDateofLoanClosingIndicator;
        /// <summary>
        /// Disclosure-Loan Terms Fixed Through Date of Loan Closing [DISCLOSURE.X951]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-Loan Terms Fixed Through Date of Loan Closing")]
        public bool? LoanTermsFixedThroughDateofLoanClosingIndicator { get => _loanTermsFixedThroughDateofLoanClosingIndicator; set => _loanTermsFixedThroughDateofLoanClosingIndicator = value; }
        private DirtyValue<decimal?> _lockInFee;
        /// <summary>
        /// Disclosure-FL Lock-in Fee [FLMTGCM.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Lock-in Fee")]
        public decimal? LockInFee { get => _lockInFee; set => _lockInFee = value; }
        private DirtyValue<string> _methodDescription;
        /// <summary>
        /// Disclosure-FL Rate Index at Closing [FLMTGCM.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Rate Index at Closing")]
        public string MethodDescription { get => _methodDescription; set => _methodDescription = value; }
        private DirtyValue<StringEnumValue<MethodDetermine>> _methodDetermine;
        /// <summary>
        /// Disclosure-FL Rate Index Subject to Change [FLMTGCM.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Rate Index Subject to Change")]
        public StringEnumValue<MethodDetermine> MethodDetermine { get => _methodDetermine; set => _methodDetermine = value; }
        private DirtyValue<bool?> _mortgageAgreementIndicator;
        /// <summary>
        /// Disclosure-FL Mortgage loan origination agreement [FLGFE.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Mortgage loan origination agreement")]
        public bool? MortgageAgreementIndicator { get => _mortgageAgreementIndicator; set => _mortgageAgreementIndicator = value; }
        private DirtyValue<string> _mtgBrokerLicense;
        /// <summary>
        /// Disclosure-FL Broker License # [FLGFE.X57]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure-FL Broker License #")]
        public string MtgBrokerLicense { get => _mtgBrokerLicense; set => _mtgBrokerLicense = value; }
        private DirtyValue<string> _nameOfLicensee;
        /// <summary>
        /// Disclosure-FL Licensee Name [DISCLOSURE.X171]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Licensee Name")]
        public string NameOfLicensee { get => _nameOfLicensee; set => _nameOfLicensee = value; }
        private DirtyValue<decimal?> _newMoneyAmount;
        /// <summary>
        /// Disclosure-NY New Money Amount [DISCLOSURE.X993]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY New Money Amount")]
        public decimal? NewMoneyAmount { get => _newMoneyAmount; set => _newMoneyAmount = value; }
        private DirtyValue<decimal?> _newYorkApplicationFee;
        /// <summary>
        /// Disclosure-NY Application Fee [DISCLOSURE.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Application Fee")]
        public decimal? NewYorkApplicationFee { get => _newYorkApplicationFee; set => _newYorkApplicationFee = value; }
        private DirtyValue<decimal?> _newYorkAppraisalFee;
        /// <summary>
        /// Disclosure-NY Appraisal Fee [DISCLOSURE.X123]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Appraisal Fee")]
        public decimal? NewYorkAppraisalFee { get => _newYorkAppraisalFee; set => _newYorkAppraisalFee = value; }
        private DirtyValue<decimal?> _newYorkCreditReportFee;
        /// <summary>
        /// Disclosure-NY Credit Fee [DISCLOSURE.X124]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Credit Fee")]
        public decimal? NewYorkCreditReportFee { get => _newYorkCreditReportFee; set => _newYorkCreditReportFee = value; }
        private DirtyList<NewYorkFee> _newYorkFees;
        /// <summary>
        /// StateDisclosure NewYorkFees
        /// </summary>
        public IList<NewYorkFee> NewYorkFees { get => _newYorkFees ?? (_newYorkFees = new DirtyList<NewYorkFee>()); set => _newYorkFees = new DirtyList<NewYorkFee>(value); }
        private DirtyList<NewYorkPrimaryLender> _newYorkPrimaryLenders;
        /// <summary>
        /// StateDisclosure NewYorkPrimaryLenders
        /// </summary>
        public IList<NewYorkPrimaryLender> NewYorkPrimaryLenders { get => _newYorkPrimaryLenders ?? (_newYorkPrimaryLenders = new DirtyList<NewYorkPrimaryLender>()); set => _newYorkPrimaryLenders = new DirtyList<NewYorkPrimaryLender>(value); }
        private DirtyValue<decimal?> _newYorkProcessingFee;
        /// <summary>
        /// Disclosure-NY Processing Fee [DISCLOSURE.X127]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Processing Fee")]
        public decimal? NewYorkProcessingFee { get => _newYorkProcessingFee; set => _newYorkProcessingFee = value; }
        private DirtyValue<decimal?> _notRefundableAmount;
        /// <summary>
        /// Disclosure-TX Non-Refundable Amt [DISCLOSURE.X94]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Non-Refundable Amt")]
        public decimal? NotRefundableAmount { get => _notRefundableAmount; set => _notRefundableAmount = value; }
        private DirtyValue<bool?> _offerRetailPriceIndicator;
        /// <summary>
        /// Disclosure-TX Compensated Retail Price [DISCLOSURE.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Compensated Retail Price", OptionsJson = "{\"true\":\"The retail price we offer you\"}")]
        public bool? OfferRetailPriceIndicator { get => _offerRetailPriceIndicator; set => _offerRetailPriceIndicator = value; }
        private DirtyValue<decimal?> _originalAcquisitionCost;
        /// <summary>
        /// Disclosure - AK - Original Acquisition Cost [DISCLOSURE.X973]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Original Acquisition Cost")]
        public decimal? OriginalAcquisitionCost { get => _originalAcquisitionCost; set => _originalAcquisitionCost = value; }
        private DirtyValue<decimal?> _originationFeeChargedAmount;
        /// <summary>
        /// Disclosure-NV Origination Fee Charged Amount [DISCLOSURE.X925]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NV Origination Fee Charged Amount")]
        public decimal? OriginationFeeChargedAmount { get => _originationFeeChargedAmount; set => _originationFeeChargedAmount = value; }
        private DirtyValue<bool?> _originationFeeChargedIndicator;
        /// <summary>
        /// Disclosure-NV Origination Fee Charged Indicator [DISCLOSURE.X924]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Origination Fee Charged Indicator")]
        public bool? OriginationFeeChargedIndicator { get => _originationFeeChargedIndicator; set => _originationFeeChargedIndicator = value; }
        private DirtyValue<decimal?> _originationFeeDecreasesRate;
        /// <summary>
        /// Disclosure-NV Origination Fee Decreases Interest Rate By [DISCLOSURE.X928]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-NV Origination Fee Decreases Interest Rate By")]
        public decimal? OriginationFeeDecreasesRate { get => _originationFeeDecreasesRate; set => _originationFeeDecreasesRate = value; }
        private DirtyValue<decimal?> _originationFeeIncreasesRate;
        /// <summary>
        /// Disclosure-NV Origination Fee Increases Interest Rate By [DISCLOSURE.X929]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-NV Origination Fee Increases Interest Rate By")]
        public decimal? OriginationFeeIncreasesRate { get => _originationFeeIncreasesRate; set => _originationFeeIncreasesRate = value; }
        private DirtyValue<StringEnumValue<InterestRateImpactedStatus>> _originationFeeInterestRateImpactedStatus;
        /// <summary>
        /// Disclosure-NV Identify one of three possible impacts of Origination Fee on the Interest Rate [DISCLOSURE.X927]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Identify one of three possible impacts of Origination Fee on the Interest Rate")]
        public StringEnumValue<InterestRateImpactedStatus> OriginationFeeInterestRateImpactedStatus { get => _originationFeeInterestRateImpactedStatus; set => _originationFeeInterestRateImpactedStatus = value; }
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>> _originationFeePaidBy;
        /// <summary>
        /// Disclosure-NV Origination Fee Paid By [DISCLOSURE.X926]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Origination Fee Paid By")]
        public StringEnumValue<StateDisclosureFeePaidBy> OriginationFeePaidBy { get => _originationFeePaidBy; set => _originationFeePaidBy = value; }
        private DirtyValue<decimal?> _paidByBorrower;
        /// <summary>
        /// Disclosure-NY Broker Fee Borr [DISCLOSURE.X158]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Broker Fee Borr")]
        public decimal? PaidByBorrower { get => _paidByBorrower; set => _paidByBorrower = value; }
        private DirtyValue<decimal?> _paidByLender;
        /// <summary>
        /// Disclosure-NY Broker Fee Lender Paid [DISCLOSURE.X157]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Broker Fee Lender Paid")]
        public decimal? PaidByLender { get => _paidByLender; set => _paidByLender = value; }
        private DirtyValue<decimal?> _paidByOther1;
        /// <summary>
        /// Disclosure-NY Other Fee 1 Amt [DISCLOSURE.X160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Other Fee 1 Amt")]
        public decimal? PaidByOther1 { get => _paidByOther1; set => _paidByOther1 = value; }
        private DirtyValue<decimal?> _paidByOther2;
        /// <summary>
        /// Disclosure-NY Other Fee 2 Amt [DISCLOSURE.X162]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Other Fee 2 Amt")]
        public decimal? PaidByOther2 { get => _paidByOther2; set => _paidByOther2 = value; }
        private DirtyValue<string> _paidByOtherDescription1;
        /// <summary>
        /// Disclosure-NY Other Fee 1 Descr [DISCLOSURE.X159]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Other Fee 1 Descr")]
        public string PaidByOtherDescription1 { get => _paidByOtherDescription1; set => _paidByOtherDescription1 = value; }
        private DirtyValue<string> _paidByOtherDescription2;
        /// <summary>
        /// Disclosure-NY Other Fee 2 Descr [DISCLOSURE.X161]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Other Fee 2 Descr")]
        public string PaidByOtherDescription2 { get => _paidByOtherDescription2; set => _paidByOtherDescription2 = value; }
        private DirtyValue<decimal?> _previousMortgageAmountOne;
        /// <summary>
        /// Disclosure-NY Previous Mortgage Amount 1 [DISCLOSURE.X994]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Previous Mortgage Amount 1")]
        public decimal? PreviousMortgageAmountOne { get => _previousMortgageAmountOne; set => _previousMortgageAmountOne = value; }
        private DirtyValue<decimal?> _previousMortgageAmountTwo;
        /// <summary>
        /// Disclosure-NY Previous Mortgage Amount 2 [DISCLOSURE.X995]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Previous Mortgage Amount 2")]
        public decimal? PreviousMortgageAmountTwo { get => _previousMortgageAmountTwo; set => _previousMortgageAmountTwo = value; }
        private DirtyValue<bool?> _printCertificationOfCosts;
        /// <summary>
        /// Disclosure - AK - Print Certification O fCosts [DISCLOSURE.X962]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - AK - Print Certification O fCosts", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? PrintCertificationOfCosts { get => _printCertificationOfCosts; set => _printCertificationOfCosts = value; }
        private DirtyValue<bool?> _printInterestRateReductionRider;
        /// <summary>
        /// Disclosure - AK - Print Interest Rate Reduction Rider [DISCLOSURE.X961]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - AK - Print Interest Rate Reduction Rider", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? PrintInterestRateReductionRider { get => _printInterestRateReductionRider; set => _printInterestRateReductionRider = value; }
        private DirtyValue<bool?> _printMDDeliveryIndicator;
        /// <summary>
        /// Disclosure-MD Print MD Delivery of Net Proceeds Authorization Disclosure [DISCLOSURE.X911]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-MD Print MD Delivery of Net Proceeds Authorization Disclosure")]
        public bool? PrintMDDeliveryIndicator { get => _printMDDeliveryIndicator; set => _printMDDeliveryIndicator = value; }
        private DirtyValue<StringEnumValue<ProvidedBy>> _providedBy;
        /// <summary>
        /// Disclosure-FL GFE Provided By [FLGFE.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL GFE Provided By")]
        public StringEnumValue<ProvidedBy> ProvidedBy { get => _providedBy; set => _providedBy = value; }
        private DirtyValue<string> _questionContact;
        /// <summary>
        /// Disclosure-NY Ques/Comments To [DISCLOSURE.X128]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Ques/Comments To")]
        public string QuestionContact { get => _questionContact; set => _questionContact = value; }
        private DirtyValue<string> _questionContactPhone;
        /// <summary>
        /// Disclosure-NY Ques/Comments Phone [DISCLOSURE.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure-NY Ques/Comments Phone")]
        public string QuestionContactPhone { get => _questionContactPhone; set => _questionContactPhone = value; }
        private DirtyValue<string> _questionContactTollFree;
        /// <summary>
        /// Disclosure-NY Ques/Comments Toll Free [DISCLOSURE.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure-NY Ques/Comments Toll Free")]
        public string QuestionContactTollFree { get => _questionContactTollFree; set => _questionContactTollFree = value; }
        private DirtyValue<bool?> _rateLockHonoredIndicator;
        /// <summary>
        /// Disclosure-NY-Rate Lock honored only if loan closes at least 3 business days prior to the Lock Expiration Date [DISCLOSURE.X950]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY-Rate Lock honored only if loan closes at least 3 business days prior to the Lock Expiration Date")]
        public bool? RateLockHonoredIndicator { get => _rateLockHonoredIndicator; set => _rateLockHonoredIndicator = value; }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// Disclosure-NY Fee Recipient [DISCLOSURE.X149]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Fee Recipient")]
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<decimal?> _refinancingFee;
        /// <summary>
        /// Disclosure-FL Refi Fee [FLMTGCM.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Refi Fee")]
        public decimal? RefinancingFee { get => _refinancingFee; set => _refinancingFee = value; }
        private DirtyValue<string> _refundableBy;
        /// <summary>
        /// Disclosure-FL Deposit Refundable By [FLGFE.X56]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure-FL Deposit Refundable By")]
        public string RefundableBy { get => _refundableBy; set => _refundableBy = value; }
        private DirtyValue<bool?> _refundableIndicator;
        /// <summary>
        /// Disclosure-FL Commitment Fee Refundable If [FLMTGCM.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Commitment Fee Refundable If", OptionsJson = "{\"true\":\"Refundable If\"}")]
        public bool? RefundableIndicator { get => _refundableIndicator; set => _refundableIndicator = value; }
        private DirtyValue<StringEnumValue<RefundableType>> _refundableType;
        /// <summary>
        /// Disclosure-FL Appl Fee Refund/Non Refund [DISCLOSURE.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Appl Fee Refund/Non Refund")]
        public StringEnumValue<RefundableType> RefundableType { get => _refundableType; set => _refundableType = value; }
        private DirtyValue<string> _refundCondition1;
        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 1 [DISCLOSURE.X125]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Appl Fee Refund If 1")]
        public string RefundCondition1 { get => _refundCondition1; set => _refundCondition1 = value; }
        private DirtyValue<string> _refundCondition2;
        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 2 [DISCLOSURE.X126]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Appl Fee Refund If 2")]
        public string RefundCondition2 { get => _refundCondition2; set => _refundCondition2 = value; }
        private DirtyValue<string> _refundCondition3;
        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 3 [DISCLOSURE.X164]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Appl Fee Refund If 3")]
        public string RefundCondition3 { get => _refundCondition3; set => _refundCondition3 = value; }
        private DirtyValue<string> _refundCondition4;
        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 4 [DISCLOSURE.X165]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Appl Fee Refund If 4")]
        public string RefundCondition4 { get => _refundCondition4; set => _refundCondition4 = value; }
        private DirtyValue<string> _refundCondition5;
        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 5 [DISCLOSURE.X166]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Appl Fee Refund If 5")]
        public string RefundCondition5 { get => _refundCondition5; set => _refundCondition5 = value; }
        private DirtyValue<string> _refundCondition6;
        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 6 [DISCLOSURE.X167]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Appl Fee Refund If 6")]
        public string RefundCondition6 { get => _refundCondition6; set => _refundCondition6 = value; }
        private DirtyValue<string> _regulatorAddress;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Address [DISCLOSURE.X1064]
        /// </summary>
        [LoanFieldProperty(Description = "South Carolina State Specific Disclosure -  Regulator Address")]
        public string RegulatorAddress { get => _regulatorAddress; set => _regulatorAddress = value; }
        private DirtyValue<string> _regulatorCity;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator City [DISCLOSURE.X1065]
        /// </summary>
        [LoanFieldProperty(Description = "South Carolina State Specific Disclosure -  Regulator City")]
        public string RegulatorCity { get => _regulatorCity; set => _regulatorCity = value; }
        private DirtyValue<string> _regulatorMailingAddress;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing Address [DISCLOSURE.X1070]
        /// </summary>
        [LoanFieldProperty(Description = "South Carolina State Specific Disclosure -  Regulator Mailing Address")]
        public string RegulatorMailingAddress { get => _regulatorMailingAddress; set => _regulatorMailingAddress = value; }
        private DirtyValue<string> _regulatorMailingCity;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing City [DISCLOSURE.X1071]
        /// </summary>
        [LoanFieldProperty(Description = "South Carolina State Specific Disclosure -  Regulator Mailing City")]
        public string RegulatorMailingCity { get => _regulatorMailingCity; set => _regulatorMailingCity = value; }
        private DirtyValue<StringEnumValue<State>> _regulatorMailingState;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing State [DISCLOSURE.X1072]
        /// </summary>
        [LoanFieldProperty(Description = "South Carolina State Specific Disclosure -  Regulator Mailing State")]
        public StringEnumValue<State> RegulatorMailingState { get => _regulatorMailingState; set => _regulatorMailingState = value; }
        private DirtyValue<string> _regulatorMailingZipCode;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing Zip Code [DISCLOSURE.X1073]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "South Carolina State Specific Disclosure -  Regulator Mailing Zip Code")]
        public string RegulatorMailingZipCode { get => _regulatorMailingZipCode; set => _regulatorMailingZipCode = value; }
        private DirtyValue<string> _regulatorPhone;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Phone [DISCLOSURE.X1068]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "South Carolina State Specific Disclosure -  Regulator Phone")]
        public string RegulatorPhone { get => _regulatorPhone; set => _regulatorPhone = value; }
        private DirtyValue<StringEnumValue<State>> _regulatorState;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator State [DISCLOSURE.X1066]
        /// </summary>
        [LoanFieldProperty(Description = "South Carolina State Specific Disclosure -  Regulator State")]
        public StringEnumValue<State> RegulatorState { get => _regulatorState; set => _regulatorState = value; }
        private DirtyValue<string> _regulatorTollFreePhone;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Toll-free Phone [DISCLOSURE.X1069]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "South Carolina State Specific Disclosure -  Regulator Toll-free Phone")]
        public string RegulatorTollFreePhone { get => _regulatorTollFreePhone; set => _regulatorTollFreePhone = value; }
        private DirtyValue<string> _regulatorWebAddress;
        /// <summary>
        /// South Carolina State Specific Disclosure - Regulatory Agency - Web Address [DISCLOSURE.X1156]
        /// </summary>
        [LoanFieldProperty(Description = "South Carolina State Specific Disclosure - Regulatory Agency - Web Address")]
        public string RegulatorWebAddress { get => _regulatorWebAddress; set => _regulatorWebAddress = value; }
        private DirtyValue<string> _regulatorZipCode;
        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Zip Code [DISCLOSURE.X1067]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "South Carolina State Specific Disclosure -  Regulator Zip Code")]
        public string RegulatorZipCode { get => _regulatorZipCode; set => _regulatorZipCode = value; }
        private DirtyValue<StringEnumValue<ScheduleOfChargesEstimatedFinalIndicator>> _scheduleOfChargesEstimatedFinalIndicator;
        /// <summary>
        /// Disclosure-MD The schedule of charges is Estimated, subject to change or Final, not subject to change [DISCLOSURE.X912]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-MD The schedule of charges is Estimated, subject to change or Final, not subject to change")]
        public StringEnumValue<ScheduleOfChargesEstimatedFinalIndicator> ScheduleOfChargesEstimatedFinalIndicator { get => _scheduleOfChargesEstimatedFinalIndicator; set => _scheduleOfChargesEstimatedFinalIndicator = value; }
        private DirtyValue<StringEnumValue<ScRegulatoryAgencyType>> _scRegulatoryAgencyType;
        /// <summary>
        /// Disclosure - SC - Regulatory Agency [DISCLOSURE.X953]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - SC - Regulatory Agency")]
        public StringEnumValue<ScRegulatoryAgencyType> ScRegulatoryAgencyType { get => _scRegulatoryAgencyType; set => _scRegulatoryAgencyType = value; }
        private DirtyValue<bool?> _selectDivisionFeesIndicator;
        /// <summary>
        /// Disclosure-NY Lender Division of Fees Is Selected [DISCLOSURE.X181]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Lender Division of Fees Is Selected")]
        public bool? SelectDivisionFeesIndicator { get => _selectDivisionFeesIndicator; set => _selectDivisionFeesIndicator = value; }
        private DirtyValue<bool?> _selectPrimaryLenderIndicator;
        /// <summary>
        /// Disclosure-NY Lender Primary Lender Is Selected [DISCLOSURE.X179]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Lender Primary Lender Is Selected")]
        public bool? SelectPrimaryLenderIndicator { get => _selectPrimaryLenderIndicator; set => _selectPrimaryLenderIndicator = value; }
        private DirtyValue<bool?> _selectPrivateLenderIndicator;
        /// <summary>
        /// Disclosure-NY Lender Private Lender Is Selected [DISCLOSURE.X180]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Lender Private Lender Is Selected")]
        public bool? SelectPrivateLenderIndicator { get => _selectPrivateLenderIndicator; set => _selectPrivateLenderIndicator = value; }
        private DirtyValue<decimal?> _servicingFeeChargedAmount;
        /// <summary>
        /// Disclosure-NV Servicing Fee Charged Amount [DISCLOSURE.X940]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NV Servicing Fee Charged Amount")]
        public decimal? ServicingFeeChargedAmount { get => _servicingFeeChargedAmount; set => _servicingFeeChargedAmount = value; }
        private DirtyValue<bool?> _servicingFeeChargedIndicator;
        /// <summary>
        /// Disclosure-NV Servicing Fee Indicator [DISCLOSURE.X939]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Servicing Fee Indicator")]
        public bool? ServicingFeeChargedIndicator { get => _servicingFeeChargedIndicator; set => _servicingFeeChargedIndicator = value; }
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>> _servicingFeePaidBy;
        /// <summary>
        /// Disclosure-NV Servicing Fee Paid By [DISCLOSURE.X941]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Servicing Fee Paid By")]
        public StringEnumValue<StateDisclosureFeePaidBy> ServicingFeePaidBy { get => _servicingFeePaidBy; set => _servicingFeePaidBy = value; }
        private DirtyValue<StringEnumValue<ServicingFeePaidFrequence>> _servicingFeePaidFrequence;
        /// <summary>
        /// Disclosure-NV Servicing Fee Paid Frequency [DISCLOSURE.X942]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Servicing Fee Paid Frequency")]
        public StringEnumValue<ServicingFeePaidFrequence> ServicingFeePaidFrequence { get => _servicingFeePaidFrequence; set => _servicingFeePaidFrequence = value; }
        private DirtyValue<bool?> _signedByBorrowerIndicator;
        /// <summary>
        /// Disclosure-FL GFE of settlemnt chrgs dated/signed by borrower [FLGFE.X76]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL GFE of settlemnt chrgs dated/signed by borrower")]
        public bool? SignedByBorrowerIndicator { get => _signedByBorrowerIndicator; set => _signedByBorrowerIndicator = value; }
        private DirtyValue<bool?> _specificARMIndicator;
        /// <summary>
        /// Disclosure-FL Specific ARM rates, terms, and conditions [FLGFE.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Specific ARM rates, terms, and conditions")]
        public bool? SpecificARMIndicator { get => _specificARMIndicator; set => _specificARMIndicator = value; }
        private DirtyValue<bool?> _submitToLenderIndicator;
        /// <summary>
        /// Disclosure-TX Will Submit to Lender [DISCLOSURE.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Will Submit to Lender", OptionsJson = "{\"true\":\"We will submit your loan application to a participating lender\"}")]
        public bool? SubmitToLenderIndicator { get => _submitToLenderIndicator; set => _submitToLenderIndicator = value; }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationAssessments;
        /// <summary>
        /// Disclosure - AK - Assessments [DISCLOSURE.X968]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Assessments")]
        public decimal? TaxExemptAcquisitionCostCertificationAssessments { get => _taxExemptAcquisitionCostCertificationAssessments; set => _taxExemptAcquisitionCostCertificationAssessments = value; }
        private DirtyValue<string> _taxExemptAcquisitionCostCertificationOther;
        /// <summary>
        /// Disclosure - AK - Other [DISCLOSURE.X970]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - AK - Other")]
        public string TaxExemptAcquisitionCostCertificationOther { get => _taxExemptAcquisitionCostCertificationOther; set => _taxExemptAcquisitionCostCertificationOther = value; }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationOtherAmount;
        /// <summary>
        /// Disclosure - AK - Other Amount [DISCLOSURE.X971]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Other Amount")]
        public decimal? TaxExemptAcquisitionCostCertificationOtherAmount { get => _taxExemptAcquisitionCostCertificationOtherAmount; set => _taxExemptAcquisitionCostCertificationOtherAmount = value; }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationOwnersTitleInsurance;
        /// <summary>
        /// Disclosure - AK - Owners Title Insurance [DISCLOSURE.X965]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Owners Title Insurance")]
        public decimal? TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get => _taxExemptAcquisitionCostCertificationOwnersTitleInsurance; set => _taxExemptAcquisitionCostCertificationOwnersTitleInsurance = value; }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationRealEstateCommission;
        /// <summary>
        /// Disclosure - AK - Real Estate Commission [DISCLOSURE.X967]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Real Estate Commission")]
        public decimal? TaxExemptAcquisitionCostCertificationRealEstateCommission { get => _taxExemptAcquisitionCostCertificationRealEstateCommission; set => _taxExemptAcquisitionCostCertificationRealEstateCommission = value; }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationRepairsImprovements;
        /// <summary>
        /// Disclosure - AK - Repairs/Improvements [DISCLOSURE.X969]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Repairs/Improvements")]
        public decimal? TaxExemptAcquisitionCostCertificationRepairsImprovements { get => _taxExemptAcquisitionCostCertificationRepairsImprovements; set => _taxExemptAcquisitionCostCertificationRepairsImprovements = value; }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationSurvey;
        /// <summary>
        /// Disclosure - AK - Survey [DISCLOSURE.X966]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Survey")]
        public decimal? TaxExemptAcquisitionCostCertificationSurvey { get => _taxExemptAcquisitionCostCertificationSurvey; set => _taxExemptAcquisitionCostCertificationSurvey = value; }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationTotalAdjustments;
        /// <summary>
        /// Disclosure - AK - Total Adjustments [DISCLOSURE.X972]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure - AK - Total Adjustments")]
        public decimal? TaxExemptAcquisitionCostCertificationTotalAdjustments { get => _taxExemptAcquisitionCostCertificationTotalAdjustments; set => _taxExemptAcquisitionCostCertificationTotalAdjustments = value; }
        private DirtyValue<StringEnumValue<TermsChange>> _termsChange;
        /// <summary>
        /// Disclosure-FL Terms Are/Are Not Subject to Change [FLMTGCM.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-FL Terms Are/Are Not Subject to Change")]
        public StringEnumValue<TermsChange> TermsChange { get => _termsChange; set => _termsChange = value; }
        private DirtyValue<decimal?> _texasApplicationFee;
        /// <summary>
        /// Disclosure-TX Application Fee [DISCLOSURE.X82]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Application Fee")]
        public decimal? TexasApplicationFee { get => _texasApplicationFee; set => _texasApplicationFee = value; }
        private DirtyValue<decimal?> _texasAppraisalFee;
        /// <summary>
        /// Disclosure-TX Appraisal Fee [DISCLOSURE.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Appraisal Fee")]
        public decimal? TexasAppraisalFee { get => _texasAppraisalFee; set => _texasAppraisalFee = value; }
        private DirtyValue<decimal?> _texasCreditReportFee;
        /// <summary>
        /// Disclosure-TX Credit Rpt Fee [DISCLOSURE.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Credit Rpt Fee")]
        public decimal? TexasCreditReportFee { get => _texasCreditReportFee; set => _texasCreditReportFee = value; }
        private DirtyValue<decimal?> _texasOtherFee1;
        /// <summary>
        /// Disclosure-TX Other Fee 1 [DISCLOSURE.X91]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Other Fee 1")]
        public decimal? TexasOtherFee1 { get => _texasOtherFee1; set => _texasOtherFee1 = value; }
        private DirtyValue<decimal?> _texasOtherFee2;
        /// <summary>
        /// Disclosure-TX Other Fee 2 [DISCLOSURE.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Other Fee 2")]
        public decimal? TexasOtherFee2 { get => _texasOtherFee2; set => _texasOtherFee2 = value; }
        private DirtyValue<string> _texasOtherFeeContact1;
        /// <summary>
        /// Disclosure-TX Other Fee 1 Descr [DISCLOSURE.X90]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Other Fee 1 Descr")]
        public string TexasOtherFeeContact1 { get => _texasOtherFeeContact1; set => _texasOtherFeeContact1 = value; }
        private DirtyValue<string> _texasOtherFeeContact2;
        /// <summary>
        /// Disclosure-TX Other Fee 2 Descr [DISCLOSURE.X92]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Other Fee 2 Descr")]
        public string TexasOtherFeeContact2 { get => _texasOtherFeeContact2; set => _texasOtherFeeContact2 = value; }
        private DirtyValue<decimal?> _texasProcessingFee;
        /// <summary>
        /// Disclosure-TX Processing Fee [DISCLOSURE.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Processing Fee")]
        public decimal? TexasProcessingFee { get => _texasProcessingFee; set => _texasProcessingFee = value; }
        private DirtyValue<decimal?> _thirdPartyFee;
        /// <summary>
        /// Disclosure-FL Third Party Fee Amt [FLGFE.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-FL Third Party Fee Amt")]
        public decimal? ThirdPartyFee { get => _thirdPartyFee; set => _thirdPartyFee = value; }
        private DirtyValue<decimal?> _totalFee;
        /// <summary>
        /// Disclosure-NY Total Broker Fee [DISCLOSURE.X163]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NY Total Broker Fee")]
        public decimal? TotalFee { get => _totalFee; set => _totalFee = value; }
        private DirtyValue<decimal?> _transferFeeChargedAmount;
        /// <summary>
        /// Disclosure-NV Service Rights Transfer Fee Charged Amount [DISCLOSURE.X937]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NV Service Rights Transfer Fee Charged Amount")]
        public decimal? TransferFeeChargedAmount { get => _transferFeeChargedAmount; set => _transferFeeChargedAmount = value; }
        private DirtyValue<bool?> _transferFeeChargedIndicator;
        /// <summary>
        /// Disclosure-NV Service Rights Transfer Fee Indicator [DISCLOSURE.X936]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Service Rights Transfer Fee Indicator")]
        public bool? TransferFeeChargedIndicator { get => _transferFeeChargedIndicator; set => _transferFeeChargedIndicator = value; }
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>> _transferFeePaidBy;
        /// <summary>
        /// Disclosure-NV Service Rights Transfer Fee Paid By [DISCLOSURE.X938]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Service Rights Transfer Fee Paid By")]
        public StringEnumValue<StateDisclosureFeePaidBy> TransferFeePaidBy { get => _transferFeePaidBy; set => _transferFeePaidBy = value; }
        private DirtyValue<bool?> _txVeteransLandBoardIndicator;
        /// <summary>
        /// Disclosure - TX - Texas Veterans Land Board [DISCLOSURE.X955]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure - TX - Texas Veterans Land Board", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? TxVeteransLandBoardIndicator { get => _txVeteransLandBoardIndicator; set => _txVeteransLandBoardIndicator = value; }
        private DirtyValue<StringEnumValue<TypeOfProperty>> _typeOfProperty;
        /// <summary>
        /// Disclosure-NY Type of Property [DISCLOSURE.X996]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NY Type of Property")]
        public StringEnumValue<TypeOfProperty> TypeOfProperty { get => _typeOfProperty; set => _typeOfProperty = value; }
        private DirtyValue<string> _underwritingContact;
        /// <summary>
        /// Disclosure-TX Underwriting Fee Descr [DISCLOSURE.X88]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-TX Underwriting Fee Descr")]
        public string UnderwritingContact { get => _underwritingContact; set => _underwritingContact = value; }
        private DirtyValue<decimal?> _underwritingFee;
        /// <summary>
        /// Disclosure-TX Underwriting Fee [DISCLOSURE.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-TX Underwriting Fee")]
        public decimal? UnderwritingFee { get => _underwritingFee; set => _underwritingFee = value; }
        private DirtyValue<decimal?> _ySPChargedAmount;
        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Charged Amount [DISCLOSURE.X931]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosure-NV Yield Spread Premium (YSP) Charged Amount")]
        public decimal? YSPChargedAmount { get => _ySPChargedAmount; set => _ySPChargedAmount = value; }
        private DirtyValue<bool?> _ySPChargedIndicator;
        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Indicator [DISCLOSURE.X930]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Yield Spread Premium (YSP) Indicator")]
        public bool? YSPChargedIndicator { get => _ySPChargedIndicator; set => _ySPChargedIndicator = value; }
        private DirtyValue<decimal?> _ySPDecreasesRate;
        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Decreases Interest Rate By [DISCLOSURE.X934]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-NV Yield Spread Premium (YSP) Decreases Interest Rate By")]
        public decimal? YSPDecreasesRate { get => _ySPDecreasesRate; set => _ySPDecreasesRate = value; }
        private DirtyValue<decimal?> _ySPIncreasesRate;
        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Increases Interest Rate By [DISCLOSURE.X935]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure-NV Yield Spread Premium (YSP) Increases Interest Rate By")]
        public decimal? YSPIncreasesRate { get => _ySPIncreasesRate; set => _ySPIncreasesRate = value; }
        private DirtyValue<StringEnumValue<InterestRateImpactedStatus>> _ySPInterestRateImpactedStatus;
        /// <summary>
        /// Disclosure-NV Identify one of three possible impacts of Yield Spread Premium (YSP) on the Interest Rate [DISCLOSURE.X933]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Identify one of three possible impacts of Yield Spread Premium (YSP) on the Interest Rate")]
        public StringEnumValue<InterestRateImpactedStatus> YSPInterestRateImpactedStatus { get => _ySPInterestRateImpactedStatus; set => _ySPInterestRateImpactedStatus = value; }
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>> _ySPPaidBy;
        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP)  Paid By [DISCLOSURE.X932]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure-NV Yield Spread Premium (YSP)  Paid By")]
        public StringEnumValue<StateDisclosureFeePaidBy> YSPPaidBy { get => _ySPPaidBy; set => _ySPPaidBy = value; }
    }
}