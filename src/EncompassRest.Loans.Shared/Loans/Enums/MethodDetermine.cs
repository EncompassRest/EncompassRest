using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// MethodDetermine
/// </summary>
public enum MethodDetermine
{
    /// <summary>
    /// The basis/index/method which will be used to determine the rate at closing is
    /// </summary>
    [Description("The basis/index/method which will be used to determine the rate at closing is")]
    DetermineAtClosing = 0,
    /// <summary>
    /// The interest rate will be the rate established by the lender in its
    /// </summary>
    [Description("The interest rate will be the rate established by the lender in its")]
    EstablishedByLender = 1
}