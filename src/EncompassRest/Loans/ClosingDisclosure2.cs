using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure2
    {
        public JsonNullable<decimal?> BorrowerClosingCostAtClosing { get; set; }
        public JsonNullable<decimal?> BorrowerClosingCostBeforeClosing { get; set; }
        public JsonNullable<decimal?> ClosingCostLenderCredits { get; set; }
        public JsonNullable<decimal?> ClosingCostPaidByOthers { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> InitialEscrowSubTotal { get; set; }
        public JsonNullable<decimal?> LastDisclosedLenderCredits { get; set; }
        public JsonNullable<decimal?> LastDisclosedLoanCosts { get; set; }
        public JsonNullable<decimal?> LastDisclosedOtherCosts { get; set; }
        public JsonNullable<decimal?> LCAtClosing { get; set; }
        public JsonNullable<decimal?> OriginationChargesSubTotal { get; set; }
        public JsonNullable<decimal?> OtherSubTotal { get; set; }
        public JsonNullable<decimal?> PrepaidsSubTotal { get; set; }
        public JsonNullable<decimal?> SellerClosingCostAtClosing { get; set; }
        public JsonNullable<decimal?> SellerClosingCostBeforeClosing { get; set; }
        public JsonNullable<decimal?> ServicesDidNotShopSubTotal { get; set; }
        public JsonNullable<decimal?> ServicesDidShopSubTotal { get; set; }
        public JsonNullable<decimal?> TaxesGovermentFeesSubTotal { get; set; }
        public JsonNullable<decimal?> TotalBorrowerPaidAtClosing { get; set; }
        public JsonNullable<decimal?> TotalBorrowerPaidBeforeClosing { get; set; }
        public JsonNullable<decimal?> TotalClosingCost { get; set; }
        public JsonNullable<decimal?> TotalLoanCost { get; set; }
        public JsonNullable<decimal?> TotalOtherCost { get; set; }
        public JsonNullable<decimal?> TotalOtherCostAtClosing { get; set; }
        public JsonNullable<decimal?> TotalOtherCostBeforeClosing { get; set; }
    }
}