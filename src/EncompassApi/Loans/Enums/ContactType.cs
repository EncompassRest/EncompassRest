using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ContactType
    /// </summary>
    public enum ContactType
    {
        /// <summary>
        /// Undefined
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// LOAN_PROCESSOR
        /// </summary>
        [EnumMember(Value = "LOAN_PROCESSOR")]
        LOANPROCESSOR = 1,
        /// <summary>
        /// LOAN_OFFICER
        /// </summary>
        [EnumMember(Value = "LOAN_OFFICER")]
        LOANOFFICER = 2,
        /// <summary>
        /// BROKER_LENDER
        /// </summary>
        [EnumMember(Value = "BROKER_LENDER")]
        BROKERLENDER = 3,
        /// <summary>
        /// BROKER_LENDERSsnCompanyAgent
        /// </summary>
        [EnumMember(Value = "BROKER_LENDERSsnCompanyAgent")]
        BROKERLENDERSsnCompanyAgent = 4,
        /// <summary>
        /// BROKER_LENDERSsnCompany
        /// </summary>
        [EnumMember(Value = "BROKER_LENDERSsnCompany")]
        BROKERLENDERSsnCompany = 5,
        /// <summary>
        /// LENDER_INVESTOR
        /// </summary>
        [EnumMember(Value = "LENDER_INVESTOR")]
        LENDERINVESTOR = 6,
        /// <summary>
        /// APPRAISAL_COMPANY
        /// </summary>
        [EnumMember(Value = "APPRAISAL_COMPANY")]
        APPRAISALCOMPANY = 7,
        /// <summary>
        /// ESCROW_COMPANY
        /// </summary>
        [EnumMember(Value = "ESCROW_COMPANY")]
        ESCROWCOMPANY = 8,
        /// <summary>
        /// TITLE_COMPANY
        /// </summary>
        [EnumMember(Value = "TITLE_COMPANY")]
        TITLECOMPANY = 9,
        /// <summary>
        /// BUYERS_ATTORNEY
        /// </summary>
        [EnumMember(Value = "BUYERS_ATTORNEY")]
        BUYERSATTORNEY = 10,
        /// <summary>
        /// SELLERS_ATTORNEY
        /// </summary>
        [EnumMember(Value = "SELLERS_ATTORNEY")]
        SELLERSATTORNEY = 11,
        /// <summary>
        /// BUYERS_AGENT
        /// </summary>
        [EnumMember(Value = "BUYERS_AGENT")]
        BUYERSAGENT = 12,
        /// <summary>
        /// SELLERS_AGENT
        /// </summary>
        [EnumMember(Value = "SELLERS_AGENT")]
        SELLERSAGENT = 13,
        /// <summary>
        /// SELLER
        /// </summary>
        SELLER = 14,
        /// <summary>
        /// SELLER2
        /// </summary>
        SELLER2 = 15,
        /// <summary>
        /// SELLER3
        /// </summary>
        SELLER3 = 16,
        /// <summary>
        /// SELLER4
        /// </summary>
        SELLER4 = 17,
        /// <summary>
        /// BUILDER
        /// </summary>
        BUILDER = 18,
        /// <summary>
        /// HAZARD_INSURANCE
        /// </summary>
        [EnumMember(Value = "HAZARD_INSURANCE")]
        HAZARDINSURANCE = 19,
        /// <summary>
        /// MORTGAGE_INSURANCE
        /// </summary>
        [EnumMember(Value = "MORTGAGE_INSURANCE")]
        MORTGAGEINSURANCE = 20,
        /// <summary>
        /// SURVEYOR
        /// </summary>
        SURVEYOR = 21,
        /// <summary>
        /// FLOOD_INSURANCE
        /// </summary>
        [EnumMember(Value = "FLOOD_INSURANCE")]
        FLOODINSURANCE = 22,
        /// <summary>
        /// CREDIT_COMPANY
        /// </summary>
        [EnumMember(Value = "CREDIT_COMPANY")]
        CREDITCOMPANY = 23,
        /// <summary>
        /// UNDERWRITER
        /// </summary>
        UNDERWRITER = 24,
        /// <summary>
        /// SERVICING
        /// </summary>
        SERVICING = 25,
        /// <summary>
        /// DOC_SIGNING
        /// </summary>
        [EnumMember(Value = "DOC_SIGNING")]
        DOCSIGNING = 26,
        /// <summary>
        /// WAREHOUSE
        /// </summary>
        WAREHOUSE = 27,
        /// <summary>
        /// FINANCIAL_PLANNER
        /// </summary>
        [EnumMember(Value = "FINANCIAL_PLANNER")]
        FINANCIALPLANNER = 28,
        /// <summary>
        /// INVESTOR
        /// </summary>
        INVESTOR = 29,
        /// <summary>
        /// ASSIGNTO
        /// </summary>
        ASSIGNTO = 30,
        /// <summary>
        /// BROKER
        /// </summary>
        BROKER = 31,
        /// <summary>
        /// DOCSPREPAREDBY
        /// </summary>
        DOCSPREPAREDBY = 32,
        /// <summary>
        /// CUSTOM
        /// </summary>
        CUSTOM = 33,
        /// <summary>
        /// MORTGAGEE
        /// </summary>
        MORTGAGEE = 34,
        /// <summary>
        /// NOTARY
        /// </summary>
        NOTARY = 35,
        /// <summary>
        /// LOAN_CLOSER
        /// </summary>
        [EnumMember(Value = "LOAN_CLOSER")]
        LOANCLOSER = 36,
        /// <summary>
        /// LOAN_UNDERWRITER
        /// </summary>
        [EnumMember(Value = "LOAN_UNDERWRITER")]
        LOANUNDERWRITER = 37,
        /// <summary>
        /// SETTLEMENT_AGENT
        /// </summary>
        [EnumMember(Value = "SETTLEMENT_AGENT")]
        SETTLEMENTAGENT = 38,
        /// <summary>
        /// ARCHITECT
        /// </summary>
        ARCHITECT = 39,
        /// <summary>
        /// GENERALCONTRACTOR
        /// </summary>
        GENERALCONTRACTOR = 40,
        /// <summary>
        /// APPOINTMENTOFDESIGNEE
        /// </summary>
        APPOINTMENTOFDESIGNEE = 41
    }
}