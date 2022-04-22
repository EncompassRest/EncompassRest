namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDisclosure2
/// </summary>
public sealed partial class ClosingDisclosure2 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Closing disclosure - Borrower Paid Closing Cost At Closing [CD2.XBCCAC]
    /// </summary>
    public decimal? BorrowerClosingCostAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Borrower Paid Closing Cost Before Closing [CD2.XBCCBC]
    /// </summary>
    public decimal? BorrowerClosingCostBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Credits [CD2.XSTLC]
    /// </summary>
    public decimal? ClosingCostLenderCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Closing Cost Paid by Others [CD2.XCCBO]
    /// </summary>
    public decimal? ClosingCostPaidByOthers { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclose Lender Credits applied [CD2.X2]
    /// </summary>
    public decimal? DiscloseLenderCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - G. Initial Escrow Payment at Closing [CD2.XSTG]
    /// </summary>
    public decimal? InitialEscrowSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Last Disclosed Lender Credits [CD2.XLDLCR]
    /// </summary>
    public decimal? LastDisclosedLenderCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Last Disclosed Loan Costs [CD2.XLDLC]
    /// </summary>
    public decimal? LastDisclosedLoanCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Last Disclosed Other Costs [CD2.XLDOC]
    /// </summary>
    public decimal? LastDisclosedOtherCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure Lender Credits At closing [CD2.X1]
    /// </summary>
    public decimal? LcAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - A. Origination Charges [CD2.XSTA]
    /// </summary>
    public decimal? OriginationChargesSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - H. Other [CD2.XSTH]
    /// </summary>
    public decimal? OtherSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - F. Prepaids [CD2.XSTF]
    /// </summary>
    public decimal? PrepaidsSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Seller Paid Closing Cost At Closing [CD2.XSCCAC]
    /// </summary>
    public decimal? SellerClosingCostAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Seller Paid Closing Cost Before Closing [CD2.XSCCBC]
    /// </summary>
    public decimal? SellerClosingCostBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - B. Services Borrower Did Not Shop For [CD2.XSTB]
    /// </summary>
    public decimal? ServicesDidNotShopSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - C. Services Borrower Did Shop For [CD2.XSTC]
    /// </summary>
    public decimal? ServicesDidShopSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - E.Taxes and Other Government Fees [CD2.XSTE]
    /// </summary>
    public decimal? TaxesGovermentFeesSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Total Borrower Paid At Closing [CD2.XLCAC]
    /// </summary>
    public decimal? TotalBorrowerPaidAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Total Borrower Paid Before Closing [CD2.XLCBC]
    /// </summary>
    public decimal? TotalBorrowerPaidBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - J. Total Closing Costs (BORROWER Paid) [CD2.XSTJ]
    /// </summary>
    public decimal? TotalClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Costs [CD2.XSTD]
    /// </summary>
    public decimal? TotalLoanCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Other Costs [CD2.XSTI]
    /// </summary>
    public decimal? TotalOtherCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Total Other Cost At Closing [CD2.XOCAC]
    /// </summary>
    public decimal? TotalOtherCostAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Total Other Costs Before Closing [CD2.XOCBC]
    /// </summary>
    public decimal? TotalOtherCostBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }
}