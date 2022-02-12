using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanEstimate3
/// </summary>
public sealed partial class LoanEstimate3 : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<Appraisal>>? _appraisal;
    private DirtyValue<StringEnumValue<Assumption>>? _assumption;
    private DirtyValue<bool?>? _constructionLoan;
    private DirtyValue<bool?>? _homeownerInsurance;
    private DirtyValue<string?>? _id;
    private DirtyValue<int?>? _in5YearsPrincipalYouWillHavePaidOff;
    private DirtyValue<int?>? _in5YearsTotalYouWillHavePaid;
    private DirtyValue<string?>? _lenderEmail;
    private DirtyValue<string?>? _lenderLicenseID;
    private DirtyValue<StringEnumValue<State>>? _lenderLicenseState;
    private DirtyValue<string?>? _lenderLoanOfficer;
    private DirtyValue<StringEnumValue<State>>? _lenderLoanOfficerLicenseState;
    private DirtyValue<string?>? _lenderLoanOfficerNMLSId;
    private DirtyValue<string?>? _lenderPhone;
    private DirtyValue<string?>? _mortgageBrokerEmail;
    private DirtyValue<string?>? _mortgageBrokerLicenseID;
    private DirtyValue<StringEnumValue<State>>? _mortgageBrokerLicenseState;
    private DirtyValue<string?>? _mortgageBrokerLoanOfficer;
    private DirtyValue<string?>? _mortgageBrokerLoanOfficerLicenseID;
    private DirtyValue<StringEnumValue<State>>? _mortgageBrokerLoanOfficerLicenseState;
    private DirtyValue<string?>? _mortgageBrokerLoanOfficerNMLSId;
    private DirtyValue<string?>? _mortgageBrokerPhone;
    private DirtyValue<string?>? _mortgageLenderLoanOfficerLicenseID;
    private DirtyValue<StringEnumValue<Servicing>>? _servicing;
    private DirtyValue<StringEnumValue<SignatureType>>? _signatureType;
    private DirtyValue<decimal?>? _totalInterestPercentage;
    private DirtyValue<string?>? _totalInterestPercentageUI;

    /// <summary>
    /// Loan Estimate - Appraisal [LE3.X11]
    /// </summary>
    public StringEnumValue<Appraisal> Appraisal { get => _appraisal; set => SetField(ref _appraisal, value); }

    /// <summary>
    /// Loan Estimate - Assumption [LE3.X12]
    /// </summary>
    public StringEnumValue<Assumption> Assumption { get => _assumption; set => SetField(ref _assumption, value); }

    /// <summary>
    /// Loan Estimate - Construction Loan [LE3.X15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Settlement will occur more than 60 days after initial disclosure.\"}")]
    public bool? ConstructionLoan { get => _constructionLoan; set => SetField(ref _constructionLoan, value); }

    /// <summary>
    /// Loan Estimate - Homeowner Insurance [LE3.X13]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Omit from print\"}")]
    public bool? HomeownerInsurance { get => _homeownerInsurance; set => SetField(ref _homeownerInsurance, value); }

    /// <summary>
    /// LoanEstimate3 Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Loan Estimate - In 5 years Principal you will have paid off [LE3.X18]
    /// </summary>
    public int? In5YearsPrincipalYouWillHavePaidOff { get => _in5YearsPrincipalYouWillHavePaidOff; set => SetField(ref _in5YearsPrincipalYouWillHavePaidOff, value); }

    /// <summary>
    /// Loan Estimate - In 5 years Total you will have paid [LE3.X17]
    /// </summary>
    public int? In5YearsTotalYouWillHavePaid { get => _in5YearsTotalYouWillHavePaid; set => SetField(ref _in5YearsTotalYouWillHavePaid, value); }

    /// <summary>
    /// Loan Estimate - Lender Email [LE3.X2]
    /// </summary>
    public string? LenderEmail { get => _lenderEmail; set => SetField(ref _lenderEmail, value); }

    /// <summary>
    /// Loan Estimate - Lender License ID [LE3.X1]
    /// </summary>
    public string? LenderLicenseID { get => _lenderLicenseID; set => SetField(ref _lenderLicenseID, value); }

    /// <summary>
    /// Loan Estimate - Lender License State [LE3.X20]
    /// </summary>
    public StringEnumValue<State> LenderLicenseState { get => _lenderLicenseState; set => SetField(ref _lenderLicenseState, value); }

    /// <summary>
    /// Loan Estimate - Lender Loan Officer [LE3.X4]
    /// </summary>
    public string? LenderLoanOfficer { get => _lenderLoanOfficer; set => SetField(ref _lenderLoanOfficer, value); }

    /// <summary>
    /// Loan Estimate - Lender Loan Officer License State [LE3.X21]
    /// </summary>
    public StringEnumValue<State> LenderLoanOfficerLicenseState { get => _lenderLoanOfficerLicenseState; set => SetField(ref _lenderLoanOfficerLicenseState, value); }

    /// <summary>
    /// Loan Estimate - Lender Loan Officer NMLS ID [LE3.X5]
    /// </summary>
    public string? LenderLoanOfficerNMLSId { get => _lenderLoanOfficerNMLSId; set => SetField(ref _lenderLoanOfficerNMLSId, value); }

    /// <summary>
    /// Loan Estimate - Lender Phone [LE3.X3]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderPhone { get => _lenderPhone; set => SetField(ref _lenderPhone, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Email [LE3.X7]
    /// </summary>
    public string? MortgageBrokerEmail { get => _mortgageBrokerEmail; set => SetField(ref _mortgageBrokerEmail, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker License ID [LE3.X6]
    /// </summary>
    public string? MortgageBrokerLicenseID { get => _mortgageBrokerLicenseID; set => SetField(ref _mortgageBrokerLicenseID, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker License State [LE3.X22]
    /// </summary>
    public StringEnumValue<State> MortgageBrokerLicenseState { get => _mortgageBrokerLicenseState; set => SetField(ref _mortgageBrokerLicenseState, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer [LE3.X9]
    /// </summary>
    public string? MortgageBrokerLoanOfficer { get => _mortgageBrokerLoanOfficer; set => SetField(ref _mortgageBrokerLoanOfficer, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer License ID [LE3.X25]
    /// </summary>
    public string? MortgageBrokerLoanOfficerLicenseID { get => _mortgageBrokerLoanOfficerLicenseID; set => SetField(ref _mortgageBrokerLoanOfficerLicenseID, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer License State [LE3.X23]
    /// </summary>
    public StringEnumValue<State> MortgageBrokerLoanOfficerLicenseState { get => _mortgageBrokerLoanOfficerLicenseState; set => SetField(ref _mortgageBrokerLoanOfficerLicenseState, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Loan Officer NMLS ID [LE3.X10]
    /// </summary>
    public string? MortgageBrokerLoanOfficerNMLSId { get => _mortgageBrokerLoanOfficerNMLSId; set => SetField(ref _mortgageBrokerLoanOfficerNMLSId, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Broker Phone [LE3.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? MortgageBrokerPhone { get => _mortgageBrokerPhone; set => SetField(ref _mortgageBrokerPhone, value); }

    /// <summary>
    /// Loan Estimate - Mortgage Lender Loan Officer License ID [LE3.X24]
    /// </summary>
    public string? MortgageLenderLoanOfficerLicenseID { get => _mortgageLenderLoanOfficerLicenseID; set => SetField(ref _mortgageLenderLoanOfficerLicenseID, value); }

    /// <summary>
    /// Loan Estimate - Servicing [LE3.X14]
    /// </summary>
    public StringEnumValue<Servicing> Servicing { get => _servicing; set => SetField(ref _servicing, value); }

    /// <summary>
    /// Loan Estimate - Signature Type [LE3.X19]
    /// </summary>
    public StringEnumValue<SignatureType> SignatureType { get => _signatureType; set => SetField(ref _signatureType, value); }

    /// <summary>
    /// Loan Estimate - Total Interest Percentage [LE3.X16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalInterestPercentage { get => _totalInterestPercentage; set => SetField(ref _totalInterestPercentage, value); }

    /// <summary>
    /// Loan Estimate - Total Interest Percentage - Display fields with KBYO rounding rules [KBYO.LE3XD16]
    /// </summary>
    public string? TotalInterestPercentageUI { get => _totalInterestPercentageUI; set => SetField(ref _totalInterestPercentageUI, value); }
}