using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CreditorTypeDescription
    {
        [EnumMember(Value = "Community Development Financial Institution")]
        CommunityDevelopmentFinancialInstitution = 0,
        [EnumMember(Value = "Community Housing Development Organization")]
        CommunityHousingDevelopmentOrganization = 1,
        [EnumMember(Value = "Downpayment Assistance Provider")]
        DownpaymentAssistanceProvider = 2,
        [EnumMember(Value = "Nonprofit Organization")]
        NonprofitOrganization = 3
    }
}