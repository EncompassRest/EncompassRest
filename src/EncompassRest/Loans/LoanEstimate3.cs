using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanEstimate3
    /// </summary>
    public sealed partial class LoanEstimate3 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<Appraisal>> _appraisal;
        /// <summary>
        /// Loan Estimate - Appraisal [LE3.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Appraisal")]
        public StringEnumValue<Appraisal> Appraisal { get => _appraisal; set => SetField(ref _appraisal, value); }
        private DirtyValue<StringEnumValue<Assumption>> _assumption;
        /// <summary>
        /// Loan Estimate - Assumption [LE3.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Assumption")]
        public StringEnumValue<Assumption> Assumption { get => _assumption; set => SetField(ref _assumption, value); }
        private DirtyValue<bool?> _constructionLoan;
        /// <summary>
        /// Loan Estimate - Construction Loan [LE3.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Construction Loan", OptionsJson = "{\"true\":\"Settlement will occur more than 60 days after initial disclosure.\"}")]
        public bool? ConstructionLoan { get => _constructionLoan; set => SetField(ref _constructionLoan, value); }
        private DirtyValue<bool?> _homeownerInsurance;
        /// <summary>
        /// Loan Estimate - Homeowner Insurance [LE3.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Homeowner Insurance", OptionsJson = "{\"true\":\"Omit from print\"}")]
        public bool? HomeownerInsurance { get => _homeownerInsurance; set => SetField(ref _homeownerInsurance, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanEstimate3 Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<int?> _in5YearsPrincipalYouWillHavePaidOff;
        /// <summary>
        /// Loan Estimate - In 5 years Principal you will have paid off [LE3.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - In 5 years Principal you will have paid off")]
        public int? In5YearsPrincipalYouWillHavePaidOff { get => _in5YearsPrincipalYouWillHavePaidOff; set => SetField(ref _in5YearsPrincipalYouWillHavePaidOff, value); }
        private DirtyValue<int?> _in5YearsTotalYouWillHavePaid;
        /// <summary>
        /// Loan Estimate - In 5 years Total you will have paid [LE3.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - In 5 years Total you will have paid")]
        public int? In5YearsTotalYouWillHavePaid { get => _in5YearsTotalYouWillHavePaid; set => SetField(ref _in5YearsTotalYouWillHavePaid, value); }
        private DirtyValue<string> _lenderEmail;
        /// <summary>
        /// Loan Estimate - Lender Email [LE3.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Lender Email")]
        public string LenderEmail { get => _lenderEmail; set => SetField(ref _lenderEmail, value); }
        private DirtyValue<string> _lenderLicenseID;
        /// <summary>
        /// Loan Estimate - Lender License ID [LE3.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Lender License ID")]
        public string LenderLicenseID { get => _lenderLicenseID; set => SetField(ref _lenderLicenseID, value); }
        private DirtyValue<StringEnumValue<State>> _lenderLicenseState;
        /// <summary>
        /// Loan Estimate - Lender License State [LE3.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Lender License State")]
        public StringEnumValue<State> LenderLicenseState { get => _lenderLicenseState; set => SetField(ref _lenderLicenseState, value); }
        private DirtyValue<string> _lenderLoanOfficer;
        /// <summary>
        /// Loan Estimate - Lender Loan Officer [LE3.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Lender Loan Officer")]
        public string LenderLoanOfficer { get => _lenderLoanOfficer; set => SetField(ref _lenderLoanOfficer, value); }
        private DirtyValue<StringEnumValue<State>> _lenderLoanOfficerLicenseState;
        /// <summary>
        /// Loan Estimate - Lender Loan Officer License State [LE3.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Lender Loan Officer License State")]
        public StringEnumValue<State> LenderLoanOfficerLicenseState { get => _lenderLoanOfficerLicenseState; set => SetField(ref _lenderLoanOfficerLicenseState, value); }
        private DirtyValue<string> _lenderLoanOfficerNMLSId;
        /// <summary>
        /// Loan Estimate - Lender Loan Officer NMLS ID [LE3.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Lender Loan Officer NMLS ID")]
        public string LenderLoanOfficerNMLSId { get => _lenderLoanOfficerNMLSId; set => SetField(ref _lenderLoanOfficerNMLSId, value); }
        private DirtyValue<string> _lenderPhone;
        /// <summary>
        /// Loan Estimate - Lender Phone [LE3.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Loan Estimate - Lender Phone")]
        public string LenderPhone { get => _lenderPhone; set => SetField(ref _lenderPhone, value); }
        private DirtyValue<string> _mortgageBrokerEmail;
        /// <summary>
        /// Loan Estimate - Mortgage Broker Email [LE3.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Broker Email")]
        public string MortgageBrokerEmail { get => _mortgageBrokerEmail; set => SetField(ref _mortgageBrokerEmail, value); }
        private DirtyValue<string> _mortgageBrokerLicenseID;
        /// <summary>
        /// Loan Estimate - Mortgage Broker License ID [LE3.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Broker License ID")]
        public string MortgageBrokerLicenseID { get => _mortgageBrokerLicenseID; set => SetField(ref _mortgageBrokerLicenseID, value); }
        private DirtyValue<StringEnumValue<State>> _mortgageBrokerLicenseState;
        /// <summary>
        /// Loan Estimate - Mortgage Broker License State [LE3.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Broker License State")]
        public StringEnumValue<State> MortgageBrokerLicenseState { get => _mortgageBrokerLicenseState; set => SetField(ref _mortgageBrokerLicenseState, value); }
        private DirtyValue<string> _mortgageBrokerLoanOfficer;
        /// <summary>
        /// Loan Estimate - Mortgage Broker Loan Officer [LE3.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Broker Loan Officer")]
        public string MortgageBrokerLoanOfficer { get => _mortgageBrokerLoanOfficer; set => SetField(ref _mortgageBrokerLoanOfficer, value); }
        private DirtyValue<string> _mortgageBrokerLoanOfficerLicenseID;
        /// <summary>
        /// Loan Estimate - Mortgage Broker Loan Officer License ID [LE3.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Broker Loan Officer License ID")]
        public string MortgageBrokerLoanOfficerLicenseID { get => _mortgageBrokerLoanOfficerLicenseID; set => SetField(ref _mortgageBrokerLoanOfficerLicenseID, value); }
        private DirtyValue<StringEnumValue<State>> _mortgageBrokerLoanOfficerLicenseState;
        /// <summary>
        /// Loan Estimate - Mortgage Broker Loan Officer License State [LE3.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Broker Loan Officer License State")]
        public StringEnumValue<State> MortgageBrokerLoanOfficerLicenseState { get => _mortgageBrokerLoanOfficerLicenseState; set => SetField(ref _mortgageBrokerLoanOfficerLicenseState, value); }
        private DirtyValue<string> _mortgageBrokerLoanOfficerNMLSId;
        /// <summary>
        /// Loan Estimate - Mortgage Broker Loan Officer NMLS ID [LE3.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Broker Loan Officer NMLS ID")]
        public string MortgageBrokerLoanOfficerNMLSId { get => _mortgageBrokerLoanOfficerNMLSId; set => SetField(ref _mortgageBrokerLoanOfficerNMLSId, value); }
        private DirtyValue<string> _mortgageBrokerPhone;
        /// <summary>
        /// Loan Estimate - Mortgage Broker Phone [LE3.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Loan Estimate - Mortgage Broker Phone")]
        public string MortgageBrokerPhone { get => _mortgageBrokerPhone; set => SetField(ref _mortgageBrokerPhone, value); }
        private DirtyValue<string> _mortgageLenderLoanOfficerLicenseID;
        /// <summary>
        /// Loan Estimate - Mortgage Lender Loan Officer License ID [LE3.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Mortgage Lender Loan Officer License ID")]
        public string MortgageLenderLoanOfficerLicenseID { get => _mortgageLenderLoanOfficerLicenseID; set => SetField(ref _mortgageLenderLoanOfficerLicenseID, value); }
        private DirtyValue<StringEnumValue<Servicing>> _servicing;
        /// <summary>
        /// Loan Estimate - Servicing [LE3.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Servicing")]
        public StringEnumValue<Servicing> Servicing { get => _servicing; set => SetField(ref _servicing, value); }
        private DirtyValue<StringEnumValue<SignatureType>> _signatureType;
        /// <summary>
        /// Loan Estimate - Signature Type [LE3.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Signature Type")]
        public StringEnumValue<SignatureType> SignatureType { get => _signatureType; set => SetField(ref _signatureType, value); }
        private DirtyValue<decimal?> _totalInterestPercentage;
        /// <summary>
        /// Loan Estimate - Total Interest Percentage [LE3.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Estimate - Total Interest Percentage")]
        public decimal? TotalInterestPercentage { get => _totalInterestPercentage; set => SetField(ref _totalInterestPercentage, value); }
        private DirtyValue<string> _totalInterestPercentageUI;
        /// <summary>
        /// Loan Estimate - Total Interest Percentage - Display fields with KBYO rounding rules [KBYO.LE3XD16]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Total Interest Percentage - Display fields with KBYO rounding rules")]
        public string TotalInterestPercentageUI { get => _totalInterestPercentageUI; set => SetField(ref _totalInterestPercentageUI, value); }
    }
}