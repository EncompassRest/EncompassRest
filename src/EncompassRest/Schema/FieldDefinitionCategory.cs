using System.Runtime.Serialization;

namespace EncompassRest.Schema
{
    public enum FieldDefinitionCategory
    {
        Alerts = 0,
        ARM = 1,
        Borrowers = 2,
        Database = 3,
        Lender = 4,
        Loan = 5,
        [EnumMember(Value = "Loan Folder")]
        LoanFolder = 6,
        [EnumMember(Value = "Loan Related Companies")]
        LoanRelatedCompanies = 7,
        Milestone = 8,
        Pipeline = 9,
        Ratios = 10,
        Servicing = 11,
        Trade = 12,
        [EnumMember(Value = "Borrower Contact")]
        BorrowerContact = 13,
        Opportunity = 14,
        [EnumMember(Value = "Recent Events")]
        RecentEvents = 15,
        Appointments = 16,
        [EnumMember(Value = "Business Contact")]
        BusinessContact = 17,
        BizPartnerCustomField = 18
    }
}