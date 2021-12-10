using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Funding
/// </summary>
public sealed partial class Funding : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _collateralSentDate;
    private DirtyValue<string?>? _funderName;
    private DirtyValue<string?>? _funderUrl;
    private DirtyValue<string?>? _fundingClearedBy;
    private DirtyValue<DateTime?>? _fundingCloseDate;
    private DirtyValue<string?>? _fundingFees;
    private DirtyValue<DateTime?>? _fundingOrderDate;
    private DirtyValue<string?>? _fundingType;
    private DirtyValue<DateTime?>? _fundsReleasedDate;
    private DirtyValue<string?>? _fundsReleaseNumber;
    private DirtyValue<DateTime?>? _fundsSentDate;
    private DirtyValue<string?>? _fundsWireTo;
    private DirtyValue<DateTime?>? _sentToFunderDate;
    private DirtyValue<decimal?>? _wireAmount;
    private DirtyValue<string?>? _wiredToAbaNumber;
    private DirtyValue<string?>? _wiredToAccountNumber;
    private DirtyValue<string?>? _wiredToForCreditTo;
    private DirtyValue<string?>? _wiredToForCreditTo1;
    private DirtyValue<string?>? _wiredToForCreditTo2;
    private DirtyValue<string?>? _wiredToForFurtherCreditTo1;
    private DirtyValue<string?>? _wiredToForFurtherCreditTo2;

    /// <summary>
    /// Funding Collateral Sent Date [1998]
    /// </summary>
    public DateTime? CollateralSentDate { get => _collateralSentDate; set => SetField(ref _collateralSentDate, value); }

    /// <summary>
    /// Funding Funder Name [1991]
    /// </summary>
    public string? FunderName { get => _funderName; set => SetField(ref _funderName, value); }

    /// <summary>
    /// Funding Funder URL [2011]
    /// </summary>
    public string? FunderUrl { get => _funderUrl; set => SetField(ref _funderUrl, value); }

    /// <summary>
    /// Funding Cleared By [1995]
    /// </summary>
    public string? FundingClearedBy { get => _fundingClearedBy; set => SetField(ref _fundingClearedBy, value); }

    /// <summary>
    /// Funding Close Date [1994]
    /// </summary>
    public DateTime? FundingCloseDate { get => _fundingCloseDate; set => SetField(ref _fundingCloseDate, value); }

    /// <summary>
    /// Funding Worksheet - Funding Fees [FUNDINGFEES]
    /// </summary>
    public string? FundingFees { get => _fundingFees; set => SetField(ref _fundingFees, value); }

    /// <summary>
    /// Funding Funds Ordered Date [1996]
    /// </summary>
    public DateTime? FundingOrderDate { get => _fundingOrderDate; set => SetField(ref _fundingOrderDate, value); }

    /// <summary>
    /// Funding Type [1993]
    /// </summary>
    public string? FundingType { get => _fundingType; set => SetField(ref _fundingType, value); }

    /// <summary>
    /// Funding Funds Released [1999]
    /// </summary>
    public DateTime? FundsReleasedDate { get => _fundsReleasedDate; set => SetField(ref _fundsReleasedDate, value); }

    /// <summary>
    /// Funding Funds Release Number [2000]
    /// </summary>
    public string? FundsReleaseNumber { get => _fundsReleaseNumber; set => SetField(ref _fundsReleaseNumber, value); }

    /// <summary>
    /// Funding Funds Sent Date [1997]
    /// </summary>
    public DateTime? FundsSentDate { get => _fundsSentDate; set => SetField(ref _fundsSentDate, value); }

    /// <summary>
    /// Funding Wired To [2001]
    /// </summary>
    public string? FundsWireTo { get => _fundsWireTo; set => SetField(ref _fundsWireTo, value); }

    /// <summary>
    /// Funding Sent to Funder Date [1992]
    /// </summary>
    public DateTime? SentToFunderDate { get => _sentToFunderDate; set => SetField(ref _sentToFunderDate, value); }

    /// <summary>
    /// WareHouse Lender Wire Amount(From Warehouse Lender to Lender/Closing Agent) [4660]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? WireAmount { get => _wireAmount; set => SetField(ref _wireAmount, value); }

    /// <summary>
    /// Funding Wired To ABA Number [2008]
    /// </summary>
    public string? WiredToAbaNumber { get => _wiredToAbaNumber; set => SetField(ref _wiredToAbaNumber, value); }

    /// <summary>
    /// Funding Wired To Account Number [2009]
    /// </summary>
    public string? WiredToAccountNumber { get => _wiredToAccountNumber; set => SetField(ref _wiredToAccountNumber, value); }

    /// <summary>
    /// Funding Wired To For Credit To [2010]
    /// </summary>
    public string? WiredToForCreditTo { get => _wiredToForCreditTo; set => SetField(ref _wiredToForCreditTo, value); }

    /// <summary>
    /// Funding Wired To 1 - For Credit To [2004]
    /// </summary>
    public string? WiredToForCreditTo1 { get => _wiredToForCreditTo1; set => SetField(ref _wiredToForCreditTo1, value); }

    /// <summary>
    /// Funding Wired To 2 - For Credit To [2007]
    /// </summary>
    public string? WiredToForCreditTo2 { get => _wiredToForCreditTo2; set => SetField(ref _wiredToForCreditTo2, value); }

    /// <summary>
    /// Funding Wired To 1 - For Further Credit To [2002]
    /// </summary>
    public string? WiredToForFurtherCreditTo1 { get => _wiredToForFurtherCreditTo1; set => SetField(ref _wiredToForFurtherCreditTo1, value); }

    /// <summary>
    /// Funding Wired To 2 - For Further Credit To [2003]
    /// </summary>
    public string? WiredToForFurtherCreditTo2 { get => _wiredToForFurtherCreditTo2; set => SetField(ref _wiredToForFurtherCreditTo2, value); }
}