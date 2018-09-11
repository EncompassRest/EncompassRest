using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure2
    /// </summary>
    public sealed partial class ClosingDisclosure2 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _borrowerClosingCostAtClosing;
        /// <summary>
        /// Closing disclosure - Borrower Paid Closing Cost At Closing [CD2.XBCCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Borrower Paid Closing Cost At Closing")]
        public decimal? BorrowerClosingCostAtClosing { get => _borrowerClosingCostAtClosing; set => SetField(ref _borrowerClosingCostAtClosing, value); }
        private DirtyValue<decimal?> _borrowerClosingCostBeforeClosing;
        /// <summary>
        /// Closing disclosure - Borrower Paid Closing Cost Before Closing [CD2.XBCCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Borrower Paid Closing Cost Before Closing")]
        public decimal? BorrowerClosingCostBeforeClosing { get => _borrowerClosingCostBeforeClosing; set => SetField(ref _borrowerClosingCostBeforeClosing, value); }
        private DirtyValue<decimal?> _closingCostLenderCredits;
        /// <summary>
        /// Lender Credits [CD2.XSTLC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lender Credits")]
        public decimal? ClosingCostLenderCredits { get => _closingCostLenderCredits; set => SetField(ref _closingCostLenderCredits, value); }
        private DirtyValue<decimal?> _closingCostPaidByOthers;
        /// <summary>
        /// Closing disclosure - Closing Cost Paid by Others [CD2.XCCBO]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Closing Cost Paid by Others")]
        public decimal? ClosingCostPaidByOthers { get => _closingCostPaidByOthers; set => SetField(ref _closingCostPaidByOthers, value); }
        private DirtyValue<decimal?> _discloseLenderCredits;
        /// <summary>
        /// Disclose Lender Credits applied [CD2.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclose Lender Credits applied")]
        public decimal? DiscloseLenderCredits { get => _discloseLenderCredits; set => SetField(ref _discloseLenderCredits, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDisclosure2 Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _initialEscrowSubTotal;
        /// <summary>
        /// Closing disclosure - G. Initial Escrow Payment at Closing [CD2.XSTG]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - G. Initial Escrow Payment at Closing")]
        public decimal? InitialEscrowSubTotal { get => _initialEscrowSubTotal; set => SetField(ref _initialEscrowSubTotal, value); }
        private DirtyValue<decimal?> _lastDisclosedLenderCredits;
        /// <summary>
        /// CD Last Disclosed Lender Credits [CD2.XLDLCR]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD Last Disclosed Lender Credits")]
        public decimal? LastDisclosedLenderCredits { get => _lastDisclosedLenderCredits; set => SetField(ref _lastDisclosedLenderCredits, value); }
        private DirtyValue<decimal?> _lastDisclosedLoanCosts;
        /// <summary>
        /// CD Last Disclosed Loan Costs [CD2.XLDLC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD Last Disclosed Loan Costs")]
        public decimal? LastDisclosedLoanCosts { get => _lastDisclosedLoanCosts; set => SetField(ref _lastDisclosedLoanCosts, value); }
        private DirtyValue<decimal?> _lastDisclosedOtherCosts;
        /// <summary>
        /// CD Last Disclosed Other Costs [CD2.XLDOC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD Last Disclosed Other Costs")]
        public decimal? LastDisclosedOtherCosts { get => _lastDisclosedOtherCosts; set => SetField(ref _lastDisclosedOtherCosts, value); }
        private DirtyValue<decimal?> _lCAtClosing;
        /// <summary>
        /// Closing disclosure Lender Credits At closing [CD2.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure Lender Credits At closing")]
        public decimal? LCAtClosing { get => _lCAtClosing; set => SetField(ref _lCAtClosing, value); }
        private DirtyValue<decimal?> _originationChargesSubTotal;
        /// <summary>
        /// Closing disclosure - A. Origination Charges [CD2.XSTA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - A. Origination Charges")]
        public decimal? OriginationChargesSubTotal { get => _originationChargesSubTotal; set => SetField(ref _originationChargesSubTotal, value); }
        private DirtyValue<decimal?> _otherSubTotal;
        /// <summary>
        /// Closing disclosure - H. Other [CD2.XSTH]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - H. Other")]
        public decimal? OtherSubTotal { get => _otherSubTotal; set => SetField(ref _otherSubTotal, value); }
        private DirtyValue<decimal?> _prepaidsSubTotal;
        /// <summary>
        /// Closing disclosure - F. Prepaids [CD2.XSTF]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - F. Prepaids")]
        public decimal? PrepaidsSubTotal { get => _prepaidsSubTotal; set => SetField(ref _prepaidsSubTotal, value); }
        private DirtyValue<decimal?> _sellerClosingCostAtClosing;
        /// <summary>
        /// Closing disclosure - Seller Paid Closing Cost At Closing [CD2.XSCCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Seller Paid Closing Cost At Closing")]
        public decimal? SellerClosingCostAtClosing { get => _sellerClosingCostAtClosing; set => SetField(ref _sellerClosingCostAtClosing, value); }
        private DirtyValue<decimal?> _sellerClosingCostBeforeClosing;
        /// <summary>
        /// Closing disclosure - Seller Paid Closing Cost Before Closing [CD2.XSCCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Seller Paid Closing Cost Before Closing")]
        public decimal? SellerClosingCostBeforeClosing { get => _sellerClosingCostBeforeClosing; set => SetField(ref _sellerClosingCostBeforeClosing, value); }
        private DirtyValue<decimal?> _servicesDidNotShopSubTotal;
        /// <summary>
        /// Closing disclosure - B. Services Borrower Did Not Shop For [CD2.XSTB]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - B. Services Borrower Did Not Shop For")]
        public decimal? ServicesDidNotShopSubTotal { get => _servicesDidNotShopSubTotal; set => SetField(ref _servicesDidNotShopSubTotal, value); }
        private DirtyValue<decimal?> _servicesDidShopSubTotal;
        /// <summary>
        /// Closing disclosure - C. Services Borrower Did Shop For [CD2.XSTC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - C. Services Borrower Did Shop For")]
        public decimal? ServicesDidShopSubTotal { get => _servicesDidShopSubTotal; set => SetField(ref _servicesDidShopSubTotal, value); }
        private DirtyValue<decimal?> _taxesGovermentFeesSubTotal;
        /// <summary>
        /// Closing disclosure - E.Taxes and Other Government Fees [CD2.XSTE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - E.Taxes and Other Government Fees")]
        public decimal? TaxesGovermentFeesSubTotal { get => _taxesGovermentFeesSubTotal; set => SetField(ref _taxesGovermentFeesSubTotal, value); }
        private DirtyValue<decimal?> _totalBorrowerPaidAtClosing;
        /// <summary>
        /// Closing disclosure - Total Borrower Paid At Closing [CD2.XLCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Borrower Paid At Closing")]
        public decimal? TotalBorrowerPaidAtClosing { get => _totalBorrowerPaidAtClosing; set => SetField(ref _totalBorrowerPaidAtClosing, value); }
        private DirtyValue<decimal?> _totalBorrowerPaidBeforeClosing;
        /// <summary>
        /// Closing disclosure - Total Borrower Paid Before Closing [CD2.XLCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Borrower Paid Before Closing")]
        public decimal? TotalBorrowerPaidBeforeClosing { get => _totalBorrowerPaidBeforeClosing; set => SetField(ref _totalBorrowerPaidBeforeClosing, value); }
        private DirtyValue<decimal?> _totalClosingCost;
        /// <summary>
        /// Closing disclosure - J. Total Closing Costs (BORROWER Paid) [CD2.XSTJ]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - J. Total Closing Costs (BORROWER Paid)")]
        public decimal? TotalClosingCost { get => _totalClosingCost; set => SetField(ref _totalClosingCost, value); }
        private DirtyValue<decimal?> _totalLoanCost;
        /// <summary>
        /// Loan Costs [CD2.XSTD]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Costs")]
        public decimal? TotalLoanCost { get => _totalLoanCost; set => SetField(ref _totalLoanCost, value); }
        private DirtyValue<decimal?> _totalOtherCost;
        /// <summary>
        /// Other Costs [CD2.XSTI]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Other Costs")]
        public decimal? TotalOtherCost { get => _totalOtherCost; set => SetField(ref _totalOtherCost, value); }
        private DirtyValue<decimal?> _totalOtherCostAtClosing;
        /// <summary>
        /// Closing disclosure - Total Other Cost At Closing [CD2.XOCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Other Cost At Closing")]
        public decimal? TotalOtherCostAtClosing { get => _totalOtherCostAtClosing; set => SetField(ref _totalOtherCostAtClosing, value); }
        private DirtyValue<decimal?> _totalOtherCostBeforeClosing;
        /// <summary>
        /// Closing disclosure - Total Other Costs Before Closing [CD2.XOCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Total Other Costs Before Closing")]
        public decimal? TotalOtherCostBeforeClosing { get => _totalOtherCostBeforeClosing; set => SetField(ref _totalOtherCostBeforeClosing, value); }
    }
}