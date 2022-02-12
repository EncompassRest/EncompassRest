using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// InterestAccrualType
/// </summary>
public enum InterestAccrualType
{
    /// <summary>
    /// Average Daily Interest Accrual
    /// </summary>
    [Description("Average Daily Interest Accrual")]
    AverageDailyInterestAccrual = 0,
    /// <summary>
    /// Daily Interest Accrual
    /// </summary>
    [Description("Daily Interest Accrual")]
    DailyInterestAccrual = 1
}