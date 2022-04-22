using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlReport
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlReport : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TQL - Borrower 4506T Orders - ID [TQL4506T0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 1 [TQL4506T0021]
    /// </summary>
    public string? BorrowerId1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 2 [TQL4506T0031]
    /// </summary>
    public string? BorrowerId2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 3 [TQL4506T0041]
    /// </summary>
    public string? BorrowerId3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 4 [TQL4506T0051]
    /// </summary>
    public string? BorrowerId4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Completed Date [TQL4506T0003]
    /// </summary>
    public DateTime? CompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TqlReport Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Investor [TQL4506T0006]
    /// </summary>
    public string? Investor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Order Date [TQL4506T0002]
    /// </summary>
    public DateTime? OrderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Order number [TQL4506T0005]
    /// </summary>
    public string? OrderNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Status [TQL4506T0004]
    /// </summary>
    public string? OrderStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 1 [TQL4506T0023]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 2 [TQL4506T0033]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 3 [TQL4506T0043]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 4 [TQL4506T0053]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Products Ordered [TQL4506T0007]
    /// </summary>
    public string? ProductsOrdered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 1 [TQL4506T0020]
    /// </summary>
    public string? ReportYear1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 2 [TQL4506T0030]
    /// </summary>
    public string? ReportYear2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 3 [TQL4506T0040]
    /// </summary>
    public string? ReportYear3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 4 [TQL4506T0050]
    /// </summary>
    public string? ReportYear4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 1 [TQL4506T0022]
    /// </summary>
    public decimal? TotalIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 2 [TQL4506T0032]
    /// </summary>
    public decimal? TotalIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 3 [TQL4506T0042]
    /// </summary>
    public decimal? TotalIncome3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 4 [TQL4506T0052]
    /// </summary>
    public decimal? TotalIncome4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Transcript Type [TQL4506T0008]
    /// </summary>
    public string? TranscriptType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - User ID [TQL4506T0001]
    /// </summary>
    public string? UserId { get => GetValue<string?>(); set => SetValue(value); }
}