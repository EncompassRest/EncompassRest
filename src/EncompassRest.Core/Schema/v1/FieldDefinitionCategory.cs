using System.Runtime.Serialization;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// FieldDefinitionCategory
    /// </summary>
    public enum FieldDefinitionCategory
    {
        /// <summary>
        /// Alerts
        /// </summary>
        Alerts = 0,
        /// <summary>
        /// ARM
        /// </summary>
        ARM = 1,
        /// <summary>
        /// Borrowers
        /// </summary>
        Borrowers = 2,
        /// <summary>
        /// Database
        /// </summary>
        Database = 3,
        /// <summary>
        /// Lender
        /// </summary>
        Lender = 4,
        /// <summary>
        /// Loan
        /// </summary>
        Loan = 5,
        /// <summary>
        /// Loan Folder
        /// </summary>
        [EnumMember(Value = "Loan Folder")]
        LoanFolder = 6,
        /// <summary>
        /// Loan Related Companies
        /// </summary>
        [EnumMember(Value = "Loan Related Companies")]
        LoanRelatedCompanies = 7,
        /// <summary>
        /// Milestone
        /// </summary>
        Milestone = 8,
        /// <summary>
        /// Pipeline
        /// </summary>
        Pipeline = 9,
        /// <summary>
        /// Ratios
        /// </summary>
        Ratios = 10,
        /// <summary>
        /// Servicing
        /// </summary>
        Servicing = 11,
        /// <summary>
        /// Trade
        /// </summary>
        Trade = 12,
        /// <summary>
        /// Borrower Contact
        /// </summary>
        [EnumMember(Value = "Borrower Contact")]
        BorrowerContact = 13,
        /// <summary>
        /// Opportunity
        /// </summary>
        Opportunity = 14,
        /// <summary>
        /// Recent Events
        /// </summary>
        [EnumMember(Value = "Recent Events")]
        RecentEvents = 15,
        /// <summary>
        /// Appointments
        /// </summary>
        Appointments = 16,
        /// <summary>
        /// Business Contact
        /// </summary>
        [EnumMember(Value = "Business Contact")]
        BusinessContact = 17,
        /// <summary>
        /// BizPartnerCustomField
        /// </summary>
        BizPartnerCustomField = 18,
        /// <summary>
        /// Audit Trail
        /// </summary>
        [EnumMember(Value = "Audit Trail")]
        AuditTrail = 19,
        /// <summary>
        /// LoanProperties
        /// </summary>
        LoanProperties = 20
    }
}