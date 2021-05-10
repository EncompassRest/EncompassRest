using System.Runtime.Serialization;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// AtrExemptCreditors
    /// </summary>
    public enum AtrExemptCreditors
    {
        /// <summary>
        /// community development financial institution
        /// </summary>
        [EnumMember(Value = "community development financial institution")]
        CommunityDevelopmentFinancialInstitution = 0,
        /// <summary>
        /// community housing development organization
        /// </summary>
        [EnumMember(Value = "community housing development organization")]
        CommunityHousingDevelopmentOrganization = 1,
        /// <summary>
        /// down payment assistance provider
        /// </summary>
        [EnumMember(Value = "down payment assistance provider")]
        DownPaymentAssistanceProvider = 2,
        /// <summary>
        /// non-profit organization
        /// </summary>
        [EnumMember(Value = "non-profit organization")]
        NonProfitOrganization = 3
    }
}