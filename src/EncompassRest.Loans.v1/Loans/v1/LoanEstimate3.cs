using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanEstimate3
/// </summary>
public sealed partial class LoanEstimate3 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Loan Estimate - Appraisal [LE3.X11]
    /// </summary>
    public StringEnumValue<Appraisal> Appraisal { get => GetValue<StringEnumValue<Appraisal>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Assumption [LE3.X12]
    /// </summary>
    public StringEnumValue<Assumption> Assumption { get => GetValue<StringEnumValue<Assumption>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Construction Loan [LE3.X15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Settlement will occur more than 60 days after initial disclosure.\"}")]
    public bool? ConstructionLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Homeowner Insurance [LE3.X13]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Omit from print\"}")]
    public bool? HomeownerInsurance { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimate3 Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - In 5 years Principal you will have paid off [LE3.X18]
    /// </summary>
    public int? In5YearsPrincipalYouWillHavePaidOff { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - In 5 years Total you will have paid [LE3.X17]
    /// </summary>
    public int? In5YearsTotalYouWillHavePaid { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender Email [LE3.X2]
    /// </summary>
    public string? LenderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender License ID [LE3.X1]
    /// </summary>
    public string? LenderLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender License State [LE3.X20]
    /// </summary>
    public StringEnumValue<State> LenderLicenseState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender Loan Officer [LE3.X4]
    /// </summary>
    public string? LenderLoanOfficer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender Loan Officer License State [LE3.X21]
    /// </summary>
    public StringEnumValue<State> LenderLoanOfficerLicenseState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender Loan Officer NMLS ID [LE3.X5]
    /// </summary>
    public string? LenderLoanOfficerNMLSId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender Phone [LE3.X3]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Email [LE3.X7]
    /// </summary>
    public string? MortgageBrokerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker License ID [LE3.X6]
    /// </summary>
    public string? MortgageBrokerLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker License State [LE3.X22]
    /// </summary>
    public StringEnumValue<State> MortgageBrokerLicenseState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer [LE3.X9]
    /// </summary>
    public string? MortgageBrokerLoanOfficer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer License ID [LE3.X25]
    /// </summary>
    public string? MortgageBrokerLoanOfficerLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer License State [LE3.X23]
    /// </summary>
    public StringEnumValue<State> MortgageBrokerLoanOfficerLicenseState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer NMLS ID [LE3.X10]
    /// </summary>
    public string? MortgageBrokerLoanOfficerNMLSId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Phone [LE3.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? MortgageBrokerPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Mortgage Lender Loan Officer License ID [LE3.X24]
    /// </summary>
    public string? MortgageLenderLoanOfficerLicenseID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Servicing [LE3.X14]
    /// </summary>
    public StringEnumValue<Servicing> Servicing { get => GetValue<StringEnumValue<Servicing>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Signature Type [LE3.X19]
    /// </summary>
    public StringEnumValue<SignatureType> SignatureType { get => GetValue<StringEnumValue<SignatureType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Total Interest Percentage [LE3.X16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalInterestPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Total Interest Percentage - Display fields with KBYO rounding rules [KBYO.LE3XD16]
    /// </summary>
    public string? TotalInterestPercentageUI { get => GetValue<string?>(); set => SetValue(value); }
}