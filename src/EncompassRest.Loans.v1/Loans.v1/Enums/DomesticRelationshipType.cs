using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// DomesticRelationshipType
    /// </summary>
    public enum DomesticRelationshipType
    {
        /// <summary>
        /// Civil Union
        /// </summary>
        [Description("Civil Union")]
        CivilUnion = 0,
        /// <summary>
        /// Domestic Partnership
        /// </summary>
        [Description("Domestic Partnership")]
        DomesticPartnership = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2,
        /// <summary>
        /// Registered Reciprocal Beneficiary Relationship
        /// </summary>
        [Description("Registered Reciprocal Beneficiary Relationship")]
        RegisteredReciprocalBeneficiaryRelationship = 3
    }
}