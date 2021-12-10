using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RegulationZPayment
/// </summary>
public sealed partial class RegulationZPayment : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _balance;
    private DirtyValue<decimal?>? _interestRatePercent;
    private DirtyValue<decimal?>? _monthlyPayment;
    private DirtyValue<int?>? _numberOfPayments;
    private DirtyValue<DateTime?>? _paymentDate;
    private DirtyValue<int?>? _regulationZPaymentIndex;

    /// <summary>
    /// RegulationZPaymentContract Balance
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Balance { get => _balance; set => SetField(ref _balance, value); }

    /// <summary>
    /// RegulationZPaymentContract InterestRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InterestRatePercent { get => _interestRatePercent; set => SetField(ref _interestRatePercent, value); }

    /// <summary>
    /// RegulationZPaymentContract MonthlyPayment
    /// </summary>
    public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

    /// <summary>
    /// RegulationZPaymentContract NumberOfPayments
    /// </summary>
    public int? NumberOfPayments { get => _numberOfPayments; set => SetField(ref _numberOfPayments, value); }

    /// <summary>
    /// RegulationZPaymentContract PaymentDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PaymentDate { get => _paymentDate; set => SetField(ref _paymentDate, value); }

    /// <summary>
    /// RegulationZPaymentContract RegulationZPaymentIndex
    /// </summary>
    public int? RegulationZPaymentIndex { get => _regulationZPaymentIndex; set => SetField(ref _regulationZPaymentIndex, value); }
}