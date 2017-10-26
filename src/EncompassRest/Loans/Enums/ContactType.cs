using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ContactType
    {
        Undefined = 0,
        [EnumMember(Value = "LOAN_PROCESSOR")]
        LOANPROCESSOR = 1,
        [EnumMember(Value = "LOAN_OFFICER")]
        LOANOFFICER = 2,
        [EnumMember(Value = "BROKER_LENDER")]
        BROKERLENDER = 3,
        [EnumMember(Value = "BROKER_LENDERSsnCompanyAgent")]
        BROKERLENDERSsnCompanyAgent = 4,
        [EnumMember(Value = "BROKER_LENDERSsnCompany")]
        BROKERLENDERSsnCompany = 5,
        [EnumMember(Value = "LENDER_INVESTOR")]
        LENDERINVESTOR = 6,
        [EnumMember(Value = "APPRAISAL_COMPANY")]
        APPRAISALCOMPANY = 7,
        [EnumMember(Value = "ESCROW_COMPANY")]
        ESCROWCOMPANY = 8,
        [EnumMember(Value = "TITLE_COMPANY")]
        TITLECOMPANY = 9,
        [EnumMember(Value = "BUYERS_ATTORNEY")]
        BUYERSATTORNEY = 10,
        [EnumMember(Value = "SELLERS_ATTORNEY")]
        SELLERSATTORNEY = 11,
        [EnumMember(Value = "BUYERS_AGENT")]
        BUYERSAGENT = 12,
        [EnumMember(Value = "SELLERS_AGENT")]
        SELLERSAGENT = 13,
        SELLER = 14,
        SELLER2 = 15,
        SELLER3 = 16,
        SELLER4 = 17,
        BUILDER = 18,
        [EnumMember(Value = "HAZARD_INSURANCE")]
        HAZARDINSURANCE = 19,
        [EnumMember(Value = "MORTGAGE_INSURANCE")]
        MORTGAGEINSURANCE = 20,
        SURVEYOR = 21,
        [EnumMember(Value = "FLOOD_INSURANCE")]
        FLOODINSURANCE = 22,
        [EnumMember(Value = "CREDIT_COMPANY")]
        CREDITCOMPANY = 23,
        UNDERWRITER = 24,
        SERVICING = 25,
        [EnumMember(Value = "DOC_SIGNING")]
        DOCSIGNING = 26,
        WAREHOUSE = 27,
        [EnumMember(Value = "FINANCIAL_PLANNER")]
        FINANCIALPLANNER = 28,
        INVESTOR = 29,
        ASSIGNTO = 30,
        BROKER = 31,
        DOCSPREPAREDBY = 32,
        CUSTOM = 33,
        MORTGAGEE = 34,
        NOTARY = 35,
        [EnumMember(Value = "LOAN_CLOSER")]
        LOANCLOSER = 36,
        [EnumMember(Value = "LOAN_UNDERWRITER")]
        LOANUNDERWRITER = 37,
        [EnumMember(Value = "SETTLEMENT_AGENT")]
        SETTLEMENTAGENT = 38,
        ARCHITECT = 39,
        GENERALCONTRACTOR = 40,
        APPOINTMENTOFDESIGNEE = 41
    }
}