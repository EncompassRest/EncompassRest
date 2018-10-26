using System.Runtime.Serialization;

namespace EncompassRest.Organizations
{
    public enum AtrExemptCreditors
    {
        [EnumMember(Value = "community development financial institution")]
        CommunityDevelopmentFinancialInstitution = 0,
        [EnumMember(Value = "community housing development organization")]
        CommunityHousingDevelopmentOrganization = 1,
        [EnumMember(Value = "down payment assistance provider")]
        DownPaymentAssistanceProvider = 2,
        [EnumMember(Value = "non-profit organization")]
        NonProfitOrganization = 3
    }
}