using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ScRegulatoryAgencyType
    {
        [EnumMember(Value = "Consumer Financial Protection Bureau")]
        ConsumerFinancialProtectionBureau = 0,
        [EnumMember(Value = "Office of the Comptroller of the Currency")]
        OfficeOfTheComptrollerOfTheCurrency = 1,
        [EnumMember(Value = "Federal Reserve System")]
        FederalReserveSystem = 2,
        [EnumMember(Value = "Federal Deposit Insurance Corporation")]
        FederalDepositInsuranceCorporation = 3,
        [EnumMember(Value = "National Credit Union Administration")]
        NationalCreditUnionAdministration = 4,
        [EnumMember(Value = "South Carolina Board of Financial Institutions")]
        SouthCarolinaBoardOfFinancialInstitutions = 5,
        [EnumMember(Value = "South Carolina Department of Consumer Affairs")]
        SouthCarolinaDepartmentOfConsumerAffairs = 6,
        [EnumMember(Value = "Consumer Finance Division")]
        ConsumerFinanceDivision = 7
    }
}