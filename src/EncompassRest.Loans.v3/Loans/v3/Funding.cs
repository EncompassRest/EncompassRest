using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Funding
/// </summary>
public sealed partial class Funding : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Funding Collateral Sent Date [1998]
    /// </summary>
    public DateTime? CollateralSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Funder Name [1991]
    /// </summary>
    public string? FunderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Funder URL [2011]
    /// </summary>
    public string? FunderUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Cleared By [1995]
    /// </summary>
    public string? FundingClearedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Close Date [1994]
    /// </summary>
    public DateTime? FundingCloseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Worksheet - Funding Fees [FUNDINGFEES]
    /// </summary>
    public string? FundingFees { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Funds Ordered Date [1996]
    /// </summary>
    public DateTime? FundingOrderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Type [1993]
    /// </summary>
    public string? FundingType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Funds Released [1999]
    /// </summary>
    public DateTime? FundsReleasedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Funds Release Number [2000]
    /// </summary>
    public string? FundsReleaseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Funds Sent Date [1997]
    /// </summary>
    public DateTime? FundsSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To [2001]
    /// </summary>
    public string? FundsWireTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Sent to Funder Date [1992]
    /// </summary>
    public DateTime? SentToFunderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// WareHouse Lender Wire Amount(From Warehouse Lender to Lender/Closing Agent) [4660]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? WireAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To ABA Number [2008]
    /// </summary>
    public string? WiredToAbaNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To Account Number [2009]
    /// </summary>
    public string? WiredToAccountNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To For Credit To [2010]
    /// </summary>
    public string? WiredToForCreditTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To 1 - For Credit To [2004]
    /// </summary>
    public string? WiredToForCreditTo1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To 2 - For Credit To [2007]
    /// </summary>
    public string? WiredToForCreditTo2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To 1 - For Further Credit To [2002]
    /// </summary>
    public string? WiredToForFurtherCreditTo1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Wired To 2 - For Further Credit To [2003]
    /// </summary>
    public string? WiredToForFurtherCreditTo2 { get => GetValue<string?>(); set => SetValue(value); }
}