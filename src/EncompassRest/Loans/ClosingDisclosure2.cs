using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure2
    /// </summary>
    public sealed partial class ClosingDisclosure2 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _borrowerClosingCostAtClosing;
        /// <summary>
        /// Closing disclosure - Borrower Paid Closing Cost At Closing [CD2.XBCCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Borrower Paid Closing Cost At Closing")]
        public decimal? BorrowerClosingCostAtClosing { get => _borrowerClosingCostAtClosing; set => _borrowerClosingCostAtClosing = value; }
        private DirtyValue<decimal?> _borrowerClosingCostBeforeClosing;
        /// <summary>
        /// Closing disclosure - Borrower Paid Closing Cost Before Closing [CD2.XBCCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Borrower Paid Closing Cost Before Closing")]
        public decimal? BorrowerClosingCostBeforeClosing { get => _borrowerClosingCostBeforeClosing; set => _borrowerClosingCostBeforeClosing = value; }
        private DirtyValue<decimal?> _closingCostLenderCredits;
        /// <summary>
        /// Lender Credits [CD2.XSTLC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lender Credits")]
        public decimal? ClosingCostLenderCredits { get => _closingCostLenderCredits; set => _closingCostLenderCredits = value; }
        private DirtyValue<decimal?> _closingCostPaidByOthers;
        /// <summary>
        /// Closing disclosure - Closing Cost Paid by Others [CD2.XCCBO]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Closing Cost Paid by Others")]
        public decimal? ClosingCostPaidByOthers { get => _closingCostPaidByOthers; set => _closingCostPaidByOthers = value; }
        private DirtyValue<decimal?> _discloseLenderCredits;
        /// <summary>
        /// Disclose Lender Credits applied [CD2.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclose Lender Credits applied")]
        public decimal? DiscloseLenderCredits { get => _discloseLenderCredits; set => _discloseLenderCredits = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDisclosure2 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _initialEscrowSubTotal;
        /// <summary>
        /// Closing disclosure - G. Initial Escrow Payment at Closing [CD2.XSTG]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - G. Initial Escrow Payment at Closing")]
        public decimal? InitialEscrowSubTotal { get => _initialEscrowSubTotal; set => _initialEscrowSubTotal = value; }
        private DirtyValue<decimal?> _lastDisclosedLenderCredits;
        /// <summary>
        /// CD Last Disclosed Lender Credits [CD2.XLDLCR]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD Last Disclosed Lender Credits")]
        public decimal? LastDisclosedLenderCredits { get => _lastDisclosedLenderCredits; set => _lastDisclosedLenderCredits = value; }
        private DirtyValue<decimal?> _lastDisclosedLoanCosts;
        /// <summary>
        /// CD Last Disclosed Loan Costs [CD2.XLDLC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD Last Disclosed Loan Costs")]
        public decimal? LastDisclosedLoanCosts { get => _lastDisclosedLoanCosts; set => _lastDisclosedLoanCosts = value; }
        private DirtyValue<decimal?> _lastDisclosedOtherCosts;
        /// <summary>
        /// CD Last Disclosed Other Costs [CD2.XLDOC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD Last Disclosed Other Costs")]
        public decimal? LastDisclosedOtherCosts { get => _lastDisclosedOtherCosts; set => _lastDisclosedOtherCosts = value; }
        private DirtyValue<decimal?> _lCAtClosing;
        /// <summary>
        /// Closing disclosure Lender Credits At closing [CD2.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure Lender Credits At closing")]
        public decimal? LCAtClosing { get => _lCAtClosing; set => _lCAtClosing = value; }
        private DirtyValue<decimal?> _originationChargesSubTotal;
        /// <summary>
        /// Closing disclosure - A. Origination Charges [CD2.XSTA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - A. Origination Charges")]
        public decimal? OriginationChargesSubTotal { get => _originationChargesSubTotal; set => _originationChargesSubTotal = value; }
        private DirtyValue<decimal?> _otherSubTotal;
        /// <summary>
        /// Closing disclosure - H. Other [CD2.XSTH]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - H. Other")]
        public decimal? OtherSubTotal { get => _otherSubTotal; set => _otherSubTotal = value; }
        private DirtyValue<decimal?> _prepaidsSubTotal;
        /// <summary>
        /// Closing disclosure - F. Prepaids [CD2.XSTF]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - F. Prepaids")]
        public decimal? PrepaidsSubTotal { get => _prepaidsSubTotal; set => _prepaidsSubTotal = value; }
        private DirtyValue<decimal?> _sellerClosingCostAtClosing;
        /// <summary>
        /// Closing disclosure - Seller Paid Closing Cost At Closing [CD2.XSCCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Seller Paid Closing Cost At Closing")]
        public decimal? SellerClosingCostAtClosing { get => _sellerClosingCostAtClosing; set => _sellerClosingCostAtClosing = value; }
        private DirtyValue<decimal?> _sellerClosingCostBeforeClosing;
        /// <summary>
        /// Closing disclosure - Seller Paid Closing Cost Before Closing [CD2.XSCCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Seller Paid Closing Cost Before Closing")]
        public decimal? SellerClosingCostBeforeClosing { get => _sellerClosingCostBeforeClosing; set => _sellerClosingCostBeforeClosing = value; }
        private DirtyValue<decimal?> _servicesDidNotShopSubTotal;
        /// <summary>
        /// Closing disclosure - B. Services Borrower Did Not Shop For [CD2.XSTB]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - B. Services Borrower Did Not Shop For")]
        public decimal? ServicesDidNotShopSubTotal { get => _servicesDidNotShopSubTotal; set => _servicesDidNotShopSubTotal = value; }
        private DirtyValue<decimal?> _servicesDidShopSubTotal;
        /// <summary>
        /// Closing disclosure - C. Services Borrower Did Shop For [CD2.XSTC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - C. Services Borrower Did Shop For")]
        public decimal? ServicesDidShopSubTotal { get => _servicesDidShopSubTotal; set => _servicesDidShopSubTotal = value; }
        private DirtyValue<decimal?> _taxesGovermentFeesSubTotal;
        /// <summary>
        /// Closing disclosure - E.Taxes and Other Government Fees [CD2.XSTE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - E.Taxes and Other Government Fees")]
        public decimal? TaxesGovermentFeesSubTotal { get => _taxesGovermentFeesSubTotal; set => _taxesGovermentFeesSubTotal = value; }
        private DirtyValue<decimal?> _totalBorrowerPaidAtClosing;
        /// <summary>
        /// Closing disclosure - Total Borrower Paid At Closing [CD2.XLCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Borrower Paid At Closing")]
        public decimal? TotalBorrowerPaidAtClosing { get => _totalBorrowerPaidAtClosing; set => _totalBorrowerPaidAtClosing = value; }
        private DirtyValue<decimal?> _totalBorrowerPaidBeforeClosing;
        /// <summary>
        /// Closing disclosure - Total Borrower Paid Before Closing [CD2.XLCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Borrower Paid Before Closing")]
        public decimal? TotalBorrowerPaidBeforeClosing { get => _totalBorrowerPaidBeforeClosing; set => _totalBorrowerPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _totalClosingCost;
        /// <summary>
        /// Closing disclosure - J. Total Closing Costs (BORROWER Paid) [CD2.XSTJ]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - J. Total Closing Costs (BORROWER Paid)")]
        public decimal? TotalClosingCost { get => _totalClosingCost; set => _totalClosingCost = value; }
        private DirtyValue<decimal?> _totalLoanCost;
        /// <summary>
        /// Loan Costs [CD2.XSTD]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Costs")]
        public decimal? TotalLoanCost { get => _totalLoanCost; set => _totalLoanCost = value; }
        private DirtyValue<decimal?> _totalOtherCost;
        /// <summary>
        /// Other Costs [CD2.XSTI]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Other Costs")]
        public decimal? TotalOtherCost { get => _totalOtherCost; set => _totalOtherCost = value; }
        private DirtyValue<decimal?> _totalOtherCostAtClosing;
        /// <summary>
        /// Closing disclosure - Total Other Cost At Closing [CD2.XOCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Other Cost At Closing")]
        public decimal? TotalOtherCostAtClosing { get => _totalOtherCostAtClosing; set => _totalOtherCostAtClosing = value; }
        private DirtyValue<decimal?> _totalOtherCostBeforeClosing;
        /// <summary>
        /// Closing disclosure - Total Other Costs Before Closing [CD2.XOCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Other Costs Before Closing")]
        public decimal? TotalOtherCostBeforeClosing { get => _totalOtherCostBeforeClosing; set => _totalOtherCostBeforeClosing = value; }
        internal override bool DirtyInternal
        {
            get => _borrowerClosingCostAtClosing.Dirty
                || _borrowerClosingCostBeforeClosing.Dirty
                || _closingCostLenderCredits.Dirty
                || _closingCostPaidByOthers.Dirty
                || _discloseLenderCredits.Dirty
                || _id.Dirty
                || _initialEscrowSubTotal.Dirty
                || _lastDisclosedLenderCredits.Dirty
                || _lastDisclosedLoanCosts.Dirty
                || _lastDisclosedOtherCosts.Dirty
                || _lCAtClosing.Dirty
                || _originationChargesSubTotal.Dirty
                || _otherSubTotal.Dirty
                || _prepaidsSubTotal.Dirty
                || _sellerClosingCostAtClosing.Dirty
                || _sellerClosingCostBeforeClosing.Dirty
                || _servicesDidNotShopSubTotal.Dirty
                || _servicesDidShopSubTotal.Dirty
                || _taxesGovermentFeesSubTotal.Dirty
                || _totalBorrowerPaidAtClosing.Dirty
                || _totalBorrowerPaidBeforeClosing.Dirty
                || _totalClosingCost.Dirty
                || _totalLoanCost.Dirty
                || _totalOtherCost.Dirty
                || _totalOtherCostAtClosing.Dirty
                || _totalOtherCostBeforeClosing.Dirty;
            set
            {
                _borrowerClosingCostAtClosing.Dirty = value;
                _borrowerClosingCostBeforeClosing.Dirty = value;
                _closingCostLenderCredits.Dirty = value;
                _closingCostPaidByOthers.Dirty = value;
                _discloseLenderCredits.Dirty = value;
                _id.Dirty = value;
                _initialEscrowSubTotal.Dirty = value;
                _lastDisclosedLenderCredits.Dirty = value;
                _lastDisclosedLoanCosts.Dirty = value;
                _lastDisclosedOtherCosts.Dirty = value;
                _lCAtClosing.Dirty = value;
                _originationChargesSubTotal.Dirty = value;
                _otherSubTotal.Dirty = value;
                _prepaidsSubTotal.Dirty = value;
                _sellerClosingCostAtClosing.Dirty = value;
                _sellerClosingCostBeforeClosing.Dirty = value;
                _servicesDidNotShopSubTotal.Dirty = value;
                _servicesDidShopSubTotal.Dirty = value;
                _taxesGovermentFeesSubTotal.Dirty = value;
                _totalBorrowerPaidAtClosing.Dirty = value;
                _totalBorrowerPaidBeforeClosing.Dirty = value;
                _totalClosingCost.Dirty = value;
                _totalLoanCost.Dirty = value;
                _totalOtherCost.Dirty = value;
                _totalOtherCostAtClosing.Dirty = value;
                _totalOtherCostBeforeClosing.Dirty = value;
            }
        }
    }
}