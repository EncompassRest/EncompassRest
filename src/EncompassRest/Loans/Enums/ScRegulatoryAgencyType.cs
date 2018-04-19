using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ScRegulatoryAgencyType
    /// </summary>
    public enum ScRegulatoryAgencyType
    {
        /// <summary>
        /// Consumer Financial Protection Bureau
        /// </summary>
        [EnumMember(Value = "Consumer Financial Protection Bureau")]
        ConsumerFinancialProtectionBureau = 0,
        /// <summary>
        /// Office of the Comptroller of the Currency
        /// </summary>
        [EnumMember(Value = "Office of the Comptroller of the Currency")]
        OfficeOfTheComptrollerOfTheCurrency = 1,
        /// <summary>
        /// Federal Reserve System
        /// </summary>
        [EnumMember(Value = "Federal Reserve System")]
        FederalReserveSystem = 2,
        /// <summary>
        /// Federal Deposit Insurance Corporation
        /// </summary>
        [EnumMember(Value = "Federal Deposit Insurance Corporation")]
        FederalDepositInsuranceCorporation = 3,
        /// <summary>
        /// National Credit Union Administration
        /// </summary>
        [EnumMember(Value = "National Credit Union Administration")]
        NationalCreditUnionAdministration = 4,
        /// <summary>
        /// South Carolina Board of Financial Institutions
        /// </summary>
        [EnumMember(Value = "South Carolina Board of Financial Institutions")]
        SouthCarolinaBoardOfFinancialInstitutions = 5,
        /// <summary>
        /// South Carolina Department of Consumer Affairs
        /// </summary>
        [EnumMember(Value = "South Carolina Department of Consumer Affairs")]
        SouthCarolinaDepartmentOfConsumerAffairs = 6,
        /// <summary>
        /// Consumer Finance Division
        /// </summary>
        [EnumMember(Value = "Consumer Finance Division")]
        ConsumerFinanceDivision = 7
    }
}