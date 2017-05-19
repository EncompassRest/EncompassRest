using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ClosingDisclosure2
    {
        public decimal? LCAtClosing { get; set; }
        public decimal? OriginationChargesSubTotal { get; set; }
        public decimal? ServicesDidNotShopSubTotal { get; set; }
        public decimal? ServicesDidShopSubTotal { get; set; }
        public decimal? TotalLoanCost { get; set; }
        public decimal? LastDisclosedLoanCosts { get; set; }
        public decimal? TotalBorrowerPaidAtClosing { get; set; }
        public decimal? TotalBorrowerPaidBeforeClosing { get; set; }
        public decimal? TaxesGovermentFeesSubTotal { get; set; }
        public decimal? PrepaidsSubTotal { get; set; }
        public decimal? InitialEscrowSubTotal { get; set; }
        public decimal? OtherSubTotal { get; set; }
        public decimal? TotalOtherCost { get; set; }
        public decimal? LastDisclosedOtherCosts { get; set; }
        public decimal? TotalOtherCostAtClosing { get; set; }
        public decimal? TotalOtherCostBeforeClosing { get; set; }
        public decimal? TotalClosingCost { get; set; }
        public decimal? BorrowerClosingCostAtClosing { get; set; }
        public decimal? BorrowerClosingCostBeforeClosing { get; set; }
        public decimal? SellerClosingCostAtClosing { get; set; }
        public decimal? SellerClosingCostBeforeClosing { get; set; }
        public decimal? ClosingCostPaidByOthers { get; set; }
        public decimal? ClosingCostLenderCredits { get; set; }
        public decimal? LastDisclosedLenderCredits { get; set; }
        public string Id { get; set; }
    }
}