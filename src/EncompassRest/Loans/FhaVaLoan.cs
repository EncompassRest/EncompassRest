using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FhaVaLoan
    /// </summary>
    public sealed partial class FhaVaLoan : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AddendumType>> _addendumType;
        /// <summary>
        /// HUD Addendum Type [1711]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Addendum Type")]
        public StringEnumValue<AddendumType> AddendumType { get => _addendumType; set => SetField(ref _addendumType, value); }
        private DirtyValue<bool?> _additionalCondition1;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 1 [3185]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 1")]
        public bool? AdditionalCondition1 { get => _additionalCondition1; set => SetField(ref _additionalCondition1, value); }
        private DirtyValue<bool?> _additionalCondition2;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 2 [3186]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 2")]
        public bool? AdditionalCondition2 { get => _additionalCondition2; set => SetField(ref _additionalCondition2, value); }
        private DirtyValue<bool?> _additionalCondition3;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 3 [3187]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 3")]
        public bool? AdditionalCondition3 { get => _additionalCondition3; set => SetField(ref _additionalCondition3, value); }
        private DirtyValue<bool?> _additionalCondition4;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 4 [3188]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 4")]
        public bool? AdditionalCondition4 { get => _additionalCondition4; set => SetField(ref _additionalCondition4, value); }
        private DirtyValue<bool?> _additionalCondition5;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 5 [3189]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 5")]
        public bool? AdditionalCondition5 { get => _additionalCondition5; set => SetField(ref _additionalCondition5, value); }
        private DirtyValue<bool?> _additionalCondition6;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 6 [3190]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 6")]
        public bool? AdditionalCondition6 { get => _additionalCondition6; set => SetField(ref _additionalCondition6, value); }
        private DirtyValue<bool?> _additionalCondition7;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 7 [3191]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 7")]
        public bool? AdditionalCondition7 { get => _additionalCondition7; set => SetField(ref _additionalCondition7, value); }
        private DirtyValue<bool?> _additionalCondition8;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 8 [3193]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 8")]
        public bool? AdditionalCondition8 { get => _additionalCondition8; set => SetField(ref _additionalCondition8, value); }
        private DirtyValue<bool?> _additionalCondition9;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 9 [3195]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 9")]
        public bool? AdditionalCondition9 { get => _additionalCondition9; set => SetField(ref _additionalCondition9, value); }
        private DirtyValue<string> _addressValidatedBy;
        /// <summary>
        /// FHA Management Address Validated By [3061]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Address Validated By")]
        public string AddressValidatedBy { get => _addressValidatedBy; set => SetField(ref _addressValidatedBy, value); }
        private DirtyValue<string> _addressValidationMessage;
        /// <summary>
        /// FHA Management Address Validation Message [3063]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Address Validation Message")]
        public string AddressValidationMessage { get => _addressValidationMessage; set => SetField(ref _addressValidationMessage, value); }
        private DirtyValue<bool?> _allConditionsSatisfied;
        /// <summary>
        /// HUD 1003 Addendum - All Conditions of Approval Have Been Satisfied Indicator [4092]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum - All Conditions of Approval Have Been Satisfied Indicator")]
        public bool? AllConditionsSatisfied { get => _allConditionsSatisfied; set => SetField(ref _allConditionsSatisfied, value); }
        private DirtyValue<DateTime?> _appraisalLoggedDate;
        /// <summary>
        /// FHA Management Appraisal Logged Date [3076]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Appraisal Logged Date")]
        public DateTime? AppraisalLoggedDate { get => _appraisalLoggedDate; set => SetField(ref _appraisalLoggedDate, value); }
        private DirtyValue<string> _appraisalLookupBy;
        /// <summary>
        /// FHA Management Appraisal Lookup By [3077]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Appraisal Lookup By")]
        public string AppraisalLookupBy { get => _appraisalLookupBy; set => SetField(ref _appraisalLookupBy, value); }
        private DirtyValue<StringEnumValue<BeenInformed>> _beenInformed;
        /// <summary>
        /// Borr Cert Property Value [1639]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Property Value")]
        public StringEnumValue<BeenInformed> BeenInformed { get => _beenInformed; set => SetField(ref _beenInformed, value); }
        private DirtyValue<string> _borrowerCertificationAddress;
        /// <summary>
        /// Borr Other Ownd RE Addr [461]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Other Ownd RE Addr")]
        public string BorrowerCertificationAddress { get => _borrowerCertificationAddress; set => SetField(ref _borrowerCertificationAddress, value); }
        private DirtyValue<string> _borrowerCertificationCity;
        /// <summary>
        /// Borr Cert Other RE City [1738]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Other RE City")]
        public string BorrowerCertificationCity { get => _borrowerCertificationCity; set => SetField(ref _borrowerCertificationCity, value); }
        private DirtyValue<string> _borrowerCertificationPostalCode;
        /// <summary>
        /// Borr Cert Other RE Zip [1740]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Borr Cert Other RE Zip")]
        public string BorrowerCertificationPostalCode { get => _borrowerCertificationPostalCode; set => SetField(ref _borrowerCertificationPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _borrowerCertificationState;
        /// <summary>
        /// Borr Cert Other RE State [1739]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Other RE State")]
        public StringEnumValue<State> BorrowerCertificationState { get => _borrowerCertificationState; set => SetField(ref _borrowerCertificationState, value); }
        private DirtyValue<string> _cAIVRSObtainedBy;
        /// <summary>
        /// FHA Management CAIVRS Obtained By [3068]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management CAIVRS Obtained By")]
        public string CAIVRSObtainedBy { get => _cAIVRSObtainedBy; set => SetField(ref _cAIVRSObtainedBy, value); }
        private DirtyValue<string> _caseBinderShippedBy;
        /// <summary>
        /// FHA Management Case Binder Shipped By [3091]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Case Binder Shipped By")]
        public string CaseBinderShippedBy { get => _caseBinderShippedBy; set => SetField(ref _caseBinderShippedBy, value); }
        private DirtyValue<DateTime?> _caseBinderShippedDate;
        /// <summary>
        /// FHA Management Case Binder Shipped Date [3090]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Case Binder Shipped Date")]
        public DateTime? CaseBinderShippedDate { get => _caseBinderShippedDate; set => SetField(ref _caseBinderShippedDate, value); }
        private DirtyValue<DateTime?> _closingDate;
        /// <summary>
        /// Trans Details Closed Date [748]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Closed Date")]
        public DateTime? ClosingDate { get => _closingDate; set => SetField(ref _closingDate, value); }
        private DirtyValue<string> _condoPudID;
        /// <summary>
        /// FHA Management CondoPud ID [3075]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management CondoPud ID")]
        public string CondoPudID { get => _condoPudID; set => SetField(ref _condoPudID, value); }
        private DirtyValue<string> _condoPudLookupBy;
        /// <summary>
        /// FHA Management Condo Pud Lookup By [3074]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Condo Pud Lookup By")]
        public string CondoPudLookupBy { get => _condoPudLookupBy; set => SetField(ref _condoPudLookupBy, value); }
        private DirtyValue<DateTime?> _condoPudLookupDate;
        /// <summary>
        /// FHA Management Condo Pud Lookup Date [3073]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Condo Pud Lookup Date")]
        public DateTime? CondoPudLookupDate { get => _condoPudLookupDate; set => SetField(ref _condoPudLookupDate, value); }
        private DirtyValue<decimal?> _conventionalClosingCost;
        /// <summary>
        /// Informed Consumer Choice Conventional Closing Cost [FICC.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Closing Cost")]
        public decimal? ConventionalClosingCost { get => _conventionalClosingCost; set => SetField(ref _conventionalClosingCost, value); }
        private DirtyValue<decimal?> _conventionalDownPayment;
        /// <summary>
        /// Informed Consumer Choice Conventional Down Payment [FICC.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Down Payment")]
        public decimal? ConventionalDownPayment { get => _conventionalDownPayment; set => SetField(ref _conventionalDownPayment, value); }
        private DirtyValue<decimal?> _conventionalInterestRate;
        /// <summary>
        /// Informed Consumer Choice Conventional Interest Rate [FICC.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Interest Rate")]
        public decimal? ConventionalInterestRate { get => _conventionalInterestRate; set => SetField(ref _conventionalInterestRate, value); }
        private DirtyValue<int?> _conventionalLoanTerm;
        /// <summary>
        /// Informed Consumer Choice Conventional Loan Term [FICC.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice Conventional Loan Term")]
        public int? ConventionalLoanTerm { get => _conventionalLoanTerm; set => SetField(ref _conventionalLoanTerm, value); }
        private DirtyValue<decimal?> _conventionalLTV;
        /// <summary>
        /// Informed Consumer Choice Conventional LTV [FICC.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional LTV")]
        public decimal? ConventionalLTV { get => _conventionalLTV; set => SetField(ref _conventionalLTV, value); }
        private DirtyValue<int?> _conventionalMaxYearsMI;
        /// <summary>
        /// Informed Consumer Choice Conventional Max Years of Monthly Insurance Premium Payments [FICC.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice Conventional Max Years of Monthly Insurance Premium Payments")]
        public int? ConventionalMaxYearsMI { get => _conventionalMaxYearsMI; set => SetField(ref _conventionalMaxYearsMI, value); }
        private DirtyValue<decimal?> _conventionalMMI;
        /// <summary>
        /// Informed Consumer Choice Conventional Monthly Mortgage Income [FICC.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Monthly Mortgage Income")]
        public decimal? ConventionalMMI { get => _conventionalMMI; set => SetField(ref _conventionalMMI, value); }
        private DirtyValue<decimal?> _conventionalMonthlyPayment;
        /// <summary>
        /// Informed Consumer Choice Conventional Monthly Payment [FICC.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Monthly Payment")]
        public decimal? ConventionalMonthlyPayment { get => _conventionalMonthlyPayment; set => SetField(ref _conventionalMonthlyPayment, value); }
        private DirtyValue<decimal?> _conventionalMortgageAmount;
        /// <summary>
        /// Informed Consumer Choice Conventional Mortgage Amount [FICC.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Mortgage Amount")]
        public decimal? ConventionalMortgageAmount { get => _conventionalMortgageAmount; set => SetField(ref _conventionalMortgageAmount, value); }
        private DirtyValue<decimal?> _conventionalSalesPrice;
        /// <summary>
        /// Informed Consumer Choice Conventional Sales Price [FICC.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Sales Price")]
        public decimal? ConventionalSalesPrice { get => _conventionalSalesPrice; set => SetField(ref _conventionalSalesPrice, value); }
        private DirtyValue<decimal?> _conventionalUMIP;
        /// <summary>
        /// Informed Consumer Choice Conventional UMIP [FICC.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional UMIP")]
        public decimal? ConventionalUMIP { get => _conventionalUMIP; set => SetField(ref _conventionalUMIP, value); }
        private DirtyValue<DateTime?> _dateApprovalExpires;
        /// <summary>
        /// HUD 1003 Addendum Date Approval Expires [3177]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Date Approval Expires")]
        public DateTime? DateApprovalExpires { get => _dateApprovalExpires; set => SetField(ref _dateApprovalExpires, value); }
        private DirtyValue<DateTime?> _dateMortgageApproved;
        /// <summary>
        /// HUD 1003 Addendum Date Mtg Approved [3176]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Date Mtg Approved")]
        public DateTime? DateMortgageApproved { get => _dateMortgageApproved; set => SetField(ref _dateMortgageApproved, value); }
        private DirtyValue<string> _detailForOther;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 7 Detail [3192]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 7 Detail")]
        public string DetailForOther { get => _detailForOther; set => SetField(ref _detailForOther, value); }
        private DirtyValue<decimal?> _discountPoints;
        /// <summary>
        /// FHA MCAW Discounts [1046]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Discounts")]
        public decimal? DiscountPoints { get => _discountPoints; set => SetField(ref _discountPoints, value); }
        private DirtyValue<string> _dulyAgentAddress;
        /// <summary>
        /// HUD Duly Auth Agent Addr 1 [1795]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Addr 1")]
        public string DulyAgentAddress { get => _dulyAgentAddress; set => SetField(ref _dulyAgentAddress, value); }
        private DirtyValue<string> _dulyAgentCity;
        /// <summary>
        /// HUD Lender Cert Author Agent Addr 2 [684]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Lender Cert Author Agent Addr 2")]
        public string DulyAgentCity { get => _dulyAgentCity; set => SetField(ref _dulyAgentCity, value); }
        private DirtyValue<string> _dulyAgentFunction1;
        /// <summary>
        /// HUD Duly Auth Agent Function 1 [1796]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Function 1")]
        public string DulyAgentFunction1 { get => _dulyAgentFunction1; set => SetField(ref _dulyAgentFunction1, value); }
        private DirtyValue<string> _dulyAgentFunction2;
        /// <summary>
        /// HUD Duly Auth Agent Function 2 [1798]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Function 2")]
        public string DulyAgentFunction2 { get => _dulyAgentFunction2; set => SetField(ref _dulyAgentFunction2, value); }
        private DirtyValue<string> _dulyAgentName;
        /// <summary>
        /// HUD Duly Auth Agent Name [322]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Name")]
        public string DulyAgentName { get => _dulyAgentName; set => SetField(ref _dulyAgentName, value); }
        private DirtyValue<string> _dulyAgentState;
        /// <summary>
        /// HUD Duly Auth Agent Addr 3 [1797]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Addr 3")]
        public string DulyAgentState { get => _dulyAgentState; set => SetField(ref _dulyAgentState, value); }
        private DirtyValue<bool?> _dwellingCoveredBy;
        /// <summary>
        /// Borr Cert Dwelling To Be Covered By Yes/No [1016]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Dwelling To Be Covered By Yes/No")]
        public bool? DwellingCoveredBy { get => _dwellingCoveredBy; set => SetField(ref _dwellingCoveredBy, value); }
        private EnergyEfficientMortgage _eem;
        /// <summary>
        /// FhaVaLoan Eem
        /// </summary>
        public EnergyEfficientMortgage Eem { get => GetField(ref _eem); set => SetField(ref _eem, value); }
        private DirtyValue<StringEnumValue<EligibilityAssessment>> _eligibilityAssessment;
        /// <summary>
        /// FHA Management Eligibility Assessment [3631]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Eligibility Assessment")]
        public StringEnumValue<EligibilityAssessment> EligibilityAssessment { get => _eligibilityAssessment; set => SetField(ref _eligibilityAssessment, value); }
        private DirtyValue<decimal?> _energyEfficientMortgageAmount;
        /// <summary>
        /// FHA MCAW Energy Eff Improvements Amt [1721]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Energy Eff Improvements Amt")]
        public decimal? EnergyEfficientMortgageAmount { get => _energyEfficientMortgageAmount; set => SetField(ref _energyEfficientMortgageAmount, value); }
        private DirtyList<EnergyEfficientMortgageItem> _energyEfficientMortgageItems;
        /// <summary>
        /// FhaVaLoan EnergyEfficientMortgageItems
        /// </summary>
        public IList<EnergyEfficientMortgageItem> EnergyEfficientMortgageItems { get => GetField(ref _energyEfficientMortgageItems); set => SetField(ref _energyEfficientMortgageItems, value); }
        private DirtyValue<bool?> _everHadVAHomeLoan;
        /// <summary>
        /// Borr Cert Prior VA Home Loan [1398]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Prior VA Home Loan")]
        public bool? EverHadVAHomeLoan { get => _everHadVAHomeLoan; set => SetField(ref _everHadVAHomeLoan, value); }
        private DirtyValue<decimal?> _excessContributionAmount;
        /// <summary>
        /// Excess Seller Contribution [3053]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Excess Seller Contribution")]
        public decimal? ExcessContributionAmount { get => _excessContributionAmount; set => SetField(ref _excessContributionAmount, value); }
        private DirtyValue<decimal?> _existingDebtAmount;
        /// <summary>
        /// Existing Debt for Refi Loan [3052]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Existing Debt for Refi Loan")]
        public decimal? ExistingDebtAmount { get => _existingDebtAmount; set => SetField(ref _existingDebtAmount, value); }
        private DirtyValue<string> _fHACaseOrderedBy;
        /// <summary>
        /// FHA Management FHA Case Ordered By [3059]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management FHA Case Ordered By")]
        public string FHACaseOrderedBy { get => _fHACaseOrderedBy; set => SetField(ref _fHACaseOrderedBy, value); }
        private DirtyValue<decimal?> _fHAClosingCost;
        /// <summary>
        /// Informed Consumer Choice FHA Closing Cost [FICC.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Closing Cost")]
        public decimal? FHAClosingCost { get => _fHAClosingCost; set => SetField(ref _fHAClosingCost, value); }
        private DirtyValue<decimal?> _fHADownPayment;
        /// <summary>
        /// Informed Consumer Choice FHA Down Payment [FICC.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Down Payment")]
        public decimal? FHADownPayment { get => _fHADownPayment; set => SetField(ref _fHADownPayment, value); }
        private DirtyValue<decimal?> _fHAInterestRate;
        /// <summary>
        /// Informed Consumer Choice FHA Interest Rate [FICC.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Interest Rate")]
        public decimal? FHAInterestRate { get => _fHAInterestRate; set => SetField(ref _fHAInterestRate, value); }
        private DirtyValue<int?> _fHALoanTerm;
        /// <summary>
        /// Informed Consumer Choice FHA Loan Term [FICC.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice FHA Loan Term")]
        public int? FHALoanTerm { get => _fHALoanTerm; set => SetField(ref _fHALoanTerm, value); }
        private DirtyValue<decimal?> _fHALTV;
        /// <summary>
        /// Informed Consumer Choice FHA LTV [FICC.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA LTV")]
        public decimal? FHALTV { get => _fHALTV; set => SetField(ref _fHALTV, value); }
        private DirtyValue<StringEnumValue<FHAManagementCounselType>> _fHAManagementCounselType;
        /// <summary>
        /// FHA Management Counsel Type [3062]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Counsel Type")]
        public StringEnumValue<FHAManagementCounselType> FHAManagementCounselType { get => _fHAManagementCounselType; set => SetField(ref _fHAManagementCounselType, value); }
        private DirtyValue<decimal?> _fHAMaxLoanAmount;
        /// <summary>
        /// FHA MCAW Max Loan Amt [1720]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Max Loan Amt")]
        public decimal? FHAMaxLoanAmount { get => _fHAMaxLoanAmount; set => SetField(ref _fHAMaxLoanAmount, value); }
        private DirtyValue<decimal?> _fHAMMI;
        /// <summary>
        /// Informed Consumer Choice FHA Monthly Mortgage Income [FICC.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Monthly Mortgage Income")]
        public decimal? FHAMMI { get => _fHAMMI; set => SetField(ref _fHAMMI, value); }
        private DirtyValue<decimal?> _fHAMonthlyPayment;
        /// <summary>
        /// Informed Consumer Choice FHA Monthly Payment [FICC.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Monthly Payment")]
        public decimal? FHAMonthlyPayment { get => _fHAMonthlyPayment; set => SetField(ref _fHAMonthlyPayment, value); }
        private DirtyValue<decimal?> _fHAMortgageAmount;
        /// <summary>
        /// Informed Consumer Choice FHA Mortgage Amount [FICC.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Mortgage Amount")]
        public decimal? FHAMortgageAmount { get => _fHAMortgageAmount; set => SetField(ref _fHAMortgageAmount, value); }
        private DirtyValue<decimal?> _fHAMortgageAmountUMIP;
        /// <summary>
        /// Informed Consumer Choice FHA Mortgage Amount with UMIP [FICC.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Mortgage Amount with UMIP")]
        public decimal? FHAMortgageAmountUMIP { get => _fHAMortgageAmountUMIP; set => SetField(ref _fHAMortgageAmountUMIP, value); }
        private DirtyValue<decimal?> _fHASalesPrice;
        /// <summary>
        /// Informed Consumer Choice FHA Sales Price [FICC.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Sales Price")]
        public decimal? FHASalesPrice { get => _fHASalesPrice; set => SetField(ref _fHASalesPrice, value); }
        private DirtyValue<decimal?> _fHAUMIP;
        /// <summary>
        /// Informed Consumer Choice FHA UMIP [FICC.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA UMIP")]
        public decimal? FHAUMIP { get => _fHAUMIP; set => SetField(ref _fHAUMIP, value); }
        private DirtyValue<int?> _fHAYearsMonthlyInsurance;
        /// <summary>
        /// Informed Consumer Choice FHA Max Years of Monthly Insurance Premium Payments [FICC.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice FHA Max Years of Monthly Insurance Premium Payments")]
        public int? FHAYearsMonthlyInsurance { get => _fHAYearsMonthlyInsurance; set => SetField(ref _fHAYearsMonthlyInsurance, value); }
        private DirtyValue<bool?> _foreclosedProperty;
        /// <summary>
        /// FHA Process Mgmt Foreclosed Property [3093]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Process Mgmt Foreclosed Property")]
        public bool? ForeclosedProperty { get => _foreclosedProperty; set => SetField(ref _foreclosedProperty, value); }
        private DirtyValue<StringEnumValue<FreddieMacCounselType>> _freddieMacCounselType;
        /// <summary>
        /// Freddie Mac Counsel Type [2847]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Counsel Type")]
        public StringEnumValue<FreddieMacCounselType> FreddieMacCounselType { get => _freddieMacCounselType; set => SetField(ref _freddieMacCounselType, value); }
        private DirtyValue<decimal?> _fundingFeePaidInCash;
        /// <summary>
        /// FHA Funding Fee Paid in Cash [1160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA Funding Fee Paid in Cash")]
        public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => SetField(ref _fundingFeePaidInCash, value); }
        private DirtyValue<decimal?> _giftFundsAmount;
        /// <summary>
        /// Trans Details Total Gift Funds Amt [220]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Total Gift Funds Amt")]
        public decimal? GiftFundsAmount { get => _giftFundsAmount; set => SetField(ref _giftFundsAmount, value); }
        private DirtyValue<bool?> _haveReceivedLeadPaintPoisoningInfo;
        /// <summary>
        /// HUD Rec Lead Paint Poisoning Info [1400]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Rec Lead Paint Poisoning Info")]
        public bool? HaveReceivedLeadPaintPoisoningInfo { get => _haveReceivedLeadPaintPoisoningInfo; set => SetField(ref _haveReceivedLeadPaintPoisoningInfo, value); }
        private DirtyValue<StringEnumValue<HUD1003AddendumApproved>> _hUD1003AddendumApproved;
        /// <summary>
        /// HUD 1003 Addendum Approved or Modified [3175]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Approved or Modified")]
        public StringEnumValue<HUD1003AddendumApproved> HUD1003AddendumApproved { get => _hUD1003AddendumApproved; set => SetField(ref _hUD1003AddendumApproved, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// FhaVaLoan Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<DateTime?> _lastRefiDate;
        /// <summary>
        /// FHA Management Last Refi Date [3057]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Last Refi Date")]
        public DateTime? LastRefiDate { get => _lastRefiDate; set => SetField(ref _lastRefiDate, value); }
        private DirtyValue<DateTime?> _lDPGSASearchDate;
        /// <summary>
        /// FHA Management LDP/GSA Search Date [3069]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management LDP/GSA Search Date")]
        public DateTime? LDPGSASearchDate { get => _lDPGSASearchDate; set => SetField(ref _lDPGSASearchDate, value); }
        private DirtyValue<string> _lDPGSASearchedBy;
        /// <summary>
        /// FHA Management LDP/GSA Searched By [3070]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management LDP/GSA Searched By")]
        public string LDPGSASearchedBy { get => _lDPGSASearchedBy; set => SetField(ref _lDPGSASearchedBy, value); }
        private DirtyValue<string> _lenderAddress;
        /// <summary>
        /// HUD 1003 Addendum Lender Addr [3633]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender Addr")]
        public string LenderAddress { get => _lenderAddress; set => SetField(ref _lenderAddress, value); }
        private DirtyValue<string> _lenderCity;
        /// <summary>
        /// HUD 1003 Addendum Lender City [3634]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender City")]
        public string LenderCity { get => _lenderCity; set => SetField(ref _lenderCity, value); }
        private DirtyValue<string> _lenderName;
        /// <summary>
        /// HUD 1003 Addendum Lender Co Name [3632]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender Co Name")]
        public string LenderName { get => _lenderName; set => SetField(ref _lenderName, value); }
        private DirtyValue<string> _lenderNMLS;
        /// <summary>
        /// HUD 1003 Addendum Lender Info NMLS [3637]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender Info NMLS")]
        public string LenderNMLS { get => _lenderNMLS; set => SetField(ref _lenderNMLS, value); }
        private DirtyValue<string> _lenderPostalCode;
        /// <summary>
        /// HUD 1003 Addendum Lender Zip [3636]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD 1003 Addendum Lender Zip")]
        public string LenderPostalCode { get => _lenderPostalCode; set => SetField(ref _lenderPostalCode, value); }
        private DirtyValue<string> _lenderRepresentativeName;
        /// <summary>
        /// HUD Lenders Rep Name [1754]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Lenders Rep Name")]
        public string LenderRepresentativeName { get => _lenderRepresentativeName; set => SetField(ref _lenderRepresentativeName, value); }
        private DirtyValue<string> _lenderRepresentativePhone;
        /// <summary>
        /// HUD Lenders Rep Phone [1756]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD Lenders Rep Phone")]
        public string LenderRepresentativePhone { get => _lenderRepresentativePhone; set => SetField(ref _lenderRepresentativePhone, value); }
        private DirtyValue<string> _lenderRepresentativeTitle;
        /// <summary>
        /// HUD Lenders Rep Title [1755]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Lenders Rep Title")]
        public string LenderRepresentativeTitle { get => _lenderRepresentativeTitle; set => SetField(ref _lenderRepresentativeTitle, value); }
        private DirtyValue<StringEnumValue<State>> _lenderState;
        /// <summary>
        /// HUD 1003 Addendum Lender State [3635]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender State")]
        public StringEnumValue<State> LenderState { get => _lenderState; set => SetField(ref _lenderState, value); }
        private DirtyValue<string> _lenderTaxID;
        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3638]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsor Agent Info Tax ID")]
        public string LenderTaxID { get => _lenderTaxID; set => SetField(ref _lenderTaxID, value); }
        private DirtyValue<string> _loanScoreID;
        /// <summary>
        /// FHA Management Loan Score ID [3630]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Loan Score ID")]
        public string LoanScoreID { get => _loanScoreID; set => SetField(ref _loanScoreID, value); }
        private DirtyValue<string> _mIAppliedBy;
        /// <summary>
        /// FHA Management MI Applied By [3087]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MI Applied By")]
        public string MIAppliedBy { get => _mIAppliedBy; set => SetField(ref _mIAppliedBy, value); }
        private DirtyValue<DateTime?> _mIAppliedDate;
        /// <summary>
        /// FHA Management MI Applied Date [3086]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MI Applied Date")]
        public DateTime? MIAppliedDate { get => _mIAppliedDate; set => SetField(ref _mIAppliedDate, value); }
        private DirtyValue<DateTime?> _mICRetrivedDate;
        /// <summary>
        /// FHA Management MIC Retrived Date [3089]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIC Retrived Date")]
        public DateTime? MICRetrivedDate { get => _mICRetrivedDate; set => SetField(ref _mICRetrivedDate, value); }
        private DirtyValue<decimal?> _minimumDownPayment;
        /// <summary>
        /// FHA MCAW Min Down Pymt [1117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Min Down Pymt")]
        public decimal? MinimumDownPayment { get => _minimumDownPayment; set => SetField(ref _minimumDownPayment, value); }
        private DirtyValue<DateTime?> _mIP1stDueDate;
        /// <summary>
        /// FHA Management MIP 1st Due Date [3083]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIP 1st Due Date")]
        public DateTime? MIP1stDueDate { get => _mIP1stDueDate; set => SetField(ref _mIP1stDueDate, value); }
        private DirtyValue<DateTime?> _mIP1stToInvestor;
        /// <summary>
        /// FHA Management MIP 1st To Investor [3085]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIP 1st To Investor")]
        public DateTime? MIP1stToInvestor { get => _mIP1stToInvestor; set => SetField(ref _mIP1stToInvestor, value); }
        private DirtyValue<DateTime?> _mIPRemittedDate;
        /// <summary>
        /// FHA Management MIP Periodic Remitted Date [3084]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIP Periodic Remitted Date")]
        public DateTime? MIPRemittedDate { get => _mIPRemittedDate; set => SetField(ref _mIPRemittedDate, value); }
        private DirtyValue<DateTime?> _mIRejectedDate;
        /// <summary>
        /// FHA Management MI Rejected Date [3088]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MI Rejected Date")]
        public DateTime? MIRejectedDate { get => _mIRejectedDate; set => SetField(ref _mIRejectedDate, value); }
        private DirtyValue<decimal?> _modifiedInterestRate;
        /// <summary>
        /// HUD 1003 Addendum Mod Interest Rate [3179]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HUD 1003 Addendum Mod Interest Rate")]
        public decimal? ModifiedInterestRate { get => _modifiedInterestRate; set => SetField(ref _modifiedInterestRate, value); }
        private DirtyValue<decimal?> _modifiedLoanAmount;
        /// <summary>
        /// HUD 1003 Addendum Mod Loan Amount [3178]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Loan Amount")]
        public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => SetField(ref _modifiedLoanAmount, value); }
        private DirtyValue<decimal?> _modifiedMonthlyPayment;
        /// <summary>
        /// HUD 1003 Addendum Mod Mthly Pymt [3182]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Mthly Pymt")]
        public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => SetField(ref _modifiedMonthlyPayment, value); }
        private DirtyValue<decimal?> _modifiedMonthlyPremium;
        /// <summary>
        /// HUD 1003 Addendum Mod Amt Mthly Premium [3184]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Amt Mthly Premium")]
        public decimal? ModifiedMonthlyPremium { get => _modifiedMonthlyPremium; set => SetField(ref _modifiedMonthlyPremium, value); }
        private DirtyValue<int?> _modifiedProposedMaturityMonth;
        /// <summary>
        /// HUD 1003 Addendum Mod Proposed Maturity Mth [3181]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mod Proposed Maturity Mth")]
        public int? ModifiedProposedMaturityMonth { get => _modifiedProposedMaturityMonth; set => SetField(ref _modifiedProposedMaturityMonth, value); }
        private DirtyValue<int?> _modifiedProposedMaturityYear;
        /// <summary>
        /// HUD 1003 Addendum Mod Proposed Maturity Yr [3180]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mod Proposed Maturity Yr")]
        public int? ModifiedProposedMaturityYear { get => _modifiedProposedMaturityYear; set => SetField(ref _modifiedProposedMaturityYear, value); }
        private DirtyValue<int?> _modifiedTermAnnualPremium;
        /// <summary>
        /// HUD 1003 Addendum Mod Term Annual Premium [3196]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mod Term Annual Premium")]
        public int? ModifiedTermAnnualPremium { get => _modifiedTermAnnualPremium; set => SetField(ref _modifiedTermAnnualPremium, value); }
        private DirtyValue<decimal?> _modifiedUpfrontPremium;
        /// <summary>
        /// HUD 1003 Addendum Mod Amt Up Front Premium [3183]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Amt Up Front Premium")]
        public decimal? ModifiedUpfrontPremium { get => _modifiedUpfrontPremium; set => SetField(ref _modifiedUpfrontPremium, value); }
        private DirtyValue<string> _mortgageeRepresentative;
        /// <summary>
        /// HUD 1003 Addendum Mortgagee Representative [3194]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mortgagee Representative")]
        public string MortgageeRepresentative { get => _mortgageeRepresentative; set => SetField(ref _mortgageeRepresentative, value); }
        private DirtyValue<StringEnumValue<DoesOrDoesNot>> _mortgageFinancialInterest;
        /// <summary>
        /// HUD Mtg Financial Interest Does/Does Not [153]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Mtg Financial Interest Does/Does Not")]
        public StringEnumValue<DoesOrDoesNot> MortgageFinancialInterest { get => _mortgageFinancialInterest; set => SetField(ref _mortgageFinancialInterest, value); }
        private DirtyValue<decimal?> _nonRealtyAndOtherItems;
        /// <summary>
        /// FHA MCAW Non-Realty/Other Items [1137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Non-Realty/Other Items")]
        public decimal? NonRealtyAndOtherItems { get => _nonRealtyAndOtherItems; set => SetField(ref _nonRealtyAndOtherItems, value); }
        private DirtyValue<DateTime?> _obtainCAIVRSDate;
        /// <summary>
        /// FHA Management Obtain CAIVRS Date [3067]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Obtain CAIVRS Date")]
        public DateTime? ObtainCAIVRSDate { get => _obtainCAIVRSDate; set => SetField(ref _obtainCAIVRSDate, value); }
        private DirtyValue<StringEnumValue<Occupancy>> _occupancy;
        /// <summary>
        /// Borr Cert Occupancy [1065]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Occupancy")]
        public StringEnumValue<Occupancy> Occupancy { get => _occupancy; set => SetField(ref _occupancy, value); }
        private DirtyValue<string> _oldAgencyCaseIdentifier;
        /// <summary>
        /// FHA Management Old Agency Case Identifier [3066]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Old Agency Case Identifier")]
        public string OldAgencyCaseIdentifier { get => _oldAgencyCaseIdentifier; set => SetField(ref _oldAgencyCaseIdentifier, value); }
        private DirtyValue<decimal?> _originalMortgageAmount;
        /// <summary>
        /// HUD Original Mtg Amt [744]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Original Mtg Amt")]
        public decimal? OriginalMortgageAmount { get => _originalMortgageAmount; set => SetField(ref _originalMortgageAmount, value); }
        private DirtyValue<decimal?> _otherLiabilitiesMonthlyPayment;
        /// <summary>
        /// Liabilities Other Mo Pymt [1648]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Other Mo Pymt")]
        public decimal? OtherLiabilitiesMonthlyPayment { get => _otherLiabilitiesMonthlyPayment; set => SetField(ref _otherLiabilitiesMonthlyPayment, value); }
        private DirtyValue<decimal?> _otherLiabilitiesUnpaidBalance;
        /// <summary>
        /// Liabilities Other Unpaid Bal [1649]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Other Unpaid Bal")]
        public decimal? OtherLiabilitiesUnpaidBalance { get => _otherLiabilitiesUnpaidBalance; set => SetField(ref _otherLiabilitiesUnpaidBalance, value); }
        private DirtyValue<decimal?> _otherMonthlyShelterExpense;
        /// <summary>
        /// VA Mo Shelter Exp Est Other [1348]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Mo Shelter Exp Est Other")]
        public decimal? OtherMonthlyShelterExpense { get => _otherMonthlyShelterExpense; set => SetField(ref _otherMonthlyShelterExpense, value); }
        private DirtyValue<string> _otherTitleDescription;
        /// <summary>
        /// VA Title Other Descr [1064]
        /// </summary>
        [LoanFieldProperty(Description = "VA Title Other Descr")]
        public string OtherTitleDescription { get => _otherTitleDescription; set => SetField(ref _otherTitleDescription, value); }
        private DirtyValue<bool?> _ownMoreThanFourDwellings;
        /// <summary>
        /// Borr Cert Own More than 4 [1017]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Own More than 4")]
        public bool? OwnMoreThanFourDwellings { get => _ownMoreThanFourDwellings; set => SetField(ref _ownMoreThanFourDwellings, value); }
        private DirtyValue<bool?> _ownOrSoldOtherRealEstate;
        /// <summary>
        /// Borr Cert Own/Sold Other than RE [900]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Own/Sold Other than RE")]
        public bool? OwnOrSoldOtherRealEstate { get => _ownOrSoldOtherRealEstate; set => SetField(ref _ownOrSoldOtherRealEstate, value); }
        private DirtyValue<decimal?> _paidAmount;
        /// <summary>
        /// FHA MCAW Paid Amt [201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Paid Amt")]
        public decimal? PaidAmount { get => _paidAmount; set => SetField(ref _paidAmount, value); }
        private DirtyValue<int?> _premiumMonths;
        /// <summary>
        /// HUD Premium # Mos [409]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Premium # Mos")]
        public int? PremiumMonths { get => _premiumMonths; set => SetField(ref _premiumMonths, value); }
        private DirtyValue<decimal?> _prepaidExpenses;
        /// <summary>
        /// FHA MCAW Prepaid Expenses [61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Prepaid Expenses")]
        public decimal? PrepaidExpenses { get => _prepaidExpenses; set => SetField(ref _prepaidExpenses, value); }
        private DirtyValue<DateTime?> _previousPurchaseDate;
        /// <summary>
        /// FHA Management Previous Purchase Date [3058]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Previous Purchase Date")]
        public DateTime? PreviousPurchaseDate { get => _previousPurchaseDate; set => SetField(ref _previousPurchaseDate, value); }
        private DirtyValue<DateTime?> _priorEndorsementDate;
        /// <summary>
        /// FHA Management Refi Authorization Prior Endorsement Date [3432]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Refi Authorization Prior Endorsement Date")]
        public DateTime? PriorEndorsementDate { get => _priorEndorsementDate; set => SetField(ref _priorEndorsementDate, value); }
        private DirtyValue<int?> _proposedMaturityMonths;
        /// <summary>
        /// HUD Maturity Mos [1392]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HUD Maturity Mos")]
        public int? ProposedMaturityMonths { get => _proposedMaturityMonths; set => SetField(ref _proposedMaturityMonths, value); }
        private DirtyValue<int?> _proposedMaturityYears;
        /// <summary>
        /// Trans Details Loan Term [1347]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Loan Term")]
        public int? ProposedMaturityYears { get => _proposedMaturityYears; set => SetField(ref _proposedMaturityYears, value); }
        private DirtyValue<StringEnumValue<FhaVaLoanPurposeOfLoan>> _purposeOfLoan;
        /// <summary>
        /// Trans Details Loan Purpose VA [28]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose VA")]
        public StringEnumValue<FhaVaLoanPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => SetField(ref _purposeOfLoan, value); }
        private DirtyValue<string> _refiAuthorizationBy;
        /// <summary>
        /// FHA Management Refi Authorization By [3065]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Refi Authorization By")]
        public string RefiAuthorizationBy { get => _refiAuthorizationBy; set => SetField(ref _refiAuthorizationBy, value); }
        private DirtyValue<DateTime?> _refiAuthorizationDate;
        /// <summary>
        /// FHA Management Refi Authorization Date [3064]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Refi Authorization Date")]
        public DateTime? RefiAuthorizationDate { get => _refiAuthorizationDate; set => SetField(ref _refiAuthorizationDate, value); }
        private DirtyValue<decimal?> _salesPrice;
        /// <summary>
        /// Borr Cert Other RE Sales Price [687]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Cert Other RE Sales Price")]
        public decimal? SalesPrice { get => _salesPrice; set => SetField(ref _salesPrice, value); }
        private DirtyValue<decimal?> _secondMortgageAmount;
        /// <summary>
        /// FHA MCAW 2nd Mtg Amt [1140]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW 2nd Mtg Amt")]
        public decimal? SecondMortgageAmount { get => _secondMortgageAmount; set => SetField(ref _secondMortgageAmount, value); }
        private DirtyValue<decimal?> _sellerPaidClosingCost;
        /// <summary>
        /// Fees Total FHA Closing Costs Seller [1131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total FHA Closing Costs Seller")]
        public decimal? SellerPaidClosingCost { get => _sellerPaidClosingCost; set => SetField(ref _sellerPaidClosingCost, value); }
        private DirtyValue<DateTime?> _servingTransferedDate;
        /// <summary>
        /// FHA Management Serving Transfered Date [3092]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Serving Transfered Date")]
        public DateTime? ServingTransferedDate { get => _servingTransferedDate; set => SetField(ref _servingTransferedDate, value); }
        private DirtyValue<decimal?> _specialAssessments;
        /// <summary>
        /// VA Mo Shelter Exp Est Special Asmts [1346]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Mo Shelter Exp Est Special Asmts")]
        public decimal? SpecialAssessments { get => _specialAssessments; set => SetField(ref _specialAssessments, value); }
        private DirtyValue<string> _sponsorAgentAddress;
        /// <summary>
        /// File Contacts Sponsor/Agent Street [1113]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent Street")]
        public string SponsorAgentAddress { get => _sponsorAgentAddress; set => SetField(ref _sponsorAgentAddress, value); }
        private DirtyValue<string> _sponsorAgentCity;
        /// <summary>
        /// File Contacts Sponsor/Agent City [1114]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent City")]
        public string SponsorAgentCity { get => _sponsorAgentCity; set => SetField(ref _sponsorAgentCity, value); }
        private DirtyValue<string> _sponsorAgentName;
        /// <summary>
        /// File Contacts Sponsor/Agent Name [1111]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent Name")]
        public string SponsorAgentName { get => _sponsorAgentName; set => SetField(ref _sponsorAgentName, value); }
        private DirtyValue<string> _sponsorAgentNMLS;
        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info NMLS [3640]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsor Agent Info NMLS")]
        public string SponsorAgentNMLS { get => _sponsorAgentNMLS; set => SetField(ref _sponsorAgentNMLS, value); }
        private DirtyValue<string> _sponsorAgentPostalCode;
        /// <summary>
        /// File Contacts Sponsor/Agent Zip [1744]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "File Contacts Sponsor/Agent Zip")]
        public string SponsorAgentPostalCode { get => _sponsorAgentPostalCode; set => SetField(ref _sponsorAgentPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _sponsorAgentState;
        /// <summary>
        /// File Contacts Sponsor/Agent State [1743]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent State")]
        public StringEnumValue<State> SponsorAgentState { get => _sponsorAgentState; set => SetField(ref _sponsorAgentState, value); }
        private DirtyValue<string> _sponsorAgentTaxID;
        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3641]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsor Agent Info Tax ID")]
        public string SponsorAgentTaxID { get => _sponsorAgentTaxID; set => SetField(ref _sponsorAgentTaxID, value); }
        private DirtyValue<string> _sponsoredOriginationsName;
        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations Name [3656]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsored Originations Name")]
        public string SponsoredOriginationsName { get => _sponsoredOriginationsName; set => SetField(ref _sponsoredOriginationsName, value); }
        private DirtyValue<string> _sponsoredOriginationsNMLS;
        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations NMLS ID [3657]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsored Originations NMLS ID")]
        public string SponsoredOriginationsNMLS { get => _sponsoredOriginationsNMLS; set => SetField(ref _sponsoredOriginationsNMLS, value); }
        private DirtyValue<string> _sponsoredOriginationsTaxID;
        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations Tax ID [3658]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsored Originations Tax ID")]
        public string SponsoredOriginationsTaxID { get => _sponsoredOriginationsTaxID; set => SetField(ref _sponsoredOriginationsTaxID, value); }
        private DirtyValue<string> _sponsorID;
        /// <summary>
        /// FHA Sponsor ID [1060]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Sponsor ID")]
        public string SponsorID { get => _sponsorID; set => SetField(ref _sponsorID, value); }
        private DirtyValue<StringEnumValue<TitleVestedIn>> _titleVestedIn;
        /// <summary>
        /// VA Title Vested In [1497]
        /// </summary>
        [LoanFieldProperty(Description = "VA Title Vested In")]
        public StringEnumValue<TitleVestedIn> TitleVestedIn { get => _titleVestedIn; set => SetField(ref _titleVestedIn, value); }
        private DirtyValue<bool?> _toBeSold;
        /// <summary>
        /// Borr Cert Other RE To Be Sold [933]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Other RE To Be Sold")]
        public bool? ToBeSold { get => _toBeSold; set => SetField(ref _toBeSold, value); }
        private DirtyValue<decimal?> _totalClosingCost;
        /// <summary>
        /// FHA MCAW Total Closing Cost [386]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Total Closing Cost")]
        public decimal? TotalClosingCost { get => _totalClosingCost; set => SetField(ref _totalClosingCost, value); }
        private DirtyValue<string> _totalScorecardBy;
        /// <summary>
        /// FHA Management Total Scorecard By [3072]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Total Scorecard By")]
        public string TotalScorecardBy { get => _totalScorecardBy; set => SetField(ref _totalScorecardBy, value); }
        private DirtyValue<DateTime?> _totalScorecardDate;
        /// <summary>
        /// FHA Management Total Scorecard Date [3071]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Total Scorecard Date")]
        public DateTime? TotalScorecardDate { get => _totalScorecardDate; set => SetField(ref _totalScorecardDate, value); }
        private DirtyValue<DateTime?> _uFMIPRemittanceDueDate;
        /// <summary>
        /// FHA Management UFMIP Remittance Due Date [3078]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Remittance Due Date")]
        public DateTime? UFMIPRemittanceDueDate { get => _uFMIPRemittanceDueDate; set => SetField(ref _uFMIPRemittanceDueDate, value); }
        private DirtyValue<decimal?> _uFMIPRemittedAmount;
        /// <summary>
        /// FHA Management UFMIP Remitted Amount [3081]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA Management UFMIP Remitted Amount")]
        public decimal? UFMIPRemittedAmount { get => _uFMIPRemittedAmount; set => SetField(ref _uFMIPRemittedAmount, value); }
        private DirtyValue<string> _uFMIPRemittedBy;
        /// <summary>
        /// FHA Management UFMIP Remitted By [3080]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Remitted By")]
        public string UFMIPRemittedBy { get => _uFMIPRemittedBy; set => SetField(ref _uFMIPRemittedBy, value); }
        private DirtyValue<DateTime?> _uFMIPRemittedDate;
        /// <summary>
        /// FHA Management UFMIP Remitted Date [3079]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Remitted Date")]
        public DateTime? UFMIPRemittedDate { get => _uFMIPRemittedDate; set => SetField(ref _uFMIPRemittedDate, value); }
        private DirtyValue<string> _uFMIPVerificationCode;
        /// <summary>
        /// FHA Management UFMIP Verification Code [3082]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Verification Code")]
        public string UFMIPVerificationCode { get => _uFMIPVerificationCode; set => SetField(ref _uFMIPVerificationCode, value); }
        private DirtyValue<bool?> _useDefaultLenderInfo;
        /// <summary>
        /// HUD 1003 Addendum Use Default Lender [3639]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Use Default Lender")]
        public bool? UseDefaultLenderInfo { get => _useDefaultLenderInfo; set => SetField(ref _useDefaultLenderInfo, value); }
        private DirtyValue<bool?> _utilityIncluded;
        /// <summary>
        /// Expenses Borr Mo Housing Exp Utiliy Incl [1087]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Borr Mo Housing Exp Utiliy Incl")]
        public bool? UtilityIncluded { get => _utilityIncluded; set => SetField(ref _utilityIncluded, value); }
        private DirtyValue<DateTime?> _validateAddressDate;
        /// <summary>
        /// FHA Management Address Validation Date [3060]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Address Validation Date")]
        public DateTime? ValidateAddressDate { get => _validateAddressDate; set => SetField(ref _validateAddressDate, value); }
        private DirtyValue<StringEnumValue<Valuation>> _valuation;
        /// <summary>
        /// Borr Cert Aware/Unaware of Valuation [1399]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Aware/Unaware of Valuation")]
        public StringEnumValue<Valuation> Valuation { get => _valuation; set => SetField(ref _valuation, value); }
    }
}