using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Application
/// </summary>
public sealed partial class Application : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Liabilities Alternate Acct # 1 [1735]
    /// </summary>
    public string? AccountNumber1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Alternate Acct # 2 [1737]
    /// </summary>
    public string? AccountNumber2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application AdditionalLoans
    /// </summary>
    [AllowNull]
    public IList<AdditionalLoan> AdditionalLoans { get => GetList<AdditionalLoan>(); set => SetList(value); }

    /// <summary>
    /// Underwriting All Other Pymts [1733]
    /// </summary>
    public decimal? AllOtherPaymentsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application ApplicationId
    /// </summary>
    public string? ApplicationId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application ApplicationIndex
    /// </summary>
    public int? ApplicationIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Signature Date [MORNET.X68]
    /// </summary>
    public DateTime? ApplicationSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Application Assets
    /// </summary>
    [AllowNull]
    public IList<Asset> Assets { get => GetList<Asset>(); set => SetList(value); }

    /// <summary>
    /// FHA MCAW Assets Available [1094]
    /// </summary>
    public decimal? AssetsAvailableAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application ATRQMBorrower
    /// </summary>
    public ATRQMBorrower? ATRQMBorrower { get => GetValue<ATRQMBorrower?>(); set => SetValue(value); }

    /// <summary>
    /// Application ATRQMBorrowers
    /// </summary>
    [AllowNull]
    public IList<ATRQMBorrower> ATRQMBorrowers { get => GetList<ATRQMBorrower>(); set => SetList(value); }

    /// <summary>
    /// Application AUSTrackingLogs
    /// </summary>
    [AllowNull]
    public IList<AUSTrackingLog> AUSTrackingLogs { get => GetList<AUSTrackingLog>(); set => SetList(value); }

    /// <summary>
    /// VA Bal Avail Family Support Guideline [1340]
    /// </summary>
    public decimal? BalanceAvailableFamilySupportGuideline { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application Borrower
    /// </summary>
    [AllowNull]
    public Borrower Borrower { get => GetEntity<Borrower>(); set => SetEntity(value); }

    /// <summary>
    /// Borrower Pair ID [BORPAIRID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerPairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Qual Ratio Bottom [742]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BottomRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Deductions Spouse/Borr [1312]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BrwCoBrwTotalTaxDeductions { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Closing Disclosure Borrower Delivery Date [CORRESPONDENT.X145]
    /// </summary>
    public DateTime? ClosingDisclosureBorDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Closing Disclosure Received Date [CORRESPONDENT.X146]
    /// </summary>
    public DateTime? ClosingDisclosureBorReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Application Coborrower
    /// </summary>
    [AllowNull]
    public Borrower Coborrower { get => GetEntity<Borrower>(); set => SetEntity(value); }

    /// <summary>
    /// Liabilities Alternate Name 1 [206]
    /// </summary>
    public string? CreditAliasName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Alternate Name 2 [203]
    /// </summary>
    public string? CreditAliasName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Creditor Name 1 [1734]
    /// </summary>
    public string? CreditorName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Creditor Name 2 [1736]
    /// </summary>
    public string? CreditorName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Credit Rpt Ref # [300]
    /// </summary>
    public string? CreditReportReferenceIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application Employment
    /// </summary>
    [AllowNull]
    public IList<Employment> Employment { get => GetList<Employment>(); set => SetList(value); }

    /// <summary>
    /// Application EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Addr [DISCLOSURE.X42]
    /// </summary>
    public string? EquifaxAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co City [DISCLOSURE.X43]
    /// </summary>
    public string? EquifaxCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Fax [DISCLOSURE.X47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? EquifaxFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Model [DISCLOSURE.X48]
    /// </summary>
    public string? EquifaxModel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Name [DISCLOSURE.X41]
    /// </summary>
    public string? EquifaxName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Phone [DISCLOSURE.X46]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? EquifaxPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Zip [DISCLOSURE.X45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? EquifaxPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Range Scores From [DISCLOSURE.X49]
    /// </summary>
    public string? EquifaxScoreRangeFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Range Scores To [DISCLOSURE.X50]
    /// </summary>
    public string? EquifaxScoreRangeTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co State [DISCLOSURE.X44]
    /// </summary>
    public StringEnumValue<State> EquifaxState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Website [DISCLOSURE.X640]
    /// </summary>
    public string? EquifaxWebsite { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Addr [DISCLOSURE.X2]
    /// </summary>
    public string? ExperianAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co City [DISCLOSURE.X3]
    /// </summary>
    public string? ExperianCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Fax [DISCLOSURE.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ExperianFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Model Used [DISCLOSURE.X8]
    /// </summary>
    public string? ExperianModel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Name [DISCLOSURE.X1]
    /// </summary>
    public string? ExperianName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Phone [DISCLOSURE.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ExperianPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Zip [DISCLOSURE.X5]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ExperianPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Range Scores From [DISCLOSURE.X9]
    /// </summary>
    public string? ExperianScoreRangeFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Range Scores To [DISCLOSURE.X10]
    /// </summary>
    public string? ExperianScoreRangeTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co State [DISCLOSURE.X4]
    /// </summary>
    public StringEnumValue<State> ExperianState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Website [DISCLOSURE.X638]
    /// </summary>
    public string? ExperianWebsite { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Debt-to-Income Ratio [1341]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FhaVaDebtIncomeRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Residual Income Spouse/Borr [1325]
    /// </summary>
    public decimal? FhaVaFamilySupportAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Total Mo Shelter Exp Est [1349]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Net Effective Income [1323]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalNetEffectiveIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Net Spouse/Borr [1321]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalNetIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Net Take Home Pay Spouse/Borr [1315]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalNetTakeHomePayAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Other Net Spouse/Borr [1318]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalOtherNetIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Present Mtg Pymt [120]
    /// </summary>
    public decimal? FirstMortgagePrincipalAndInterestAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Credit Ref # [CASASRN.X198]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FreddieMacCreditReportReferenceIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Additional Data - Occupancy Debt Ratio [CASASRN.X202]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FreddieMacOccupantDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Additional Data - Occupancy Housing Ratio [CASASRN.X201]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FreddieMacOccupantHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Qual Ratio Debt-to-Housing [1539]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FreDebtToHousingGapRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application GiftsGrants
    /// </summary>
    [AllowNull]
    public IList<GiftGrant> GiftsGrants { get => GetList<GiftGrant>(); set => SetList(value); }

    /// <summary>
    /// Income Total Base Income (Borr/Co-Borr) [273]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossBaseIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Co-Mortgagor Income [1374]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossIncomeForComortSet { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Negative Cash Flow [462]
    /// </summary>
    public decimal? GrossNegativeCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Other Income (Borr/Co-Borr) [1168]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossOtherIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Positive Cash Flow (Borr/Co-Borr) [1171]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossPositiveCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Present Haz Ins [122]
    /// </summary>
    public string? HazardInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Present HOA [125]
    /// </summary>
    public string? HomeownersAssociationDuesAndCondoFeesAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Lienholder [CAPIAP.X134]
    /// </summary>
    public string? HudAutoLienHolderName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Lienholder [CAPIAP.X139]
    /// </summary>
    public string? HudAutoLienHolderName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Loan Amt [CAPIAP.X136]
    /// </summary>
    public decimal? HudAutoLoanAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Loan Amt [CAPIAP.X141]
    /// </summary>
    public decimal? HudAutoLoanAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Mo Pymt [CAPIAP.X138]
    /// </summary>
    public decimal? HudAutoMonthlyPayment1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Mo Pymt [CAPIAP.X143]
    /// </summary>
    public decimal? HudAutoMonthlyPayment2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Present Bal [CAPIAP.X137]
    /// </summary>
    public decimal? HudAutoPresentBalance1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Present Bal [CAPIAP.X142]
    /// </summary>
    public decimal? HudAutoPresentBalance2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Yr/Make [CAPIAP.X135]
    /// </summary>
    public string? HudAutoYearAndMake1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Yr/Make [CAPIAP.X140]
    /// </summary>
    public string? HudAutoYearAndMake2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 1 Loan Amt [CAPIAP.X25]
    /// </summary>
    public decimal? HudLoanAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 10 Loan Amt [CAPIAP.X38]
    /// </summary>
    public decimal? HudLoanAmount10 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 11 Loan Amt [CAPIAP.X39]
    /// </summary>
    public decimal? HudLoanAmount11 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 2 Loan Amt [CAPIAP.X26]
    /// </summary>
    public decimal? HudLoanAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 3 Loan Amt [CAPIAP.X31]
    /// </summary>
    public decimal? HudLoanAmount3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 4 Loan Amt [CAPIAP.X32]
    /// </summary>
    public decimal? HudLoanAmount4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 5 Loan Amt [CAPIAP.X33]
    /// </summary>
    public decimal? HudLoanAmount5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 6 Loan Amt [CAPIAP.X34]
    /// </summary>
    public decimal? HudLoanAmount6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 7 Loan Amt [CAPIAP.X35]
    /// </summary>
    public decimal? HudLoanAmount7 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 8 Loan Amt [CAPIAP.X36]
    /// </summary>
    public decimal? HudLoanAmount8 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Liability 9 Loan Amt [CAPIAP.X37]
    /// </summary>
    public decimal? HudLoanAmount9 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 1 FHA Insured [CAPIAP.X28]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"FHA Insured\"}")]
    public bool? HudRealEstateFhaInsured1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 2 FHA Insured [CAPIAP.X30]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"FHA Insured\"}")]
    public bool? HudRealEstateFhaInsured2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 1 Lienholder [CAPIAP.X148]
    /// </summary>
    public string? HudRealEstateLienHolder1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 2 Lienholder [CAPIAP.X149]
    /// </summary>
    public string? HudRealEstateLienHolder2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 1 Loan Amt [CAPIAP.X27]
    /// </summary>
    public decimal? HudRealEstateLoanAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 2 Loan Amt [CAPIAP.X29]
    /// </summary>
    public decimal? HudRealEstateLoanAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 1 Mo Pymt [CAPIAP.X151]
    /// </summary>
    public decimal? HudRealEstateMonthlyPayment1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 2 Mo Pymt [CAPIAP.X153]
    /// </summary>
    public decimal? HudRealEstateMonthlyPayment2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 1 Present Bal [CAPIAP.X150]
    /// </summary>
    public decimal? HudRealEstatePresentBalance1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve RE 2 Present Bal [CAPIAP.X152]
    /// </summary>
    public decimal? HudRealEstatePresentBalance2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application Income
    /// </summary>
    [AllowNull]
    public IList<Income> Income { get => GetList<Income>(); set => SetList(value); }

    /// <summary>
    /// Trans Details Income of Spouse will not be used [35]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The income/assets of the Borrower's spouse will not be used..\"}")]
    public bool? IncomeOfBorrowersSpouseUsedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Income of Other will be used [307]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The income/assets of a person other than Borrower will be used...\"}")]
    public bool? IncomeOtherThanBorrowerUsedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Assets/Liabilities Completed Jointly/Not Jointly [181]
    /// </summary>
    public bool? JointAssetLiabilityReportingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Application LastModified
    /// </summary>
    public string? LastModified { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application Liabilities
    /// </summary>
    [AllowNull]
    public IList<Liability> Liabilities { get => GetList<Liability>(); set => SetList(value); }

    /// <summary>
    /// Assets Co-Borr Liquid Assets [267]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LiquidAssetsComortSet { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application LoanAmount
    /// </summary>
    public string? LoanAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Estimate Delivery Date [CORRESPONDENT.X243]
    /// </summary>
    public DateTime? LoanEstimateDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Application LoanOfficerId
    /// </summary>
    public string? LoanOfficerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application LoanOfficerName
    /// </summary>
    public string? LoanOfficerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Borr Other Mo Income [936]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawBorrowerOtherMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Co-Borr Other Mo Income [938]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Gross Mo Income [1761]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawGrossMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Mtg Pymt-to-Income Ratio [MCAWPUR.X22]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawMortgagePaymentToIncome1Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Ratio Mtg Pymt-to-Income [GMCAW.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawMortgagePaymentToIncome2Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Liabilities Other [1161]
    /// </summary>
    public decimal? McawOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Liabilities Unpaid Bal [1163]
    /// </summary>
    public decimal? McawOtherDebtsAndObligationsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Fixed Pymt [MCAWPUR.X24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalFixedPaymentForPurchaseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Fixed Pymt [GMCAW.X9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalFixedPaymentForRefinanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Fixed Pymt-to-Income Ratio [MCAWPUR.X23]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawTotalFixedPaymentToIncome1Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Ratio Total Fixed Pymt-to-Income [GMCAW.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawTotalFixedPaymentToIncome2Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Liabilities Total Mo Pymt [1150]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalMonthlyPaymentsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Mtg Pymt [739]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalMortgagePaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Co-Mortgagor [1384]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyExpenseComortSet { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Total Housing Expense [1809]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyHousingExpenseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Total Mo Installment Exp [382]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyInstallmentExpenseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Negative Real Estate [LOANSUB.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyNegativeRealEstateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses 2nd/Vacation Home [1476]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlySecondHomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Present MTG Ins [124]
    /// </summary>
    public string? MortgageInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Net Worth [734]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NetWorthAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application OtherAssets
    /// </summary>
    [AllowNull]
    public IList<OtherAsset> OtherAssets { get => GetList<OtherAsset>(); set => SetList(value); }

    /// <summary>
    /// Expenses Present Other Housing [126]
    /// </summary>
    public decimal? OtherHousingExpenseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application OtherIncomeSources
    /// </summary>
    [AllowNull]
    public IList<OtherIncomeSource> OtherIncomeSources { get => GetList<OtherIncomeSource>(); set => SetList(value); }

    /// <summary>
    /// Income Deductions Other Items Deducted [198]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherItemsDeducted { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application OtherLiabilities
    /// </summary>
    [AllowNull]
    public IList<OtherLiability> OtherLiabilities { get => GetList<OtherLiability>(); set => SetList(value); }

    /// <summary>
    /// Expenses Present Other Pymt [121]
    /// </summary>
    public decimal? OtherMortgagePrincipalAndInterestAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Other Total Income [URLA.X44]
    /// </summary>
    public decimal? OtherTotalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Past Credit Record [1326]
    /// </summary>
    public StringEnumValue<PastCreditRecord> PastCreditRecord { get => GetValue<StringEnumValue<PastCreditRecord>>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Credit Report Indicator  [4750]
    /// </summary>
    public bool? PrequalCreditReportIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Co-Borr Present Mo Hous Exp [268]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PresentHousingExpComortSet { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Present Supplemental Property Insurance Amount [URLA.X212]
    /// </summary>
    public decimal? PresentSupplementalPropertyInsuranceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Co-Mortgagor Primary Exp [1379]
    /// </summary>
    public decimal? PrimaryResidenceComortSet { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Occupancy Status [1811]
    /// </summary>
    public StringEnumValue<PropertyUsageType> PropertyUsageType { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting HOA Fees [1729]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedDuesAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting First Mtg P&amp;I [1724]
    /// </summary>
    public decimal? ProposedFirstMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Rent [1723]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ProposedGroundRentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Hazard Ins [1726]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedHazardInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Mo Pymt [1728]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedMortgageInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Other Fees [1730]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ProposedOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Second Mtg P&amp;I [1725]
    /// </summary>
    public decimal? ProposedOtherMortgagesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Taxes [1727]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedRealEstateTaxesAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application ProvidedDocuments
    /// </summary>
    [AllowNull]
    public IList<ProvidedDocument> ProvidedDocuments { get => GetList<ProvidedDocument>(); set => SetList(value); }

    /// <summary>
    /// Expenses Present Taxes [123]
    /// </summary>
    public string? RealEstateTaxAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Present Rent [119]
    /// </summary>
    public decimal? RentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application ReoProperties
    /// </summary>
    [AllowNull]
    public IList<ReoProperty> ReoProperties { get => GetList<ReoProperty>(); set => SetList(value); }

    /// <summary>
    /// Income Total Gross Rent Income [921]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalGrossRentalIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Ins/Tax/Exp Income [923]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMaintenanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Assets Real Estate Owned [919]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Mortgage Pymts Income [922]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMortgagePaymentsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Amt of Mortgages Income [920]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMortgagesAndLiensAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Net Rental Income [924]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ReoTotalNetRentalIncomeAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rescission Date [CORRESPONDENT.X316]
    /// </summary>
    public DateTime? RescissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rescission Note Signed Date [CORRESPONDENT.X317]
    /// </summary>
    public DateTime? RescissionNoteSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Application Residences
    /// </summary>
    [AllowNull]
    public IList<Residence> Residences { get => GetList<Residence>(); set => SetList(value); }

    /// <summary>
    /// Application Respa6
    /// </summary>
    public string? Respa6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application SelfEmployedIncomes
    /// </summary>
    [AllowNull]
    public IList<SelfEmployedIncome> SelfEmployedIncomes { get => GetList<SelfEmployedIncome>(); set => SetList(value); }

    /// <summary>
    /// Denial Info - Borrower Country [DENIAL.X98]
    /// </summary>
    public string? SofDBorrCountry { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Info - Borrower Foreign Address Indicator [DENIAL.X97]
    /// </summary>
    public bool? SofDBorrForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address [DENIAL.X82]
    /// </summary>
    public string? SofDBorrowerAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address - City [DENIAL.X83]
    /// </summary>
    public string? SofDBorrowerAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address - State [DENIAL.X84]
    /// </summary>
    public StringEnumValue<State> SofDBorrowerAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address Type [DENIAL.X81]
    /// </summary>
    public StringEnumValue<SofDBorrowerAddressType> SofDBorrowerAddressType { get => GetValue<StringEnumValue<SofDBorrowerAddressType>>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address - Zipcode [DENIAL.X85]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SofDBorrowerAddressZipcode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Info - Coborrower Country [DENIAL.X100]
    /// </summary>
    public string? SofDCoBorrCountry { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Info - Coborrower Foreign Address Indicator [DENIAL.X99]
    /// </summary>
    public bool? SofDCoBorrForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address [DENIAL.X87]
    /// </summary>
    public string? SofDCoBorrowerAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address - City [DENIAL.X88]
    /// </summary>
    public string? SofDCoBorrowerAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address - State [DENIAL.X89]
    /// </summary>
    public StringEnumValue<State> SofDCoBorrowerAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address Type [DENIAL.X86]
    /// </summary>
    public StringEnumValue<SofDBorrowerAddressType> SofDCoBorrowerAddressType { get => GetValue<StringEnumValue<SofDBorrowerAddressType>>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address - Zipcode [DENIAL.X90]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SofDCoBorrowerAddressZipcode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Income Consider Spouse Income [1006]
    /// </summary>
    public bool? SpouseIncomeConsider { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Application Tax4506s
    /// </summary>
    [AllowNull]
    public IList<Tax4506> Tax4506s { get => GetList<Tax4506>(); set => SetList(value); }

    /// <summary>
    /// Trans Details Qual Ratio Top [740]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TopRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Additional Assets Amount [URLA.X49]
    /// </summary>
    public decimal? TotalAdditionalAssetsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Additional Loans Amount [URLA.X229]
    /// </summary>
    public decimal? TotalAdditionalLoansAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Additional Other Assets Amount [URLA.X53]
    /// </summary>
    public decimal? TotalAdditionalOtherAssetsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Applied To Downpayment [URLA.X230]
    /// </summary>
    public decimal? TotalAppliedToDownpayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Assets Total Assets [732]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAssetsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Base Income (Borr/Co-Borr) [901]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBaseIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Bonuses (Borr/Co-Borr) [903]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBonusAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Commissions (Borr/Co-Borr) [904]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCommissionsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Assets Total Bank Deposits [979]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDeposit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Div/Int (Borr/Co-Borr) [905]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDividendsInterestAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Mo Income Spouse/Borr [1810]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalEmploymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Total Mo Expense [1187]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalFixedPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Mo Income (Borr/Co-Borr) [1389]
    /// </summary>
    public decimal? TotalGrossMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Mo Income [736]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Total Liability Pymt [350]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Mtg Bal [941]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMortgagesBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Mtg Mo Pymt [909]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMortgagesMonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Net Rent Income (Borr/Co-Borr) [906]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalNetRentalIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Other 1 (Borr/Co-Borr) [907]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOther1Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Other 2 (Borr/Co-Borr) [908]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOther2Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Other Assets Amount [URLA.X54]
    /// </summary>
    public decimal? TotalOtherAssetsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Overtime (Borr/Co-Borr) [902]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOvertimeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Proposed Mo Pymt [1742]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPaymentsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Total Primary Expenses [1731]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPrimaryHousingExpenseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application TotalReoMarketValueAmount
    /// </summary>
    public decimal? TotalReoMarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Assets Amount [URLA.X50]
    /// </summary>
    public decimal? TotalURLA2020AssetsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Other Income (User Defined) [1817]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalUserDefinedIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Application TQLReports
    /// </summary>
    [AllowNull]
    public IList<TQLReportInformation> TQLReports { get => GetList<TQLReportInformation>(); set => SetList(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Addr [DISCLOSURE.X22]
    /// </summary>
    public string? TransUnionAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co City [DISCLOSURE.X23]
    /// </summary>
    public string? TransUnionCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Fax [DISCLOSURE.X27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TransUnionFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Model [DISCLOSURE.X28]
    /// </summary>
    public string? TransUnionModel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Name [DISCLOSURE.X21]
    /// </summary>
    public string? TransUnionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Phone [DISCLOSURE.X26]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TransUnionPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Zip [DISCLOSURE.X25]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? TransUnionPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Range Scores From [DISCLOSURE.X29]
    /// </summary>
    public string? TransUnionScoreRangeFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Range Scores To [DISCLOSURE.X30]
    /// </summary>
    public string? TransUnionScoreRangeTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co State [DISCLOSURE.X24]
    /// </summary>
    public StringEnumValue<State> TransUnionState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Website [DISCLOSURE.X639]
    /// </summary>
    public string? TransUnionWebsite { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Application URLAAlternateNames
    /// </summary>
    [AllowNull]
    public IList<URLAAlternateName> URLAAlternateNames { get => GetList<URLAAlternateName>(); set => SetList(value); }

    /// <summary>
    /// Application UserDefinedIncome
    /// </summary>
    public decimal? UserDefinedIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Borr/Co-Borr Other Income 2 Descr [1818]
    /// </summary>
    public string? UserDefinedIncomeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Meets VA Credit Standards [1327]
    /// </summary>
    public StringEnumValue<YOrN> VACreditStandards { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Income Spouse Income Amt [1008]
    /// </summary>
    public decimal? VaSummarySpouseIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Mo Gross Income [993]
    /// </summary>
    public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}