using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FederalAgency
/// </summary>
public enum FederalAgency
{
    /// <summary>
    /// 1. Office of the Comptroller of the Currency (OCC)
    /// </summary>
    [Description("1. Office of the Comptroller of the Currency (OCC)")]
    OCC = 0,
    /// <summary>
    /// 2. Federal Reserve System (FRS)
    /// </summary>
    [Description("2. Federal Reserve System (FRS)")]
    FRS = 1,
    /// <summary>
    /// 3. Federal Deposit Insurance Corporation (FDIC)
    /// </summary>
    [Description("3. Federal Deposit Insurance Corporation (FDIC)")]
    FDIC = 2,
    /// <summary>
    /// 5. National Credit Union Administration (NCUA)
    /// </summary>
    [Description("5. National Credit Union Administration (NCUA)")]
    NCUA = 3,
    /// <summary>
    /// 7. United States Department of Housing and Urban Development (HUD)
    /// </summary>
    [Description("7. United States Department of Housing and Urban Development (HUD)")]
    HUD = 4,
    /// <summary>
    /// 9. Consumer Financial Protection Bureau (CFPB)
    /// </summary>
    [Description("9. Consumer Financial Protection Bureau (CFPB)")]
    CFPB = 5
}