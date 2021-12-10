using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlReport
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlReport : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _borrowerId1;
    private DirtyValue<string?>? _borrowerId2;
    private DirtyValue<string?>? _borrowerId3;
    private DirtyValue<string?>? _borrowerId4;
    private DirtyValue<DateTime?>? _completedDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _investor;
    private DirtyValue<DateTime?>? _orderDate;
    private DirtyValue<string?>? _orderNumber;
    private DirtyValue<string?>? _orderStatus;
    private DirtyValue<decimal?>? _percentVariance1;
    private DirtyValue<decimal?>? _percentVariance2;
    private DirtyValue<decimal?>? _percentVariance3;
    private DirtyValue<decimal?>? _percentVariance4;
    private DirtyValue<string?>? _productsOrdered;
    private DirtyValue<string?>? _reportYear1;
    private DirtyValue<string?>? _reportYear2;
    private DirtyValue<string?>? _reportYear3;
    private DirtyValue<string?>? _reportYear4;
    private DirtyValue<decimal?>? _totalIncome1;
    private DirtyValue<decimal?>? _totalIncome2;
    private DirtyValue<decimal?>? _totalIncome3;
    private DirtyValue<decimal?>? _totalIncome4;
    private DirtyValue<string?>? _transcriptType;
    private DirtyValue<string?>? _userId;

    /// <summary>
    /// TQL - Borrower 4506T Orders - ID [TQL4506T0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 1 [TQL4506T0021]
    /// </summary>
    public string? BorrowerId1 { get => _borrowerId1; set => SetField(ref _borrowerId1, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 2 [TQL4506T0031]
    /// </summary>
    public string? BorrowerId2 { get => _borrowerId2; set => SetField(ref _borrowerId2, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 3 [TQL4506T0041]
    /// </summary>
    public string? BorrowerId3 { get => _borrowerId3; set => SetField(ref _borrowerId3, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 4 [TQL4506T0051]
    /// </summary>
    public string? BorrowerId4 { get => _borrowerId4; set => SetField(ref _borrowerId4, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Completed Date [TQL4506T0003]
    /// </summary>
    public DateTime? CompletedDate { get => _completedDate; set => SetField(ref _completedDate, value); }

    /// <summary>
    /// TqlReportContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Investor [TQL4506T0006]
    /// </summary>
    public string? Investor { get => _investor; set => SetField(ref _investor, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Order Date [TQL4506T0002]
    /// </summary>
    public DateTime? OrderDate { get => _orderDate; set => SetField(ref _orderDate, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Order number [TQL4506T0005]
    /// </summary>
    public string? OrderNumber { get => _orderNumber; set => SetField(ref _orderNumber, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Status [TQL4506T0004]
    /// </summary>
    public string? OrderStatus { get => _orderStatus; set => SetField(ref _orderStatus, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 1 [TQL4506T0023]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance1 { get => _percentVariance1; set => SetField(ref _percentVariance1, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 2 [TQL4506T0033]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance2 { get => _percentVariance2; set => SetField(ref _percentVariance2, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 3 [TQL4506T0043]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance3 { get => _percentVariance3; set => SetField(ref _percentVariance3, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 4 [TQL4506T0053]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance4 { get => _percentVariance4; set => SetField(ref _percentVariance4, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Products Ordered [TQL4506T0007]
    /// </summary>
    public string? ProductsOrdered { get => _productsOrdered; set => SetField(ref _productsOrdered, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 1 [TQL4506T0020]
    /// </summary>
    public string? ReportYear1 { get => _reportYear1; set => SetField(ref _reportYear1, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 2 [TQL4506T0030]
    /// </summary>
    public string? ReportYear2 { get => _reportYear2; set => SetField(ref _reportYear2, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 3 [TQL4506T0040]
    /// </summary>
    public string? ReportYear3 { get => _reportYear3; set => SetField(ref _reportYear3, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 4 [TQL4506T0050]
    /// </summary>
    public string? ReportYear4 { get => _reportYear4; set => SetField(ref _reportYear4, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 1 [TQL4506T0022]
    /// </summary>
    public decimal? TotalIncome1 { get => _totalIncome1; set => SetField(ref _totalIncome1, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 2 [TQL4506T0032]
    /// </summary>
    public decimal? TotalIncome2 { get => _totalIncome2; set => SetField(ref _totalIncome2, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 3 [TQL4506T0042]
    /// </summary>
    public decimal? TotalIncome3 { get => _totalIncome3; set => SetField(ref _totalIncome3, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 4 [TQL4506T0052]
    /// </summary>
    public decimal? TotalIncome4 { get => _totalIncome4; set => SetField(ref _totalIncome4, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Transcript Type [TQL4506T0008]
    /// </summary>
    public string? TranscriptType { get => _transcriptType; set => SetField(ref _transcriptType, value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - User ID [TQL4506T0001]
    /// </summary>
    public string? UserId { get => _userId; set => SetField(ref _userId, value); }
}