using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CreditorTypeDescription
    /// </summary>
    public enum CreditorTypeDescription
    {
        /// <summary>
        /// Community Development Financial Institution
        /// </summary>
        [EnumMember(Value = "Community Development Financial Institution")]
        CommunityDevelopmentFinancialInstitution = 0,
        /// <summary>
        /// Community Housing Development Organization
        /// </summary>
        [EnumMember(Value = "Community Housing Development Organization")]
        CommunityHousingDevelopmentOrganization = 1,
        /// <summary>
        /// Downpayment Assistance Provider
        /// </summary>
        [EnumMember(Value = "Downpayment Assistance Provider")]
        DownpaymentAssistanceProvider = 2,
        /// <summary>
        /// Nonprofit Organization
        /// </summary>
        [EnumMember(Value = "Nonprofit Organization")]
        NonprofitOrganization = 3
    }
}