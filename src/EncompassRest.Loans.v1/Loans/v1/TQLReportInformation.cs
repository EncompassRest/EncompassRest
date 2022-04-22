using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// TQLReportInformation
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TQLReportInformation : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TQL - Borrower 4506T Orders - ID [TQL4506TNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 1 [TQL4506TNN21]
    /// </summary>
    public string? BorrowerID1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 2 [TQL4506TNN31]
    /// </summary>
    public string? BorrowerID2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 3 [TQL4506TNN41]
    /// </summary>
    public string? BorrowerID3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Borrower ID 4 [TQL4506TNN51]
    /// </summary>
    public string? BorrowerID4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Completed Date [TQL4506TNN03]
    /// </summary>
    public DateTime? CompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQLReportInformation Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Investor [TQL4506TNN06]
    /// </summary>
    public string? Investor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Order Date [TQL4506TNN02]
    /// </summary>
    public DateTime? OrderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Order number [TQL4506TNN05]
    /// </summary>
    public string? OrderNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Status [TQL4506TNN04]
    /// </summary>
    public string? OrderStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 1 [TQL4506TNN23]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 2 [TQL4506TNN33]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 3 [TQL4506TNN43]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Percent Variance 4 [TQL4506TNN53]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentVariance4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Products Ordered [TQL4506TNN07]
    /// </summary>
    public string? ProductsOrdered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 1 [TQL4506TNN20]
    /// </summary>
    public string? ReportYear1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 2 [TQL4506TNN30]
    /// </summary>
    public string? ReportYear2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 3 [TQL4506TNN40]
    /// </summary>
    public string? ReportYear3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Report Year 4 [TQL4506TNN50]
    /// </summary>
    public string? ReportYear4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 1 [TQL4506TNN22]
    /// </summary>
    public decimal? TotalIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 2 [TQL4506TNN32]
    /// </summary>
    public decimal? TotalIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 3 [TQL4506TNN42]
    /// </summary>
    public decimal? TotalIncome3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Total Income 4 [TQL4506TNN52]
    /// </summary>
    public decimal? TotalIncome4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Transcript Type [TQL4506TNN08]
    /// </summary>
    public string? TranscriptType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - User ID [TQL4506TNN01]
    /// </summary>
    public string? UserID { get => GetValue<string?>(); set => SetValue(value); }
}