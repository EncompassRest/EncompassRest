using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanSubmission
/// </summary>
public sealed partial class LoanSubmission : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Trans Details Amt Available [199]
    /// </summary>
    public decimal? AmountAvailable { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amt Required To Close [743]
    /// </summary>
    public decimal? AmountRequiredToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Buydown Descr [1297]
    /// </summary>
    public string? BuydownDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Buydown Mos [1275]
    /// </summary>
    public string? BuydownMonthsPerAdjustment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Comments/Special Instr [472]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last Rate Set Date [3253]
    /// </summary>
    public DateTime? CurrentRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Impounds Flood [LOANSUB.X13]
    /// </summary>
    public bool? FloodIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Impounds Hazard [LOANSUB.X11]
    /// </summary>
    public bool? HazardIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Secondary Registration [3941]
    /// </summary>
    public bool? IsSecondaryRegistration { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Date Last Pymt Recd [LOANSUB.X16]
    /// </summary>
    public DateTime? LastPaymentReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanSubmission LoanSubmissionFees
    /// </summary>
    [AllowNull]
    public IList<LoanSubmissionFee> LoanSubmissionFees { get => GetList<LoanSubmissionFee>(); set => SetList(value); }

    /// <summary>
    /// Trans Details Lock Date [761]
    /// </summary>
    public DateTime? LockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Lock Date Modification Timestamp [3200]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LockDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Rate Lock Expires [762]
    /// </summary>
    public DateTime? LockExpiresDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Impounds MMI/PMI [LOANSUB.X12]
    /// </summary>
    public bool? MmmPmiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Rate Lock # Days [432]
    /// </summary>
    public int? NumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Impounds Other Descr [LOANSUB.X15]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Impounds Other [LOANSUB.X14]
    /// </summary>
    public bool? OtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Product Code [1130]
    /// </summary>
    public string? ProgramCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Rate Lock Type [431]
    /// </summary>
    public string? RateLock { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Disclosure Date [3259]
    /// </summary>
    public DateTime? RateLockDisclosureDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Reduced Documents [246]
    /// </summary>
    public bool? ReducedDocsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Impounds Taxes [LOANSUB.X10]
    /// </summary>
    public bool? TaxesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Payable Items (Broker/Lender) [435]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Payable Items Discount Fee [331]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDiscountPointCharged { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Payable Items Broker [434]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForDueBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Payable Items Lender [433]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForDueLender { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Total Primary Housing Exp Plus Co-mort [1299]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForPrimaryResidence { get => GetValue<decimal?>(); set => SetValue(value); }
}