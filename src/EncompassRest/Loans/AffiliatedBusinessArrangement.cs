using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AffiliatedBusinessArrangement
    /// </summary>
    public sealed partial class AffiliatedBusinessArrangement : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _affiliatedBusinessArrangementIndex;
        /// <summary>
        /// AffiliatedBusinessArrangement AffiliatedBusinessArrangementIndex
        /// </summary>
        public int? AffiliatedBusinessArrangementIndex { get => _affiliatedBusinessArrangementIndex; set => _affiliatedBusinessArrangementIndex = value; }
        private DirtyValue<string> _affiliateName;
        /// <summary>
        /// Affiliated Business Arrangements - Affiliate Name [ABNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Affiliate Name")]
        public string AffiliateName { get => _affiliateName; set => _affiliateName = value; }
        private DirtyValue<string> _chargeRangeChargesDescription1;
        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 1 [ABNN16]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Charge or Range of Charges Line 1")]
        public string ChargeRangeChargesDescription1 { get => _chargeRangeChargesDescription1; set => _chargeRangeChargesDescription1 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription2;
        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 2 [ABNN17]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Charge or Range of Charges Line 2")]
        public string ChargeRangeChargesDescription2 { get => _chargeRangeChargesDescription2; set => _chargeRangeChargesDescription2 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription3;
        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 3 [ABNN18]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Charge or Range of Charges Line 3")]
        public string ChargeRangeChargesDescription3 { get => _chargeRangeChargesDescription3; set => _chargeRangeChargesDescription3 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription4;
        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 4 [ABNN19]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Charge or Range of Charges Line 4")]
        public string ChargeRangeChargesDescription4 { get => _chargeRangeChargesDescription4; set => _chargeRangeChargesDescription4 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription5;
        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 5 [ABNN20]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Charge or Range of Charges Line 5")]
        public string ChargeRangeChargesDescription5 { get => _chargeRangeChargesDescription5; set => _chargeRangeChargesDescription5 = value; }
        private DirtyValue<string> _chargeRangeChargesDescription6;
        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 6 [ABNN21]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Charge or Range of Charges Line 6")]
        public string ChargeRangeChargesDescription6 { get => _chargeRangeChargesDescription6; set => _chargeRangeChargesDescription6 = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// AffiliatedBusinessArrangement Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lenderAddress;
        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address [ABNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Lender's Address")]
        public string LenderAddress { get => _lenderAddress; set => _lenderAddress = value; }
        private DirtyValue<string> _lenderAddressCity;
        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address City [ABNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Lender's Address City")]
        public string LenderAddressCity { get => _lenderAddressCity; set => _lenderAddressCity = value; }
        private DirtyValue<StringEnumValue<State>> _lenderAddressState;
        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address State [ABNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Lender's Address State")]
        public StringEnumValue<State> LenderAddressState { get => _lenderAddressState; set => _lenderAddressState = value; }
        private DirtyValue<string> _lenderAddressZipcode;
        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address Zipcode [ABNN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Affiliated Business Arrangements - Lender's Address Zipcode")]
        public string LenderAddressZipcode { get => _lenderAddressZipcode; set => _lenderAddressZipcode = value; }
        private DirtyValue<string> _lenderName;
        /// <summary>
        /// Affiliated Business Arrangements - Lender Name [ABNN01]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Lender Name")]
        public string LenderName { get => _lenderName; set => _lenderName = value; }
        private DirtyValue<string> _natureOfRelationship;
        /// <summary>
        /// Affiliated Business Arrangements - Nature of Relationship [ABNN07]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Nature of Relationship")]
        public string NatureOfRelationship { get => _natureOfRelationship; set => _natureOfRelationship = value; }
        private DirtyValue<decimal?> _percentOwnershipInterest;
        /// <summary>
        /// Affiliated Business Arrangements - Percentage of Ownership Interest [ABNN28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Affiliated Business Arrangements - Percentage of Ownership Interest")]
        public decimal? PercentOwnershipInterest { get => _percentOwnershipInterest; set => _percentOwnershipInterest = value; }
        private DirtyValue<bool?> _purchaseSaleRefinanceIndicator;
        /// <summary>
        /// Affiliated Business Arrangements - Purchase/Sale/Refinance Indicator [ABNN09]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Purchase/Sale/Refinance Indicator")]
        public bool? PurchaseSaleRefinanceIndicator { get => _purchaseSaleRefinanceIndicator; set => _purchaseSaleRefinanceIndicator = value; }
        private DirtyValue<bool?> _requiredUseIndicator1;
        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 1 [ABNN22]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Required Use Indicator Line 1")]
        public bool? RequiredUseIndicator1 { get => _requiredUseIndicator1; set => _requiredUseIndicator1 = value; }
        private DirtyValue<bool?> _requiredUseIndicator2;
        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 2 [ABNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Required Use Indicator Line 2")]
        public bool? RequiredUseIndicator2 { get => _requiredUseIndicator2; set => _requiredUseIndicator2 = value; }
        private DirtyValue<bool?> _requiredUseIndicator3;
        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 3 [ABNN24]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Required Use Indicator Line 3")]
        public bool? RequiredUseIndicator3 { get => _requiredUseIndicator3; set => _requiredUseIndicator3 = value; }
        private DirtyValue<bool?> _requiredUseIndicator4;
        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 4 [ABNN25]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Required Use Indicator Line 4")]
        public bool? RequiredUseIndicator4 { get => _requiredUseIndicator4; set => _requiredUseIndicator4 = value; }
        private DirtyValue<bool?> _requiredUseIndicator5;
        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 5 [ABNN26]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Required Use Indicator Line 5")]
        public bool? RequiredUseIndicator5 { get => _requiredUseIndicator5; set => _requiredUseIndicator5 = value; }
        private DirtyValue<bool?> _requiredUseIndicator6;
        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 6 [ABNN27]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Required Use Indicator Line 6")]
        public bool? RequiredUseIndicator6 { get => _requiredUseIndicator6; set => _requiredUseIndicator6 = value; }
        private DirtyValue<string> _serviceDescription1;
        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 1 [ABNN10]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Service Description Line 1")]
        public string ServiceDescription1 { get => _serviceDescription1; set => _serviceDescription1 = value; }
        private DirtyValue<string> _serviceDescription2;
        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 2 [ABNN11]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Service Description Line 2")]
        public string ServiceDescription2 { get => _serviceDescription2; set => _serviceDescription2 = value; }
        private DirtyValue<string> _serviceDescription3;
        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 3 [ABNN12]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Service Description Line 3")]
        public string ServiceDescription3 { get => _serviceDescription3; set => _serviceDescription3 = value; }
        private DirtyValue<string> _serviceDescription4;
        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 4 [ABNN13]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Service Description Line 4")]
        public string ServiceDescription4 { get => _serviceDescription4; set => _serviceDescription4 = value; }
        private DirtyValue<string> _serviceDescription5;
        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 5 [ABNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Service Description Line 5")]
        public string ServiceDescription5 { get => _serviceDescription5; set => _serviceDescription5 = value; }
        private DirtyValue<string> _serviceDescription6;
        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 6 [ABNN15]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Service Description Line 6")]
        public string ServiceDescription6 { get => _serviceDescription6; set => _serviceDescription6 = value; }
        private DirtyValue<bool?> _settlementIndicator;
        /// <summary>
        /// Affiliated Business Arrangements - Settlement Indicator [ABNN08]
        /// </summary>
        [LoanFieldProperty(Description = "Affiliated Business Arrangements - Settlement Indicator")]
        public bool? SettlementIndicator { get => _settlementIndicator; set => _settlementIndicator = value; }
    }
}