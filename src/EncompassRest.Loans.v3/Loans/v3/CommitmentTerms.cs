using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CommitmentTerms
/// </summary>
public sealed partial class CommitmentTerms : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HUD Action Date [1038]
    /// </summary>
    public DateTime? ActionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD See Conditions on Reverse [1190]
    /// </summary>
    public string? AdditionalConditions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Conditions See Attached 1 [966]
    /// </summary>
    public string? AdditionalItems1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Conditions See Attached 2 [1081]
    /// </summary>
    public string? AdditionalItems2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Conditions See Attached 3 [1189]
    /// </summary>
    public string? AdditionalItems3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Commit Terms See Below [1365]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"See Below  (Appraisal done)\"}")]
    public bool? AppraisalDone { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Assurance of Completion $ [649]
    /// </summary>
    public decimal? AssuranceOfCompletion { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Loan Commitment Date [3094]
    /// </summary>
    public DateTime? CommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Commit Expires [1072]
    /// </summary>
    public DateTime? CommitmentExpired { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Commit Issued Date [1068]
    /// </summary>
    public DateTime? CommitmentIssued { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Conditional Commit Under Act [1141]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Conditional Commitment under Act\"}")]
    public bool? ConditionalCommitmentUnderActg { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Conditions Elig High Loan to Value Ratio [1342]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Eligible for high loan to value ratio\"}")]
    public bool? EligibleForHighLtv { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Remaining Economic Life [1142]
    /// </summary>
    public int? EstimatedRemainingYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Improved Living Area [1082]
    /// </summary>
    public string? ImprovedLivingAreas { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Manufactured Housing [603]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Manufactured Housing\"}")]
    public bool? ManufacturedHousing { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Mtg Ins Maximum [1080]
    /// </summary>
    public decimal? MaxInsurableMortgage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Commitment Mortgagee Addr [3343]
    /// </summary>
    public string? MortgageeAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Commitment Mortgagee City [3344]
    /// </summary>
    public string? MortgageeCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Commitment Mortgagee Name [3342]
    /// </summary>
    public string? MortgageeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Commitment Mortgagee Zip [3346]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? MortgageePostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Commitment Mortgagee State [3345]
    /// </summary>
    public string? MortgageeState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Expenses Oth Mo Expense Descr [1071]
    /// </summary>
    public string? OtherMonthlyExpenseDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Report Date [1078]
    /// </summary>
    public DateTime? ReportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Comply w/ Requirements # [1077]
    /// </summary>
    public string? RequirementsNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Subdivision Descr [1079]
    /// </summary>
    public string? SubdivisionDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Subdivision Requirements [1076]
    /// </summary>
    public string? SubdivisionRequirements { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Expenses Total Mo Expenses Est [1075]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyExpense { get => GetValue<decimal?>(); set => SetValue(value); }
}